(function () {
    var app = angular.module("SearchUserApp", []);
    app.controller("SearchUserController", function ($scope, $http) {

        $scope.orderBy = 'AccountName';
        $scope.txtAccountName = '';

        $http.get('/api/Environment').
          success(function (data, status, headers, config) {
              $scope.environments = data;
          }).
          error(function (data, status, headers, config) {
              alert("error : " + data.error);
          });

        $scope.setOrder = function (orderColumn) {
            $scope.orderBy = orderColumn;
        };

        $scope.searchUsers = function () {
            $http.get('/api/Account/GetAccountsInEnv?envId=' + $scope.ddlEnvironment + '&AccountName=' + $scope.txtAccountName).
              success(function (data, status, headers, config) {
                  $scope.orderBy = 'AccountName';
                  $scope.accounts = data;
              }).
              error(function (data, status, headers, config) {
                  alert("error : " + data.error);
              });
        }
    });
}());