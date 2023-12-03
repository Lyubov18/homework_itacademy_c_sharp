namespace Lesson9
{
    public class DVDPlayer : MultimediaDevice, IMultimediaDevice<MultimediaDevice>
    {
        public DVDPlayer()
        {   
            Name = "DVDPlayer";
        }

        public DVDPlayer(string name)
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
                Console.WriteLine("Нет видео для воспроизведения");
            }
            else
            {
                Console.WriteLine($"Видео: {ContentList[ContentId - 1]}{Environment.NewLine}" +
                                  $"Статус DVD: {State}");
            }
        }
    }
}
