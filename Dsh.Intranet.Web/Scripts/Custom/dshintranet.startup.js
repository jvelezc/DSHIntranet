/// <reference path="../lib/jquery-1.9.1.js" />
/// <reference path="../lib/jquery.ba-hashchange.min.js" />
/// <reference path="../lib/knockout-2.0.0.js" />
/// <reference path="../lib/koExternalTemplateEngine_all.js" />
/// <reference path="dshintranet.dataservice.js" />
/// <reference path="dshintranet.viewmodel.js" />
/// <reference path="dshintranet.model.js" />
/// <reference path="dshintranet.serializer.js" />

my.dataService = new function () {

    //getSecurity
    getSecurity = function (callback) {
        $.getJSON('/api/security', function (data) {
            callback(data);
        });
    },

    //addSecurity
    addSecurity = function (article, callback) {
        $.ajax({
            url: '/api/security',
            type: 'POST',
            contentType: 'application/json; charset=utf-8',
            data: article,
            success: callback(status)
        });
    },

    //editSecurity
    editSecurity = function (article, callback) {
        $.ajax({
            url: '/api/security',
            type: 'PUT',
            contentType: 'application/json; charset=utf-8',
            data: article,
            success: callback(status)
        });
    },

    //deleteSecurity
    deleteSecurity = function (article, callback) {
        $.ajax({
            url: '/api/security',
            type: 'PUT',
            contentType: 'application/json; charset=utf-8',
            data: article,
            success: callback(status)
        });
    },

    //sendMail
    //IMPORTANT: JSON.Stringify finally sent it correctly. You must parse JS objects to JSON objest before send to controller method
    sendMail = function (mailMessage, callback) {
        $.ajax({
            url: '/api/utility/sendmail',
            type: 'POST',
            contentType: 'application/json; charset=utf-8',
            data: JSON.stringify(mailMessage),
            dataType: "json",
            success: callback(status)
        });
    }

    return {
        // Public methods exposed using revealing module pattern
        getSecurity: getSecurity,
        addSecurity: addSecurity,
        editSecurity: editSecurity,
        deleteSecurity: deleteSecurity,
        sendMail: sendMail
    };
}();