using System;
using System.Collections.Generic;
using Android.Runtime;

namespace RU.Tinkoff.Acquiring.Sdk.Responses {

	// Metadata.xml XPath class reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.responses']/class[@name='GetAddCardStateResponse']"
	[global::Android.Runtime.Register ("ru/tinkoff/acquiring/sdk/responses/GetAddCardStateResponse", DoNotGenerateAcw=true)]
	public partial class GetAddCardStateResponse : global::RU.Tinkoff.Acquiring.Sdk.Responses.AcquiringResponse {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("ru/tinkoff/acquiring/sdk/responses/GetAddCardStateResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GetAddCardStateResponse); }
		}

		protected GetAddCardStateResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.responses']/class[@name='GetAddCardStateResponse']/constructor[@name='GetAddCardStateResponse' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GetAddCardStateResponse ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (GetAddCardStateResponse)) {
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
			global::RU.Tinkoff.Acquiring.Sdk.Responses.GetAddCardStateResponse __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Responses.GetAddCardStateResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CardId);
		}
#pragma warning restore 0169

		static IntPtr id_getCardId;
		public virtual unsafe string CardId {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.responses']/class[@name='GetAddCardStateResponse']/method[@name='getCardId' and count(parameter)=0]"
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
			global::RU.Tinkoff.Acquiring.Sdk.Responses.GetAddCardStateResponse __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Responses.GetAddCardStateResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RebillId);
		}
#pragma warning restore 0169

		static IntPtr id_getRebillId;
		public virtual unsafe string RebillId {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.responses']/class[@name='GetAddCardStateResponse']/method[@name='getRebillId' and count(parameter)=0]"
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
			global::RU.Tinkoff.Acquiring.Sdk.Responses.GetAddCardStateResponse __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Responses.GetAddCardStateResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RequestKey);
		}
#pragma warning restore 0169

		static IntPtr id_getRequestKey;
		public virtual unsafe string RequestKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.responses']/class[@name='GetAddCardStateResponse']/method[@name='getRequestKey' and count(parameter)=0]"
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
			global::RU.Tinkoff.Acquiring.Sdk.Responses.GetAddCardStateResponse __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Responses.GetAddCardStateResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Status);
		}
#pragma warning restore 0169

		static IntPtr id_getStatus;
		public virtual unsafe global::RU.Tinkoff.Acquiring.Sdk.PaymentStatus Status {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.responses']/class[@name='GetAddCardStateResponse']/method[@name='getStatus' and count(parameter)=0]"
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

	}
}
