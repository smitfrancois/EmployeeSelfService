define(["angularAMD"],
    function (angularAMD) {

        angularAMD
            .directive("mainPageContainer", mainPageContainer);

        function mainPageContainer() {
            var directive = {
                restrict: "E",
                controller: "mainPageContainerController",
                controllerAs: "mainPageContainerCtrl",
                bindToController: true,
                link: link,
                templateUrl: "app/mainPageContainer/mainPageContainerView.html"
            };

            return directive;

            function link(scope, el, attr, ctrl) {

            };
        };

    });