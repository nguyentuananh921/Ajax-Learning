showInPopup = (url, title) => {
    $.ajax({
        type: "GET",
        url: url,
        success: function (res) {
            $("#layout-form-modal .modal-body").html(res);
            $("#layout-form-modal .modal-title").html(title);
            $("#layout-form-modal").modal('show');
            //// to make popup draggable
            //$('.modal-dialog').draggable({
            //    handle: ".modal-header"
            //});
        }
    })
}
jQueryAjaxPost = form => {

    try {
        $.ajax({
            type: "POST",
            url: form.action,
            data: new FormData(form),
            contentType: false,
            processData: false,
            success: function (res) {
                if (res.isValid) {
                    $("#transaction-view-all").html(res.html); //Update the div have Id=transaction-view-all
                    //Clear content of the div have id=layout-form-modal
                    $("#layout-form-modal .modal-body").html('');
                    $("#layout-form-modal .modal-title").html('');
                    $("#layout-form-modal").modal('hide');
                    //$.notify('Submited successfully', { globalPosition: 'top center', classname='success' });
                }
                else {
                    $("#layout-form-modal .modal-body").html(res.html); //Update modal-body part of the div have Id=layout-form-modal
                }

            },
            error: function (err) {
                console.log(err);
            }

        })
        //to prevent default form submit event
        return false;
        }
    catch (e) {
            console.log(e);
        }
}
jQueryAjaxDelete = form => {
    if (confirm('Are you sure to delete this record ?')) {
        try {
            $.ajax({
                type: 'POST',
                url: form.action,
                data: new FormData(form),
                contentType: false,
                processData: false,
                success: function (res) {
                    $('#view-all').html(res.html);
                    //$.notify('Delete successfully', { globalPosition: 'top center', classname='success' });
                },
                error: function (err) {
                    console.log(err)
                }
            })
        } catch (ex) {
            console.log(ex)
        }
    }

    //prevent default form submit event
    return false;
}

