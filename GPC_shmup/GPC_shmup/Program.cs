using System;

namespace GPC_shmup
{
#if WINDOWS || XBOX
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            using (GameRun game = new GameRun())
            {
                game.Run();
            }
        }
    }
#endif
}

