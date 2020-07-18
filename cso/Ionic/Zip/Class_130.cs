using System;
using System.Runtime.InteropServices;

namespace Ionic.Zip
{
	// Token: 0x020000A9 RID: 169
	[ComVisible(true)]
	public class Class_130 : Class_129
	{
		// Token: 0x0600031D RID: 797 RVA: 0x00016443 File Offset: 0x00014643
		internal Class_130()
		{
		}

		// Token: 0x0600031E RID: 798 RVA: 0x0001644B File Offset: 0x0001464B
		private Class_130(string str_0, Class_128 arg_0) : base(str_0, arg_0)
		{
		}

		// Token: 0x0600031F RID: 799 RVA: 0x00016458 File Offset: 0x00014658
		internal static Class_130 dmethod_436(string str_0, int sayıInt_0)
		{
			return new Class_130(str_0, Class_128.Reading_BeforeReadEntry)
			{
				prop_0 = sayıInt_0
			};
		}

		// Token: 0x06000320 RID: 800 RVA: 0x00016478 File Offset: 0x00014678
		internal static Class_130 kmethod_437(string str_0, Class_163 arg_0, int sayıInt_0)
		{
			return new Class_130(str_0, Class_128.Reading_AfterReadEntry)
			{
				prop_0 = sayıInt_0,
				prop_1 = arg_0
			};
		}

		// Token: 0x06000321 RID: 801 RVA: 0x0001649C File Offset: 0x0001469C
		internal static Class_130 lmethod_438(string str_0)
		{
			return new Class_130(str_0, Class_128.Reading_Started);
		}

		// Token: 0x06000322 RID: 802 RVA: 0x000164B4 File Offset: 0x000146B4
		internal static Class_130 pmethod_439(string str_0, Class_163 arg_0, long sayıUınt_0, long sayıUınt_1)
		{
			return new Class_130(str_0, Class_128.Reading_ArchiveBytesRead)
			{
				prop_1 = arg_0,
				prop_5 = sayıUınt_0,
				prop_6 = sayıUınt_1
			};
		}

		// Token: 0x06000323 RID: 803 RVA: 0x000164E0 File Offset: 0x000146E0
		internal static Class_130 smethod_440(string str_0)
		{
			return new Class_130(str_0, Class_128.Reading_Completed);
		}
	}
}
