using System;
using System.Collections.Generic;
using Android.Runtime;

namespace RU.Tinkoff.Acquiring.Sdk.Requests {

	// Metadata.xml XPath class reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='GetAddCardStateRequest']"
	[global::Android.Runtime.Register ("ru/tinkoff/acquiring/sdk/requests/GetAddCardStateRequest", DoNotGenerateAcw=true)]
	public partial class GetAddCardStateRequest : global::RU.Tinkoff.Acquiring.Sdk.Requests.AcquiringRequest {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("ru/tinkoff/acquiring/sdk/requests/GetAddCardStateRequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GetAddCardStateRequest); }
		}

		protected GetAddCardStateRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='GetAddCardStateRequest']/constructor[@name='GetAddCardStateRequest' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GetAddCardStateRequest ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (GetAddCardStateRequest)) {
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
			global::RU.Tinkoff.Acquiring.Sdk.Requests.GetAddCardStateRequest __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Requests.GetAddCardStateRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RequestKey);
		}
#pragma warning restore 0169

		static IntPtr id_getRequestKey;
		public virtual unsafe string RequestKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='GetAddCardStateRequest']/method[@name='getRequestKey' and count(parameter)=0]"
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
