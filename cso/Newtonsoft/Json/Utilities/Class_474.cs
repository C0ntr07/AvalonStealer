using System;
using System.IO;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000278 RID: 632
	internal class Class_474
	{
		// Token: 0x060015BF RID: 5567 RVA: 0x00067874 File Offset: 0x00065A74
		public Class_474(TextWriter arg_0)
		{
			Class_517.ArgumentNotNull(arg_0, "writer");
			this.field_3 = arg_0;
		}

		// Token: 0x060015C0 RID: 5568 RVA: 0x0006789C File Offset: 0x00065A9C
		public void smethod_4000(byte[] byteDizi_0, int sayıInt_0, int sayıInt_1)
		{
			if (byteDizi_0 == null)
			{
				throw new ArgumentNullException("buffer");
			}
			if (sayıInt_0 < 0)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			if (sayıInt_1 < 0)
			{
				throw new ArgumentOutOfRangeException("count");
			}
			if (sayıInt_1 > byteDizi_0.Length - sayıInt_0)
			{
				throw new ArgumentOutOfRangeException("count");
			}
			if (this.field_5 > 0)
			{
				int num = this.field_5;
				while (num < 3 && sayıInt_1 > 0)
				{
					this.field_4[num++] = byteDizi_0[sayıInt_0++];
					sayıInt_1--;
				}
				if (sayıInt_1 == 0 && num < 3)
				{
					this.field_5 = num;
					return;
				}
				int sayıInt_2 = Convert.ToBase64CharArray(this.field_4, 0, 3, this.field_2, 0);
				this.tmethod_4002(this.field_2, 0, sayıInt_2);
			}
			this.field_5 = sayıInt_1 % 3;
			if (this.field_5 > 0)
			{
				sayıInt_1 -= this.field_5;
				if (this.field_4 == null)
				{
					this.field_4 = new byte[3];
				}
				for (int i = 0; i < this.field_5; i++)
				{
					this.field_4[i] = byteDizi_0[sayıInt_0 + sayıInt_1 + i];
				}
			}
			int num2 = sayıInt_0 + sayıInt_1;
			int num3 = 57;
			while (sayıInt_0 < num2)
			{
				if (sayıInt_0 + num3 > num2)
				{
					num3 = num2 - sayıInt_0;
				}
				int sayıInt_3 = Convert.ToBase64CharArray(byteDizi_0, sayıInt_0, num3, this.field_2, 0);
				this.tmethod_4002(this.field_2, 0, sayıInt_3);
				sayıInt_0 += num3;
			}
		}

		// Token: 0x060015C1 RID: 5569 RVA: 0x00067A08 File Offset: 0x00065C08
		public void xmethod_4001()
		{
			if (this.field_5 > 0)
			{
				int sayıInt_ = Convert.ToBase64CharArray(this.field_4, 0, this.field_5, this.field_2, 0);
				this.tmethod_4002(this.field_2, 0, sayıInt_);
				this.field_5 = 0;
			}
		}

		// Token: 0x060015C2 RID: 5570 RVA: 0x00067A50 File Offset: 0x00065C50
		private void tmethod_4002(char[] charDizi_0, int sayıInt_0, int sayıInt_1)
		{
			this.field_3.Write(charDizi_0, sayıInt_0, sayıInt_1);
		}

		// Token: 0x04000B65 RID: 2917
		private const int field_0 = 76;

		// Token: 0x04000B66 RID: 2918
		private const int field_1 = 57;

		// Token: 0x04000B67 RID: 2919
		private readonly char[] field_2 = new char[76];

		// Token: 0x04000B68 RID: 2920
		private readonly TextWriter field_3;

		// Token: 0x04000B69 RID: 2921
		private byte[] field_4;

		// Token: 0x04000B6A RID: 2922
		private int field_5;
	}
}
