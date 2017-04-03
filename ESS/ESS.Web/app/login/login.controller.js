define(["angularAMD"],
    function (angularAMD) {

        angularAMD
            .controller("loginController", loginController);

        loginController.$inject = ["$scope"];

        function loginController(scope) {
            var vm = this;
            $.material.init();
        };

    });