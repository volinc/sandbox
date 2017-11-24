using System;
using System.Collections.Generic;
using Android.Runtime;

namespace RU.Tinkoff.Acquiring.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='Taxation']"
	[global::Android.Runtime.Register ("ru/tinkoff/acquiring/sdk/Taxation", DoNotGenerateAcw=true)]
	public sealed partial class Taxation : global::Java.Lang.Enum {


		static IntPtr ENVD_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='Taxation']/field[@name='ENVD']"
		[Register ("ENVD")]
		public static global::RU.Tinkoff.Acquiring.Sdk.Taxation Envd {
			get {
				if (ENVD_jfieldId == IntPtr.Zero)
					ENVD_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ENVD", "Lru/tinkoff/acquiring/sdk/Taxation;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ENVD_jfieldId);
				return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Taxation> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ESN_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='Taxation']/field[@name='ESN']"
		[Register ("ESN")]
		public static global::RU.Tinkoff.Acquiring.Sdk.Taxation Esn {
			get {
				if (ESN_jfieldId == IntPtr.Zero)
					ESN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ESN", "Lru/tinkoff/acquiring/sdk/Taxation;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ESN_jfieldId);
				return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Taxation> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr OSN_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='Taxation']/field[@name='OSN']"
		[Register ("OSN")]
		public static global::RU.Tinkoff.Acquiring.Sdk.Taxation Osn {
			get {
				if (OSN_jfieldId == IntPtr.Zero)
					OSN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OSN", "Lru/tinkoff/acquiring/sdk/Taxation;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, OSN_jfieldId);
				return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Taxation> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr PATENT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='Taxation']/field[@name='PATENT']"
		[Register ("PATENT")]
		public static global::RU.Tinkoff.Acquiring.Sdk.Taxation Patent {
			get {
				if (PATENT_jfieldId == IntPtr.Zero)
					PATENT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PATENT", "Lru/tinkoff/acquiring/sdk/Taxation;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PATENT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Taxation> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr USN_INCOME_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='Taxation']/field[@name='USN_INCOME']"
		[Register ("USN_INCOME")]
		public static global::RU.Tinkoff.Acquiring.Sdk.Taxation UsnIncome {
			get {
				if (USN_INCOME_jfieldId == IntPtr.Zero)
					USN_INCOME_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "USN_INCOME", "Lru/tinkoff/acquiring/sdk/Taxation;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, USN_INCOME_jfieldId);
				return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Taxation> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr USN_INCOME_OUTCOME_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='Taxation']/field[@name='USN_INCOME_OUTCOME']"
		[Register ("USN_INCOME_OUTCOME")]
		public static global::RU.Tinkoff.Acquiring.Sdk.Taxation UsnIncomeOutcome {
			get {
				if (USN_INCOME_OUTCOME_jfieldId == IntPtr.Zero)
					USN_INCOME_OUTCOME_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "USN_INCOME_OUTCOME", "Lru/tinkoff/acquiring/sdk/Taxation;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, USN_INCOME_OUTCOME_jfieldId);
				return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Taxation> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("ru/tinkoff/acquiring/sdk/Taxation", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Taxation); }
		}

		internal Taxation (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='Taxation']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lru/tinkoff/acquiring/sdk/Taxation;", "")]
		public static unsafe global::RU.Tinkoff.Acquiring.Sdk.Taxation ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lru/tinkoff/acquiring/sdk/Taxation;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::RU.Tinkoff.Acquiring.Sdk.Taxation __ret = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Taxation> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='Taxation']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lru/tinkoff/acquiring/sdk/Taxation;", "")]
		public static unsafe global::RU.Tinkoff.Acquiring.Sdk.Taxation[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lru/tinkoff/acquiring/sdk/Taxation;");
			try {
				return (global::RU.Tinkoff.Acquiring.Sdk.Taxation[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::RU.Tinkoff.Acquiring.Sdk.Taxation));
			} finally {
			}
		}

	}
}
