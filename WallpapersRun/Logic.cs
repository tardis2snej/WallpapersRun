﻿using Microsoft.Win32.TaskScheduler;
using System;
using System.IO;

namespace WallpapersRun
{
    class Logic
    {
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
            DateTime newTime;
            if (Properties.Settings1.Default.isDailyUpd)
            {
                DateTime oldTime = Properties.Settings1.Default.lastUpdSetTo;
                DateTime newTimePrev = new DateTime(
                    DateTime.Now.Year,
                    DateTime.Now.Month,
                    DateTime.Now.Day,
                    Properties.Settings1.Default.updInterval.Hours,
                    Properties.Settings1.Default.updInterval.Minutes,
                    00);
                newTimePrev = newTimePrev.AddDays(1);
                newTime = newTimePrev;
                if (oldTime == newTimePrev && oldTime.Month == 12)
                {
                    newTime = newTime.AddYears(1);
                    newTime = newTime.AddMonths(-12);
                }
                if (oldTime == newTimePrev && (oldTime.Day == 28 || oldTime.Day == 29 || oldTime.Day == 30 || oldTime.Day == 31))
                {
                    newTime = newTime.AddDays(-1 * (oldTime.Day - 1));
                    newTime = newTime.AddMonths(1);
                }
            }
            else
            {
                newTime = DateTime.Now.Add(Properties.Settings1.Default.updInterval);
                newTime = newTime.Subtract(new TimeSpan(00, 00, newTime.Second));
                if (newTime < DateTime.Now)
                    newTime.AddMinutes(1);
            }
            Properties.Settings1.Default.lastUpdSetTo = Properties.Settings1.Default.nextUpdTime;
            Properties.Settings1.Default.nextUpdTime = newTime;
        }

        public static void CreateSheduledTask()
        {
            TaskDefinition taskDefinition = TaskService.Instance.NewTask();
            taskDefinition.Principal.LogonType = TaskLogonType.InteractiveToken;

            taskDefinition.RegistrationInfo.Description = "Changes your wallpaper to next in list when the designated time comes";

            taskDefinition.Triggers.Add(new TimeTrigger(Properties.Settings1.Default.nextUpdTime));
            taskDefinition.Actions.Add(new ExecAction(System.Reflection.Assembly.GetExecutingAssembly().Location, "-s", null));

            taskDefinition.Settings.DisallowStartIfOnBatteries = false;
            taskDefinition.Settings.StopIfGoingOnBatteries = false;
            taskDefinition.Settings.StartWhenAvailable = true;

            TaskService.Instance.RootFolder.RegisterTaskDefinition(Properties.Settings1.Default.taskSheldurerPath, taskDefinition);
        }
    }
}
