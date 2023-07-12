function ItemController() {

    var self = this;

    var baseUrl = "/api/saleApi"
    self.Items = ko.observableArray();
    self.newItem = ko.observable(new ItemModel());

    self.Customers = ko.observableArray();
    self.newCustomer = ko.observable(new CustomerModel());
    self.grandtotal = ko.observable(55);
//    self.Items().forEach((item) =>
//        self.grandTotal(self.grandTotal() + item.total)
    

//);

    self.addItem = function () {
        console.log(self.newItem());
        self.Items.push(ko.toJS(self.newItem()));
        self.newItem(new ItemModel());
    }
    //self.master = ko.observable({
    //    ko.toJS(self.newCustomer())
    //});
    self.test = function () {
        var data = {
            customer: ko.toJSON(self.newCustomer()),
            items: self.Items()
        }
        console.log("ok");
        console.log(data);
        ajax.post(baseUrl, data);
    };
}


//self.Checkout = function () {

//    ajax.post(baseUrl, (data()))
//        .done(
//            (rs) => {
        
             
//            }).fail((err) => {
//                console.log(err);
//            });


//}

var ajax = {
    get: function (url, data) {
        return $.ajax({
            method: "GET",
            url: url,

        });
    }
    ,
    post: function (url, data) {

        return $.ajax({
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            },
            method: "POST",
            url: url,
            data: (data)
        });
    },
    put: function (url, data) {
        return $.ajax({
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            },
            method: "PUT",
            url: url,
            data: data
        });
    },
    delete: function (url) {
        //api/apiController/id
        return $.ajax({
            method: "DELETE",
            url: url

        });

    }
}



//{
//    "customer": {
//        "name": "string",
//            "address": "string",
//                "phoneNo": "string"
//    },
//    "items": [
//        {
//            "name": "string",
//            "price": 0,
//            "discount": 0,
//            "quantity": 0,
//            "total": 0
//        }
//    ]
//