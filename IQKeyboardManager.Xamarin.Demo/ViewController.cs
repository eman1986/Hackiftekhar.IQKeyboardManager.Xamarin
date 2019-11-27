using System;
using UIKit;

namespace Hackiftekhar.IQKeyboardManager.Xamarin.Demo
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            IQKeyboardManager.SharedManager().EnableAutoToolbar = true;
            IQKeyboardManager.SharedManager().ShouldResignOnTouchOutside = true;
            IQKeyboardManager.SharedManager().ShouldToolbarUsesTextFieldTintColor = true;
        }
    }
}