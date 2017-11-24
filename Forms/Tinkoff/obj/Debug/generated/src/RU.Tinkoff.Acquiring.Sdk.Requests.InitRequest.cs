using System;
using System.Collections.Generic;
using Android.Runtime;

namespace RU.Tinkoff.Acquiring.Sdk.Requests {

	// Metadata.xml XPath class reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='InitRequest']"
	[global::Android.Runtime.Register ("ru/tinkoff/acquiring/sdk/requests/InitRequest", DoNotGenerateAcw=true)]
	public sealed partial class InitRequest : global::RU.Tinkoff.Acquiring.Sdk.Requests.AcquiringRequest {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("ru/tinkoff/acquiring/sdk/requests/InitRequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (InitRequest); }
		}

		internal InitRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='InitRequest']/constructor[@name='InitRequest' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe InitRequest ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (InitRequest)) {
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

		static IntPtr id_getAmount;
		public unsafe global::Java.Lang.Long Amount {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='InitRequest']/method[@name='getAmount' and count(parameter)=0]"
			[Register ("getAmount", "()Ljava/lang/Long;", "GetGetAmountHandler")]
			get {
				if (id_getAmount == IntPtr.Zero)
					id_getAmount = JNIEnv.GetMethodID (class_ref, "getAmount", "()Ljava/lang/Long;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAmount), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getCustomerKey;
		public unsafe string CustomerKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='InitRequest']/method[@name='getCustomerKey' and count(parameter)=0]"
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

		static IntPtr id_getData;
		public unsafe global::System.Collections.Generic.IDictionary<string, string> Data {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='InitRequest']/method[@name='getData' and count(parameter)=0]"
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

		static IntPtr id_getDescription;
		public unsafe string Description {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='InitRequest']/method[@name='getDescription' and count(parameter)=0]"
			[Register ("getDescription", "()Ljava/lang/String;", "GetGetDescriptionHandler")]
			get {
				if (id_getDescription == IntPtr.Zero)
					id_getDescription = JNIEnv.GetMethodID (class_ref, "getDescription", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDescription), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_isChargeFlag;
		public unsafe bool IsChargeFlag {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='InitRequest']/method[@name='isChargeFlag' and count(parameter)=0]"
			[Register ("isChargeFlag", "()Z", "GetIsChargeFlagHandler")]
			get {
				if (id_isChargeFlag == IntPtr.Zero)
					id_isChargeFlag = JNIEnv.GetMethodID (class_ref, "isChargeFlag", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isChargeFlag);
				} finally {
				}
			}
		}

		static IntPtr id_getLanguage;
		public unsafe string Language {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='InitRequest']/method[@name='getLanguage' and count(parameter)=0]"
			[Register ("getLanguage", "()Ljava/lang/String;", "GetGetLanguageHandler")]
			get {
				if (id_getLanguage == IntPtr.Zero)
					id_getLanguage = JNIEnv.GetMethodID (class_ref, "getLanguage", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLanguage), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getOrderId;
		public unsafe string OrderId {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='InitRequest']/method[@name='getOrderId' and count(parameter)=0]"
			[Register ("getOrderId", "()Ljava/lang/String;", "GetGetOrderIdHandler")]
			get {
				if (id_getOrderId == IntPtr.Zero)
					id_getOrderId = JNIEnv.GetMethodID (class_ref, "getOrderId", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOrderId), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getPayForm;
		public unsafe string PayForm {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='InitRequest']/method[@name='getPayForm' and count(parameter)=0]"
			[Register ("getPayForm", "()Ljava/lang/String;", "GetGetPayFormHandler")]
			get {
				if (id_getPayForm == IntPtr.Zero)
					id_getPayForm = JNIEnv.GetMethodID (class_ref, "getPayForm", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPayForm), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getPayType;
		public unsafe string PayType {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='InitRequest']/method[@name='getPayType' and count(parameter)=0]"
			[Register ("getPayType", "()Ljava/lang/String;", "GetGetPayTypeHandler")]
			get {
				if (id_getPayType == IntPtr.Zero)
					id_getPayType = JNIEnv.GetMethodID (class_ref, "getPayType", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPayType), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getReceipt;
		public unsafe global::RU.Tinkoff.Acquiring.Sdk.Receipt Receipt {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='InitRequest']/method[@name='getReceipt' and count(parameter)=0]"
			[Register ("getReceipt", "()Lru/tinkoff/acquiring/sdk/Receipt;", "GetGetReceiptHandler")]
			get {
				if (id_getReceipt == IntPtr.Zero)
					id_getReceipt = JNIEnv.GetMethodID (class_ref, "getReceipt", "()Lru/tinkoff/acquiring/sdk/Receipt;");
				try {
					return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Receipt> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getReceipt), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getRecurrent;
		public unsafe bool Recurrent {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='InitRequest']/method[@name='getRecurrent' and count(parameter)=0]"
			[Register ("getRecurrent", "()Z", "GetGetRecurrentHandler")]
			get {
				if (id_getRecurrent == IntPtr.Zero)
					id_getRecurrent = JNIEnv.GetMethodID (class_ref, "getRecurrent", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getRecurrent);
				} finally {
				}
			}
		}

	}
}
