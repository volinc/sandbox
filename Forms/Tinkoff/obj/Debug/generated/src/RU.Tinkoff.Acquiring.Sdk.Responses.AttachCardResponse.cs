using System;
using System.Collections.Generic;
using Android.Runtime;

namespace RU.Tinkoff.Acquiring.Sdk.Responses {

	// Metadata.xml XPath class reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.responses']/class[@name='AttachCardResponse']"
	[global::Android.Runtime.Register ("ru/tinkoff/acquiring/sdk/responses/AttachCardResponse", DoNotGenerateAcw=true)]
	public partial class AttachCardResponse : global::RU.Tinkoff.Acquiring.Sdk.Responses.AcquiringResponse {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("ru/tinkoff/acquiring/sdk/responses/AttachCardResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AttachCardResponse); }
		}

		protected AttachCardResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.responses']/class[@name='AttachCardResponse']/constructor[@name='AttachCardResponse' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AttachCardResponse ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (AttachCardResponse)) {
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

		static Delegate cb_getAcsUrl;
#pragma warning disable 0169
		static Delegate GetGetAcsUrlHandler ()
		{
			if (cb_getAcsUrl == null)
				cb_getAcsUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAcsUrl);
			return cb_getAcsUrl;
		}

		static IntPtr n_GetAcsUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::RU.Tinkoff.Acquiring.Sdk.Responses.AttachCardResponse __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Responses.AttachCardResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AcsUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getAcsUrl;
		public virtual unsafe string AcsUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.responses']/class[@name='AttachCardResponse']/method[@name='getAcsUrl' and count(parameter)=0]"
			[Register ("getAcsUrl", "()Ljava/lang/String;", "GetGetAcsUrlHandler")]
			get {
				if (id_getAcsUrl == IntPtr.Zero)
					id_getAcsUrl = JNIEnv.GetMethodID (class_ref, "getAcsUrl", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAcsUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAcsUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCardId;
#pragma warning disable 0169
		static Delegate GetGetCardIdHandler ()
		{
			if (cb_getCardId == null)
				cb_getCardId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCardId);
			return cb_getCardId;
		}

		static IntPtr n_GetCardId (IntPtr jnienv, IntPtr native__this)
		{
			global::RU.Tinkoff.Acquiring.Sdk.Responses.AttachCardResponse __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Responses.AttachCardResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CardId);
		}
#pragma warning restore 0169

		static IntPtr id_getCardId;
		public virtual unsafe string CardId {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.responses']/class[@name='AttachCardResponse']/method[@name='getCardId' and count(parameter)=0]"
			[Register ("getCardId", "()Ljava/lang/String;", "GetGetCardIdHandler")]
			get {
				if (id_getCardId == IntPtr.Zero)
					id_getCardId = JNIEnv.GetMethodID (class_ref, "getCardId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCardId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCardId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCustomerKey;
#pragma warning disable 0169
		static Delegate GetGetCustomerKeyHandler ()
		{
			if (cb_getCustomerKey == null)
				cb_getCustomerKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCustomerKey);
			return cb_getCustomerKey;
		}

		static IntPtr n_GetCustomerKey (IntPtr jnienv, IntPtr native__this)
		{
			global::RU.Tinkoff.Acquiring.Sdk.Responses.AttachCardResponse __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Responses.AttachCardResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CustomerKey);
		}
#pragma warning restore 0169

		static IntPtr id_getCustomerKey;
		public virtual unsafe string CustomerKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.responses']/class[@name='AttachCardResponse']/method[@name='getCustomerKey' and count(parameter)=0]"
			[Register ("getCustomerKey", "()Ljava/lang/String;", "GetGetCustomerKeyHandler")]
			get {
				if (id_getCustomerKey == IntPtr.Zero)
					id_getCustomerKey = JNIEnv.GetMethodID (class_ref, "getCustomerKey", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCustomerKey), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCustomerKey", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMd;
#pragma warning disable 0169
		static Delegate GetGetMdHandler ()
		{
			if (cb_getMd == null)
				cb_getMd = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMd);
			return cb_getMd;
		}

		static IntPtr n_GetMd (IntPtr jnienv, IntPtr native__this)
		{
			global::RU.Tinkoff.Acquiring.Sdk.Responses.AttachCardResponse __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Responses.AttachCardResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Md);
		}
#pragma warning restore 0169

		static IntPtr id_getMd;
		public virtual unsafe string Md {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.responses']/class[@name='AttachCardResponse']/method[@name='getMd' and count(parameter)=0]"
			[Register ("getMd", "()Ljava/lang/String;", "GetGetMdHandler")]
			get {
				if (id_getMd == IntPtr.Zero)
					id_getMd = JNIEnv.GetMethodID (class_ref, "getMd", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMd), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMd", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPaReq;
#pragma warning disable 0169
		static Delegate GetGetPaReqHandler ()
		{
			if (cb_getPaReq == null)
				cb_getPaReq = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPaReq);
			return cb_getPaReq;
		}

		static IntPtr n_GetPaReq (IntPtr jnienv, IntPtr native__this)
		{
			global::RU.Tinkoff.Acquiring.Sdk.Responses.AttachCardResponse __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Responses.AttachCardResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PaReq);
		}
#pragma warning restore 0169

		static IntPtr id_getPaReq;
		public virtual unsafe string PaReq {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.responses']/class[@name='AttachCardResponse']/method[@name='getPaReq' and count(parameter)=0]"
			[Register ("getPaReq", "()Ljava/lang/String;", "GetGetPaReqHandler")]
			get {
				if (id_getPaReq == IntPtr.Zero)
					id_getPaReq = JNIEnv.GetMethodID (class_ref, "getPaReq", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPaReq), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPaReq", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRebillId;
#pragma warning disable 0169
		static Delegate GetGetRebillIdHandler ()
		{
			if (cb_getRebillId == null)
				cb_getRebillId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRebillId);
			return cb_getRebillId;
		}

		static IntPtr n_GetRebillId (IntPtr jnienv, IntPtr native__this)
		{
			global::RU.Tinkoff.Acquiring.Sdk.Responses.AttachCardResponse __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Responses.AttachCardResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RebillId);
		}
#pragma warning restore 0169

		static IntPtr id_getRebillId;
		public virtual unsafe string RebillId {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.responses']/class[@name='AttachCardResponse']/method[@name='getRebillId' and count(parameter)=0]"
			[Register ("getRebillId", "()Ljava/lang/String;", "GetGetRebillIdHandler")]
			get {
				if (id_getRebillId == IntPtr.Zero)
					id_getRebillId = JNIEnv.GetMethodID (class_ref, "getRebillId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRebillId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRebillId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRequestKey;
#pragma warning disable 0169
		static Delegate GetGetRequestKeyHandler ()
		{
			if (cb_getRequestKey == null)
				cb_getRequestKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRequestKey);
			return cb_getRequestKey;
		}

		static IntPtr n_GetRequestKey (IntPtr jnienv, IntPtr native__this)
		{
			global::RU.Tinkoff.Acquiring.Sdk.Responses.AttachCardResponse __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Responses.AttachCardResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RequestKey);
		}
#pragma warning restore 0169

		static IntPtr id_getRequestKey;
		public virtual unsafe string RequestKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.responses']/class[@name='AttachCardResponse']/method[@name='getRequestKey' and count(parameter)=0]"
			[Register ("getRequestKey", "()Ljava/lang/String;", "GetGetRequestKeyHandler")]
			get {
				if (id_getRequestKey == IntPtr.Zero)
					id_getRequestKey = JNIEnv.GetMethodID (class_ref, "getRequestKey", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRequestKey), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRequestKey", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getStatus;
#pragma warning disable 0169
		static Delegate GetGetStatusHandler ()
		{
			if (cb_getStatus == null)
				cb_getStatus = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStatus);
			return cb_getStatus;
		}

		static IntPtr n_GetStatus (IntPtr jnienv, IntPtr native__this)
		{
			global::RU.Tinkoff.Acquiring.Sdk.Responses.AttachCardResponse __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Responses.AttachCardResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Status);
		}
#pragma warning restore 0169

		static IntPtr id_getStatus;
		public virtual unsafe global::RU.Tinkoff.Acquiring.Sdk.PaymentStatus Status {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.responses']/class[@name='AttachCardResponse']/method[@name='getStatus' and count(parameter)=0]"
			[Register ("getStatus", "()Lru/tinkoff/acquiring/sdk/PaymentStatus;", "GetGetStatusHandler")]
			get {
				if (id_getStatus == IntPtr.Zero)
					id_getStatus = JNIEnv.GetMethodID (class_ref, "getStatus", "()Lru/tinkoff/acquiring/sdk/PaymentStatus;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.PaymentStatus> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getStatus), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.PaymentStatus> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStatus", "()Lru/tinkoff/acquiring/sdk/PaymentStatus;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getThreeDsData;
#pragma warning disable 0169
		static Delegate GetGetThreeDsDataHandler ()
		{
			if (cb_getThreeDsData == null)
				cb_getThreeDsData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetThreeDsData);
			return cb_getThreeDsData;
		}

		static IntPtr n_GetThreeDsData (IntPtr jnienv, IntPtr native__this)
		{
			global::RU.Tinkoff.Acquiring.Sdk.Responses.AttachCardResponse __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Responses.AttachCardResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ThreeDsData);
		}
#pragma warning restore 0169

		static IntPtr id_getThreeDsData;
		public virtual unsafe global::RU.Tinkoff.Acquiring.Sdk.ThreeDsData ThreeDsData {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.responses']/class[@name='AttachCardResponse']/method[@name='getThreeDsData' and count(parameter)=0]"
			[Register ("getThreeDsData", "()Lru/tinkoff/acquiring/sdk/ThreeDsData;", "GetGetThreeDsDataHandler")]
			get {
				if (id_getThreeDsData == IntPtr.Zero)
					id_getThreeDsData = JNIEnv.GetMethodID (class_ref, "getThreeDsData", "()Lru/tinkoff/acquiring/sdk/ThreeDsData;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.ThreeDsData> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getThreeDsData), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.ThreeDsData> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getThreeDsData", "()Lru/tinkoff/acquiring/sdk/ThreeDsData;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
