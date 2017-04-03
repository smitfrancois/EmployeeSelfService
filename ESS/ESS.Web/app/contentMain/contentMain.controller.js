define(["angularAMD"],
    function(angularAMD) {

        angularAMD
            .controller("contentMainController", contentMainController);

        contentMainController.$inject = ["$scope"];

        function contentMainController(scope) {
            var vm = this;

        };

    });