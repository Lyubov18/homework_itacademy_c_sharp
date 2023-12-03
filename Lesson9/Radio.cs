namespace Lesson9
{
    public class Radio : MultimediaDevice, IMultimediaDevice<MultimediaDevice>
    {
        public Radio()
        {
            Name = "Radio";
        }

        public Radio(string name)
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
                Console.WriteLine("Не найдено ни одной радиостанции");
            }
            else
            {
                Console.WriteLine($"Станция: {ContentList[ContentId - 1]}{Environment.NewLine}" +
                                  $"Статус Radio: {State}");
            }
        }
    }
}
