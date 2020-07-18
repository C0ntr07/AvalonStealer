using System;
using System.Runtime.InteropServices;

namespace Ionic.Zip
{
	// Token: 0x020000AB RID: 171
	[ComVisible(true)]
	public class Class_132 : Class_129
	{
		// Token: 0x06000329 RID: 809 RVA: 0x0001654A File Offset: 0x0001474A
		internal Class_132(string str_0, bool bool_0, int sayıInt_0, int sayıInt_1, Class_163 arg_0) : base(str_0, bool_0 ? Class_128.Saving_BeforeWriteEntry : Class_128.Saving_AfterWriteEntry)
		{
			base.prop_0 = sayıInt_0;
			base.prop_1 = arg_0;
			this.field_0 = sayıInt_1;
		}

		// Token: 0x0600032A RID: 810 RVA: 0x00016443 File Offset: 0x00014643
		internal Class_132()
		{
		}

		// Token: 0x0600032B RID: 811 RVA: 0x0001644B File Offset: 0x0001464B
		internal Class_132(string str_0, Class_128 arg_0) : base(str_0, arg_0)
		{
		}

		// Token: 0x0600032C RID: 812 RVA: 0x0001657C File Offset: 0x0001477C
		internal static Class_132 cmethod_444(string str_0, Class_163 arg_0, long sayıUınt_0, long sayıUınt_1)
		{
			return new Class_132(str_0, Class_128.Saving_EntryBytesRead)
			{
				prop_4 = str_0,
				prop_1 = arg_0,
				prop_5 = sayıUınt_0,
				prop_6 = sayıUınt_1
			};
		}

		// Token: 0x0600032D RID: 813 RVA: 0x000165B0 File Offset: 0x000147B0
		internal static Class_132 vmethod_445(string str_0)
		{
			return new Class_132(str_0, Class_128.Saving_Started);
		}

		// Token: 0x0600032E RID: 814 RVA: 0x000165C8 File Offset: 0x000147C8
		internal static Class_132 dmethod_446(string str_0)
		{
			return new Class_132(str_0, Class_128.Saving_Completed);
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x0600032F RID: 815 RVA: 0x000165DF File Offset: 0x000147DF
		public new int prop_0
		{
			get
			{
				return this.field_0;
			}
		}

		// Token: 0x04000216 RID: 534
		private int field_0;
	}
}
