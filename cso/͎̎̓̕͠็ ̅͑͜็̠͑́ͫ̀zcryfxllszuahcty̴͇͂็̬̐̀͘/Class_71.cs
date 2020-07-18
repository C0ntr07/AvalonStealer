using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace \u030E\u0360\u0313\u034E\u0315\u0E47\u0020\u0305\u035C\u0351\u0E47\u0351\u0320\u0301\u036B\u0300zcryfxllszuahcty\u0347\u0334\u0342\u0E47\u0310\u032C\u0358\u0340\u036B\u0331\u0329\u036B\u0340\u032F\u0308\u0E47cexuwlosbhsreyjl
{
	// Token: 0x0200005E RID: 94
	public class Class_71
	{
		// Token: 0x060001B7 RID: 439 RVA: 0x0000EF77 File Offset: 0x0000D177
		public Class_71(byte[] byteDizi_0, byte[] byteDizi_1, byte[] byteDizi_2)
		{
			this.field_0 = byteDizi_0;
			this.field_1 = byteDizi_1;
			this.field_2 = byteDizi_2;
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060001B8 RID: 440 RVA: 0x0000EFA0 File Offset: 0x0000D1A0
		private byte[] prop_0 { get; }

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060001B9 RID: 441 RVA: 0x0000EFB4 File Offset: 0x0000D1B4
		private byte[] prop_1 { get; }

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060001BA RID: 442 RVA: 0x0000EFC8 File Offset: 0x0000D1C8
		private byte[] prop_2 { get; }

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060001BB RID: 443 RVA: 0x0000EFDC File Offset: 0x0000D1DC
		// (set) Token: 0x060001BC RID: 444 RVA: 0x0000EFF0 File Offset: 0x0000D1F0
		public byte[] prop_3 { get; private set; }

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060001BD RID: 445 RVA: 0x0000F005 File Offset: 0x0000D205
		// (set) Token: 0x060001BE RID: 446 RVA: 0x0000F019 File Offset: 0x0000D219
		public byte[] prop_4 { get; private set; }

		// Token: 0x060001BF RID: 447 RVA: 0x0000F030 File Offset: 0x0000D230
		public void smethod_230()
		{
			SHA1CryptoServiceProvider sha1CryptoServiceProvider = new SHA1CryptoServiceProvider();
			byte[] array = new byte[this.prop_0.Length + this.prop_1.Length];
			Array.Copy(this.prop_0, 0, array, 0, this.prop_0.Length);
			Array.Copy(this.prop_1, 0, array, this.prop_0.Length, this.prop_1.Length);
			byte[] array2 = sha1CryptoServiceProvider.ComputeHash(array);
			byte[] array3 = new byte[array2.Length + this.prop_2.Length];
			Array.Copy(array2, 0, array3, 0, array2.Length);
			Array.Copy(this.prop_2, 0, array3, array2.Length, this.prop_2.Length);
			byte[] key = sha1CryptoServiceProvider.ComputeHash(array3);
			byte[] array4 = new byte[20];
			Array.Copy(this.prop_2, 0, array4, 0, this.prop_2.Length);
			for (int i = this.prop_2.Length; i < 20; i++)
			{
				array4[i] = 0;
			}
			byte[] array5 = new byte[array4.Length + this.prop_2.Length];
			Array.Copy(array4, 0, array5, 0, array4.Length);
			Array.Copy(this.prop_2, 0, array5, array4.Length, this.prop_2.Length);
			byte[] array6;
			byte[] array9;
			using (HMACSHA1 hmacsha = new HMACSHA1(key))
			{
				array6 = hmacsha.ComputeHash(array5);
				byte[] array7 = hmacsha.ComputeHash(array4);
				byte[] array8 = new byte[array7.Length + this.prop_2.Length];
				Array.Copy(array7, 0, array8, 0, array7.Length);
				Array.Copy(this.prop_2, 0, array8, array7.Length, this.prop_2.Length);
				array9 = hmacsha.ComputeHash(array8);
			}
			byte[] array10 = new byte[array6.Length + array9.Length];
			Array.Copy(array6, 0, array10, 0, array6.Length);
			Array.Copy(array9, 0, array10, array6.Length, array9.Length);
			this.prop_3 = new byte[24];
			for (int j = 0; j < this.prop_3.Length; j++)
			{
				this.prop_3[j] = array10[j];
			}
			this.prop_4 = new byte[8];
			int num = this.prop_4.Length - 1;
			for (int k = array10.Length - 1; k >= array10.Length - this.prop_4.Length; k--)
			{
				this.prop_4[num] = array10[k];
				num--;
			}
		}

		// Token: 0x0400011A RID: 282
		[CompilerGenerated]
		private readonly byte[] field_0;

		// Token: 0x0400011B RID: 283
		[CompilerGenerated]
		private readonly byte[] field_1;

		// Token: 0x0400011C RID: 284
		[CompilerGenerated]
		private readonly byte[] field_2;

		// Token: 0x0400011D RID: 285
		[CompilerGenerated]
		private byte[] field_3;

		// Token: 0x0400011E RID: 286
		[CompilerGenerated]
		private byte[] field_4;
	}
}
