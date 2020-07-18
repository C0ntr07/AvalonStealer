using System;
using System.Globalization;
using System.IO;
using System.Numerics;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x02000198 RID: 408
	public class Class_297 : Class_296
	{
		// Token: 0x17000284 RID: 644
		// (get) Token: 0x06000BB3 RID: 2995 RVA: 0x00042057 File Offset: 0x00040257
		// (set) Token: 0x06000BB4 RID: 2996 RVA: 0x00042064 File Offset: 0x00040264
		public new DateTimeKind prop_0
		{
			get
			{
				return this.field_0.prop_0;
			}
			set
			{
				this.field_0.prop_0 = value;
			}
		}

		// Token: 0x06000BB5 RID: 2997 RVA: 0x00042072 File Offset: 0x00040272
		public Class_297(Stream stream_)
		{
			Class_517.ArgumentNotNull(stream_, "stream");
			this.field_0 = new Class_284(new BinaryWriter(stream_));
		}

		// Token: 0x06000BB6 RID: 2998 RVA: 0x00042096 File Offset: 0x00040296
		public Class_297(BinaryWriter arg_0)
		{
			Class_517.ArgumentNotNull(arg_0, "writer");
			this.field_0 = new Class_284(arg_0);
		}

		// Token: 0x06000BB7 RID: 2999 RVA: 0x000420B5 File Offset: 0x000402B5
		public virtual void xmethod_2091()
		{
			this.field_0.lmethod_1848();
		}

		// Token: 0x06000BB8 RID: 3000 RVA: 0x000420C2 File Offset: 0x000402C2
		protected virtual void tmethod_2092(Class_508 arg_0)
		{
			base.lmethod_2028(arg_0);
			this.tmethod_2102();
			if (base.prop_1 == 0)
			{
				this.field_0.smethod_1850(this.field_1);
			}
		}

		// Token: 0x06000BB9 RID: 3001 RVA: 0x000420ED File Offset: 0x000402ED
		public virtual void gmethod_2093(string str_0)
		{
			throw Class_413.smethod_3090(this, "Cannot write JSON comment as BSON.", null);
		}

		// Token: 0x06000BBA RID: 3002 RVA: 0x000420FB File Offset: 0x000402FB
		public virtual void cmethod_2094(string str_0)
		{
			throw Class_413.smethod_3090(this, "Cannot write JSON constructor as BSON.", null);
		}

		// Token: 0x06000BBB RID: 3003 RVA: 0x00042109 File Offset: 0x00040309
		public virtual void vmethod_2095(string str_0)
		{
			throw Class_413.smethod_3090(this, "Cannot write raw JSON as BSON.", null);
		}

		// Token: 0x06000BBC RID: 3004 RVA: 0x00042109 File Offset: 0x00040309
		public virtual void dmethod_2096(string str_0)
		{
			throw Class_413.smethod_3090(this, "Cannot write raw JSON as BSON.", null);
		}

		// Token: 0x06000BBD RID: 3005 RVA: 0x00042117 File Offset: 0x00040317
		public virtual void kmethod_2097()
		{
			base.pmethod_2009();
			this.xmethod_2101(new Class_289());
		}

		// Token: 0x06000BBE RID: 3006 RVA: 0x0004212A File Offset: 0x0004032A
		public virtual void lmethod_2098()
		{
			base.kmethod_2007();
			this.xmethod_2101(new Class_288());
		}

		// Token: 0x06000BBF RID: 3007 RVA: 0x0004213D File Offset: 0x0004033D
		public virtual void pmethod_2099(string str_0)
		{
			base.gmethod_2013(str_0);
			this.field_3 = str_0;
		}

		// Token: 0x06000BC0 RID: 3008 RVA: 0x0004214D File Offset: 0x0004034D
		public virtual void smethod_2100()
		{
			base.dmethod_2006();
			if (base.prop_0 && this.field_0 != null)
			{
				this.field_0.pmethod_1849();
			}
		}

		// Token: 0x06000BC1 RID: 3009 RVA: 0x00042176 File Offset: 0x00040376
		private void xmethod_2101(Class_287 arg_0)
		{
			this.cmethod_2104(arg_0);
			this.field_2 = arg_0;
		}

		// Token: 0x06000BC2 RID: 3010 RVA: 0x00042186 File Offset: 0x00040386
		private void tmethod_2102()
		{
			this.field_2 = this.field_2.prop_1;
		}

		// Token: 0x06000BC3 RID: 3011 RVA: 0x00042199 File Offset: 0x00040399
		private void gmethod_2103(object obje_0, Class_295 arg_0)
		{
			this.cmethod_2104(new Class_290(obje_0, arg_0));
		}

		// Token: 0x06000BC4 RID: 3012 RVA: 0x000421A8 File Offset: 0x000403A8
		internal void cmethod_2104(Class_287 arg_0)
		{
			if (this.field_2 != null)
			{
				if (this.field_2 is Class_288)
				{
					((Class_288)this.field_2).cmethod_1954(this.field_3, arg_0);
					this.field_3 = null;
					return;
				}
				((Class_289)this.field_2).lmethod_1958(arg_0);
				return;
			}
			else
			{
				if (arg_0.prop_0 != Class_295.Object && arg_0.prop_0 != Class_295.Array)
				{
					throw Class_413.smethod_3090(this, "Error writing {0} value. BSON must start with an Object or Array.".FormatWith(CultureInfo.InvariantCulture, arg_0.prop_0), null);
				}
				this.field_2 = arg_0;
				this.field_1 = arg_0;
				return;
			}
		}

		// Token: 0x06000BC5 RID: 3013 RVA: 0x0004224C File Offset: 0x0004044C
		public virtual void vmethod_2105(object obje_0)
		{
			if (obje_0 is BigInteger)
			{
				base.dmethod_2086(Class_508.Integer);
				this.cmethod_2104(new Class_292(((BigInteger)obje_0).ToByteArray(), Class_283.Binary));
				return;
			}
			base.cmethod_2074(obje_0);
		}

		// Token: 0x06000BC6 RID: 3014 RVA: 0x0004228D File Offset: 0x0004048D
		public virtual void dmethod_2106()
		{
			base.gmethod_2033();
			this.gmethod_2103(null, Class_295.Null);
		}

		// Token: 0x06000BC7 RID: 3015 RVA: 0x0004229E File Offset: 0x0004049E
		public virtual void kmethod_2107()
		{
			base.cmethod_2034();
			this.gmethod_2103(null, Class_295.Undefined);
		}

		// Token: 0x06000BC8 RID: 3016 RVA: 0x000422AE File Offset: 0x000404AE
		public virtual void lmethod_2108(string str_0)
		{
			base.kmethod_2037(str_0);
			if (str_0 == null)
			{
				this.gmethod_2103(null, Class_295.Null);
				return;
			}
			this.cmethod_2104(new Class_291(str_0, true));
		}

		// Token: 0x06000BC9 RID: 3017 RVA: 0x000422D4 File Offset: 0x000404D4
		public virtual void pmethod_2109(int sayıInt_0)
		{
			base.lmethod_2038(sayıInt_0);
			this.gmethod_2103(sayıInt_0, Class_295.Integer);
		}

		// Token: 0x06000BCA RID: 3018 RVA: 0x000422EB File Offset: 0x000404EB
		[CLSCompliant(false)]
		public virtual void smethod_2110(uint arg_0)
		{
			if (arg_0 > 2147483647U)
			{
				throw Class_413.smethod_3090(this, "Value is too large to fit in a signed 32 bit integer. BSON does not support unsigned values.", null);
			}
			base.pmethod_2039(arg_0);
			this.gmethod_2103(arg_0, Class_295.Integer);
		}

		// Token: 0x06000BCB RID: 3019 RVA: 0x0004231A File Offset: 0x0004051A
		public virtual void xmethod_2111(long sayıUınt_0)
		{
			base.smethod_2040(sayıUınt_0);
			this.gmethod_2103(sayıUınt_0, Class_295.Long);
		}

		// Token: 0x06000BCC RID: 3020 RVA: 0x00042331 File Offset: 0x00040531
		[CLSCompliant(false)]
		public virtual void tmethod_2112(ulong arg_0)
		{
			if (arg_0 > 9223372036854775807UL)
			{
				throw Class_413.smethod_3090(this, "Value is too large to fit in a signed 64 bit integer. BSON does not support unsigned values.", null);
			}
			base.xmethod_2041(arg_0);
			this.gmethod_2103(arg_0, Class_295.Long);
		}

		// Token: 0x06000BCD RID: 3021 RVA: 0x00042364 File Offset: 0x00040564
		public virtual void gmethod_2113(float arg_0)
		{
			base.tmethod_2042(arg_0);
			this.gmethod_2103(arg_0, Class_295.Number);
		}

		// Token: 0x06000BCE RID: 3022 RVA: 0x0004237A File Offset: 0x0004057A
		public virtual void cmethod_2114(double double_0)
		{
			base.gmethod_2043(double_0);
			this.gmethod_2103(double_0, Class_295.Number);
		}

		// Token: 0x06000BCF RID: 3023 RVA: 0x00042390 File Offset: 0x00040590
		public virtual void vmethod_2115(bool bool_0)
		{
			base.cmethod_2044(bool_0);
			this.gmethod_2103(bool_0, Class_295.Boolean);
		}

		// Token: 0x06000BD0 RID: 3024 RVA: 0x000423A6 File Offset: 0x000405A6
		public virtual void dmethod_2116(short sayıShort_0)
		{
			base.vmethod_2045(sayıShort_0);
			this.gmethod_2103(sayıShort_0, Class_295.Integer);
		}

		// Token: 0x06000BD1 RID: 3025 RVA: 0x000423BD File Offset: 0x000405BD
		[CLSCompliant(false)]
		public virtual void kmethod_2117(ushort arg_0)
		{
			base.dmethod_2046(arg_0);
			this.gmethod_2103(arg_0, Class_295.Integer);
		}

		// Token: 0x06000BD2 RID: 3026 RVA: 0x000423D4 File Offset: 0x000405D4
		public virtual void lmethod_2118(char char_0)
		{
			base.kmethod_2047(char_0);
			string obje_ = char_0.ToString(CultureInfo.InvariantCulture);
			this.cmethod_2104(new Class_291(obje_, true));
		}

		// Token: 0x06000BD3 RID: 3027 RVA: 0x00042404 File Offset: 0x00040604
		public virtual void pmethod_2119(byte byte_0)
		{
			base.lmethod_2048(byte_0);
			this.gmethod_2103(byte_0, Class_295.Integer);
		}

		// Token: 0x06000BD4 RID: 3028 RVA: 0x0004241B File Offset: 0x0004061B
		[CLSCompliant(false)]
		public virtual void smethod_2120(sbyte arg_0)
		{
			base.pmethod_2049(arg_0);
			this.gmethod_2103(arg_0, Class_295.Integer);
		}

		// Token: 0x06000BD5 RID: 3029 RVA: 0x00042432 File Offset: 0x00040632
		public virtual void xmethod_2121(decimal arg_0)
		{
			base.smethod_2050(arg_0);
			this.gmethod_2103(arg_0, Class_295.Number);
		}

		// Token: 0x06000BD6 RID: 3030 RVA: 0x00042448 File Offset: 0x00040648
		public virtual void tmethod_2122(DateTime arg_0)
		{
			base.xmethod_2051(arg_0);
			arg_0 = Class_502.EnsureDateTime(arg_0, base.prop_7);
			this.gmethod_2103(arg_0, Class_295.Date);
		}

		// Token: 0x06000BD7 RID: 3031 RVA: 0x0004246D File Offset: 0x0004066D
		public virtual void gmethod_2123(DateTimeOffset arg_0)
		{
			base.tmethod_2052(arg_0);
			this.gmethod_2103(arg_0, Class_295.Date);
		}

		// Token: 0x06000BD8 RID: 3032 RVA: 0x00042484 File Offset: 0x00040684
		public virtual void cmethod_2124(byte[] byteDizi_0)
		{
			base.tmethod_2072(byteDizi_0);
			this.cmethod_2104(new Class_292(byteDizi_0, Class_283.Binary));
		}

		// Token: 0x06000BD9 RID: 3033 RVA: 0x0004249A File Offset: 0x0004069A
		public virtual void vmethod_2125(Guid arg_0)
		{
			base.gmethod_2053(arg_0);
			this.cmethod_2104(new Class_292(arg_0.ToByteArray(), Class_283.Uuid));
		}

		// Token: 0x06000BDA RID: 3034 RVA: 0x000424B6 File Offset: 0x000406B6
		public virtual void dmethod_2126(TimeSpan arg_0)
		{
			base.cmethod_2054(arg_0);
			this.cmethod_2104(new Class_291(arg_0.ToString(), true));
		}

		// Token: 0x06000BDB RID: 3035 RVA: 0x000424D8 File Offset: 0x000406D8
		public virtual void kmethod_2127(Uri arg_0)
		{
			base.gmethod_2073(arg_0);
			this.cmethod_2104(new Class_291(arg_0.ToString(), true));
		}

		// Token: 0x06000BDC RID: 3036 RVA: 0x000424F3 File Offset: 0x000406F3
		public void lmethod_2128(byte[] byteDizi_0)
		{
			Class_517.ArgumentNotNull(byteDizi_0, "value");
			if (byteDizi_0.Length != 12)
			{
				throw Class_413.smethod_3090(this, "An object id must be 12 bytes", null);
			}
			base.xmethod_2001();
			base.tmethod_2032(Class_508.Undefined);
			this.gmethod_2103(byteDizi_0, Class_295.Oid);
		}

		// Token: 0x06000BDD RID: 3037 RVA: 0x0004252D File Offset: 0x0004072D
		public void pmethod_2129(string str_0, string str_1)
		{
			Class_517.ArgumentNotNull(str_0, "pattern");
			base.xmethod_2001();
			base.tmethod_2032(Class_508.Undefined);
			this.cmethod_2104(new Class_293(str_0, str_1));
		}

		// Token: 0x0400079A RID: 1946
		private readonly Class_284 field_0;

		// Token: 0x0400079B RID: 1947
		private new Class_287 field_1;

		// Token: 0x0400079C RID: 1948
		private Class_287 field_2;

		// Token: 0x0400079D RID: 1949
		private string field_3;
	}
}
