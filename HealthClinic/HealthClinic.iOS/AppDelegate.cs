﻿using UIKit;
using Foundation;

namespace HealthClinic.iOS
{
    [Register(nameof(AppDelegate))]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication uiApplication, NSDictionary launchOptions)
        {
            global::Xamarin.Forms.Forms.Init();
            FFImageLoading.Forms.Touch.CachedImageRenderer.Init();

#if DEBUG
            Xamarin.Calabash.Start();
#endif

            LoadApplication(new App());

            return base.FinishedLaunching(uiApplication, launchOptions);
        }
    }
}