using Microsoft.VisualBasic.FileIO;

namespace Lesson9
{
    public class MultimediaDevicePlayer
    {
        private List<IMultimediaDevice<MultimediaDevice>>? _devices;

        public List<IMultimediaDevice<MultimediaDevice>>? Devices
        {
            get;
            set;
        }

        public void AddDevice(IMultimediaDevice<MultimediaDevice> device)
        {
            if (_devices == null)
            {
                _devices = new List<IMultimediaDevice<MultimediaDevice>>() { device };
            }
            else
            {
                _devices.Add(device);
            }
        }

        public void RemoveDevice(IMultimediaDevice<MultimediaDevice> device)
        {
            if (_devices == null)
            {
                Console.WriteLine("Нет ни одного устройства");
            }
            else
            {
                _devices.Remove(device);
            }
        }

        public void ManageDevices()
        {
            if (_devices == null)
            {
                Console.WriteLine("Нет ни одного устройства. Сначала подключите устройство");
            }
            else
            {
                int devicesNumber = _devices.Count;
                Console.WriteLine("Выберите устройство для управления:");
                for (int i = 0; i < devicesNumber; i++)
                {
                    Console.WriteLine($"{i + 1} - {_devices[i].Name}");
                }
                if (int.TryParse(Console.ReadLine(), out int n))
                {
                    if (n <= devicesNumber & n >= 1)
                    {
                        _devices[n - 1].ManageDevice((MultimediaDevice)_devices[n - 1]);
                    }
                    else
                    {
                        Console.WriteLine($"Выберите устройство из диапазона от {1} до {devicesNumber}");
                    }
                }
                else
                {
                    Console.WriteLine($"Выберите номер устройства");
                }
            }
        }
    }
}
