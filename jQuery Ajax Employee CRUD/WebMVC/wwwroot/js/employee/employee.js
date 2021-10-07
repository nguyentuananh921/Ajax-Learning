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
}
jQueryAjaxEmployeePost(form)
{
    $.validator.unobtrusive.parse(form);//Make sure all the validator have been check before post.
    if($(form).validator)
}
