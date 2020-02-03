using System;
using System.Windows.Forms;

namespace WallpapersRun
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            //Update();
            if (args.Length == 0)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainWindow());
            }
        }

        public static void Update()
        {
            if (Logic.isTimeToUpdate())
            {
                string nextWallpaper = Logic.SelectNextWallpaper();
                if (nextWallpaper != null)
                    Win32.SetWallpaper(nextWallpaper);
                Logic.SetNextUpdateTime();
                Properties.Settings1.Default.Save();
                Logic.CreateSheduledTask();
            }
        }
    }
}
