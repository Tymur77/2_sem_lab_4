using AppKit;
using Foundation;

using System;

namespace Plotter
{
    [Register("AppDelegate")]
    public class AppDelegate : NSApplicationDelegate
    {
        public AppDelegate()
        {
        }

        public override void DidFinishLaunching(NSNotification notification)
        {
            // Insert code here to initialize your application
            NSEvent.AddLocalMonitorForEventsMatchingMask(NSEventMask.KeyDown, e =>
            {
                if (e.KeyCode == 36 || e.KeyCode == 76)
                    Console.WriteLine("Return");

                return e;
            });
        }

        public override void WillTerminate(NSNotification notification)
        {
            // Insert code here to tear down your application
        }
    }
}
