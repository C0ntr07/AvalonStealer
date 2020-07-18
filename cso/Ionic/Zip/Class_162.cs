using System;
using System.IO;

namespace Ionic.Zip
{
	// Token: 0x020000CB RID: 203
	internal class Class_162 : Stream
	{
		// Token: 0x060003F2 RID: 1010 RVA: 0x00019CE2 File Offset: 0x00017EE2
		public Class_162(Stream stream_, Class_160 arg_0, Class_161 arg_1)
		{
			this.field_0 = arg_0;
			this.field_1 = stream_;
			this.field_2 = arg_1;
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x00019D00 File Offset: 0x00017F00
		public virtual int dmethod_576(byte[] byteDizi_0, int sayıInt_0, int sayıInt_1)
		{
			if (this.field_2 == Class_161.Encrypt)
			{
				throw new NotSupportedException("This stream does not encrypt via Read()");
			}
			if (byteDizi_0 == null)
			{
				throw new ArgumentNullException("buffer");
			}
			byte[] array = new byte[sayıInt_1];
			int num = this.field_1.Read(array, 0, sayıInt_1);
			byte[] array2 = this.field_0.tmethod_572(array, num);
			for (int i = 0; i < num; i++)
			{
				byteDizi_0[sayıInt_0 + i] = array2[i];
			}
			return num;
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x00019D70 File Offset: 0x00017F70
		public virtual void kmethod_577(byte[] byteDizi_0, int sayıInt_0, int sayıInt_1)
		{
			if (this.field_2 == Class_161.Decrypt)
			{
				throw new NotSupportedException("This stream does not Decrypt via Write()");
			}
			if (byteDizi_0 == null)
			{
				throw new ArgumentNullException("buffer");
			}
			if (sayıInt_1 == 0)
			{
				return;
			}
			byte[] array;
			if (sayıInt_0 != 0)
			{
				array = new byte[sayıInt_1];
				for (int i = 0; i < sayıInt_1; i++)
				{
					array[i] = byteDizi_0[sayıInt_0 + i];
				}
			}
			else
			{
				array = byteDizi_0;
			}
			byte[] array2 = this.field_0.gmethod_573(array, sayıInt_1);
			this.field_1.Write(array2, 0, array2.Length);
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x060003F5 RID: 1013 RVA: 0x00019DF7 File Offset: 0x00017FF7
		public virtual bool prop_0
		{
			get
			{
				return this.field_2 == Class_161.Decrypt;
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x060003F6 RID: 1014 RVA: 0x00018464 File Offset: 0x00016664
		public virtual bool prop_1
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x060003F7 RID: 1015 RVA: 0x00019E02 File Offset: 0x00018002
		public virtual bool prop_2
		{
			get
			{
				return this.field_2 == Class_161.Encrypt;
			}
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x00002050 File Offset: 0x00000250
		public virtual void xmethod_581()
		{
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x060003F9 RID: 1017 RVA: 0x0001429B File Offset: 0x0001249B
		public virtual long prop_3
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x060003FA RID: 1018 RVA: 0x0001429B File Offset: 0x0001249B
		// (set) Token: 0x060003FB RID: 1019 RVA: 0x0001429B File Offset: 0x0001249B
		public virtual long prop_4
		{
			get
			{
				throw new NotSupportedException();
			}
			set
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x0001429B File Offset: 0x0001249B
		public virtual long vmethod_585(long sayıUınt_0, SeekOrigin arg_0)
		{
			throw new NotSupportedException();
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x0001429B File Offset: 0x0001249B
		public virtual void dmethod_586(long sayıUınt_0)
		{
			throw new NotSupportedException();
		}

		// Token: 0x04000285 RID: 645
		private Class_160 field_0;

		// Token: 0x04000286 RID: 646
		private Stream field_1;

		// Token: 0x04000287 RID: 647
		private Class_161 field_2;
	}
}
