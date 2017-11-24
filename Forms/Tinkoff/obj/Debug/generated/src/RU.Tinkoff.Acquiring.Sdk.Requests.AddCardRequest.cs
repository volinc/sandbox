using System;
using System.Collections.Generic;
using Android.Runtime;

namespace RU.Tinkoff.Acquiring.Sdk.Requests {

	// Metadata.xml XPath class reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='AddCardRequest']"
	[global::Android.Runtime.Register ("ru/tinkoff/acquiring/sdk/requests/AddCardRequest", DoNotGenerateAcw=true)]
	public sealed partial class AddCardRequest : global::RU.Tinkoff.Acquiring.Sdk.Requests.AcquiringRequest {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("ru/tinkoff/acquiring/sdk/requests/AddCardRequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AddCardRequest); }
		}

		internal AddCardRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='AddCardRequest']/constructor[@name='AddCardRequest' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AddCardRequest ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (AddCardRequest)) {
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

		static IntPtr id_getCheckType;
		public unsafe string CheckType {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='AddCardRequest']/method[@name='getCheckType' and count(parameter)=0]"
			[Register ("getCheckType", "()Ljava/lang/String;", "GetGetCheckTypeHandler")]
			get {
				if (id_getCheckType == IntPtr.Zero)
					id_getCheckType = JNIEnv.GetMethodID (class_ref, "getCheckType", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCheckType), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getCustomerKey;
		public unsafe string CustomerKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='AddCardRequest']/method[@name='getCustomerKey' and count(parameter)=0]"
			[Register ("getCustomerKey", "()Ljava/lang/String;", "GetGetCustomerKeyHandler")]
			get {
				if (id_getCustomerKey == IntPtr.Zero)
					id_getCustomerKey = JNIEnv.GetMethodID (class_ref, "getCustomerKey", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCustomerKey), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
