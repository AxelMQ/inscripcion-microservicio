// Infrastructure/Background/PauseJobsFilter.cs
using Hangfire.Server;

namespace Infrastructure.Background
{
    public class PauseJobsFilter : IServerFilter
    {
        private readonly PauseService _pause;
        public PauseJobsFilter(PauseService pause) => _pause = pause;

        public void OnPerforming(PerformingContext ctx)
        {
            if (_pause.IsPaused)
            {
                // Evita ejecutar el job; queda re-encolado sin contarse como fallo
                ctx.Canceled = true;
            }
        }

        public void OnPerformed(PerformedContext ctx) { }
    }
}
