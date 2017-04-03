define(["angularAMD"],
    function(angularAMD) {

        angularAMD
            .directive("contentMain", contentMain);

        function contentMain() {
            var directive = {
                restrict: "E",
                controller: "contentMainController",
                controllerAs: "contentMainCtrl",
                bindToController: true,
                link: link,
                templateUrl:"app/contentMain/contentMainView.html"
            };

            return directive;

            function link(scope, el, attr, ctrl) {
                
            };
        };

    });