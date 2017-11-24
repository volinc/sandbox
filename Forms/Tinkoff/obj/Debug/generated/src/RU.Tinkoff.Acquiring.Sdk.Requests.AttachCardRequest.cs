using System;
using System.Collections.Generic;
using Android.Runtime;

namespace RU.Tinkoff.Acquiring.Sdk.Requests {

	// Metadata.xml XPath class reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='AttachCardRequest']"
	[global::Android.Runtime.Register ("ru/tinkoff/acquiring/sdk/requests/AttachCardRequest", DoNotGenerateAcw=true)]
	public sealed partial class AttachCardRequest : global::RU.Tinkoff.Acquiring.Sdk.Requests.AcquiringRequest {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("ru/tinkoff/acquiring/sdk/requests/AttachCardRequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AttachCardRequest); }
		}

		internal AttachCardRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='AttachCardRequest']/constructor[@name='AttachCardRequest' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AttachCardRequest ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (AttachCardRequest)) {
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

		static IntPtr id_getCardData;
		public unsafe string CardData {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='AttachCardRequest']/method[@name='getCardData' and count(parameter)=0]"
			[Register ("getCardData", "()Ljava/lang/String;", "GetGetCardDataHandler")]
			get {
				if (id_getCardData == IntPtr.Zero)
					id_getCardData = JNIEnv.GetMethodID (class_ref, "getCardData", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCardData), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getData;
		public unsafe global::System.Collections.Generic.IDictionary<string, string> Data {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='AttachCardRequest']/method[@name='getData' and count(parameter)=0]"
			[Register ("getData", "()Ljava/util/Map;", "GetGetDataHandler")]
			get {
				if (id_getData == IntPtr.Zero)
					id_getData = JNIEnv.GetMethodID (class_ref, "getData", "()Ljava/util/Map;");
				try {
					return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getData), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getEmail;
		public unsafe string Email {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='AttachCardRequest']/method[@name='getEmail' and count(parameter)=0]"
			[Register ("getEmail", "()Ljava/lang/String;", "GetGetEmailHandler")]
			get {
				if (id_getEmail == IntPtr.Zero)
					id_getEmail = JNIEnv.GetMethodID (class_ref, "getEmail", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEmail), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getRequestKey;
		public unsafe string RequestKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='AttachCardRequest']/method[@name='getRequestKey' and count(parameter)=0]"
			[Register ("getRequestKey", "()Ljava/lang/String;", "GetGetRequestKeyHandler")]
			get {
				if (id_getRequestKey == IntPtr.Zero)
					id_getRequestKey = JNIEnv.GetMethodID (class_ref, "getRequestKey", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRequestKey), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
