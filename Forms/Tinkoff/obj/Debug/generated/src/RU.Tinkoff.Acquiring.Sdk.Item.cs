using System;
using System.Collections.Generic;
using Android.Runtime;

namespace RU.Tinkoff.Acquiring.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='Item']"
	[global::Android.Runtime.Register ("ru/tinkoff/acquiring/sdk/Item", DoNotGenerateAcw=true)]
	public partial class Item : global::Java.Lang.Object, global::Java.IO.ISerializable {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("ru/tinkoff/acquiring/sdk/Item", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Item); }
		}

		protected Item (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_Long_DLjava_lang_Long_Lru_tinkoff_acquiring_sdk_Tax_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='Item']/constructor[@name='Item' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Long'] and parameter[3][@type='double'] and parameter[4][@type='java.lang.Long'] and parameter[5][@type='ru.tinkoff.acquiring.sdk.Tax']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/Long;DLjava/lang/Long;Lru/tinkoff/acquiring/sdk/Tax;)V", "")]
		public unsafe Item (string p0, global::Java.Lang.Long p1, double p2, global::Java.Lang.Long p3, global::RU.Tinkoff.Acquiring.Sdk.Tax p4)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				if (((object) this).GetType () != typeof (Item)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/Long;DLjava/lang/Long;Lru/tinkoff/acquiring/sdk/Tax;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/Long;DLjava/lang/Long;Lru/tinkoff/acquiring/sdk/Tax;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_Long_DLjava_lang_Long_Lru_tinkoff_acquiring_sdk_Tax_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_Long_DLjava_lang_Long_Lru_tinkoff_acquiring_sdk_Tax_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/Long;DLjava/lang/Long;Lru/tinkoff/acquiring/sdk/Tax;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_Long_DLjava_lang_Long_Lru_tinkoff_acquiring_sdk_Tax_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_Long_DLjava_lang_Long_Lru_tinkoff_acquiring_sdk_Tax_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getAmount;
#pragma warning disable 0169
		static Delegate GetGetAmountHandler ()
		{
			if (cb_getAmount == null)
				cb_getAmount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAmount);
			return cb_getAmount;
		}

		static IntPtr n_GetAmount (IntPtr jnienv, IntPtr native__this)
		{
			global::RU.Tinkoff.Acquiring.Sdk.Item __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Item> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Amount);
		}
#pragma warning restore 0169

		static IntPtr id_getAmount;
		public virtual unsafe global::Java.Lang.Long Amount {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='Item']/method[@name='getAmount' and count(parameter)=0]"
			[Register ("getAmount", "()Ljava/lang/Long;", "GetGetAmountHandler")]
			get {
				if (id_getAmount == IntPtr.Zero)
					id_getAmount = JNIEnv.GetMethodID (class_ref, "getAmount", "()Ljava/lang/Long;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAmount), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAmount", "()Ljava/lang/Long;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getEan13;
#pragma warning disable 0169
		static Delegate GetGetEan13Handler ()
		{
			if (cb_getEan13 == null)
				cb_getEan13 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEan13);
			return cb_getEan13;
		}

		static IntPtr n_GetEan13 (IntPtr jnienv, IntPtr native__this)
		{
			global::RU.Tinkoff.Acquiring.Sdk.Item __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Item> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Ean13);
		}
#pragma warning restore 0169

		static Delegate cb_setEan13_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetEan13_Ljava_lang_String_Handler ()
		{
			if (cb_setEan13_Ljava_lang_String_ == null)
				cb_setEan13_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetEan13_Ljava_lang_String_);
			return cb_setEan13_Ljava_lang_String_;
		}

		static void n_SetEan13_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::RU.Tinkoff.Acquiring.Sdk.Item __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Item> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Ean13 = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getEan13;
		static IntPtr id_setEan13_Ljava_lang_String_;
		public virtual unsafe string Ean13 {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='Item']/method[@name='getEan13' and count(parameter)=0]"
			[Register ("getEan13", "()Ljava/lang/String;", "GetGetEan13Handler")]
			get {
				if (id_getEan13 == IntPtr.Zero)
					id_getEan13 = JNIEnv.GetMethodID (class_ref, "getEan13", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEan13), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEan13", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='Item']/method[@name='setEan13' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setEan13", "(Ljava/lang/String;)V", "GetSetEan13_Ljava_lang_String_Handler")]
			set {
				if (id_setEan13_Ljava_lang_String_ == IntPtr.Zero)
					id_setEan13_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setEan13", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setEan13_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEan13", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetName);
			return cb_getName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			global::RU.Tinkoff.Acquiring.Sdk.Item __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Item> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		static IntPtr id_getName;
		public virtual unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='Item']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get {
				if (id_getName == IntPtr.Zero)
					id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPrice;
#pragma warning disable 0169
		static Delegate GetGetPriceHandler ()
		{
			if (cb_getPrice == null)
				cb_getPrice = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPrice);
			return cb_getPrice;
		}

		static IntPtr n_GetPrice (IntPtr jnienv, IntPtr native__this)
		{
			global::RU.Tinkoff.Acquiring.Sdk.Item __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Item> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Price);
		}
#pragma warning restore 0169

		static IntPtr id_getPrice;
		public virtual unsafe global::Java.Lang.Long Price {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='Item']/method[@name='getPrice' and count(parameter)=0]"
			[Register ("getPrice", "()Ljava/lang/Long;", "GetGetPriceHandler")]
			get {
				if (id_getPrice == IntPtr.Zero)
					id_getPrice = JNIEnv.GetMethodID (class_ref, "getPrice", "()Ljava/lang/Long;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPrice), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPrice", "()Ljava/lang/Long;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getQuantity;
#pragma warning disable 0169
		static Delegate GetGetQuantityHandler ()
		{
			if (cb_getQuantity == null)
				cb_getQuantity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetQuantity);
			return cb_getQuantity;
		}

		static double n_GetQuantity (IntPtr jnienv, IntPtr native__this)
		{
			global::RU.Tinkoff.Acquiring.Sdk.Item __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Item> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Quantity;
		}
#pragma warning restore 0169

		static IntPtr id_getQuantity;
		public virtual unsafe double Quantity {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='Item']/method[@name='getQuantity' and count(parameter)=0]"
			[Register ("getQuantity", "()D", "GetGetQuantityHandler")]
			get {
				if (id_getQuantity == IntPtr.Zero)
					id_getQuantity = JNIEnv.GetMethodID (class_ref, "getQuantity", "()D");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getQuantity);
					else
						return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getQuantity", "()D"));
				} finally {
				}
			}
		}

		static Delegate cb_getShopCode;
#pragma warning disable 0169
		static Delegate GetGetShopCodeHandler ()
		{
			if (cb_getShopCode == null)
				cb_getShopCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetShopCode);
			return cb_getShopCode;
		}

		static IntPtr n_GetShopCode (IntPtr jnienv, IntPtr native__this)
		{
			global::RU.Tinkoff.Acquiring.Sdk.Item __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Item> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ShopCode);
		}
#pragma warning restore 0169

		static Delegate cb_setShopCode_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetShopCode_Ljava_lang_String_Handler ()
		{
			if (cb_setShopCode_Ljava_lang_String_ == null)
				cb_setShopCode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetShopCode_Ljava_lang_String_);
			return cb_setShopCode_Ljava_lang_String_;
		}

		static void n_SetShopCode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::RU.Tinkoff.Acquiring.Sdk.Item __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Item> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ShopCode = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getShopCode;
		static IntPtr id_setShopCode_Ljava_lang_String_;
		public virtual unsafe string ShopCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='Item']/method[@name='getShopCode' and count(parameter)=0]"
			[Register ("getShopCode", "()Ljava/lang/String;", "GetGetShopCodeHandler")]
			get {
				if (id_getShopCode == IntPtr.Zero)
					id_getShopCode = JNIEnv.GetMethodID (class_ref, "getShopCode", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getShopCode), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getShopCode", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='Item']/method[@name='setShopCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setShopCode", "(Ljava/lang/String;)V", "GetSetShopCode_Ljava_lang_String_Handler")]
			set {
				if (id_setShopCode_Ljava_lang_String_ == IntPtr.Zero)
					id_setShopCode_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setShopCode", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setShopCode_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setShopCode", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getTax;
#pragma warning disable 0169
		static Delegate GetGetTaxHandler ()
		{
			if (cb_getTax == null)
				cb_getTax = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTax);
			return cb_getTax;
		}

		static IntPtr n_GetTax (IntPtr jnienv, IntPtr native__this)
		{
			global::RU.Tinkoff.Acquiring.Sdk.Item __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Item> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Tax);
		}
#pragma warning restore 0169

		static IntPtr id_getTax;
		public virtual unsafe global::RU.Tinkoff.Acquiring.Sdk.Tax Tax {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='Item']/method[@name='getTax' and count(parameter)=0]"
			[Register ("getTax", "()Lru/tinkoff/acquiring/sdk/Tax;", "GetGetTaxHandler")]
			get {
				if (id_getTax == IntPtr.Zero)
					id_getTax = JNIEnv.GetMethodID (class_ref, "getTax", "()Lru/tinkoff/acquiring/sdk/Tax;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Tax> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTax), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Tax> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTax", "()Lru/tinkoff/acquiring/sdk/Tax;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
