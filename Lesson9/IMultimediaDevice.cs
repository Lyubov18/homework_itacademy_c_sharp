namespace Lesson9
{
    public interface IMultimediaDevice
    {
        public int VolumeLevel { get; set; }
        public int State { get; set; }
        public string ContentId { get; set; }

        public void Play();
        public void Stop();
        public void Pause();
        public void Next();
        public void IncreaseVolume();
        public void DecreaseVolume();
    }
}
