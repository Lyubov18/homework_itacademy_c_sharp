namespace Lesson9
{
    public class MP3Player : MultimediaDevice, IMultimediaDevice<MultimediaDevice>
    {
        public MP3Player()
        {
            Name = "MP3Player";
        }

        public MP3Player(string name)
        {
            {
                Name = name;
            }
        }

        public override void Next()
        {
            ContentId += 1;
            if (ContentList == null)
            {
                Console.WriteLine("Нет мелодий для воспроизведения");
            }
            else
            {
                Console.WriteLine($"Мелодия: {ContentList[ContentId - 1]}{Environment.NewLine}" +
                                  $"Статус MP3Player: {State}");
            }
        }

        public new void ManageDevice(MultimediaDevice device)
        {
            int n = 1;
            while (n != 0)
            {
                Console.WriteLine($"Что сделать с MP3 Player?{Environment.NewLine} 1 - Проигрывать{Environment.NewLine}" +
                                                                            $" 2 - Остановить воспроизведение{Environment.NewLine}" +
                                                                            $" 3 - Пауза{Environment.NewLine}" +
                                                                            $" 4 - Следующий{Environment.NewLine}" +
                                                                            $" 5 - Уведичить громккость{Environment.NewLine}" +
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
