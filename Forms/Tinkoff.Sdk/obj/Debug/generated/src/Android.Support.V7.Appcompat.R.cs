using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Support.V7.Appcompat {

	// Metadata.xml XPath class reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R']"
	[global::Android.Runtime.Register ("android/support/v7/appcompat/R", DoNotGenerateAcw=true)]
	public sealed partial class R : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.anim']"
		[global::Android.Runtime.Register ("android/support/v7/appcompat/R$anim", DoNotGenerateAcw=true)]
		public sealed partial class Anim : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.anim']/field[@name='abc_fade_in']"
			[Register ("abc_fade_in")]
			public const int AbcFadeIn = (int) 2130968576;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.anim']/field[@name='abc_fade_out']"
			[Register ("abc_fade_out")]
			public const int AbcFadeOut = (int) 2130968577;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.anim']/field[@name='abc_grow_fade_in_from_bottom']"
			[Register ("abc_grow_fade_in_from_bottom")]
			public const int AbcGrowFadeInFromBottom = (int) 2130968578;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.anim']/field[@name='abc_popup_enter']"
			[Register ("abc_popup_enter")]
			public const int AbcPopupEnter = (int) 2130968579;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.anim']/field[@name='abc_popup_exit']"
			[Register ("abc_popup_exit")]
			public const int AbcPopupExit = (int) 2130968580;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.anim']/field[@name='abc_shrink_fade_out_from_bottom']"
			[Register ("abc_shrink_fade_out_from_bottom")]
			public const int AbcShrinkFadeOutFromBottom = (int) 2130968581;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.anim']/field[@name='abc_slide_in_bottom']"
			[Register ("abc_slide_in_bottom")]
			public const int AbcSlideInBottom = (int) 2130968582;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.anim']/field[@name='abc_slide_in_top']"
			[Register ("abc_slide_in_top")]
			public const int AbcSlideInTop = (int) 2130968583;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.anim']/field[@name='abc_slide_out_bottom']"
			[Register ("abc_slide_out_bottom")]
			public const int AbcSlideOutBottom = (int) 2130968584;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.anim']/field[@name='abc_slide_out_top']"
			[Register ("abc_slide_out_top")]
			public const int AbcSlideOutTop = (int) 2130968585;
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("android/support/v7/appcompat/R$anim", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Anim); }
			}

			internal Anim (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.anim']/constructor[@name='R.anim' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Anim ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (((object) this).GetType () != typeof (Anim)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
						return;
					}

					if (id_ctor == IntPtr.Zero)
						id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']"
		[global::Android.Runtime.Register ("android/support/v7/appcompat/R$attr", DoNotGenerateAcw=true)]
		public sealed partial class Attr : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='actionBarDivider']"
			[Register ("actionBarDivider")]
			public const int ActionBarDivider = (int) 2130772043;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='actionBarItemBackground']"
			[Register ("actionBarItemBackground")]
			public const int ActionBarItemBackground = (int) 2130772044;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='actionBarPopupTheme']"
			[Register ("actionBarPopupTheme")]
			public const int ActionBarPopupTheme = (int) 2130772037;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='actionBarSize']"
			[Register ("actionBarSize")]
			public const int ActionBarSize = (int) 2130772042;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='actionBarSplitStyle']"
			[Register ("actionBarSplitStyle")]
			public const int ActionBarSplitStyle = (int) 2130772039;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='actionBarStyle']"
			[Register ("actionBarStyle")]
			public const int ActionBarStyle = (int) 2130772038;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='actionBarTabBarStyle']"
			[Register ("actionBarTabBarStyle")]
			public const int ActionBarTabBarStyle = (int) 2130772033;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='actionBarTabStyle']"
			[Register ("actionBarTabStyle")]
			public const int ActionBarTabStyle = (int) 2130772032;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='actionBarTabTextStyle']"
			[Register ("actionBarTabTextStyle")]
			public const int ActionBarTabTextStyle = (int) 2130772034;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='actionBarTheme']"
			[Register ("actionBarTheme")]
			public const int ActionBarTheme = (int) 2130772040;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='actionBarWidgetTheme']"
			[Register ("actionBarWidgetTheme")]
			public const int ActionBarWidgetTheme = (int) 2130772041;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='actionButtonStyle']"
			[Register ("actionButtonStyle")]
			public const int ActionButtonStyle = (int) 2130772069;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='actionDropDownStyle']"
			[Register ("actionDropDownStyle")]
			public const int ActionDropDownStyle = (int) 2130772065;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='actionLayout']"
			[Register ("actionLayout")]
			public const int ActionLayout = (int) 2130772155;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='actionMenuTextAppearance']"
			[Register ("actionMenuTextAppearance")]
			public const int ActionMenuTextAppearance = (int) 2130772045;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='actionMenuTextColor']"
			[Register ("actionMenuTextColor")]
			public const int ActionMenuTextColor = (int) 2130772046;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='actionModeBackground']"
			[Register ("actionModeBackground")]
			public const int ActionModeBackground = (int) 2130772049;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='actionModeCloseButtonStyle']"
			[Register ("actionModeCloseButtonStyle")]
			public const int ActionModeCloseButtonStyle = (int) 2130772048;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='actionModeCloseDrawable']"
			[Register ("actionModeCloseDrawable")]
			public const int ActionModeCloseDrawable = (int) 2130772051;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='actionModeCopyDrawable']"
			[Register ("actionModeCopyDrawable")]
			public const int ActionModeCopyDrawable = (int) 2130772053;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='actionModeCutDrawable']"
			[Register ("actionModeCutDrawable")]
			public const int ActionModeCutDrawable = (int) 2130772052;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='actionModeFindDrawable']"
			[Register ("actionModeFindDrawable")]
			public const int ActionModeFindDrawable = (int) 2130772057;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='actionModePasteDrawable']"
			[Register ("actionModePasteDrawable")]
			public const int ActionModePasteDrawable = (int) 2130772054;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='actionModePopupWindowStyle']"
			[Register ("actionModePopupWindowStyle")]
			public const int ActionModePopupWindowStyle = (int) 2130772059;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='actionModeSelectAllDrawable']"
			[Register ("actionModeSelectAllDrawable")]
			public const int ActionModeSelectAllDrawable = (int) 2130772055;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='actionModeShareDrawable']"
			[Register ("actionModeShareDrawable")]
			public const int ActionModeShareDrawable = (int) 2130772056;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='actionModeSplitBackground']"
			[Register ("actionModeSplitBackground")]
			public const int ActionModeSplitBackground = (int) 2130772050;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='actionModeStyle']"
			[Register ("actionModeStyle")]
			public const int ActionModeStyle = (int) 2130772047;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='actionModeWebSearchDrawable']"
			[Register ("actionModeWebSearchDrawable")]
			public const int ActionModeWebSearchDrawable = (int) 2130772058;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='actionOverflowButtonStyle']"
			[Register ("actionOverflowButtonStyle")]
			public const int ActionOverflowButtonStyle = (int) 2130772035;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='actionOverflowMenuStyle']"
			[Register ("actionOverflowMenuStyle")]
			public const int ActionOverflowMenuStyle = (int) 2130772036;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='actionProviderClass']"
			[Register ("actionProviderClass")]
			public const int ActionProviderClass = (int) 2130772157;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='actionViewClass']"
			[Register ("actionViewClass")]
			public const int ActionViewClass = (int) 2130772156;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='activityChooserViewStyle']"
			[Register ("activityChooserViewStyle")]
			public const int ActivityChooserViewStyle = (int) 2130772077;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='alertDialogButtonGroupStyle']"
			[Register ("alertDialogButtonGroupStyle")]
			public const int AlertDialogButtonGroupStyle = (int) 2130772112;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='alertDialogCenterButtons']"
			[Register ("alertDialogCenterButtons")]
			public const int AlertDialogCenterButtons = (int) 2130772113;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='alertDialogStyle']"
			[Register ("alertDialogStyle")]
			public const int AlertDialogStyle = (int) 2130772111;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='alertDialogTheme']"
			[Register ("alertDialogTheme")]
			public const int AlertDialogTheme = (int) 2130772114;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='allowStacking']"
			[Register ("allowStacking")]
			public const int AllowStacking = (int) 2130772132;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='arrowHeadLength']"
			[Register ("arrowHeadLength")]
			public const int ArrowHeadLength = (int) 2130772139;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='arrowShaftLength']"
			[Register ("arrowShaftLength")]
			public const int ArrowShaftLength = (int) 2130772140;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='autoCompleteTextViewStyle']"
			[Register ("autoCompleteTextViewStyle")]
			public const int AutoCompleteTextViewStyle = (int) 2130772119;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='background']"
			[Register ("background")]
			public const int Background = (int) 2130771996;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='backgroundSplit']"
			[Register ("backgroundSplit")]
			public const int BackgroundSplit = (int) 2130771998;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='backgroundStacked']"
			[Register ("backgroundStacked")]
			public const int BackgroundStacked = (int) 2130771997;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='backgroundTint']"
			[Register ("backgroundTint")]
			public const int BackgroundTint = (int) 2130772199;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='backgroundTintMode']"
			[Register ("backgroundTintMode")]
			public const int BackgroundTintMode = (int) 2130772200;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='barLength']"
			[Register ("barLength")]
			public const int BarLength = (int) 2130772141;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='borderlessButtonStyle']"
			[Register ("borderlessButtonStyle")]
			public const int BorderlessButtonStyle = (int) 2130772074;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='buttonBarButtonStyle']"
			[Register ("buttonBarButtonStyle")]
			public const int ButtonBarButtonStyle = (int) 2130772071;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='buttonBarNegativeButtonStyle']"
			[Register ("buttonBarNegativeButtonStyle")]
			public const int ButtonBarNegativeButtonStyle = (int) 2130772117;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='buttonBarNeutralButtonStyle']"
			[Register ("buttonBarNeutralButtonStyle")]
			public const int ButtonBarNeutralButtonStyle = (int) 2130772118;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='buttonBarPositiveButtonStyle']"
			[Register ("buttonBarPositiveButtonStyle")]
			public const int ButtonBarPositiveButtonStyle = (int) 2130772116;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='buttonBarStyle']"
			[Register ("buttonBarStyle")]
			public const int ButtonBarStyle = (int) 2130772070;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='buttonPanelSideLayout']"
			[Register ("buttonPanelSideLayout")]
			public const int ButtonPanelSideLayout = (int) 2130772015;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='buttonStyle']"
			[Register ("buttonStyle")]
			public const int ButtonStyle = (int) 2130772120;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='buttonStyleSmall']"
			[Register ("buttonStyleSmall")]
			public const int ButtonStyleSmall = (int) 2130772121;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='buttonTint']"
			[Register ("buttonTint")]
			public const int ButtonTint = (int) 2130772133;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='buttonTintMode']"
			[Register ("buttonTintMode")]
			public const int ButtonTintMode = (int) 2130772134;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='checkboxStyle']"
			[Register ("checkboxStyle")]
			public const int CheckboxStyle = (int) 2130772122;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='checkedTextViewStyle']"
			[Register ("checkedTextViewStyle")]
			public const int CheckedTextViewStyle = (int) 2130772123;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='closeIcon']"
			[Register ("closeIcon")]
			public const int CloseIcon = (int) 2130772165;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='closeItemLayout']"
			[Register ("closeItemLayout")]
			public const int CloseItemLayout = (int) 2130772012;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='collapseContentDescription']"
			[Register ("collapseContentDescription")]
			public const int CollapseContentDescription = (int) 2130772190;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='collapseIcon']"
			[Register ("collapseIcon")]
			public const int CollapseIcon = (int) 2130772189;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='color']"
			[Register ("color")]
			public const int Color = (int) 2130772135;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='colorAccent']"
			[Register ("colorAccent")]
			public const int ColorAccent = (int) 2130772104;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='colorButtonNormal']"
			[Register ("colorButtonNormal")]
			public const int ColorButtonNormal = (int) 2130772108;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='colorControlActivated']"
			[Register ("colorControlActivated")]
			public const int ColorControlActivated = (int) 2130772106;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='colorControlHighlight']"
			[Register ("colorControlHighlight")]
			public const int ColorControlHighlight = (int) 2130772107;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='colorControlNormal']"
			[Register ("colorControlNormal")]
			public const int ColorControlNormal = (int) 2130772105;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='colorPrimary']"
			[Register ("colorPrimary")]
			public const int ColorPrimary = (int) 2130772102;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='colorPrimaryDark']"
			[Register ("colorPrimaryDark")]
			public const int ColorPrimaryDark = (int) 2130772103;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='colorSwitchThumbNormal']"
			[Register ("colorSwitchThumbNormal")]
			public const int ColorSwitchThumbNormal = (int) 2130772109;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='commitIcon']"
			[Register ("commitIcon")]
			public const int CommitIcon = (int) 2130772170;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='contentInsetEnd']"
			[Register ("contentInsetEnd")]
			public const int ContentInsetEnd = (int) 2130772007;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='contentInsetLeft']"
			[Register ("contentInsetLeft")]
			public const int ContentInsetLeft = (int) 2130772008;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='contentInsetRight']"
			[Register ("contentInsetRight")]
			public const int ContentInsetRight = (int) 2130772009;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='contentInsetStart']"
			[Register ("contentInsetStart")]
			public const int ContentInsetStart = (int) 2130772006;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='controlBackground']"
			[Register ("controlBackground")]
			public const int ControlBackground = (int) 2130772110;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='customNavigationLayout']"
			[Register ("customNavigationLayout")]
			public const int CustomNavigationLayout = (int) 2130771999;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='defaultQueryHint']"
			[Register ("defaultQueryHint")]
			public const int DefaultQueryHint = (int) 2130772164;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='dialogPreferredPadding']"
			[Register ("dialogPreferredPadding")]
			public const int DialogPreferredPadding = (int) 2130772063;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='dialogTheme']"
			[Register ("dialogTheme")]
			public const int DialogTheme = (int) 2130772062;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='displayOptions']"
			[Register ("displayOptions")]
			public const int DisplayOptions = (int) 2130771989;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='divider']"
			[Register ("divider")]
			public const int Divider = (int) 2130771995;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='dividerHorizontal']"
			[Register ("dividerHorizontal")]
			public const int DividerHorizontal = (int) 2130772076;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='dividerPadding']"
			[Register ("dividerPadding")]
			public const int DividerPadding = (int) 2130772153;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='dividerVertical']"
			[Register ("dividerVertical")]
			public const int DividerVertical = (int) 2130772075;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='drawableSize']"
			[Register ("drawableSize")]
			public const int DrawableSize = (int) 2130772137;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='drawerArrowStyle']"
			[Register ("drawerArrowStyle")]
			public const int DrawerArrowStyle = (int) 2130771984;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='dropDownListViewStyle']"
			[Register ("dropDownListViewStyle")]
			public const int DropDownListViewStyle = (int) 2130772094;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='dropdownListPreferredItemHeight']"
			[Register ("dropdownListPreferredItemHeight")]
			public const int DropdownListPreferredItemHeight = (int) 2130772066;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='editTextBackground']"
			[Register ("editTextBackground")]
			public const int EditTextBackground = (int) 2130772083;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='editTextColor']"
			[Register ("editTextColor")]
			public const int EditTextColor = (int) 2130772082;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='editTextStyle']"
			[Register ("editTextStyle")]
			public const int EditTextStyle = (int) 2130772124;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='elevation']"
			[Register ("elevation")]
			public const int Elevation = (int) 2130772010;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='expandActivityOverflowButtonDrawable']"
			[Register ("expandActivityOverflowButtonDrawable")]
			public const int ExpandActivityOverflowButtonDrawable = (int) 2130772014;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='gapBetweenBars']"
			[Register ("gapBetweenBars")]
			public const int GapBetweenBars = (int) 2130772138;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='goIcon']"
			[Register ("goIcon")]
			public const int GoIcon = (int) 2130772166;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='height']"
			[Register ("height")]
			public const int Height = (int) 2130771985;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='hideOnContentScroll']"
			[Register ("hideOnContentScroll")]
			public const int HideOnContentScroll = (int) 2130772005;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='homeAsUpIndicator']"
			[Register ("homeAsUpIndicator")]
			public const int HomeAsUpIndicator = (int) 2130772068;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='homeLayout']"
			[Register ("homeLayout")]
			public const int HomeLayout = (int) 2130772000;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='icon']"
			[Register ("icon")]
			public const int Icon = (int) 2130771993;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='iconifiedByDefault']"
			[Register ("iconifiedByDefault")]
			public const int IconifiedByDefault = (int) 2130772162;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='imageButtonStyle']"
			[Register ("imageButtonStyle")]
			public const int ImageButtonStyle = (int) 2130772084;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='indeterminateProgressStyle']"
			[Register ("indeterminateProgressStyle")]
			public const int IndeterminateProgressStyle = (int) 2130772002;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='initialActivityCount']"
			[Register ("initialActivityCount")]
			public const int InitialActivityCount = (int) 2130772013;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='isLightTheme']"
			[Register ("isLightTheme")]
			public const int IsLightTheme = (int) 2130771986;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='itemPadding']"
			[Register ("itemPadding")]
			public const int ItemPadding = (int) 2130772004;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='layout']"
			[Register ("layout")]
			public const int Layout = (int) 2130772161;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='listChoiceBackgroundIndicator']"
			[Register ("listChoiceBackgroundIndicator")]
			public const int ListChoiceBackgroundIndicator = (int) 2130772101;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='listDividerAlertDialog']"
			[Register ("listDividerAlertDialog")]
			public const int ListDividerAlertDialog = (int) 2130772064;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='listItemLayout']"
			[Register ("listItemLayout")]
			public const int ListItemLayout = (int) 2130772019;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='listLayout']"
			[Register ("listLayout")]
			public const int ListLayout = (int) 2130772016;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='listPopupWindowStyle']"
			[Register ("listPopupWindowStyle")]
			public const int ListPopupWindowStyle = (int) 2130772095;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='listPreferredItemHeight']"
			[Register ("listPreferredItemHeight")]
			public const int ListPreferredItemHeight = (int) 2130772089;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='listPreferredItemHeightLarge']"
			[Register ("listPreferredItemHeightLarge")]
			public const int ListPreferredItemHeightLarge = (int) 2130772091;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='listPreferredItemHeightSmall']"
			[Register ("listPreferredItemHeightSmall")]
			public const int ListPreferredItemHeightSmall = (int) 2130772090;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='listPreferredItemPaddingLeft']"
			[Register ("listPreferredItemPaddingLeft")]
			public const int ListPreferredItemPaddingLeft = (int) 2130772092;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='listPreferredItemPaddingRight']"
			[Register ("listPreferredItemPaddingRight")]
			public const int ListPreferredItemPaddingRight = (int) 2130772093;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='logo']"
			[Register ("logo")]
			public const int Logo = (int) 2130771994;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='logoDescription']"
			[Register ("logoDescription")]
			public const int LogoDescription = (int) 2130772193;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='maxButtonHeight']"
			[Register ("maxButtonHeight")]
			public const int MaxButtonHeight = (int) 2130772188;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='measureWithLargestChild']"
			[Register ("measureWithLargestChild")]
			public const int MeasureWithLargestChild = (int) 2130772151;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='multiChoiceItemLayout']"
			[Register ("multiChoiceItemLayout")]
			public const int MultiChoiceItemLayout = (int) 2130772017;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='navigationContentDescription']"
			[Register ("navigationContentDescription")]
			public const int NavigationContentDescription = (int) 2130772192;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='navigationIcon']"
			[Register ("navigationIcon")]
			public const int NavigationIcon = (int) 2130772191;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='navigationMode']"
			[Register ("navigationMode")]
			public const int NavigationMode = (int) 2130771988;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='overlapAnchor']"
			[Register ("overlapAnchor")]
			public const int OverlapAnchor = (int) 2130772159;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='paddingEnd']"
			[Register ("paddingEnd")]
			public const int PaddingEnd = (int) 2130772197;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='paddingStart']"
			[Register ("paddingStart")]
			public const int PaddingStart = (int) 2130772196;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='panelBackground']"
			[Register ("panelBackground")]
			public const int PanelBackground = (int) 2130772098;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='panelMenuListTheme']"
			[Register ("panelMenuListTheme")]
			public const int PanelMenuListTheme = (int) 2130772100;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='panelMenuListWidth']"
			[Register ("panelMenuListWidth")]
			public const int PanelMenuListWidth = (int) 2130772099;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='popupMenuStyle']"
			[Register ("popupMenuStyle")]
			public const int PopupMenuStyle = (int) 2130772080;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='popupTheme']"
			[Register ("popupTheme")]
			public const int PopupTheme = (int) 2130772011;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='popupWindowStyle']"
			[Register ("popupWindowStyle")]
			public const int PopupWindowStyle = (int) 2130772081;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='preserveIconSpacing']"
			[Register ("preserveIconSpacing")]
			public const int PreserveIconSpacing = (int) 2130772158;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='progressBarPadding']"
			[Register ("progressBarPadding")]
			public const int ProgressBarPadding = (int) 2130772003;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='progressBarStyle']"
			[Register ("progressBarStyle")]
			public const int ProgressBarStyle = (int) 2130772001;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='queryBackground']"
			[Register ("queryBackground")]
			public const int QueryBackground = (int) 2130772172;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='queryHint']"
			[Register ("queryHint")]
			public const int QueryHint = (int) 2130772163;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='radioButtonStyle']"
			[Register ("radioButtonStyle")]
			public const int RadioButtonStyle = (int) 2130772125;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='ratingBarStyle']"
			[Register ("ratingBarStyle")]
			public const int RatingBarStyle = (int) 2130772126;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='ratingBarStyleIndicator']"
			[Register ("ratingBarStyleIndicator")]
			public const int RatingBarStyleIndicator = (int) 2130772127;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='ratingBarStyleSmall']"
			[Register ("ratingBarStyleSmall")]
			public const int RatingBarStyleSmall = (int) 2130772128;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='searchHintIcon']"
			[Register ("searchHintIcon")]
			public const int SearchHintIcon = (int) 2130772168;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='searchIcon']"
			[Register ("searchIcon")]
			public const int SearchIcon = (int) 2130772167;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='searchViewStyle']"
			[Register ("searchViewStyle")]
			public const int SearchViewStyle = (int) 2130772088;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='seekBarStyle']"
			[Register ("seekBarStyle")]
			public const int SeekBarStyle = (int) 2130772129;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='selectableItemBackground']"
			[Register ("selectableItemBackground")]
			public const int SelectableItemBackground = (int) 2130772072;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='selectableItemBackgroundBorderless']"
			[Register ("selectableItemBackgroundBorderless")]
			public const int SelectableItemBackgroundBorderless = (int) 2130772073;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='showAsAction']"
			[Register ("showAsAction")]
			public const int ShowAsAction = (int) 2130772154;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='showDividers']"
			[Register ("showDividers")]
			public const int ShowDividers = (int) 2130772152;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='showText']"
			[Register ("showText")]
			public const int ShowText = (int) 2130772180;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='singleChoiceItemLayout']"
			[Register ("singleChoiceItemLayout")]
			public const int SingleChoiceItemLayout = (int) 2130772018;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='spinBars']"
			[Register ("spinBars")]
			public const int SpinBars = (int) 2130772136;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='spinnerDropDownItemStyle']"
			[Register ("spinnerDropDownItemStyle")]
			public const int SpinnerDropDownItemStyle = (int) 2130772067;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='spinnerStyle']"
			[Register ("spinnerStyle")]
			public const int SpinnerStyle = (int) 2130772130;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='splitTrack']"
			[Register ("splitTrack")]
			public const int SplitTrack = (int) 2130772179;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='srcCompat']"
			[Register ("srcCompat")]
			public const int SrcCompat = (int) 2130772020;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='state_above_anchor']"
			[Register ("state_above_anchor")]
			public const int StateAboveAnchor = (int) 2130772160;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='submitBackground']"
			[Register ("submitBackground")]
			public const int SubmitBackground = (int) 2130772173;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='subtitle']"
			[Register ("subtitle")]
			public const int Subtitle = (int) 2130771990;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='subtitleTextAppearance']"
			[Register ("subtitleTextAppearance")]
			public const int SubtitleTextAppearance = (int) 2130772182;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='subtitleTextColor']"
			[Register ("subtitleTextColor")]
			public const int SubtitleTextColor = (int) 2130772195;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='subtitleTextStyle']"
			[Register ("subtitleTextStyle")]
			public const int SubtitleTextStyle = (int) 2130771992;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='suggestionRowLayout']"
			[Register ("suggestionRowLayout")]
			public const int SuggestionRowLayout = (int) 2130772171;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='switchMinWidth']"
			[Register ("switchMinWidth")]
			public const int SwitchMinWidth = (int) 2130772177;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='switchPadding']"
			[Register ("switchPadding")]
			public const int SwitchPadding = (int) 2130772178;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='switchStyle']"
			[Register ("switchStyle")]
			public const int SwitchStyle = (int) 2130772131;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='switchTextAppearance']"
			[Register ("switchTextAppearance")]
			public const int SwitchTextAppearance = (int) 2130772176;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='textAllCaps']"
			[Register ("textAllCaps")]
			public const int TextAllCaps = (int) 2130772021;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='textAppearanceLargePopupMenu']"
			[Register ("textAppearanceLargePopupMenu")]
			public const int TextAppearanceLargePopupMenu = (int) 2130772060;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='textAppearanceListItem']"
			[Register ("textAppearanceListItem")]
			public const int TextAppearanceListItem = (int) 2130772096;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='textAppearanceListItemSmall']"
			[Register ("textAppearanceListItemSmall")]
			public const int TextAppearanceListItemSmall = (int) 2130772097;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='textAppearanceSearchResultSubtitle']"
			[Register ("textAppearanceSearchResultSubtitle")]
			public const int TextAppearanceSearchResultSubtitle = (int) 2130772086;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='textAppearanceSearchResultTitle']"
			[Register ("textAppearanceSearchResultTitle")]
			public const int TextAppearanceSearchResultTitle = (int) 2130772085;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='textAppearanceSmallPopupMenu']"
			[Register ("textAppearanceSmallPopupMenu")]
			public const int TextAppearanceSmallPopupMenu = (int) 2130772061;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='textColorAlertDialogListItem']"
			[Register ("textColorAlertDialogListItem")]
			public const int TextColorAlertDialogListItem = (int) 2130772115;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='textColorSearchUrl']"
			[Register ("textColorSearchUrl")]
			public const int TextColorSearchUrl = (int) 2130772087;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='theme']"
			[Register ("theme")]
			public const int Theme = (int) 2130772198;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='thickness']"
			[Register ("thickness")]
			public const int Thickness = (int) 2130772142;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='thumbTextPadding']"
			[Register ("thumbTextPadding")]
			public const int ThumbTextPadding = (int) 2130772175;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='title']"
			[Register ("title")]
			public const int Title = (int) 2130771987;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='titleMarginBottom']"
			[Register ("titleMarginBottom")]
			public const int TitleMarginBottom = (int) 2130772187;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='titleMarginEnd']"
			[Register ("titleMarginEnd")]
			public const int TitleMarginEnd = (int) 2130772185;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='titleMarginStart']"
			[Register ("titleMarginStart")]
			public const int TitleMarginStart = (int) 2130772184;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='titleMarginTop']"
			[Register ("titleMarginTop")]
			public const int TitleMarginTop = (int) 2130772186;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='titleMargins']"
			[Register ("titleMargins")]
			public const int TitleMargins = (int) 2130772183;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='titleTextAppearance']"
			[Register ("titleTextAppearance")]
			public const int TitleTextAppearance = (int) 2130772181;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='titleTextColor']"
			[Register ("titleTextColor")]
			public const int TitleTextColor = (int) 2130772194;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='titleTextStyle']"
			[Register ("titleTextStyle")]
			public const int TitleTextStyle = (int) 2130771991;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='toolbarNavigationButtonStyle']"
			[Register ("toolbarNavigationButtonStyle")]
			public const int ToolbarNavigationButtonStyle = (int) 2130772079;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='toolbarStyle']"
			[Register ("toolbarStyle")]
			public const int ToolbarStyle = (int) 2130772078;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='track']"
			[Register ("track")]
			public const int Track = (int) 2130772174;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='voiceIcon']"
			[Register ("voiceIcon")]
			public const int VoiceIcon = (int) 2130772169;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='windowActionBar']"
			[Register ("windowActionBar")]
			public const int WindowActionBar = (int) 2130772022;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='windowActionBarOverlay']"
			[Register ("windowActionBarOverlay")]
			public const int WindowActionBarOverlay = (int) 2130772024;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='windowActionModeOverlay']"
			[Register ("windowActionModeOverlay")]
			public const int WindowActionModeOverlay = (int) 2130772025;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='windowFixedHeightMajor']"
			[Register ("windowFixedHeightMajor")]
			public const int WindowFixedHeightMajor = (int) 2130772029;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='windowFixedHeightMinor']"
			[Register ("windowFixedHeightMinor")]
			public const int WindowFixedHeightMinor = (int) 2130772027;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='windowFixedWidthMajor']"
			[Register ("windowFixedWidthMajor")]
			public const int WindowFixedWidthMajor = (int) 2130772026;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='windowFixedWidthMinor']"
			[Register ("windowFixedWidthMinor")]
			public const int WindowFixedWidthMinor = (int) 2130772028;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='windowMinWidthMajor']"
			[Register ("windowMinWidthMajor")]
			public const int WindowMinWidthMajor = (int) 2130772030;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='windowMinWidthMinor']"
			[Register ("windowMinWidthMinor")]
			public const int WindowMinWidthMinor = (int) 2130772031;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/field[@name='windowNoTitle']"
			[Register ("windowNoTitle")]
			public const int WindowNoTitle = (int) 2130772023;
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("android/support/v7/appcompat/R$attr", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Attr); }
			}

			internal Attr (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.attr']/constructor[@name='R.attr' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Attr ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (((object) this).GetType () != typeof (Attr)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
						return;
					}

					if (id_ctor == IntPtr.Zero)
						id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.bool']"
		[global::Android.Runtime.Register ("android/support/v7/appcompat/R$bool", DoNotGenerateAcw=true)]
		public sealed partial class Bool : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.bool']/field[@name='abc_action_bar_embed_tabs']"
			[Register ("abc_action_bar_embed_tabs")]
			public const int AbcActionBarEmbedTabs = (int) 2131099651;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.bool']/field[@name='abc_action_bar_embed_tabs_pre_jb']"
			[Register ("abc_action_bar_embed_tabs_pre_jb")]
			public const int AbcActionBarEmbedTabsPreJb = (int) 2131099649;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.bool']/field[@name='abc_action_bar_expanded_action_views_exclusive']"
			[Register ("abc_action_bar_expanded_action_views_exclusive")]
			public const int AbcActionBarExpandedActionViewsExclusive = (int) 2131099652;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.bool']/field[@name='abc_allow_stacked_button_bar']"
			[Register ("abc_allow_stacked_button_bar")]
			public const int AbcAllowStackedButtonBar = (int) 2131099648;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.bool']/field[@name='abc_config_actionMenuItemAllCaps']"
			[Register ("abc_config_actionMenuItemAllCaps")]
			public const int AbcConfigActionMenuItemAllCaps = (int) 2131099653;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.bool']/field[@name='abc_config_allowActionMenuItemTextWithIcon']"
			[Register ("abc_config_allowActionMenuItemTextWithIcon")]
			public const int AbcConfigAllowActionMenuItemTextWithIcon = (int) 2131099650;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.bool']/field[@name='abc_config_closeDialogWhenTouchOutside']"
			[Register ("abc_config_closeDialogWhenTouchOutside")]
			public const int AbcConfigCloseDialogWhenTouchOutside = (int) 2131099654;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.bool']/field[@name='abc_config_showMenuShortcutsWhenKeyboardPresent']"
			[Register ("abc_config_showMenuShortcutsWhenKeyboardPresent")]
			public const int AbcConfigShowMenuShortcutsWhenKeyboardPresent = (int) 2131099655;
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("android/support/v7/appcompat/R$bool", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Bool); }
			}

			internal Bool (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.bool']/constructor[@name='R.bool' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Bool ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (((object) this).GetType () != typeof (Bool)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
						return;
					}

					if (id_ctor == IntPtr.Zero)
						id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.color']"
		[global::Android.Runtime.Register ("android/support/v7/appcompat/R$color", DoNotGenerateAcw=true)]
		public sealed partial class Color : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.color']/field[@name='abc_background_cache_hint_selector_material_dark']"
			[Register ("abc_background_cache_hint_selector_material_dark")]
			public const int AbcBackgroundCacheHintSelectorMaterialDark = (int) 2131427402;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.color']/field[@name='abc_background_cache_hint_selector_material_light']"
			[Register ("abc_background_cache_hint_selector_material_light")]
			public const int AbcBackgroundCacheHintSelectorMaterialLight = (int) 2131427403;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.color']/field[@name='abc_color_highlight_material']"
			[Register ("abc_color_highlight_material")]
			public const int AbcColorHighlightMaterial = (int) 2131427404;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.color']/field[@name='abc_input_method_navigation_guard']"
			[Register ("abc_input_method_navigation_guard")]
			public const int AbcInputMethodNavigationGuard = (int) 2131427328;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.color']/field[@name='abc_primary_text_disable_only_material_dark']"
			[Register ("abc_primary_text_disable_only_material_dark")]
			public const int AbcPrimaryTextDisableOnlyMaterialDark = (int) 2131427405;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.color']/field[@name='abc_primary_text_disable_only_material_light']"
			[Register ("abc_primary_text_disable_only_material_light")]
			public const int AbcPrimaryTextDisableOnlyMaterialLight = (int) 2131427406;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.color']/field[@name='abc_primary_text_material_dark']"
			[Register ("abc_primary_text_material_dark")]
			public const int AbcPrimaryTextMaterialDark = (int) 2131427407;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.color']/field[@name='abc_primary_text_material_light']"
			[Register ("abc_primary_text_material_light")]
			public const int AbcPrimaryTextMaterialLight = (int) 2131427408;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.color']/field[@name='abc_search_url_text']"
			[Register ("abc_search_url_text")]
			public const int AbcSearchUrlText = (int) 2131427409;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.color']/field[@name='abc_search_url_text_normal']"
			[Register ("abc_search_url_text_normal")]
			public const int AbcSearchUrlTextNormal = (int) 2131427329;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.color']/field[@name='abc_search_url_text_pressed']"
			[Register ("abc_search_url_text_pressed")]
			public const int AbcSearchUrlTextPressed = (int) 2131427330;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.color']/field[@name='abc_search_url_text_selected']"
			[Register ("abc_search_url_text_selected")]
			public const int AbcSearchUrlTextSelected = (int) 2131427331;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.color']/field[@name='abc_secondary_text_material_dark']"
			[Register ("abc_secondary_text_material_dark")]
			public const int AbcSecondaryTextMaterialDark = (int) 2131427410;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.color']/field[@name='abc_secondary_text_material_light']"
			[Register ("abc_secondary_text_material_light")]
			public const int AbcSecondaryTextMaterialLight = (int) 2131427411;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.color']/field[@name='accent_material_dark']"
			[Register ("accent_material_dark")]
			public const int AccentMaterialDark = (int) 2131427332;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.color']/field[@name='accent_material_light']"
			[Register ("accent_material_light")]
			public const int AccentMaterialLight = (int) 2131427333;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.color']/field[@name='background_floating_material_dark']"
			[Register ("background_floating_material_dark")]
			public const int BackgroundFloatingMaterialDark = (int) 2131427350;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.color']/field[@name='background_floating_material_light']"
			[Register ("background_floating_material_light")]
			public const int BackgroundFloatingMaterialLight = (int) 2131427351;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.color']/field[@name='background_material_dark']"
			[Register ("background_material_dark")]
			public const int BackgroundMaterialDark = (int) 2131427352;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.color']/field[@name='background_material_light']"
			[Register ("background_material_light")]
			public const int BackgroundMaterialLight = (int) 2131427353;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.color']/field[@name='bright_foreground_disabled_material_dark']"
			[Register ("bright_foreground_disabled_material_dark")]
			public const int BrightForegroundDisabledMaterialDark = (int) 2131427354;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.color']/field[@name='bright_foreground_disabled_material_light']"
			[Register ("bright_foreground_disabled_material_light")]
			public const int BrightForegroundDisabledMaterialLight = (int) 2131427355;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.color']/field[@name='bright_foreground_inverse_material_dark']"
			[Register ("bright_foreground_inverse_material_dark")]
			public const int BrightForegroundInverseMaterialDark = (int) 2131427356;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.color']/field[@name='bright_foreground_inverse_material_light']"
			[Register ("bright_foreground_inverse_material_light")]
			public const int BrightForegroundInverseMaterialLight = (int) 2131427357;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.color']/field[@name='bright_foreground_material_dark']"
			[Register ("bright_foreground_material_dark")]
			public const int BrightForegroundMaterialDark = (int) 2131427358;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.color']/field[@name='bright_foreground_material_light']"
			[Register ("bright_foreground_material_light")]
			public const int BrightForegroundMaterialLight = (int) 2131427359;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.color']/field[@name='button_material_dark']"
			[Register ("button_material_dark")]
			public const int ButtonMaterialDark = (int) 2131427360;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.color']/field[@name='button_material_light']"
			[Register ("button_material_light")]
			public const int ButtonMaterialLight = (int) 2131427361;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.color']/field[@name='dim_foreground_disabled_material_dark']"
			[Register ("dim_foreground_disabled_material_dark")]
			public const int DimForegroundDisabledMaterialDark = (int) 2131427362;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.color']/field[@name='dim_foreground_disabled_material_light']"
			[Register ("dim_foreground_disabled_material_light")]
			public const int DimForegroundDisabledMaterialLight = (int) 2131427363;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.color']/field[@name='dim_foreground_material_dark']"
			[Register ("dim_foreground_material_dark")]
			public const int DimForegroundMaterialDark = (int) 2131427364;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.color']/field[@name='dim_foreground_material_light']"
			[Register ("dim_foreground_material_light")]
			public const int DimForegroundMaterialLight = (int) 2131427365;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.color']/field[@name='foreground_material_dark']"
			[Register ("foreground_material_dark")]
			public const int ForegroundMaterialDark = (int) 2131427366;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.color']/field[@name='foreground_material_light']"
			[Register ("foreground_material_light")]
			public const int ForegroundMaterialLight = (int) 2131427367;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.color']/field[@name='highlighted_text_material_dark']"
			[Register ("highlighted_text_material_dark")]
			public const int HighlightedTextMaterialDark = (int) 2131427368;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.color']/field[@name='highlighted_text_material_light']"
			[Register ("highlighted_text_material_light")]
			public const int HighlightedTextMaterialLight = (int) 2131427369;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.color']/field[@name='hint_foreground_material_dark']"
			[Register ("hint_foreground_material_dark")]
			public const int HintForegroundMaterialDark = (int) 2131427370;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.color']/field[@name='hint_foreground_material_light']"
			[Register ("hint_foreground_material_light")]
			public const int HintForegroundMaterialLight = (int) 2131427371;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.color']/field[@name='material_blue_grey_800']"
			[Register ("material_blue_grey_800")]
			public const int MaterialBlueGrey800 = (int) 2131427372;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.color']/field[@name='material_blue_grey_900']"
			[Register ("material_blue_grey_900")]
			public const int MaterialBlueGrey900 = (int) 2131427373;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.color']/field[@name='material_blue_grey_950']"
			[Register ("material_blue_grey_950")]
			public const int MaterialBlueGrey950 = (int) 2131427374;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.color']/field[@name='material_deep_teal_200']"
			[Register ("material_deep_teal_200")]
			public const int MaterialDeepTeal200 = (int) 2131427375;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.color']/field[@name='material_deep_teal_500']"
			[Register ("material_deep_teal_500")]
			public const int MaterialDeepTeal500 = (int) 2131427376;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.color']/field[@name='material_grey_100']"
			[Register ("material_grey_100")]
			public const int MaterialGrey100 = (int) 2131427377;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.color']/field[@name='material_grey_300']"
			[Register ("material_grey_300")]
			public const int MaterialGrey300 = (int) 2131427378;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.color']/field[@name='material_grey_50']"
			[Register ("material_grey_50")]
			public const int MaterialGrey50 = (int) 2131427379;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.color']/field[@name='material_grey_600']"
			[Register ("material_grey_600")]
			public const int MaterialGrey600 = (int) 2131427380;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.color']/field[@name='material_grey_800']"
			[Register ("material_grey_800")]
			public const int MaterialGrey800 = (int) 2131427381;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.color']/field[@name='material_grey_850']"
			[Register ("material_grey_850")]
			public const int MaterialGrey850 = (int) 2131427382;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.color']/field[@name='material_grey_900']"
			[Register ("material_grey_900")]
			public const int MaterialGrey900 = (int) 2131427383;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.color']/field[@name='primary_dark_material_dark']"
			[Register ("primary_dark_material_dark")]
			public const int PrimaryDarkMaterialDark = (int) 2131427384;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.color']/field[@name='primary_dark_material_light']"
			[Register ("primary_dark_material_light")]
			public const int PrimaryDarkMaterialLight = (int) 2131427385;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.color']/field[@name='primary_material_dark']"
			[Register ("primary_material_dark")]
			public const int PrimaryMaterialDark = (int) 2131427386;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.color']/field[@name='primary_material_light']"
			[Register ("primary_material_light")]
			public const int PrimaryMaterialLight = (int) 2131427387;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.color']/field[@name='primary_text_default_material_dark']"
			[Register ("primary_text_default_material_dark")]
			public const int PrimaryTextDefaultMaterialDark = (int) 2131427388;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.color']/field[@name='primary_text_default_material_light']"
			[Register ("primary_text_default_material_light")]
			public const int PrimaryTextDefaultMaterialLight = (int) 2131427389;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.color']/field[@name='primary_text_disabled_material_dark']"
			[Register ("primary_text_disabled_material_dark")]
			public const int PrimaryTextDisabledMaterialDark = (int) 2131427390;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.color']/field[@name='primary_text_disabled_material_light']"
			[Register ("primary_text_disabled_material_light")]
			public const int PrimaryTextDisabledMaterialLight = (int) 2131427391;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.color']/field[@name='ripple_material_dark']"
			[Register ("ripple_material_dark")]
			public const int RippleMaterialDark = (int) 2131427392;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.color']/field[@name='ripple_material_light']"
			[Register ("ripple_material_light")]
			public const int RippleMaterialLight = (int) 2131427393;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.color']/field[@name='secondary_text_default_material_dark']"
			[Register ("secondary_text_default_material_dark")]
			public const int SecondaryTextDefaultMaterialDark = (int) 2131427394;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.color']/field[@name='secondary_text_default_material_light']"
			[Register ("secondary_text_default_material_light")]
			public const int SecondaryTextDefaultMaterialLight = (int) 2131427395;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.color']/field[@name='secondary_text_disabled_material_dark']"
			[Register ("secondary_text_disabled_material_dark")]
			public const int SecondaryTextDisabledMaterialDark = (int) 2131427396;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.color']/field[@name='secondary_text_disabled_material_light']"
			[Register ("secondary_text_disabled_material_light")]
			public const int SecondaryTextDisabledMaterialLight = (int) 2131427397;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.color']/field[@name='switch_thumb_disabled_material_dark']"
			[Register ("switch_thumb_disabled_material_dark")]
			public const int SwitchThumbDisabledMaterialDark = (int) 2131427398;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.color']/field[@name='switch_thumb_disabled_material_light']"
			[Register ("switch_thumb_disabled_material_light")]
			public const int SwitchThumbDisabledMaterialLight = (int) 2131427399;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.color']/field[@name='switch_thumb_material_dark']"
			[Register ("switch_thumb_material_dark")]
			public const int SwitchThumbMaterialDark = (int) 2131427412;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.color']/field[@name='switch_thumb_material_light']"
			[Register ("switch_thumb_material_light")]
			public const int SwitchThumbMaterialLight = (int) 2131427413;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.color']/field[@name='switch_thumb_normal_material_dark']"
			[Register ("switch_thumb_normal_material_dark")]
			public const int SwitchThumbNormalMaterialDark = (int) 2131427400;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.color']/field[@name='switch_thumb_normal_material_light']"
			[Register ("switch_thumb_normal_material_light")]
			public const int SwitchThumbNormalMaterialLight = (int) 2131427401;
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("android/support/v7/appcompat/R$color", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Color); }
			}

			internal Color (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.color']/constructor[@name='R.color' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Color ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (((object) this).GetType () != typeof (Color)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
						return;
					}

					if (id_ctor == IntPtr.Zero)
						id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.dimen']"
		[global::Android.Runtime.Register ("android/support/v7/appcompat/R$dimen", DoNotGenerateAcw=true)]
		public sealed partial class Dimen : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.dimen']/field[@name='abc_action_bar_content_inset_material']"
			[Register ("abc_action_bar_content_inset_material")]
			public const int AbcActionBarContentInsetMaterial = (int) 2131165197;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.dimen']/field[@name='abc_action_bar_default_height_material']"
			[Register ("abc_action_bar_default_height_material")]
			public const int AbcActionBarDefaultHeightMaterial = (int) 2131165185;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.dimen']/field[@name='abc_action_bar_default_padding_end_material']"
			[Register ("abc_action_bar_default_padding_end_material")]
			public const int AbcActionBarDefaultPaddingEndMaterial = (int) 2131165198;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.dimen']/field[@name='abc_action_bar_default_padding_start_material']"
			[Register ("abc_action_bar_default_padding_start_material")]
			public const int AbcActionBarDefaultPaddingStartMaterial = (int) 2131165199;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.dimen']/field[@name='abc_action_bar_icon_vertical_padding_material']"
			[Register ("abc_action_bar_icon_vertical_padding_material")]
			public const int AbcActionBarIconVerticalPaddingMaterial = (int) 2131165202;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.dimen']/field[@name='abc_action_bar_overflow_padding_end_material']"
			[Register ("abc_action_bar_overflow_padding_end_material")]
			public const int AbcActionBarOverflowPaddingEndMaterial = (int) 2131165203;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.dimen']/field[@name='abc_action_bar_overflow_padding_start_material']"
			[Register ("abc_action_bar_overflow_padding_start_material")]
			public const int AbcActionBarOverflowPaddingStartMaterial = (int) 2131165204;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.dimen']/field[@name='abc_action_bar_progress_bar_size']"
			[Register ("abc_action_bar_progress_bar_size")]
			public const int AbcActionBarProgressBarSize = (int) 2131165186;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.dimen']/field[@name='abc_action_bar_stacked_max_height']"
			[Register ("abc_action_bar_stacked_max_height")]
			public const int AbcActionBarStackedMaxHeight = (int) 2131165205;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.dimen']/field[@name='abc_action_bar_stacked_tab_max_width']"
			[Register ("abc_action_bar_stacked_tab_max_width")]
			public const int AbcActionBarStackedTabMaxWidth = (int) 2131165206;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.dimen']/field[@name='abc_action_bar_subtitle_bottom_margin_material']"
			[Register ("abc_action_bar_subtitle_bottom_margin_material")]
			public const int AbcActionBarSubtitleBottomMarginMaterial = (int) 2131165207;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.dimen']/field[@name='abc_action_bar_subtitle_top_margin_material']"
			[Register ("abc_action_bar_subtitle_top_margin_material")]
			public const int AbcActionBarSubtitleTopMarginMaterial = (int) 2131165208;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.dimen']/field[@name='abc_action_button_min_height_material']"
			[Register ("abc_action_button_min_height_material")]
			public const int AbcActionButtonMinHeightMaterial = (int) 2131165209;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.dimen']/field[@name='abc_action_button_min_width_material']"
			[Register ("abc_action_button_min_width_material")]
			public const int AbcActionButtonMinWidthMaterial = (int) 2131165210;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.dimen']/field[@name='abc_action_button_min_width_overflow_material']"
			[Register ("abc_action_button_min_width_overflow_material")]
			public const int AbcActionButtonMinWidthOverflowMaterial = (int) 2131165211;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.dimen']/field[@name='abc_alert_dialog_button_bar_height']"
			[Register ("abc_alert_dialog_button_bar_height")]
			public const int AbcAlertDialogButtonBarHeight = (int) 2131165184;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.dimen']/field[@name='abc_button_inset_horizontal_material']"
			[Register ("abc_button_inset_horizontal_material")]
			public const int AbcButtonInsetHorizontalMaterial = (int) 2131165212;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.dimen']/field[@name='abc_button_inset_vertical_material']"
			[Register ("abc_button_inset_vertical_material")]
			public const int AbcButtonInsetVerticalMaterial = (int) 2131165213;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.dimen']/field[@name='abc_button_padding_horizontal_material']"
			[Register ("abc_button_padding_horizontal_material")]
			public const int AbcButtonPaddingHorizontalMaterial = (int) 2131165214;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.dimen']/field[@name='abc_button_padding_vertical_material']"
			[Register ("abc_button_padding_vertical_material")]
			public const int AbcButtonPaddingVerticalMaterial = (int) 2131165215;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.dimen']/field[@name='abc_config_prefDialogWidth']"
			[Register ("abc_config_prefDialogWidth")]
			public const int AbcConfigPrefDialogWidth = (int) 2131165189;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.dimen']/field[@name='abc_control_corner_material']"
			[Register ("abc_control_corner_material")]
			public const int AbcControlCornerMaterial = (int) 2131165216;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.dimen']/field[@name='abc_control_inset_material']"
			[Register ("abc_control_inset_material")]
			public const int AbcControlInsetMaterial = (int) 2131165217;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.dimen']/field[@name='abc_control_padding_material']"
			[Register ("abc_control_padding_material")]
			public const int AbcControlPaddingMaterial = (int) 2131165218;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.dimen']/field[@name='abc_dialog_fixed_height_major']"
			[Register ("abc_dialog_fixed_height_major")]
			public const int AbcDialogFixedHeightMajor = (int) 2131165190;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.dimen']/field[@name='abc_dialog_fixed_height_minor']"
			[Register ("abc_dialog_fixed_height_minor")]
			public const int AbcDialogFixedHeightMinor = (int) 2131165191;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.dimen']/field[@name='abc_dialog_fixed_width_major']"
			[Register ("abc_dialog_fixed_width_major")]
			public const int AbcDialogFixedWidthMajor = (int) 2131165192;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.dimen']/field[@name='abc_dialog_fixed_width_minor']"
			[Register ("abc_dialog_fixed_width_minor")]
			public const int AbcDialogFixedWidthMinor = (int) 2131165193;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.dimen']/field[@name='abc_dialog_list_padding_vertical_material']"
			[Register ("abc_dialog_list_padding_vertical_material")]
			public const int AbcDialogListPaddingVerticalMaterial = (int) 2131165219;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.dimen']/field[@name='abc_dialog_min_width_major']"
			[Register ("abc_dialog_min_width_major")]
			public const int AbcDialogMinWidthMajor = (int) 2131165194;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.dimen']/field[@name='abc_dialog_min_width_minor']"
			[Register ("abc_dialog_min_width_minor")]
			public const int AbcDialogMinWidthMinor = (int) 2131165195;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.dimen']/field[@name='abc_dialog_padding_material']"
			[Register ("abc_dialog_padding_material")]
			public const int AbcDialogPaddingMaterial = (int) 2131165220;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.dimen']/field[@name='abc_dialog_padding_top_material']"
			[Register ("abc_dialog_padding_top_material")]
			public const int AbcDialogPaddingTopMaterial = (int) 2131165221;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.dimen']/field[@name='abc_disabled_alpha_material_dark']"
			[Register ("abc_disabled_alpha_material_dark")]
			public const int AbcDisabledAlphaMaterialDark = (int) 2131165222;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.dimen']/field[@name='abc_disabled_alpha_material_light']"
			[Register ("abc_disabled_alpha_material_light")]
			public const int AbcDisabledAlphaMaterialLight = (int) 2131165223;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.dimen']/field[@name='abc_dropdownitem_icon_width']"
			[Register ("abc_dropdownitem_icon_width")]
			public const int AbcDropdownitemIconWidth = (int) 2131165224;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.dimen']/field[@name='abc_dropdownitem_text_padding_left']"
			[Register ("abc_dropdownitem_text_padding_left")]
			public const int AbcDropdownitemTextPaddingLeft = (int) 2131165225;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.dimen']/field[@name='abc_dropdownitem_text_padding_right']"
			[Register ("abc_dropdownitem_text_padding_right")]
			public const int AbcDropdownitemTextPaddingRight = (int) 2131165226;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.dimen']/field[@name='abc_edit_text_inset_bottom_material']"
			[Register ("abc_edit_text_inset_bottom_material")]
			public const int AbcEditTextInsetBottomMaterial = (int) 2131165227;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.dimen']/field[@name='abc_edit_text_inset_horizontal_material']"
			[Register ("abc_edit_text_inset_horizontal_material")]
			public const int AbcEditTextInsetHorizontalMaterial = (int) 2131165228;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.dimen']/field[@name='abc_edit_text_inset_top_material']"
			[Register ("abc_edit_text_inset_top_material")]
			public const int AbcEditTextInsetTopMaterial = (int) 2131165229;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.dimen']/field[@name='abc_floating_window_z']"
			[Register ("abc_floating_window_z")]
			public const int AbcFloatingWindowZ = (int) 2131165230;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.dimen']/field[@name='abc_list_item_padding_horizontal_material']"
			[Register ("abc_list_item_padding_horizontal_material")]
			public const int AbcListItemPaddingHorizontalMaterial = (int) 2131165231;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.dimen']/field[@name='abc_panel_menu_list_width']"
			[Register ("abc_panel_menu_list_width")]
			public const int AbcPanelMenuListWidth = (int) 2131165232;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.dimen']/field[@name='abc_search_view_preferred_width']"
			[Register ("abc_search_view_preferred_width")]
			public const int AbcSearchViewPreferredWidth = (int) 2131165233;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.dimen']/field[@name='abc_search_view_text_min_width']"
			[Register ("abc_search_view_text_min_width")]
			public const int AbcSearchViewTextMinWidth = (int) 2131165196;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.dimen']/field[@name='abc_seekbar_track_background_height_material']"
			[Register ("abc_seekbar_track_background_height_material")]
			public const int AbcSeekbarTrackBackgroundHeightMaterial = (int) 2131165234;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.dimen']/field[@name='abc_seekbar_track_progress_height_material']"
			[Register ("abc_seekbar_track_progress_height_material")]
			public const int AbcSeekbarTrackProgressHeightMaterial = (int) 2131165235;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.dimen']/field[@name='abc_select_dialog_padding_start_material']"
			[Register ("abc_select_dialog_padding_start_material")]
			public const int AbcSelectDialogPaddingStartMaterial = (int) 2131165236;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.dimen']/field[@name='abc_switch_padding']"
			[Register ("abc_switch_padding")]
			public const int AbcSwitchPadding = (int) 2131165200;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.dimen']/field[@name='abc_text_size_body_1_material']"
			[Register ("abc_text_size_body_1_material")]
			public const int AbcTextSizeBody1Material = (int) 2131165237;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.dimen']/field[@name='abc_text_size_body_2_material']"
			[Register ("abc_text_size_body_2_material")]
			public const int AbcTextSizeBody2Material = (int) 2131165238;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.dimen']/field[@name='abc_text_size_button_material']"
			[Register ("abc_text_size_button_material")]
			public const int AbcTextSizeButtonMaterial = (int) 2131165239;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.dimen']/field[@name='abc_text_size_caption_material']"
			[Register ("abc_text_size_caption_material")]
			public const int AbcTextSizeCaptionMaterial = (int) 2131165240;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.dimen']/field[@name='abc_text_size_display_1_material']"
			[Register ("abc_text_size_display_1_material")]
			public const int AbcTextSizeDisplay1Material = (int) 2131165241;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.dimen']/field[@name='abc_text_size_display_2_material']"
			[Register ("abc_text_size_display_2_material")]
			public const int AbcTextSizeDisplay2Material = (int) 2131165242;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.dimen']/field[@name='abc_text_size_display_3_material']"
			[Register ("abc_text_size_display_3_material")]
			public const int AbcTextSizeDisplay3Material = (int) 2131165243;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.dimen']/field[@name='abc_text_size_display_4_material']"
			[Register ("abc_text_size_display_4_material")]
			public const int AbcTextSizeDisplay4Material = (int) 2131165244;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.dimen']/field[@name='abc_text_size_headline_material']"
			[Register ("abc_text_size_headline_material")]
			public const int AbcTextSizeHeadlineMaterial = (int) 2131165245;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.dimen']/field[@name='abc_text_size_large_material']"
			[Register ("abc_text_size_large_material")]
			public const int AbcTextSizeLargeMaterial = (int) 2131165246;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.dimen']/field[@name='abc_text_size_medium_material']"
			[Register ("abc_text_size_medium_material")]
			public const int AbcTextSizeMediumMaterial = (int) 2131165247;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.dimen']/field[@name='abc_text_size_menu_material']"
			[Register ("abc_text_size_menu_material")]
			public const int AbcTextSizeMenuMaterial = (int) 2131165248;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.dimen']/field[@name='abc_text_size_small_material']"
			[Register ("abc_text_size_small_material")]
			public const int AbcTextSizeSmallMaterial = (int) 2131165249;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.dimen']/field[@name='abc_text_size_subhead_material']"
			[Register ("abc_text_size_subhead_material")]
			public const int AbcTextSizeSubheadMaterial = (int) 2131165250;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.dimen']/field[@name='abc_text_size_subtitle_material_toolbar']"
			[Register ("abc_text_size_subtitle_material_toolbar")]
			public const int AbcTextSizeSubtitleMaterialToolbar = (int) 2131165187;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.dimen']/field[@name='abc_text_size_title_material']"
			[Register ("abc_text_size_title_material")]
			public const int AbcTextSizeTitleMaterial = (int) 2131165251;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.dimen']/field[@name='abc_text_size_title_material_toolbar']"
			[Register ("abc_text_size_title_material_toolbar")]
			public const int AbcTextSizeTitleMaterialToolbar = (int) 2131165188;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.dimen']/field[@name='disabled_alpha_material_dark']"
			[Register ("disabled_alpha_material_dark")]
			public const int DisabledAlphaMaterialDark = (int) 2131165253;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.dimen']/field[@name='disabled_alpha_material_light']"
			[Register ("disabled_alpha_material_light")]
			public const int DisabledAlphaMaterialLight = (int) 2131165254;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.dimen']/field[@name='highlight_alpha_material_colored']"
			[Register ("highlight_alpha_material_colored")]
			public const int HighlightAlphaMaterialColored = (int) 2131165255;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.dimen']/field[@name='highlight_alpha_material_dark']"
			[Register ("highlight_alpha_material_dark")]
			public const int HighlightAlphaMaterialDark = (int) 2131165256;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.dimen']/field[@name='highlight_alpha_material_light']"
			[Register ("highlight_alpha_material_light")]
			public const int HighlightAlphaMaterialLight = (int) 2131165257;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.dimen']/field[@name='notification_large_icon_height']"
			[Register ("notification_large_icon_height")]
			public const int NotificationLargeIconHeight = (int) 2131165258;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.dimen']/field[@name='notification_large_icon_width']"
			[Register ("notification_large_icon_width")]
			public const int NotificationLargeIconWidth = (int) 2131165259;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.dimen']/field[@name='notification_subtext_size']"
			[Register ("notification_subtext_size")]
			public const int NotificationSubtextSize = (int) 2131165260;
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("android/support/v7/appcompat/R$dimen", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Dimen); }
			}

			internal Dimen (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.dimen']/constructor[@name='R.dimen' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Dimen ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (((object) this).GetType () != typeof (Dimen)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
						return;
					}

					if (id_ctor == IntPtr.Zero)
						id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.drawable']"
		[global::Android.Runtime.Register ("android/support/v7/appcompat/R$drawable", DoNotGenerateAcw=true)]
		public sealed partial class Drawable : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.drawable']/field[@name='abc_ab_share_pack_mtrl_alpha']"
			[Register ("abc_ab_share_pack_mtrl_alpha")]
			public const int AbcAbSharePackMtrlAlpha = (int) 2130837504;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.drawable']/field[@name='abc_action_bar_item_background_material']"
			[Register ("abc_action_bar_item_background_material")]
			public const int AbcActionBarItemBackgroundMaterial = (int) 2130837505;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.drawable']/field[@name='abc_btn_borderless_material']"
			[Register ("abc_btn_borderless_material")]
			public const int AbcBtnBorderlessMaterial = (int) 2130837506;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.drawable']/field[@name='abc_btn_check_material']"
			[Register ("abc_btn_check_material")]
			public const int AbcBtnCheckMaterial = (int) 2130837507;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.drawable']/field[@name='abc_btn_check_to_on_mtrl_000']"
			[Register ("abc_btn_check_to_on_mtrl_000")]
			public const int AbcBtnCheckToOnMtrl000 = (int) 2130837508;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.drawable']/field[@name='abc_btn_check_to_on_mtrl_015']"
			[Register ("abc_btn_check_to_on_mtrl_015")]
			public const int AbcBtnCheckToOnMtrl015 = (int) 2130837509;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.drawable']/field[@name='abc_btn_colored_material']"
			[Register ("abc_btn_colored_material")]
			public const int AbcBtnColoredMaterial = (int) 2130837510;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.drawable']/field[@name='abc_btn_default_mtrl_shape']"
			[Register ("abc_btn_default_mtrl_shape")]
			public const int AbcBtnDefaultMtrlShape = (int) 2130837511;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.drawable']/field[@name='abc_btn_radio_material']"
			[Register ("abc_btn_radio_material")]
			public const int AbcBtnRadioMaterial = (int) 2130837512;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.drawable']/field[@name='abc_btn_radio_to_on_mtrl_000']"
			[Register ("abc_btn_radio_to_on_mtrl_000")]
			public const int AbcBtnRadioToOnMtrl000 = (int) 2130837513;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.drawable']/field[@name='abc_btn_radio_to_on_mtrl_015']"
			[Register ("abc_btn_radio_to_on_mtrl_015")]
			public const int AbcBtnRadioToOnMtrl015 = (int) 2130837514;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.drawable']/field[@name='abc_btn_rating_star_off_mtrl_alpha']"
			[Register ("abc_btn_rating_star_off_mtrl_alpha")]
			public const int AbcBtnRatingStarOffMtrlAlpha = (int) 2130837515;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.drawable']/field[@name='abc_btn_rating_star_on_mtrl_alpha']"
			[Register ("abc_btn_rating_star_on_mtrl_alpha")]
			public const int AbcBtnRatingStarOnMtrlAlpha = (int) 2130837516;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.drawable']/field[@name='abc_btn_switch_to_on_mtrl_00001']"
			[Register ("abc_btn_switch_to_on_mtrl_00001")]
			public const int AbcBtnSwitchToOnMtrl00001 = (int) 2130837517;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.drawable']/field[@name='abc_btn_switch_to_on_mtrl_00012']"
			[Register ("abc_btn_switch_to_on_mtrl_00012")]
			public const int AbcBtnSwitchToOnMtrl00012 = (int) 2130837518;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.drawable']/field[@name='abc_cab_background_internal_bg']"
			[Register ("abc_cab_background_internal_bg")]
			public const int AbcCabBackgroundInternalBg = (int) 2130837519;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.drawable']/field[@name='abc_cab_background_top_material']"
			[Register ("abc_cab_background_top_material")]
			public const int AbcCabBackgroundTopMaterial = (int) 2130837520;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.drawable']/field[@name='abc_cab_background_top_mtrl_alpha']"
			[Register ("abc_cab_background_top_mtrl_alpha")]
			public const int AbcCabBackgroundTopMtrlAlpha = (int) 2130837521;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.drawable']/field[@name='abc_control_background_material']"
			[Register ("abc_control_background_material")]
			public const int AbcControlBackgroundMaterial = (int) 2130837522;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.drawable']/field[@name='abc_dialog_material_background_dark']"
			[Register ("abc_dialog_material_background_dark")]
			public const int AbcDialogMaterialBackgroundDark = (int) 2130837523;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.drawable']/field[@name='abc_dialog_material_background_light']"
			[Register ("abc_dialog_material_background_light")]
			public const int AbcDialogMaterialBackgroundLight = (int) 2130837524;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.drawable']/field[@name='abc_edit_text_material']"
			[Register ("abc_edit_text_material")]
			public const int AbcEditTextMaterial = (int) 2130837525;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.drawable']/field[@name='abc_ic_ab_back_mtrl_am_alpha']"
			[Register ("abc_ic_ab_back_mtrl_am_alpha")]
			public const int AbcIcAbBackMtrlAmAlpha = (int) 2130837526;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.drawable']/field[@name='abc_ic_clear_mtrl_alpha']"
			[Register ("abc_ic_clear_mtrl_alpha")]
			public const int AbcIcClearMtrlAlpha = (int) 2130837527;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.drawable']/field[@name='abc_ic_commit_search_api_mtrl_alpha']"
			[Register ("abc_ic_commit_search_api_mtrl_alpha")]
			public const int AbcIcCommitSearchApiMtrlAlpha = (int) 2130837528;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.drawable']/field[@name='abc_ic_go_search_api_mtrl_alpha']"
			[Register ("abc_ic_go_search_api_mtrl_alpha")]
			public const int AbcIcGoSearchApiMtrlAlpha = (int) 2130837529;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.drawable']/field[@name='abc_ic_menu_copy_mtrl_am_alpha']"
			[Register ("abc_ic_menu_copy_mtrl_am_alpha")]
			public const int AbcIcMenuCopyMtrlAmAlpha = (int) 2130837530;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.drawable']/field[@name='abc_ic_menu_cut_mtrl_alpha']"
			[Register ("abc_ic_menu_cut_mtrl_alpha")]
			public const int AbcIcMenuCutMtrlAlpha = (int) 2130837531;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.drawable']/field[@name='abc_ic_menu_moreoverflow_mtrl_alpha']"
			[Register ("abc_ic_menu_moreoverflow_mtrl_alpha")]
			public const int AbcIcMenuMoreoverflowMtrlAlpha = (int) 2130837532;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.drawable']/field[@name='abc_ic_menu_paste_mtrl_am_alpha']"
			[Register ("abc_ic_menu_paste_mtrl_am_alpha")]
			public const int AbcIcMenuPasteMtrlAmAlpha = (int) 2130837533;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.drawable']/field[@name='abc_ic_menu_selectall_mtrl_alpha']"
			[Register ("abc_ic_menu_selectall_mtrl_alpha")]
			public const int AbcIcMenuSelectallMtrlAlpha = (int) 2130837534;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.drawable']/field[@name='abc_ic_menu_share_mtrl_alpha']"
			[Register ("abc_ic_menu_share_mtrl_alpha")]
			public const int AbcIcMenuShareMtrlAlpha = (int) 2130837535;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.drawable']/field[@name='abc_ic_search_api_mtrl_alpha']"
			[Register ("abc_ic_search_api_mtrl_alpha")]
			public const int AbcIcSearchApiMtrlAlpha = (int) 2130837536;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.drawable']/field[@name='abc_ic_star_black_16dp']"
			[Register ("abc_ic_star_black_16dp")]
			public const int AbcIcStarBlack16dp = (int) 2130837537;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.drawable']/field[@name='abc_ic_star_black_36dp']"
			[Register ("abc_ic_star_black_36dp")]
			public const int AbcIcStarBlack36dp = (int) 2130837538;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.drawable']/field[@name='abc_ic_star_half_black_16dp']"
			[Register ("abc_ic_star_half_black_16dp")]
			public const int AbcIcStarHalfBlack16dp = (int) 2130837539;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.drawable']/field[@name='abc_ic_star_half_black_36dp']"
			[Register ("abc_ic_star_half_black_36dp")]
			public const int AbcIcStarHalfBlack36dp = (int) 2130837540;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.drawable']/field[@name='abc_ic_voice_search_api_mtrl_alpha']"
			[Register ("abc_ic_voice_search_api_mtrl_alpha")]
			public const int AbcIcVoiceSearchApiMtrlAlpha = (int) 2130837541;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.drawable']/field[@name='abc_item_background_holo_dark']"
			[Register ("abc_item_background_holo_dark")]
			public const int AbcItemBackgroundHoloDark = (int) 2130837542;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.drawable']/field[@name='abc_item_background_holo_light']"
			[Register ("abc_item_background_holo_light")]
			public const int AbcItemBackgroundHoloLight = (int) 2130837543;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.drawable']/field[@name='abc_list_divider_mtrl_alpha']"
			[Register ("abc_list_divider_mtrl_alpha")]
			public const int AbcListDividerMtrlAlpha = (int) 2130837544;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.drawable']/field[@name='abc_list_focused_holo']"
			[Register ("abc_list_focused_holo")]
			public const int AbcListFocusedHolo = (int) 2130837545;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.drawable']/field[@name='abc_list_longpressed_holo']"
			[Register ("abc_list_longpressed_holo")]
			public const int AbcListLongpressedHolo = (int) 2130837546;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.drawable']/field[@name='abc_list_pressed_holo_dark']"
			[Register ("abc_list_pressed_holo_dark")]
			public const int AbcListPressedHoloDark = (int) 2130837547;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.drawable']/field[@name='abc_list_pressed_holo_light']"
			[Register ("abc_list_pressed_holo_light")]
			public const int AbcListPressedHoloLight = (int) 2130837548;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.drawable']/field[@name='abc_list_selector_background_transition_holo_dark']"
			[Register ("abc_list_selector_background_transition_holo_dark")]
			public const int AbcListSelectorBackgroundTransitionHoloDark = (int) 2130837549;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.drawable']/field[@name='abc_list_selector_background_transition_holo_light']"
			[Register ("abc_list_selector_background_transition_holo_light")]
			public const int AbcListSelectorBackgroundTransitionHoloLight = (int) 2130837550;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.drawable']/field[@name='abc_list_selector_disabled_holo_dark']"
			[Register ("abc_list_selector_disabled_holo_dark")]
			public const int AbcListSelectorDisabledHoloDark = (int) 2130837551;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.drawable']/field[@name='abc_list_selector_disabled_holo_light']"
			[Register ("abc_list_selector_disabled_holo_light")]
			public const int AbcListSelectorDisabledHoloLight = (int) 2130837552;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.drawable']/field[@name='abc_list_selector_holo_dark']"
			[Register ("abc_list_selector_holo_dark")]
			public const int AbcListSelectorHoloDark = (int) 2130837553;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.drawable']/field[@name='abc_list_selector_holo_light']"
			[Register ("abc_list_selector_holo_light")]
			public const int AbcListSelectorHoloLight = (int) 2130837554;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.drawable']/field[@name='abc_menu_hardkey_panel_mtrl_mult']"
			[Register ("abc_menu_hardkey_panel_mtrl_mult")]
			public const int AbcMenuHardkeyPanelMtrlMult = (int) 2130837555;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.drawable']/field[@name='abc_popup_background_mtrl_mult']"
			[Register ("abc_popup_background_mtrl_mult")]
			public const int AbcPopupBackgroundMtrlMult = (int) 2130837556;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.drawable']/field[@name='abc_ratingbar_full_material']"
			[Register ("abc_ratingbar_full_material")]
			public const int AbcRatingbarFullMaterial = (int) 2130837557;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.drawable']/field[@name='abc_ratingbar_indicator_material']"
			[Register ("abc_ratingbar_indicator_material")]
			public const int AbcRatingbarIndicatorMaterial = (int) 2130837558;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.drawable']/field[@name='abc_ratingbar_small_material']"
			[Register ("abc_ratingbar_small_material")]
			public const int AbcRatingbarSmallMaterial = (int) 2130837559;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.drawable']/field[@name='abc_scrubber_control_off_mtrl_alpha']"
			[Register ("abc_scrubber_control_off_mtrl_alpha")]
			public const int AbcScrubberControlOffMtrlAlpha = (int) 2130837560;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.drawable']/field[@name='abc_scrubber_control_to_pressed_mtrl_000']"
			[Register ("abc_scrubber_control_to_pressed_mtrl_000")]
			public const int AbcScrubberControlToPressedMtrl000 = (int) 2130837561;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.drawable']/field[@name='abc_scrubber_control_to_pressed_mtrl_005']"
			[Register ("abc_scrubber_control_to_pressed_mtrl_005")]
			public const int AbcScrubberControlToPressedMtrl005 = (int) 2130837562;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.drawable']/field[@name='abc_scrubber_primary_mtrl_alpha']"
			[Register ("abc_scrubber_primary_mtrl_alpha")]
			public const int AbcScrubberPrimaryMtrlAlpha = (int) 2130837563;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.drawable']/field[@name='abc_scrubber_track_mtrl_alpha']"
			[Register ("abc_scrubber_track_mtrl_alpha")]
			public const int AbcScrubberTrackMtrlAlpha = (int) 2130837564;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.drawable']/field[@name='abc_seekbar_thumb_material']"
			[Register ("abc_seekbar_thumb_material")]
			public const int AbcSeekbarThumbMaterial = (int) 2130837565;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.drawable']/field[@name='abc_seekbar_track_material']"
			[Register ("abc_seekbar_track_material")]
			public const int AbcSeekbarTrackMaterial = (int) 2130837566;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.drawable']/field[@name='abc_spinner_mtrl_am_alpha']"
			[Register ("abc_spinner_mtrl_am_alpha")]
			public const int AbcSpinnerMtrlAmAlpha = (int) 2130837567;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.drawable']/field[@name='abc_spinner_textfield_background_material']"
			[Register ("abc_spinner_textfield_background_material")]
			public const int AbcSpinnerTextfieldBackgroundMaterial = (int) 2130837568;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.drawable']/field[@name='abc_switch_thumb_material']"
			[Register ("abc_switch_thumb_material")]
			public const int AbcSwitchThumbMaterial = (int) 2130837569;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.drawable']/field[@name='abc_switch_track_mtrl_alpha']"
			[Register ("abc_switch_track_mtrl_alpha")]
			public const int AbcSwitchTrackMtrlAlpha = (int) 2130837570;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.drawable']/field[@name='abc_tab_indicator_material']"
			[Register ("abc_tab_indicator_material")]
			public const int AbcTabIndicatorMaterial = (int) 2130837571;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.drawable']/field[@name='abc_tab_indicator_mtrl_alpha']"
			[Register ("abc_tab_indicator_mtrl_alpha")]
			public const int AbcTabIndicatorMtrlAlpha = (int) 2130837572;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.drawable']/field[@name='abc_text_cursor_material']"
			[Register ("abc_text_cursor_material")]
			public const int AbcTextCursorMaterial = (int) 2130837573;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.drawable']/field[@name='abc_textfield_activated_mtrl_alpha']"
			[Register ("abc_textfield_activated_mtrl_alpha")]
			public const int AbcTextfieldActivatedMtrlAlpha = (int) 2130837574;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.drawable']/field[@name='abc_textfield_default_mtrl_alpha']"
			[Register ("abc_textfield_default_mtrl_alpha")]
			public const int AbcTextfieldDefaultMtrlAlpha = (int) 2130837575;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.drawable']/field[@name='abc_textfield_search_activated_mtrl_alpha']"
			[Register ("abc_textfield_search_activated_mtrl_alpha")]
			public const int AbcTextfieldSearchActivatedMtrlAlpha = (int) 2130837576;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.drawable']/field[@name='abc_textfield_search_default_mtrl_alpha']"
			[Register ("abc_textfield_search_default_mtrl_alpha")]
			public const int AbcTextfieldSearchDefaultMtrlAlpha = (int) 2130837577;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.drawable']/field[@name='abc_textfield_search_material']"
			[Register ("abc_textfield_search_material")]
			public const int AbcTextfieldSearchMaterial = (int) 2130837578;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.drawable']/field[@name='notification_template_icon_bg']"
			[Register ("notification_template_icon_bg")]
			public const int NotificationTemplateIconBg = (int) 2130837596;
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("android/support/v7/appcompat/R$drawable", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Drawable); }
			}

			internal Drawable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.drawable']/constructor[@name='R.drawable' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Drawable ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (((object) this).GetType () != typeof (Drawable)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
						return;
					}

					if (id_ctor == IntPtr.Zero)
						id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.id']"
		[global::Android.Runtime.Register ("android/support/v7/appcompat/R$id", DoNotGenerateAcw=true)]
		public sealed partial class Id : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.id']/field[@name='action0']"
			[Register ("action0")]
			public const int Action0 = (int) 2131492964;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.id']/field[@name='action_bar']"
			[Register ("action_bar")]
			public const int ActionBar = (int) 2131492929;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.id']/field[@name='action_bar_activity_content']"
			[Register ("action_bar_activity_content")]
			public const int ActionBarActivityContent = (int) 2131492864;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.id']/field[@name='action_bar_container']"
			[Register ("action_bar_container")]
			public const int ActionBarContainer = (int) 2131492928;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.id']/field[@name='action_bar_root']"
			[Register ("action_bar_root")]
			public const int ActionBarRoot = (int) 2131492924;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.id']/field[@name='action_bar_spinner']"
			[Register ("action_bar_spinner")]
			public const int ActionBarSpinner = (int) 2131492865;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.id']/field[@name='action_bar_subtitle']"
			[Register ("action_bar_subtitle")]
			public const int ActionBarSubtitle = (int) 2131492898;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.id']/field[@name='action_bar_title']"
			[Register ("action_bar_title")]
			public const int ActionBarTitle = (int) 2131492897;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.id']/field[@name='action_context_bar']"
			[Register ("action_context_bar")]
			public const int ActionContextBar = (int) 2131492930;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.id']/field[@name='action_divider']"
			[Register ("action_divider")]
			public const int ActionDivider = (int) 2131492968;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.id']/field[@name='action_menu_divider']"
			[Register ("action_menu_divider")]
			public const int ActionMenuDivider = (int) 2131492866;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.id']/field[@name='action_menu_presenter']"
			[Register ("action_menu_presenter")]
			public const int ActionMenuPresenter = (int) 2131492867;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.id']/field[@name='action_mode_bar']"
			[Register ("action_mode_bar")]
			public const int ActionModeBar = (int) 2131492926;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.id']/field[@name='action_mode_bar_stub']"
			[Register ("action_mode_bar_stub")]
			public const int ActionModeBarStub = (int) 2131492925;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.id']/field[@name='action_mode_close_button']"
			[Register ("action_mode_close_button")]
			public const int ActionModeCloseButton = (int) 2131492899;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.id']/field[@name='activity_chooser_view_content']"
			[Register ("activity_chooser_view_content")]
			public const int ActivityChooserViewContent = (int) 2131492900;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.id']/field[@name='alertTitle']"
			[Register ("alertTitle")]
			public const int AlertTitle = (int) 2131492912;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.id']/field[@name='always']"
			[Register ("always")]
			public const int Always = (int) 2131492892;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.id']/field[@name='beginning']"
			[Register ("beginning")]
			public const int Beginning = (int) 2131492889;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.id']/field[@name='buttonPanel']"
			[Register ("buttonPanel")]
			public const int ButtonPanel = (int) 2131492907;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.id']/field[@name='cancel_action']"
			[Register ("cancel_action")]
			public const int CancelAction = (int) 2131492965;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.id']/field[@name='checkbox']"
			[Register ("checkbox")]
			public const int Checkbox = (int) 2131492921;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.id']/field[@name='chronometer']"
			[Register ("chronometer")]
			public const int Chronometer = (int) 2131492971;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.id']/field[@name='collapseActionView']"
			[Register ("collapseActionView")]
			public const int CollapseActionView = (int) 2131492893;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.id']/field[@name='contentPanel']"
			[Register ("contentPanel")]
			public const int ContentPanel = (int) 2131492913;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.id']/field[@name='custom']"
			[Register ("custom")]
			public const int Custom = (int) 2131492919;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.id']/field[@name='customPanel']"
			[Register ("customPanel")]
			public const int CustomPanel = (int) 2131492918;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.id']/field[@name='decor_content_parent']"
			[Register ("decor_content_parent")]
			public const int DecorContentParent = (int) 2131492927;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.id']/field[@name='default_activity_button']"
			[Register ("default_activity_button")]
			public const int DefaultActivityButton = (int) 2131492903;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.id']/field[@name='disableHome']"
			[Register ("disableHome")]
			public const int DisableHome = (int) 2131492876;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.id']/field[@name='edit_query']"
			[Register ("edit_query")]
			public const int EditQuery = (int) 2131492931;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.id']/field[@name='end']"
			[Register ("end")]
			public const int End = (int) 2131492890;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.id']/field[@name='end_padder']"
			[Register ("end_padder")]
			public const int EndPadder = (int) 2131492976;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.id']/field[@name='expand_activities_button']"
			[Register ("expand_activities_button")]
			public const int ExpandActivitiesButton = (int) 2131492901;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.id']/field[@name='expanded_menu']"
			[Register ("expanded_menu")]
			public const int ExpandedMenu = (int) 2131492920;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.id']/field[@name='home']"
			[Register ("home")]
			public const int Home = (int) 2131492868;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.id']/field[@name='homeAsUp']"
			[Register ("homeAsUp")]
			public const int HomeAsUp = (int) 2131492877;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.id']/field[@name='icon']"
			[Register ("icon")]
			public const int Icon = (int) 2131492905;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.id']/field[@name='ifRoom']"
			[Register ("ifRoom")]
			public const int IfRoom = (int) 2131492894;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.id']/field[@name='image']"
			[Register ("image")]
			public const int Image = (int) 2131492902;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.id']/field[@name='info']"
			[Register ("info")]
			public const int Info = (int) 2131492975;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.id']/field[@name='line1']"
			[Register ("line1")]
			public const int Line1 = (int) 2131492969;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.id']/field[@name='line3']"
			[Register ("line3")]
			public const int Line3 = (int) 2131492973;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.id']/field[@name='listMode']"
			[Register ("listMode")]
			public const int ListMode = (int) 2131492873;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.id']/field[@name='list_item']"
			[Register ("list_item")]
			public const int ListItem = (int) 2131492904;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.id']/field[@name='media_actions']"
			[Register ("media_actions")]
			public const int MediaActions = (int) 2131492967;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.id']/field[@name='middle']"
			[Register ("middle")]
			public const int Middle = (int) 2131492891;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.id']/field[@name='multiply']"
			[Register ("multiply")]
			public const int Multiply = (int) 2131492884;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.id']/field[@name='never']"
			[Register ("never")]
			public const int Never = (int) 2131492895;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.id']/field[@name='none']"
			[Register ("none")]
			public const int None = (int) 2131492878;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.id']/field[@name='normal']"
			[Register ("normal")]
			public const int Normal = (int) 2131492874;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.id']/field[@name='parentPanel']"
			[Register ("parentPanel")]
			public const int ParentPanel = (int) 2131492909;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.id']/field[@name='progress_circular']"
			[Register ("progress_circular")]
			public const int ProgressCircular = (int) 2131492869;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.id']/field[@name='progress_horizontal']"
			[Register ("progress_horizontal")]
			public const int ProgressHorizontal = (int) 2131492870;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.id']/field[@name='radio']"
			[Register ("radio")]
			public const int Radio = (int) 2131492923;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.id']/field[@name='screen']"
			[Register ("screen")]
			public const int Screen = (int) 2131492885;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.id']/field[@name='scrollIndicatorDown']"
			[Register ("scrollIndicatorDown")]
			public const int ScrollIndicatorDown = (int) 2131492917;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.id']/field[@name='scrollIndicatorUp']"
			[Register ("scrollIndicatorUp")]
			public const int ScrollIndicatorUp = (int) 2131492914;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.id']/field[@name='scrollView']"
			[Register ("scrollView")]
			public const int ScrollView = (int) 2131492915;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.id']/field[@name='search_badge']"
			[Register ("search_badge")]
			public const int SearchBadge = (int) 2131492933;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.id']/field[@name='search_bar']"
			[Register ("search_bar")]
			public const int SearchBar = (int) 2131492932;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.id']/field[@name='search_button']"
			[Register ("search_button")]
			public const int SearchButton = (int) 2131492934;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.id']/field[@name='search_close_btn']"
			[Register ("search_close_btn")]
			public const int SearchCloseBtn = (int) 2131492939;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.id']/field[@name='search_edit_frame']"
			[Register ("search_edit_frame")]
			public const int SearchEditFrame = (int) 2131492935;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.id']/field[@name='search_go_btn']"
			[Register ("search_go_btn")]
			public const int SearchGoBtn = (int) 2131492941;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.id']/field[@name='search_mag_icon']"
			[Register ("search_mag_icon")]
			public const int SearchMagIcon = (int) 2131492936;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.id']/field[@name='search_plate']"
			[Register ("search_plate")]
			public const int SearchPlate = (int) 2131492937;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.id']/field[@name='search_src_text']"
			[Register ("search_src_text")]
			public const int SearchSrcText = (int) 2131492938;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.id']/field[@name='search_voice_btn']"
			[Register ("search_voice_btn")]
			public const int SearchVoiceBtn = (int) 2131492942;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.id']/field[@name='select_dialog_listview']"
			[Register ("select_dialog_listview")]
			public const int SelectDialogListview = (int) 2131492943;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.id']/field[@name='shortcut']"
			[Register ("shortcut")]
			public const int Shortcut = (int) 2131492922;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.id']/field[@name='showCustom']"
			[Register ("showCustom")]
			public const int ShowCustom = (int) 2131492879;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.id']/field[@name='showHome']"
			[Register ("showHome")]
			public const int ShowHome = (int) 2131492880;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.id']/field[@name='showTitle']"
			[Register ("showTitle")]
			public const int ShowTitle = (int) 2131492881;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.id']/field[@name='spacer']"
			[Register ("spacer")]
			public const int Spacer = (int) 2131492908;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.id']/field[@name='split_action_bar']"
			[Register ("split_action_bar")]
			public const int SplitActionBar = (int) 2131492871;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.id']/field[@name='src_atop']"
			[Register ("src_atop")]
			public const int SrcAtop = (int) 2131492886;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.id']/field[@name='src_in']"
			[Register ("src_in")]
			public const int SrcIn = (int) 2131492887;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.id']/field[@name='src_over']"
			[Register ("src_over")]
			public const int SrcOver = (int) 2131492888;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.id']/field[@name='status_bar_latest_event_content']"
			[Register ("status_bar_latest_event_content")]
			public const int StatusBarLatestEventContent = (int) 2131492966;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.id']/field[@name='submit_area']"
			[Register ("submit_area")]
			public const int SubmitArea = (int) 2131492940;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.id']/field[@name='tabMode']"
			[Register ("tabMode")]
			public const int TabMode = (int) 2131492875;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.id']/field[@name='text']"
			[Register ("text")]
			public const int Text = (int) 2131492974;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.id']/field[@name='text2']"
			[Register ("text2")]
			public const int Text2 = (int) 2131492972;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.id']/field[@name='textSpacerNoButtons']"
			[Register ("textSpacerNoButtons")]
			public const int TextSpacerNoButtons = (int) 2131492916;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.id']/field[@name='time']"
			[Register ("time")]
			public const int Time = (int) 2131492970;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.id']/field[@name='title']"
			[Register ("title")]
			public const int Title = (int) 2131492906;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.id']/field[@name='title_template']"
			[Register ("title_template")]
			public const int TitleTemplate = (int) 2131492911;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.id']/field[@name='topPanel']"
			[Register ("topPanel")]
			public const int TopPanel = (int) 2131492910;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.id']/field[@name='up']"
			[Register ("up")]
			public const int Up = (int) 2131492872;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.id']/field[@name='useLogo']"
			[Register ("useLogo")]
			public const int UseLogo = (int) 2131492882;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.id']/field[@name='withText']"
			[Register ("withText")]
			public const int WithText = (int) 2131492896;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.id']/field[@name='wrap_content']"
			[Register ("wrap_content")]
			public const int WrapContent = (int) 2131492883;
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("android/support/v7/appcompat/R$id", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Id); }
			}

			internal Id (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.id']/constructor[@name='R.id' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Id ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (((object) this).GetType () != typeof (Id)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
						return;
					}

					if (id_ctor == IntPtr.Zero)
						id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.integer']"
		[global::Android.Runtime.Register ("android/support/v7/appcompat/R$integer", DoNotGenerateAcw=true)]
		public sealed partial class Integer : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.integer']/field[@name='abc_config_activityDefaultDur']"
			[Register ("abc_config_activityDefaultDur")]
			public const int AbcConfigActivityDefaultDur = (int) 2131296257;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.integer']/field[@name='abc_config_activityShortDur']"
			[Register ("abc_config_activityShortDur")]
			public const int AbcConfigActivityShortDur = (int) 2131296258;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.integer']/field[@name='abc_max_action_buttons']"
			[Register ("abc_max_action_buttons")]
			public const int AbcMaxActionButtons = (int) 2131296256;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.integer']/field[@name='cancel_button_image_alpha']"
			[Register ("cancel_button_image_alpha")]
			public const int CancelButtonImageAlpha = (int) 2131296259;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.integer']/field[@name='status_bar_notification_info_maxnum']"
			[Register ("status_bar_notification_info_maxnum")]
			public const int StatusBarNotificationInfoMaxnum = (int) 2131296260;
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("android/support/v7/appcompat/R$integer", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Integer); }
			}

			internal Integer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.integer']/constructor[@name='R.integer' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Integer ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (((object) this).GetType () != typeof (Integer)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
						return;
					}

					if (id_ctor == IntPtr.Zero)
						id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.layout']"
		[global::Android.Runtime.Register ("android/support/v7/appcompat/R$layout", DoNotGenerateAcw=true)]
		public sealed partial class Layout : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.layout']/field[@name='abc_action_bar_title_item']"
			[Register ("abc_action_bar_title_item")]
			public const int AbcActionBarTitleItem = (int) 2130903040;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.layout']/field[@name='abc_action_bar_up_container']"
			[Register ("abc_action_bar_up_container")]
			public const int AbcActionBarUpContainer = (int) 2130903041;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.layout']/field[@name='abc_action_bar_view_list_nav_layout']"
			[Register ("abc_action_bar_view_list_nav_layout")]
			public const int AbcActionBarViewListNavLayout = (int) 2130903042;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.layout']/field[@name='abc_action_menu_item_layout']"
			[Register ("abc_action_menu_item_layout")]
			public const int AbcActionMenuItemLayout = (int) 2130903043;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.layout']/field[@name='abc_action_menu_layout']"
			[Register ("abc_action_menu_layout")]
			public const int AbcActionMenuLayout = (int) 2130903044;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.layout']/field[@name='abc_action_mode_bar']"
			[Register ("abc_action_mode_bar")]
			public const int AbcActionModeBar = (int) 2130903045;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.layout']/field[@name='abc_action_mode_close_item_material']"
			[Register ("abc_action_mode_close_item_material")]
			public const int AbcActionModeCloseItemMaterial = (int) 2130903046;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.layout']/field[@name='abc_activity_chooser_view']"
			[Register ("abc_activity_chooser_view")]
			public const int AbcActivityChooserView = (int) 2130903047;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.layout']/field[@name='abc_activity_chooser_view_list_item']"
			[Register ("abc_activity_chooser_view_list_item")]
			public const int AbcActivityChooserViewListItem = (int) 2130903048;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.layout']/field[@name='abc_alert_dialog_button_bar_material']"
			[Register ("abc_alert_dialog_button_bar_material")]
			public const int AbcAlertDialogButtonBarMaterial = (int) 2130903049;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.layout']/field[@name='abc_alert_dialog_material']"
			[Register ("abc_alert_dialog_material")]
			public const int AbcAlertDialogMaterial = (int) 2130903050;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.layout']/field[@name='abc_dialog_title_material']"
			[Register ("abc_dialog_title_material")]
			public const int AbcDialogTitleMaterial = (int) 2130903051;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.layout']/field[@name='abc_expanded_menu_layout']"
			[Register ("abc_expanded_menu_layout")]
			public const int AbcExpandedMenuLayout = (int) 2130903052;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.layout']/field[@name='abc_list_menu_item_checkbox']"
			[Register ("abc_list_menu_item_checkbox")]
			public const int AbcListMenuItemCheckbox = (int) 2130903053;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.layout']/field[@name='abc_list_menu_item_icon']"
			[Register ("abc_list_menu_item_icon")]
			public const int AbcListMenuItemIcon = (int) 2130903054;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.layout']/field[@name='abc_list_menu_item_layout']"
			[Register ("abc_list_menu_item_layout")]
			public const int AbcListMenuItemLayout = (int) 2130903055;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.layout']/field[@name='abc_list_menu_item_radio']"
			[Register ("abc_list_menu_item_radio")]
			public const int AbcListMenuItemRadio = (int) 2130903056;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.layout']/field[@name='abc_popup_menu_item_layout']"
			[Register ("abc_popup_menu_item_layout")]
			public const int AbcPopupMenuItemLayout = (int) 2130903057;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.layout']/field[@name='abc_screen_content_include']"
			[Register ("abc_screen_content_include")]
			public const int AbcScreenContentInclude = (int) 2130903058;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.layout']/field[@name='abc_screen_simple']"
			[Register ("abc_screen_simple")]
			public const int AbcScreenSimple = (int) 2130903059;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.layout']/field[@name='abc_screen_simple_overlay_action_mode']"
			[Register ("abc_screen_simple_overlay_action_mode")]
			public const int AbcScreenSimpleOverlayActionMode = (int) 2130903060;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.layout']/field[@name='abc_screen_toolbar']"
			[Register ("abc_screen_toolbar")]
			public const int AbcScreenToolbar = (int) 2130903061;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.layout']/field[@name='abc_search_dropdown_item_icons_2line']"
			[Register ("abc_search_dropdown_item_icons_2line")]
			public const int AbcSearchDropdownItemIcons2line = (int) 2130903062;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.layout']/field[@name='abc_search_view']"
			[Register ("abc_search_view")]
			public const int AbcSearchView = (int) 2130903063;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.layout']/field[@name='abc_select_dialog_material']"
			[Register ("abc_select_dialog_material")]
			public const int AbcSelectDialogMaterial = (int) 2130903064;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.layout']/field[@name='notification_media_action']"
			[Register ("notification_media_action")]
			public const int NotificationMediaAction = (int) 2130903074;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.layout']/field[@name='notification_media_cancel_action']"
			[Register ("notification_media_cancel_action")]
			public const int NotificationMediaCancelAction = (int) 2130903075;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.layout']/field[@name='notification_template_big_media']"
			[Register ("notification_template_big_media")]
			public const int NotificationTemplateBigMedia = (int) 2130903076;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.layout']/field[@name='notification_template_big_media_narrow']"
			[Register ("notification_template_big_media_narrow")]
			public const int NotificationTemplateBigMediaNarrow = (int) 2130903077;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.layout']/field[@name='notification_template_lines']"
			[Register ("notification_template_lines")]
			public const int NotificationTemplateLines = (int) 2130903078;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.layout']/field[@name='notification_template_media']"
			[Register ("notification_template_media")]
			public const int NotificationTemplateMedia = (int) 2130903079;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.layout']/field[@name='notification_template_part_chronometer']"
			[Register ("notification_template_part_chronometer")]
			public const int NotificationTemplatePartChronometer = (int) 2130903080;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.layout']/field[@name='notification_template_part_time']"
			[Register ("notification_template_part_time")]
			public const int NotificationTemplatePartTime = (int) 2130903081;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.layout']/field[@name='select_dialog_item_material']"
			[Register ("select_dialog_item_material")]
			public const int SelectDialogItemMaterial = (int) 2130903082;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.layout']/field[@name='select_dialog_multichoice_material']"
			[Register ("select_dialog_multichoice_material")]
			public const int SelectDialogMultichoiceMaterial = (int) 2130903083;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.layout']/field[@name='select_dialog_singlechoice_material']"
			[Register ("select_dialog_singlechoice_material")]
			public const int SelectDialogSinglechoiceMaterial = (int) 2130903084;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.layout']/field[@name='support_simple_spinner_dropdown_item']"
			[Register ("support_simple_spinner_dropdown_item")]
			public const int SupportSimpleSpinnerDropdownItem = (int) 2130903085;
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("android/support/v7/appcompat/R$layout", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Layout); }
			}

			internal Layout (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.layout']/constructor[@name='R.layout' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Layout ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (((object) this).GetType () != typeof (Layout)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
						return;
					}

					if (id_ctor == IntPtr.Zero)
						id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.string']"
		[global::Android.Runtime.Register ("android/support/v7/appcompat/R$string", DoNotGenerateAcw=true)]
		public sealed partial class String : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.string']/field[@name='abc_action_bar_home_description']"
			[Register ("abc_action_bar_home_description")]
			public const int AbcActionBarHomeDescription = (int) 2131034112;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.string']/field[@name='abc_action_bar_home_description_format']"
			[Register ("abc_action_bar_home_description_format")]
			public const int AbcActionBarHomeDescriptionFormat = (int) 2131034113;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.string']/field[@name='abc_action_bar_home_subtitle_description_format']"
			[Register ("abc_action_bar_home_subtitle_description_format")]
			public const int AbcActionBarHomeSubtitleDescriptionFormat = (int) 2131034114;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.string']/field[@name='abc_action_bar_up_description']"
			[Register ("abc_action_bar_up_description")]
			public const int AbcActionBarUpDescription = (int) 2131034115;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.string']/field[@name='abc_action_menu_overflow_description']"
			[Register ("abc_action_menu_overflow_description")]
			public const int AbcActionMenuOverflowDescription = (int) 2131034116;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.string']/field[@name='abc_action_mode_done']"
			[Register ("abc_action_mode_done")]
			public const int AbcActionModeDone = (int) 2131034117;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.string']/field[@name='abc_activity_chooser_view_see_all']"
			[Register ("abc_activity_chooser_view_see_all")]
			public const int AbcActivityChooserViewSeeAll = (int) 2131034118;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.string']/field[@name='abc_activitychooserview_choose_application']"
			[Register ("abc_activitychooserview_choose_application")]
			public const int AbcActivitychooserviewChooseApplication = (int) 2131034119;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.string']/field[@name='abc_capital_off']"
			[Register ("abc_capital_off")]
			public const int AbcCapitalOff = (int) 2131034120;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.string']/field[@name='abc_capital_on']"
			[Register ("abc_capital_on")]
			public const int AbcCapitalOn = (int) 2131034121;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.string']/field[@name='abc_search_hint']"
			[Register ("abc_search_hint")]
			public const int AbcSearchHint = (int) 2131034122;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.string']/field[@name='abc_searchview_description_clear']"
			[Register ("abc_searchview_description_clear")]
			public const int AbcSearchviewDescriptionClear = (int) 2131034123;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.string']/field[@name='abc_searchview_description_query']"
			[Register ("abc_searchview_description_query")]
			public const int AbcSearchviewDescriptionQuery = (int) 2131034124;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.string']/field[@name='abc_searchview_description_search']"
			[Register ("abc_searchview_description_search")]
			public const int AbcSearchviewDescriptionSearch = (int) 2131034125;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.string']/field[@name='abc_searchview_description_submit']"
			[Register ("abc_searchview_description_submit")]
			public const int AbcSearchviewDescriptionSubmit = (int) 2131034126;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.string']/field[@name='abc_searchview_description_voice']"
			[Register ("abc_searchview_description_voice")]
			public const int AbcSearchviewDescriptionVoice = (int) 2131034127;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.string']/field[@name='abc_shareactionprovider_share_with']"
			[Register ("abc_shareactionprovider_share_with")]
			public const int AbcShareactionproviderShareWith = (int) 2131034128;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.string']/field[@name='abc_shareactionprovider_share_with_application']"
			[Register ("abc_shareactionprovider_share_with_application")]
			public const int AbcShareactionproviderShareWithApplication = (int) 2131034129;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.string']/field[@name='abc_toolbar_collapse_description']"
			[Register ("abc_toolbar_collapse_description")]
			public const int AbcToolbarCollapseDescription = (int) 2131034130;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.string']/field[@name='status_bar_notification_info_overflow']"
			[Register ("status_bar_notification_info_overflow")]
			public const int StatusBarNotificationInfoOverflow = (int) 2131034131;
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("android/support/v7/appcompat/R$string", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (String); }
			}

			internal String (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.string']/constructor[@name='R.string' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe String ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (((object) this).GetType () != typeof (String)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
						return;
					}

					if (id_ctor == IntPtr.Zero)
						id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']"
		[global::Android.Runtime.Register ("android/support/v7/appcompat/R$style", DoNotGenerateAcw=true)]
		public sealed partial class Style : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='AlertDialog_AppCompat']"
			[Register ("AlertDialog_AppCompat")]
			public const int AlertDialogAppCompat = (int) 2131230867;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='AlertDialog_AppCompat_Light']"
			[Register ("AlertDialog_AppCompat_Light")]
			public const int AlertDialogAppCompatLight = (int) 2131230868;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Animation_AppCompat_Dialog']"
			[Register ("Animation_AppCompat_Dialog")]
			public const int AnimationAppCompatDialog = (int) 2131230869;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Animation_AppCompat_DropDownUp']"
			[Register ("Animation_AppCompat_DropDownUp")]
			public const int AnimationAppCompatDropDownUp = (int) 2131230870;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_AlertDialog_AppCompat']"
			[Register ("Base_AlertDialog_AppCompat")]
			public const int BaseAlertDialogAppCompat = (int) 2131230872;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_AlertDialog_AppCompat_Light']"
			[Register ("Base_AlertDialog_AppCompat_Light")]
			public const int BaseAlertDialogAppCompatLight = (int) 2131230873;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_Animation_AppCompat_Dialog']"
			[Register ("Base_Animation_AppCompat_Dialog")]
			public const int BaseAnimationAppCompatDialog = (int) 2131230874;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_Animation_AppCompat_DropDownUp']"
			[Register ("Base_Animation_AppCompat_DropDownUp")]
			public const int BaseAnimationAppCompatDropDownUp = (int) 2131230875;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_DialogWindowTitleBackground_AppCompat']"
			[Register ("Base_DialogWindowTitleBackground_AppCompat")]
			public const int BaseDialogWindowTitleBackgroundAppCompat = (int) 2131230877;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_DialogWindowTitle_AppCompat']"
			[Register ("Base_DialogWindowTitle_AppCompat")]
			public const int BaseDialogWindowTitleAppCompat = (int) 2131230876;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_TextAppearance_AppCompat']"
			[Register ("Base_TextAppearance_AppCompat")]
			public const int BaseTextAppearanceAppCompat = (int) 2131230774;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_TextAppearance_AppCompat_Body1']"
			[Register ("Base_TextAppearance_AppCompat_Body1")]
			public const int BaseTextAppearanceAppCompatBody1 = (int) 2131230775;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_TextAppearance_AppCompat_Body2']"
			[Register ("Base_TextAppearance_AppCompat_Body2")]
			public const int BaseTextAppearanceAppCompatBody2 = (int) 2131230776;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_TextAppearance_AppCompat_Button']"
			[Register ("Base_TextAppearance_AppCompat_Button")]
			public const int BaseTextAppearanceAppCompatButton = (int) 2131230752;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_TextAppearance_AppCompat_Caption']"
			[Register ("Base_TextAppearance_AppCompat_Caption")]
			public const int BaseTextAppearanceAppCompatCaption = (int) 2131230777;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_TextAppearance_AppCompat_Display1']"
			[Register ("Base_TextAppearance_AppCompat_Display1")]
			public const int BaseTextAppearanceAppCompatDisplay1 = (int) 2131230778;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_TextAppearance_AppCompat_Display2']"
			[Register ("Base_TextAppearance_AppCompat_Display2")]
			public const int BaseTextAppearanceAppCompatDisplay2 = (int) 2131230779;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_TextAppearance_AppCompat_Display3']"
			[Register ("Base_TextAppearance_AppCompat_Display3")]
			public const int BaseTextAppearanceAppCompatDisplay3 = (int) 2131230780;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_TextAppearance_AppCompat_Display4']"
			[Register ("Base_TextAppearance_AppCompat_Display4")]
			public const int BaseTextAppearanceAppCompatDisplay4 = (int) 2131230781;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_TextAppearance_AppCompat_Headline']"
			[Register ("Base_TextAppearance_AppCompat_Headline")]
			public const int BaseTextAppearanceAppCompatHeadline = (int) 2131230782;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_TextAppearance_AppCompat_Inverse']"
			[Register ("Base_TextAppearance_AppCompat_Inverse")]
			public const int BaseTextAppearanceAppCompatInverse = (int) 2131230731;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_TextAppearance_AppCompat_Large']"
			[Register ("Base_TextAppearance_AppCompat_Large")]
			public const int BaseTextAppearanceAppCompatLarge = (int) 2131230783;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_TextAppearance_AppCompat_Large_Inverse']"
			[Register ("Base_TextAppearance_AppCompat_Large_Inverse")]
			public const int BaseTextAppearanceAppCompatLargeInverse = (int) 2131230732;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_TextAppearance_AppCompat_Light_Widget_PopupMenu_Large']"
			[Register ("Base_TextAppearance_AppCompat_Light_Widget_PopupMenu_Large")]
			public const int BaseTextAppearanceAppCompatLightWidgetPopupMenuLarge = (int) 2131230784;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_TextAppearance_AppCompat_Light_Widget_PopupMenu_Small']"
			[Register ("Base_TextAppearance_AppCompat_Light_Widget_PopupMenu_Small")]
			public const int BaseTextAppearanceAppCompatLightWidgetPopupMenuSmall = (int) 2131230785;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_TextAppearance_AppCompat_Medium']"
			[Register ("Base_TextAppearance_AppCompat_Medium")]
			public const int BaseTextAppearanceAppCompatMedium = (int) 2131230786;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_TextAppearance_AppCompat_Medium_Inverse']"
			[Register ("Base_TextAppearance_AppCompat_Medium_Inverse")]
			public const int BaseTextAppearanceAppCompatMediumInverse = (int) 2131230733;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_TextAppearance_AppCompat_Menu']"
			[Register ("Base_TextAppearance_AppCompat_Menu")]
			public const int BaseTextAppearanceAppCompatMenu = (int) 2131230787;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_TextAppearance_AppCompat_SearchResult']"
			[Register ("Base_TextAppearance_AppCompat_SearchResult")]
			public const int BaseTextAppearanceAppCompatSearchResult = (int) 2131230878;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_TextAppearance_AppCompat_SearchResult_Subtitle']"
			[Register ("Base_TextAppearance_AppCompat_SearchResult_Subtitle")]
			public const int BaseTextAppearanceAppCompatSearchResultSubtitle = (int) 2131230788;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_TextAppearance_AppCompat_SearchResult_Title']"
			[Register ("Base_TextAppearance_AppCompat_SearchResult_Title")]
			public const int BaseTextAppearanceAppCompatSearchResultTitle = (int) 2131230789;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_TextAppearance_AppCompat_Small']"
			[Register ("Base_TextAppearance_AppCompat_Small")]
			public const int BaseTextAppearanceAppCompatSmall = (int) 2131230790;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_TextAppearance_AppCompat_Small_Inverse']"
			[Register ("Base_TextAppearance_AppCompat_Small_Inverse")]
			public const int BaseTextAppearanceAppCompatSmallInverse = (int) 2131230734;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_TextAppearance_AppCompat_Subhead']"
			[Register ("Base_TextAppearance_AppCompat_Subhead")]
			public const int BaseTextAppearanceAppCompatSubhead = (int) 2131230791;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_TextAppearance_AppCompat_Subhead_Inverse']"
			[Register ("Base_TextAppearance_AppCompat_Subhead_Inverse")]
			public const int BaseTextAppearanceAppCompatSubheadInverse = (int) 2131230735;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_TextAppearance_AppCompat_Title']"
			[Register ("Base_TextAppearance_AppCompat_Title")]
			public const int BaseTextAppearanceAppCompatTitle = (int) 2131230792;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_TextAppearance_AppCompat_Title_Inverse']"
			[Register ("Base_TextAppearance_AppCompat_Title_Inverse")]
			public const int BaseTextAppearanceAppCompatTitleInverse = (int) 2131230736;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_TextAppearance_AppCompat_Widget_ActionBar_Menu']"
			[Register ("Base_TextAppearance_AppCompat_Widget_ActionBar_Menu")]
			public const int BaseTextAppearanceAppCompatWidgetActionBarMenu = (int) 2131230847;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_TextAppearance_AppCompat_Widget_ActionBar_Subtitle']"
			[Register ("Base_TextAppearance_AppCompat_Widget_ActionBar_Subtitle")]
			public const int BaseTextAppearanceAppCompatWidgetActionBarSubtitle = (int) 2131230793;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_TextAppearance_AppCompat_Widget_ActionBar_Subtitle_Inverse']"
			[Register ("Base_TextAppearance_AppCompat_Widget_ActionBar_Subtitle_Inverse")]
			public const int BaseTextAppearanceAppCompatWidgetActionBarSubtitleInverse = (int) 2131230794;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_TextAppearance_AppCompat_Widget_ActionBar_Title']"
			[Register ("Base_TextAppearance_AppCompat_Widget_ActionBar_Title")]
			public const int BaseTextAppearanceAppCompatWidgetActionBarTitle = (int) 2131230795;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_TextAppearance_AppCompat_Widget_ActionBar_Title_Inverse']"
			[Register ("Base_TextAppearance_AppCompat_Widget_ActionBar_Title_Inverse")]
			public const int BaseTextAppearanceAppCompatWidgetActionBarTitleInverse = (int) 2131230796;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_TextAppearance_AppCompat_Widget_ActionMode_Subtitle']"
			[Register ("Base_TextAppearance_AppCompat_Widget_ActionMode_Subtitle")]
			public const int BaseTextAppearanceAppCompatWidgetActionModeSubtitle = (int) 2131230797;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_TextAppearance_AppCompat_Widget_ActionMode_Title']"
			[Register ("Base_TextAppearance_AppCompat_Widget_ActionMode_Title")]
			public const int BaseTextAppearanceAppCompatWidgetActionModeTitle = (int) 2131230798;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_TextAppearance_AppCompat_Widget_Button']"
			[Register ("Base_TextAppearance_AppCompat_Widget_Button")]
			public const int BaseTextAppearanceAppCompatWidgetButton = (int) 2131230799;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_TextAppearance_AppCompat_Widget_Button_Inverse']"
			[Register ("Base_TextAppearance_AppCompat_Widget_Button_Inverse")]
			public const int BaseTextAppearanceAppCompatWidgetButtonInverse = (int) 2131230848;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_TextAppearance_AppCompat_Widget_DropDownItem']"
			[Register ("Base_TextAppearance_AppCompat_Widget_DropDownItem")]
			public const int BaseTextAppearanceAppCompatWidgetDropDownItem = (int) 2131230879;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_TextAppearance_AppCompat_Widget_PopupMenu_Large']"
			[Register ("Base_TextAppearance_AppCompat_Widget_PopupMenu_Large")]
			public const int BaseTextAppearanceAppCompatWidgetPopupMenuLarge = (int) 2131230800;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_TextAppearance_AppCompat_Widget_PopupMenu_Small']"
			[Register ("Base_TextAppearance_AppCompat_Widget_PopupMenu_Small")]
			public const int BaseTextAppearanceAppCompatWidgetPopupMenuSmall = (int) 2131230801;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_TextAppearance_AppCompat_Widget_Switch']"
			[Register ("Base_TextAppearance_AppCompat_Widget_Switch")]
			public const int BaseTextAppearanceAppCompatWidgetSwitch = (int) 2131230802;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_TextAppearance_AppCompat_Widget_TextView_SpinnerItem']"
			[Register ("Base_TextAppearance_AppCompat_Widget_TextView_SpinnerItem")]
			public const int BaseTextAppearanceAppCompatWidgetTextViewSpinnerItem = (int) 2131230803;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_TextAppearance_Widget_AppCompat_ExpandedMenu_Item']"
			[Register ("Base_TextAppearance_Widget_AppCompat_ExpandedMenu_Item")]
			public const int BaseTextAppearanceWidgetAppCompatExpandedMenuItem = (int) 2131230880;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_TextAppearance_Widget_AppCompat_Toolbar_Subtitle']"
			[Register ("Base_TextAppearance_Widget_AppCompat_Toolbar_Subtitle")]
			public const int BaseTextAppearanceWidgetAppCompatToolbarSubtitle = (int) 2131230804;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_TextAppearance_Widget_AppCompat_Toolbar_Title']"
			[Register ("Base_TextAppearance_Widget_AppCompat_Toolbar_Title")]
			public const int BaseTextAppearanceWidgetAppCompatToolbarTitle = (int) 2131230805;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_ThemeOverlay_AppCompat']"
			[Register ("Base_ThemeOverlay_AppCompat")]
			public const int BaseThemeOverlayAppCompat = (int) 2131230889;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_ThemeOverlay_AppCompat_ActionBar']"
			[Register ("Base_ThemeOverlay_AppCompat_ActionBar")]
			public const int BaseThemeOverlayAppCompatActionBar = (int) 2131230890;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_ThemeOverlay_AppCompat_Dark']"
			[Register ("Base_ThemeOverlay_AppCompat_Dark")]
			public const int BaseThemeOverlayAppCompatDark = (int) 2131230891;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_ThemeOverlay_AppCompat_Dark_ActionBar']"
			[Register ("Base_ThemeOverlay_AppCompat_Dark_ActionBar")]
			public const int BaseThemeOverlayAppCompatDarkActionBar = (int) 2131230892;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_ThemeOverlay_AppCompat_Light']"
			[Register ("Base_ThemeOverlay_AppCompat_Light")]
			public const int BaseThemeOverlayAppCompatLight = (int) 2131230893;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_Theme_AppCompat']"
			[Register ("Base_Theme_AppCompat")]
			public const int BaseThemeAppCompat = (int) 2131230806;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_Theme_AppCompat_CompactMenu']"
			[Register ("Base_Theme_AppCompat_CompactMenu")]
			public const int BaseThemeAppCompatCompactMenu = (int) 2131230881;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_Theme_AppCompat_Dialog']"
			[Register ("Base_Theme_AppCompat_Dialog")]
			public const int BaseThemeAppCompatDialog = (int) 2131230737;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_Theme_AppCompat_DialogWhenLarge']"
			[Register ("Base_Theme_AppCompat_DialogWhenLarge")]
			public const int BaseThemeAppCompatDialogWhenLarge = (int) 2131230721;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_Theme_AppCompat_Dialog_Alert']"
			[Register ("Base_Theme_AppCompat_Dialog_Alert")]
			public const int BaseThemeAppCompatDialogAlert = (int) 2131230882;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_Theme_AppCompat_Dialog_FixedSize']"
			[Register ("Base_Theme_AppCompat_Dialog_FixedSize")]
			public const int BaseThemeAppCompatDialogFixedSize = (int) 2131230883;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_Theme_AppCompat_Dialog_MinWidth']"
			[Register ("Base_Theme_AppCompat_Dialog_MinWidth")]
			public const int BaseThemeAppCompatDialogMinWidth = (int) 2131230884;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_Theme_AppCompat_Light']"
			[Register ("Base_Theme_AppCompat_Light")]
			public const int BaseThemeAppCompatLight = (int) 2131230807;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_Theme_AppCompat_Light_DarkActionBar']"
			[Register ("Base_Theme_AppCompat_Light_DarkActionBar")]
			public const int BaseThemeAppCompatLightDarkActionBar = (int) 2131230885;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_Theme_AppCompat_Light_Dialog']"
			[Register ("Base_Theme_AppCompat_Light_Dialog")]
			public const int BaseThemeAppCompatLightDialog = (int) 2131230738;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_Theme_AppCompat_Light_DialogWhenLarge']"
			[Register ("Base_Theme_AppCompat_Light_DialogWhenLarge")]
			public const int BaseThemeAppCompatLightDialogWhenLarge = (int) 2131230722;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_Theme_AppCompat_Light_Dialog_Alert']"
			[Register ("Base_Theme_AppCompat_Light_Dialog_Alert")]
			public const int BaseThemeAppCompatLightDialogAlert = (int) 2131230886;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_Theme_AppCompat_Light_Dialog_FixedSize']"
			[Register ("Base_Theme_AppCompat_Light_Dialog_FixedSize")]
			public const int BaseThemeAppCompatLightDialogFixedSize = (int) 2131230887;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_Theme_AppCompat_Light_Dialog_MinWidth']"
			[Register ("Base_Theme_AppCompat_Light_Dialog_MinWidth")]
			public const int BaseThemeAppCompatLightDialogMinWidth = (int) 2131230888;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_V11_Theme_AppCompat_Dialog']"
			[Register ("Base_V11_Theme_AppCompat_Dialog")]
			public const int BaseV11ThemeAppCompatDialog = (int) 2131230739;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_V11_Theme_AppCompat_Light_Dialog']"
			[Register ("Base_V11_Theme_AppCompat_Light_Dialog")]
			public const int BaseV11ThemeAppCompatLightDialog = (int) 2131230740;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_V12_Widget_AppCompat_AutoCompleteTextView']"
			[Register ("Base_V12_Widget_AppCompat_AutoCompleteTextView")]
			public const int BaseV12WidgetAppCompatAutoCompleteTextView = (int) 2131230748;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_V12_Widget_AppCompat_EditText']"
			[Register ("Base_V12_Widget_AppCompat_EditText")]
			public const int BaseV12WidgetAppCompatEditText = (int) 2131230749;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_V21_Theme_AppCompat']"
			[Register ("Base_V21_Theme_AppCompat")]
			public const int BaseV21ThemeAppCompat = (int) 2131230808;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_V21_Theme_AppCompat_Dialog']"
			[Register ("Base_V21_Theme_AppCompat_Dialog")]
			public const int BaseV21ThemeAppCompatDialog = (int) 2131230809;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_V21_Theme_AppCompat_Light']"
			[Register ("Base_V21_Theme_AppCompat_Light")]
			public const int BaseV21ThemeAppCompatLight = (int) 2131230810;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_V21_Theme_AppCompat_Light_Dialog']"
			[Register ("Base_V21_Theme_AppCompat_Light_Dialog")]
			public const int BaseV21ThemeAppCompatLightDialog = (int) 2131230811;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_V22_Theme_AppCompat']"
			[Register ("Base_V22_Theme_AppCompat")]
			public const int BaseV22ThemeAppCompat = (int) 2131230845;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_V22_Theme_AppCompat_Light']"
			[Register ("Base_V22_Theme_AppCompat_Light")]
			public const int BaseV22ThemeAppCompatLight = (int) 2131230846;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_V23_Theme_AppCompat']"
			[Register ("Base_V23_Theme_AppCompat")]
			public const int BaseV23ThemeAppCompat = (int) 2131230849;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_V23_Theme_AppCompat_Light']"
			[Register ("Base_V23_Theme_AppCompat_Light")]
			public const int BaseV23ThemeAppCompatLight = (int) 2131230850;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_V7_Theme_AppCompat']"
			[Register ("Base_V7_Theme_AppCompat")]
			public const int BaseV7ThemeAppCompat = (int) 2131230894;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_V7_Theme_AppCompat_Dialog']"
			[Register ("Base_V7_Theme_AppCompat_Dialog")]
			public const int BaseV7ThemeAppCompatDialog = (int) 2131230895;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_V7_Theme_AppCompat_Light']"
			[Register ("Base_V7_Theme_AppCompat_Light")]
			public const int BaseV7ThemeAppCompatLight = (int) 2131230896;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_V7_Theme_AppCompat_Light_Dialog']"
			[Register ("Base_V7_Theme_AppCompat_Light_Dialog")]
			public const int BaseV7ThemeAppCompatLightDialog = (int) 2131230897;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_V7_Widget_AppCompat_AutoCompleteTextView']"
			[Register ("Base_V7_Widget_AppCompat_AutoCompleteTextView")]
			public const int BaseV7WidgetAppCompatAutoCompleteTextView = (int) 2131230898;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_V7_Widget_AppCompat_EditText']"
			[Register ("Base_V7_Widget_AppCompat_EditText")]
			public const int BaseV7WidgetAppCompatEditText = (int) 2131230899;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_Widget_AppCompat_ActionBar']"
			[Register ("Base_Widget_AppCompat_ActionBar")]
			public const int BaseWidgetAppCompatActionBar = (int) 2131230900;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_Widget_AppCompat_ActionBar_Solid']"
			[Register ("Base_Widget_AppCompat_ActionBar_Solid")]
			public const int BaseWidgetAppCompatActionBarSolid = (int) 2131230901;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_Widget_AppCompat_ActionBar_TabBar']"
			[Register ("Base_Widget_AppCompat_ActionBar_TabBar")]
			public const int BaseWidgetAppCompatActionBarTabBar = (int) 2131230902;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_Widget_AppCompat_ActionBar_TabText']"
			[Register ("Base_Widget_AppCompat_ActionBar_TabText")]
			public const int BaseWidgetAppCompatActionBarTabText = (int) 2131230812;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_Widget_AppCompat_ActionBar_TabView']"
			[Register ("Base_Widget_AppCompat_ActionBar_TabView")]
			public const int BaseWidgetAppCompatActionBarTabView = (int) 2131230813;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_Widget_AppCompat_ActionButton']"
			[Register ("Base_Widget_AppCompat_ActionButton")]
			public const int BaseWidgetAppCompatActionButton = (int) 2131230814;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_Widget_AppCompat_ActionButton_CloseMode']"
			[Register ("Base_Widget_AppCompat_ActionButton_CloseMode")]
			public const int BaseWidgetAppCompatActionButtonCloseMode = (int) 2131230815;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_Widget_AppCompat_ActionButton_Overflow']"
			[Register ("Base_Widget_AppCompat_ActionButton_Overflow")]
			public const int BaseWidgetAppCompatActionButtonOverflow = (int) 2131230816;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_Widget_AppCompat_ActionMode']"
			[Register ("Base_Widget_AppCompat_ActionMode")]
			public const int BaseWidgetAppCompatActionMode = (int) 2131230903;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_Widget_AppCompat_ActivityChooserView']"
			[Register ("Base_Widget_AppCompat_ActivityChooserView")]
			public const int BaseWidgetAppCompatActivityChooserView = (int) 2131230904;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_Widget_AppCompat_AutoCompleteTextView']"
			[Register ("Base_Widget_AppCompat_AutoCompleteTextView")]
			public const int BaseWidgetAppCompatAutoCompleteTextView = (int) 2131230750;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_Widget_AppCompat_Button']"
			[Register ("Base_Widget_AppCompat_Button")]
			public const int BaseWidgetAppCompatButton = (int) 2131230817;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_Widget_AppCompat_ButtonBar']"
			[Register ("Base_Widget_AppCompat_ButtonBar")]
			public const int BaseWidgetAppCompatButtonBar = (int) 2131230821;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_Widget_AppCompat_ButtonBar_AlertDialog']"
			[Register ("Base_Widget_AppCompat_ButtonBar_AlertDialog")]
			public const int BaseWidgetAppCompatButtonBarAlertDialog = (int) 2131230906;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_Widget_AppCompat_Button_Borderless']"
			[Register ("Base_Widget_AppCompat_Button_Borderless")]
			public const int BaseWidgetAppCompatButtonBorderless = (int) 2131230818;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_Widget_AppCompat_Button_Borderless_Colored']"
			[Register ("Base_Widget_AppCompat_Button_Borderless_Colored")]
			public const int BaseWidgetAppCompatButtonBorderlessColored = (int) 2131230819;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_Widget_AppCompat_Button_ButtonBar_AlertDialog']"
			[Register ("Base_Widget_AppCompat_Button_ButtonBar_AlertDialog")]
			public const int BaseWidgetAppCompatButtonButtonBarAlertDialog = (int) 2131230905;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_Widget_AppCompat_Button_Colored']"
			[Register ("Base_Widget_AppCompat_Button_Colored")]
			public const int BaseWidgetAppCompatButtonColored = (int) 2131230851;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_Widget_AppCompat_Button_Small']"
			[Register ("Base_Widget_AppCompat_Button_Small")]
			public const int BaseWidgetAppCompatButtonSmall = (int) 2131230820;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_Widget_AppCompat_CompoundButton_CheckBox']"
			[Register ("Base_Widget_AppCompat_CompoundButton_CheckBox")]
			public const int BaseWidgetAppCompatCompoundButtonCheckBox = (int) 2131230822;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_Widget_AppCompat_CompoundButton_RadioButton']"
			[Register ("Base_Widget_AppCompat_CompoundButton_RadioButton")]
			public const int BaseWidgetAppCompatCompoundButtonRadioButton = (int) 2131230823;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_Widget_AppCompat_CompoundButton_Switch']"
			[Register ("Base_Widget_AppCompat_CompoundButton_Switch")]
			public const int BaseWidgetAppCompatCompoundButtonSwitch = (int) 2131230907;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_Widget_AppCompat_DrawerArrowToggle']"
			[Register ("Base_Widget_AppCompat_DrawerArrowToggle")]
			public const int BaseWidgetAppCompatDrawerArrowToggle = (int) 2131230720;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_Widget_AppCompat_DrawerArrowToggle_Common']"
			[Register ("Base_Widget_AppCompat_DrawerArrowToggle_Common")]
			public const int BaseWidgetAppCompatDrawerArrowToggleCommon = (int) 2131230908;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_Widget_AppCompat_DropDownItem_Spinner']"
			[Register ("Base_Widget_AppCompat_DropDownItem_Spinner")]
			public const int BaseWidgetAppCompatDropDownItemSpinner = (int) 2131230824;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_Widget_AppCompat_EditText']"
			[Register ("Base_Widget_AppCompat_EditText")]
			public const int BaseWidgetAppCompatEditText = (int) 2131230751;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_Widget_AppCompat_ImageButton']"
			[Register ("Base_Widget_AppCompat_ImageButton")]
			public const int BaseWidgetAppCompatImageButton = (int) 2131230825;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_Widget_AppCompat_Light_ActionBar']"
			[Register ("Base_Widget_AppCompat_Light_ActionBar")]
			public const int BaseWidgetAppCompatLightActionBar = (int) 2131230909;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_Widget_AppCompat_Light_ActionBar_Solid']"
			[Register ("Base_Widget_AppCompat_Light_ActionBar_Solid")]
			public const int BaseWidgetAppCompatLightActionBarSolid = (int) 2131230910;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_Widget_AppCompat_Light_ActionBar_TabBar']"
			[Register ("Base_Widget_AppCompat_Light_ActionBar_TabBar")]
			public const int BaseWidgetAppCompatLightActionBarTabBar = (int) 2131230911;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_Widget_AppCompat_Light_ActionBar_TabText']"
			[Register ("Base_Widget_AppCompat_Light_ActionBar_TabText")]
			public const int BaseWidgetAppCompatLightActionBarTabText = (int) 2131230826;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_Widget_AppCompat_Light_ActionBar_TabText_Inverse']"
			[Register ("Base_Widget_AppCompat_Light_ActionBar_TabText_Inverse")]
			public const int BaseWidgetAppCompatLightActionBarTabTextInverse = (int) 2131230827;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_Widget_AppCompat_Light_ActionBar_TabView']"
			[Register ("Base_Widget_AppCompat_Light_ActionBar_TabView")]
			public const int BaseWidgetAppCompatLightActionBarTabView = (int) 2131230828;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_Widget_AppCompat_Light_PopupMenu']"
			[Register ("Base_Widget_AppCompat_Light_PopupMenu")]
			public const int BaseWidgetAppCompatLightPopupMenu = (int) 2131230829;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_Widget_AppCompat_Light_PopupMenu_Overflow']"
			[Register ("Base_Widget_AppCompat_Light_PopupMenu_Overflow")]
			public const int BaseWidgetAppCompatLightPopupMenuOverflow = (int) 2131230830;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_Widget_AppCompat_ListPopupWindow']"
			[Register ("Base_Widget_AppCompat_ListPopupWindow")]
			public const int BaseWidgetAppCompatListPopupWindow = (int) 2131230831;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_Widget_AppCompat_ListView']"
			[Register ("Base_Widget_AppCompat_ListView")]
			public const int BaseWidgetAppCompatListView = (int) 2131230832;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_Widget_AppCompat_ListView_DropDown']"
			[Register ("Base_Widget_AppCompat_ListView_DropDown")]
			public const int BaseWidgetAppCompatListViewDropDown = (int) 2131230833;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_Widget_AppCompat_ListView_Menu']"
			[Register ("Base_Widget_AppCompat_ListView_Menu")]
			public const int BaseWidgetAppCompatListViewMenu = (int) 2131230834;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_Widget_AppCompat_PopupMenu']"
			[Register ("Base_Widget_AppCompat_PopupMenu")]
			public const int BaseWidgetAppCompatPopupMenu = (int) 2131230835;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_Widget_AppCompat_PopupMenu_Overflow']"
			[Register ("Base_Widget_AppCompat_PopupMenu_Overflow")]
			public const int BaseWidgetAppCompatPopupMenuOverflow = (int) 2131230836;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_Widget_AppCompat_PopupWindow']"
			[Register ("Base_Widget_AppCompat_PopupWindow")]
			public const int BaseWidgetAppCompatPopupWindow = (int) 2131230912;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_Widget_AppCompat_ProgressBar']"
			[Register ("Base_Widget_AppCompat_ProgressBar")]
			public const int BaseWidgetAppCompatProgressBar = (int) 2131230741;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_Widget_AppCompat_ProgressBar_Horizontal']"
			[Register ("Base_Widget_AppCompat_ProgressBar_Horizontal")]
			public const int BaseWidgetAppCompatProgressBarHorizontal = (int) 2131230742;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_Widget_AppCompat_RatingBar']"
			[Register ("Base_Widget_AppCompat_RatingBar")]
			public const int BaseWidgetAppCompatRatingBar = (int) 2131230837;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_Widget_AppCompat_RatingBar_Indicator']"
			[Register ("Base_Widget_AppCompat_RatingBar_Indicator")]
			public const int BaseWidgetAppCompatRatingBarIndicator = (int) 2131230852;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_Widget_AppCompat_RatingBar_Small']"
			[Register ("Base_Widget_AppCompat_RatingBar_Small")]
			public const int BaseWidgetAppCompatRatingBarSmall = (int) 2131230853;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_Widget_AppCompat_SearchView']"
			[Register ("Base_Widget_AppCompat_SearchView")]
			public const int BaseWidgetAppCompatSearchView = (int) 2131230913;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_Widget_AppCompat_SearchView_ActionBar']"
			[Register ("Base_Widget_AppCompat_SearchView_ActionBar")]
			public const int BaseWidgetAppCompatSearchViewActionBar = (int) 2131230914;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_Widget_AppCompat_SeekBar']"
			[Register ("Base_Widget_AppCompat_SeekBar")]
			public const int BaseWidgetAppCompatSeekBar = (int) 2131230838;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_Widget_AppCompat_Spinner']"
			[Register ("Base_Widget_AppCompat_Spinner")]
			public const int BaseWidgetAppCompatSpinner = (int) 2131230839;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_Widget_AppCompat_Spinner_Underlined']"
			[Register ("Base_Widget_AppCompat_Spinner_Underlined")]
			public const int BaseWidgetAppCompatSpinnerUnderlined = (int) 2131230723;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_Widget_AppCompat_TextView_SpinnerItem']"
			[Register ("Base_Widget_AppCompat_TextView_SpinnerItem")]
			public const int BaseWidgetAppCompatTextViewSpinnerItem = (int) 2131230840;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_Widget_AppCompat_Toolbar']"
			[Register ("Base_Widget_AppCompat_Toolbar")]
			public const int BaseWidgetAppCompatToolbar = (int) 2131230915;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Base_Widget_AppCompat_Toolbar_Button_Navigation']"
			[Register ("Base_Widget_AppCompat_Toolbar_Button_Navigation")]
			public const int BaseWidgetAppCompatToolbarButtonNavigation = (int) 2131230841;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Platform_AppCompat']"
			[Register ("Platform_AppCompat")]
			public const int PlatformAppCompat = (int) 2131230743;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Platform_AppCompat_Light']"
			[Register ("Platform_AppCompat_Light")]
			public const int PlatformAppCompatLight = (int) 2131230744;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Platform_ThemeOverlay_AppCompat']"
			[Register ("Platform_ThemeOverlay_AppCompat")]
			public const int PlatformThemeOverlayAppCompat = (int) 2131230842;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Platform_ThemeOverlay_AppCompat_Dark']"
			[Register ("Platform_ThemeOverlay_AppCompat_Dark")]
			public const int PlatformThemeOverlayAppCompatDark = (int) 2131230843;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Platform_ThemeOverlay_AppCompat_Light']"
			[Register ("Platform_ThemeOverlay_AppCompat_Light")]
			public const int PlatformThemeOverlayAppCompatLight = (int) 2131230844;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Platform_V11_AppCompat']"
			[Register ("Platform_V11_AppCompat")]
			public const int PlatformV11AppCompat = (int) 2131230745;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Platform_V11_AppCompat_Light']"
			[Register ("Platform_V11_AppCompat_Light")]
			public const int PlatformV11AppCompatLight = (int) 2131230746;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Platform_V14_AppCompat']"
			[Register ("Platform_V14_AppCompat")]
			public const int PlatformV14AppCompat = (int) 2131230753;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Platform_V14_AppCompat_Light']"
			[Register ("Platform_V14_AppCompat_Light")]
			public const int PlatformV14AppCompatLight = (int) 2131230754;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Platform_Widget_AppCompat_Spinner']"
			[Register ("Platform_Widget_AppCompat_Spinner")]
			public const int PlatformWidgetAppCompatSpinner = (int) 2131230747;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='RtlOverlay_DialogWindowTitle_AppCompat']"
			[Register ("RtlOverlay_DialogWindowTitle_AppCompat")]
			public const int RtlOverlayDialogWindowTitleAppCompat = (int) 2131230760;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='RtlOverlay_Widget_AppCompat_ActionBar_TitleItem']"
			[Register ("RtlOverlay_Widget_AppCompat_ActionBar_TitleItem")]
			public const int RtlOverlayWidgetAppCompatActionBarTitleItem = (int) 2131230761;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='RtlOverlay_Widget_AppCompat_DialogTitle_Icon']"
			[Register ("RtlOverlay_Widget_AppCompat_DialogTitle_Icon")]
			public const int RtlOverlayWidgetAppCompatDialogTitleIcon = (int) 2131230762;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='RtlOverlay_Widget_AppCompat_PopupMenuItem']"
			[Register ("RtlOverlay_Widget_AppCompat_PopupMenuItem")]
			public const int RtlOverlayWidgetAppCompatPopupMenuItem = (int) 2131230763;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='RtlOverlay_Widget_AppCompat_PopupMenuItem_InternalGroup']"
			[Register ("RtlOverlay_Widget_AppCompat_PopupMenuItem_InternalGroup")]
			public const int RtlOverlayWidgetAppCompatPopupMenuItemInternalGroup = (int) 2131230764;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='RtlOverlay_Widget_AppCompat_PopupMenuItem_Text']"
			[Register ("RtlOverlay_Widget_AppCompat_PopupMenuItem_Text")]
			public const int RtlOverlayWidgetAppCompatPopupMenuItemText = (int) 2131230765;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='RtlOverlay_Widget_AppCompat_SearchView_MagIcon']"
			[Register ("RtlOverlay_Widget_AppCompat_SearchView_MagIcon")]
			public const int RtlOverlayWidgetAppCompatSearchViewMagIcon = (int) 2131230771;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='RtlOverlay_Widget_AppCompat_Search_DropDown']"
			[Register ("RtlOverlay_Widget_AppCompat_Search_DropDown")]
			public const int RtlOverlayWidgetAppCompatSearchDropDown = (int) 2131230766;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='RtlOverlay_Widget_AppCompat_Search_DropDown_Icon1']"
			[Register ("RtlOverlay_Widget_AppCompat_Search_DropDown_Icon1")]
			public const int RtlOverlayWidgetAppCompatSearchDropDownIcon1 = (int) 2131230767;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='RtlOverlay_Widget_AppCompat_Search_DropDown_Icon2']"
			[Register ("RtlOverlay_Widget_AppCompat_Search_DropDown_Icon2")]
			public const int RtlOverlayWidgetAppCompatSearchDropDownIcon2 = (int) 2131230768;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='RtlOverlay_Widget_AppCompat_Search_DropDown_Query']"
			[Register ("RtlOverlay_Widget_AppCompat_Search_DropDown_Query")]
			public const int RtlOverlayWidgetAppCompatSearchDropDownQuery = (int) 2131230769;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='RtlOverlay_Widget_AppCompat_Search_DropDown_Text']"
			[Register ("RtlOverlay_Widget_AppCompat_Search_DropDown_Text")]
			public const int RtlOverlayWidgetAppCompatSearchDropDownText = (int) 2131230770;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='RtlUnderlay_Widget_AppCompat_ActionButton']"
			[Register ("RtlUnderlay_Widget_AppCompat_ActionButton")]
			public const int RtlUnderlayWidgetAppCompatActionButton = (int) 2131230772;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='RtlUnderlay_Widget_AppCompat_ActionButton_Overflow']"
			[Register ("RtlUnderlay_Widget_AppCompat_ActionButton_Overflow")]
			public const int RtlUnderlayWidgetAppCompatActionButtonOverflow = (int) 2131230773;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='TextAppearance_AppCompat']"
			[Register ("TextAppearance_AppCompat")]
			public const int TextAppearanceAppCompat = (int) 2131230916;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='TextAppearance_AppCompat_Body1']"
			[Register ("TextAppearance_AppCompat_Body1")]
			public const int TextAppearanceAppCompatBody1 = (int) 2131230917;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='TextAppearance_AppCompat_Body2']"
			[Register ("TextAppearance_AppCompat_Body2")]
			public const int TextAppearanceAppCompatBody2 = (int) 2131230918;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='TextAppearance_AppCompat_Button']"
			[Register ("TextAppearance_AppCompat_Button")]
			public const int TextAppearanceAppCompatButton = (int) 2131230919;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='TextAppearance_AppCompat_Caption']"
			[Register ("TextAppearance_AppCompat_Caption")]
			public const int TextAppearanceAppCompatCaption = (int) 2131230920;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='TextAppearance_AppCompat_Display1']"
			[Register ("TextAppearance_AppCompat_Display1")]
			public const int TextAppearanceAppCompatDisplay1 = (int) 2131230921;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='TextAppearance_AppCompat_Display2']"
			[Register ("TextAppearance_AppCompat_Display2")]
			public const int TextAppearanceAppCompatDisplay2 = (int) 2131230922;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='TextAppearance_AppCompat_Display3']"
			[Register ("TextAppearance_AppCompat_Display3")]
			public const int TextAppearanceAppCompatDisplay3 = (int) 2131230923;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='TextAppearance_AppCompat_Display4']"
			[Register ("TextAppearance_AppCompat_Display4")]
			public const int TextAppearanceAppCompatDisplay4 = (int) 2131230924;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='TextAppearance_AppCompat_Headline']"
			[Register ("TextAppearance_AppCompat_Headline")]
			public const int TextAppearanceAppCompatHeadline = (int) 2131230925;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='TextAppearance_AppCompat_Inverse']"
			[Register ("TextAppearance_AppCompat_Inverse")]
			public const int TextAppearanceAppCompatInverse = (int) 2131230926;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='TextAppearance_AppCompat_Large']"
			[Register ("TextAppearance_AppCompat_Large")]
			public const int TextAppearanceAppCompatLarge = (int) 2131230927;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='TextAppearance_AppCompat_Large_Inverse']"
			[Register ("TextAppearance_AppCompat_Large_Inverse")]
			public const int TextAppearanceAppCompatLargeInverse = (int) 2131230928;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='TextAppearance_AppCompat_Light_SearchResult_Subtitle']"
			[Register ("TextAppearance_AppCompat_Light_SearchResult_Subtitle")]
			public const int TextAppearanceAppCompatLightSearchResultSubtitle = (int) 2131230929;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='TextAppearance_AppCompat_Light_SearchResult_Title']"
			[Register ("TextAppearance_AppCompat_Light_SearchResult_Title")]
			public const int TextAppearanceAppCompatLightSearchResultTitle = (int) 2131230930;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='TextAppearance_AppCompat_Light_Widget_PopupMenu_Large']"
			[Register ("TextAppearance_AppCompat_Light_Widget_PopupMenu_Large")]
			public const int TextAppearanceAppCompatLightWidgetPopupMenuLarge = (int) 2131230931;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='TextAppearance_AppCompat_Light_Widget_PopupMenu_Small']"
			[Register ("TextAppearance_AppCompat_Light_Widget_PopupMenu_Small")]
			public const int TextAppearanceAppCompatLightWidgetPopupMenuSmall = (int) 2131230932;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='TextAppearance_AppCompat_Medium']"
			[Register ("TextAppearance_AppCompat_Medium")]
			public const int TextAppearanceAppCompatMedium = (int) 2131230933;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='TextAppearance_AppCompat_Medium_Inverse']"
			[Register ("TextAppearance_AppCompat_Medium_Inverse")]
			public const int TextAppearanceAppCompatMediumInverse = (int) 2131230934;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='TextAppearance_AppCompat_Menu']"
			[Register ("TextAppearance_AppCompat_Menu")]
			public const int TextAppearanceAppCompatMenu = (int) 2131230935;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='TextAppearance_AppCompat_SearchResult_Subtitle']"
			[Register ("TextAppearance_AppCompat_SearchResult_Subtitle")]
			public const int TextAppearanceAppCompatSearchResultSubtitle = (int) 2131230936;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='TextAppearance_AppCompat_SearchResult_Title']"
			[Register ("TextAppearance_AppCompat_SearchResult_Title")]
			public const int TextAppearanceAppCompatSearchResultTitle = (int) 2131230937;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='TextAppearance_AppCompat_Small']"
			[Register ("TextAppearance_AppCompat_Small")]
			public const int TextAppearanceAppCompatSmall = (int) 2131230938;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='TextAppearance_AppCompat_Small_Inverse']"
			[Register ("TextAppearance_AppCompat_Small_Inverse")]
			public const int TextAppearanceAppCompatSmallInverse = (int) 2131230939;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='TextAppearance_AppCompat_Subhead']"
			[Register ("TextAppearance_AppCompat_Subhead")]
			public const int TextAppearanceAppCompatSubhead = (int) 2131230940;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='TextAppearance_AppCompat_Subhead_Inverse']"
			[Register ("TextAppearance_AppCompat_Subhead_Inverse")]
			public const int TextAppearanceAppCompatSubheadInverse = (int) 2131230941;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='TextAppearance_AppCompat_Title']"
			[Register ("TextAppearance_AppCompat_Title")]
			public const int TextAppearanceAppCompatTitle = (int) 2131230942;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='TextAppearance_AppCompat_Title_Inverse']"
			[Register ("TextAppearance_AppCompat_Title_Inverse")]
			public const int TextAppearanceAppCompatTitleInverse = (int) 2131230943;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='TextAppearance_AppCompat_Widget_ActionBar_Menu']"
			[Register ("TextAppearance_AppCompat_Widget_ActionBar_Menu")]
			public const int TextAppearanceAppCompatWidgetActionBarMenu = (int) 2131230944;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='TextAppearance_AppCompat_Widget_ActionBar_Subtitle']"
			[Register ("TextAppearance_AppCompat_Widget_ActionBar_Subtitle")]
			public const int TextAppearanceAppCompatWidgetActionBarSubtitle = (int) 2131230945;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='TextAppearance_AppCompat_Widget_ActionBar_Subtitle_Inverse']"
			[Register ("TextAppearance_AppCompat_Widget_ActionBar_Subtitle_Inverse")]
			public const int TextAppearanceAppCompatWidgetActionBarSubtitleInverse = (int) 2131230946;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='TextAppearance_AppCompat_Widget_ActionBar_Title']"
			[Register ("TextAppearance_AppCompat_Widget_ActionBar_Title")]
			public const int TextAppearanceAppCompatWidgetActionBarTitle = (int) 2131230947;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='TextAppearance_AppCompat_Widget_ActionBar_Title_Inverse']"
			[Register ("TextAppearance_AppCompat_Widget_ActionBar_Title_Inverse")]
			public const int TextAppearanceAppCompatWidgetActionBarTitleInverse = (int) 2131230948;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='TextAppearance_AppCompat_Widget_ActionMode_Subtitle']"
			[Register ("TextAppearance_AppCompat_Widget_ActionMode_Subtitle")]
			public const int TextAppearanceAppCompatWidgetActionModeSubtitle = (int) 2131230949;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='TextAppearance_AppCompat_Widget_ActionMode_Subtitle_Inverse']"
			[Register ("TextAppearance_AppCompat_Widget_ActionMode_Subtitle_Inverse")]
			public const int TextAppearanceAppCompatWidgetActionModeSubtitleInverse = (int) 2131230950;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='TextAppearance_AppCompat_Widget_ActionMode_Title']"
			[Register ("TextAppearance_AppCompat_Widget_ActionMode_Title")]
			public const int TextAppearanceAppCompatWidgetActionModeTitle = (int) 2131230951;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='TextAppearance_AppCompat_Widget_ActionMode_Title_Inverse']"
			[Register ("TextAppearance_AppCompat_Widget_ActionMode_Title_Inverse")]
			public const int TextAppearanceAppCompatWidgetActionModeTitleInverse = (int) 2131230952;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='TextAppearance_AppCompat_Widget_Button']"
			[Register ("TextAppearance_AppCompat_Widget_Button")]
			public const int TextAppearanceAppCompatWidgetButton = (int) 2131230953;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='TextAppearance_AppCompat_Widget_Button_Inverse']"
			[Register ("TextAppearance_AppCompat_Widget_Button_Inverse")]
			public const int TextAppearanceAppCompatWidgetButtonInverse = (int) 2131230954;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='TextAppearance_AppCompat_Widget_DropDownItem']"
			[Register ("TextAppearance_AppCompat_Widget_DropDownItem")]
			public const int TextAppearanceAppCompatWidgetDropDownItem = (int) 2131230955;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='TextAppearance_AppCompat_Widget_PopupMenu_Large']"
			[Register ("TextAppearance_AppCompat_Widget_PopupMenu_Large")]
			public const int TextAppearanceAppCompatWidgetPopupMenuLarge = (int) 2131230956;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='TextAppearance_AppCompat_Widget_PopupMenu_Small']"
			[Register ("TextAppearance_AppCompat_Widget_PopupMenu_Small")]
			public const int TextAppearanceAppCompatWidgetPopupMenuSmall = (int) 2131230957;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='TextAppearance_AppCompat_Widget_Switch']"
			[Register ("TextAppearance_AppCompat_Widget_Switch")]
			public const int TextAppearanceAppCompatWidgetSwitch = (int) 2131230958;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='TextAppearance_AppCompat_Widget_TextView_SpinnerItem']"
			[Register ("TextAppearance_AppCompat_Widget_TextView_SpinnerItem")]
			public const int TextAppearanceAppCompatWidgetTextViewSpinnerItem = (int) 2131230959;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='TextAppearance_StatusBar_EventContent']"
			[Register ("TextAppearance_StatusBar_EventContent")]
			public const int TextAppearanceStatusBarEventContent = (int) 2131230755;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='TextAppearance_StatusBar_EventContent_Info']"
			[Register ("TextAppearance_StatusBar_EventContent_Info")]
			public const int TextAppearanceStatusBarEventContentInfo = (int) 2131230756;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='TextAppearance_StatusBar_EventContent_Line2']"
			[Register ("TextAppearance_StatusBar_EventContent_Line2")]
			public const int TextAppearanceStatusBarEventContentLine2 = (int) 2131230757;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='TextAppearance_StatusBar_EventContent_Time']"
			[Register ("TextAppearance_StatusBar_EventContent_Time")]
			public const int TextAppearanceStatusBarEventContentTime = (int) 2131230758;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='TextAppearance_StatusBar_EventContent_Title']"
			[Register ("TextAppearance_StatusBar_EventContent_Title")]
			public const int TextAppearanceStatusBarEventContentTitle = (int) 2131230759;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='TextAppearance_Widget_AppCompat_ExpandedMenu_Item']"
			[Register ("TextAppearance_Widget_AppCompat_ExpandedMenu_Item")]
			public const int TextAppearanceWidgetAppCompatExpandedMenuItem = (int) 2131230960;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='TextAppearance_Widget_AppCompat_Toolbar_Subtitle']"
			[Register ("TextAppearance_Widget_AppCompat_Toolbar_Subtitle")]
			public const int TextAppearanceWidgetAppCompatToolbarSubtitle = (int) 2131230961;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='TextAppearance_Widget_AppCompat_Toolbar_Title']"
			[Register ("TextAppearance_Widget_AppCompat_Toolbar_Title")]
			public const int TextAppearanceWidgetAppCompatToolbarTitle = (int) 2131230962;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='ThemeOverlay_AppCompat']"
			[Register ("ThemeOverlay_AppCompat")]
			public const int ThemeOverlayAppCompat = (int) 2131230977;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='ThemeOverlay_AppCompat_ActionBar']"
			[Register ("ThemeOverlay_AppCompat_ActionBar")]
			public const int ThemeOverlayAppCompatActionBar = (int) 2131230978;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='ThemeOverlay_AppCompat_Dark']"
			[Register ("ThemeOverlay_AppCompat_Dark")]
			public const int ThemeOverlayAppCompatDark = (int) 2131230979;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='ThemeOverlay_AppCompat_Dark_ActionBar']"
			[Register ("ThemeOverlay_AppCompat_Dark_ActionBar")]
			public const int ThemeOverlayAppCompatDarkActionBar = (int) 2131230980;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='ThemeOverlay_AppCompat_Light']"
			[Register ("ThemeOverlay_AppCompat_Light")]
			public const int ThemeOverlayAppCompatLight = (int) 2131230981;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Theme_AppCompat']"
			[Register ("Theme_AppCompat")]
			public const int ThemeAppCompat = (int) 2131230963;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Theme_AppCompat_CompactMenu']"
			[Register ("Theme_AppCompat_CompactMenu")]
			public const int ThemeAppCompatCompactMenu = (int) 2131230964;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Theme_AppCompat_DayNight']"
			[Register ("Theme_AppCompat_DayNight")]
			public const int ThemeAppCompatDayNight = (int) 2131230724;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Theme_AppCompat_DayNight_DarkActionBar']"
			[Register ("Theme_AppCompat_DayNight_DarkActionBar")]
			public const int ThemeAppCompatDayNightDarkActionBar = (int) 2131230725;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Theme_AppCompat_DayNight_Dialog']"
			[Register ("Theme_AppCompat_DayNight_Dialog")]
			public const int ThemeAppCompatDayNightDialog = (int) 2131230726;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Theme_AppCompat_DayNight_DialogWhenLarge']"
			[Register ("Theme_AppCompat_DayNight_DialogWhenLarge")]
			public const int ThemeAppCompatDayNightDialogWhenLarge = (int) 2131230729;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Theme_AppCompat_DayNight_Dialog_Alert']"
			[Register ("Theme_AppCompat_DayNight_Dialog_Alert")]
			public const int ThemeAppCompatDayNightDialogAlert = (int) 2131230727;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Theme_AppCompat_DayNight_Dialog_MinWidth']"
			[Register ("Theme_AppCompat_DayNight_Dialog_MinWidth")]
			public const int ThemeAppCompatDayNightDialogMinWidth = (int) 2131230728;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Theme_AppCompat_DayNight_NoActionBar']"
			[Register ("Theme_AppCompat_DayNight_NoActionBar")]
			public const int ThemeAppCompatDayNightNoActionBar = (int) 2131230730;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Theme_AppCompat_Dialog']"
			[Register ("Theme_AppCompat_Dialog")]
			public const int ThemeAppCompatDialog = (int) 2131230965;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Theme_AppCompat_DialogWhenLarge']"
			[Register ("Theme_AppCompat_DialogWhenLarge")]
			public const int ThemeAppCompatDialogWhenLarge = (int) 2131230968;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Theme_AppCompat_Dialog_Alert']"
			[Register ("Theme_AppCompat_Dialog_Alert")]
			public const int ThemeAppCompatDialogAlert = (int) 2131230966;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Theme_AppCompat_Dialog_MinWidth']"
			[Register ("Theme_AppCompat_Dialog_MinWidth")]
			public const int ThemeAppCompatDialogMinWidth = (int) 2131230967;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Theme_AppCompat_Light']"
			[Register ("Theme_AppCompat_Light")]
			public const int ThemeAppCompatLight = (int) 2131230969;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Theme_AppCompat_Light_DarkActionBar']"
			[Register ("Theme_AppCompat_Light_DarkActionBar")]
			public const int ThemeAppCompatLightDarkActionBar = (int) 2131230970;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Theme_AppCompat_Light_Dialog']"
			[Register ("Theme_AppCompat_Light_Dialog")]
			public const int ThemeAppCompatLightDialog = (int) 2131230971;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Theme_AppCompat_Light_DialogWhenLarge']"
			[Register ("Theme_AppCompat_Light_DialogWhenLarge")]
			public const int ThemeAppCompatLightDialogWhenLarge = (int) 2131230974;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Theme_AppCompat_Light_Dialog_Alert']"
			[Register ("Theme_AppCompat_Light_Dialog_Alert")]
			public const int ThemeAppCompatLightDialogAlert = (int) 2131230972;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Theme_AppCompat_Light_Dialog_MinWidth']"
			[Register ("Theme_AppCompat_Light_Dialog_MinWidth")]
			public const int ThemeAppCompatLightDialogMinWidth = (int) 2131230973;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Theme_AppCompat_Light_NoActionBar']"
			[Register ("Theme_AppCompat_Light_NoActionBar")]
			public const int ThemeAppCompatLightNoActionBar = (int) 2131230975;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Theme_AppCompat_NoActionBar']"
			[Register ("Theme_AppCompat_NoActionBar")]
			public const int ThemeAppCompatNoActionBar = (int) 2131230976;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Widget_AppCompat_ActionBar']"
			[Register ("Widget_AppCompat_ActionBar")]
			public const int WidgetAppCompatActionBar = (int) 2131230982;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Widget_AppCompat_ActionBar_Solid']"
			[Register ("Widget_AppCompat_ActionBar_Solid")]
			public const int WidgetAppCompatActionBarSolid = (int) 2131230983;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Widget_AppCompat_ActionBar_TabBar']"
			[Register ("Widget_AppCompat_ActionBar_TabBar")]
			public const int WidgetAppCompatActionBarTabBar = (int) 2131230984;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Widget_AppCompat_ActionBar_TabText']"
			[Register ("Widget_AppCompat_ActionBar_TabText")]
			public const int WidgetAppCompatActionBarTabText = (int) 2131230985;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Widget_AppCompat_ActionBar_TabView']"
			[Register ("Widget_AppCompat_ActionBar_TabView")]
			public const int WidgetAppCompatActionBarTabView = (int) 2131230986;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Widget_AppCompat_ActionButton']"
			[Register ("Widget_AppCompat_ActionButton")]
			public const int WidgetAppCompatActionButton = (int) 2131230987;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Widget_AppCompat_ActionButton_CloseMode']"
			[Register ("Widget_AppCompat_ActionButton_CloseMode")]
			public const int WidgetAppCompatActionButtonCloseMode = (int) 2131230988;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Widget_AppCompat_ActionButton_Overflow']"
			[Register ("Widget_AppCompat_ActionButton_Overflow")]
			public const int WidgetAppCompatActionButtonOverflow = (int) 2131230989;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Widget_AppCompat_ActionMode']"
			[Register ("Widget_AppCompat_ActionMode")]
			public const int WidgetAppCompatActionMode = (int) 2131230990;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Widget_AppCompat_ActivityChooserView']"
			[Register ("Widget_AppCompat_ActivityChooserView")]
			public const int WidgetAppCompatActivityChooserView = (int) 2131230991;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Widget_AppCompat_AutoCompleteTextView']"
			[Register ("Widget_AppCompat_AutoCompleteTextView")]
			public const int WidgetAppCompatAutoCompleteTextView = (int) 2131230992;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Widget_AppCompat_Button']"
			[Register ("Widget_AppCompat_Button")]
			public const int WidgetAppCompatButton = (int) 2131230993;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Widget_AppCompat_ButtonBar']"
			[Register ("Widget_AppCompat_ButtonBar")]
			public const int WidgetAppCompatButtonBar = (int) 2131230999;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Widget_AppCompat_ButtonBar_AlertDialog']"
			[Register ("Widget_AppCompat_ButtonBar_AlertDialog")]
			public const int WidgetAppCompatButtonBarAlertDialog = (int) 2131231000;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Widget_AppCompat_Button_Borderless']"
			[Register ("Widget_AppCompat_Button_Borderless")]
			public const int WidgetAppCompatButtonBorderless = (int) 2131230994;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Widget_AppCompat_Button_Borderless_Colored']"
			[Register ("Widget_AppCompat_Button_Borderless_Colored")]
			public const int WidgetAppCompatButtonBorderlessColored = (int) 2131230995;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Widget_AppCompat_Button_ButtonBar_AlertDialog']"
			[Register ("Widget_AppCompat_Button_ButtonBar_AlertDialog")]
			public const int WidgetAppCompatButtonButtonBarAlertDialog = (int) 2131230996;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Widget_AppCompat_Button_Colored']"
			[Register ("Widget_AppCompat_Button_Colored")]
			public const int WidgetAppCompatButtonColored = (int) 2131230997;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Widget_AppCompat_Button_Small']"
			[Register ("Widget_AppCompat_Button_Small")]
			public const int WidgetAppCompatButtonSmall = (int) 2131230998;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Widget_AppCompat_CompoundButton_CheckBox']"
			[Register ("Widget_AppCompat_CompoundButton_CheckBox")]
			public const int WidgetAppCompatCompoundButtonCheckBox = (int) 2131231001;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Widget_AppCompat_CompoundButton_RadioButton']"
			[Register ("Widget_AppCompat_CompoundButton_RadioButton")]
			public const int WidgetAppCompatCompoundButtonRadioButton = (int) 2131231002;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Widget_AppCompat_CompoundButton_Switch']"
			[Register ("Widget_AppCompat_CompoundButton_Switch")]
			public const int WidgetAppCompatCompoundButtonSwitch = (int) 2131231003;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Widget_AppCompat_DrawerArrowToggle']"
			[Register ("Widget_AppCompat_DrawerArrowToggle")]
			public const int WidgetAppCompatDrawerArrowToggle = (int) 2131231004;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Widget_AppCompat_DropDownItem_Spinner']"
			[Register ("Widget_AppCompat_DropDownItem_Spinner")]
			public const int WidgetAppCompatDropDownItemSpinner = (int) 2131231005;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Widget_AppCompat_EditText']"
			[Register ("Widget_AppCompat_EditText")]
			public const int WidgetAppCompatEditText = (int) 2131231006;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Widget_AppCompat_ImageButton']"
			[Register ("Widget_AppCompat_ImageButton")]
			public const int WidgetAppCompatImageButton = (int) 2131231007;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Widget_AppCompat_Light_ActionBar']"
			[Register ("Widget_AppCompat_Light_ActionBar")]
			public const int WidgetAppCompatLightActionBar = (int) 2131231008;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Widget_AppCompat_Light_ActionBar_Solid']"
			[Register ("Widget_AppCompat_Light_ActionBar_Solid")]
			public const int WidgetAppCompatLightActionBarSolid = (int) 2131231009;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Widget_AppCompat_Light_ActionBar_Solid_Inverse']"
			[Register ("Widget_AppCompat_Light_ActionBar_Solid_Inverse")]
			public const int WidgetAppCompatLightActionBarSolidInverse = (int) 2131231010;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Widget_AppCompat_Light_ActionBar_TabBar']"
			[Register ("Widget_AppCompat_Light_ActionBar_TabBar")]
			public const int WidgetAppCompatLightActionBarTabBar = (int) 2131231011;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Widget_AppCompat_Light_ActionBar_TabBar_Inverse']"
			[Register ("Widget_AppCompat_Light_ActionBar_TabBar_Inverse")]
			public const int WidgetAppCompatLightActionBarTabBarInverse = (int) 2131231012;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Widget_AppCompat_Light_ActionBar_TabText']"
			[Register ("Widget_AppCompat_Light_ActionBar_TabText")]
			public const int WidgetAppCompatLightActionBarTabText = (int) 2131231013;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Widget_AppCompat_Light_ActionBar_TabText_Inverse']"
			[Register ("Widget_AppCompat_Light_ActionBar_TabText_Inverse")]
			public const int WidgetAppCompatLightActionBarTabTextInverse = (int) 2131231014;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Widget_AppCompat_Light_ActionBar_TabView']"
			[Register ("Widget_AppCompat_Light_ActionBar_TabView")]
			public const int WidgetAppCompatLightActionBarTabView = (int) 2131231015;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Widget_AppCompat_Light_ActionBar_TabView_Inverse']"
			[Register ("Widget_AppCompat_Light_ActionBar_TabView_Inverse")]
			public const int WidgetAppCompatLightActionBarTabViewInverse = (int) 2131231016;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Widget_AppCompat_Light_ActionButton']"
			[Register ("Widget_AppCompat_Light_ActionButton")]
			public const int WidgetAppCompatLightActionButton = (int) 2131231017;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Widget_AppCompat_Light_ActionButton_CloseMode']"
			[Register ("Widget_AppCompat_Light_ActionButton_CloseMode")]
			public const int WidgetAppCompatLightActionButtonCloseMode = (int) 2131231018;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Widget_AppCompat_Light_ActionButton_Overflow']"
			[Register ("Widget_AppCompat_Light_ActionButton_Overflow")]
			public const int WidgetAppCompatLightActionButtonOverflow = (int) 2131231019;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Widget_AppCompat_Light_ActionMode_Inverse']"
			[Register ("Widget_AppCompat_Light_ActionMode_Inverse")]
			public const int WidgetAppCompatLightActionModeInverse = (int) 2131231020;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Widget_AppCompat_Light_ActivityChooserView']"
			[Register ("Widget_AppCompat_Light_ActivityChooserView")]
			public const int WidgetAppCompatLightActivityChooserView = (int) 2131231021;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Widget_AppCompat_Light_AutoCompleteTextView']"
			[Register ("Widget_AppCompat_Light_AutoCompleteTextView")]
			public const int WidgetAppCompatLightAutoCompleteTextView = (int) 2131231022;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Widget_AppCompat_Light_DropDownItem_Spinner']"
			[Register ("Widget_AppCompat_Light_DropDownItem_Spinner")]
			public const int WidgetAppCompatLightDropDownItemSpinner = (int) 2131231023;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Widget_AppCompat_Light_ListPopupWindow']"
			[Register ("Widget_AppCompat_Light_ListPopupWindow")]
			public const int WidgetAppCompatLightListPopupWindow = (int) 2131231024;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Widget_AppCompat_Light_ListView_DropDown']"
			[Register ("Widget_AppCompat_Light_ListView_DropDown")]
			public const int WidgetAppCompatLightListViewDropDown = (int) 2131231025;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Widget_AppCompat_Light_PopupMenu']"
			[Register ("Widget_AppCompat_Light_PopupMenu")]
			public const int WidgetAppCompatLightPopupMenu = (int) 2131231026;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Widget_AppCompat_Light_PopupMenu_Overflow']"
			[Register ("Widget_AppCompat_Light_PopupMenu_Overflow")]
			public const int WidgetAppCompatLightPopupMenuOverflow = (int) 2131231027;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Widget_AppCompat_Light_SearchView']"
			[Register ("Widget_AppCompat_Light_SearchView")]
			public const int WidgetAppCompatLightSearchView = (int) 2131231028;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Widget_AppCompat_Light_Spinner_DropDown_ActionBar']"
			[Register ("Widget_AppCompat_Light_Spinner_DropDown_ActionBar")]
			public const int WidgetAppCompatLightSpinnerDropDownActionBar = (int) 2131231029;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Widget_AppCompat_ListPopupWindow']"
			[Register ("Widget_AppCompat_ListPopupWindow")]
			public const int WidgetAppCompatListPopupWindow = (int) 2131231030;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Widget_AppCompat_ListView']"
			[Register ("Widget_AppCompat_ListView")]
			public const int WidgetAppCompatListView = (int) 2131231031;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Widget_AppCompat_ListView_DropDown']"
			[Register ("Widget_AppCompat_ListView_DropDown")]
			public const int WidgetAppCompatListViewDropDown = (int) 2131231032;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Widget_AppCompat_ListView_Menu']"
			[Register ("Widget_AppCompat_ListView_Menu")]
			public const int WidgetAppCompatListViewMenu = (int) 2131231033;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Widget_AppCompat_PopupMenu']"
			[Register ("Widget_AppCompat_PopupMenu")]
			public const int WidgetAppCompatPopupMenu = (int) 2131231034;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Widget_AppCompat_PopupMenu_Overflow']"
			[Register ("Widget_AppCompat_PopupMenu_Overflow")]
			public const int WidgetAppCompatPopupMenuOverflow = (int) 2131231035;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Widget_AppCompat_PopupWindow']"
			[Register ("Widget_AppCompat_PopupWindow")]
			public const int WidgetAppCompatPopupWindow = (int) 2131231036;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Widget_AppCompat_ProgressBar']"
			[Register ("Widget_AppCompat_ProgressBar")]
			public const int WidgetAppCompatProgressBar = (int) 2131231037;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Widget_AppCompat_ProgressBar_Horizontal']"
			[Register ("Widget_AppCompat_ProgressBar_Horizontal")]
			public const int WidgetAppCompatProgressBarHorizontal = (int) 2131231038;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Widget_AppCompat_RatingBar']"
			[Register ("Widget_AppCompat_RatingBar")]
			public const int WidgetAppCompatRatingBar = (int) 2131231039;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Widget_AppCompat_RatingBar_Indicator']"
			[Register ("Widget_AppCompat_RatingBar_Indicator")]
			public const int WidgetAppCompatRatingBarIndicator = (int) 2131231040;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Widget_AppCompat_RatingBar_Small']"
			[Register ("Widget_AppCompat_RatingBar_Small")]
			public const int WidgetAppCompatRatingBarSmall = (int) 2131231041;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Widget_AppCompat_SearchView']"
			[Register ("Widget_AppCompat_SearchView")]
			public const int WidgetAppCompatSearchView = (int) 2131231042;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Widget_AppCompat_SearchView_ActionBar']"
			[Register ("Widget_AppCompat_SearchView_ActionBar")]
			public const int WidgetAppCompatSearchViewActionBar = (int) 2131231043;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Widget_AppCompat_SeekBar']"
			[Register ("Widget_AppCompat_SeekBar")]
			public const int WidgetAppCompatSeekBar = (int) 2131231044;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Widget_AppCompat_Spinner']"
			[Register ("Widget_AppCompat_Spinner")]
			public const int WidgetAppCompatSpinner = (int) 2131231045;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Widget_AppCompat_Spinner_DropDown']"
			[Register ("Widget_AppCompat_Spinner_DropDown")]
			public const int WidgetAppCompatSpinnerDropDown = (int) 2131231046;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Widget_AppCompat_Spinner_DropDown_ActionBar']"
			[Register ("Widget_AppCompat_Spinner_DropDown_ActionBar")]
			public const int WidgetAppCompatSpinnerDropDownActionBar = (int) 2131231047;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Widget_AppCompat_Spinner_Underlined']"
			[Register ("Widget_AppCompat_Spinner_Underlined")]
			public const int WidgetAppCompatSpinnerUnderlined = (int) 2131231048;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Widget_AppCompat_TextView_SpinnerItem']"
			[Register ("Widget_AppCompat_TextView_SpinnerItem")]
			public const int WidgetAppCompatTextViewSpinnerItem = (int) 2131231049;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Widget_AppCompat_Toolbar']"
			[Register ("Widget_AppCompat_Toolbar")]
			public const int WidgetAppCompatToolbar = (int) 2131231050;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/field[@name='Widget_AppCompat_Toolbar_Button_Navigation']"
			[Register ("Widget_AppCompat_Toolbar_Button_Navigation")]
			public const int WidgetAppCompatToolbarButtonNavigation = (int) 2131231051;
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("android/support/v7/appcompat/R$style", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Style); }
			}

			internal Style (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.style']/constructor[@name='R.style' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Style ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (((object) this).GetType () != typeof (Style)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
						return;
					}

					if (id_ctor == IntPtr.Zero)
						id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']"
		[global::Android.Runtime.Register ("android/support/v7/appcompat/R$styleable", DoNotGenerateAcw=true)]
		public sealed partial class Styleable : global::Java.Lang.Object {


			static IntPtr ActionBar_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='ActionBar']"
			[Register ("ActionBar")]
			public static IList<int> ActionBar {
				get {
					if (ActionBar_jfieldId == IntPtr.Zero)
						ActionBar_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ActionBar", "[I");
					return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, ActionBar_jfieldId), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr ActionBarLayout_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='ActionBarLayout']"
			[Register ("ActionBarLayout")]
			public static IList<int> ActionBarLayout {
				get {
					if (ActionBarLayout_jfieldId == IntPtr.Zero)
						ActionBarLayout_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ActionBarLayout", "[I");
					return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, ActionBarLayout_jfieldId), JniHandleOwnership.TransferLocalRef);
				}
			}

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='ActionBarLayout_android_layout_gravity']"
			[Register ("ActionBarLayout_android_layout_gravity")]
			public const int ActionBarLayoutAndroidLayoutGravity = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='ActionBar_background']"
			[Register ("ActionBar_background")]
			public const int ActionBarBackground = (int) 10;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='ActionBar_backgroundSplit']"
			[Register ("ActionBar_backgroundSplit")]
			public const int ActionBarBackgroundSplit = (int) 12;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='ActionBar_backgroundStacked']"
			[Register ("ActionBar_backgroundStacked")]
			public const int ActionBarBackgroundStacked = (int) 11;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='ActionBar_contentInsetEnd']"
			[Register ("ActionBar_contentInsetEnd")]
			public const int ActionBarContentInsetEnd = (int) 21;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='ActionBar_contentInsetLeft']"
			[Register ("ActionBar_contentInsetLeft")]
			public const int ActionBarContentInsetLeft = (int) 22;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='ActionBar_contentInsetRight']"
			[Register ("ActionBar_contentInsetRight")]
			public const int ActionBarContentInsetRight = (int) 23;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='ActionBar_contentInsetStart']"
			[Register ("ActionBar_contentInsetStart")]
			public const int ActionBarContentInsetStart = (int) 20;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='ActionBar_customNavigationLayout']"
			[Register ("ActionBar_customNavigationLayout")]
			public const int ActionBarCustomNavigationLayout = (int) 13;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='ActionBar_displayOptions']"
			[Register ("ActionBar_displayOptions")]
			public const int ActionBarDisplayOptions = (int) 3;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='ActionBar_divider']"
			[Register ("ActionBar_divider")]
			public const int ActionBarDivider = (int) 9;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='ActionBar_elevation']"
			[Register ("ActionBar_elevation")]
			public const int ActionBarElevation = (int) 24;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='ActionBar_height']"
			[Register ("ActionBar_height")]
			public const int ActionBarHeight = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='ActionBar_hideOnContentScroll']"
			[Register ("ActionBar_hideOnContentScroll")]
			public const int ActionBarHideOnContentScroll = (int) 19;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='ActionBar_homeAsUpIndicator']"
			[Register ("ActionBar_homeAsUpIndicator")]
			public const int ActionBarHomeAsUpIndicator = (int) 26;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='ActionBar_homeLayout']"
			[Register ("ActionBar_homeLayout")]
			public const int ActionBarHomeLayout = (int) 14;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='ActionBar_icon']"
			[Register ("ActionBar_icon")]
			public const int ActionBarIcon = (int) 7;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='ActionBar_indeterminateProgressStyle']"
			[Register ("ActionBar_indeterminateProgressStyle")]
			public const int ActionBarIndeterminateProgressStyle = (int) 16;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='ActionBar_itemPadding']"
			[Register ("ActionBar_itemPadding")]
			public const int ActionBarItemPadding = (int) 18;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='ActionBar_logo']"
			[Register ("ActionBar_logo")]
			public const int ActionBarLogo = (int) 8;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='ActionBar_navigationMode']"
			[Register ("ActionBar_navigationMode")]
			public const int ActionBarNavigationMode = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='ActionBar_popupTheme']"
			[Register ("ActionBar_popupTheme")]
			public const int ActionBarPopupTheme = (int) 25;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='ActionBar_progressBarPadding']"
			[Register ("ActionBar_progressBarPadding")]
			public const int ActionBarProgressBarPadding = (int) 17;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='ActionBar_progressBarStyle']"
			[Register ("ActionBar_progressBarStyle")]
			public const int ActionBarProgressBarStyle = (int) 15;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='ActionBar_subtitle']"
			[Register ("ActionBar_subtitle")]
			public const int ActionBarSubtitle = (int) 4;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='ActionBar_subtitleTextStyle']"
			[Register ("ActionBar_subtitleTextStyle")]
			public const int ActionBarSubtitleTextStyle = (int) 6;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='ActionBar_title']"
			[Register ("ActionBar_title")]
			public const int ActionBarTitle = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='ActionBar_titleTextStyle']"
			[Register ("ActionBar_titleTextStyle")]
			public const int ActionBarTitleTextStyle = (int) 5;

			static IntPtr ActionMenuItemView_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='ActionMenuItemView']"
			[Register ("ActionMenuItemView")]
			public static IList<int> ActionMenuItemView {
				get {
					if (ActionMenuItemView_jfieldId == IntPtr.Zero)
						ActionMenuItemView_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ActionMenuItemView", "[I");
					return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, ActionMenuItemView_jfieldId), JniHandleOwnership.TransferLocalRef);
				}
			}

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='ActionMenuItemView_android_minWidth']"
			[Register ("ActionMenuItemView_android_minWidth")]
			public const int ActionMenuItemViewAndroidMinWidth = (int) 0;

			static IntPtr ActionMenuView_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='ActionMenuView']"
			[Register ("ActionMenuView")]
			public static IList<int> ActionMenuView {
				get {
					if (ActionMenuView_jfieldId == IntPtr.Zero)
						ActionMenuView_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ActionMenuView", "[I");
					return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, ActionMenuView_jfieldId), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr ActionMode_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='ActionMode']"
			[Register ("ActionMode")]
			public static IList<int> ActionMode {
				get {
					if (ActionMode_jfieldId == IntPtr.Zero)
						ActionMode_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ActionMode", "[I");
					return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, ActionMode_jfieldId), JniHandleOwnership.TransferLocalRef);
				}
			}

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='ActionMode_background']"
			[Register ("ActionMode_background")]
			public const int ActionModeBackground = (int) 3;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='ActionMode_backgroundSplit']"
			[Register ("ActionMode_backgroundSplit")]
			public const int ActionModeBackgroundSplit = (int) 4;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='ActionMode_closeItemLayout']"
			[Register ("ActionMode_closeItemLayout")]
			public const int ActionModeCloseItemLayout = (int) 5;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='ActionMode_height']"
			[Register ("ActionMode_height")]
			public const int ActionModeHeight = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='ActionMode_subtitleTextStyle']"
			[Register ("ActionMode_subtitleTextStyle")]
			public const int ActionModeSubtitleTextStyle = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='ActionMode_titleTextStyle']"
			[Register ("ActionMode_titleTextStyle")]
			public const int ActionModeTitleTextStyle = (int) 1;

			static IntPtr ActivityChooserView_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='ActivityChooserView']"
			[Register ("ActivityChooserView")]
			public static IList<int> ActivityChooserView {
				get {
					if (ActivityChooserView_jfieldId == IntPtr.Zero)
						ActivityChooserView_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ActivityChooserView", "[I");
					return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, ActivityChooserView_jfieldId), JniHandleOwnership.TransferLocalRef);
				}
			}

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='ActivityChooserView_expandActivityOverflowButtonDrawable']"
			[Register ("ActivityChooserView_expandActivityOverflowButtonDrawable")]
			public const int ActivityChooserViewExpandActivityOverflowButtonDrawable = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='ActivityChooserView_initialActivityCount']"
			[Register ("ActivityChooserView_initialActivityCount")]
			public const int ActivityChooserViewInitialActivityCount = (int) 0;

			static IntPtr AlertDialog_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AlertDialog']"
			[Register ("AlertDialog")]
			public static IList<int> AlertDialog {
				get {
					if (AlertDialog_jfieldId == IntPtr.Zero)
						AlertDialog_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AlertDialog", "[I");
					return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, AlertDialog_jfieldId), JniHandleOwnership.TransferLocalRef);
				}
			}

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AlertDialog_android_layout']"
			[Register ("AlertDialog_android_layout")]
			public const int AlertDialogAndroidLayout = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AlertDialog_buttonPanelSideLayout']"
			[Register ("AlertDialog_buttonPanelSideLayout")]
			public const int AlertDialogButtonPanelSideLayout = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AlertDialog_listItemLayout']"
			[Register ("AlertDialog_listItemLayout")]
			public const int AlertDialogListItemLayout = (int) 5;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AlertDialog_listLayout']"
			[Register ("AlertDialog_listLayout")]
			public const int AlertDialogListLayout = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AlertDialog_multiChoiceItemLayout']"
			[Register ("AlertDialog_multiChoiceItemLayout")]
			public const int AlertDialogMultiChoiceItemLayout = (int) 3;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AlertDialog_singleChoiceItemLayout']"
			[Register ("AlertDialog_singleChoiceItemLayout")]
			public const int AlertDialogSingleChoiceItemLayout = (int) 4;

			static IntPtr AppCompatImageView_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatImageView']"
			[Register ("AppCompatImageView")]
			public static IList<int> AppCompatImageView {
				get {
					if (AppCompatImageView_jfieldId == IntPtr.Zero)
						AppCompatImageView_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AppCompatImageView", "[I");
					return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, AppCompatImageView_jfieldId), JniHandleOwnership.TransferLocalRef);
				}
			}

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatImageView_android_src']"
			[Register ("AppCompatImageView_android_src")]
			public const int AppCompatImageViewAndroidSrc = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatImageView_srcCompat']"
			[Register ("AppCompatImageView_srcCompat")]
			public const int AppCompatImageViewSrcCompat = (int) 1;

			static IntPtr AppCompatTextView_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTextView']"
			[Register ("AppCompatTextView")]
			public static IList<int> AppCompatTextView {
				get {
					if (AppCompatTextView_jfieldId == IntPtr.Zero)
						AppCompatTextView_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AppCompatTextView", "[I");
					return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, AppCompatTextView_jfieldId), JniHandleOwnership.TransferLocalRef);
				}
			}

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTextView_android_textAppearance']"
			[Register ("AppCompatTextView_android_textAppearance")]
			public const int AppCompatTextViewAndroidTextAppearance = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTextView_textAllCaps']"
			[Register ("AppCompatTextView_textAllCaps")]
			public const int AppCompatTextViewTextAllCaps = (int) 1;

			static IntPtr AppCompatTheme_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme']"
			[Register ("AppCompatTheme")]
			public static IList<int> AppCompatTheme {
				get {
					if (AppCompatTheme_jfieldId == IntPtr.Zero)
						AppCompatTheme_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AppCompatTheme", "[I");
					return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, AppCompatTheme_jfieldId), JniHandleOwnership.TransferLocalRef);
				}
			}

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_actionBarDivider']"
			[Register ("AppCompatTheme_actionBarDivider")]
			public const int AppCompatThemeActionBarDivider = (int) 23;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_actionBarItemBackground']"
			[Register ("AppCompatTheme_actionBarItemBackground")]
			public const int AppCompatThemeActionBarItemBackground = (int) 24;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_actionBarPopupTheme']"
			[Register ("AppCompatTheme_actionBarPopupTheme")]
			public const int AppCompatThemeActionBarPopupTheme = (int) 17;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_actionBarSize']"
			[Register ("AppCompatTheme_actionBarSize")]
			public const int AppCompatThemeActionBarSize = (int) 22;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_actionBarSplitStyle']"
			[Register ("AppCompatTheme_actionBarSplitStyle")]
			public const int AppCompatThemeActionBarSplitStyle = (int) 19;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_actionBarStyle']"
			[Register ("AppCompatTheme_actionBarStyle")]
			public const int AppCompatThemeActionBarStyle = (int) 18;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_actionBarTabBarStyle']"
			[Register ("AppCompatTheme_actionBarTabBarStyle")]
			public const int AppCompatThemeActionBarTabBarStyle = (int) 13;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_actionBarTabStyle']"
			[Register ("AppCompatTheme_actionBarTabStyle")]
			public const int AppCompatThemeActionBarTabStyle = (int) 12;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_actionBarTabTextStyle']"
			[Register ("AppCompatTheme_actionBarTabTextStyle")]
			public const int AppCompatThemeActionBarTabTextStyle = (int) 14;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_actionBarTheme']"
			[Register ("AppCompatTheme_actionBarTheme")]
			public const int AppCompatThemeActionBarTheme = (int) 20;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_actionBarWidgetTheme']"
			[Register ("AppCompatTheme_actionBarWidgetTheme")]
			public const int AppCompatThemeActionBarWidgetTheme = (int) 21;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_actionButtonStyle']"
			[Register ("AppCompatTheme_actionButtonStyle")]
			public const int AppCompatThemeActionButtonStyle = (int) 49;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_actionDropDownStyle']"
			[Register ("AppCompatTheme_actionDropDownStyle")]
			public const int AppCompatThemeActionDropDownStyle = (int) 45;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_actionMenuTextAppearance']"
			[Register ("AppCompatTheme_actionMenuTextAppearance")]
			public const int AppCompatThemeActionMenuTextAppearance = (int) 25;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_actionMenuTextColor']"
			[Register ("AppCompatTheme_actionMenuTextColor")]
			public const int AppCompatThemeActionMenuTextColor = (int) 26;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_actionModeBackground']"
			[Register ("AppCompatTheme_actionModeBackground")]
			public const int AppCompatThemeActionModeBackground = (int) 29;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_actionModeCloseButtonStyle']"
			[Register ("AppCompatTheme_actionModeCloseButtonStyle")]
			public const int AppCompatThemeActionModeCloseButtonStyle = (int) 28;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_actionModeCloseDrawable']"
			[Register ("AppCompatTheme_actionModeCloseDrawable")]
			public const int AppCompatThemeActionModeCloseDrawable = (int) 31;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_actionModeCopyDrawable']"
			[Register ("AppCompatTheme_actionModeCopyDrawable")]
			public const int AppCompatThemeActionModeCopyDrawable = (int) 33;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_actionModeCutDrawable']"
			[Register ("AppCompatTheme_actionModeCutDrawable")]
			public const int AppCompatThemeActionModeCutDrawable = (int) 32;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_actionModeFindDrawable']"
			[Register ("AppCompatTheme_actionModeFindDrawable")]
			public const int AppCompatThemeActionModeFindDrawable = (int) 37;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_actionModePasteDrawable']"
			[Register ("AppCompatTheme_actionModePasteDrawable")]
			public const int AppCompatThemeActionModePasteDrawable = (int) 34;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_actionModePopupWindowStyle']"
			[Register ("AppCompatTheme_actionModePopupWindowStyle")]
			public const int AppCompatThemeActionModePopupWindowStyle = (int) 39;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_actionModeSelectAllDrawable']"
			[Register ("AppCompatTheme_actionModeSelectAllDrawable")]
			public const int AppCompatThemeActionModeSelectAllDrawable = (int) 35;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_actionModeShareDrawable']"
			[Register ("AppCompatTheme_actionModeShareDrawable")]
			public const int AppCompatThemeActionModeShareDrawable = (int) 36;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_actionModeSplitBackground']"
			[Register ("AppCompatTheme_actionModeSplitBackground")]
			public const int AppCompatThemeActionModeSplitBackground = (int) 30;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_actionModeStyle']"
			[Register ("AppCompatTheme_actionModeStyle")]
			public const int AppCompatThemeActionModeStyle = (int) 27;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_actionModeWebSearchDrawable']"
			[Register ("AppCompatTheme_actionModeWebSearchDrawable")]
			public const int AppCompatThemeActionModeWebSearchDrawable = (int) 38;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_actionOverflowButtonStyle']"
			[Register ("AppCompatTheme_actionOverflowButtonStyle")]
			public const int AppCompatThemeActionOverflowButtonStyle = (int) 15;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_actionOverflowMenuStyle']"
			[Register ("AppCompatTheme_actionOverflowMenuStyle")]
			public const int AppCompatThemeActionOverflowMenuStyle = (int) 16;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_activityChooserViewStyle']"
			[Register ("AppCompatTheme_activityChooserViewStyle")]
			public const int AppCompatThemeActivityChooserViewStyle = (int) 57;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_alertDialogButtonGroupStyle']"
			[Register ("AppCompatTheme_alertDialogButtonGroupStyle")]
			public const int AppCompatThemeAlertDialogButtonGroupStyle = (int) 92;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_alertDialogCenterButtons']"
			[Register ("AppCompatTheme_alertDialogCenterButtons")]
			public const int AppCompatThemeAlertDialogCenterButtons = (int) 93;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_alertDialogStyle']"
			[Register ("AppCompatTheme_alertDialogStyle")]
			public const int AppCompatThemeAlertDialogStyle = (int) 91;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_alertDialogTheme']"
			[Register ("AppCompatTheme_alertDialogTheme")]
			public const int AppCompatThemeAlertDialogTheme = (int) 94;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_android_windowAnimationStyle']"
			[Register ("AppCompatTheme_android_windowAnimationStyle")]
			public const int AppCompatThemeAndroidWindowAnimationStyle = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_android_windowIsFloating']"
			[Register ("AppCompatTheme_android_windowIsFloating")]
			public const int AppCompatThemeAndroidWindowIsFloating = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_autoCompleteTextViewStyle']"
			[Register ("AppCompatTheme_autoCompleteTextViewStyle")]
			public const int AppCompatThemeAutoCompleteTextViewStyle = (int) 99;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_borderlessButtonStyle']"
			[Register ("AppCompatTheme_borderlessButtonStyle")]
			public const int AppCompatThemeBorderlessButtonStyle = (int) 54;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_buttonBarButtonStyle']"
			[Register ("AppCompatTheme_buttonBarButtonStyle")]
			public const int AppCompatThemeButtonBarButtonStyle = (int) 51;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_buttonBarNegativeButtonStyle']"
			[Register ("AppCompatTheme_buttonBarNegativeButtonStyle")]
			public const int AppCompatThemeButtonBarNegativeButtonStyle = (int) 97;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_buttonBarNeutralButtonStyle']"
			[Register ("AppCompatTheme_buttonBarNeutralButtonStyle")]
			public const int AppCompatThemeButtonBarNeutralButtonStyle = (int) 98;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_buttonBarPositiveButtonStyle']"
			[Register ("AppCompatTheme_buttonBarPositiveButtonStyle")]
			public const int AppCompatThemeButtonBarPositiveButtonStyle = (int) 96;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_buttonBarStyle']"
			[Register ("AppCompatTheme_buttonBarStyle")]
			public const int AppCompatThemeButtonBarStyle = (int) 50;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_buttonStyle']"
			[Register ("AppCompatTheme_buttonStyle")]
			public const int AppCompatThemeButtonStyle = (int) 100;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_buttonStyleSmall']"
			[Register ("AppCompatTheme_buttonStyleSmall")]
			public const int AppCompatThemeButtonStyleSmall = (int) 101;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_checkboxStyle']"
			[Register ("AppCompatTheme_checkboxStyle")]
			public const int AppCompatThemeCheckboxStyle = (int) 102;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_checkedTextViewStyle']"
			[Register ("AppCompatTheme_checkedTextViewStyle")]
			public const int AppCompatThemeCheckedTextViewStyle = (int) 103;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_colorAccent']"
			[Register ("AppCompatTheme_colorAccent")]
			public const int AppCompatThemeColorAccent = (int) 84;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_colorButtonNormal']"
			[Register ("AppCompatTheme_colorButtonNormal")]
			public const int AppCompatThemeColorButtonNormal = (int) 88;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_colorControlActivated']"
			[Register ("AppCompatTheme_colorControlActivated")]
			public const int AppCompatThemeColorControlActivated = (int) 86;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_colorControlHighlight']"
			[Register ("AppCompatTheme_colorControlHighlight")]
			public const int AppCompatThemeColorControlHighlight = (int) 87;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_colorControlNormal']"
			[Register ("AppCompatTheme_colorControlNormal")]
			public const int AppCompatThemeColorControlNormal = (int) 85;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_colorPrimary']"
			[Register ("AppCompatTheme_colorPrimary")]
			public const int AppCompatThemeColorPrimary = (int) 82;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_colorPrimaryDark']"
			[Register ("AppCompatTheme_colorPrimaryDark")]
			public const int AppCompatThemeColorPrimaryDark = (int) 83;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_colorSwitchThumbNormal']"
			[Register ("AppCompatTheme_colorSwitchThumbNormal")]
			public const int AppCompatThemeColorSwitchThumbNormal = (int) 89;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_controlBackground']"
			[Register ("AppCompatTheme_controlBackground")]
			public const int AppCompatThemeControlBackground = (int) 90;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_dialogPreferredPadding']"
			[Register ("AppCompatTheme_dialogPreferredPadding")]
			public const int AppCompatThemeDialogPreferredPadding = (int) 43;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_dialogTheme']"
			[Register ("AppCompatTheme_dialogTheme")]
			public const int AppCompatThemeDialogTheme = (int) 42;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_dividerHorizontal']"
			[Register ("AppCompatTheme_dividerHorizontal")]
			public const int AppCompatThemeDividerHorizontal = (int) 56;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_dividerVertical']"
			[Register ("AppCompatTheme_dividerVertical")]
			public const int AppCompatThemeDividerVertical = (int) 55;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_dropDownListViewStyle']"
			[Register ("AppCompatTheme_dropDownListViewStyle")]
			public const int AppCompatThemeDropDownListViewStyle = (int) 74;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_dropdownListPreferredItemHeight']"
			[Register ("AppCompatTheme_dropdownListPreferredItemHeight")]
			public const int AppCompatThemeDropdownListPreferredItemHeight = (int) 46;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_editTextBackground']"
			[Register ("AppCompatTheme_editTextBackground")]
			public const int AppCompatThemeEditTextBackground = (int) 63;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_editTextColor']"
			[Register ("AppCompatTheme_editTextColor")]
			public const int AppCompatThemeEditTextColor = (int) 62;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_editTextStyle']"
			[Register ("AppCompatTheme_editTextStyle")]
			public const int AppCompatThemeEditTextStyle = (int) 104;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_homeAsUpIndicator']"
			[Register ("AppCompatTheme_homeAsUpIndicator")]
			public const int AppCompatThemeHomeAsUpIndicator = (int) 48;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_imageButtonStyle']"
			[Register ("AppCompatTheme_imageButtonStyle")]
			public const int AppCompatThemeImageButtonStyle = (int) 64;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_listChoiceBackgroundIndicator']"
			[Register ("AppCompatTheme_listChoiceBackgroundIndicator")]
			public const int AppCompatThemeListChoiceBackgroundIndicator = (int) 81;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_listDividerAlertDialog']"
			[Register ("AppCompatTheme_listDividerAlertDialog")]
			public const int AppCompatThemeListDividerAlertDialog = (int) 44;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_listPopupWindowStyle']"
			[Register ("AppCompatTheme_listPopupWindowStyle")]
			public const int AppCompatThemeListPopupWindowStyle = (int) 75;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_listPreferredItemHeight']"
			[Register ("AppCompatTheme_listPreferredItemHeight")]
			public const int AppCompatThemeListPreferredItemHeight = (int) 69;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_listPreferredItemHeightLarge']"
			[Register ("AppCompatTheme_listPreferredItemHeightLarge")]
			public const int AppCompatThemeListPreferredItemHeightLarge = (int) 71;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_listPreferredItemHeightSmall']"
			[Register ("AppCompatTheme_listPreferredItemHeightSmall")]
			public const int AppCompatThemeListPreferredItemHeightSmall = (int) 70;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_listPreferredItemPaddingLeft']"
			[Register ("AppCompatTheme_listPreferredItemPaddingLeft")]
			public const int AppCompatThemeListPreferredItemPaddingLeft = (int) 72;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_listPreferredItemPaddingRight']"
			[Register ("AppCompatTheme_listPreferredItemPaddingRight")]
			public const int AppCompatThemeListPreferredItemPaddingRight = (int) 73;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_panelBackground']"
			[Register ("AppCompatTheme_panelBackground")]
			public const int AppCompatThemePanelBackground = (int) 78;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_panelMenuListTheme']"
			[Register ("AppCompatTheme_panelMenuListTheme")]
			public const int AppCompatThemePanelMenuListTheme = (int) 80;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_panelMenuListWidth']"
			[Register ("AppCompatTheme_panelMenuListWidth")]
			public const int AppCompatThemePanelMenuListWidth = (int) 79;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_popupMenuStyle']"
			[Register ("AppCompatTheme_popupMenuStyle")]
			public const int AppCompatThemePopupMenuStyle = (int) 60;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_popupWindowStyle']"
			[Register ("AppCompatTheme_popupWindowStyle")]
			public const int AppCompatThemePopupWindowStyle = (int) 61;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_radioButtonStyle']"
			[Register ("AppCompatTheme_radioButtonStyle")]
			public const int AppCompatThemeRadioButtonStyle = (int) 105;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_ratingBarStyle']"
			[Register ("AppCompatTheme_ratingBarStyle")]
			public const int AppCompatThemeRatingBarStyle = (int) 106;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_ratingBarStyleIndicator']"
			[Register ("AppCompatTheme_ratingBarStyleIndicator")]
			public const int AppCompatThemeRatingBarStyleIndicator = (int) 107;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_ratingBarStyleSmall']"
			[Register ("AppCompatTheme_ratingBarStyleSmall")]
			public const int AppCompatThemeRatingBarStyleSmall = (int) 108;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_searchViewStyle']"
			[Register ("AppCompatTheme_searchViewStyle")]
			public const int AppCompatThemeSearchViewStyle = (int) 68;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_seekBarStyle']"
			[Register ("AppCompatTheme_seekBarStyle")]
			public const int AppCompatThemeSeekBarStyle = (int) 109;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_selectableItemBackground']"
			[Register ("AppCompatTheme_selectableItemBackground")]
			public const int AppCompatThemeSelectableItemBackground = (int) 52;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_selectableItemBackgroundBorderless']"
			[Register ("AppCompatTheme_selectableItemBackgroundBorderless")]
			public const int AppCompatThemeSelectableItemBackgroundBorderless = (int) 53;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_spinnerDropDownItemStyle']"
			[Register ("AppCompatTheme_spinnerDropDownItemStyle")]
			public const int AppCompatThemeSpinnerDropDownItemStyle = (int) 47;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_spinnerStyle']"
			[Register ("AppCompatTheme_spinnerStyle")]
			public const int AppCompatThemeSpinnerStyle = (int) 110;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_switchStyle']"
			[Register ("AppCompatTheme_switchStyle")]
			public const int AppCompatThemeSwitchStyle = (int) 111;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_textAppearanceLargePopupMenu']"
			[Register ("AppCompatTheme_textAppearanceLargePopupMenu")]
			public const int AppCompatThemeTextAppearanceLargePopupMenu = (int) 40;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_textAppearanceListItem']"
			[Register ("AppCompatTheme_textAppearanceListItem")]
			public const int AppCompatThemeTextAppearanceListItem = (int) 76;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_textAppearanceListItemSmall']"
			[Register ("AppCompatTheme_textAppearanceListItemSmall")]
			public const int AppCompatThemeTextAppearanceListItemSmall = (int) 77;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_textAppearanceSearchResultSubtitle']"
			[Register ("AppCompatTheme_textAppearanceSearchResultSubtitle")]
			public const int AppCompatThemeTextAppearanceSearchResultSubtitle = (int) 66;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_textAppearanceSearchResultTitle']"
			[Register ("AppCompatTheme_textAppearanceSearchResultTitle")]
			public const int AppCompatThemeTextAppearanceSearchResultTitle = (int) 65;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_textAppearanceSmallPopupMenu']"
			[Register ("AppCompatTheme_textAppearanceSmallPopupMenu")]
			public const int AppCompatThemeTextAppearanceSmallPopupMenu = (int) 41;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_textColorAlertDialogListItem']"
			[Register ("AppCompatTheme_textColorAlertDialogListItem")]
			public const int AppCompatThemeTextColorAlertDialogListItem = (int) 95;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_textColorSearchUrl']"
			[Register ("AppCompatTheme_textColorSearchUrl")]
			public const int AppCompatThemeTextColorSearchUrl = (int) 67;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_toolbarNavigationButtonStyle']"
			[Register ("AppCompatTheme_toolbarNavigationButtonStyle")]
			public const int AppCompatThemeToolbarNavigationButtonStyle = (int) 59;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_toolbarStyle']"
			[Register ("AppCompatTheme_toolbarStyle")]
			public const int AppCompatThemeToolbarStyle = (int) 58;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_windowActionBar']"
			[Register ("AppCompatTheme_windowActionBar")]
			public const int AppCompatThemeWindowActionBar = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_windowActionBarOverlay']"
			[Register ("AppCompatTheme_windowActionBarOverlay")]
			public const int AppCompatThemeWindowActionBarOverlay = (int) 4;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_windowActionModeOverlay']"
			[Register ("AppCompatTheme_windowActionModeOverlay")]
			public const int AppCompatThemeWindowActionModeOverlay = (int) 5;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_windowFixedHeightMajor']"
			[Register ("AppCompatTheme_windowFixedHeightMajor")]
			public const int AppCompatThemeWindowFixedHeightMajor = (int) 9;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_windowFixedHeightMinor']"
			[Register ("AppCompatTheme_windowFixedHeightMinor")]
			public const int AppCompatThemeWindowFixedHeightMinor = (int) 7;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_windowFixedWidthMajor']"
			[Register ("AppCompatTheme_windowFixedWidthMajor")]
			public const int AppCompatThemeWindowFixedWidthMajor = (int) 6;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_windowFixedWidthMinor']"
			[Register ("AppCompatTheme_windowFixedWidthMinor")]
			public const int AppCompatThemeWindowFixedWidthMinor = (int) 8;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_windowMinWidthMajor']"
			[Register ("AppCompatTheme_windowMinWidthMajor")]
			public const int AppCompatThemeWindowMinWidthMajor = (int) 10;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_windowMinWidthMinor']"
			[Register ("AppCompatTheme_windowMinWidthMinor")]
			public const int AppCompatThemeWindowMinWidthMinor = (int) 11;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='AppCompatTheme_windowNoTitle']"
			[Register ("AppCompatTheme_windowNoTitle")]
			public const int AppCompatThemeWindowNoTitle = (int) 3;

			static IntPtr ButtonBarLayout_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='ButtonBarLayout']"
			[Register ("ButtonBarLayout")]
			public static IList<int> ButtonBarLayout {
				get {
					if (ButtonBarLayout_jfieldId == IntPtr.Zero)
						ButtonBarLayout_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ButtonBarLayout", "[I");
					return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, ButtonBarLayout_jfieldId), JniHandleOwnership.TransferLocalRef);
				}
			}

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='ButtonBarLayout_allowStacking']"
			[Register ("ButtonBarLayout_allowStacking")]
			public const int ButtonBarLayoutAllowStacking = (int) 0;

			static IntPtr CompoundButton_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='CompoundButton']"
			[Register ("CompoundButton")]
			public static IList<int> CompoundButton {
				get {
					if (CompoundButton_jfieldId == IntPtr.Zero)
						CompoundButton_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CompoundButton", "[I");
					return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, CompoundButton_jfieldId), JniHandleOwnership.TransferLocalRef);
				}
			}

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='CompoundButton_android_button']"
			[Register ("CompoundButton_android_button")]
			public const int CompoundButtonAndroidButton = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='CompoundButton_buttonTint']"
			[Register ("CompoundButton_buttonTint")]
			public const int CompoundButtonButtonTint = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='CompoundButton_buttonTintMode']"
			[Register ("CompoundButton_buttonTintMode")]
			public const int CompoundButtonButtonTintMode = (int) 2;

			static IntPtr DrawerArrowToggle_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='DrawerArrowToggle']"
			[Register ("DrawerArrowToggle")]
			public static IList<int> DrawerArrowToggle {
				get {
					if (DrawerArrowToggle_jfieldId == IntPtr.Zero)
						DrawerArrowToggle_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DrawerArrowToggle", "[I");
					return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, DrawerArrowToggle_jfieldId), JniHandleOwnership.TransferLocalRef);
				}
			}

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='DrawerArrowToggle_arrowHeadLength']"
			[Register ("DrawerArrowToggle_arrowHeadLength")]
			public const int DrawerArrowToggleArrowHeadLength = (int) 4;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='DrawerArrowToggle_arrowShaftLength']"
			[Register ("DrawerArrowToggle_arrowShaftLength")]
			public const int DrawerArrowToggleArrowShaftLength = (int) 5;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='DrawerArrowToggle_barLength']"
			[Register ("DrawerArrowToggle_barLength")]
			public const int DrawerArrowToggleBarLength = (int) 6;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='DrawerArrowToggle_color']"
			[Register ("DrawerArrowToggle_color")]
			public const int DrawerArrowToggleColor = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='DrawerArrowToggle_drawableSize']"
			[Register ("DrawerArrowToggle_drawableSize")]
			public const int DrawerArrowToggleDrawableSize = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='DrawerArrowToggle_gapBetweenBars']"
			[Register ("DrawerArrowToggle_gapBetweenBars")]
			public const int DrawerArrowToggleGapBetweenBars = (int) 3;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='DrawerArrowToggle_spinBars']"
			[Register ("DrawerArrowToggle_spinBars")]
			public const int DrawerArrowToggleSpinBars = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='DrawerArrowToggle_thickness']"
			[Register ("DrawerArrowToggle_thickness")]
			public const int DrawerArrowToggleThickness = (int) 7;

			static IntPtr LinearLayoutCompat_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='LinearLayoutCompat']"
			[Register ("LinearLayoutCompat")]
			public static IList<int> LinearLayoutCompat {
				get {
					if (LinearLayoutCompat_jfieldId == IntPtr.Zero)
						LinearLayoutCompat_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LinearLayoutCompat", "[I");
					return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, LinearLayoutCompat_jfieldId), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr LinearLayoutCompat_Layout_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='LinearLayoutCompat_Layout']"
			[Register ("LinearLayoutCompat_Layout")]
			public static IList<int> LinearLayoutCompatLayout {
				get {
					if (LinearLayoutCompat_Layout_jfieldId == IntPtr.Zero)
						LinearLayoutCompat_Layout_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LinearLayoutCompat_Layout", "[I");
					return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, LinearLayoutCompat_Layout_jfieldId), JniHandleOwnership.TransferLocalRef);
				}
			}

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='LinearLayoutCompat_Layout_android_layout_gravity']"
			[Register ("LinearLayoutCompat_Layout_android_layout_gravity")]
			public const int LinearLayoutCompatLayoutAndroidLayoutGravity = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='LinearLayoutCompat_Layout_android_layout_height']"
			[Register ("LinearLayoutCompat_Layout_android_layout_height")]
			public const int LinearLayoutCompatLayoutAndroidLayoutHeight = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='LinearLayoutCompat_Layout_android_layout_weight']"
			[Register ("LinearLayoutCompat_Layout_android_layout_weight")]
			public const int LinearLayoutCompatLayoutAndroidLayoutWeight = (int) 3;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='LinearLayoutCompat_Layout_android_layout_width']"
			[Register ("LinearLayoutCompat_Layout_android_layout_width")]
			public const int LinearLayoutCompatLayoutAndroidLayoutWidth = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='LinearLayoutCompat_android_baselineAligned']"
			[Register ("LinearLayoutCompat_android_baselineAligned")]
			public const int LinearLayoutCompatAndroidBaselineAligned = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='LinearLayoutCompat_android_baselineAlignedChildIndex']"
			[Register ("LinearLayoutCompat_android_baselineAlignedChildIndex")]
			public const int LinearLayoutCompatAndroidBaselineAlignedChildIndex = (int) 3;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='LinearLayoutCompat_android_gravity']"
			[Register ("LinearLayoutCompat_android_gravity")]
			public const int LinearLayoutCompatAndroidGravity = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='LinearLayoutCompat_android_orientation']"
			[Register ("LinearLayoutCompat_android_orientation")]
			public const int LinearLayoutCompatAndroidOrientation = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='LinearLayoutCompat_android_weightSum']"
			[Register ("LinearLayoutCompat_android_weightSum")]
			public const int LinearLayoutCompatAndroidWeightSum = (int) 4;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='LinearLayoutCompat_divider']"
			[Register ("LinearLayoutCompat_divider")]
			public const int LinearLayoutCompatDivider = (int) 5;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='LinearLayoutCompat_dividerPadding']"
			[Register ("LinearLayoutCompat_dividerPadding")]
			public const int LinearLayoutCompatDividerPadding = (int) 8;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='LinearLayoutCompat_measureWithLargestChild']"
			[Register ("LinearLayoutCompat_measureWithLargestChild")]
			public const int LinearLayoutCompatMeasureWithLargestChild = (int) 6;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='LinearLayoutCompat_showDividers']"
			[Register ("LinearLayoutCompat_showDividers")]
			public const int LinearLayoutCompatShowDividers = (int) 7;

			static IntPtr ListPopupWindow_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='ListPopupWindow']"
			[Register ("ListPopupWindow")]
			public static IList<int> ListPopupWindow {
				get {
					if (ListPopupWindow_jfieldId == IntPtr.Zero)
						ListPopupWindow_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ListPopupWindow", "[I");
					return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, ListPopupWindow_jfieldId), JniHandleOwnership.TransferLocalRef);
				}
			}

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='ListPopupWindow_android_dropDownHorizontalOffset']"
			[Register ("ListPopupWindow_android_dropDownHorizontalOffset")]
			public const int ListPopupWindowAndroidDropDownHorizontalOffset = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='ListPopupWindow_android_dropDownVerticalOffset']"
			[Register ("ListPopupWindow_android_dropDownVerticalOffset")]
			public const int ListPopupWindowAndroidDropDownVerticalOffset = (int) 1;

			static IntPtr MenuGroup_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='MenuGroup']"
			[Register ("MenuGroup")]
			public static IList<int> MenuGroup {
				get {
					if (MenuGroup_jfieldId == IntPtr.Zero)
						MenuGroup_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MenuGroup", "[I");
					return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, MenuGroup_jfieldId), JniHandleOwnership.TransferLocalRef);
				}
			}

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='MenuGroup_android_checkableBehavior']"
			[Register ("MenuGroup_android_checkableBehavior")]
			public const int MenuGroupAndroidCheckableBehavior = (int) 5;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='MenuGroup_android_enabled']"
			[Register ("MenuGroup_android_enabled")]
			public const int MenuGroupAndroidEnabled = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='MenuGroup_android_id']"
			[Register ("MenuGroup_android_id")]
			public const int MenuGroupAndroidId = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='MenuGroup_android_menuCategory']"
			[Register ("MenuGroup_android_menuCategory")]
			public const int MenuGroupAndroidMenuCategory = (int) 3;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='MenuGroup_android_orderInCategory']"
			[Register ("MenuGroup_android_orderInCategory")]
			public const int MenuGroupAndroidOrderInCategory = (int) 4;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='MenuGroup_android_visible']"
			[Register ("MenuGroup_android_visible")]
			public const int MenuGroupAndroidVisible = (int) 2;

			static IntPtr MenuItem_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='MenuItem']"
			[Register ("MenuItem")]
			public static IList<int> MenuItem {
				get {
					if (MenuItem_jfieldId == IntPtr.Zero)
						MenuItem_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MenuItem", "[I");
					return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, MenuItem_jfieldId), JniHandleOwnership.TransferLocalRef);
				}
			}

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='MenuItem_actionLayout']"
			[Register ("MenuItem_actionLayout")]
			public const int MenuItemActionLayout = (int) 14;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='MenuItem_actionProviderClass']"
			[Register ("MenuItem_actionProviderClass")]
			public const int MenuItemActionProviderClass = (int) 16;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='MenuItem_actionViewClass']"
			[Register ("MenuItem_actionViewClass")]
			public const int MenuItemActionViewClass = (int) 15;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='MenuItem_android_alphabeticShortcut']"
			[Register ("MenuItem_android_alphabeticShortcut")]
			public const int MenuItemAndroidAlphabeticShortcut = (int) 9;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='MenuItem_android_checkable']"
			[Register ("MenuItem_android_checkable")]
			public const int MenuItemAndroidCheckable = (int) 11;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='MenuItem_android_checked']"
			[Register ("MenuItem_android_checked")]
			public const int MenuItemAndroidChecked = (int) 3;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='MenuItem_android_enabled']"
			[Register ("MenuItem_android_enabled")]
			public const int MenuItemAndroidEnabled = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='MenuItem_android_icon']"
			[Register ("MenuItem_android_icon")]
			public const int MenuItemAndroidIcon = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='MenuItem_android_id']"
			[Register ("MenuItem_android_id")]
			public const int MenuItemAndroidId = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='MenuItem_android_menuCategory']"
			[Register ("MenuItem_android_menuCategory")]
			public const int MenuItemAndroidMenuCategory = (int) 5;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='MenuItem_android_numericShortcut']"
			[Register ("MenuItem_android_numericShortcut")]
			public const int MenuItemAndroidNumericShortcut = (int) 10;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='MenuItem_android_onClick']"
			[Register ("MenuItem_android_onClick")]
			public const int MenuItemAndroidOnClick = (int) 12;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='MenuItem_android_orderInCategory']"
			[Register ("MenuItem_android_orderInCategory")]
			public const int MenuItemAndroidOrderInCategory = (int) 6;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='MenuItem_android_title']"
			[Register ("MenuItem_android_title")]
			public const int MenuItemAndroidTitle = (int) 7;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='MenuItem_android_titleCondensed']"
			[Register ("MenuItem_android_titleCondensed")]
			public const int MenuItemAndroidTitleCondensed = (int) 8;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='MenuItem_android_visible']"
			[Register ("MenuItem_android_visible")]
			public const int MenuItemAndroidVisible = (int) 4;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='MenuItem_showAsAction']"
			[Register ("MenuItem_showAsAction")]
			public const int MenuItemShowAsAction = (int) 13;

			static IntPtr MenuView_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='MenuView']"
			[Register ("MenuView")]
			public static IList<int> MenuView {
				get {
					if (MenuView_jfieldId == IntPtr.Zero)
						MenuView_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MenuView", "[I");
					return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, MenuView_jfieldId), JniHandleOwnership.TransferLocalRef);
				}
			}

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='MenuView_android_headerBackground']"
			[Register ("MenuView_android_headerBackground")]
			public const int MenuViewAndroidHeaderBackground = (int) 4;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='MenuView_android_horizontalDivider']"
			[Register ("MenuView_android_horizontalDivider")]
			public const int MenuViewAndroidHorizontalDivider = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='MenuView_android_itemBackground']"
			[Register ("MenuView_android_itemBackground")]
			public const int MenuViewAndroidItemBackground = (int) 5;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='MenuView_android_itemIconDisabledAlpha']"
			[Register ("MenuView_android_itemIconDisabledAlpha")]
			public const int MenuViewAndroidItemIconDisabledAlpha = (int) 6;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='MenuView_android_itemTextAppearance']"
			[Register ("MenuView_android_itemTextAppearance")]
			public const int MenuViewAndroidItemTextAppearance = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='MenuView_android_verticalDivider']"
			[Register ("MenuView_android_verticalDivider")]
			public const int MenuViewAndroidVerticalDivider = (int) 3;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='MenuView_android_windowAnimationStyle']"
			[Register ("MenuView_android_windowAnimationStyle")]
			public const int MenuViewAndroidWindowAnimationStyle = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='MenuView_preserveIconSpacing']"
			[Register ("MenuView_preserveIconSpacing")]
			public const int MenuViewPreserveIconSpacing = (int) 7;

			static IntPtr PopupWindow_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='PopupWindow']"
			[Register ("PopupWindow")]
			public static IList<int> PopupWindow {
				get {
					if (PopupWindow_jfieldId == IntPtr.Zero)
						PopupWindow_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PopupWindow", "[I");
					return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, PopupWindow_jfieldId), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr PopupWindowBackgroundState_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='PopupWindowBackgroundState']"
			[Register ("PopupWindowBackgroundState")]
			public static IList<int> PopupWindowBackgroundState {
				get {
					if (PopupWindowBackgroundState_jfieldId == IntPtr.Zero)
						PopupWindowBackgroundState_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PopupWindowBackgroundState", "[I");
					return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, PopupWindowBackgroundState_jfieldId), JniHandleOwnership.TransferLocalRef);
				}
			}

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='PopupWindowBackgroundState_state_above_anchor']"
			[Register ("PopupWindowBackgroundState_state_above_anchor")]
			public const int PopupWindowBackgroundStateStateAboveAnchor = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='PopupWindow_android_popupBackground']"
			[Register ("PopupWindow_android_popupBackground")]
			public const int PopupWindowAndroidPopupBackground = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='PopupWindow_overlapAnchor']"
			[Register ("PopupWindow_overlapAnchor")]
			public const int PopupWindowOverlapAnchor = (int) 1;

			static IntPtr SearchView_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='SearchView']"
			[Register ("SearchView")]
			public static IList<int> SearchView {
				get {
					if (SearchView_jfieldId == IntPtr.Zero)
						SearchView_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SearchView", "[I");
					return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, SearchView_jfieldId), JniHandleOwnership.TransferLocalRef);
				}
			}

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='SearchView_android_focusable']"
			[Register ("SearchView_android_focusable")]
			public const int SearchViewAndroidFocusable = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='SearchView_android_imeOptions']"
			[Register ("SearchView_android_imeOptions")]
			public const int SearchViewAndroidImeOptions = (int) 3;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='SearchView_android_inputType']"
			[Register ("SearchView_android_inputType")]
			public const int SearchViewAndroidInputType = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='SearchView_android_maxWidth']"
			[Register ("SearchView_android_maxWidth")]
			public const int SearchViewAndroidMaxWidth = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='SearchView_closeIcon']"
			[Register ("SearchView_closeIcon")]
			public const int SearchViewCloseIcon = (int) 8;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='SearchView_commitIcon']"
			[Register ("SearchView_commitIcon")]
			public const int SearchViewCommitIcon = (int) 13;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='SearchView_defaultQueryHint']"
			[Register ("SearchView_defaultQueryHint")]
			public const int SearchViewDefaultQueryHint = (int) 7;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='SearchView_goIcon']"
			[Register ("SearchView_goIcon")]
			public const int SearchViewGoIcon = (int) 9;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='SearchView_iconifiedByDefault']"
			[Register ("SearchView_iconifiedByDefault")]
			public const int SearchViewIconifiedByDefault = (int) 5;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='SearchView_layout']"
			[Register ("SearchView_layout")]
			public const int SearchViewLayout = (int) 4;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='SearchView_queryBackground']"
			[Register ("SearchView_queryBackground")]
			public const int SearchViewQueryBackground = (int) 15;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='SearchView_queryHint']"
			[Register ("SearchView_queryHint")]
			public const int SearchViewQueryHint = (int) 6;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='SearchView_searchHintIcon']"
			[Register ("SearchView_searchHintIcon")]
			public const int SearchViewSearchHintIcon = (int) 11;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='SearchView_searchIcon']"
			[Register ("SearchView_searchIcon")]
			public const int SearchViewSearchIcon = (int) 10;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='SearchView_submitBackground']"
			[Register ("SearchView_submitBackground")]
			public const int SearchViewSubmitBackground = (int) 16;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='SearchView_suggestionRowLayout']"
			[Register ("SearchView_suggestionRowLayout")]
			public const int SearchViewSuggestionRowLayout = (int) 14;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='SearchView_voiceIcon']"
			[Register ("SearchView_voiceIcon")]
			public const int SearchViewVoiceIcon = (int) 12;

			static IntPtr Spinner_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='Spinner']"
			[Register ("Spinner")]
			public static IList<int> Spinner {
				get {
					if (Spinner_jfieldId == IntPtr.Zero)
						Spinner_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Spinner", "[I");
					return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, Spinner_jfieldId), JniHandleOwnership.TransferLocalRef);
				}
			}

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='Spinner_android_dropDownWidth']"
			[Register ("Spinner_android_dropDownWidth")]
			public const int SpinnerAndroidDropDownWidth = (int) 3;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='Spinner_android_entries']"
			[Register ("Spinner_android_entries")]
			public const int SpinnerAndroidEntries = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='Spinner_android_popupBackground']"
			[Register ("Spinner_android_popupBackground")]
			public const int SpinnerAndroidPopupBackground = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='Spinner_android_prompt']"
			[Register ("Spinner_android_prompt")]
			public const int SpinnerAndroidPrompt = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='Spinner_popupTheme']"
			[Register ("Spinner_popupTheme")]
			public const int SpinnerPopupTheme = (int) 4;

			static IntPtr SwitchCompat_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='SwitchCompat']"
			[Register ("SwitchCompat")]
			public static IList<int> SwitchCompat {
				get {
					if (SwitchCompat_jfieldId == IntPtr.Zero)
						SwitchCompat_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SwitchCompat", "[I");
					return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, SwitchCompat_jfieldId), JniHandleOwnership.TransferLocalRef);
				}
			}

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='SwitchCompat_android_textOff']"
			[Register ("SwitchCompat_android_textOff")]
			public const int SwitchCompatAndroidTextOff = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='SwitchCompat_android_textOn']"
			[Register ("SwitchCompat_android_textOn")]
			public const int SwitchCompatAndroidTextOn = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='SwitchCompat_android_thumb']"
			[Register ("SwitchCompat_android_thumb")]
			public const int SwitchCompatAndroidThumb = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='SwitchCompat_showText']"
			[Register ("SwitchCompat_showText")]
			public const int SwitchCompatShowText = (int) 9;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='SwitchCompat_splitTrack']"
			[Register ("SwitchCompat_splitTrack")]
			public const int SwitchCompatSplitTrack = (int) 8;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='SwitchCompat_switchMinWidth']"
			[Register ("SwitchCompat_switchMinWidth")]
			public const int SwitchCompatSwitchMinWidth = (int) 6;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='SwitchCompat_switchPadding']"
			[Register ("SwitchCompat_switchPadding")]
			public const int SwitchCompatSwitchPadding = (int) 7;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='SwitchCompat_switchTextAppearance']"
			[Register ("SwitchCompat_switchTextAppearance")]
			public const int SwitchCompatSwitchTextAppearance = (int) 5;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='SwitchCompat_thumbTextPadding']"
			[Register ("SwitchCompat_thumbTextPadding")]
			public const int SwitchCompatThumbTextPadding = (int) 4;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='SwitchCompat_track']"
			[Register ("SwitchCompat_track")]
			public const int SwitchCompatTrack = (int) 3;

			static IntPtr TextAppearance_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='TextAppearance']"
			[Register ("TextAppearance")]
			public static IList<int> TextAppearance {
				get {
					if (TextAppearance_jfieldId == IntPtr.Zero)
						TextAppearance_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TextAppearance", "[I");
					return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, TextAppearance_jfieldId), JniHandleOwnership.TransferLocalRef);
				}
			}

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='TextAppearance_android_shadowColor']"
			[Register ("TextAppearance_android_shadowColor")]
			public const int TextAppearanceAndroidShadowColor = (int) 4;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='TextAppearance_android_shadowDx']"
			[Register ("TextAppearance_android_shadowDx")]
			public const int TextAppearanceAndroidShadowDx = (int) 5;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='TextAppearance_android_shadowDy']"
			[Register ("TextAppearance_android_shadowDy")]
			public const int TextAppearanceAndroidShadowDy = (int) 6;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='TextAppearance_android_shadowRadius']"
			[Register ("TextAppearance_android_shadowRadius")]
			public const int TextAppearanceAndroidShadowRadius = (int) 7;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='TextAppearance_android_textColor']"
			[Register ("TextAppearance_android_textColor")]
			public const int TextAppearanceAndroidTextColor = (int) 3;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='TextAppearance_android_textSize']"
			[Register ("TextAppearance_android_textSize")]
			public const int TextAppearanceAndroidTextSize = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='TextAppearance_android_textStyle']"
			[Register ("TextAppearance_android_textStyle")]
			public const int TextAppearanceAndroidTextStyle = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='TextAppearance_android_typeface']"
			[Register ("TextAppearance_android_typeface")]
			public const int TextAppearanceAndroidTypeface = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='TextAppearance_textAllCaps']"
			[Register ("TextAppearance_textAllCaps")]
			public const int TextAppearanceTextAllCaps = (int) 8;

			static IntPtr Toolbar_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='Toolbar']"
			[Register ("Toolbar")]
			public static IList<int> Toolbar {
				get {
					if (Toolbar_jfieldId == IntPtr.Zero)
						Toolbar_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Toolbar", "[I");
					return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, Toolbar_jfieldId), JniHandleOwnership.TransferLocalRef);
				}
			}

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='Toolbar_android_gravity']"
			[Register ("Toolbar_android_gravity")]
			public const int ToolbarAndroidGravity = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='Toolbar_android_minHeight']"
			[Register ("Toolbar_android_minHeight")]
			public const int ToolbarAndroidMinHeight = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='Toolbar_collapseContentDescription']"
			[Register ("Toolbar_collapseContentDescription")]
			public const int ToolbarCollapseContentDescription = (int) 19;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='Toolbar_collapseIcon']"
			[Register ("Toolbar_collapseIcon")]
			public const int ToolbarCollapseIcon = (int) 18;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='Toolbar_contentInsetEnd']"
			[Register ("Toolbar_contentInsetEnd")]
			public const int ToolbarContentInsetEnd = (int) 6;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='Toolbar_contentInsetLeft']"
			[Register ("Toolbar_contentInsetLeft")]
			public const int ToolbarContentInsetLeft = (int) 7;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='Toolbar_contentInsetRight']"
			[Register ("Toolbar_contentInsetRight")]
			public const int ToolbarContentInsetRight = (int) 8;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='Toolbar_contentInsetStart']"
			[Register ("Toolbar_contentInsetStart")]
			public const int ToolbarContentInsetStart = (int) 5;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='Toolbar_logo']"
			[Register ("Toolbar_logo")]
			public const int ToolbarLogo = (int) 4;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='Toolbar_logoDescription']"
			[Register ("Toolbar_logoDescription")]
			public const int ToolbarLogoDescription = (int) 22;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='Toolbar_maxButtonHeight']"
			[Register ("Toolbar_maxButtonHeight")]
			public const int ToolbarMaxButtonHeight = (int) 17;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='Toolbar_navigationContentDescription']"
			[Register ("Toolbar_navigationContentDescription")]
			public const int ToolbarNavigationContentDescription = (int) 21;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='Toolbar_navigationIcon']"
			[Register ("Toolbar_navigationIcon")]
			public const int ToolbarNavigationIcon = (int) 20;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='Toolbar_popupTheme']"
			[Register ("Toolbar_popupTheme")]
			public const int ToolbarPopupTheme = (int) 9;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='Toolbar_subtitle']"
			[Register ("Toolbar_subtitle")]
			public const int ToolbarSubtitle = (int) 3;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='Toolbar_subtitleTextAppearance']"
			[Register ("Toolbar_subtitleTextAppearance")]
			public const int ToolbarSubtitleTextAppearance = (int) 11;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='Toolbar_subtitleTextColor']"
			[Register ("Toolbar_subtitleTextColor")]
			public const int ToolbarSubtitleTextColor = (int) 24;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='Toolbar_title']"
			[Register ("Toolbar_title")]
			public const int ToolbarTitle = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='Toolbar_titleMarginBottom']"
			[Register ("Toolbar_titleMarginBottom")]
			public const int ToolbarTitleMarginBottom = (int) 16;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='Toolbar_titleMarginEnd']"
			[Register ("Toolbar_titleMarginEnd")]
			public const int ToolbarTitleMarginEnd = (int) 14;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='Toolbar_titleMarginStart']"
			[Register ("Toolbar_titleMarginStart")]
			public const int ToolbarTitleMarginStart = (int) 13;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='Toolbar_titleMarginTop']"
			[Register ("Toolbar_titleMarginTop")]
			public const int ToolbarTitleMarginTop = (int) 15;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='Toolbar_titleMargins']"
			[Register ("Toolbar_titleMargins")]
			public const int ToolbarTitleMargins = (int) 12;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='Toolbar_titleTextAppearance']"
			[Register ("Toolbar_titleTextAppearance")]
			public const int ToolbarTitleTextAppearance = (int) 10;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='Toolbar_titleTextColor']"
			[Register ("Toolbar_titleTextColor")]
			public const int ToolbarTitleTextColor = (int) 23;

			static IntPtr View_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='View']"
			[Register ("View")]
			public static IList<int> View {
				get {
					if (View_jfieldId == IntPtr.Zero)
						View_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "View", "[I");
					return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, View_jfieldId), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr ViewBackgroundHelper_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='ViewBackgroundHelper']"
			[Register ("ViewBackgroundHelper")]
			public static IList<int> ViewBackgroundHelper {
				get {
					if (ViewBackgroundHelper_jfieldId == IntPtr.Zero)
						ViewBackgroundHelper_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ViewBackgroundHelper", "[I");
					return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, ViewBackgroundHelper_jfieldId), JniHandleOwnership.TransferLocalRef);
				}
			}

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='ViewBackgroundHelper_android_background']"
			[Register ("ViewBackgroundHelper_android_background")]
			public const int ViewBackgroundHelperAndroidBackground = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='ViewBackgroundHelper_backgroundTint']"
			[Register ("ViewBackgroundHelper_backgroundTint")]
			public const int ViewBackgroundHelperBackgroundTint = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='ViewBackgroundHelper_backgroundTintMode']"
			[Register ("ViewBackgroundHelper_backgroundTintMode")]
			public const int ViewBackgroundHelperBackgroundTintMode = (int) 2;

			static IntPtr ViewStubCompat_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='ViewStubCompat']"
			[Register ("ViewStubCompat")]
			public static IList<int> ViewStubCompat {
				get {
					if (ViewStubCompat_jfieldId == IntPtr.Zero)
						ViewStubCompat_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ViewStubCompat", "[I");
					return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, ViewStubCompat_jfieldId), JniHandleOwnership.TransferLocalRef);
				}
			}

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='ViewStubCompat_android_id']"
			[Register ("ViewStubCompat_android_id")]
			public const int ViewStubCompatAndroidId = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='ViewStubCompat_android_inflatedId']"
			[Register ("ViewStubCompat_android_inflatedId")]
			public const int ViewStubCompatAndroidInflatedId = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='ViewStubCompat_android_layout']"
			[Register ("ViewStubCompat_android_layout")]
			public const int ViewStubCompatAndroidLayout = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='View_android_focusable']"
			[Register ("View_android_focusable")]
			public const int ViewAndroidFocusable = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='View_android_theme']"
			[Register ("View_android_theme")]
			public const int ViewAndroidTheme = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='View_paddingEnd']"
			[Register ("View_paddingEnd")]
			public const int ViewPaddingEnd = (int) 3;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='View_paddingStart']"
			[Register ("View_paddingStart")]
			public const int ViewPaddingStart = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/field[@name='View_theme']"
			[Register ("View_theme")]
			public const int ViewTheme = (int) 4;
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("android/support/v7/appcompat/R$styleable", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Styleable); }
			}

			internal Styleable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R.styleable']/constructor[@name='R.styleable' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Styleable ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (((object) this).GetType () != typeof (Styleable)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
						return;
					}

					if (id_ctor == IntPtr.Zero)
						id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("android/support/v7/appcompat/R", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (R); }
		}

		internal R (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='android.support.v7.appcompat']/class[@name='R']/constructor[@name='R' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe R ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (R)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

	}
}
