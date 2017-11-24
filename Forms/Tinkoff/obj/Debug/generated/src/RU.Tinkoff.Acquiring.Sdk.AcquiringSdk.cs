using System;
using System.Collections.Generic;
using Android.Runtime;

namespace RU.Tinkoff.Acquiring.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='AcquiringSdk']"
	[global::Android.Runtime.Register ("ru/tinkoff/acquiring/sdk/AcquiringSdk", DoNotGenerateAcw=true)]
	public partial class AcquiringSdk : global::RU.Tinkoff.Acquiring.Sdk.Journal {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("ru/tinkoff/acquiring/sdk/AcquiringSdk", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AcquiringSdk); }
		}

		protected AcquiringSdk (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Lru_tinkoff_acquiring_sdk_KeyCreator_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='AcquiringSdk']/constructor[@name='AcquiringSdk' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='ru.tinkoff.acquiring.sdk.KeyCreator']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Lru/tinkoff/acquiring/sdk/KeyCreator;)V", "")]
		public unsafe AcquiringSdk (string p0, string p1, global::RU.Tinkoff.Acquiring.Sdk.IKeyCreator p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (AcquiringSdk)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;Lru/tinkoff/acquiring/sdk/KeyCreator;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;Lru/tinkoff/acquiring/sdk/KeyCreator;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_Lru_tinkoff_acquiring_sdk_KeyCreator_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_Lru_tinkoff_acquiring_sdk_KeyCreator_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Lru/tinkoff/acquiring/sdk/KeyCreator;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Lru_tinkoff_acquiring_sdk_KeyCreator_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Lru_tinkoff_acquiring_sdk_KeyCreator_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='AcquiringSdk']/constructor[@name='AcquiringSdk' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe AcquiringSdk (string p0, string p1, string p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				if (((object) this).GetType () != typeof (AcquiringSdk)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_security_PublicKey_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='AcquiringSdk']/constructor[@name='AcquiringSdk' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.security.PublicKey']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/security/PublicKey;)V", "")]
		public unsafe AcquiringSdk (string p0, string p1, global::Java.Security.IPublicKey p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (AcquiringSdk)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;Ljava/security/PublicKey;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;Ljava/security/PublicKey;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_security_PublicKey_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_security_PublicKey_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/security/PublicKey;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_security_PublicKey_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_security_PublicKey_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_getPassword;
#pragma warning disable 0169
		static Delegate GetGetPasswordHandler ()
		{
			if (cb_getPassword == null)
				cb_getPassword = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPassword);
			return cb_getPassword;
		}

		static IntPtr n_GetPassword (IntPtr jnienv, IntPtr native__this)
		{
			global::RU.Tinkoff.Acquiring.Sdk.AcquiringSdk __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.AcquiringSdk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Password);
		}
#pragma warning restore 0169

		static IntPtr id_getPassword;
		public virtual unsafe string Password {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='AcquiringSdk']/method[@name='getPassword' and count(parameter)=0]"
			[Register ("getPassword", "()Ljava/lang/String;", "GetGetPasswordHandler")]
			get {
				if (id_getPassword == IntPtr.Zero)
					id_getPassword = JNIEnv.GetMethodID (class_ref, "getPassword", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPassword), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPassword", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPublicKey;
#pragma warning disable 0169
		static Delegate GetGetPublicKeyHandler ()
		{
			if (cb_getPublicKey == null)
				cb_getPublicKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPublicKey);
			return cb_getPublicKey;
		}

		static IntPtr n_GetPublicKey (IntPtr jnienv, IntPtr native__this)
		{
			global::RU.Tinkoff.Acquiring.Sdk.AcquiringSdk __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.AcquiringSdk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PublicKey);
		}
#pragma warning restore 0169

		static IntPtr id_getPublicKey;
		public virtual unsafe global::Java.Security.IPublicKey PublicKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='AcquiringSdk']/method[@name='getPublicKey' and count(parameter)=0]"
			[Register ("getPublicKey", "()Ljava/security/PublicKey;", "GetGetPublicKeyHandler")]
			get {
				if (id_getPublicKey == IntPtr.Zero)
					id_getPublicKey = JNIEnv.GetMethodID (class_ref, "getPublicKey", "()Ljava/security/PublicKey;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Security.IPublicKey> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPublicKey), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Security.IPublicKey> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPublicKey", "()Ljava/security/PublicKey;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTerminalKey;
#pragma warning disable 0169
		static Delegate GetGetTerminalKeyHandler ()
		{
			if (cb_getTerminalKey == null)
				cb_getTerminalKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTerminalKey);
			return cb_getTerminalKey;
		}

		static IntPtr n_GetTerminalKey (IntPtr jnienv, IntPtr native__this)
		{
			global::RU.Tinkoff.Acquiring.Sdk.AcquiringSdk __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.AcquiringSdk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TerminalKey);
		}
#pragma warning restore 0169

		static IntPtr id_getTerminalKey;
		public virtual unsafe string TerminalKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='AcquiringSdk']/method[@name='getTerminalKey' and count(parameter)=0]"
			[Register ("getTerminalKey", "()Ljava/lang/String;", "GetGetTerminalKeyHandler")]
			get {
				if (id_getTerminalKey == IntPtr.Zero)
					id_getTerminalKey = JNIEnv.GetMethodID (class_ref, "getTerminalKey", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTerminalKey), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTerminalKey", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_addCard_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddCard_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_addCard_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_addCard_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AddCard_Ljava_lang_String_Ljava_lang_String_);
			return cb_addCard_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_AddCard_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::RU.Tinkoff.Acquiring.Sdk.AcquiringSdk __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.AcquiringSdk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.AddCard (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addCard_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='AcquiringSdk']/method[@name='addCard' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("addCard", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "GetAddCard_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe string AddCard (string p0, string p1)
		{
			if (id_addCard_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_addCard_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addCard", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addCard_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addCard", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_addCard_Ljava_lang_String_Lru_tinkoff_acquiring_sdk_CheckType_;
#pragma warning disable 0169
		static Delegate GetAddCard_Ljava_lang_String_Lru_tinkoff_acquiring_sdk_CheckType_Handler ()
		{
			if (cb_addCard_Ljava_lang_String_Lru_tinkoff_acquiring_sdk_CheckType_ == null)
				cb_addCard_Ljava_lang_String_Lru_tinkoff_acquiring_sdk_CheckType_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AddCard_Ljava_lang_String_Lru_tinkoff_acquiring_sdk_CheckType_);
			return cb_addCard_Ljava_lang_String_Lru_tinkoff_acquiring_sdk_CheckType_;
		}

		static IntPtr n_AddCard_Ljava_lang_String_Lru_tinkoff_acquiring_sdk_CheckType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::RU.Tinkoff.Acquiring.Sdk.AcquiringSdk __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.AcquiringSdk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::RU.Tinkoff.Acquiring.Sdk.CheckType p1 = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.CheckType> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.AddCard (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addCard_Ljava_lang_String_Lru_tinkoff_acquiring_sdk_CheckType_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='AcquiringSdk']/method[@name='addCard' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='ru.tinkoff.acquiring.sdk.CheckType']]"
		[Register ("addCard", "(Ljava/lang/String;Lru/tinkoff/acquiring/sdk/CheckType;)Ljava/lang/String;", "GetAddCard_Ljava_lang_String_Lru_tinkoff_acquiring_sdk_CheckType_Handler")]
		public virtual unsafe string AddCard (string p0, global::RU.Tinkoff.Acquiring.Sdk.CheckType p1)
		{
			if (id_addCard_Ljava_lang_String_Lru_tinkoff_acquiring_sdk_CheckType_ == IntPtr.Zero)
				id_addCard_Ljava_lang_String_Lru_tinkoff_acquiring_sdk_CheckType_ = JNIEnv.GetMethodID (class_ref, "addCard", "(Ljava/lang/String;Lru/tinkoff/acquiring/sdk/CheckType;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addCard_Ljava_lang_String_Lru_tinkoff_acquiring_sdk_CheckType_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addCard", "(Ljava/lang/String;Lru/tinkoff/acquiring/sdk/CheckType;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_attachCard_Ljava_lang_String_Lru_tinkoff_acquiring_sdk_CardData_Ljava_lang_String_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetAttachCard_Ljava_lang_String_Lru_tinkoff_acquiring_sdk_CardData_Ljava_lang_String_Ljava_util_Map_Handler ()
		{
			if (cb_attachCard_Ljava_lang_String_Lru_tinkoff_acquiring_sdk_CardData_Ljava_lang_String_Ljava_util_Map_ == null)
				cb_attachCard_Ljava_lang_String_Lru_tinkoff_acquiring_sdk_CardData_Ljava_lang_String_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AttachCard_Ljava_lang_String_Lru_tinkoff_acquiring_sdk_CardData_Ljava_lang_String_Ljava_util_Map_);
			return cb_attachCard_Ljava_lang_String_Lru_tinkoff_acquiring_sdk_CardData_Ljava_lang_String_Ljava_util_Map_;
		}

		static IntPtr n_AttachCard_Ljava_lang_String_Lru_tinkoff_acquiring_sdk_CardData_Ljava_lang_String_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::RU.Tinkoff.Acquiring.Sdk.AcquiringSdk __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.AcquiringSdk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::RU.Tinkoff.Acquiring.Sdk.CardData p1 = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.CardData> (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p3, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AttachCard (p0, p1, p2, p3));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_attachCard_Ljava_lang_String_Lru_tinkoff_acquiring_sdk_CardData_Ljava_lang_String_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='AcquiringSdk']/method[@name='attachCard' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='ru.tinkoff.acquiring.sdk.CardData'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("attachCard", "(Ljava/lang/String;Lru/tinkoff/acquiring/sdk/CardData;Ljava/lang/String;Ljava/util/Map;)Lru/tinkoff/acquiring/sdk/responses/AttachCardResponse;", "GetAttachCard_Ljava_lang_String_Lru_tinkoff_acquiring_sdk_CardData_Ljava_lang_String_Ljava_util_Map_Handler")]
		public virtual unsafe global::RU.Tinkoff.Acquiring.Sdk.Responses.AttachCardResponse AttachCard (string p0, global::RU.Tinkoff.Acquiring.Sdk.CardData p1, string p2, global::System.Collections.Generic.IDictionary<string, string> p3)
		{
			if (id_attachCard_Ljava_lang_String_Lru_tinkoff_acquiring_sdk_CardData_Ljava_lang_String_Ljava_util_Map_ == IntPtr.Zero)
				id_attachCard_Ljava_lang_String_Lru_tinkoff_acquiring_sdk_CardData_Ljava_lang_String_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "attachCard", "(Ljava/lang/String;Lru/tinkoff/acquiring/sdk/CardData;Ljava/lang/String;Ljava/util/Map;)Lru/tinkoff/acquiring/sdk/responses/AttachCardResponse;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);

				global::RU.Tinkoff.Acquiring.Sdk.Responses.AttachCardResponse __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Responses.AttachCardResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_attachCard_Ljava_lang_String_Lru_tinkoff_acquiring_sdk_CardData_Ljava_lang_String_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Responses.AttachCardResponse> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "attachCard", "(Ljava/lang/String;Lru/tinkoff/acquiring/sdk/CardData;Ljava/lang/String;Ljava/util/Map;)Lru/tinkoff/acquiring/sdk/responses/AttachCardResponse;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_charge_JLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCharge_JLjava_lang_String_Handler ()
		{
			if (cb_charge_JLjava_lang_String_ == null)
				cb_charge_JLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, IntPtr>) n_Charge_JLjava_lang_String_);
			return cb_charge_JLjava_lang_String_;
		}

		static IntPtr n_Charge_JLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			global::RU.Tinkoff.Acquiring.Sdk.AcquiringSdk __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.AcquiringSdk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Charge (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_charge_JLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='AcquiringSdk']/method[@name='charge' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.lang.String']]"
		[Register ("charge", "(JLjava/lang/String;)Lru/tinkoff/acquiring/sdk/PaymentInfo;", "GetCharge_JLjava_lang_String_Handler")]
		public virtual unsafe global::RU.Tinkoff.Acquiring.Sdk.PaymentInfo Charge (long p0, string p1)
		{
			if (id_charge_JLjava_lang_String_ == IntPtr.Zero)
				id_charge_JLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "charge", "(JLjava/lang/String;)Lru/tinkoff/acquiring/sdk/PaymentInfo;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				global::RU.Tinkoff.Acquiring.Sdk.PaymentInfo __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.PaymentInfo> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_charge_JLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.PaymentInfo> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "charge", "(JLjava/lang/String;)Lru/tinkoff/acquiring/sdk/PaymentInfo;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_finishAuthorize_JLru_tinkoff_acquiring_sdk_CardData_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetFinishAuthorize_JLru_tinkoff_acquiring_sdk_CardData_Ljava_lang_String_Handler ()
		{
			if (cb_finishAuthorize_JLru_tinkoff_acquiring_sdk_CardData_Ljava_lang_String_ == null)
				cb_finishAuthorize_JLru_tinkoff_acquiring_sdk_CardData_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, IntPtr, IntPtr>) n_FinishAuthorize_JLru_tinkoff_acquiring_sdk_CardData_Ljava_lang_String_);
			return cb_finishAuthorize_JLru_tinkoff_acquiring_sdk_CardData_Ljava_lang_String_;
		}

		static IntPtr n_FinishAuthorize_JLru_tinkoff_acquiring_sdk_CardData_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::RU.Tinkoff.Acquiring.Sdk.AcquiringSdk __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.AcquiringSdk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::RU.Tinkoff.Acquiring.Sdk.CardData p1 = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.CardData> (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.FinishAuthorize (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_finishAuthorize_JLru_tinkoff_acquiring_sdk_CardData_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='AcquiringSdk']/method[@name='finishAuthorize' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='ru.tinkoff.acquiring.sdk.CardData'] and parameter[3][@type='java.lang.String']]"
		[Register ("finishAuthorize", "(JLru/tinkoff/acquiring/sdk/CardData;Ljava/lang/String;)Lru/tinkoff/acquiring/sdk/ThreeDsData;", "GetFinishAuthorize_JLru_tinkoff_acquiring_sdk_CardData_Ljava_lang_String_Handler")]
		public virtual unsafe global::RU.Tinkoff.Acquiring.Sdk.ThreeDsData FinishAuthorize (long p0, global::RU.Tinkoff.Acquiring.Sdk.CardData p1, string p2)
		{
			if (id_finishAuthorize_JLru_tinkoff_acquiring_sdk_CardData_Ljava_lang_String_ == IntPtr.Zero)
				id_finishAuthorize_JLru_tinkoff_acquiring_sdk_CardData_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "finishAuthorize", "(JLru/tinkoff/acquiring/sdk/CardData;Ljava/lang/String;)Lru/tinkoff/acquiring/sdk/ThreeDsData;");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);

				global::RU.Tinkoff.Acquiring.Sdk.ThreeDsData __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.ThreeDsData> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_finishAuthorize_JLru_tinkoff_acquiring_sdk_CardData_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.ThreeDsData> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "finishAuthorize", "(JLru/tinkoff/acquiring/sdk/CardData;Ljava/lang/String;)Lru/tinkoff/acquiring/sdk/ThreeDsData;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_getAddCardState_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetAddCardState_Ljava_lang_String_Handler ()
		{
			if (cb_getAddCardState_Ljava_lang_String_ == null)
				cb_getAddCardState_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetAddCardState_Ljava_lang_String_);
			return cb_getAddCardState_Ljava_lang_String_;
		}

		static IntPtr n_GetAddCardState_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::RU.Tinkoff.Acquiring.Sdk.AcquiringSdk __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.AcquiringSdk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetAddCardState (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getAddCardState_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='AcquiringSdk']/method[@name='getAddCardState' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getAddCardState", "(Ljava/lang/String;)Lru/tinkoff/acquiring/sdk/responses/GetAddCardStateResponse;", "GetGetAddCardState_Ljava_lang_String_Handler")]
		public virtual unsafe global::RU.Tinkoff.Acquiring.Sdk.Responses.GetAddCardStateResponse GetAddCardState (string p0)
		{
			if (id_getAddCardState_Ljava_lang_String_ == IntPtr.Zero)
				id_getAddCardState_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getAddCardState", "(Ljava/lang/String;)Lru/tinkoff/acquiring/sdk/responses/GetAddCardStateResponse;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::RU.Tinkoff.Acquiring.Sdk.Responses.GetAddCardStateResponse __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Responses.GetAddCardStateResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAddCardState_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Responses.GetAddCardStateResponse> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAddCardState", "(Ljava/lang/String;)Lru/tinkoff/acquiring/sdk/responses/GetAddCardStateResponse;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getCardList_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetCardList_Ljava_lang_String_Handler ()
		{
			if (cb_getCardList_Ljava_lang_String_ == null)
				cb_getCardList_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetCardList_Ljava_lang_String_);
			return cb_getCardList_Ljava_lang_String_;
		}

		static IntPtr n_GetCardList_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::RU.Tinkoff.Acquiring.Sdk.AcquiringSdk __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.AcquiringSdk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.GetCardList (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getCardList_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='AcquiringSdk']/method[@name='getCardList' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getCardList", "(Ljava/lang/String;)[Lru/tinkoff/acquiring/sdk/Card;", "GetGetCardList_Ljava_lang_String_Handler")]
		public virtual unsafe global::RU.Tinkoff.Acquiring.Sdk.Card[] GetCardList (string p0)
		{
			if (id_getCardList_Ljava_lang_String_ == IntPtr.Zero)
				id_getCardList_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getCardList", "(Ljava/lang/String;)[Lru/tinkoff/acquiring/sdk/Card;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::RU.Tinkoff.Acquiring.Sdk.Card[] __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = (global::RU.Tinkoff.Acquiring.Sdk.Card[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCardList_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (global::RU.Tinkoff.Acquiring.Sdk.Card));
				else
					__ret = (global::RU.Tinkoff.Acquiring.Sdk.Card[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCardList", "(Ljava/lang/String;)[Lru/tinkoff/acquiring/sdk/Card;"), __args), JniHandleOwnership.TransferLocalRef, typeof (global::RU.Tinkoff.Acquiring.Sdk.Card));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getState_J;
#pragma warning disable 0169
		static Delegate GetGetState_JHandler ()
		{
			if (cb_getState_J == null)
				cb_getState_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_GetState_J);
			return cb_getState_J;
		}

		static IntPtr n_GetState_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::RU.Tinkoff.Acquiring.Sdk.AcquiringSdk __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.AcquiringSdk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetState (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getState_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='AcquiringSdk']/method[@name='getState' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("getState", "(J)Lru/tinkoff/acquiring/sdk/PaymentStatus;", "GetGetState_JHandler")]
		public virtual unsafe global::RU.Tinkoff.Acquiring.Sdk.PaymentStatus GetState (long p0)
		{
			if (id_getState_J == IntPtr.Zero)
				id_getState_J = JNIEnv.GetMethodID (class_ref, "getState", "(J)Lru/tinkoff/acquiring/sdk/PaymentStatus;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.PaymentStatus> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getState_J, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.PaymentStatus> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getState", "(J)Lru/tinkoff/acquiring/sdk/PaymentStatus;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getUrl_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetUrl_Ljava_lang_String_Handler ()
		{
			if (cb_getUrl_Ljava_lang_String_ == null)
				cb_getUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetUrl_Ljava_lang_String_);
			return cb_getUrl_Ljava_lang_String_;
		}

		static IntPtr n_GetUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::RU.Tinkoff.Acquiring.Sdk.AcquiringSdk __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.AcquiringSdk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetUrl (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getUrl_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='AcquiringSdk']/method[@name='getUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getUrl", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetUrl_Ljava_lang_String_Handler")]
		public virtual unsafe string GetUrl (string p0)
		{
			if (id_getUrl_Ljava_lang_String_ == IntPtr.Zero)
				id_getUrl_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getUrl", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUrl_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUrl", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_init_Lru_tinkoff_acquiring_sdk_requests_InitRequestBuilder_;
#pragma warning disable 0169
		static Delegate GetInit_Lru_tinkoff_acquiring_sdk_requests_InitRequestBuilder_Handler ()
		{
			if (cb_init_Lru_tinkoff_acquiring_sdk_requests_InitRequestBuilder_ == null)
				cb_init_Lru_tinkoff_acquiring_sdk_requests_InitRequestBuilder_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Init_Lru_tinkoff_acquiring_sdk_requests_InitRequestBuilder_);
			return cb_init_Lru_tinkoff_acquiring_sdk_requests_InitRequestBuilder_;
		}

		static IntPtr n_Init_Lru_tinkoff_acquiring_sdk_requests_InitRequestBuilder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::RU.Tinkoff.Acquiring.Sdk.AcquiringSdk __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.AcquiringSdk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::RU.Tinkoff.Acquiring.Sdk.Requests.InitRequestBuilder p0 = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Requests.InitRequestBuilder> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Init (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_init_Lru_tinkoff_acquiring_sdk_requests_InitRequestBuilder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='AcquiringSdk']/method[@name='init' and count(parameter)=1 and parameter[1][@type='ru.tinkoff.acquiring.sdk.requests.InitRequestBuilder']]"
		[Register ("init", "(Lru/tinkoff/acquiring/sdk/requests/InitRequestBuilder;)Ljava/lang/Long;", "GetInit_Lru_tinkoff_acquiring_sdk_requests_InitRequestBuilder_Handler")]
		public virtual unsafe global::Java.Lang.Long Init (global::RU.Tinkoff.Acquiring.Sdk.Requests.InitRequestBuilder p0)
		{
			if (id_init_Lru_tinkoff_acquiring_sdk_requests_InitRequestBuilder_ == IntPtr.Zero)
				id_init_Lru_tinkoff_acquiring_sdk_requests_InitRequestBuilder_ = JNIEnv.GetMethodID (class_ref, "init", "(Lru/tinkoff/acquiring/sdk/requests/InitRequestBuilder;)Ljava/lang/Long;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Java.Lang.Long __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_init_Lru_tinkoff_acquiring_sdk_requests_InitRequestBuilder_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "init", "(Lru/tinkoff/acquiring/sdk/requests/InitRequestBuilder;)Ljava/lang/Long;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_removeCard_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemoveCard_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_removeCard_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_removeCard_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_RemoveCard_Ljava_lang_String_Ljava_lang_String_);
			return cb_removeCard_Ljava_lang_String_Ljava_lang_String_;
		}

		static bool n_RemoveCard_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::RU.Tinkoff.Acquiring.Sdk.AcquiringSdk __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.AcquiringSdk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RemoveCard (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_removeCard_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='AcquiringSdk']/method[@name='removeCard' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("removeCard", "(Ljava/lang/String;Ljava/lang/String;)Z", "GetRemoveCard_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe bool RemoveCard (string p0, string p1)
		{
			if (id_removeCard_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_removeCard_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "removeCard", "(Ljava/lang/String;Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_removeCard_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeCard", "(Ljava/lang/String;Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_submitRandomAmount_Ljava_lang_String_Ljava_lang_Long_;
#pragma warning disable 0169
		static Delegate GetSubmitRandomAmount_Ljava_lang_String_Ljava_lang_Long_Handler ()
		{
			if (cb_submitRandomAmount_Ljava_lang_String_Ljava_lang_Long_ == null)
				cb_submitRandomAmount_Ljava_lang_String_Ljava_lang_Long_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SubmitRandomAmount_Ljava_lang_String_Ljava_lang_Long_);
			return cb_submitRandomAmount_Ljava_lang_String_Ljava_lang_Long_;
		}

		static IntPtr n_SubmitRandomAmount_Ljava_lang_String_Ljava_lang_Long_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::RU.Tinkoff.Acquiring.Sdk.AcquiringSdk __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.AcquiringSdk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Long p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.SubmitRandomAmount (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_submitRandomAmount_Ljava_lang_String_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='AcquiringSdk']/method[@name='submitRandomAmount' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Long']]"
		[Register ("submitRandomAmount", "(Ljava/lang/String;Ljava/lang/Long;)Ljava/lang/String;", "GetSubmitRandomAmount_Ljava_lang_String_Ljava_lang_Long_Handler")]
		public virtual unsafe string SubmitRandomAmount (string p0, global::Java.Lang.Long p1)
		{
			if (id_submitRandomAmount_Ljava_lang_String_Ljava_lang_Long_ == IntPtr.Zero)
				id_submitRandomAmount_Ljava_lang_String_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "submitRandomAmount", "(Ljava/lang/String;Ljava/lang/Long;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_submitRandomAmount_Ljava_lang_String_Ljava_lang_Long_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "submitRandomAmount", "(Ljava/lang/String;Ljava/lang/Long;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
