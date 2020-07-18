using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Threading;

namespace Ionic.Zip
{
	// Token: 0x020000C7 RID: 199
	internal class Class_158 : Stream
	{
		// Token: 0x060003D4 RID: 980 RVA: 0x00019231 File Offset: 0x00017431
		internal Class_158(Stream stream_, Class_157 arg_0, long sayıUınt_0, Class_161 arg_1) : this(stream_, arg_0, arg_1)
		{
			this.field_11 = sayıUınt_0;
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x00019244 File Offset: 0x00017444
		internal Class_158(Stream stream_, Class_157 arg_0, Class_161 arg_1)
		{
			this.field_1 = arg_0;
			this.field_2 = stream_;
			this.field_3 = arg_1;
			this.field_4 = 1;
			if (this.field_1 == null)
			{
				throw new Class_136("Supply a password to use AES encryption.");
			}
			int num = this.field_1.prop_5.Length * 8;
			if (num != 256 && num != 128 && num != 192)
			{
				throw new ArgumentOutOfRangeException("keysize", "size of key must be 128, 192, or 256");
			}
			this.field_6 = new HMACSHA1(this.field_1.prop_6);
			this.field_7 = new RijndaelManaged();
			this.field_7.BlockSize = 128;
			this.field_7.KeySize = num;
			this.field_7.Mode = CipherMode.ECB;
			this.field_7.Padding = PaddingMode.None;
			byte[] rgbIV = new byte[16];
			this.field_8 = this.field_7.CreateEncryptor(this.field_1.prop_5, rgbIV);
			if (this.field_3 == Class_161.Encrypt)
			{
				this.field_15 = new byte[2048];
				this.field_13 = new byte[16];
			}
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x00019394 File Offset: 0x00017594
		private void pmethod_549(byte[] byteDizi_0, int sayıInt_0, int sayıInt_1)
		{
			for (int i = 0; i < sayıInt_1; i++)
			{
				byteDizi_0[sayıInt_0 + i] = (this.field_10[i] ^ byteDizi_0[sayıInt_0 + i]);
			}
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x000193C4 File Offset: 0x000175C4
		private void smethod_550(byte[] byteDizi_0, int sayıInt_0)
		{
			Array.Copy(BitConverter.GetBytes(this.field_4++), 0, this.field_9, 0, 4);
			this.field_8.TransformBlock(this.field_9, 0, 16, this.field_10, 0);
			this.pmethod_549(byteDizi_0, sayıInt_0, 16);
			this.field_6.TransformBlock(byteDizi_0, sayıInt_0, 16, null, 0);
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x00019430 File Offset: 0x00017630
		private void xmethod_551(byte[] byteDizi_0, int sayıInt_0, int sayıInt_1)
		{
			int num = sayıInt_0;
			int num2 = sayıInt_1 + sayıInt_0;
			while (num < byteDizi_0.Length && num < num2)
			{
				this.smethod_550(byteDizi_0, num);
				num += 16;
			}
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x00019464 File Offset: 0x00017664
		private void tmethod_552()
		{
			if (this.field_14 == 0)
			{
				throw new InvalidOperationException("No bytes available.");
			}
			if (this.field_5)
			{
				throw new InvalidOperationException("The final block has already been transformed.");
			}
			Array.Copy(BitConverter.GetBytes(this.field_4++), 0, this.field_9, 0, 4);
			this.field_10 = this.field_8.TransformFinalBlock(this.field_9, 0, 16);
			this.pmethod_549(this.field_13, 0, this.field_14);
			this.field_6.TransformFinalBlock(this.field_13, 0, this.field_14);
			this.field_5 = true;
		}

		// Token: 0x060003DA RID: 986 RVA: 0x00019510 File Offset: 0x00017710
		private int gmethod_553(byte[] byteDizi_0, int sayıInt_0, int sayıInt_1)
		{
			if (this.field_5)
			{
				throw new NotSupportedException();
			}
			int num = sayıInt_1 - sayıInt_0;
			int num2 = (num > 16) ? 16 : num;
			Array.Copy(BitConverter.GetBytes(this.field_4++), 0, this.field_9, 0, 4);
			if (num2 == num && this.field_11 > 0L && this.field_12 + (long)sayıInt_1 == this.field_11)
			{
				this.field_6.TransformFinalBlock(byteDizi_0, sayıInt_0, num2);
				this.field_10 = this.field_8.TransformFinalBlock(this.field_9, 0, 16);
				this.field_5 = true;
			}
			else
			{
				this.field_6.TransformBlock(byteDizi_0, sayıInt_0, num2, null, 0);
				this.field_8.TransformBlock(this.field_9, 0, 16, this.field_10, 0);
			}
			this.pmethod_549(byteDizi_0, sayıInt_0, num2);
			return num2;
		}

		// Token: 0x060003DB RID: 987 RVA: 0x000195FC File Offset: 0x000177FC
		private void cmethod_554(byte[] byteDizi_0, int sayıInt_0, int sayıInt_1)
		{
			int num = sayıInt_0;
			int num2 = sayıInt_1 + sayıInt_0;
			while (num < byteDizi_0.Length && num < num2)
			{
				int num3 = this.gmethod_553(byteDizi_0, num, num2);
				num += num3;
			}
		}

		// Token: 0x060003DC RID: 988 RVA: 0x00019630 File Offset: 0x00017830
		public virtual int vmethod_555(byte[] byteDizi_0, int sayıInt_0, int sayıInt_1)
		{
			if (this.field_3 == Class_161.Encrypt)
			{
				throw new NotSupportedException();
			}
			if (byteDizi_0 == null)
			{
				throw new ArgumentNullException("buffer");
			}
			if (sayıInt_0 < 0)
			{
				throw new ArgumentOutOfRangeException("offset", "Must not be less than zero.");
			}
			if (sayıInt_1 < 0)
			{
				throw new ArgumentOutOfRangeException("count", "Must not be less than zero.");
			}
			if (byteDizi_0.Length < sayıInt_0 + sayıInt_1)
			{
				throw new ArgumentException("The buffer is too small");
			}
			int num = sayıInt_1;
			if (this.field_12 >= this.field_11)
			{
				return 0;
			}
			long num2 = this.field_11 - this.field_12;
			if (num2 < (long)sayıInt_1)
			{
				num = (int)num2;
			}
			int num3 = this.field_2.Read(byteDizi_0, sayıInt_0, num);
			this.cmethod_554(byteDizi_0, sayıInt_0, num);
			this.field_12 += (long)num3;
			return num3;
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060003DD RID: 989 RVA: 0x000196FC File Offset: 0x000178FC
		public byte[] prop_0
		{
			get
			{
				if (!this.field_5)
				{
					if (this.field_12 != 0L)
					{
						throw new Class_140("The final hash has not been computed.");
					}
					byte[] buffer = new byte[0];
					this.field_6.ComputeHash(buffer);
				}
				byte[] array = new byte[10];
				Array.Copy(this.field_6.Hash, 0, array, 0, 10);
				return array;
			}
		}

		// Token: 0x060003DE RID: 990 RVA: 0x00019760 File Offset: 0x00017960
		public virtual void kmethod_557(byte[] byteDizi_0, int sayıInt_0, int sayıInt_1)
		{
			if (this.field_5)
			{
				throw new InvalidOperationException("The final block has already been transformed.");
			}
			if (this.field_3 == Class_161.Decrypt)
			{
				throw new NotSupportedException();
			}
			if (byteDizi_0 == null)
			{
				throw new ArgumentNullException("buffer");
			}
			if (sayıInt_0 < 0)
			{
				throw new ArgumentOutOfRangeException("offset", "Must not be less than zero.");
			}
			if (sayıInt_1 < 0)
			{
				throw new ArgumentOutOfRangeException("count", "Must not be less than zero.");
			}
			if (byteDizi_0.Length < sayıInt_0 + sayıInt_1)
			{
				throw new ArgumentException("The offset and count are too large");
			}
			if (sayıInt_1 == 0)
			{
				return;
			}
			if (sayıInt_1 + this.field_14 <= 16)
			{
				Buffer.BlockCopy(byteDizi_0, sayıInt_0, this.field_13, this.field_14, sayıInt_1);
				this.field_14 += sayıInt_1;
				return;
			}
			int num = sayıInt_1;
			int num2 = sayıInt_0;
			if (this.field_14 != 0)
			{
				int num3 = 16 - this.field_14;
				if (num3 > 0)
				{
					Buffer.BlockCopy(byteDizi_0, sayıInt_0, this.field_13, this.field_14, num3);
					num -= num3;
					num2 += num3;
				}
				this.smethod_550(this.field_13, 0);
				this.field_2.Write(this.field_13, 0, 16);
				this.field_12 += 16L;
				this.field_14 = 0;
			}
			int num4 = (num - 1) / 16;
			this.field_14 = num - num4 * 16;
			Buffer.BlockCopy(byteDizi_0, num2 + num - this.field_14, this.field_13, 0, this.field_14);
			num -= this.field_14;
			this.field_12 += (long)num;
			if (num4 > 0)
			{
				do
				{
					int num5 = this.field_15.Length;
					if (num5 > num)
					{
						num5 = num;
					}
					Buffer.BlockCopy(byteDizi_0, num2, this.field_15, 0, num5);
					this.xmethod_551(this.field_15, 0, num5);
					this.field_2.Write(this.field_15, 0, num5);
					num -= num5;
					num2 += num5;
				}
				while (num > 0);
			}
		}

		// Token: 0x060003DF RID: 991 RVA: 0x0001993C File Offset: 0x00017B3C
		public virtual void lmethod_558()
		{
			if (this.field_14 > 0)
			{
				this.tmethod_552();
				this.field_2.Write(this.field_13, 0, this.field_14);
				this.field_12 += (long)this.field_14;
				this.field_14 = 0;
			}
			this.field_2.Close();
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060003E0 RID: 992 RVA: 0x00019999 File Offset: 0x00017B99
		public virtual bool prop_1
		{
			get
			{
				return this.field_3 == Class_161.Decrypt;
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060003E1 RID: 993 RVA: 0x00018464 File Offset: 0x00016664
		public virtual bool prop_2
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060003E2 RID: 994 RVA: 0x000199AA File Offset: 0x00017BAA
		public virtual bool prop_3
		{
			get
			{
				return this.field_3 == Class_161.Encrypt;
			}
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x000199B5 File Offset: 0x00017BB5
		public virtual void tmethod_562()
		{
			this.field_2.Flush();
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x060003E4 RID: 996 RVA: 0x00018443 File Offset: 0x00016643
		public virtual long prop_4
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060003E5 RID: 997 RVA: 0x00018443 File Offset: 0x00016643
		// (set) Token: 0x060003E6 RID: 998 RVA: 0x00018443 File Offset: 0x00016643
		public virtual long prop_5
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x00018443 File Offset: 0x00016643
		public virtual long dmethod_566(long sayıUınt_0, SeekOrigin arg_0)
		{
			throw new NotImplementedException();
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x00018443 File Offset: 0x00016643
		public virtual void kmethod_567(long sayıUınt_0)
		{
			throw new NotImplementedException();
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x000199C4 File Offset: 0x00017BC4
		[Conditional("Trace")]
		private void lmethod_568(string str_0, params object[] arg_0)
		{
			lock (this.field_16)
			{
				int hashCode = Thread.CurrentThread.GetHashCode();
				Console.ForegroundColor = hashCode % 8 + ConsoleColor.DarkGray;
				Console.Write("{0:000} WZACS ", hashCode);
				Console.WriteLine(str_0, arg_0);
				Console.ResetColor();
			}
		}

		// Token: 0x04000262 RID: 610
		private const int field_0 = 16;

		// Token: 0x04000263 RID: 611
		private Class_157 field_1;

		// Token: 0x04000264 RID: 612
		private Stream field_2;

		// Token: 0x04000265 RID: 613
		private Class_161 field_3;

		// Token: 0x04000266 RID: 614
		private int field_4;

		// Token: 0x04000267 RID: 615
		private bool field_5;

		// Token: 0x04000268 RID: 616
		internal HMACSHA1 field_6;

		// Token: 0x04000269 RID: 617
		internal RijndaelManaged field_7;

		// Token: 0x0400026A RID: 618
		internal ICryptoTransform field_8;

		// Token: 0x0400026B RID: 619
		private byte[] field_9 = new byte[16];

		// Token: 0x0400026C RID: 620
		private byte[] field_10 = new byte[16];

		// Token: 0x0400026D RID: 621
		private long field_11;

		// Token: 0x0400026E RID: 622
		private long field_12;

		// Token: 0x0400026F RID: 623
		private byte[] field_13;

		// Token: 0x04000270 RID: 624
		private int field_14;

		// Token: 0x04000271 RID: 625
		private byte[] field_15;

		// Token: 0x04000272 RID: 626
		private object field_16 = new object();
	}
}
