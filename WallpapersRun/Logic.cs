using Microsoft.Win32.TaskScheduler;
using System;
using System.IO;

namespace WallpapersRun
{
    class Logic
    {
        static readonly string taskSheldurerPath = "WallpapersSequence\\WallpaperChange";

        public static bool isTimeToUpdate()
        {
            if (Properties.Settings1.Default.nextUpdTime <= DateTime.Now)
                return true;
            else
                return false;
        }

        public static string SelectNextWallpaper()
        {
            string currentWallpaperName = Win32.GetWallpaper().Name;
            FileInfo[] allWallpapers;
            try
            {
                allWallpapers = new DirectoryInfo(Properties.Settings1.Default.wallpapersPath).GetFiles();
            }
            catch
            {
                return null;
            }
            if (allWallpapers.Length == 0)
            {
                Console.WriteLine("No wallpapers in directory " + Properties.Settings1.Default.wallpapersPath);
                return null;
            }
            string nextWalpaperPath = allWallpapers[0].FullName;
            for (int i = 0; i < allWallpapers.Length; i++)
            {
                if (allWallpapers[i].Name.Equals(currentWallpaperName))
                {
                    if (i < allWallpapers.Length - 1)
                        nextWalpaperPath = allWallpapers[i + 1].FullName;
                    else
                        nextWalpaperPath = allWallpapers[0].FullName;
                    break;
                }
            }
            return nextWalpaperPath;
        }

        public static void SetNextUpdateTime()
        {
            if (Properties.Settings1.Default.isDailyUpd)
                Properties.Settings1.Default.nextUpdTime = Properties.Settings1.Default.nextUpdTime.Add(Properties.Settings1.Default.updInterval);
            else
                Properties.Settings1.Default.nextUpdTime = DateTime.Now.Add(Properties.Settings1.Default.updInterval);
            Properties.Settings1.Default.Save();
        }

        public static void CreateSheduledTask()
        {
            TaskDefinition taskDefinition = TaskService.Instance.NewTask();
            taskDefinition.Principal.LogonType = TaskLogonType.InteractiveToken;

            taskDefinition.RegistrationInfo.Description = "Changes your wallpaper to next in list when the designated time comes";

            taskDefinition.Triggers.Add(new TimeTrigger(Properties.Settings1.Default.nextUpdTime));
            //taskDefinition.Triggers.Add(new TimeTrigger(DateTime.Now.AddMinutes(1)));
            taskDefinition.Actions.Add(new ExecAction(System.Reflection.Assembly.GetExecutingAssembly().Location, "-s", null));

            taskDefinition.Settings.DisallowStartIfOnBatteries = false;
            taskDefinition.Settings.StopIfGoingOnBatteries = false;
            taskDefinition.Settings.StartWhenAvailable = true;

            TaskService.Instance.RootFolder.RegisterTaskDefinition(taskSheldurerPath, taskDefinition);
        }
    }
}
