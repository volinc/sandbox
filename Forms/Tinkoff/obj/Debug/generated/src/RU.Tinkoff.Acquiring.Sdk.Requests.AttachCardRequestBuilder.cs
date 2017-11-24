using System;
using System.Collections.Generic;
using Android.Runtime;

namespace RU.Tinkoff.Acquiring.Sdk.Requests {

	// Metadata.xml XPath class reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='AttachCardRequestBuilder']"
	[global::Android.Runtime.Register ("ru/tinkoff/acquiring/sdk/requests/AttachCardRequestBuilder", DoNotGenerateAcw=true)]
	public sealed partial class AttachCardRequestBuilder : global::RU.Tinkoff.Acquiring.Sdk.Requests.AcquiringRequestBuilder {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("ru/tinkoff/acquiring/sdk/requests/AttachCardRequestBuilder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AttachCardRequestBuilder); }
		}

		internal AttachCardRequestBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='AttachCardRequestBuilder']/constructor[@name='AttachCardRequestBuilder' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe AttachCardRequestBuilder (string p0, string p1)
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
				if (((object) this).GetType () != typeof (AttachCardRequestBuilder)) {
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
		protected unsafe global::RU.Tinkoff.Acquiring.Sdk.Requests.AttachCardRequest Request {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='AttachCardRequestBuilder']/method[@name='getRequest' and count(parameter)=0]"
			[Register ("getRequest", "()Lru/tinkoff/acquiring/sdk/requests/AttachCardRequest;", "GetGetRequestHandler")]
			get {
				if (id_getRequest == IntPtr.Zero)
					id_getRequest = JNIEnv.GetMethodID (class_ref, "getRequest", "()Lru/tinkoff/acquiring/sdk/requests/AttachCardRequest;");
				try {
					return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Requests.AttachCardRequest> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRequest), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_addData_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='AttachCardRequestBuilder']/method[@name='addData' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("addData", "(Ljava/util/Map;)Lru/tinkoff/acquiring/sdk/requests/AttachCardRequestBuilder;", "")]
		public unsafe global::RU.Tinkoff.Acquiring.Sdk.Requests.AttachCardRequestBuilder AddData (global::System.Collections.Generic.IDictionary<string, string> p0)
		{
			if (id_addData_Ljava_util_Map_ == IntPtr.Zero)
				id_addData_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "addData", "(Ljava/util/Map;)Lru/tinkoff/acquiring/sdk/requests/AttachCardRequestBuilder;");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::RU.Tinkoff.Acquiring.Sdk.Requests.AttachCardRequestBuilder __ret = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Requests.AttachCardRequestBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addData_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_setCardData_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='AttachCardRequestBuilder']/method[@name='setCardData' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setCardData", "(Ljava/lang/String;)Lru/tinkoff/acquiring/sdk/requests/AttachCardRequestBuilder;", "")]
		public unsafe global::RU.Tinkoff.Acquiring.Sdk.Requests.AttachCardRequestBuilder SetCardData (string p0)
		{
			if (id_setCardData_Ljava_lang_String_ == IntPtr.Zero)
				id_setCardData_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCardData", "(Ljava/lang/String;)Lru/tinkoff/acquiring/sdk/requests/AttachCardRequestBuilder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::RU.Tinkoff.Acquiring.Sdk.Requests.AttachCardRequestBuilder __ret = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Requests.AttachCardRequestBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setCardData_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_setData_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='AttachCardRequestBuilder']/method[@name='setData' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("setData", "(Ljava/util/Map;)Lru/tinkoff/acquiring/sdk/requests/AttachCardRequestBuilder;", "")]
		public unsafe global::RU.Tinkoff.Acquiring.Sdk.Requests.AttachCardRequestBuilder SetData (global::System.Collections.Generic.IDictionary<string, string> p0)
		{
			if (id_setData_Ljava_util_Map_ == IntPtr.Zero)
				id_setData_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "setData", "(Ljava/util/Map;)Lru/tinkoff/acquiring/sdk/requests/AttachCardRequestBuilder;");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::RU.Tinkoff.Acquiring.Sdk.Requests.AttachCardRequestBuilder __ret = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Requests.AttachCardRequestBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setData_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_setEmail_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='AttachCardRequestBuilder']/method[@name='setEmail' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setEmail", "(Ljava/lang/String;)Lru/tinkoff/acquiring/sdk/requests/AttachCardRequestBuilder;", "")]
		public unsafe global::RU.Tinkoff.Acquiring.Sdk.Requests.AttachCardRequestBuilder SetEmail (string p0)
		{
			if (id_setEmail_Ljava_lang_String_ == IntPtr.Zero)
				id_setEmail_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setEmail", "(Ljava/lang/String;)Lru/tinkoff/acquiring/sdk/requests/AttachCardRequestBuilder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::RU.Tinkoff.Acquiring.Sdk.Requests.AttachCardRequestBuilder __ret = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Requests.AttachCardRequestBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setEmail_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_setRequestKey_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='AttachCardRequestBuilder']/method[@name='setRequestKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setRequestKey", "(Ljava/lang/String;)Lru/tinkoff/acquiring/sdk/requests/AttachCardRequestBuilder;", "")]
		public unsafe global::RU.Tinkoff.Acquiring.Sdk.Requests.AttachCardRequestBuilder SetRequestKey (string p0)
		{
			if (id_setRequestKey_Ljava_lang_String_ == IntPtr.Zero)
				id_setRequestKey_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setRequestKey", "(Ljava/lang/String;)Lru/tinkoff/acquiring/sdk/requests/AttachCardRequestBuilder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::RU.Tinkoff.Acquiring.Sdk.Requests.AttachCardRequestBuilder __ret = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Requests.AttachCardRequestBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setRequestKey_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_validate;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='AttachCardRequestBuilder']/method[@name='validate' and count(parameter)=0]"
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
