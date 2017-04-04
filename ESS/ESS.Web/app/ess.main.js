require.config({
    baseUrl: "",
    paths: {
        "angular": "scripts/angular",
        "angularAMD": "scripts/angularAMD",
        "bootstrap": "scripts/bootstrap",
        "jquery": "scripts/jquery-1.9.1",
        "material": "scripts/material/material.min",
        "ripples":"scripts/material/ripples.min",
        "contentMainController": "app/contentMain/contentMain.controller",
        "contentMainDirective": "app/contentMain/contentMain.directive",
        "loginController": "app/login/login.controller",
        "loginDirective":"app/login/login.directive"
    },
    shim: {
        "angular": "angular",
        "material": { exports: "material", deps: ["jquery"] },
        "ripples":{exports:"ripples",deps:["material"]},
        "bootstrap": { deps: ["jquery"] }

    },
    deps: ["app/ess.module"]
});