using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace DownloadingManager
{
    public static class CustomEventController
    {
        public delegate void StartingDownloadEventHandler(string message);

        public static event StartingDownloadEventHandler downloadEvent;

        public static void OnStartDownloading()
        {
            if(downloadEvent != null)
            {
                downloadEvent("Download");
            }
        }

    }
}
