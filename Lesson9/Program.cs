namespace Lesson9
{
    internal class Program
    {
        static void Main()
        {
            //Проверка решения задачи 1
            Vehicle vVehicle = new Vehicle() { MaxSpeed = 40, Weight = 27 };
            Vehicle vTruck = new Truck() { MaxSpeed = 80, Weight = 3000, Carrying = 1000 };
            Truck trTruck = new Truck() { MaxSpeed = 60, Weight = 4000, Carrying = 2000 };
            Vehicle vCar = new Car() { MaxSpeed = 210, Weight = 1700, FuelType = "Disel", NumberOfDoors = 5 };
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
            IMultimediaDevice<MultimediaDevice> radio = new Radio() { ContentList = new List<string>() { "Станция 1", "Станция 2", "Станция 3" } };
            radio.Play();
            radio.ManageDevice((MultimediaDevice)radio);
            IMultimediaDevice<MultimediaDevice> mp3 = new MP3Player() { ContentList = new List<string>() { "Песня 1", "Песня 2", "Песня 3" } };
            mp3.Play();
            mp3.ManageDevice((MultimediaDevice)mp3);
            IMultimediaDevice<MultimediaDevice> dvd = new DVDPlayer() { ContentList = new List<string>() { "Видео 1", "Видео 2", "Видео 3" } };
            dvd.Play();
            dvd.ManageDevice((MultimediaDevice)dvd);

            MultimediaDevicePlayer Room1 = new MultimediaDevicePlayer();
            Room1.AddDevice(mp3);
            Room1.AddDevice(dvd);
            Room1.AddDevice(radio);
            Room1.ManageDevices();
            Room1.ManageDevices();
            Room1.ManageDevices();
        }
    }
}