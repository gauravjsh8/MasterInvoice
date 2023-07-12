﻿/// <reference path="../../knockout.js" />



function CustomerModel(item) {
    var self = this;
    item = item || {};
    self.id = ko.observable(item.id || 0);
    self.name = ko.observable(item.name || '');
    self.address = ko.observable(item.address || '');
    self.phoneNo = ko.observable(item.phoneNo || '');

}