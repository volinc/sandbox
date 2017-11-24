using System;
using System.Collections.Generic;
using Android.Runtime;

namespace RU.Tinkoff.Acquiring.Sdk.Requests {

	// Metadata.xml XPath class reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='GetStateRequestBuilder']"
	[global::Android.Runtime.Register ("ru/tinkoff/acquiring/sdk/requests/GetStateRequestBuilder", DoNotGenerateAcw=true)]
	public sealed partial class GetStateRequestBuilder : global::RU.Tinkoff.Acquiring.Sdk.Requests.AcquiringRequestBuilder {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("ru/tinkoff/acquiring/sdk/requests/GetStateRequestBuilder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GetStateRequestBuilder); }
		}

		internal GetStateRequestBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='GetStateRequestBuilder']/constructor[@name='GetStateRequestBuilder' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe GetStateRequestBuilder (string p0, string p1)
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
				if (((object) this).GetType () != typeof (GetStateRequestBuilder)) {
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
		protected unsafe global::RU.Tinkoff.Acquiring.Sdk.Requests.GetStateRequest Request {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='GetStateRequestBuilder']/method[@name='getRequest' and count(parameter)=0]"
			[Register ("getRequest", "()Lru/tinkoff/acquiring/sdk/requests/GetStateRequest;", "GetGetRequestHandler")]
			get {
				if (id_getRequest == IntPtr.Zero)
					id_getRequest = JNIEnv.GetMethodID (class_ref, "getRequest", "()Lru/tinkoff/acquiring/sdk/requests/GetStateRequest;");
				try {
					return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Requests.GetStateRequest> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRequest), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_setPaymentId_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='GetStateRequestBuilder']/method[@name='setPaymentId' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
		[Register ("setPaymentId", "(Ljava/lang/Long;)Lru/tinkoff/acquiring/sdk/requests/GetStateRequestBuilder;", "")]
		public unsafe global::RU.Tinkoff.Acquiring.Sdk.Requests.GetStateRequestBuilder SetPaymentId (global::Java.Lang.Long p0)
		{
			if (id_setPaymentId_Ljava_lang_Long_ == IntPtr.Zero)
				id_setPaymentId_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "setPaymentId", "(Ljava/lang/Long;)Lru/tinkoff/acquiring/sdk/requests/GetStateRequestBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::RU.Tinkoff.Acquiring.Sdk.Requests.GetStateRequestBuilder __ret = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Requests.GetStateRequestBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setPaymentId_Ljava_lang_Long_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_validate;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='GetStateRequestBuilder']/method[@name='validate' and count(parameter)=0]"
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
