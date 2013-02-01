using System;

namespace soundRecordingTest
{
#if WINDOWS || XBOX
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            using (SoundRecording game = new SoundRecording())
            {
                game.Run();
            }
        }
    }
#endif
}

