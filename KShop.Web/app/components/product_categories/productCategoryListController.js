﻿/// <reference path="../../../assets/admin/libs/angular/angular.js" />

(function (app) {
    app.controller('productCategoryListController', productCategoryListController);
    productCategoryListController.$inject = ['$scope', 'apiService'];

    function productCategoryListController($scope, apiService) {
        $scope.productCategories = [];
        $scope.getProductCategories = getProductCategories;
        $scope.page = 0;
        $scope.pagesCount = 0;

        function getProductCategories(page) {
            page = page || 0;
            var config = {
                params: {
                    page: page,
                    pageSize: 2
                }
            }

            apiService.get("/api/productcategory/getall", config, function (result) {
                console.log(result.data);
                $scope.productCategories = result.data.Items;
                $scope.page = result.data.Page;
                $scope.totalCount = result.data.TotalCount;
                $scope.pagesCount = result.data.TotalPages;
            }, function () {
                    console.log("load product category failed");
            });
        }

        $scope.getProductCategories();

    }
})(angular.module("kshop.product_categories"));