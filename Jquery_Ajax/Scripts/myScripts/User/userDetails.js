$(document).ready(function () {

    // Show the alert box with User Id
    $('#show-alert').on('click', function () {
        var UserId = $("#user-id").val();
        alert("Entered User Id :" + UserId);
    });

    //Make a ajax call with
    $("#make-ajax-call").on('click', function (ev) {
        var UserId = $("#user-id").val();
        $.ajax({
            url: "/User/GetUserDetails",
            data: { 'userId': UserId },
            success: function (data) {
                console.log(data);

                $('#user-firstname').val(data.userModal.FirstName);
                console.log("FirstName: " + $('#user-firstname').val());
               
                $('#user-lastname').val(data.userModal.LastName);
                console.log("LastName: " + $('#user-lastname').val());
            }
        });
        // avoid to execute the actual submit of the form.
        ev.preventDefault();
    });


    // Fade the background and show the modal
    $('#show-modal').on('click', function () {
        $.data('target', '#SimpleModal');
        $('#SimpleModal').modal('show');
    });
});



