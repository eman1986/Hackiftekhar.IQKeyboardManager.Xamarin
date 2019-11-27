using ObjCRuntime;

namespace Hackiftekhar.IQKeyboardManager.Xamarin
{
	[Native]
	public enum IQAutoToolbarManageBehaviour : long
	{
		Subviews,
		Tag,
		Position
	}

	[Native]
	public enum IQPreviousNextDisplayMode : ulong
	{
		Default,
		AlwaysHide,
		AlwaysShow
	}

	[Native]
	public enum IQEnableMode : ulong
	{
		Default,
		Enabled,
		Disabled
	}
}