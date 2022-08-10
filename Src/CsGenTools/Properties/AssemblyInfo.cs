using System.Reflection;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("General")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("General")]
[assembly: AssemblyCopyright("Copyright ©  2019")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("d29281ad-e337-4685-9d2c-c21b1e0b9c76")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("2.2.0.2")]

/*
    1.1.0.0 first version
    1.0.0.0 Counter added (moved here from AppDiag)
    1.1.2.0 Wrapped event added
    1.2.0.0 DebugFriendly added
    1.3.0.0 TimeSpan average added
    2.0.0.0 functional codes brought here + add helpers from https://www.extensionmethod.net/csharp/object
    2.1.0.0 
    2.2.0.0 Match with action added to Maybe
    2.2.0.1 DataCacher added
    2.2.0.2 notes added to DataCacher
 */

// NOTE: don't change version of .Net for this project!! (makes problems with primitives)