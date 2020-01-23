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
            Properties.Settings1.Default.nextUpdTime = DateTime.Now;

            if (Logic.isTimeToUpdate())
            {
                string nextWallpaper = Logic.SelectNextWallpaper();
                if (nextWallpaper != null)
                    Win32.SetWallpaper(nextWallpaper);
                Logic.SetNextUpdateTime();
                Logic.CreateSheduledTask();
            }
            if (args.Length == 0)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainWindow());
            }
        }
    }
}
