using System;
using System.Collections.Generic;
using Android.Runtime;

namespace RU.Tinkoff.Acquiring.Sdk.Responses {

	// Metadata.xml XPath class reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.responses']/class[@name='AddCardResponse']"
	[global::Android.Runtime.Register ("ru/tinkoff/acquiring/sdk/responses/AddCardResponse", DoNotGenerateAcw=true)]
	public partial class AddCardResponse : global::RU.Tinkoff.Acquiring.Sdk.Responses.AcquiringResponse {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("ru/tinkoff/acquiring/sdk/responses/AddCardResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AddCardResponse); }
		}

		protected AddCardResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.responses']/class[@name='AddCardResponse']/constructor[@name='AddCardResponse' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AddCardResponse ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (AddCardResponse)) {
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

		static Delegate cb_getCustomerKey;
#pragma warning disable 0169
		static Delegate GetGetCustomerKeyHandler ()
		{
			if (cb_getCustomerKey == null)
				cb_getCustomerKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCustomerKey);
			return cb_getCustomerKey;
		}

		static IntPtr n_GetCustomerKey (IntPtr jnienv, IntPtr native__this)
		{
			global::RU.Tinkoff.Acquiring.Sdk.Responses.AddCardResponse __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Responses.AddCardResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CustomerKey);
		}
#pragma warning restore 0169

		static IntPtr id_getCustomerKey;
		public virtual unsafe string CustomerKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.responses']/class[@name='AddCardResponse']/method[@name='getCustomerKey' and count(parameter)=0]"
			[Register ("getCustomerKey", "()Ljava/lang/String;", "GetGetCustomerKeyHandler")]
			get {
				if (id_getCustomerKey == IntPtr.Zero)
					id_getCustomerKey = JNIEnv.GetMethodID (class_ref, "getCustomerKey", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCustomerKey), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCustomerKey", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRequestKey;
#pragma warning disable 0169
		static Delegate GetGetRequestKeyHandler ()
		{
			if (cb_getRequestKey == null)
				cb_getRequestKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRequestKey);
			return cb_getRequestKey;
		}

		static IntPtr n_GetRequestKey (IntPtr jnienv, IntPtr native__this)
		{
			global::RU.Tinkoff.Acquiring.Sdk.Responses.AddCardResponse __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Responses.AddCardResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RequestKey);
		}
#pragma warning restore 0169

		static IntPtr id_getRequestKey;
		public virtual unsafe string RequestKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.responses']/class[@name='AddCardResponse']/method[@name='getRequestKey' and count(parameter)=0]"
			[Register ("getRequestKey", "()Ljava/lang/String;", "GetGetRequestKeyHandler")]
			get {
				if (id_getRequestKey == IntPtr.Zero)
					id_getRequestKey = JNIEnv.GetMethodID (class_ref, "getRequestKey", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRequestKey), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRequestKey", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
