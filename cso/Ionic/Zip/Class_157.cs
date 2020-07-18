using System;
using System.IO;
using System.Security.Cryptography;

namespace Ionic.Zip
{
	// Token: 0x020000C6 RID: 198
	internal class Class_157
	{
		// Token: 0x060003C7 RID: 967 RVA: 0x00018F58 File Offset: 0x00017158
		private Class_157(string str_0, int sayıInt_0)
		{
			this.field_10 = str_0;
			this.field_3 = sayıInt_0;
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x00018F7C File Offset: 0x0001717C
		public static Class_157 kmethod_537(string str_0, int sayıInt_0)
		{
			Class_157 class_ = new Class_157(str_0, sayıInt_0);
			int num = class_.prop_2 / 2;
			class_.field_0 = new byte[num];
			Random random = new Random();
			random.NextBytes(class_.field_0);
			return class_;
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x00018FBC File Offset: 0x000171BC
		public static Class_157 lmethod_538(string str_0, int sayıInt_0, Stream stream_)
		{
			Class_157 class_ = new Class_157(str_0, sayıInt_0);
			int num = class_.prop_2 / 2;
			class_.field_0 = new byte[num];
			class_.field_1 = new byte[2];
			stream_.Read(class_.field_0, 0, class_.field_0.Length);
			stream_.Read(class_.field_1, 0, class_.field_1.Length);
			class_.field_7 = (short)((int)class_.field_1[0] + (int)class_.field_1[1] * 256);
			if (str_0 != null)
			{
				class_.field_8 = (short)((int)class_.prop_0[0] + (int)class_.prop_0[1] * 256);
				if (class_.field_8 != class_.field_7)
				{
					throw new Class_136("bad password");
				}
			}
			return class_;
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060003CA RID: 970 RVA: 0x0001907D File Offset: 0x0001727D
		public byte[] prop_0
		{
			get
			{
				if (!this.field_11)
				{
					this.vmethod_545();
				}
				return this.field_2;
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060003CB RID: 971 RVA: 0x00019096 File Offset: 0x00017296
		public byte[] prop_1
		{
			get
			{
				return this.field_0;
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060003CC RID: 972 RVA: 0x0001909E File Offset: 0x0001729E
		private int prop_2
		{
			get
			{
				return this.field_3 / 8;
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060003CD RID: 973 RVA: 0x000190A8 File Offset: 0x000172A8
		public int prop_3
		{
			get
			{
				return this.prop_2 / 2 + 10 + 2;
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060003CF RID: 975 RVA: 0x0001910C File Offset: 0x0001730C
		// (set) Token: 0x060003CE RID: 974 RVA: 0x000190B8 File Offset: 0x000172B8
		public string prop_4
		{
			private get
			{
				return this.field_10;
			}
			set
			{
				this.field_10 = value;
				if (this.field_10 != null)
				{
					this.field_8 = (short)((int)this.prop_0[0] + (int)this.prop_0[1] * 256);
					if (this.field_8 != this.field_7)
					{
						throw new Class_136();
					}
				}
			}
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x00019114 File Offset: 0x00017314
		private void vmethod_545()
		{
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(this.field_10, this.prop_1, this.field_9);
			this.field_6 = rfc2898DeriveBytes.GetBytes(this.prop_2);
			this.field_4 = rfc2898DeriveBytes.GetBytes(this.prop_2);
			this.field_2 = rfc2898DeriveBytes.GetBytes(2);
			this.field_11 = true;
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060003D1 RID: 977 RVA: 0x00019171 File Offset: 0x00017371
		public byte[] prop_5
		{
			get
			{
				if (!this.field_11)
				{
					this.vmethod_545();
				}
				return this.field_6;
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060003D2 RID: 978 RVA: 0x0001918A File Offset: 0x0001738A
		public byte[] prop_6
		{
			get
			{
				if (!this.field_11)
				{
					this.vmethod_545();
				}
				return this.field_4;
			}
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x000191A4 File Offset: 0x000173A4
		public void lmethod_548(Stream stream_)
		{
			bool flag = false;
			this.field_5 = new byte[10];
			stream_.Read(this.field_5, 0, this.field_5.Length);
			if (this.field_5.Length != this.field_12.Length)
			{
				flag = true;
			}
			if (!flag)
			{
				for (int i = 0; i < this.field_5.Length; i++)
				{
					if (this.field_5[i] != this.field_12[i])
					{
						flag = true;
					}
				}
			}
			if (flag)
			{
				throw new Class_140("The MAC does not match.");
			}
		}

		// Token: 0x04000255 RID: 597
		internal byte[] field_0;

		// Token: 0x04000256 RID: 598
		internal byte[] field_1;

		// Token: 0x04000257 RID: 599
		internal byte[] field_2;

		// Token: 0x04000258 RID: 600
		internal int field_3;

		// Token: 0x04000259 RID: 601
		private byte[] field_4;

		// Token: 0x0400025A RID: 602
		private byte[] field_5;

		// Token: 0x0400025B RID: 603
		private byte[] field_6;

		// Token: 0x0400025C RID: 604
		private short field_7;

		// Token: 0x0400025D RID: 605
		private short field_8;

		// Token: 0x0400025E RID: 606
		private int field_9 = 1000;

		// Token: 0x0400025F RID: 607
		private string field_10;

		// Token: 0x04000260 RID: 608
		private bool field_11;

		// Token: 0x04000261 RID: 609
		public byte[] field_12;
	}
}
