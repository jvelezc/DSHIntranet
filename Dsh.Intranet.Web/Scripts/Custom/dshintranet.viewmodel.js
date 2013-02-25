/// <reference path="../lib/jquery-1.9.1.js" />
/// <reference path="../lib/jquery.ba-hashchange.min.js" />
/// <reference path="../lib/knockout-2.0.0.js" />
/// <reference path="../lib/koExternalTemplateEngine_all.js" />
/// <reference path="dshintranet.dataservice.js" />
/// <reference path="dshintranet.viewmodel.js" />
/// <reference path="dshintranet.model.js" />
/// <reference path="dshintranet.serializer.js" />

my.viewModel = function () {

    security = ko.observableArray([]),
    isBusy = ko.observable();
    currentPage = ko.observable();

    submitContactForm = function () {
        // Submit ajax call to controller for email submission
        var hasError = false;
        var emailReg = /^([\w-\.]+@([\w-]+\.)+[\w-]{2,4})?$/;

        var name = $('#name').val();
        var email = $('#email').val();
        var message = $('#text').val();

        if (name == '') {
            hasError = true;
        };

        if (email == '') {
            hasError = true;
        };

        if (!emailReg.test(email)) {
            hasError = true;
        };

        if (text == '') {
            hasError = true;
        };

        if (hasError) {
            alert("Invalid Submission! Please ensure a valid email address has been entered, and that all other fields have been entered correctly.");
        }
        else {
            var mailMessage = { name: name, email: email, message: message };

            // Send email  
            my.dataService.sendMail(mailMessage, function (data) {
                alert("Your message has been sent successfully. Thank You.");
            });
        }
    }

    return {
        security: security,
        currentPage: currentPage,
        isBusy: isBusy,
    }
}();