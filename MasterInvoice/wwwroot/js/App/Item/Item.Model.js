/// <reference path="../../knockout.js" />

function ItemModel(item) {
    var self = this;
    item = item || {};
    self.id = ko.observable(item.id || 0);
    self.name = ko.observable(item.name || '');
    self.price = ko.observable(item.price || 0.0);
    self.quantity = ko.observable(item.quantity || '');
    self.discount = ko.observable(item.discount || 0);
    self.total = ko.computed(function () {
        return (self.price() * self.quantity()) - self.discount();
    });
    self.customerId = ko.observable(item.customerId);

}