showInPopup = (url, title) => {
    $.ajax({
        type: "GET",
        url: url,
        success: function (res) {
            $("#form-modal .modal-body").html(res);
            $("#form-modal .modal-title").html(title);
            $("#form-modal").modal('show');
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
                    $("#view-all").html(res);
                    $("#form-modal").modal('hide');
                    //Clear form-modal
                    $("#form-modal .modal-body").html('');
                    $("#form-modal .modal-title").html('');

                }
                else {
                    $("#form-modal .modal-body").html(res.html);
                }
            },
            error: function (err) {
                console.log(err)
            }
        })
        //To prevent default form submit event
        return false;
    }    catch (e){
        console.log(e);
    }
}
