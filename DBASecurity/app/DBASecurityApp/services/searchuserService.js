(function () {

    var injectParams = ['$http', '$rootScope'];

    var titleFactory = function ($http, $rootScope) {
        var serviceBase = '/api/SearchUser/'

        factory = {};

        factory.GetEnvironments = function () {
            return $http.get(serviceBase).then(
                function (results) {
                    return results.data;
                });
        };

        return factory;
    };

    titleFactory.$inject = injectParams;

    angular.module('DBASecurityApp').factory('searchuserService', titleFactory);

}());

