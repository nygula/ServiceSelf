// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#pragma warning disable CS1591,CS1573,CS0465,CS0649,CS8019,CS1570,CS1584,CS1658,CS0436,CS8981
using global::System;
using global::System.Diagnostics;
using global::System.Diagnostics.CodeAnalysis;
using global::System.Runtime.CompilerServices;
using global::System.Runtime.InteropServices;
using global::System.Runtime.Versioning;
using winmdroot = global::Windows.Win32;
namespace Windows.Win32
{
    namespace System.Services
    {
        [Flags]
		[global::System.CodeDom.Compiler.GeneratedCode("Microsoft.Windows.CsWin32", "0.3.106+a37a0b4b70")]
		internal enum ENUM_SERVICE_TYPE : uint
		{
			SERVICE_DRIVER = 0x0000000B,
			SERVICE_KERNEL_DRIVER = 0x00000001,
			SERVICE_WIN32 = 0x00000030,
			SERVICE_WIN32_SHARE_PROCESS = 0x00000020,
			SERVICE_ADAPTER = 0x00000004,
			SERVICE_FILE_SYSTEM_DRIVER = 0x00000002,
			SERVICE_RECOGNIZER_DRIVER = 0x00000008,
			SERVICE_WIN32_OWN_PROCESS = 0x00000010,
			SERVICE_USER_OWN_PROCESS = 0x00000050,
			SERVICE_USER_SHARE_PROCESS = 0x00000060,
			SERVICE_NO_CHANGE = 0xFFFFFFFF,
		}
	}
}