using System.Reflection;
using Android;
using Android.App;

// Information about this assembly is defined by the following attributes. 
// Change them to the values specific to your project.

[assembly: AssemblyTitle("Forms.Android")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("")]
[assembly: AssemblyCopyright("${AuthorCopyright}")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// The assembly version has the format "{Major}.{Minor}.{Build}.{Revision}".
// The form "{Major}.{Minor}.*" will automatically update the build and revision,
// and "{Major}.{Minor}.{Build}.*" will update just the revision.

[assembly: AssemblyVersion("1.0.0")]

// The following attributes are used to specify the signing key for the assembly, 
// if desired. See the Mono documentation for more information about signing.

//[assembly: AssemblyDelaySign(false)]
//[assembly: AssemblyKeyFile("")]

// https://developer.android.com/reference/android/Manifest.permission.html#RECEIVE_BOOT_COMPLETED
[assembly: UsesPermission(Manifest.Permission.ReceiveBootCompleted)] // ... (normal)
[assembly: UsesPermission(Manifest.Permission.AccessNotificationPolicy)] // Marker permission for applications that wish to access notification policy. (normal)
[assembly: UsesPermission(Manifest.Permission.Internet)] // Allows applications to open network sockets. (normal)
[assembly: UsesPermission(Manifest.Permission.AccessCoarseLocation)] // Allows an app to access approximate location. Alternatively, you might want ACCESS_FINE_LOCATION. (dangerous)
[assembly: UsesPermission(Manifest.Permission.AccessFineLocation)] // Allows an app to access precise location. Alternatively, you might want ACCESS_COARSE_LOCATION. (dangerous) 
[assembly: UsesPermission(Manifest.Permission.AccessLocationExtraCommands)] // Allows an application to access extra location provider commands. (normal) ?
[assembly: UsesPermission(Manifest.Permission.InstantAppForegroundService)] // Allows an instant app to create foreground services. (normal)
[assembly: UsesPermission(Manifest.Permission.ReceiveSms)]
[assembly: UsesPermission(Manifest.Permission.ReadSms)]

[assembly: UsesFeature("android.hardware.location", Required = false)]
[assembly: UsesFeature("android.hardware.location.gps", Required = false)]
[assembly: UsesFeature("android.hardware.location.network", Required = false)]