using System;
using System.Collections.Generic;
using Android.Runtime;

namespace RU.Tinkoff.Acquiring.Sdk.Requests {

	// Metadata.xml XPath class reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='SubmitRandomAmountRequestBuilder']"
	[global::Android.Runtime.Register ("ru/tinkoff/acquiring/sdk/requests/SubmitRandomAmountRequestBuilder", DoNotGenerateAcw=true)]
	public partial class SubmitRandomAmountRequestBuilder : global::RU.Tinkoff.Acquiring.Sdk.Requests.AcquiringRequestBuilder {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("ru/tinkoff/acquiring/sdk/requests/SubmitRandomAmountRequestBuilder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SubmitRandomAmountRequestBuilder); }
		}

		protected SubmitRandomAmountRequestBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='SubmitRandomAmountRequestBuilder']/constructor[@name='SubmitRandomAmountRequestBuilder' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe SubmitRandomAmountRequestBuilder (string p0, string p1)
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
				if (((object) this).GetType () != typeof (SubmitRandomAmountRequestBuilder)) {
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
			global::RU.Tinkoff.Acquiring.Sdk.Requests.SubmitRandomAmountRequestBuilder __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Requests.SubmitRandomAmountRequestBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Request);
		}
#pragma warning restore 0169

		static IntPtr id_getRequest;
		protected virtual unsafe global::RU.Tinkoff.Acquiring.Sdk.Requests.SubmitRandomAmountRequest Request {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='SubmitRandomAmountRequestBuilder']/method[@name='getRequest' and count(parameter)=0]"
			[Register ("getRequest", "()Lru/tinkoff/acquiring/sdk/requests/SubmitRandomAmountRequest;", "GetGetRequestHandler")]
			get {
				if (id_getRequest == IntPtr.Zero)
					id_getRequest = JNIEnv.GetMethodID (class_ref, "getRequest", "()Lru/tinkoff/acquiring/sdk/requests/SubmitRandomAmountRequest;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Requests.SubmitRandomAmountRequest> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRequest), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Requests.SubmitRandomAmountRequest> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRequest", "()Lru/tinkoff/acquiring/sdk/requests/SubmitRandomAmountRequest;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_setAmount_Ljava_lang_Long_;
#pragma warning disable 0169
		static Delegate GetSetAmount_Ljava_lang_Long_Handler ()
		{
			if (cb_setAmount_Ljava_lang_Long_ == null)
				cb_setAmount_Ljava_lang_Long_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetAmount_Ljava_lang_Long_);
			return cb_setAmount_Ljava_lang_Long_;
		}

		static IntPtr n_SetAmount_Ljava_lang_Long_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::RU.Tinkoff.Acquiring.Sdk.Requests.SubmitRandomAmountRequestBuilder __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Requests.SubmitRandomAmountRequestBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Long p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetAmount (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setAmount_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='SubmitRandomAmountRequestBuilder']/method[@name='setAmount' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
		[Register ("setAmount", "(Ljava/lang/Long;)Lru/tinkoff/acquiring/sdk/requests/SubmitRandomAmountRequestBuilder;", "GetSetAmount_Ljava_lang_Long_Handler")]
		public virtual unsafe global::RU.Tinkoff.Acquiring.Sdk.Requests.SubmitRandomAmountRequestBuilder SetAmount (global::Java.Lang.Long p0)
		{
			if (id_setAmount_Ljava_lang_Long_ == IntPtr.Zero)
				id_setAmount_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "setAmount", "(Ljava/lang/Long;)Lru/tinkoff/acquiring/sdk/requests/SubmitRandomAmountRequestBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::RU.Tinkoff.Acquiring.Sdk.Requests.SubmitRandomAmountRequestBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Requests.SubmitRandomAmountRequestBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setAmount_Ljava_lang_Long_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Requests.SubmitRandomAmountRequestBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAmount", "(Ljava/lang/Long;)Lru/tinkoff/acquiring/sdk/requests/SubmitRandomAmountRequestBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
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
			global::RU.Tinkoff.Acquiring.Sdk.Requests.SubmitRandomAmountRequestBuilder __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Requests.SubmitRandomAmountRequestBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetRequestKey (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setRequestKey_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='SubmitRandomAmountRequestBuilder']/method[@name='setRequestKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setRequestKey", "(Ljava/lang/String;)Lru/tinkoff/acquiring/sdk/requests/SubmitRandomAmountRequestBuilder;", "GetSetRequestKey_Ljava_lang_String_Handler")]
		public virtual unsafe global::RU.Tinkoff.Acquiring.Sdk.Requests.SubmitRandomAmountRequestBuilder SetRequestKey (string p0)
		{
			if (id_setRequestKey_Ljava_lang_String_ == IntPtr.Zero)
				id_setRequestKey_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setRequestKey", "(Ljava/lang/String;)Lru/tinkoff/acquiring/sdk/requests/SubmitRandomAmountRequestBuilder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::RU.Tinkoff.Acquiring.Sdk.Requests.SubmitRandomAmountRequestBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Requests.SubmitRandomAmountRequestBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setRequestKey_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Requests.SubmitRandomAmountRequestBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRequestKey", "(Ljava/lang/String;)Lru/tinkoff/acquiring/sdk/requests/SubmitRandomAmountRequestBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
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
			global::RU.Tinkoff.Acquiring.Sdk.Requests.SubmitRandomAmountRequestBuilder __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Requests.SubmitRandomAmountRequestBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Validate ();
		}
#pragma warning restore 0169

		static IntPtr id_validate;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='SubmitRandomAmountRequestBuilder']/method[@name='validate' and count(parameter)=0]"
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
