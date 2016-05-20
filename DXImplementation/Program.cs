using System;

namespace DXImplementation
{
#if WINDOWS || LINUX
    /// <summary>
    /// The main class.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Runs the DesktopGL implementation using DirectX Dlls (Sorry!)
            using (var game = new Engine.Game())
                game.Run();
        }
    }
#endif
}
