function refreshAddOrEditTab(resetUrl, showViewTab) {
    $.ajax({
        type: 'GET',
        url: resetUrl,
        success: function (response) {
            $("#AddOrEditTab").html(response);
            $('ul.nav.nav-tabs a:eq(1)').html('Add New');
            if (showViewTab)
                $('ul.nav.nav-tabs a:eq(0)').tab('show');
        }

    });
    //prevent default form submit event
    return false;
}
jQueryAjaxEmployeePost(form)
{
    $.validator.unobtrusive.parse(form);//Make sure all the validator have been check before post.
    if ($(form).valid())
    {
        var ajaxConfig = {
            type: 'POST',
            url: form.action,
            data: new FormData(form),       
            success: function (response) {
                $("#ViewAllEmployeeTab").html(response)
            }
        }

        if ($(form).attr('enctype') == "multipart/form-data") {
            ajaxConfig["contentType"] = false;
            ajaxConfig["processData"] = false;
        }

        ajax(ajaxConfig);
    }   
    //prevent default form submit event
    return false;
}
function Edit(url) {
    $.ajax({
        type: 'GET',
        url: url,
        success: function (response) {
            $("#AddOrEditEmployee-tab").html(response);
            $('ul.nav.nav-tabs a:eq(1)').html('Edit');
            $('ul.nav.nav-tabs a:eq(1)').tab('show');
        }

    });
    //prevent default form submit event
    return false;
}
