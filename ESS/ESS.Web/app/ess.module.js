define(["angularAMD",
    "angular",
    "bootstrap",
    "jquery",
    "material",
    "ripples",
    "contentMainController",
    "contentMainDirective",
    "loginController",
    "loginDirective"], function (angularAMD) {
        var app = angular.module("EssApp", []);

        return angularAMD.bootstrap(app);
    });