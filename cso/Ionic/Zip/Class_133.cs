using System;
using System.Runtime.InteropServices;

namespace Ionic.Zip
{
	// Token: 0x020000AC RID: 172
	[ComVisible(true)]
	public class Class_133 : Class_129
	{
		// Token: 0x06000330 RID: 816 RVA: 0x000165E7 File Offset: 0x000147E7
		internal Class_133(string str_0, bool bool_0, int sayıInt_0, int sayıInt_1, Class_163 arg_0, string str_1) : base(str_0, bool_0 ? Class_128.Extracting_BeforeExtractEntry : Class_128.Extracting_AfterExtractEntry)
		{
			base.prop_0 = sayıInt_0;
			base.prop_1 = arg_0;
			this.field_0 = sayıInt_1;
			this.field_1 = str_1;
		}

		// Token: 0x06000331 RID: 817 RVA: 0x0001644B File Offset: 0x0001464B
		internal Class_133(string str_0, Class_128 arg_0) : base(str_0, arg_0)
		{
		}

		// Token: 0x06000332 RID: 818 RVA: 0x00016443 File Offset: 0x00014643
		internal Class_133()
		{
		}

		// Token: 0x06000333 RID: 819 RVA: 0x00016620 File Offset: 0x00014820
		internal static Class_133 lmethod_448(string str_0, Class_163 arg_0, string str_1)
		{
			return new Class_133
			{
				prop_4 = str_0,
				prop_3 = Class_128.Extracting_BeforeExtractEntry,
				prop_1 = arg_0,
				field_1 = str_1
			};
		}

		// Token: 0x06000334 RID: 820 RVA: 0x00016654 File Offset: 0x00014854
		internal static Class_133 pmethod_449(string str_0, Class_163 arg_0, string str_1)
		{
			return new Class_133
			{
				prop_4 = str_0,
				prop_3 = Class_128.Extracting_ExtractEntryWouldOverwrite,
				prop_1 = arg_0,
				field_1 = str_1
			};
		}

		// Token: 0x06000335 RID: 821 RVA: 0x00016688 File Offset: 0x00014888
		internal static Class_133 smethod_450(string str_0, Class_163 arg_0, string str_1)
		{
			return new Class_133
			{
				prop_4 = str_0,
				prop_3 = Class_128.Extracting_AfterExtractEntry,
				prop_1 = arg_0,
				field_1 = str_1
			};
		}

		// Token: 0x06000336 RID: 822 RVA: 0x000166BC File Offset: 0x000148BC
		internal static Class_133 xmethod_451(string str_0, string str_1)
		{
			return new Class_133(str_0, Class_128.Extracting_BeforeExtractAll)
			{
				field_1 = str_1
			};
		}

		// Token: 0x06000337 RID: 823 RVA: 0x000166DC File Offset: 0x000148DC
		internal static Class_133 tmethod_452(string str_0, string str_1)
		{
			return new Class_133(str_0, Class_128.Extracting_AfterExtractAll)
			{
				field_1 = str_1
			};
		}

		// Token: 0x06000338 RID: 824 RVA: 0x000166FC File Offset: 0x000148FC
		internal static Class_133 gmethod_453(string str_0, Class_163 arg_0, long sayıUınt_0, long sayıUınt_1)
		{
			return new Class_133(str_0, Class_128.Extracting_EntryBytesWritten)
			{
				prop_4 = str_0,
				prop_1 = arg_0,
				prop_5 = sayıUınt_0,
				prop_6 = sayıUınt_1
			};
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000339 RID: 825 RVA: 0x0001672F File Offset: 0x0001492F
		public new int prop_0
		{
			get
			{
				return this.field_0;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x0600033A RID: 826 RVA: 0x00016737 File Offset: 0x00014937
		public new string prop_1
		{
			get
			{
				return this.field_1;
			}
		}

		// Token: 0x04000217 RID: 535
		private int field_0;

		// Token: 0x04000218 RID: 536
		private string field_1;
	}
}
