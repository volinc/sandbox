using System;
using System.Collections.Generic;
using Android.Runtime;

namespace RU.Tinkoff.Acquiring.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='Receipt']"
	[global::Android.Runtime.Register ("ru/tinkoff/acquiring/sdk/Receipt", DoNotGenerateAcw=true)]
	public partial class Receipt : global::Java.Lang.Object, global::Java.IO.ISerializable {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("ru/tinkoff/acquiring/sdk/Receipt", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Receipt); }
		}

		protected Receipt (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_arrayLru_tinkoff_acquiring_sdk_Item_Ljava_lang_String_Lru_tinkoff_acquiring_sdk_Taxation_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='Receipt']/constructor[@name='Receipt' and count(parameter)=3 and parameter[1][@type='ru.tinkoff.acquiring.sdk.Item[]'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='ru.tinkoff.acquiring.sdk.Taxation']]"
		[Register (".ctor", "([Lru/tinkoff/acquiring/sdk/Item;Ljava/lang/String;Lru/tinkoff/acquiring/sdk/Taxation;)V", "")]
		public unsafe Receipt (global::RU.Tinkoff.Acquiring.Sdk.Item[] p0, string p1, global::RU.Tinkoff.Acquiring.Sdk.Taxation p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (Receipt)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "([Lru/tinkoff/acquiring/sdk/Item;Ljava/lang/String;Lru/tinkoff/acquiring/sdk/Taxation;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "([Lru/tinkoff/acquiring/sdk/Item;Ljava/lang/String;Lru/tinkoff/acquiring/sdk/Taxation;)V", __args);
					return;
				}

				if (id_ctor_arrayLru_tinkoff_acquiring_sdk_Item_Ljava_lang_String_Lru_tinkoff_acquiring_sdk_Taxation_ == IntPtr.Zero)
					id_ctor_arrayLru_tinkoff_acquiring_sdk_Item_Ljava_lang_String_Lru_tinkoff_acquiring_sdk_Taxation_ = JNIEnv.GetMethodID (class_ref, "<init>", "([Lru/tinkoff/acquiring/sdk/Item;Ljava/lang/String;Lru/tinkoff/acquiring/sdk/Taxation;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayLru_tinkoff_acquiring_sdk_Item_Ljava_lang_String_Lru_tinkoff_acquiring_sdk_Taxation_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_arrayLru_tinkoff_acquiring_sdk_Item_Ljava_lang_String_Lru_tinkoff_acquiring_sdk_Taxation_, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_getEmail;
#pragma warning disable 0169
		static Delegate GetGetEmailHandler ()
		{
			if (cb_getEmail == null)
				cb_getEmail = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEmail);
			return cb_getEmail;
		}

		static IntPtr n_GetEmail (IntPtr jnienv, IntPtr native__this)
		{
			global::RU.Tinkoff.Acquiring.Sdk.Receipt __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Receipt> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Email);
		}
#pragma warning restore 0169

		static IntPtr id_getEmail;
		public virtual unsafe string Email {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='Receipt']/method[@name='getEmail' and count(parameter)=0]"
			[Register ("getEmail", "()Ljava/lang/String;", "GetGetEmailHandler")]
			get {
				if (id_getEmail == IntPtr.Zero)
					id_getEmail = JNIEnv.GetMethodID (class_ref, "getEmail", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEmail), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEmail", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPhone;
#pragma warning disable 0169
		static Delegate GetGetPhoneHandler ()
		{
			if (cb_getPhone == null)
				cb_getPhone = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPhone);
			return cb_getPhone;
		}

		static IntPtr n_GetPhone (IntPtr jnienv, IntPtr native__this)
		{
			global::RU.Tinkoff.Acquiring.Sdk.Receipt __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Receipt> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Phone);
		}
#pragma warning restore 0169

		static Delegate cb_setPhone_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetPhone_Ljava_lang_String_Handler ()
		{
			if (cb_setPhone_Ljava_lang_String_ == null)
				cb_setPhone_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPhone_Ljava_lang_String_);
			return cb_setPhone_Ljava_lang_String_;
		}

		static void n_SetPhone_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::RU.Tinkoff.Acquiring.Sdk.Receipt __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Receipt> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Phone = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getPhone;
		static IntPtr id_setPhone_Ljava_lang_String_;
		public virtual unsafe string Phone {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='Receipt']/method[@name='getPhone' and count(parameter)=0]"
			[Register ("getPhone", "()Ljava/lang/String;", "GetGetPhoneHandler")]
			get {
				if (id_getPhone == IntPtr.Zero)
					id_getPhone = JNIEnv.GetMethodID (class_ref, "getPhone", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPhone), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPhone", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='Receipt']/method[@name='setPhone' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setPhone", "(Ljava/lang/String;)V", "GetSetPhone_Ljava_lang_String_Handler")]
			set {
				if (id_setPhone_Ljava_lang_String_ == IntPtr.Zero)
					id_setPhone_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setPhone", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPhone_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPhone", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getTaxation;
#pragma warning disable 0169
		static Delegate GetGetTaxationHandler ()
		{
			if (cb_getTaxation == null)
				cb_getTaxation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTaxation);
			return cb_getTaxation;
		}

		static IntPtr n_GetTaxation (IntPtr jnienv, IntPtr native__this)
		{
			global::RU.Tinkoff.Acquiring.Sdk.Receipt __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Receipt> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Taxation);
		}
#pragma warning restore 0169

		static IntPtr id_getTaxation;
		public virtual unsafe global::RU.Tinkoff.Acquiring.Sdk.Taxation Taxation {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='Receipt']/method[@name='getTaxation' and count(parameter)=0]"
			[Register ("getTaxation", "()Lru/tinkoff/acquiring/sdk/Taxation;", "GetGetTaxationHandler")]
			get {
				if (id_getTaxation == IntPtr.Zero)
					id_getTaxation = JNIEnv.GetMethodID (class_ref, "getTaxation", "()Lru/tinkoff/acquiring/sdk/Taxation;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Taxation> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTaxation), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Taxation> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTaxation", "()Lru/tinkoff/acquiring/sdk/Taxation;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getItems;
#pragma warning disable 0169
		static Delegate GetGetItemsHandler ()
		{
			if (cb_getItems == null)
				cb_getItems = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetItems);
			return cb_getItems;
		}

		static IntPtr n_GetItems (IntPtr jnienv, IntPtr native__this)
		{
			global::RU.Tinkoff.Acquiring.Sdk.Receipt __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Receipt> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetItems ());
		}
#pragma warning restore 0169

		static IntPtr id_getItems;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='Receipt']/method[@name='getItems' and count(parameter)=0]"
		[Register ("getItems", "()[Lru/tinkoff/acquiring/sdk/Item;", "GetGetItemsHandler")]
		public virtual unsafe global::RU.Tinkoff.Acquiring.Sdk.Item[] GetItems ()
		{
			if (id_getItems == IntPtr.Zero)
				id_getItems = JNIEnv.GetMethodID (class_ref, "getItems", "()[Lru/tinkoff/acquiring/sdk/Item;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (global::RU.Tinkoff.Acquiring.Sdk.Item[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getItems), JniHandleOwnership.TransferLocalRef, typeof (global::RU.Tinkoff.Acquiring.Sdk.Item));
				else
					return (global::RU.Tinkoff.Acquiring.Sdk.Item[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getItems", "()[Lru/tinkoff/acquiring/sdk/Item;")), JniHandleOwnership.TransferLocalRef, typeof (global::RU.Tinkoff.Acquiring.Sdk.Item));
			} finally {
			}
		}

	}
}
