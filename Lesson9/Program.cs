namespace Lesson9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Проверка решения задачи 1
            Vehicle vVehicle = new Vehicle() { MaxSpeed = 40, Weight = 27};
            Vehicle vTruck = new Truck() { MaxSpeed = 80, Weight = 3000, Carrying = 1000};
            Truck trTruck = new Truck() { MaxSpeed = 60, Weight = 4000, Carrying = 2000 };
            Vehicle vCar = new Car() { MaxSpeed = 210, Weight = 1700, FuelType = "Disel", NumberOfDoors = 5};
            Car cCar = new Car() { MaxSpeed = 240, Weight = 1300, FuelType = "Gasoline", NumberOfDoors = 3 };
            Vehicle eVihecle = new ElectricCar() { MaxSpeed = 170, Weight = 1400, ChargeLevel = 50, FuelType = "Electro", NumberOfDoors = 5, MaxDistanceSingleCharge = 200 };
            Car eCar = new ElectricCar() { MaxSpeed = 210, Weight = 1200, ChargeLevel = 70, FuelType = "Electro", NumberOfDoors = 3, MaxDistanceSingleCharge = 350 };
            ElectricCar eElectric = new ElectricCar() { MaxSpeed = 20, Weight = 25, ChargeLevel = 99, FuelType = "Electro", NumberOfDoors = 0, MaxDistanceSingleCharge = 15 };

            Console.WriteLine(" Vehicle vVehicle = new Vehicle()");
            vVehicle.DisplayInfo();
            Console.WriteLine(" Vehicle vTruck = new Truck()");
            vTruck.DisplayInfo();
            Console.WriteLine(" Truck trTruck = new Truck()");
            trTruck.DisplayInfo();
            Console.WriteLine(" Vehicle vCar = new Car()");
            vCar.DisplayInfo();
            Console.WriteLine(" Car cCar = new Car()");
            cCar.DisplayInfo();
            Console.WriteLine(" Vehicle eVihecle = new ElectricCar()");
            eVihecle.DisplayInfo();
            Console.WriteLine(" Car eCar = new ElectricCar()");
            eCar.DisplayInfo();
            Console.WriteLine(" ElectricCar eElectric = new ElectricCar()");
            eElectric.DisplayInfo();
            //Проверка решение задачи 2

        }
    }
}