using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;

namespace Medo.Security.Cryptography
{
	// Token: 0x02000126 RID: 294
	public class Class_220
	{
		// Token: 0x06000849 RID: 2121 RVA: 0x00039090 File Offset: 0x00037290
		public Class_220(HMAC arg_0, byte[] byteDizi_0, byte[] byteDizi_1, int sayıInt_0)
		{
			if (arg_0 == null)
			{
				throw new ArgumentNullException("algorithm", "Algorithm cannot be null.");
			}
			if (byteDizi_1 == null)
			{
				throw new ArgumentNullException("salt", "Salt cannot be null.");
			}
			if (byteDizi_0 == null)
			{
				throw new ArgumentNullException("password", "Password cannot be null.");
			}
			this.prop_0 = arg_0;
			this.prop_0.Key = byteDizi_0;
			this.prop_1 = byteDizi_1;
			this.prop_2 = sayıInt_0;
			this.field_0 = this.prop_0.HashSize / 8;
			this.field_2 = new byte[this.field_0];
		}

		// Token: 0x0600084A RID: 2122 RVA: 0x00039132 File Offset: 0x00037332
		public Class_220(HMAC arg_0, byte[] byteDizi_0, byte[] byteDizi_1) : this(arg_0, byteDizi_0, byteDizi_1, 1000)
		{
		}

		// Token: 0x0600084B RID: 2123 RVA: 0x00039142 File Offset: 0x00037342
		public Class_220(HMAC arg_0, string str_0, string str_1, int sayıInt_0) : this(arg_0, Encoding.UTF8.GetBytes(str_0), Encoding.UTF8.GetBytes(str_1), sayıInt_0)
		{
		}

		// Token: 0x0600084C RID: 2124 RVA: 0x00039163 File Offset: 0x00037363
		public Class_220(HMAC arg_0, string str_0, string str_1) : this(arg_0, str_0, str_1, 1000)
		{
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x0600084D RID: 2125 RVA: 0x00039173 File Offset: 0x00037373
		// (set) Token: 0x0600084E RID: 2126 RVA: 0x0003917B File Offset: 0x0003737B
		public HMAC prop_0 { get; private set; }

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x0600084F RID: 2127 RVA: 0x00039184 File Offset: 0x00037384
		// (set) Token: 0x06000850 RID: 2128 RVA: 0x0003918C File Offset: 0x0003738C
		public byte[] prop_1 { get; private set; }

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x06000851 RID: 2129 RVA: 0x00039195 File Offset: 0x00037395
		// (set) Token: 0x06000852 RID: 2130 RVA: 0x0003919D File Offset: 0x0003739D
		public int prop_2 { get; private set; }

		// Token: 0x06000853 RID: 2131 RVA: 0x000391A8 File Offset: 0x000373A8
		public byte[] smethod_1460(int sayıInt_0)
		{
			byte[] array = new byte[sayıInt_0];
			int i = 0;
			int num = this.field_4 - this.field_3;
			if (num > 0)
			{
				if (sayıInt_0 < num)
				{
					Buffer.BlockCopy(this.field_2, this.field_3, array, 0, sayıInt_0);
					this.field_3 += sayıInt_0;
					return array;
				}
				Buffer.BlockCopy(this.field_2, this.field_3, array, 0, num);
				this.field_3 = (this.field_4 = 0);
				i += num;
			}
			while (i < sayıInt_0)
			{
				int num2 = sayıInt_0 - i;
				this.field_2 = this.xmethod_1461();
				if (num2 <= this.field_0)
				{
					Buffer.BlockCopy(this.field_2, 0, array, i, num2);
					this.field_3 = num2;
					this.field_4 = this.field_0;
					return array;
				}
				Buffer.BlockCopy(this.field_2, 0, array, i, this.field_0);
				i += this.field_0;
			}
			return array;
		}

		// Token: 0x06000854 RID: 2132 RVA: 0x00039298 File Offset: 0x00037498
		private byte[] xmethod_1461()
		{
			byte[] array = new byte[this.prop_1.Length + 4];
			Buffer.BlockCopy(this.prop_1, 0, array, 0, this.prop_1.Length);
			Buffer.BlockCopy(Class_220.tmethod_1462(this.field_1), 0, array, this.prop_1.Length, 4);
			byte[] array2 = this.prop_0.ComputeHash(array);
			byte[] array3 = array2;
			for (int i = 2; i <= this.prop_2; i++)
			{
				array2 = this.prop_0.ComputeHash(array2, 0, array2.Length);
				for (int j = 0; j < this.field_0; j++)
				{
					array3[j] ^= array2[j];
				}
			}
			if (this.field_1 == 4294967295U)
			{
				throw new InvalidOperationException("Derived key too long.");
			}
			this.field_1 += 1U;
			return array3;
		}

		// Token: 0x06000855 RID: 2133 RVA: 0x00039368 File Offset: 0x00037568
		private static byte[] tmethod_1462(uint arg_0)
		{
			byte[] bytes = BitConverter.GetBytes(arg_0);
			if (BitConverter.IsLittleEndian)
			{
				return new byte[]
				{
					bytes[3],
					bytes[2],
					bytes[1],
					bytes[0]
				};
			}
			return bytes;
		}

		// Token: 0x040005F9 RID: 1529
		private readonly int field_0;

		// Token: 0x040005FA RID: 1530
		private uint field_1 = 1U;

		// Token: 0x040005FB RID: 1531
		private byte[] field_2;

		// Token: 0x040005FC RID: 1532
		private int field_3;

		// Token: 0x040005FD RID: 1533
		private int field_4;

		// Token: 0x040005FE RID: 1534
		[CompilerGenerated]
		private HMAC field_5;

		// Token: 0x040005FF RID: 1535
		[CompilerGenerated]
		private byte[] field_6;

		// Token: 0x04000600 RID: 1536
		[CompilerGenerated]
		private int field_7;
	}
}
