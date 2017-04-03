define(["angularAMD",
    "angular",
    "bootstrap",
    "jquery",
    "material",
    "ripples",
    "contentMainController",
    "contentMainDirective"], function (angularAMD) {
        var app = angular.module("EssApp", []);

        return angularAMD.bootstrap(app);
    });