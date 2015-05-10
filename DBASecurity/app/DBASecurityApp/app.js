(function () {
    
    var app = angular.module('DBASecurityApp',
        ['ngRoute', 'ngAnimate', 'ui.bootstrap']);
    
    app.config(['$routeProvider', function ($routeProvider) {
        var viewBase = '/app/DBASecurityApp/views/';
 
        $routeProvider
            .when('/searchuser', {
                controller: 'searchuserController',
                templateUrl: viewBase + 'searchuser/searchuser.html'
            })
            .otherwise({ redirectTo: '/' });
    }]);
}());

