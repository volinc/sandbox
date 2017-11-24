using System;
using System.Collections.Generic;
using Android.Runtime;

namespace RU.Tinkoff.Acquiring.Sdk.Requests {

	// Metadata.xml XPath class reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='AddCardRequestBuilder']"
	[global::Android.Runtime.Register ("ru/tinkoff/acquiring/sdk/requests/AddCardRequestBuilder", DoNotGenerateAcw=true)]
	public sealed partial class AddCardRequestBuilder : global::RU.Tinkoff.Acquiring.Sdk.Requests.AcquiringRequestBuilder {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("ru/tinkoff/acquiring/sdk/requests/AddCardRequestBuilder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AddCardRequestBuilder); }
		}

		internal AddCardRequestBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='AddCardRequestBuilder']/constructor[@name='AddCardRequestBuilder' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe AddCardRequestBuilder (string p0, string p1)
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
				if (((object) this).GetType () != typeof (AddCardRequestBuilder)) {
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

		static IntPtr id_getRequest;
		protected unsafe global::RU.Tinkoff.Acquiring.Sdk.Requests.AddCardRequest Request {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='AddCardRequestBuilder']/method[@name='getRequest' and count(parameter)=0]"
			[Register ("getRequest", "()Lru/tinkoff/acquiring/sdk/requests/AddCardRequest;", "GetGetRequestHandler")]
			get {
				if (id_getRequest == IntPtr.Zero)
					id_getRequest = JNIEnv.GetMethodID (class_ref, "getRequest", "()Lru/tinkoff/acquiring/sdk/requests/AddCardRequest;");
				try {
					return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Requests.AddCardRequest> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRequest), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_setCheckType_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='AddCardRequestBuilder']/method[@name='setCheckType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setCheckType", "(Ljava/lang/String;)Lru/tinkoff/acquiring/sdk/requests/AddCardRequestBuilder;", "")]
		public unsafe global::RU.Tinkoff.Acquiring.Sdk.Requests.AddCardRequestBuilder SetCheckType (string p0)
		{
			if (id_setCheckType_Ljava_lang_String_ == IntPtr.Zero)
				id_setCheckType_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCheckType", "(Ljava/lang/String;)Lru/tinkoff/acquiring/sdk/requests/AddCardRequestBuilder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::RU.Tinkoff.Acquiring.Sdk.Requests.AddCardRequestBuilder __ret = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Requests.AddCardRequestBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setCheckType_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_setCheckType_Lru_tinkoff_acquiring_sdk_CheckType_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='AddCardRequestBuilder']/method[@name='setCheckType' and count(parameter)=1 and parameter[1][@type='ru.tinkoff.acquiring.sdk.CheckType']]"
		[Register ("setCheckType", "(Lru/tinkoff/acquiring/sdk/CheckType;)Lru/tinkoff/acquiring/sdk/requests/AddCardRequestBuilder;", "")]
		public unsafe global::RU.Tinkoff.Acquiring.Sdk.Requests.AddCardRequestBuilder SetCheckType (global::RU.Tinkoff.Acquiring.Sdk.CheckType p0)
		{
			if (id_setCheckType_Lru_tinkoff_acquiring_sdk_CheckType_ == IntPtr.Zero)
				id_setCheckType_Lru_tinkoff_acquiring_sdk_CheckType_ = JNIEnv.GetMethodID (class_ref, "setCheckType", "(Lru/tinkoff/acquiring/sdk/CheckType;)Lru/tinkoff/acquiring/sdk/requests/AddCardRequestBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::RU.Tinkoff.Acquiring.Sdk.Requests.AddCardRequestBuilder __ret = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Requests.AddCardRequestBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setCheckType_Lru_tinkoff_acquiring_sdk_CheckType_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_setCustomerKey_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='AddCardRequestBuilder']/method[@name='setCustomerKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setCustomerKey", "(Ljava/lang/String;)Lru/tinkoff/acquiring/sdk/requests/AddCardRequestBuilder;", "")]
		public unsafe global::RU.Tinkoff.Acquiring.Sdk.Requests.AddCardRequestBuilder SetCustomerKey (string p0)
		{
			if (id_setCustomerKey_Ljava_lang_String_ == IntPtr.Zero)
				id_setCustomerKey_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCustomerKey", "(Ljava/lang/String;)Lru/tinkoff/acquiring/sdk/requests/AddCardRequestBuilder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::RU.Tinkoff.Acquiring.Sdk.Requests.AddCardRequestBuilder __ret = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Requests.AddCardRequestBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setCustomerKey_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_validate;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='AddCardRequestBuilder']/method[@name='validate' and count(parameter)=0]"
		[Register ("validate", "()V", "")]
		protected override unsafe void Validate ()
		{
			if (id_validate == IntPtr.Zero)
				id_validate = JNIEnv.GetMethodID (class_ref, "validate", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_validate);
			} finally {
			}
		}

	}
}
