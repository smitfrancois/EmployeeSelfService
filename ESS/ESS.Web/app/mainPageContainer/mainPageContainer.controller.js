define(["angularAMD"],
    function (angularAMD) {

    	angularAMD
            .controller("mainPageContainerController", mainPageContainerController);

    	mainPageContainerController.$inject = ["$scope"];

    	function mainPageContainerController(scope) {
    		var vm = this;
    		$.material.init();
    	};

    });