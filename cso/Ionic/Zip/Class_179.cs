using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace Ionic.Zip
{
	// Token: 0x020000E3 RID: 227
	internal class Class_179 : Stream
	{
		// Token: 0x0600061D RID: 1565 RVA: 0x00026990 File Offset: 0x00024B90
		private Class_179()
		{
			this.field_1 = false;
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x000269A0 File Offset: 0x00024BA0
		public static Class_179 dmethod_1086(string str_0, uint arg_0, uint arg_1)
		{
			Class_179 class_ = new Class_179
			{
				field_0 = Class_179.NClass_0.field_5,
				prop_1 = arg_0,
				field_7 = arg_1,
				field_2 = str_0
			};
			class_.lmethod_1098();
			return class_;
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x000269D8 File Offset: 0x00024BD8
		public static Class_179 kmethod_1087(string str_0, int sayıInt_0)
		{
			Class_179 class_ = new Class_179
			{
				field_0 = Class_179.NClass_0.field_6,
				prop_1 = 0U,
				field_2 = str_0,
				field_8 = sayıInt_0,
				field_3 = Path.GetDirectoryName(str_0)
			};
			if (class_.field_3 == "")
			{
				class_.field_3 = ".";
			}
			class_.smethod_1100(0U);
			return class_;
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x00026A40 File Offset: 0x00024C40
		public static Stream lmethod_1088(string str_0, uint arg_0)
		{
			if (arg_0 >= 99U)
			{
				throw new ArgumentOutOfRangeException("diskNumber");
			}
			string path = string.Format("{0}.z{1:D2}", Path.Combine(Path.GetDirectoryName(str_0), Path.GetFileNameWithoutExtension(str_0)), arg_0 + 1U);
			return File.Open(path, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x06000621 RID: 1569 RVA: 0x00026A8D File Offset: 0x00024C8D
		// (set) Token: 0x06000622 RID: 1570 RVA: 0x00026A95 File Offset: 0x00024C95
		public bool prop_0 { get; set; }

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x06000623 RID: 1571 RVA: 0x00026A9E File Offset: 0x00024C9E
		// (set) Token: 0x06000624 RID: 1572 RVA: 0x00026AA6 File Offset: 0x00024CA6
		public uint prop_1
		{
			get
			{
				return this.field_6;
			}
			private set
			{
				this.field_6 = value;
				this.field_4 = null;
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x06000625 RID: 1573 RVA: 0x00026AB6 File Offset: 0x00024CB6
		public string prop_2
		{
			get
			{
				if (this.field_4 == null)
				{
					this.field_4 = this.vmethod_1095(this.prop_1);
				}
				return this.field_4;
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x06000626 RID: 1574 RVA: 0x00026ADB File Offset: 0x00024CDB
		public string prop_3
		{
			get
			{
				return this.field_5;
			}
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x00026AE4 File Offset: 0x00024CE4
		private string vmethod_1095(uint arg_0)
		{
			if (arg_0 >= 99U)
			{
				this.field_1 = true;
				throw new OverflowException("The number of zip segments would exceed 99.");
			}
			return string.Format("{0}.z{1:D2}", Path.Combine(Path.GetDirectoryName(this.field_2), Path.GetFileNameWithoutExtension(this.field_2)), arg_0 + 1U);
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x00026B38 File Offset: 0x00024D38
		public uint dmethod_1096(int sayıInt_0)
		{
			if (this.field_9.Position + (long)sayıInt_0 > (long)this.field_8)
			{
				return this.prop_1 + 1U;
			}
			return this.prop_1;
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x00026B64 File Offset: 0x00024D64
		public virtual string kmethod_1097()
		{
			return string.Format("{0}[{1}][{2}], pos=0x{3:X})", new object[]
			{
				"ZipSegmentedStream",
				this.prop_2,
				this.field_0.ToString(),
				this.Position
			});
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x00026BB8 File Offset: 0x00024DB8
		private void lmethod_1098()
		{
			if (this.field_9 != null)
			{
				this.field_9.Dispose();
			}
			if (this.prop_1 + 1U == this.field_7)
			{
				this.field_4 = this.field_2;
			}
			this.field_9 = File.OpenRead(this.prop_2);
		}

		// Token: 0x0600062B RID: 1579 RVA: 0x00026C0C File Offset: 0x00024E0C
		public virtual int pmethod_1099(byte[] byteDizi_0, int sayıInt_0, int sayıInt_1)
		{
			if (this.field_0 != Class_179.NClass_0.field_5)
			{
				this.field_1 = true;
				throw new InvalidOperationException("Stream Error: Cannot Read.");
			}
			int num = this.field_9.Read(byteDizi_0, sayıInt_0, sayıInt_1);
			int num2 = num;
			while (num2 != sayıInt_1)
			{
				if (this.field_9.Position != this.field_9.Length)
				{
					this.field_1 = true;
					throw new Class_135(string.Format("Read error in file {0}", this.prop_2));
				}
				if (this.prop_1 + 1U == this.field_7)
				{
					return num;
				}
				this.prop_1 += 1U;
				this.lmethod_1098();
				sayıInt_0 += num2;
				sayıInt_1 -= num2;
				num2 = this.field_9.Read(byteDizi_0, sayıInt_0, sayıInt_1);
				num += num2;
			}
			return num;
		}

		// Token: 0x0600062C RID: 1580 RVA: 0x00026CD4 File Offset: 0x00024ED4
		private void smethod_1100(uint arg_0)
		{
			if (this.field_9 != null)
			{
				this.field_9.Dispose();
				if (File.Exists(this.prop_2))
				{
					File.Delete(this.prop_2);
				}
				File.Move(this.field_5, this.prop_2);
			}
			if (arg_0 > 0U)
			{
				this.prop_1 += arg_0;
			}
			Class_155.CreateAndOpenUniqueTempFile(this.field_3, out this.field_9, out this.field_5);
			if (this.prop_1 == 0U)
			{
				this.field_9.Write(BitConverter.GetBytes(134695760), 0, 4);
			}
		}

		// Token: 0x0600062D RID: 1581 RVA: 0x00026D74 File Offset: 0x00024F74
		public virtual void xmethod_1101(byte[] byteDizi_0, int sayıInt_0, int sayıInt_1)
		{
			if (this.field_0 != Class_179.NClass_0.field_6)
			{
				this.field_1 = true;
				throw new InvalidOperationException("Stream Error: Cannot Write.");
			}
			if (this.prop_0)
			{
				if (this.field_9.Position + (long)sayıInt_1 > (long)this.field_8)
				{
					this.smethod_1100(1U);
				}
			}
			else
			{
				while (this.field_9.Position + (long)sayıInt_1 > (long)this.field_8)
				{
					int num = this.field_8 - (int)this.field_9.Position;
					this.field_9.Write(byteDizi_0, sayıInt_0, num);
					this.smethod_1100(1U);
					sayıInt_1 -= num;
					sayıInt_0 += num;
				}
			}
			this.field_9.Write(byteDizi_0, sayıInt_0, sayıInt_1);
		}

		// Token: 0x0600062E RID: 1582 RVA: 0x00026E28 File Offset: 0x00025028
		public long tmethod_1102(uint arg_0, long sayıUınt_0)
		{
			if (arg_0 >= 99U)
			{
				throw new ArgumentOutOfRangeException("diskNumber");
			}
			if (this.field_0 != Class_179.NClass_0.field_6)
			{
				this.field_1 = true;
				throw new Class_135("bad state.");
			}
			if (arg_0 == this.prop_1)
			{
				return this.field_9.Seek(sayıUınt_0, SeekOrigin.Begin);
			}
			if (this.field_9 != null)
			{
				this.field_9.Dispose();
				if (File.Exists(this.field_5))
				{
					File.Delete(this.field_5);
				}
			}
			for (uint num = this.prop_1 - 1U; num > arg_0; num -= 1U)
			{
				string path = this.vmethod_1095(num);
				if (File.Exists(path))
				{
					File.Delete(path);
				}
			}
			this.prop_1 = arg_0;
			for (int i = 0; i < 3; i++)
			{
				try
				{
					this.field_5 = Class_155.InternalGetTempFileName();
					File.Move(this.prop_2, this.field_5);
					break;
				}
				catch (IOException)
				{
					if (i == 2)
					{
						throw;
					}
				}
			}
			this.field_9 = new FileStream(this.field_5, FileMode.Open);
			return this.field_9.Seek(sayıUınt_0, SeekOrigin.Begin);
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x0600062F RID: 1583 RVA: 0x00026F5C File Offset: 0x0002515C
		public virtual bool prop_4
		{
			get
			{
				return this.field_0 == Class_179.NClass_0.field_5 && this.field_9 != null && this.field_9.CanRead;
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06000630 RID: 1584 RVA: 0x00026F82 File Offset: 0x00025182
		public virtual bool prop_5
		{
			get
			{
				return this.field_9 != null && this.field_9.CanSeek;
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x06000631 RID: 1585 RVA: 0x00026F9C File Offset: 0x0002519C
		public virtual bool prop_6
		{
			get
			{
				return this.field_0 == Class_179.NClass_0.field_6 && this.field_9 != null && this.field_9.CanWrite;
			}
		}

		// Token: 0x06000632 RID: 1586 RVA: 0x00026FC2 File Offset: 0x000251C2
		public virtual void dmethod_1106()
		{
			this.field_9.Flush();
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x06000633 RID: 1587 RVA: 0x00026FCF File Offset: 0x000251CF
		public virtual long prop_7
		{
			get
			{
				return this.field_9.Length;
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x06000634 RID: 1588 RVA: 0x00026FDC File Offset: 0x000251DC
		// (set) Token: 0x06000635 RID: 1589 RVA: 0x00026FE9 File Offset: 0x000251E9
		public virtual long prop_8
		{
			get
			{
				return this.field_9.Position;
			}
			set
			{
				this.field_9.Position = value;
			}
		}

		// Token: 0x06000636 RID: 1590 RVA: 0x00026FF8 File Offset: 0x000251F8
		public virtual long smethod_1110(long sayıUınt_0, SeekOrigin arg_0)
		{
			return this.field_9.Seek(sayıUınt_0, arg_0);
		}

		// Token: 0x06000637 RID: 1591 RVA: 0x00027014 File Offset: 0x00025214
		public virtual void xmethod_1111(long sayıUınt_0)
		{
			if (this.field_0 != Class_179.NClass_0.field_6)
			{
				this.field_1 = true;
				throw new InvalidOperationException();
			}
			this.field_9.SetLength(sayıUınt_0);
		}

		// Token: 0x06000638 RID: 1592 RVA: 0x0002703C File Offset: 0x0002523C
		protected virtual void tmethod_1112(bool bool_0)
		{
			try
			{
				if (this.field_9 != null)
				{
					this.field_9.Dispose();
					if (this.field_0 == Class_179.NClass_0.field_6)
					{
						bool flag = this.field_1;
					}
				}
			}
			finally
			{
				base.Dispose(bool_0);
			}
		}

		// Token: 0x04000397 RID: 919
		private Class_179.NClass_0 field_0;

		// Token: 0x04000398 RID: 920
		private bool field_1;

		// Token: 0x04000399 RID: 921
		private string field_2;

		// Token: 0x0400039A RID: 922
		private string field_3;

		// Token: 0x0400039B RID: 923
		private string field_4;

		// Token: 0x0400039C RID: 924
		private string field_5;

		// Token: 0x0400039D RID: 925
		private uint field_6;

		// Token: 0x0400039E RID: 926
		private uint field_7;

		// Token: 0x0400039F RID: 927
		private int field_8;

		// Token: 0x040003A0 RID: 928
		private Stream field_9;

		// Token: 0x040003A1 RID: 929
		[CompilerGenerated]
		private bool field_10;

		// Token: 0x020000E4 RID: 228
		private enum NClass_0
		{
			// Token: 0x040003A3 RID: 931
			field_4,
			// Token: 0x040003A4 RID: 932
			field_5,
			// Token: 0x040003A5 RID: 933
			field_6
		}
	}
}
