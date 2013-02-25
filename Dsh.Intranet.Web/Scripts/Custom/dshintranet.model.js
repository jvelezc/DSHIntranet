/// <reference path="../lib/jquery-1.9.1.js" />
/// <reference path="../lib/jquery.ba-hashchange.min.js" />
/// <reference path="../lib/knockout-2.0.0.js" />
/// <reference path="../lib/koExternalTemplateEngine_all.js" />
/// <reference path="dshintranet.dataservice.js" />
/// <reference path="dshintranet.viewmodel.js" />
/// <reference path="dshintranet.model.js" />
/// <reference path="dshintranet.serializer.js" />

my.model = function () {

    // Create client side model objects

    Security = function () {
        var self = this;
        self.securityid = ko.observable();
        self.username = ko.observable();
        self.password = ko.observable();
    }

    return {
        Security: Security
    }
}();