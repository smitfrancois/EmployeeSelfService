define(["angularAMD"],
    function (angularAMD) {

        angularAMD
            .directive("login", login);

        function login() {
            var directive = {
                restrict: "E",
                controller: "loginController",
                controllerAs: "loginCtrl",
                bindToController: true,
                link: link,
                templateUrl: "app/login/loginView.html"
            };

            return directive;

            function link(scope, el, attr, ctrl) {

            };
        };

    });