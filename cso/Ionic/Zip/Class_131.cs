using System;
using System.Runtime.InteropServices;

namespace Ionic.Zip
{
	// Token: 0x020000AA RID: 170
	[ComVisible(true)]
	public class Class_131 : Class_129
	{
		// Token: 0x06000324 RID: 804 RVA: 0x00016443 File Offset: 0x00014643
		internal Class_131()
		{
		}

		// Token: 0x06000325 RID: 805 RVA: 0x0001644B File Offset: 0x0001464B
		private Class_131(string str_0, Class_128 arg_0) : base(str_0, arg_0)
		{
		}

		// Token: 0x06000326 RID: 806 RVA: 0x000164F8 File Offset: 0x000146F8
		internal static Class_131 xmethod_441(string str_0, Class_163 arg_0, int sayıInt_0)
		{
			return new Class_131(str_0, Class_128.Adding_AfterAddEntry)
			{
				prop_0 = sayıInt_0,
				prop_1 = arg_0
			};
		}

		// Token: 0x06000327 RID: 807 RVA: 0x0001651C File Offset: 0x0001471C
		internal static Class_131 tmethod_442(string str_0)
		{
			return new Class_131(str_0, Class_128.Adding_Started);
		}

		// Token: 0x06000328 RID: 808 RVA: 0x00016534 File Offset: 0x00014734
		internal static Class_131 gmethod_443(string str_0)
		{
			return new Class_131(str_0, Class_128.Adding_Completed);
		}
	}
}
