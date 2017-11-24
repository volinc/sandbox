using System;
using System.Collections.Generic;
using Android.Runtime;

namespace RU.Tinkoff.Acquiring.Sdk.Requests {

	// Metadata.xml XPath class reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='GetAddCardStateRequestBuilder']"
	[global::Android.Runtime.Register ("ru/tinkoff/acquiring/sdk/requests/GetAddCardStateRequestBuilder", DoNotGenerateAcw=true)]
	public partial class GetAddCardStateRequestBuilder : global::RU.Tinkoff.Acquiring.Sdk.Requests.AcquiringRequestBuilder {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("ru/tinkoff/acquiring/sdk/requests/GetAddCardStateRequestBuilder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GetAddCardStateRequestBuilder); }
		}

		protected GetAddCardStateRequestBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='GetAddCardStateRequestBuilder']/constructor[@name='GetAddCardStateRequestBuilder' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe GetAddCardStateRequestBuilder (string p0, string p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				if (((object) this).GetType () != typeof (GetAddCardStateRequestBuilder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_getRequest;
#pragma warning disable 0169
		static Delegate GetGetRequestHandler ()
		{
			if (cb_getRequest == null)
				cb_getRequest = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRequest);
			return cb_getRequest;
		}

		static IntPtr n_GetRequest (IntPtr jnienv, IntPtr native__this)
		{
			global::RU.Tinkoff.Acquiring.Sdk.Requests.GetAddCardStateRequestBuilder __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Requests.GetAddCardStateRequestBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Request);
		}
#pragma warning restore 0169

		static IntPtr id_getRequest;
		protected virtual unsafe global::RU.Tinkoff.Acquiring.Sdk.Requests.GetAddCardStateRequest Request {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='GetAddCardStateRequestBuilder']/method[@name='getRequest' and count(parameter)=0]"
			[Register ("getRequest", "()Lru/tinkoff/acquiring/sdk/requests/GetAddCardStateRequest;", "GetGetRequestHandler")]
			get {
				if (id_getRequest == IntPtr.Zero)
					id_getRequest = JNIEnv.GetMethodID (class_ref, "getRequest", "()Lru/tinkoff/acquiring/sdk/requests/GetAddCardStateRequest;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Requests.GetAddCardStateRequest> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRequest), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Requests.GetAddCardStateRequest> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRequest", "()Lru/tinkoff/acquiring/sdk/requests/GetAddCardStateRequest;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_setRequestKey_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetRequestKey_Ljava_lang_String_Handler ()
		{
			if (cb_setRequestKey_Ljava_lang_String_ == null)
				cb_setRequestKey_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetRequestKey_Ljava_lang_String_);
			return cb_setRequestKey_Ljava_lang_String_;
		}

		static IntPtr n_SetRequestKey_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::RU.Tinkoff.Acquiring.Sdk.Requests.GetAddCardStateRequestBuilder __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Requests.GetAddCardStateRequestBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetRequestKey (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setRequestKey_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='GetAddCardStateRequestBuilder']/method[@name='setRequestKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setRequestKey", "(Ljava/lang/String;)Lru/tinkoff/acquiring/sdk/requests/GetAddCardStateRequestBuilder;", "GetSetRequestKey_Ljava_lang_String_Handler")]
		public virtual unsafe global::RU.Tinkoff.Acquiring.Sdk.Requests.GetAddCardStateRequestBuilder SetRequestKey (string p0)
		{
			if (id_setRequestKey_Ljava_lang_String_ == IntPtr.Zero)
				id_setRequestKey_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setRequestKey", "(Ljava/lang/String;)Lru/tinkoff/acquiring/sdk/requests/GetAddCardStateRequestBuilder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::RU.Tinkoff.Acquiring.Sdk.Requests.GetAddCardStateRequestBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Requests.GetAddCardStateRequestBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setRequestKey_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Requests.GetAddCardStateRequestBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRequestKey", "(Ljava/lang/String;)Lru/tinkoff/acquiring/sdk/requests/GetAddCardStateRequestBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_validate;
#pragma warning disable 0169
		static Delegate GetValidateHandler ()
		{
			if (cb_validate == null)
				cb_validate = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Validate);
			return cb_validate;
		}

		static void n_Validate (IntPtr jnienv, IntPtr native__this)
		{
			global::RU.Tinkoff.Acquiring.Sdk.Requests.GetAddCardStateRequestBuilder __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Requests.GetAddCardStateRequestBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Validate ();
		}
#pragma warning restore 0169

		static IntPtr id_validate;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='GetAddCardStateRequestBuilder']/method[@name='validate' and count(parameter)=0]"
		[Register ("validate", "()V", "GetValidateHandler")]
		protected override unsafe void Validate ()
		{
			if (id_validate == IntPtr.Zero)
				id_validate = JNIEnv.GetMethodID (class_ref, "validate", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_validate);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "validate", "()V"));
			} finally {
			}
		}

	}
}
