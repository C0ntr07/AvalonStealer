using System;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000298 RID: 664
	internal class Class_487
	{
		// Token: 0x0600165E RID: 5726 RVA: 0x0006A033 File Offset: 0x00068233
		public Class_487()
		{
			this.field_2 = new Class_487.NClass_0[this.field_3 + 1];
		}

		// Token: 0x0600165F RID: 5727 RVA: 0x0006A058 File Offset: 0x00068258
		public string pmethod_4039(char[] charDizi_0, int sayıInt_0, int sayıInt_1)
		{
			if (sayıInt_1 == 0)
			{
				return string.Empty;
			}
			int num = sayıInt_1 + Class_487.field_0;
			num += (num << 7 ^ (int)charDizi_0[sayıInt_0]);
			int num2 = sayıInt_0 + sayıInt_1;
			for (int i = sayıInt_0 + 1; i < num2; i++)
			{
				num += (num << 7 ^ (int)charDizi_0[i]);
			}
			num -= num >> 17;
			num -= num >> 11;
			num -= num >> 5;
			for (Class_487.NClass_0 nclass_ = this.field_2[num & this.field_3]; nclass_ != null; nclass_ = nclass_.field_3)
			{
				if (nclass_.field_2 == num && Class_487.gmethod_4043(nclass_.field_1, charDizi_0, sayıInt_0, sayıInt_1))
				{
					return nclass_.field_1;
				}
			}
			return null;
		}

		// Token: 0x06001660 RID: 5728 RVA: 0x0006A100 File Offset: 0x00068300
		public string smethod_4040(string str_0)
		{
			if (str_0 == null)
			{
				throw new ArgumentNullException("key");
			}
			int length = str_0.Length;
			if (length == 0)
			{
				return string.Empty;
			}
			int num = length + Class_487.field_0;
			for (int i = 0; i < str_0.Length; i++)
			{
				num += (num << 7 ^ (int)str_0[i]);
			}
			num -= num >> 17;
			num -= num >> 11;
			num -= num >> 5;
			for (Class_487.NClass_0 nclass_ = this.field_2[num & this.field_3]; nclass_ != null; nclass_ = nclass_.field_3)
			{
				if (nclass_.field_2 == num && nclass_.field_1.Equals(str_0))
				{
					return nclass_.field_1;
				}
			}
			return this.xmethod_4041(str_0, num);
		}

		// Token: 0x06001661 RID: 5729 RVA: 0x0006A1C0 File Offset: 0x000683C0
		private string xmethod_4041(string str_0, int sayıInt_0)
		{
			int num = sayıInt_0 & this.field_3;
			Class_487.NClass_0 nclass_ = new Class_487.NClass_0(str_0, sayıInt_0, this.field_2[num]);
			this.field_2[num] = nclass_;
			if (this.field_1++ == this.field_3)
			{
				this.tmethod_4042();
			}
			return nclass_.field_1;
		}

		// Token: 0x06001662 RID: 5730 RVA: 0x0006A220 File Offset: 0x00068420
		private void tmethod_4042()
		{
			Class_487.NClass_0[] array = this.field_2;
			int num = this.field_3 * 2 + 1;
			Class_487.NClass_0[] array2 = new Class_487.NClass_0[num + 1];
			foreach (Class_487.NClass_0 nclass_ in array)
			{
				while (nclass_ != null)
				{
					int num2 = nclass_.field_2 & num;
					Class_487.NClass_0 nclass_2 = nclass_.field_3;
					nclass_.field_3 = array2[num2];
					array2[num2] = nclass_;
					nclass_ = nclass_2;
				}
			}
			this.field_2 = array2;
			this.field_3 = num;
		}

		// Token: 0x06001663 RID: 5731 RVA: 0x0006A2AC File Offset: 0x000684AC
		private static bool gmethod_4043(string str_0, char[] charDizi_0, int sayıInt_0, int sayıInt_1)
		{
			if (str_0.Length != sayıInt_1)
			{
				return false;
			}
			for (int i = 0; i < str_0.Length; i++)
			{
				if (str_0[i] != charDizi_0[sayıInt_0 + i])
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x04000BB6 RID: 2998
		private static readonly int field_0 = Environment.TickCount;

		// Token: 0x04000BB7 RID: 2999
		private int field_1;

		// Token: 0x04000BB8 RID: 3000
		private Class_487.NClass_0[] field_2;

		// Token: 0x04000BB9 RID: 3001
		private int field_3 = 31;

		// Token: 0x02000299 RID: 665
		private class NClass_0
		{
			// Token: 0x06001664 RID: 5732 RVA: 0x0006A2EF File Offset: 0x000684EF
			internal void nmethod_0(string str_0, int sayıInt_0, Class_487.NClass_0 arg_0)
			{
				base..ctor();
				this.field_1 = str_0;
				this.field_2 = sayıInt_0;
				this.field_3 = arg_0;
			}

			// Token: 0x04000BBA RID: 3002
			internal readonly string field_1;

			// Token: 0x04000BBB RID: 3003
			internal readonly int field_2;

			// Token: 0x04000BBC RID: 3004
			internal Class_487.NClass_0 field_3;
		}
	}
}
