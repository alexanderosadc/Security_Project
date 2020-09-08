using System;

namespace PoliciesManager.EventManager
{
    public static class EventManager
    {

        public delegate void StartingDownloadEventHandler(EventArgs args);
        public delegate void FinishDownloadEventHandler(EventArgs args);
        public delegate void InProgressDownloadEventHanled(int progress);

        public static event StartingDownloadEventHandler startDownloading;
        public static event FinishDownloadEventHandler finishDownloading;
        public static event InProgressDownloadEventHanled downloadingInProgress;

        public static void OnFinishDownloading()
        {
            if(finishDownloading != null)
            {
                finishDownloading(EventArgs.Empty);
            }
        }

        public static void OnStartDownloading()
        {
            if (startDownloading != null)
            {
                startDownloading(EventArgs.Empty);
            }
        }

        public static void OnDownloading(int progress)
        {
            if(downloadingInProgress != null)
            {
                downloadingInProgress(progress);
            }
        }
    }
}
