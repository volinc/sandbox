using System;
using System.Collections.Generic;
using Android.Runtime;

namespace RU.Tinkoff.Acquiring.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='Tax']"
	[global::Android.Runtime.Register ("ru/tinkoff/acquiring/sdk/Tax", DoNotGenerateAcw=true)]
	public sealed partial class Tax : global::Java.Lang.Enum {


		static IntPtr NONE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='Tax']/field[@name='NONE']"
		[Register ("NONE")]
		public static global::RU.Tinkoff.Acquiring.Sdk.Tax None {
			get {
				if (NONE_jfieldId == IntPtr.Zero)
					NONE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NONE", "Lru/tinkoff/acquiring/sdk/Tax;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NONE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Tax> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr VAT_0_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='Tax']/field[@name='VAT_0']"
		[Register ("VAT_0")]
		public static global::RU.Tinkoff.Acquiring.Sdk.Tax Vat0 {
			get {
				if (VAT_0_jfieldId == IntPtr.Zero)
					VAT_0_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VAT_0", "Lru/tinkoff/acquiring/sdk/Tax;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VAT_0_jfieldId);
				return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Tax> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr VAT_10_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='Tax']/field[@name='VAT_10']"
		[Register ("VAT_10")]
		public static global::RU.Tinkoff.Acquiring.Sdk.Tax Vat10 {
			get {
				if (VAT_10_jfieldId == IntPtr.Zero)
					VAT_10_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VAT_10", "Lru/tinkoff/acquiring/sdk/Tax;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VAT_10_jfieldId);
				return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Tax> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr VAT_110_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='Tax']/field[@name='VAT_110']"
		[Register ("VAT_110")]
		public static global::RU.Tinkoff.Acquiring.Sdk.Tax Vat110 {
			get {
				if (VAT_110_jfieldId == IntPtr.Zero)
					VAT_110_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VAT_110", "Lru/tinkoff/acquiring/sdk/Tax;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VAT_110_jfieldId);
				return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Tax> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr VAT_118_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='Tax']/field[@name='VAT_118']"
		[Register ("VAT_118")]
		public static global::RU.Tinkoff.Acquiring.Sdk.Tax Vat118 {
			get {
				if (VAT_118_jfieldId == IntPtr.Zero)
					VAT_118_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VAT_118", "Lru/tinkoff/acquiring/sdk/Tax;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VAT_118_jfieldId);
				return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Tax> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr VAT_18_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='Tax']/field[@name='VAT_18']"
		[Register ("VAT_18")]
		public static global::RU.Tinkoff.Acquiring.Sdk.Tax Vat18 {
			get {
				if (VAT_18_jfieldId == IntPtr.Zero)
					VAT_18_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VAT_18", "Lru/tinkoff/acquiring/sdk/Tax;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VAT_18_jfieldId);
				return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Tax> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("ru/tinkoff/acquiring/sdk/Tax", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Tax); }
		}

		internal Tax (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='Tax']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lru/tinkoff/acquiring/sdk/Tax;", "")]
		public static unsafe global::RU.Tinkoff.Acquiring.Sdk.Tax ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lru/tinkoff/acquiring/sdk/Tax;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::RU.Tinkoff.Acquiring.Sdk.Tax __ret = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Tax> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='Tax']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lru/tinkoff/acquiring/sdk/Tax;", "")]
		public static unsafe global::RU.Tinkoff.Acquiring.Sdk.Tax[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lru/tinkoff/acquiring/sdk/Tax;");
			try {
				return (global::RU.Tinkoff.Acquiring.Sdk.Tax[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::RU.Tinkoff.Acquiring.Sdk.Tax));
			} finally {
			}
		}

	}
}
