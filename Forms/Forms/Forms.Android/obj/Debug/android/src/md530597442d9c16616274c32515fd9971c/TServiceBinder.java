package md530597442d9c16616274c32515fd9971c;


public class TServiceBinder
	extends android.os.Binder
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Forms.Droid.TServiceBinder, Forms.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", TServiceBinder.class, __md_methods);
	}


	public TServiceBinder () throws java.lang.Throwable
	{
		super ();
		if (getClass () == TServiceBinder.class)
			mono.android.TypeManager.Activate ("Forms.Droid.TServiceBinder, Forms.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	public TServiceBinder (md530597442d9c16616274c32515fd9971c.TService p0) throws java.lang.Throwable
	{
		super ();
		if (getClass () == TServiceBinder.class)
			mono.android.TypeManager.Activate ("Forms.Droid.TServiceBinder, Forms.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Forms.Droid.TService, Forms.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", this, new java.lang.Object[] { p0 });
	}

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
