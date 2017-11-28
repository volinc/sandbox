using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Taxys.Tinkoff {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.taxys.tinkoff']/class[@name='TinkoffAcquiring']"
	[global::Android.Runtime.Register ("com/taxys/tinkoff/TinkoffAcquiring", DoNotGenerateAcw=true)]
	public partial class TinkoffAcquiring : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/taxys/tinkoff/TinkoffAcquiring", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TinkoffAcquiring); }
		}

		protected TinkoffAcquiring (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.taxys.tinkoff']/class[@name='TinkoffAcquiring']/constructor[@name='TinkoffAcquiring' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TinkoffAcquiring ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (TinkoffAcquiring)) {
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

		static Delegate cb_InitPayment_Landroid_app_Activity_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Double_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetInitPayment_Landroid_app_Activity_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Double_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_InitPayment_Landroid_app_Activity_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Double_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_InitPayment_Landroid_app_Activity_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Double_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_InitPayment_Landroid_app_Activity_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Double_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_InitPayment_Landroid_app_Activity_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Double_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_InitPayment_Landroid_app_Activity_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Double_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5, IntPtr native_p6, IntPtr native_p7, IntPtr native_p8, IntPtr native_p9)
		{
			global::Com.Taxys.Tinkoff.TinkoffAcquiring __this = global::Java.Lang.Object.GetObject<global::Com.Taxys.Tinkoff.TinkoffAcquiring> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			string p5 = JNIEnv.GetString (native_p5, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Double p6 = global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (native_p6, JniHandleOwnership.DoNotTransfer);
			string p7 = JNIEnv.GetString (native_p7, JniHandleOwnership.DoNotTransfer);
			string p8 = JNIEnv.GetString (native_p8, JniHandleOwnership.DoNotTransfer);
			string p9 = JNIEnv.GetString (native_p9, JniHandleOwnership.DoNotTransfer);
			__this.InitPayment (p0, p1, p2, p3, p4, p5, p6, p7, p8, p9);
		}
#pragma warning restore 0169

		static IntPtr id_InitPayment_Landroid_app_Activity_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Double_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.taxys.tinkoff']/class[@name='TinkoffAcquiring']/method[@name='InitPayment' and count(parameter)=10 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='java.lang.Double'] and parameter[8][@type='java.lang.String'] and parameter[9][@type='java.lang.String'] and parameter[10][@type='java.lang.String']]"
		[Register ("InitPayment", "(Landroid/app/Activity;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Double;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetInitPayment_Landroid_app_Activity_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Double_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void InitPayment (global::Android.App.Activity p0, string p1, string p2, string p3, string p4, string p5, global::Java.Lang.Double p6, string p7, string p8, string p9)
		{
			if (id_InitPayment_Landroid_app_Activity_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Double_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_InitPayment_Landroid_app_Activity_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Double_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "InitPayment", "(Landroid/app/Activity;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Double;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			IntPtr native_p7 = JNIEnv.NewString (p7);
			IntPtr native_p8 = JNIEnv.NewString (p8);
			IntPtr native_p9 = JNIEnv.NewString (p9);
			try {
				JValue* __args = stackalloc JValue [10];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (native_p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (native_p7);
				__args [8] = new JValue (native_p8);
				__args [9] = new JValue (native_p9);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_InitPayment_Landroid_app_Activity_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Double_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "InitPayment", "(Landroid/app/Activity;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Double;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
				JNIEnv.DeleteLocalRef (native_p5);
				JNIEnv.DeleteLocalRef (native_p7);
				JNIEnv.DeleteLocalRef (native_p8);
				JNIEnv.DeleteLocalRef (native_p9);
			}
		}

	}
}
