(function () {

    var app = angular.module('DBASecurityApp',
        ['ngRoute', 'ui.bootstrap']);

    app.config(['$routeProvider', function ($routeProvider) {
        var viewBase = '/app/DBASecurityApp/views/';

        $routeProvider
            .when('/searchuser', {
                controller: 'searchController',
                templateUrl: viewBase + 'searchuser/searchuser.html'
            })
            .otherwise({ redirectTo: '/searchuser' });
    }]);
}());

