"use strict";
var Car = /** @class */ (function () {
    function Car(make, model, year) {
        this.make = make;
        this.model = model;
        this.year = year;
    }
    Car.prototype.displayCarInfo = function (x) {
        var carInfoDiv = document.getElementById(x);
        if (carInfoDiv) {
            carInfoDiv.innerHTML = "".concat(this.make, " ").concat(this.model, " (").concat(this.year, ")");
        }
    };
    return Car;
}());
var car1 = new Car("Toyota", "Corolla", 2022);
var car2 = new Car("Honda", "Civic", 2021);
car1.displayCarInfo("carInfo");
car2.displayCarInfo("carInfo1");
//# sourceMappingURL=Exe3.js.map