namespace Lesson9
{
    public interface IMultimediaDevice<in T>
    {
        int VolumeLevel { get; set; }
        string State { get; set; }
        List<string>? ContentList { get; set; }
        int ContentId { get; set; }
        string Name { get; set; }

        void Play();
        void Stop();
        void Pause();
        void Next();
        void IncreaseVolume();
        void DecreaseVolume();
        public void ManageDevice(T device);
    }
}
