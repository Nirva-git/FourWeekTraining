class Car{
    make: string;
    model: string;
    year: number;

    constructor(make :string, model: string, year: number){
        this.make= make;
        this.model=model;
        this.year= year;
    }

    displayCarInfo(x: string): void {
        const carInfoDiv = document.getElementById(x);
        if (carInfoDiv) {
          carInfoDiv.innerHTML = `${this.make} ${this.model} (${this.year})`;
        }
    }
}
    const car1 = new Car("Toyota", "Corolla", 2022);
    const car2 = new Car("Honda", "Civic", 2021);

    car1.displayCarInfo("carInfo");
    car2.displayCarInfo("carInfo1");
        