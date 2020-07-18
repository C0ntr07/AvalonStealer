using System;
using System.Globalization;
using System.IO;
using System.Numerics;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x020001DB RID: 475
	internal class Class_355 : Class_296
	{
		// Token: 0x06000D60 RID: 3424 RVA: 0x00048574 File Offset: 0x00046774
		public Class_355(Class_296 arg_0)
		{
			this.field_0 = arg_0;
			this.field_2 = new StringWriter(CultureInfo.InvariantCulture);
			this.field_1 = new Class_412(this.field_2);
			this.field_1.prop_5 = Class_322.Indented;
			this.field_1.prop_11 = arg_0.prop_11;
			this.field_1.prop_6 = arg_0.prop_6;
			this.field_1.prop_10 = arg_0.prop_10;
			this.field_1.prop_7 = arg_0.prop_7;
			this.field_1.prop_9 = arg_0.prop_9;
		}

		// Token: 0x06000D61 RID: 3425 RVA: 0x00048610 File Offset: 0x00046810
		public string smethod_2390()
		{
			return this.field_2.ToString();
		}

		// Token: 0x06000D62 RID: 3426 RVA: 0x0004861D File Offset: 0x0004681D
		public virtual void xmethod_2391(decimal arg_0)
		{
			this.field_1.smethod_2050(arg_0);
			this.field_0.smethod_2050(arg_0);
			base.smethod_2050(arg_0);
		}

		// Token: 0x06000D63 RID: 3427 RVA: 0x0004863E File Offset: 0x0004683E
		public virtual void tmethod_2392(bool bool_0)
		{
			this.field_1.cmethod_2044(bool_0);
			this.field_0.cmethod_2044(bool_0);
			base.cmethod_2044(bool_0);
		}

		// Token: 0x06000D64 RID: 3428 RVA: 0x0004865F File Offset: 0x0004685F
		public virtual void gmethod_2393(byte byte_0)
		{
			this.field_1.lmethod_2048(byte_0);
			this.field_0.lmethod_2048(byte_0);
			base.lmethod_2048(byte_0);
		}

		// Token: 0x06000D65 RID: 3429 RVA: 0x00048680 File Offset: 0x00046880
		public virtual void cmethod_2394(byte? arg_0)
		{
			this.field_1.vmethod_2065(arg_0);
			this.field_0.vmethod_2065(arg_0);
			base.vmethod_2065(arg_0);
		}

		// Token: 0x06000D66 RID: 3430 RVA: 0x000486A1 File Offset: 0x000468A1
		public virtual void vmethod_2395(char char_0)
		{
			this.field_1.kmethod_2047(char_0);
			this.field_0.kmethod_2047(char_0);
			base.kmethod_2047(char_0);
		}

		// Token: 0x06000D67 RID: 3431 RVA: 0x000486C2 File Offset: 0x000468C2
		public virtual void dmethod_2396(byte[] byteDizi_0)
		{
			this.field_1.tmethod_2072(byteDizi_0);
			this.field_0.tmethod_2072(byteDizi_0);
			base.tmethod_2072(byteDizi_0);
		}

		// Token: 0x06000D68 RID: 3432 RVA: 0x000486E3 File Offset: 0x000468E3
		public virtual void kmethod_2397(DateTime arg_0)
		{
			this.field_1.xmethod_2051(arg_0);
			this.field_0.xmethod_2051(arg_0);
			base.xmethod_2051(arg_0);
		}

		// Token: 0x06000D69 RID: 3433 RVA: 0x00048704 File Offset: 0x00046904
		public virtual void lmethod_2398(DateTimeOffset arg_0)
		{
			this.field_1.tmethod_2052(arg_0);
			this.field_0.tmethod_2052(arg_0);
			base.tmethod_2052(arg_0);
		}

		// Token: 0x06000D6A RID: 3434 RVA: 0x00048725 File Offset: 0x00046925
		public virtual void pmethod_2399(double double_0)
		{
			this.field_1.gmethod_2043(double_0);
			this.field_0.gmethod_2043(double_0);
			base.gmethod_2043(double_0);
		}

		// Token: 0x06000D6B RID: 3435 RVA: 0x00048746 File Offset: 0x00046946
		public virtual void smethod_2400()
		{
			this.field_1.cmethod_2034();
			this.field_0.cmethod_2034();
			base.cmethod_2034();
		}

		// Token: 0x06000D6C RID: 3436 RVA: 0x00048764 File Offset: 0x00046964
		public virtual void xmethod_2401()
		{
			this.field_1.gmethod_2033();
			this.field_0.gmethod_2033();
			base.cmethod_2034();
		}

		// Token: 0x06000D6D RID: 3437 RVA: 0x00048782 File Offset: 0x00046982
		public virtual void tmethod_2402(float arg_0)
		{
			this.field_1.tmethod_2042(arg_0);
			this.field_0.tmethod_2042(arg_0);
			base.tmethod_2042(arg_0);
		}

		// Token: 0x06000D6E RID: 3438 RVA: 0x000487A3 File Offset: 0x000469A3
		public virtual void gmethod_2403(Guid arg_0)
		{
			this.field_1.gmethod_2053(arg_0);
			this.field_0.gmethod_2053(arg_0);
			base.gmethod_2053(arg_0);
		}

		// Token: 0x06000D6F RID: 3439 RVA: 0x000487C4 File Offset: 0x000469C4
		public virtual void cmethod_2404(int sayıInt_0)
		{
			this.field_1.lmethod_2038(sayıInt_0);
			this.field_0.lmethod_2038(sayıInt_0);
			base.lmethod_2038(sayıInt_0);
		}

		// Token: 0x06000D70 RID: 3440 RVA: 0x000487E5 File Offset: 0x000469E5
		public virtual void vmethod_2405(long sayıUınt_0)
		{
			this.field_1.smethod_2040(sayıUınt_0);
			this.field_0.smethod_2040(sayıUınt_0);
			base.smethod_2040(sayıUınt_0);
		}

		// Token: 0x06000D71 RID: 3441 RVA: 0x00048808 File Offset: 0x00046A08
		public virtual void dmethod_2406(object obje_0)
		{
			if (obje_0 is BigInteger)
			{
				this.field_1.cmethod_2074(obje_0);
				this.field_0.cmethod_2074(obje_0);
				base.dmethod_2086(Class_508.Integer);
				return;
			}
			this.field_1.cmethod_2074(obje_0);
			this.field_0.cmethod_2074(obje_0);
			base.cmethod_2074(obje_0);
		}

		// Token: 0x06000D72 RID: 3442 RVA: 0x0004885F File Offset: 0x00046A5F
		public virtual void kmethod_2407(sbyte arg_0)
		{
			this.field_1.pmethod_2049(arg_0);
			this.field_0.pmethod_2049(arg_0);
			base.pmethod_2049(arg_0);
		}

		// Token: 0x06000D73 RID: 3443 RVA: 0x00048880 File Offset: 0x00046A80
		public virtual void lmethod_2408(short sayıShort_0)
		{
			this.field_1.vmethod_2045(sayıShort_0);
			this.field_0.vmethod_2045(sayıShort_0);
			base.vmethod_2045(sayıShort_0);
		}

		// Token: 0x06000D74 RID: 3444 RVA: 0x000488A1 File Offset: 0x00046AA1
		public virtual void pmethod_2409(string str_0)
		{
			this.field_1.kmethod_2037(str_0);
			this.field_0.kmethod_2037(str_0);
			base.kmethod_2037(str_0);
		}

		// Token: 0x06000D75 RID: 3445 RVA: 0x000488C2 File Offset: 0x00046AC2
		public virtual void smethod_2410(TimeSpan arg_0)
		{
			this.field_1.cmethod_2054(arg_0);
			this.field_0.cmethod_2054(arg_0);
			base.cmethod_2054(arg_0);
		}

		// Token: 0x06000D76 RID: 3446 RVA: 0x000488E3 File Offset: 0x00046AE3
		public virtual void xmethod_2411(uint arg_0)
		{
			this.field_1.pmethod_2039(arg_0);
			this.field_0.pmethod_2039(arg_0);
			base.pmethod_2039(arg_0);
		}

		// Token: 0x06000D77 RID: 3447 RVA: 0x00048904 File Offset: 0x00046B04
		public virtual void tmethod_2412(ulong arg_0)
		{
			this.field_1.xmethod_2041(arg_0);
			this.field_0.xmethod_2041(arg_0);
			base.xmethod_2041(arg_0);
		}

		// Token: 0x06000D78 RID: 3448 RVA: 0x00048925 File Offset: 0x00046B25
		public virtual void gmethod_2413(Uri arg_0)
		{
			this.field_1.gmethod_2073(arg_0);
			this.field_0.gmethod_2073(arg_0);
			base.gmethod_2073(arg_0);
		}

		// Token: 0x06000D79 RID: 3449 RVA: 0x00048946 File Offset: 0x00046B46
		public virtual void cmethod_2414(ushort arg_0)
		{
			this.field_1.dmethod_2046(arg_0);
			this.field_0.dmethod_2046(arg_0);
			base.dmethod_2046(arg_0);
		}

		// Token: 0x06000D7A RID: 3450 RVA: 0x00048967 File Offset: 0x00046B67
		public virtual void vmethod_2415(string str_0)
		{
			this.field_1.dmethod_2076(str_0);
			this.field_0.dmethod_2076(str_0);
			base.dmethod_2076(str_0);
		}

		// Token: 0x06000D7B RID: 3451 RVA: 0x00048988 File Offset: 0x00046B88
		public virtual void dmethod_2416(string str_0)
		{
			this.field_1.vmethod_2075(str_0);
			this.field_0.vmethod_2075(str_0);
			base.vmethod_2075(str_0);
		}

		// Token: 0x06000D7C RID: 3452 RVA: 0x000489A9 File Offset: 0x00046BA9
		public virtual void kmethod_2417()
		{
			this.field_1.pmethod_2009();
			this.field_0.pmethod_2009();
			base.pmethod_2009();
		}

		// Token: 0x06000D7D RID: 3453 RVA: 0x000489C7 File Offset: 0x00046BC7
		public virtual void lmethod_2418()
		{
			this.field_1.smethod_2010();
			this.field_0.smethod_2010();
			base.smethod_2010();
		}

		// Token: 0x06000D7E RID: 3454 RVA: 0x000489E5 File Offset: 0x00046BE5
		public virtual void pmethod_2419(string str_0)
		{
			this.field_1.xmethod_2011(str_0);
			this.field_0.xmethod_2011(str_0);
			base.xmethod_2011(str_0);
		}

		// Token: 0x06000D7F RID: 3455 RVA: 0x00048A06 File Offset: 0x00046C06
		public virtual void smethod_2420()
		{
			this.field_1.tmethod_2012();
			this.field_0.tmethod_2012();
			base.tmethod_2012();
		}

		// Token: 0x06000D80 RID: 3456 RVA: 0x00048A24 File Offset: 0x00046C24
		public virtual void xmethod_2421(string str_0)
		{
			this.field_1.gmethod_2013(str_0);
			this.field_0.gmethod_2013(str_0);
			base.gmethod_2013(str_0);
		}

		// Token: 0x06000D81 RID: 3457 RVA: 0x00048A45 File Offset: 0x00046C45
		public virtual void tmethod_2422(string str_0, bool bool_0)
		{
			this.field_1.cmethod_2014(str_0, bool_0);
			this.field_0.cmethod_2014(str_0, bool_0);
			base.gmethod_2013(str_0);
		}

		// Token: 0x06000D82 RID: 3458 RVA: 0x00048A68 File Offset: 0x00046C68
		public virtual void gmethod_2423()
		{
			this.field_1.kmethod_2007();
			this.field_0.kmethod_2007();
			base.kmethod_2007();
		}

		// Token: 0x06000D83 RID: 3459 RVA: 0x00048A86 File Offset: 0x00046C86
		public virtual void cmethod_2424()
		{
			this.field_1.lmethod_2008();
			this.field_0.lmethod_2008();
			base.lmethod_2008();
		}

		// Token: 0x06000D84 RID: 3460 RVA: 0x00048AA4 File Offset: 0x00046CA4
		public virtual void vmethod_2425(string str_0)
		{
			this.field_1.vmethod_2035(str_0);
			this.field_0.vmethod_2035(str_0);
			base.vmethod_2035(str_0);
		}

		// Token: 0x06000D85 RID: 3461 RVA: 0x00048AC5 File Offset: 0x00046CC5
		public virtual void dmethod_2426(string str_0)
		{
			this.field_1.dmethod_2036(str_0);
			this.field_0.dmethod_2036(str_0);
			base.dmethod_2036(str_0);
		}

		// Token: 0x06000D86 RID: 3462 RVA: 0x00048AE6 File Offset: 0x00046CE6
		public virtual void kmethod_2427()
		{
			this.field_1.dmethod_2006();
			this.field_0.dmethod_2006();
			base.dmethod_2006();
		}

		// Token: 0x06000D87 RID: 3463 RVA: 0x00048B04 File Offset: 0x00046D04
		public virtual void lmethod_2428()
		{
			this.field_1.vmethod_2005();
			this.field_0.vmethod_2005();
		}

		// Token: 0x04000888 RID: 2184
		private readonly Class_296 field_0;

		// Token: 0x04000889 RID: 2185
		private new readonly Class_412 field_1;

		// Token: 0x0400088A RID: 2186
		private readonly StringWriter field_2;
	}
}
