package md530597442d9c16616274c32515fd9971c;


public class ForegroundService
	extends android.app.Service
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onBind:(Landroid/content/Intent;)Landroid/os/IBinder;:GetOnBind_Landroid_content_Intent_Handler\n" +
			"";
		mono.android.Runtime.register ("Forms.Droid.ForegroundService, Forms.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", ForegroundService.class, __md_methods);
	}


	public ForegroundService () throws java.lang.Throwable
	{
		super ();
		if (getClass () == ForegroundService.class)
			mono.android.TypeManager.Activate ("Forms.Droid.ForegroundService, Forms.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public android.os.IBinder onBind (android.content.Intent p0)
	{
		return n_onBind (p0);
	}

	private native android.os.IBinder n_onBind (android.content.Intent p0);

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
