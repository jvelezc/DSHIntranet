/// <reference path="../lib/jquery-1.9.1.js" />
/// <reference path="../lib/jquery.ba-hashchange.min.js" />
/// <reference path="../lib/knockout-2.0.0.js" />
/// <reference path="../lib/koExternalTemplateEngine_all.js" />
/// <reference path="dshintranet.dataservice.js" />
/// <reference path="dshintranet.viewmodel.js" />
/// <reference path="dshintranet.model.js" />
/// <reference path="dshintranet.serializer.js" />

// Runs after the DOM is loaded automatically
$(function () {
    // Chad Corrin, Coalinga State Hospital, 2/22/13 - SPA Hash Navigation system for knockout template switching 
    // Get and set viewmodel page with the hash of the current window on page load
    var hash = document.URL.substr(document.URL.indexOf('#') + 1);

    if (hash == "Home" || hash == "About" || hash == "Photos" || hash == "News" || hash == "Videos" || hash == "Music" || hash == "Tour" || hash == "Contact" || hash == "EPK") {
        my.viewModel.currentPage(hash + "Template");
    }
    else {
        my.viewModel.currentPage("HomeTemplate");
    }

    // Set isBusy flag while loading data
    my.viewModel.isBusy(true);

    // Apply viewModel bindings
    ko.applyBindings(my.viewModel);

    // Run after all ajax calls have completed
    $(document).ajaxStop(function () {
        $(this).unbind("ajaxStop");

    });

    // Update current page property in the viewModel when the hash change event is fired
    $(window).hashchange(function () {
        hash = document.URL.substr(document.URL.indexOf('#') + 1);

        if (hash == "Home" || hash == "About" || hash == "Photos" || hash == "News" || hash == "Videos" || hash == "Music" || hash == "Tour" || hash == "Contact" || hash == "EPK") {
            my.viewModel.currentPage(hash + "Template");
        }
        else {
            my.viewModel.currentPage("HomeTemplate");
        }
    });

    // Load security data  
    my.dataService.getSecurity(function (data) {
        $.each(data, function (index, item) {
            my.viewModel.security.push(new my.model.Security()
                .securityid(item.securityID)
                .username(item.userName)
                .password(item.password)
                );
        })
    });
})


