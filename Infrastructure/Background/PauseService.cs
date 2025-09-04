namespace Infrastructure.Background
{
    public class PauseService
    {
        private volatile bool _paused;
        public bool IsPaused => _paused;

        public void Pause()  => _paused = true;
        public void Resume() => _paused = false;
    }
}
