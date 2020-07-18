using System;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

namespace \u030E\u0360\u0313\u034E\u0315\u0E47\u0020\u0305\u035C\u0351\u0E47\u0351\u0320\u0301\u036B\u0300zcryfxllszuahcty\u0347\u0334\u0342\u0E47\u0310\u032C\u0358\u0340\u036B\u0331\u0329\u036B\u0340\u032F\u0308\u0E47cexuwlosbhsreyjl
{
	// Token: 0x02000080 RID: 128
	public class Class_101 : Class_103
	{
		// Token: 0x0600025C RID: 604 RVA: 0x00013050 File Offset: 0x00011250
		public Class_101(bool bool_0)
		{
			this.field_2 = bool_0;
		}

		// Token: 0x0600025D RID: 605 RVA: 0x0001306F File Offset: 0x0001126F
		public Class_101(byte byte_0)
		{
			this.field_2 = byte_0;
		}

		// Token: 0x0600025E RID: 606 RVA: 0x0001308E File Offset: 0x0001128E
		public Class_101(char char_0)
		{
			this.field_2 = char_0;
		}

		// Token: 0x0600025F RID: 607 RVA: 0x000130AD File Offset: 0x000112AD
		public Class_101(decimal arg_0)
		{
			this.field_2 = arg_0;
		}

		// Token: 0x06000260 RID: 608 RVA: 0x000130CC File Offset: 0x000112CC
		public Class_101(double double_0)
		{
			this.field_2 = double_0;
		}

		// Token: 0x06000261 RID: 609 RVA: 0x000130EB File Offset: 0x000112EB
		public Class_101(float arg_0)
		{
			this.field_2 = arg_0;
		}

		// Token: 0x06000262 RID: 610 RVA: 0x0001310A File Offset: 0x0001130A
		public Class_101(int sayıInt_0)
		{
			this.field_2 = sayıInt_0;
		}

		// Token: 0x06000263 RID: 611 RVA: 0x00013129 File Offset: 0x00011329
		public Class_101(long sayıUınt_0)
		{
			this.field_2 = sayıUınt_0;
		}

		// Token: 0x06000264 RID: 612 RVA: 0x00013148 File Offset: 0x00011348
		public Class_101(sbyte arg_0)
		{
			this.field_2 = arg_0;
		}

		// Token: 0x06000265 RID: 613 RVA: 0x00013167 File Offset: 0x00011367
		public Class_101(short sayıShort_0)
		{
			this.field_2 = sayıShort_0;
		}

		// Token: 0x06000266 RID: 614 RVA: 0x00013186 File Offset: 0x00011386
		public Class_101(string str_0)
		{
			this.field_2 = str_0;
		}

		// Token: 0x06000267 RID: 615 RVA: 0x000131A0 File Offset: 0x000113A0
		public Class_101(DateTime arg_0)
		{
			this.field_2 = arg_0;
		}

		// Token: 0x06000268 RID: 616 RVA: 0x000131BF File Offset: 0x000113BF
		public Class_101(uint arg_0)
		{
			this.field_2 = arg_0;
		}

		// Token: 0x06000269 RID: 617 RVA: 0x000131DE File Offset: 0x000113DE
		public Class_101(ulong arg_0)
		{
			this.field_2 = arg_0;
		}

		// Token: 0x0600026A RID: 618 RVA: 0x000131FD File Offset: 0x000113FD
		public Class_101(ushort arg_0)
		{
			this.field_2 = arg_0;
		}

		// Token: 0x0600026B RID: 619 RVA: 0x0001321C File Offset: 0x0001141C
		public Class_101(DateTimeOffset arg_0)
		{
			this.field_2 = arg_0;
		}

		// Token: 0x0600026C RID: 620 RVA: 0x0001323B File Offset: 0x0001143B
		public Class_101(Guid arg_0)
		{
			this.field_2 = arg_0;
		}

		// Token: 0x0600026D RID: 621 RVA: 0x0001325A File Offset: 0x0001145A
		public Class_101(TimeSpan arg_0)
		{
			this.field_2 = arg_0;
		}

		// Token: 0x0600026E RID: 622 RVA: 0x00013186 File Offset: 0x00011386
		public Class_101(Uri arg_0)
		{
			this.field_2 = arg_0;
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x0600026F RID: 623 RVA: 0x00013279 File Offset: 0x00011479
		public new object prop_0 { get; }

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000270 RID: 624 RVA: 0x0001328C File Offset: 0x0001148C
		public virtual Class_102 prop_1
		{
			get
			{
				if (this.prop_0 == null)
				{
					return Class_102.\u032F\u0020\u0357\u030E\u0345\u0317\u032Ec\u033A\u030D\u0489\u033A\u0E47\u031A\u0489\u034Biuprkicuzyilcxpb\u0020\u0354\u0341\u0342\u0306\u0331\u0363\u0316\u035A\u0345\u0316\u0320\u0324\u035D\u0020\u0359byltzgwaywognczj;
				}
				TypeCode typeCode = Type.GetTypeCode(this.prop_0.GetType());
				switch (typeCode)
				{
				case TypeCode.Object:
				case TypeCode.Char:
					break;
				case TypeCode.DBNull:
					return Class_102.\u0301\u0325\u0342\u036B\u0356\u0367\u0337\u0349\u034D\u0353\u0349\u0359\u0368\u030C\u0020\u035Bsumheyrskoaxhywu\u0E47\u0331\u0332\u0308\u0368\u0320\u0356\u034E\u0346\u031F\u0347\u0324\u035A\u034A\u0E47\u0331tdekmrgabhtbpfpl;
				case TypeCode.Boolean:
					return Class_102.\u031D\u0320\u033A\u0359\u0020\u032B\u036F\u030E\u034E\u032A\u0020\u0E47\u036D\u035E\u0357\u036Bbuinszyvshdxival\u0331\u033A\u0020t\u0E47\u034D\u033F\u0320\u0020\u0313\u0320\u0324\u034A\u0331\u0317\u0365rdmtbdisonjupbxu;
				default:
					if (typeCode != TypeCode.DateTime && typeCode != TypeCode.String)
					{
						return Class_102.\u0301\u0325\u0342\u036B\u0356\u0367\u0337\u0349\u034D\u0353\u0349\u0359\u0368\u030C\u0020\u035Bsumheyrskoaxhywu\u0E47\u0331\u0332\u0308\u0368\u0320\u0356\u034E\u0346\u031F\u0347\u0324\u035A\u034A\u0E47\u0331tdekmrgabhtbpfpl;
					}
					break;
				}
				return Class_102.\u032F\u0020\u0357\u030E\u0345\u0317\u032Ec\u033A\u030D\u0489\u033A\u0E47\u031A\u0489\u034Biuprkicuzyilcxpb\u0020\u0354\u0341\u0342\u0306\u0331\u0363\u0316\u035A\u0345\u0316\u0320\u0324\u035D\u0020\u0359byltzgwaywognczj;
			}
		}

		// Token: 0x06000271 RID: 625 RVA: 0x000132F4 File Offset: 0x000114F4
		public virtual void kmethod_317(Stream stream_, bool bool_0)
		{
			Class_102 class_ = this.prop_0;
			if (class_ == Class_102.\u032F\u0020\u0357\u030E\u0345\u0317\u032Ec\u033A\u030D\u0489\u033A\u0E47\u031A\u0489\u034Biuprkicuzyilcxpb\u0020\u0354\u0341\u0342\u0306\u0331\u0363\u0316\u035A\u0345\u0316\u0320\u0324\u035D\u0020\u0359byltzgwaywognczj)
			{
				stream_.WriteByte(34);
				byte[] bytes = Encoding.UTF8.GetBytes(base.vmethod_335(this.prop_0.ToString()));
				stream_.Write(bytes, 0, bytes.Length);
				stream_.WriteByte(34);
				return;
			}
			if (class_ != Class_102.\u031D\u0320\u033A\u0359\u0020\u032B\u036F\u030E\u034E\u032A\u0020\u0E47\u036D\u035E\u0357\u036Bbuinszyvshdxival\u0331\u033A\u0020t\u0E47\u034D\u033F\u0320\u0020\u0313\u0320\u0324\u034A\u0331\u0317\u0365rdmtbdisonjupbxu)
			{
				byte[] bytes2 = Encoding.UTF8.GetBytes(this.lmethod_318());
				stream_.Write(bytes2, 0, bytes2.Length);
				return;
			}
			if ((bool)this.prop_0)
			{
				stream_.Write(Class_101.field_0, 0, 4);
				return;
			}
			stream_.Write(Class_101.field_1, 0, 5);
		}

		// Token: 0x06000272 RID: 626 RVA: 0x000133A0 File Offset: 0x000115A0
		public string lmethod_318()
		{
			Class_102 class_ = this.prop_0;
			if (class_ != Class_102.\u032F\u0020\u0357\u030E\u0345\u0317\u032Ec\u033A\u030D\u0489\u033A\u0E47\u031A\u0489\u034Biuprkicuzyilcxpb\u0020\u0354\u0341\u0342\u0306\u0331\u0363\u0316\u035A\u0345\u0316\u0320\u0324\u035D\u0020\u0359byltzgwaywognczj)
			{
				if (class_ != Class_102.\u0301\u0325\u0342\u036B\u0356\u0367\u0337\u0349\u034D\u0353\u0349\u0359\u0368\u030C\u0020\u035Bsumheyrskoaxhywu\u0E47\u0331\u0332\u0308\u0368\u0320\u0356\u034E\u0346\u031F\u0347\u0324\u035A\u034A\u0E47\u0331tdekmrgabhtbpfpl)
				{
					throw new InvalidOperationException();
				}
				string text = (!(this.prop_0 is float) && !(this.prop_0 is double)) ? ((IFormattable)this.prop_0).ToString("G", NumberFormatInfo.InvariantInfo) : ((IFormattable)this.prop_0).ToString("R", NumberFormatInfo.InvariantInfo);
				if (text == "NaN" || text == "Infinity" || text == "-Infinity")
				{
					return "\"" + text + "\"";
				}
				return text;
			}
			else if (this.prop_0 is string || this.prop_0 == null)
			{
				string text2 = this.prop_0 as string;
				if (string.IsNullOrEmpty(text2))
				{
					return "null";
				}
				return text2.Trim(new char[]
				{
					'"'
				});
			}
			else
			{
				if (this.prop_0 is char)
				{
					return this.prop_0.ToString();
				}
				string str = "GetFormattedString from value type ";
				Type type = this.prop_0.GetType();
				throw new NotImplementedException(str + ((type != null) ? type.ToString() : null));
			}
		}

		// Token: 0x04000183 RID: 387
		private new static readonly byte[] field_0 = Encoding.UTF8.GetBytes("true");

		// Token: 0x04000184 RID: 388
		private static readonly byte[] field_1 = Encoding.UTF8.GetBytes("false");

		// Token: 0x04000185 RID: 389
		[CompilerGenerated]
		private readonly object field_2;
	}
}
