using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace Hackiftekhar.IQKeyboardManager.Xamarin
{
	// @interface IQBarButtonItem : UIBarButtonItem
	[BaseType (typeof(UIBarButtonItem))]
	interface IQBarButtonItem
	{
		// @property (readonly, nonatomic) BOOL isSystemItem;
		[Export ("isSystemItem")]
		bool IsSystemItem { get; }

		// -(void)setTarget:(id _Nullable)target action:(SEL _Nullable)action;
		[Export ("setTarget:action:")]
		void SetTarget ([NullAllowed] NSObject target, [NullAllowed] Selector action);

		// @property (nonatomic, strong) NSInvocation * _Nullable invocation;
		[NullAllowed, Export ("invocation", ArgumentSemantic.Strong)]
		NSInvocation Invocation { get; set; }
	}

	// @interface IQTitleBarButtonItem : IQBarButtonItem
	[BaseType (typeof(IQBarButtonItem))]
	[DisableDefaultCtor]
	interface IQTitleBarButtonItem
	{
		// @property (nonatomic, strong) UIFont * _Nullable titleFont;
		[NullAllowed, Export ("titleFont", ArgumentSemantic.Strong)]
		UIFont TitleFont { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable titleColor;
		[NullAllowed, Export ("titleColor", ArgumentSemantic.Strong)]
		UIColor TitleColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable selectableTitleColor;
		[NullAllowed, Export ("selectableTitleColor", ArgumentSemantic.Strong)]
		UIColor SelectableTitleColor { get; set; }

		// -(instancetype _Nonnull)initWithTitle:(NSString * _Nullable)title __attribute__((objc_designated_initializer));
		[Export ("initWithTitle:")]
		[DesignatedInitializer]
		IntPtr Constructor ([NullAllowed] string title);
	}

	// @interface IQToolbar : UIToolbar <UIInputViewAudioFeedback>
	[BaseType (typeof(UIToolbar))]
	interface IQToolbar : IUIInputViewAudioFeedback
	{
		// @property (nonatomic, strong) IQBarButtonItem * _Nonnull previousBarButton;
		[Export ("previousBarButton", ArgumentSemantic.Strong)]
		IQBarButtonItem PreviousBarButton { get; set; }

		// @property (nonatomic, strong) IQBarButtonItem * _Nonnull nextBarButton;
		[Export ("nextBarButton", ArgumentSemantic.Strong)]
		IQBarButtonItem NextBarButton { get; set; }

		// @property (readonly, nonatomic, strong) IQTitleBarButtonItem * _Nonnull titleBarButton;
		[Export ("titleBarButton", ArgumentSemantic.Strong)]
		IQTitleBarButtonItem TitleBarButton { get; }

		// @property (nonatomic, strong) IQBarButtonItem * _Nonnull doneBarButton;
		[Export ("doneBarButton", ArgumentSemantic.Strong)]
		IQBarButtonItem DoneBarButton { get; set; }

		// @property (nonatomic, strong) IQBarButtonItem * _Nonnull fixedSpaceBarButton;
		[Export ("fixedSpaceBarButton", ArgumentSemantic.Strong)]
		IQBarButtonItem FixedSpaceBarButton { get; set; }
	}

	// @interface IQBarButtonItemConfiguration : NSObject
	[BaseType (typeof(NSObject))]
	interface IQBarButtonItemConfiguration
	{
		// -(instancetype _Nonnull)initWithBarButtonSystemItem:(UIBarButtonSystemItem)barButtonSystemItem action:(SEL _Nullable)action;
		[Export ("initWithBarButtonSystemItem:action:")]
		IntPtr Constructor (UIBarButtonSystemItem barButtonSystemItem, [NullAllowed] Selector action);

		// -(instancetype _Nonnull)initWithImage:(UIImage * _Nonnull)image action:(SEL _Nullable)action;
		[Export ("initWithImage:action:")]
		IntPtr Constructor (UIImage image, [NullAllowed] Selector action);

		// -(instancetype _Nonnull)initWithTitle:(NSString * _Nonnull)title action:(SEL _Nullable)action;
		[Export ("initWithTitle:action:")]
		IntPtr Constructor (string title, [NullAllowed] Selector action);

		// @property (readonly, nonatomic) UIBarButtonSystemItem barButtonSystemItem;
		[Export ("barButtonSystemItem")]
		UIBarButtonSystemItem BarButtonSystemItem { get; }

		// @property (readonly, nonatomic) UIImage * _Nullable image;
		[NullAllowed, Export ("image")]
		UIImage Image { get; }

		// @property (readonly, nonatomic) NSString * _Nullable title;
		[NullAllowed, Export ("title")]
		string Title { get; }

		// @property (readonly, nonatomic) SEL _Nullable action;
		[NullAllowed, Export ("action")]
		Selector Action { get; }
	}

	// @interface IQKeyboardToolbarNextPreviousImage (UIImage)
	[Category]
	[BaseType (typeof(UIImage))]
	interface UIImage_IQKeyboardToolbarNextPreviousImage
	{
		// +(UIImage * _Nullable)keyboardLeftImage;
		[Static]
		[NullAllowed, Export ("keyboardLeftImage")]
		UIImage KeyboardLeftImage { get; }

		// +(UIImage * _Nullable)keyboardRightImage;
		[Static]
		[NullAllowed, Export ("keyboardRightImage")]
		UIImage KeyboardRightImage { get; }

		// +(UIImage * _Nullable)keyboardUpImage;
		[Static]
		[NullAllowed, Export ("keyboardUpImage")]
		UIImage KeyboardUpImage { get; }

		// +(UIImage * _Nullable)keyboardDownImage;
		[Static]
		[NullAllowed, Export ("keyboardDownImage")]
		UIImage KeyboardDownImage { get; }

		// +(UIImage * _Nullable)keyboardPreviousImage;
		[Static]
		[NullAllowed, Export ("keyboardPreviousImage")]
		UIImage KeyboardPreviousImage { get; }

		// +(UIImage * _Nullable)keyboardNextImage;
		[Static]
		[NullAllowed, Export ("keyboardNextImage")]
		UIImage KeyboardNextImage { get; }
	}

    // @interface IQPreviousNextView : UIView
	[BaseType (typeof(UIView))]
	interface IQPreviousNextView
	{
	}

	// @interface IQKeyboardReturnKeyHandler : NSObject
	[BaseType (typeof(NSObject))]
	interface IQKeyboardReturnKeyHandler
	{
		// -(instancetype _Nonnull)initWithViewController:(UIViewController * _Nullable)controller __attribute__((objc_designated_initializer));
		[Export ("initWithViewController:")]
		[DesignatedInitializer]
		IntPtr Constructor ([NullAllowed] UIViewController controller);

		[Wrap ("WeakDelegate")]
		[NullAllowed]
		NSObject Delegate { get; set; }

		// @property (nonatomic, weak) id<UITextFieldDelegate,UITextViewDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (assign, nonatomic) UIReturnKeyType lastTextFieldReturnKeyType;
		[Export ("lastTextFieldReturnKeyType", ArgumentSemantic.Assign)]
		UIReturnKeyType LastTextFieldReturnKeyType { get; set; }

		// -(void)addTextFieldView:(UIView * _Nonnull)textFieldView;
		[Export ("addTextFieldView:")]
		void AddTextFieldView (UIView textFieldView);

		// -(void)removeTextFieldView:(UIView * _Nonnull)textFieldView;
		[Export ("removeTextFieldView:")]
		void RemoveTextFieldView (UIView textFieldView);

		// -(void)addResponderFromView:(UIView * _Nonnull)view;
		[Export ("addResponderFromView:")]
		void AddResponderFromView (UIView view);

		// -(void)removeResponderFromView:(UIView * _Nonnull)view;
		[Export ("removeResponderFromView:")]
		void RemoveResponderFromView (UIView view);
	}

	// @interface IQTextView : UITextView
	[BaseType (typeof(UITextView))]
	interface IQTextView
	{
		// @property (copy, nonatomic) NSString * _Nullable placeholder;
		[NullAllowed, Export ("placeholder")]
		string Placeholder { get; set; }

		// @property (copy, nonatomic) NSAttributedString * _Nullable attributedPlaceholder;
		[NullAllowed, Export ("attributedPlaceholder", ArgumentSemantic.Copy)]
		NSAttributedString AttributedPlaceholder { get; set; }

		// @property (copy, nonatomic) UIColor * _Nullable placeholderTextColor;
		[NullAllowed, Export ("placeholderTextColor", ArgumentSemantic.Copy)]
		UIColor PlaceholderTextColor { get; set; }
	}

	// @interface PreviousNextIndexPath (UITableView)
	[Category]
	[BaseType (typeof(UITableView))]
	interface UITableView_PreviousNextIndexPath
	{
		// -(NSIndexPath * _Nullable)previousIndexPathOfIndexPath:(NSIndexPath * _Nonnull)indexPath;
		[Export ("previousIndexPathOfIndexPath:")]
		[return: NullAllowed]
		NSIndexPath PreviousIndexPathOfIndexPath (NSIndexPath indexPath);
	}

	// @interface PreviousNextIndexPath (UICollectionView)
	[Category]
	[BaseType (typeof(UICollectionView))]
	interface UICollectionView_PreviousNextIndexPath
	{
		// -(NSIndexPath * _Nullable)previousIndexPathOfIndexPath:(NSIndexPath * _Nonnull)indexPath;
		[Export ("previousIndexPathOfIndexPath:")]
		[return: NullAllowed]
		NSIndexPath PreviousIndexPathOfIndexPath (NSIndexPath indexPath);
	}

    [Static]
	partial interface Constants
	{
		// extern const CGFloat kIQUseDefaultKeyboardDistance;
		[Field ("kIQUseDefaultKeyboardDistance", "__Internal")]
		nfloat kIQUseDefaultKeyboardDistance { get; }

        [Field ("kIQDoneButtonToolbarTag", "__Internal")]
        nint kIQDoneButtonToolbarTag { get; }

        // extern const NSInteger kIQPreviousNextButtonToolbarTag;
        [Field ("kIQPreviousNextButtonToolbarTag", "__Internal")]
        nint kIQPreviousNextButtonToolbarTag { get; }
    }

    // @interface IQKeyboardManager : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface IQKeyboardManager
	{
		// +(instancetype _Nonnull)sharedManager;
		[Static]
		[Export ("sharedManager")]
		IQKeyboardManager SharedManager ();

		// @property (getter = isEnabled, assign, nonatomic) BOOL enable;
		[Export ("enable")]
		bool Enable { [Bind ("isEnabled")] get; set; }

		// @property (assign, nonatomic) CGFloat keyboardDistanceFromTextField;
		[Export ("keyboardDistanceFromTextField")]
		nfloat KeyboardDistanceFromTextField { get; set; }

		// -(void)reloadLayoutIfNeeded;
		[Export ("reloadLayoutIfNeeded")]
		void ReloadLayoutIfNeeded ();

		// @property (readonly, getter = isKeyboardShowing, assign, nonatomic) BOOL keyboardShowing;
		[Export ("keyboardShowing")]
		bool KeyboardShowing { [Bind ("isKeyboardShowing")] get; }

		// @property (readonly, assign, nonatomic) CGFloat movedDistance;
		[Export ("movedDistance")]
		nfloat MovedDistance { get; }

		// @property (copy, nonatomic) void (^ _Nullable)(CGFloat) movedDistanceChanged;
		[NullAllowed, Export ("movedDistanceChanged", ArgumentSemantic.Copy)]
		Action<nfloat> MovedDistanceChanged { get; set; }

		// @property (getter = isEnableAutoToolbar, assign, nonatomic) BOOL enableAutoToolbar;
		[Export ("enableAutoToolbar")]
		bool EnableAutoToolbar { [Bind ("isEnableAutoToolbar")] get; set; }

		// @property (assign, nonatomic) IQAutoToolbarManageBehaviour toolbarManageBehaviour;
		[Export ("toolbarManageBehaviour", ArgumentSemantic.Assign)]
		IQAutoToolbarManageBehaviour ToolbarManageBehaviour { get; set; }

		// @property (assign, nonatomic) BOOL shouldToolbarUsesTextFieldTintColor;
		[Export ("shouldToolbarUsesTextFieldTintColor")]
		bool ShouldToolbarUsesTextFieldTintColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable toolbarTintColor;
		[NullAllowed, Export ("toolbarTintColor", ArgumentSemantic.Strong)]
		UIColor ToolbarTintColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable toolbarBarTintColor;
		[NullAllowed, Export ("toolbarBarTintColor", ArgumentSemantic.Strong)]
		UIColor ToolbarBarTintColor { get; set; }

		// @property (assign, nonatomic) IQPreviousNextDisplayMode previousNextDisplayMode;
		[Export ("previousNextDisplayMode", ArgumentSemantic.Assign)]
		IQPreviousNextDisplayMode PreviousNextDisplayMode { get; set; }

		// @property (nonatomic, strong) UIImage * _Nullable toolbarPreviousBarButtonItemImage;
		[NullAllowed, Export ("toolbarPreviousBarButtonItemImage", ArgumentSemantic.Strong)]
		UIImage ToolbarPreviousBarButtonItemImage { get; set; }

		// @property (nonatomic, strong) UIImage * _Nullable toolbarNextBarButtonItemImage;
		[NullAllowed, Export ("toolbarNextBarButtonItemImage", ArgumentSemantic.Strong)]
		UIImage ToolbarNextBarButtonItemImage { get; set; }

		// @property (nonatomic, strong) UIImage * _Nullable toolbarDoneBarButtonItemImage;
		[NullAllowed, Export ("toolbarDoneBarButtonItemImage", ArgumentSemantic.Strong)]
		UIImage ToolbarDoneBarButtonItemImage { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable toolbarPreviousBarButtonItemText;
		[NullAllowed, Export ("toolbarPreviousBarButtonItemText", ArgumentSemantic.Strong)]
		string ToolbarPreviousBarButtonItemText { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable toolbarPreviousBarButtonItemAccessibilityLabel;
		[NullAllowed, Export ("toolbarPreviousBarButtonItemAccessibilityLabel", ArgumentSemantic.Strong)]
		string ToolbarPreviousBarButtonItemAccessibilityLabel { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable toolbarNextBarButtonItemText;
		[NullAllowed, Export ("toolbarNextBarButtonItemText", ArgumentSemantic.Strong)]
		string ToolbarNextBarButtonItemText { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable toolbarNextBarButtonItemAccessibilityLabel;
		[NullAllowed, Export ("toolbarNextBarButtonItemAccessibilityLabel", ArgumentSemantic.Strong)]
		string ToolbarNextBarButtonItemAccessibilityLabel { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable toolbarDoneBarButtonItemText;
		[NullAllowed, Export ("toolbarDoneBarButtonItemText", ArgumentSemantic.Strong)]
		string ToolbarDoneBarButtonItemText { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable toolbarDoneBarButtonItemAccessibilityLabel;
		[NullAllowed, Export ("toolbarDoneBarButtonItemAccessibilityLabel", ArgumentSemantic.Strong)]
		string ToolbarDoneBarButtonItemAccessibilityLabel { get; set; }

		// @property (assign, nonatomic) BOOL shouldShowToolbarPlaceholder;
		[Export ("shouldShowToolbarPlaceholder")]
		bool ShouldShowToolbarPlaceholder { get; set; }

		// @property (nonatomic, strong) UIFont * _Nullable placeholderFont;
		[NullAllowed, Export ("placeholderFont", ArgumentSemantic.Strong)]
		UIFont PlaceholderFont { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable placeholderColor;
		[NullAllowed, Export ("placeholderColor", ArgumentSemantic.Strong)]
		UIColor PlaceholderColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable placeholderButtonColor;
		[NullAllowed, Export ("placeholderButtonColor", ArgumentSemantic.Strong)]
		UIColor PlaceholderButtonColor { get; set; }

		// -(void)reloadInputViews;
		[Export ("reloadInputViews")]
		void ReloadInputViews ();

		// @property (assign, nonatomic) BOOL overrideKeyboardAppearance;
		[Export ("overrideKeyboardAppearance")]
		bool OverrideKeyboardAppearance { get; set; }

		// @property (assign, nonatomic) UIKeyboardAppearance keyboardAppearance;
		[Export ("keyboardAppearance", ArgumentSemantic.Assign)]
		UIKeyboardAppearance KeyboardAppearance { get; set; }

		// @property (assign, nonatomic) BOOL shouldResignOnTouchOutside;
		[Export ("shouldResignOnTouchOutside")]
		bool ShouldResignOnTouchOutside { get; set; }

		// @property (readonly, nonatomic, strong) UITapGestureRecognizer * _Nonnull resignFirstResponderGesture;
		[Export ("resignFirstResponderGesture", ArgumentSemantic.Strong)]
		UITapGestureRecognizer ResignFirstResponderGesture { get; }

		// -(BOOL)resignFirstResponder;
		[Export ("resignFirstResponder")]
		bool ResignFirstResponder { get; }

		// @property (readonly, nonatomic) BOOL canGoPrevious;
		[Export ("canGoPrevious")]
		bool CanGoPrevious { get; }

		// @property (readonly, nonatomic) BOOL canGoNext;
		[Export ("canGoNext")]
		bool CanGoNext { get; }

		// -(BOOL)goPrevious;
		[Export ("goPrevious")]
		bool GoPrevious { get; }

		// -(BOOL)goNext;
		[Export ("goNext")]
		bool GoNext { get; }

		// @property (assign, nonatomic) BOOL shouldPlayInputClicks;
		[Export ("shouldPlayInputClicks")]
		bool ShouldPlayInputClicks { get; set; }

		// @property (assign, nonatomic) BOOL layoutIfNeededOnUpdate;
		[Export ("layoutIfNeededOnUpdate")]
		bool LayoutIfNeededOnUpdate { get; set; }

		// @property (readonly, nonatomic, strong) NSMutableSet<Class> * _Nonnull disabledDistanceHandlingClasses;
		[Export ("disabledDistanceHandlingClasses", ArgumentSemantic.Strong)]
		NSMutableSet<Class> DisabledDistanceHandlingClasses { get; }

		// @property (readonly, nonatomic, strong) NSMutableSet<Class> * _Nonnull enabledDistanceHandlingClasses;
		[Export ("enabledDistanceHandlingClasses", ArgumentSemantic.Strong)]
		NSMutableSet<Class> EnabledDistanceHandlingClasses { get; }

		// @property (readonly, nonatomic, strong) NSMutableSet<Class> * _Nonnull disabledToolbarClasses;
		[Export ("disabledToolbarClasses", ArgumentSemantic.Strong)]
		NSMutableSet<Class> DisabledToolbarClasses { get; }

		// @property (readonly, nonatomic, strong) NSMutableSet<Class> * _Nonnull enabledToolbarClasses;
		[Export ("enabledToolbarClasses", ArgumentSemantic.Strong)]
		NSMutableSet<Class> EnabledToolbarClasses { get; }

		// @property (readonly, nonatomic, strong) NSMutableSet<Class> * _Nonnull toolbarPreviousNextAllowedClasses;
		[Export ("toolbarPreviousNextAllowedClasses", ArgumentSemantic.Strong)]
		NSMutableSet<Class> ToolbarPreviousNextAllowedClasses { get; }

		// @property (readonly, nonatomic, strong) NSMutableSet<Class> * _Nonnull disabledTouchResignedClasses;
		[Export ("disabledTouchResignedClasses", ArgumentSemantic.Strong)]
		NSMutableSet<Class> DisabledTouchResignedClasses { get; }

		// @property (readonly, nonatomic, strong) NSMutableSet<Class> * _Nonnull enabledTouchResignedClasses;
		[Export ("enabledTouchResignedClasses", ArgumentSemantic.Strong)]
		NSMutableSet<Class> EnabledTouchResignedClasses { get; }

		// @property (readonly, nonatomic, strong) NSMutableSet<Class> * _Nonnull touchResignedGestureIgnoreClasses;
		[Export ("touchResignedGestureIgnoreClasses", ArgumentSemantic.Strong)]
		NSMutableSet<Class> TouchResignedGestureIgnoreClasses { get; }

		// -(void)registerTextFieldViewClass:(Class _Nonnull)aClass didBeginEditingNotificationName:(NSString * _Nonnull)didBeginEditingNotificationName didEndEditingNotificationName:(NSString * _Nonnull)didEndEditingNotificationName;
		[Export ("registerTextFieldViewClass:didBeginEditingNotificationName:didEndEditingNotificationName:")]
		void RegisterTextFieldViewClass (Class aClass, string didBeginEditingNotificationName, string didEndEditingNotificationName);

		// -(void)unregisterTextFieldViewClass:(Class _Nonnull)aClass didBeginEditingNotificationName:(NSString * _Nonnull)didBeginEditingNotificationName didEndEditingNotificationName:(NSString * _Nonnull)didEndEditingNotificationName;
		[Export ("unregisterTextFieldViewClass:didBeginEditingNotificationName:didEndEditingNotificationName:")]
		void UnregisterTextFieldViewClass (Class aClass, string didBeginEditingNotificationName, string didEndEditingNotificationName);

		// @property (assign, nonatomic) BOOL enableDebugging;
		[Export ("enableDebugging")]
		bool EnableDebugging { get; set; }

		// -(void)registerAllNotifications;
		[Export ("registerAllNotifications")]
		void RegisterAllNotifications ();

		// -(void)unregisterAllNotifications;
		[Export ("unregisterAllNotifications")]
		void UnregisterAllNotifications ();
	}
}
