using System;
using System.Collections.Generic;
using Android.Runtime;

namespace RU.Tinkoff.Acquiring.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='CheckType']"
	[global::Android.Runtime.Register ("ru/tinkoff/acquiring/sdk/CheckType", DoNotGenerateAcw=true)]
	public sealed partial class CheckType : global::Java.Lang.Enum {


		static IntPtr HOLD_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='CheckType']/field[@name='HOLD']"
		[Register ("HOLD")]
		public static global::RU.Tinkoff.Acquiring.Sdk.CheckType Hold {
			get {
				if (HOLD_jfieldId == IntPtr.Zero)
					HOLD_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HOLD", "Lru/tinkoff/acquiring/sdk/CheckType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, HOLD_jfieldId);
				return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.CheckType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr NO_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='CheckType']/field[@name='NO']"
		[Register ("NO")]
		public static global::RU.Tinkoff.Acquiring.Sdk.CheckType No {
			get {
				if (NO_jfieldId == IntPtr.Zero)
					NO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NO", "Lru/tinkoff/acquiring/sdk/CheckType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NO_jfieldId);
				return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.CheckType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr THREE_DS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='CheckType']/field[@name='THREE_DS']"
		[Register ("THREE_DS")]
		public static global::RU.Tinkoff.Acquiring.Sdk.CheckType ThreeDs {
			get {
				if (THREE_DS_jfieldId == IntPtr.Zero)
					THREE_DS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "THREE_DS", "Lru/tinkoff/acquiring/sdk/CheckType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, THREE_DS_jfieldId);
				return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.CheckType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr THREE_DS_HOLD_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='CheckType']/field[@name='THREE_DS_HOLD']"
		[Register ("THREE_DS_HOLD")]
		public static global::RU.Tinkoff.Acquiring.Sdk.CheckType ThreeDsHold {
			get {
				if (THREE_DS_HOLD_jfieldId == IntPtr.Zero)
					THREE_DS_HOLD_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "THREE_DS_HOLD", "Lru/tinkoff/acquiring/sdk/CheckType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, THREE_DS_HOLD_jfieldId);
				return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.CheckType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("ru/tinkoff/acquiring/sdk/CheckType", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CheckType); }
		}

		internal CheckType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_fromString_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='CheckType']/method[@name='fromString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("fromString", "(Ljava/lang/String;)Lru/tinkoff/acquiring/sdk/CheckType;", "")]
		public static unsafe global::RU.Tinkoff.Acquiring.Sdk.CheckType FromString (string p0)
		{
			if (id_fromString_Ljava_lang_String_ == IntPtr.Zero)
				id_fromString_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "fromString", "(Ljava/lang/String;)Lru/tinkoff/acquiring/sdk/CheckType;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::RU.Tinkoff.Acquiring.Sdk.CheckType __ret = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.CheckType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromString_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='CheckType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lru/tinkoff/acquiring/sdk/CheckType;", "")]
		public static unsafe global::RU.Tinkoff.Acquiring.Sdk.CheckType ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lru/tinkoff/acquiring/sdk/CheckType;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::RU.Tinkoff.Acquiring.Sdk.CheckType __ret = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.CheckType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='CheckType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lru/tinkoff/acquiring/sdk/CheckType;", "")]
		public static unsafe global::RU.Tinkoff.Acquiring.Sdk.CheckType[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lru/tinkoff/acquiring/sdk/CheckType;");
			try {
				return (global::RU.Tinkoff.Acquiring.Sdk.CheckType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::RU.Tinkoff.Acquiring.Sdk.CheckType));
			} finally {
			}
		}

	}
}
