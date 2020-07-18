using System;
using System.IO;
using Ionic.Crc;

namespace Ionic.Zip
{
	// Token: 0x020000C9 RID: 201
	internal class Class_160
	{
		// Token: 0x060003EA RID: 1002 RVA: 0x00019A2C File Offset: 0x00017C2C
		private Class_160()
		{
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x00019A58 File Offset: 0x00017C58
		public static Class_160 pmethod_569(string str_0)
		{
			Class_160 class_ = new Class_160();
			if (str_0 == null)
			{
				throw new Class_136("This entry requires a password.");
			}
			class_.cmethod_574(str_0);
			return class_;
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x00019A84 File Offset: 0x00017C84
		public static Class_160 smethod_570(string str_0, Class_163 arg_0)
		{
			Stream field_ = arg_0.field_58;
			arg_0.field_57 = new byte[12];
			byte[] field_2 = arg_0.field_57;
			Class_160 class_ = new Class_160();
			if (str_0 == null)
			{
				throw new Class_136("This entry requires a password.");
			}
			class_.cmethod_574(str_0);
			Class_163.vmethod_705(field_, field_2);
			byte[] array = class_.tmethod_572(field_2, field_2.Length);
			if (array[11] != (byte)(arg_0.field_34 >> 24 & 255))
			{
				if ((arg_0.field_22 & 8) != 8)
				{
					throw new Class_136("The password did not match.");
				}
				if (array[11] != (byte)(arg_0.field_32 >> 8 & 255))
				{
					throw new Class_136("The password did not match.");
				}
			}
			return class_;
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060003ED RID: 1005 RVA: 0x00019B34 File Offset: 0x00017D34
		private byte prop_0
		{
			get
			{
				ushort num = (ushort)(this.field_0[2] & 65535U) | 2;
				return (byte)(num * num >> 8);
			}
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x00019B5C File Offset: 0x00017D5C
		public byte[] tmethod_572(byte[] byteDizi_0, int sayıInt_0)
		{
			if (byteDizi_0 == null)
			{
				throw new ArgumentNullException("cipherText");
			}
			if (sayıInt_0 > byteDizi_0.Length)
			{
				throw new ArgumentOutOfRangeException("length", "Bad length during Decryption: the length parameter must be smaller than or equal to the size of the destination array.");
			}
			byte[] array = new byte[sayıInt_0];
			for (int i = 0; i < sayıInt_0; i++)
			{
				byte b = byteDizi_0[i] ^ this.prop_0;
				this.vmethod_575(b);
				array[i] = b;
			}
			return array;
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x00019BC4 File Offset: 0x00017DC4
		public byte[] gmethod_573(byte[] byteDizi_0, int sayıInt_0)
		{
			if (byteDizi_0 == null)
			{
				throw new ArgumentNullException("plaintext");
			}
			if (sayıInt_0 > byteDizi_0.Length)
			{
				throw new ArgumentOutOfRangeException("length", "Bad length during Encryption: The length parameter must be smaller than or equal to the size of the destination array.");
			}
			byte[] array = new byte[sayıInt_0];
			for (int i = 0; i < sayıInt_0; i++)
			{
				byte byte_ = byteDizi_0[i];
				array[i] = (byteDizi_0[i] ^ this.prop_0);
				this.vmethod_575(byte_);
			}
			return array;
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x00019C2C File Offset: 0x00017E2C
		public void cmethod_574(string str_0)
		{
			byte[] array = Class_155.StringToByteArray(str_0);
			for (int i = 0; i < str_0.Length; i++)
			{
				this.vmethod_575(array[i]);
			}
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x00019C60 File Offset: 0x00017E60
		private void vmethod_575(byte byte_0)
		{
			this.field_0[0] = (uint)this.field_1.kmethod_1367((int)this.field_0[0], byte_0);
			this.field_0[1] = this.field_0[1] + (uint)((byte)this.field_0[0]);
			this.field_0[1] = this.field_0[1] * 134775813U + 1U;
			this.field_0[2] = (uint)this.field_1.kmethod_1367((int)this.field_0[2], (byte)(this.field_0[1] >> 24));
		}

		// Token: 0x04000280 RID: 640
		private uint[] field_0 = new uint[]
		{
			305419896U,
			591751049U,
			878082192U
		};

		// Token: 0x04000281 RID: 641
		private Class_215 field_1 = new Class_215();
	}
}
