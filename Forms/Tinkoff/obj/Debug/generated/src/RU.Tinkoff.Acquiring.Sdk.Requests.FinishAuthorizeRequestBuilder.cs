using System;
using System.Collections.Generic;
using Android.Runtime;

namespace RU.Tinkoff.Acquiring.Sdk.Requests {

	// Metadata.xml XPath class reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='FinishAuthorizeRequestBuilder']"
	[global::Android.Runtime.Register ("ru/tinkoff/acquiring/sdk/requests/FinishAuthorizeRequestBuilder", DoNotGenerateAcw=true)]
	public sealed partial class FinishAuthorizeRequestBuilder : global::RU.Tinkoff.Acquiring.Sdk.Requests.AcquiringRequestBuilder {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("ru/tinkoff/acquiring/sdk/requests/FinishAuthorizeRequestBuilder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FinishAuthorizeRequestBuilder); }
		}

		internal FinishAuthorizeRequestBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='FinishAuthorizeRequestBuilder']/constructor[@name='FinishAuthorizeRequestBuilder' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe FinishAuthorizeRequestBuilder (string p0, string p1)
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
				if (((object) this).GetType () != typeof (FinishAuthorizeRequestBuilder)) {
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
		protected unsafe global::RU.Tinkoff.Acquiring.Sdk.Requests.FinishAuthorizeRequest Request {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='FinishAuthorizeRequestBuilder']/method[@name='getRequest' and count(parameter)=0]"
			[Register ("getRequest", "()Lru/tinkoff/acquiring/sdk/requests/FinishAuthorizeRequest;", "GetGetRequestHandler")]
			get {
				if (id_getRequest == IntPtr.Zero)
					id_getRequest = JNIEnv.GetMethodID (class_ref, "getRequest", "()Lru/tinkoff/acquiring/sdk/requests/FinishAuthorizeRequest;");
				try {
					return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Requests.FinishAuthorizeRequest> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRequest), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_setCardData_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='FinishAuthorizeRequestBuilder']/method[@name='setCardData' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setCardData", "(Ljava/lang/String;)Lru/tinkoff/acquiring/sdk/requests/FinishAuthorizeRequestBuilder;", "")]
		public unsafe global::RU.Tinkoff.Acquiring.Sdk.Requests.FinishAuthorizeRequestBuilder SetCardData (string p0)
		{
			if (id_setCardData_Ljava_lang_String_ == IntPtr.Zero)
				id_setCardData_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCardData", "(Ljava/lang/String;)Lru/tinkoff/acquiring/sdk/requests/FinishAuthorizeRequestBuilder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::RU.Tinkoff.Acquiring.Sdk.Requests.FinishAuthorizeRequestBuilder __ret = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Requests.FinishAuthorizeRequestBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setCardData_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_setEmail_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='FinishAuthorizeRequestBuilder']/method[@name='setEmail' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setEmail", "(Ljava/lang/String;)Lru/tinkoff/acquiring/sdk/requests/FinishAuthorizeRequestBuilder;", "")]
		public unsafe global::RU.Tinkoff.Acquiring.Sdk.Requests.FinishAuthorizeRequestBuilder SetEmail (string p0)
		{
			if (id_setEmail_Ljava_lang_String_ == IntPtr.Zero)
				id_setEmail_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setEmail", "(Ljava/lang/String;)Lru/tinkoff/acquiring/sdk/requests/FinishAuthorizeRequestBuilder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::RU.Tinkoff.Acquiring.Sdk.Requests.FinishAuthorizeRequestBuilder __ret = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Requests.FinishAuthorizeRequestBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setEmail_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_setPaymentId_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='FinishAuthorizeRequestBuilder']/method[@name='setPaymentId' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
		[Register ("setPaymentId", "(Ljava/lang/Long;)Lru/tinkoff/acquiring/sdk/requests/FinishAuthorizeRequestBuilder;", "")]
		public unsafe global::RU.Tinkoff.Acquiring.Sdk.Requests.FinishAuthorizeRequestBuilder SetPaymentId (global::Java.Lang.Long p0)
		{
			if (id_setPaymentId_Ljava_lang_Long_ == IntPtr.Zero)
				id_setPaymentId_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "setPaymentId", "(Ljava/lang/Long;)Lru/tinkoff/acquiring/sdk/requests/FinishAuthorizeRequestBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::RU.Tinkoff.Acquiring.Sdk.Requests.FinishAuthorizeRequestBuilder __ret = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Requests.FinishAuthorizeRequestBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setPaymentId_Ljava_lang_Long_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_setSendEmail_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='FinishAuthorizeRequestBuilder']/method[@name='setSendEmail' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setSendEmail", "(Z)Lru/tinkoff/acquiring/sdk/requests/FinishAuthorizeRequestBuilder;", "")]
		public unsafe global::RU.Tinkoff.Acquiring.Sdk.Requests.FinishAuthorizeRequestBuilder SetSendEmail (bool p0)
		{
			if (id_setSendEmail_Z == IntPtr.Zero)
				id_setSendEmail_Z = JNIEnv.GetMethodID (class_ref, "setSendEmail", "(Z)Lru/tinkoff/acquiring/sdk/requests/FinishAuthorizeRequestBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Requests.FinishAuthorizeRequestBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setSendEmail_Z, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_validate;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='FinishAuthorizeRequestBuilder']/method[@name='validate' and count(parameter)=0]"
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
