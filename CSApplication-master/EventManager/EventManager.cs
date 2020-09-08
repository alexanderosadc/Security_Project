using System;

namespace PoliciesManager.EventManager
{
    public static class EventManager
    {

        public delegate void StartingDownloadEventHandler(EventArgs args);
        public delegate void FinishDownloadEventHandler(EventArgs args);
        public delegate void InProgressDownloadEventHanled(int progress);

        public static event StartingDownloadEventHandler StartDownloading;
        public static event FinishDownloadEventHandler FinishDownloading;
        public static event InProgressDownloadEventHanled DownloadingInProgress;

        public static void OnFinishDownloading()
        {
            if(FinishDownloading != null)
            {
                FinishDownloading(EventArgs.Empty);
            }
        }

        public static void OnStartDownloading()
        {
            if (StartDownloading != null)
            {
                StartDownloading(EventArgs.Empty);
            }
        }

        public static void OnDownloading(int progress)
        {
            if(DownloadingInProgress != null)
            {
                DownloadingInProgress(progress);
            }
        }
    }
}
