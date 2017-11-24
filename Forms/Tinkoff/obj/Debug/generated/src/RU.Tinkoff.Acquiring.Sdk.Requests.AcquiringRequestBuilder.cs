using System;
using System.Collections.Generic;
using Android.Runtime;

namespace RU.Tinkoff.Acquiring.Sdk.Requests {

	// Metadata.xml XPath class reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='AcquiringRequestBuilder']"
	[global::Android.Runtime.Register ("ru/tinkoff/acquiring/sdk/requests/AcquiringRequestBuilder", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"R extends ru.tinkoff.acquiring.sdk.requests.AcquiringRequest"})]
	public abstract partial class AcquiringRequestBuilder : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("ru/tinkoff/acquiring/sdk/requests/AcquiringRequestBuilder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AcquiringRequestBuilder); }
		}

		protected AcquiringRequestBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getRequest;
#pragma warning disable 0169
		static Delegate GetGetRequestHandler ()
		{
			if (cb_getRequest == null)
				cb_getRequest = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRequest);
			return cb_getRequest;
		}

		static IntPtr n_GetRequest (IntPtr jnienv, IntPtr native__this)
		{
			global::RU.Tinkoff.Acquiring.Sdk.Requests.AcquiringRequestBuilder __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Requests.AcquiringRequestBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RawRequest);
		}
#pragma warning restore 0169

		protected abstract global::Java.Lang.Object RawRequest {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='AcquiringRequestBuilder']/method[@name='getRequest' and count(parameter)=0]"
			[Register ("getRequest", "()Lru/tinkoff/acquiring/sdk/requests/AcquiringRequest;", "GetGetRequestHandler")] get;
		}

		static Delegate cb_build;
#pragma warning disable 0169
		static Delegate GetBuildHandler ()
		{
			if (cb_build == null)
				cb_build = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Build);
			return cb_build;
		}

		static IntPtr n_Build (IntPtr jnienv, IntPtr native__this)
		{
			global::RU.Tinkoff.Acquiring.Sdk.Requests.AcquiringRequestBuilder __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Requests.AcquiringRequestBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Build ());
		}
#pragma warning restore 0169

		static IntPtr id_build;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='AcquiringRequestBuilder']/method[@name='build' and count(parameter)=0]"
		[Register ("build", "()Lru/tinkoff/acquiring/sdk/requests/AcquiringRequest;", "GetBuildHandler")]
		public virtual unsafe global::Java.Lang.Object Build ()
		{
			if (id_build == IntPtr.Zero)
				id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lru/tinkoff/acquiring/sdk/requests/AcquiringRequest;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_build), JniHandleOwnership.TransferLocalRef);
				else
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "build", "()Lru/tinkoff/acquiring/sdk/requests/AcquiringRequest;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_validate;
#pragma warning disable 0169
		static Delegate GetValidateHandler ()
		{
			if (cb_validate == null)
				cb_validate = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Validate);
			return cb_validate;
		}

		static void n_Validate (IntPtr jnienv, IntPtr native__this)
		{
			global::RU.Tinkoff.Acquiring.Sdk.Requests.AcquiringRequestBuilder __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Requests.AcquiringRequestBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Validate ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='AcquiringRequestBuilder']/method[@name='validate' and count(parameter)=0]"
		[Register ("validate", "()V", "GetValidateHandler")]
		protected abstract void Validate ();

		static Delegate cb_validateNonEmpty_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetValidateNonEmpty_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_validateNonEmpty_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_validateNonEmpty_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_ValidateNonEmpty_Ljava_lang_String_Ljava_lang_String_);
			return cb_validateNonEmpty_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_ValidateNonEmpty_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::RU.Tinkoff.Acquiring.Sdk.Requests.AcquiringRequestBuilder __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Requests.AcquiringRequestBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.ValidateNonEmpty (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_validateNonEmpty_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='AcquiringRequestBuilder']/method[@name='validateNonEmpty' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("validateNonEmpty", "(Ljava/lang/String;Ljava/lang/String;)V", "GetValidateNonEmpty_Ljava_lang_String_Ljava_lang_String_Handler")]
		protected virtual unsafe void ValidateNonEmpty (string p0, string p1)
		{
			if (id_validateNonEmpty_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_validateNonEmpty_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "validateNonEmpty", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_validateNonEmpty_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "validateNonEmpty", "(Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_validateNonNull_Ljava_lang_Object_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetValidateNonNull_Ljava_lang_Object_Ljava_lang_String_Handler ()
		{
			if (cb_validateNonNull_Ljava_lang_Object_Ljava_lang_String_ == null)
				cb_validateNonNull_Ljava_lang_Object_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_ValidateNonNull_Ljava_lang_Object_Ljava_lang_String_);
			return cb_validateNonNull_Ljava_lang_Object_Ljava_lang_String_;
		}

		static void n_ValidateNonNull_Ljava_lang_Object_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::RU.Tinkoff.Acquiring.Sdk.Requests.AcquiringRequestBuilder __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Requests.AcquiringRequestBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.ValidateNonNull (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_validateNonNull_Ljava_lang_Object_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='AcquiringRequestBuilder']/method[@name='validateNonNull' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String']]"
		[Register ("validateNonNull", "(Ljava/lang/Object;Ljava/lang/String;)V", "GetValidateNonNull_Ljava_lang_Object_Ljava_lang_String_Handler")]
		protected virtual unsafe void ValidateNonNull (global::Java.Lang.Object p0, string p1)
		{
			if (id_validateNonNull_Ljava_lang_Object_Ljava_lang_String_ == IntPtr.Zero)
				id_validateNonNull_Ljava_lang_Object_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "validateNonNull", "(Ljava/lang/Object;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_validateNonNull_Ljava_lang_Object_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "validateNonNull", "(Ljava/lang/Object;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_validateZeroOrPositive_Ljava_lang_Long_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetValidateZeroOrPositive_Ljava_lang_Long_Ljava_lang_String_Handler ()
		{
			if (cb_validateZeroOrPositive_Ljava_lang_Long_Ljava_lang_String_ == null)
				cb_validateZeroOrPositive_Ljava_lang_Long_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_ValidateZeroOrPositive_Ljava_lang_Long_Ljava_lang_String_);
			return cb_validateZeroOrPositive_Ljava_lang_Long_Ljava_lang_String_;
		}

		static void n_ValidateZeroOrPositive_Ljava_lang_Long_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::RU.Tinkoff.Acquiring.Sdk.Requests.AcquiringRequestBuilder __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Requests.AcquiringRequestBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Long p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.ValidateZeroOrPositive (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_validateZeroOrPositive_Ljava_lang_Long_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='AcquiringRequestBuilder']/method[@name='validateZeroOrPositive' and count(parameter)=2 and parameter[1][@type='java.lang.Long'] and parameter[2][@type='java.lang.String']]"
		[Register ("validateZeroOrPositive", "(Ljava/lang/Long;Ljava/lang/String;)V", "GetValidateZeroOrPositive_Ljava_lang_Long_Ljava_lang_String_Handler")]
		protected virtual unsafe void ValidateZeroOrPositive (global::Java.Lang.Long p0, string p1)
		{
			if (id_validateZeroOrPositive_Ljava_lang_Long_Ljava_lang_String_ == IntPtr.Zero)
				id_validateZeroOrPositive_Ljava_lang_Long_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "validateZeroOrPositive", "(Ljava/lang/Long;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_validateZeroOrPositive_Ljava_lang_Long_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "validateZeroOrPositive", "(Ljava/lang/Long;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}

	[global::Android.Runtime.Register ("ru/tinkoff/acquiring/sdk/requests/AcquiringRequestBuilder", DoNotGenerateAcw=true)]
	internal partial class AcquiringRequestBuilderInvoker : AcquiringRequestBuilder {

		public AcquiringRequestBuilderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (AcquiringRequestBuilderInvoker); }
		}

		static IntPtr id_getRequest;
		protected override unsafe global::Java.Lang.Object RawRequest {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='AcquiringRequestBuilder']/method[@name='getRequest' and count(parameter)=0]"
			[Register ("getRequest", "()Lru/tinkoff/acquiring/sdk/requests/AcquiringRequest;", "GetGetRequestHandler")]
			get {
				if (id_getRequest == IntPtr.Zero)
					id_getRequest = JNIEnv.GetMethodID (class_ref, "getRequest", "()Lru/tinkoff/acquiring/sdk/requests/AcquiringRequest;");
				try {
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRequest), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_validate;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='AcquiringRequestBuilder']/method[@name='validate' and count(parameter)=0]"
		[Register ("validate", "()V", "GetValidateHandler")]
		protected override unsafe void Validate ()
		{
			if (id_validate == IntPtr.Zero)
				id_validate = JNIEnv.GetMethodID (class_ref, "validate", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_validate);
			} finally {
			}
		}

	}

}
