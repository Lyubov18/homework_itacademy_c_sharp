using System.ComponentModel.Design;

namespace Lesson9
{
    public class MultimediaDevice : IMultimediaDevice<MultimediaDevice>
    {
        private string _name = "Device";
        private int _volumeLevel = 10;
        private string _state = "Stopped";
        private List<string>? _contentList = new();
        private int _contentId = 1;

        public int VolumeLevel
        {
            get => _volumeLevel;
            set
            {
                if (value > 100)
                {
                    _volumeLevel = 100;
                }
                else if (value < 0)
                {
                    _volumeLevel = 0;
                }
                else
                {
                    _volumeLevel = value;
                }
            }
        }
        public string Name
        {
            get => _name;
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    _name = value;
                }
            }
        }
        public string State 
        {
            get => _state;
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    if (value == "Stopped" || value == "Paused" || value == "Playing")
                    { 
                        _state = value;
                    }
                }
            }
        }
        public List<string>? ContentList
        { 
            get => _contentList;
            set 
            {
                if (value == null || value.Count == 0)
                {
                    State = "Stopped";
                }
                else 
                {
                    _contentList = value;
                    ContentId = 1;
                }
            } 
        }
        public int ContentId
        {
            get => _contentId;
            set
            {
                if ( ContentList == null)
                {
                    State = "Stopped";
                }
                else if (value > ContentList.Count)
                {
                    _contentId = ContentList.Count;
                    State = "Paused";
                }
                else if (value < 1)
                {
                    _contentId = 1;
                    State = "Paused";
                }
                else 
                {
                    _contentId = value;
                }
            }
        }

        public void DecreaseVolume()
        {
           VolumeLevel -= 1;
           Console.WriteLine($"Громкость уменьшена. Значение: {VolumeLevel}");
        }

        public void IncreaseVolume()
        {
            VolumeLevel += 1;
            Console.WriteLine($"Громкость увеличена. Значение: {VolumeLevel}");
        }

        public virtual void Next()
        {
            ContentId += 1;
            if (ContentList == null)
            {
                Console.WriteLine("Нет композиций для воспроизведения");
            }
            else
            {
                Console.WriteLine($"Контент: {ContentList[ContentId - 1]}{Environment.NewLine}" +
                                  $"Статус устройства: {State}");
            }            
        }

        public void Pause()
        {
            if (State == "Playing")
            {
                State = "Paused";
                Console.WriteLine($"Статус устройства: {State}");
            }            
        }

        public void Play()
        {
            if (ContentList == null)
            {
                Console.WriteLine($"Нечего воспроизводить");
            }
            else if (State == "Paused" || State == "Stopped")
            {
                State = "Playing";
                Console.WriteLine($"Воспроизводится: {ContentList[ContentId - 1]}{Environment.NewLine}" +
                              $"Статус устройства: {State}");
            }            
        }

        public void Stop()
        {
            if (State == "Playing" || State == "Paused")
            {
                State = "Stopped";
                Console.WriteLine($"Статус устройства: {State}");
            }            
        }

        public void ManageDevice(MultimediaDevice device)
        {
            int n = 1;
            while (n != 0)
            {
                Console.WriteLine($"Что сделать с устройством?{Environment.NewLine} 1 - Проигрывать{Environment.NewLine}" +
                                                                            $" 2 - Остановить воспроизведение{Environment.NewLine}" +
                                                                            $" 3 - Пауза{Environment.NewLine}" +
                                                                            $" 4 - Следующий{Environment.NewLine}" +
                                                                            $" 5 - Увеличить громкость{Environment.NewLine}" +
                                                                            $" 6 - Уменьшить громкость{Environment.NewLine}" +
                                                                            $" 0 - Выход{Environment.NewLine}"); ;
                if (int.TryParse(Console.ReadLine(), out n))
                {
                    switch (n)
                    {
                        case 1:
                            device.Play();
                            break;
                        case 2:
                            device.Stop();
                            break;
                        case 3:
                            device.Pause();
                            break;
                        case 4:
                            device.Next();
                            break;
                        case 5:
                            device.IncreaseVolume();
                            break;
                        case 6:
                            device.DecreaseVolume();
                            break;
                        case 0:
                            break;
                        default:
                            Console.WriteLine($"Введенное значение некорректно, повторите попытку{Environment.NewLine}");
                            break;
                    }
                }
                else
                {
                    n = 1;
                }
            }
        }
    }
}
