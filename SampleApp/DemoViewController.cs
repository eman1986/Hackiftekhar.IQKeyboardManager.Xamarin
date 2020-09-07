using UIKit;
using Hackiftekhar.IQKeyboardManager.Xamarin;

namespace SampleApp
{
    public partial class DemoViewController : UIViewController
    {
        public DemoViewController() : base("DemoViewController", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            IQKeyboardManager.SharedManager().EnableAutoToolbar = true;
            IQKeyboardManager.SharedManager().ShouldPlayInputClicks = false;
            IQKeyboardManager.SharedManager().ShouldResignOnTouchOutside = true;
            IQKeyboardManager.SharedManager().ShouldToolbarUsesTextFieldTintColor = true;
        }
    }
}

