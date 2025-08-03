using System.Runtime.InteropServices;
using System.Runtime.Versioning;
// cspell:ignore rclsid ppunk lpsz lpclsid oleaut UCOMI ppbc
namespace DevTKSS.Extensions.Marshalling;
// This is particularly useful for accessing COM objects like Application objects.
// Source code: <see href="https://adndevblog.typepad.com/autocad/2024/07/autocad-2025-marshalgetactiveobject-net-core.html"/>

/// <summary>
/// Provides methods for marshalling COM objects in .NET Core.
/// </summary>
public static class MarshalExtensions
{

    [DllImport("ole32")]
    private static extern int CLSIDFromProgIDEx(
        [MarshalAs(UnmanagedType.LPWStr)] string lpszProgID,
        out Guid lpclsid);

    [DllImport("oleaut32")]
    private static extern int GetActiveObject(
      [MarshalAs(UnmanagedType.LPStruct)] Guid rclsid,
      nint pvReserved,
      [MarshalAs(UnmanagedType.IUnknown)] out object ppunk);

    public static object? GetActiveObject(string progId, bool throwOnError = false)
    {
        ArgumentNullException.ThrowIfNull(progId);

        var hr = CLSIDFromProgIDEx(progId, out var clsid);
        if (hr < 0)
        {
            if (throwOnError)
                Marshal.ThrowExceptionForHR(hr);
            return null;
        }
        hr = GetActiveObject(clsid, nint.Zero, out var obj);
        if (hr < 0)
        {
            if (throwOnError)
                Marshal.ThrowExceptionForHR(hr);
            return null;
        }
        return obj;
    }

}
