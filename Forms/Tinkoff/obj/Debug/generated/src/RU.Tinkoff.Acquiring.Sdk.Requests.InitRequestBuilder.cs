using System;
using System.Collections.Generic;
using Android.Runtime;

namespace RU.Tinkoff.Acquiring.Sdk.Requests {

	// Metadata.xml XPath class reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='InitRequestBuilder']"
	[global::Android.Runtime.Register ("ru/tinkoff/acquiring/sdk/requests/InitRequestBuilder", DoNotGenerateAcw=true)]
	public sealed partial class InitRequestBuilder : global::RU.Tinkoff.Acquiring.Sdk.Requests.AcquiringRequestBuilder {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("ru/tinkoff/acquiring/sdk/requests/InitRequestBuilder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (InitRequestBuilder); }
		}

		internal InitRequestBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='InitRequestBuilder']/constructor[@name='InitRequestBuilder' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe InitRequestBuilder (string p0, string p1)
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
				if (((object) this).GetType () != typeof (InitRequestBuilder)) {
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
		protected unsafe global::RU.Tinkoff.Acquiring.Sdk.Requests.InitRequest Request {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='InitRequestBuilder']/method[@name='getRequest' and count(parameter)=0]"
			[Register ("getRequest", "()Lru/tinkoff/acquiring/sdk/requests/InitRequest;", "GetGetRequestHandler")]
			get {
				if (id_getRequest == IntPtr.Zero)
					id_getRequest = JNIEnv.GetMethodID (class_ref, "getRequest", "()Lru/tinkoff/acquiring/sdk/requests/InitRequest;");
				try {
					return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Requests.InitRequest> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRequest), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_setAmount_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='InitRequestBuilder']/method[@name='setAmount' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setAmount", "(J)Lru/tinkoff/acquiring/sdk/requests/InitRequestBuilder;", "")]
		public unsafe global::RU.Tinkoff.Acquiring.Sdk.Requests.InitRequestBuilder SetAmount (long p0)
		{
			if (id_setAmount_J == IntPtr.Zero)
				id_setAmount_J = JNIEnv.GetMethodID (class_ref, "setAmount", "(J)Lru/tinkoff/acquiring/sdk/requests/InitRequestBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Requests.InitRequestBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setAmount_J, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_setChargeFlag_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='InitRequestBuilder']/method[@name='setChargeFlag' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setChargeFlag", "(Z)Lru/tinkoff/acquiring/sdk/requests/InitRequestBuilder;", "")]
		public unsafe global::RU.Tinkoff.Acquiring.Sdk.Requests.InitRequestBuilder SetChargeFlag (bool p0)
		{
			if (id_setChargeFlag_Z == IntPtr.Zero)
				id_setChargeFlag_Z = JNIEnv.GetMethodID (class_ref, "setChargeFlag", "(Z)Lru/tinkoff/acquiring/sdk/requests/InitRequestBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Requests.InitRequestBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setChargeFlag_Z, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_setCustomerKey_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='InitRequestBuilder']/method[@name='setCustomerKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setCustomerKey", "(Ljava/lang/String;)Lru/tinkoff/acquiring/sdk/requests/InitRequestBuilder;", "")]
		public unsafe global::RU.Tinkoff.Acquiring.Sdk.Requests.InitRequestBuilder SetCustomerKey (string p0)
		{
			if (id_setCustomerKey_Ljava_lang_String_ == IntPtr.Zero)
				id_setCustomerKey_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCustomerKey", "(Ljava/lang/String;)Lru/tinkoff/acquiring/sdk/requests/InitRequestBuilder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::RU.Tinkoff.Acquiring.Sdk.Requests.InitRequestBuilder __ret = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Requests.InitRequestBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setCustomerKey_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_setData_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='InitRequestBuilder']/method[@name='setData' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("setData", "(Ljava/util/Map;)Lru/tinkoff/acquiring/sdk/requests/InitRequestBuilder;", "")]
		public unsafe global::RU.Tinkoff.Acquiring.Sdk.Requests.InitRequestBuilder SetData (global::System.Collections.Generic.IDictionary<string, string> p0)
		{
			if (id_setData_Ljava_util_Map_ == IntPtr.Zero)
				id_setData_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "setData", "(Ljava/util/Map;)Lru/tinkoff/acquiring/sdk/requests/InitRequestBuilder;");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::RU.Tinkoff.Acquiring.Sdk.Requests.InitRequestBuilder __ret = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Requests.InitRequestBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setData_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_setDescription_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='InitRequestBuilder']/method[@name='setDescription' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setDescription", "(Ljava/lang/String;)Lru/tinkoff/acquiring/sdk/requests/InitRequestBuilder;", "")]
		public unsafe global::RU.Tinkoff.Acquiring.Sdk.Requests.InitRequestBuilder SetDescription (string p0)
		{
			if (id_setDescription_Ljava_lang_String_ == IntPtr.Zero)
				id_setDescription_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDescription", "(Ljava/lang/String;)Lru/tinkoff/acquiring/sdk/requests/InitRequestBuilder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::RU.Tinkoff.Acquiring.Sdk.Requests.InitRequestBuilder __ret = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Requests.InitRequestBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setDescription_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_setLanguage_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='InitRequestBuilder']/method[@name='setLanguage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setLanguage", "(Ljava/lang/String;)Lru/tinkoff/acquiring/sdk/requests/InitRequestBuilder;", "")]
		public unsafe global::RU.Tinkoff.Acquiring.Sdk.Requests.InitRequestBuilder SetLanguage (string p0)
		{
			if (id_setLanguage_Ljava_lang_String_ == IntPtr.Zero)
				id_setLanguage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setLanguage", "(Ljava/lang/String;)Lru/tinkoff/acquiring/sdk/requests/InitRequestBuilder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::RU.Tinkoff.Acquiring.Sdk.Requests.InitRequestBuilder __ret = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Requests.InitRequestBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setLanguage_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_setOrderId_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='InitRequestBuilder']/method[@name='setOrderId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setOrderId", "(Ljava/lang/String;)Lru/tinkoff/acquiring/sdk/requests/InitRequestBuilder;", "")]
		public unsafe global::RU.Tinkoff.Acquiring.Sdk.Requests.InitRequestBuilder SetOrderId (string p0)
		{
			if (id_setOrderId_Ljava_lang_String_ == IntPtr.Zero)
				id_setOrderId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setOrderId", "(Ljava/lang/String;)Lru/tinkoff/acquiring/sdk/requests/InitRequestBuilder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::RU.Tinkoff.Acquiring.Sdk.Requests.InitRequestBuilder __ret = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Requests.InitRequestBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setOrderId_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_setPayForm_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='InitRequestBuilder']/method[@name='setPayForm' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setPayForm", "(Ljava/lang/String;)Lru/tinkoff/acquiring/sdk/requests/InitRequestBuilder;", "")]
		public unsafe global::RU.Tinkoff.Acquiring.Sdk.Requests.InitRequestBuilder SetPayForm (string p0)
		{
			if (id_setPayForm_Ljava_lang_String_ == IntPtr.Zero)
				id_setPayForm_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setPayForm", "(Ljava/lang/String;)Lru/tinkoff/acquiring/sdk/requests/InitRequestBuilder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::RU.Tinkoff.Acquiring.Sdk.Requests.InitRequestBuilder __ret = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Requests.InitRequestBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setPayForm_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_setPayType_Lru_tinkoff_acquiring_sdk_PayType_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='InitRequestBuilder']/method[@name='setPayType' and count(parameter)=1 and parameter[1][@type='ru.tinkoff.acquiring.sdk.PayType']]"
		[Register ("setPayType", "(Lru/tinkoff/acquiring/sdk/PayType;)Lru/tinkoff/acquiring/sdk/requests/InitRequestBuilder;", "")]
		public unsafe global::RU.Tinkoff.Acquiring.Sdk.Requests.InitRequestBuilder SetPayType (global::RU.Tinkoff.Acquiring.Sdk.PayType p0)
		{
			if (id_setPayType_Lru_tinkoff_acquiring_sdk_PayType_ == IntPtr.Zero)
				id_setPayType_Lru_tinkoff_acquiring_sdk_PayType_ = JNIEnv.GetMethodID (class_ref, "setPayType", "(Lru/tinkoff/acquiring/sdk/PayType;)Lru/tinkoff/acquiring/sdk/requests/InitRequestBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::RU.Tinkoff.Acquiring.Sdk.Requests.InitRequestBuilder __ret = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Requests.InitRequestBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setPayType_Lru_tinkoff_acquiring_sdk_PayType_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_setReceipt_Lru_tinkoff_acquiring_sdk_Receipt_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='InitRequestBuilder']/method[@name='setReceipt' and count(parameter)=1 and parameter[1][@type='ru.tinkoff.acquiring.sdk.Receipt']]"
		[Register ("setReceipt", "(Lru/tinkoff/acquiring/sdk/Receipt;)Lru/tinkoff/acquiring/sdk/requests/InitRequestBuilder;", "")]
		public unsafe global::RU.Tinkoff.Acquiring.Sdk.Requests.InitRequestBuilder SetReceipt (global::RU.Tinkoff.Acquiring.Sdk.Receipt p0)
		{
			if (id_setReceipt_Lru_tinkoff_acquiring_sdk_Receipt_ == IntPtr.Zero)
				id_setReceipt_Lru_tinkoff_acquiring_sdk_Receipt_ = JNIEnv.GetMethodID (class_ref, "setReceipt", "(Lru/tinkoff/acquiring/sdk/Receipt;)Lru/tinkoff/acquiring/sdk/requests/InitRequestBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::RU.Tinkoff.Acquiring.Sdk.Requests.InitRequestBuilder __ret = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Requests.InitRequestBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setReceipt_Lru_tinkoff_acquiring_sdk_Receipt_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_setRecurrent_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='InitRequestBuilder']/method[@name='setRecurrent' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setRecurrent", "(Z)Lru/tinkoff/acquiring/sdk/requests/InitRequestBuilder;", "")]
		public unsafe global::RU.Tinkoff.Acquiring.Sdk.Requests.InitRequestBuilder SetRecurrent (bool p0)
		{
			if (id_setRecurrent_Z == IntPtr.Zero)
				id_setRecurrent_Z = JNIEnv.GetMethodID (class_ref, "setRecurrent", "(Z)Lru/tinkoff/acquiring/sdk/requests/InitRequestBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Requests.InitRequestBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setRecurrent_Z, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_validate;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='InitRequestBuilder']/method[@name='validate' and count(parameter)=0]"
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
