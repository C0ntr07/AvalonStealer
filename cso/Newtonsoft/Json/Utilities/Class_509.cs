using System;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x020002BD RID: 701
	internal class Class_509
	{
		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x0600173B RID: 5947 RVA: 0x0006E0B0 File Offset: 0x0006C2B0
		// (set) Token: 0x0600173C RID: 5948 RVA: 0x0006E0B8 File Offset: 0x0006C2B8
		public int prop_0
		{
			get
			{
				return this.field_1;
			}
			set
			{
				this.field_1 = value;
			}
		}

		// Token: 0x0600173D RID: 5949 RVA: 0x0006E0C1 File Offset: 0x0006C2C1
		public Class_509()
		{
			this.field_0 = Class_509.field_2;
		}

		// Token: 0x0600173E RID: 5950 RVA: 0x0006E0D4 File Offset: 0x0006C2D4
		public Class_509(int sayıInt_0)
		{
			this.field_0 = new char[sayıInt_0];
		}

		// Token: 0x0600173F RID: 5951 RVA: 0x0006E0E8 File Offset: 0x0006C2E8
		public void kmethod_4137(char char_0)
		{
			if (this.field_1 == this.field_0.Length)
			{
				this.smethod_4140(1);
			}
			this.field_0[this.field_1++] = char_0;
		}

		// Token: 0x06001740 RID: 5952 RVA: 0x0006E128 File Offset: 0x0006C328
		public void lmethod_4138(char[] charDizi_0, int sayıInt_0, int sayıInt_1)
		{
			if (this.field_1 + sayıInt_1 >= this.field_0.Length)
			{
				this.smethod_4140(sayıInt_1);
			}
			Array.Copy(charDizi_0, sayıInt_0, this.field_0, this.field_1, sayıInt_1);
			this.field_1 += sayıInt_1;
		}

		// Token: 0x06001741 RID: 5953 RVA: 0x0006E168 File Offset: 0x0006C368
		public void pmethod_4139()
		{
			this.field_0 = Class_509.field_2;
			this.field_1 = 0;
		}

		// Token: 0x06001742 RID: 5954 RVA: 0x0006E17C File Offset: 0x0006C37C
		private void smethod_4140(int sayıInt_0)
		{
			char[] destinationArray = new char[(this.field_1 + sayıInt_0) * 2];
			Array.Copy(this.field_0, destinationArray, this.field_1);
			this.field_0 = destinationArray;
		}

		// Token: 0x06001743 RID: 5955 RVA: 0x0006E1B2 File Offset: 0x0006C3B2
		public virtual string xmethod_4141()
		{
			return this.tmethod_4142(0, this.field_1);
		}

		// Token: 0x06001744 RID: 5956 RVA: 0x0006E1C1 File Offset: 0x0006C3C1
		public string tmethod_4142(int sayıInt_0, int sayıInt_1)
		{
			return new string(this.field_0, sayıInt_0, sayıInt_1);
		}

		// Token: 0x06001745 RID: 5957 RVA: 0x0006E1D0 File Offset: 0x0006C3D0
		public char[] gmethod_4143()
		{
			return this.field_0;
		}

		// Token: 0x04000C49 RID: 3145
		private char[] field_0;

		// Token: 0x04000C4A RID: 3146
		private int field_1;

		// Token: 0x04000C4B RID: 3147
		private static readonly char[] field_2 = new char[0];
	}
}
