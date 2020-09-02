using System;
using System.Collections.Generic;
using System.Text;

namespace DownloadingManager
{
    public class EventManager
    {
        public static EventManager Current;
        public delegate void StartingDownloadEventHandler(object source, EventArgs args);

        public event StartingDownloadEventHandler startDownloading;

        EventManager()
        {
            if(Current == null)
            {
                Current = this;
            }
        }

        protected virtual void OnStartDownloading()
        {
            if(startDownloading != null)
            {
                startDownloading(this, EventArgs.Empty);
            }
        }
    }
}
