using System;
using System.Globalization;
using System.Numerics;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x02000237 RID: 567
	public class Class_426 : Class_296
	{
		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x060012C4 RID: 4804 RVA: 0x0005A41A File Offset: 0x0005861A
		public new Class_361 prop_0
		{
			get
			{
				return this.field_3;
			}
		}

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x060012C5 RID: 4805 RVA: 0x0005A422 File Offset: 0x00058622
		public new Class_361 prop_1
		{
			get
			{
				if (this.field_0 != null)
				{
					return this.field_0;
				}
				return this.field_2;
			}
		}

		// Token: 0x060012C6 RID: 4806 RVA: 0x0005A43C File Offset: 0x0005863C
		public Class_426(Class_420 arg_0)
		{
			Class_517.ArgumentNotNull(arg_0, "container");
			this.field_0 = arg_0;
			this.field_1 = arg_0;
		}

		// Token: 0x060012C7 RID: 4807 RVA: 0x0005A45D File Offset: 0x0005865D
		public Class_426()
		{
		}

		// Token: 0x060012C8 RID: 4808 RVA: 0x00002050 File Offset: 0x00000250
		public virtual void cmethod_3394()
		{
		}

		// Token: 0x060012C9 RID: 4809 RVA: 0x0005A465 File Offset: 0x00058665
		public virtual void vmethod_3395()
		{
			base.dmethod_2006();
		}

		// Token: 0x060012CA RID: 4810 RVA: 0x0005A46D File Offset: 0x0005866D
		public virtual void dmethod_3396()
		{
			base.kmethod_2007();
			this.kmethod_3397(new Class_423());
		}

		// Token: 0x060012CB RID: 4811 RVA: 0x0005A480 File Offset: 0x00058680
		private void kmethod_3397(Class_420 arg_0)
		{
			if (this.field_1 == null)
			{
				this.field_0 = arg_0;
			}
			else
			{
				this.field_1.pmethod_3219(arg_0);
			}
			this.field_1 = arg_0;
			this.field_3 = arg_0;
		}

		// Token: 0x060012CC RID: 4812 RVA: 0x0005A4B4 File Offset: 0x000586B4
		private void lmethod_3398()
		{
			this.field_3 = this.field_1;
			this.field_1 = this.field_1.prop_1;
			if (this.field_1 != null && this.field_1.prop_3 == Class_428.Property)
			{
				this.field_1 = this.field_1.prop_1;
			}
		}

		// Token: 0x060012CD RID: 4813 RVA: 0x0005A50B File Offset: 0x0005870B
		public virtual void pmethod_3399()
		{
			base.pmethod_2009();
			this.kmethod_3397(new Class_424());
		}

		// Token: 0x060012CE RID: 4814 RVA: 0x0005A51E File Offset: 0x0005871E
		public virtual void smethod_3400(string str_0)
		{
			base.xmethod_2011(str_0);
			this.kmethod_3397(new Class_421(str_0));
		}

		// Token: 0x060012CF RID: 4815 RVA: 0x0005A533 File Offset: 0x00058733
		protected virtual void xmethod_3401(Class_508 arg_0)
		{
			this.lmethod_3398();
		}

		// Token: 0x060012D0 RID: 4816 RVA: 0x0005A53B File Offset: 0x0005873B
		public virtual void tmethod_3402(string str_0)
		{
			this.kmethod_3397(new Class_427(str_0));
			base.gmethod_2013(str_0);
		}

		// Token: 0x060012D1 RID: 4817 RVA: 0x0005A550 File Offset: 0x00058750
		private void gmethod_3403(object obje_0, Class_508 arg_0)
		{
			this.cmethod_3404(new Class_362(obje_0), arg_0);
		}

		// Token: 0x060012D2 RID: 4818 RVA: 0x0005A560 File Offset: 0x00058760
		internal void cmethod_3404(Class_362 arg_0, Class_508 arg_1)
		{
			if (this.field_1 != null)
			{
				this.field_1.lmethod_3218(arg_0);
				this.field_3 = this.field_1.prop_10;
				if (this.field_1.prop_3 == Class_428.Property)
				{
					this.field_1 = this.field_1.prop_1;
					return;
				}
			}
			else
			{
				this.field_2 = (arg_0 ?? Class_362.kmethod_2597());
				this.field_3 = this.field_2;
			}
		}

		// Token: 0x060012D3 RID: 4819 RVA: 0x0005A5D7 File Offset: 0x000587D7
		public virtual void vmethod_3405(object obje_0)
		{
			if (obje_0 is BigInteger)
			{
				base.dmethod_2086(Class_508.Integer);
				this.gmethod_3403(obje_0, Class_508.Integer);
				return;
			}
			base.cmethod_2074(obje_0);
		}

		// Token: 0x060012D4 RID: 4820 RVA: 0x0005A5FB File Offset: 0x000587FB
		public virtual void dmethod_3406()
		{
			base.gmethod_2033();
			this.cmethod_3404(null, Class_508.Null);
		}

		// Token: 0x060012D5 RID: 4821 RVA: 0x0005A60C File Offset: 0x0005880C
		public virtual void kmethod_3407()
		{
			base.cmethod_2034();
			this.cmethod_3404(null, Class_508.Undefined);
		}

		// Token: 0x060012D6 RID: 4822 RVA: 0x0005A61D File Offset: 0x0005881D
		public virtual void lmethod_3408(string str_0)
		{
			base.vmethod_2035(str_0);
			this.cmethod_3404(new Class_363(str_0), Class_508.Raw);
		}

		// Token: 0x060012D7 RID: 4823 RVA: 0x0005A633 File Offset: 0x00058833
		public virtual void pmethod_3409(string str_0)
		{
			base.vmethod_2075(str_0);
			this.cmethod_3404(Class_362.vmethod_2595(str_0), Class_508.Comment);
		}

		// Token: 0x060012D8 RID: 4824 RVA: 0x0005A649 File Offset: 0x00058849
		public virtual void smethod_3410(string str_0)
		{
			base.kmethod_2037(str_0);
			this.gmethod_3403(str_0, Class_508.String);
		}

		// Token: 0x060012D9 RID: 4825 RVA: 0x0005A65B File Offset: 0x0005885B
		public virtual void xmethod_3411(int sayıInt_0)
		{
			base.lmethod_2038(sayıInt_0);
			this.gmethod_3403(sayıInt_0, Class_508.Integer);
		}

		// Token: 0x060012DA RID: 4826 RVA: 0x0005A671 File Offset: 0x00058871
		[CLSCompliant(false)]
		public virtual void tmethod_3412(uint arg_0)
		{
			base.pmethod_2039(arg_0);
			this.gmethod_3403(arg_0, Class_508.Integer);
		}

		// Token: 0x060012DB RID: 4827 RVA: 0x0005A687 File Offset: 0x00058887
		public virtual void gmethod_3413(long sayıUınt_0)
		{
			base.smethod_2040(sayıUınt_0);
			this.gmethod_3403(sayıUınt_0, Class_508.Integer);
		}

		// Token: 0x060012DC RID: 4828 RVA: 0x0005A69D File Offset: 0x0005889D
		[CLSCompliant(false)]
		public virtual void cmethod_3414(ulong arg_0)
		{
			base.xmethod_2041(arg_0);
			this.gmethod_3403(arg_0, Class_508.Integer);
		}

		// Token: 0x060012DD RID: 4829 RVA: 0x0005A6B3 File Offset: 0x000588B3
		public virtual void vmethod_3415(float arg_0)
		{
			base.tmethod_2042(arg_0);
			this.gmethod_3403(arg_0, Class_508.Float);
		}

		// Token: 0x060012DE RID: 4830 RVA: 0x0005A6C9 File Offset: 0x000588C9
		public virtual void dmethod_3416(double double_0)
		{
			base.gmethod_2043(double_0);
			this.gmethod_3403(double_0, Class_508.Float);
		}

		// Token: 0x060012DF RID: 4831 RVA: 0x0005A6DF File Offset: 0x000588DF
		public virtual void kmethod_3417(bool bool_0)
		{
			base.cmethod_2044(bool_0);
			this.gmethod_3403(bool_0, Class_508.Boolean);
		}

		// Token: 0x060012E0 RID: 4832 RVA: 0x0005A6F6 File Offset: 0x000588F6
		public virtual void lmethod_3418(short sayıShort_0)
		{
			base.vmethod_2045(sayıShort_0);
			this.gmethod_3403(sayıShort_0, Class_508.Integer);
		}

		// Token: 0x060012E1 RID: 4833 RVA: 0x0005A70C File Offset: 0x0005890C
		[CLSCompliant(false)]
		public virtual void pmethod_3419(ushort arg_0)
		{
			base.dmethod_2046(arg_0);
			this.gmethod_3403(arg_0, Class_508.Integer);
		}

		// Token: 0x060012E2 RID: 4834 RVA: 0x0005A724 File Offset: 0x00058924
		public virtual void smethod_3420(char char_0)
		{
			base.kmethod_2047(char_0);
			string obje_ = char_0.ToString(CultureInfo.InvariantCulture);
			this.gmethod_3403(obje_, Class_508.String);
		}

		// Token: 0x060012E3 RID: 4835 RVA: 0x0005A750 File Offset: 0x00058950
		public virtual void xmethod_3421(byte byte_0)
		{
			base.lmethod_2048(byte_0);
			this.gmethod_3403(byte_0, Class_508.Integer);
		}

		// Token: 0x060012E4 RID: 4836 RVA: 0x0005A766 File Offset: 0x00058966
		[CLSCompliant(false)]
		public virtual void tmethod_3422(sbyte arg_0)
		{
			base.pmethod_2049(arg_0);
			this.gmethod_3403(arg_0, Class_508.Integer);
		}

		// Token: 0x060012E5 RID: 4837 RVA: 0x0005A77C File Offset: 0x0005897C
		public virtual void gmethod_3423(decimal arg_0)
		{
			base.smethod_2050(arg_0);
			this.gmethod_3403(arg_0, Class_508.Float);
		}

		// Token: 0x060012E6 RID: 4838 RVA: 0x0005A792 File Offset: 0x00058992
		public virtual void cmethod_3424(DateTime arg_0)
		{
			base.xmethod_2051(arg_0);
			arg_0 = Class_502.EnsureDateTime(arg_0, base.prop_7);
			this.gmethod_3403(arg_0, Class_508.Date);
		}

		// Token: 0x060012E7 RID: 4839 RVA: 0x0005A7B7 File Offset: 0x000589B7
		public virtual void vmethod_3425(DateTimeOffset arg_0)
		{
			base.tmethod_2052(arg_0);
			this.gmethod_3403(arg_0, Class_508.Date);
		}

		// Token: 0x060012E8 RID: 4840 RVA: 0x0005A7CE File Offset: 0x000589CE
		public virtual void dmethod_3426(byte[] byteDizi_0)
		{
			base.tmethod_2072(byteDizi_0);
			this.gmethod_3403(byteDizi_0, Class_508.Bytes);
		}

		// Token: 0x060012E9 RID: 4841 RVA: 0x0005A7E0 File Offset: 0x000589E0
		public virtual void kmethod_3427(TimeSpan arg_0)
		{
			base.cmethod_2054(arg_0);
			this.gmethod_3403(arg_0, Class_508.String);
		}

		// Token: 0x060012EA RID: 4842 RVA: 0x0005A7F7 File Offset: 0x000589F7
		public virtual void lmethod_3428(Guid arg_0)
		{
			base.gmethod_2053(arg_0);
			this.gmethod_3403(arg_0, Class_508.String);
		}

		// Token: 0x060012EB RID: 4843 RVA: 0x0005A80E File Offset: 0x00058A0E
		public virtual void pmethod_3429(Uri arg_0)
		{
			base.gmethod_2073(arg_0);
			this.gmethod_3403(arg_0, Class_508.String);
		}

		// Token: 0x04000A12 RID: 2578
		private Class_420 field_0;

		// Token: 0x04000A13 RID: 2579
		private new Class_420 field_1;

		// Token: 0x04000A14 RID: 2580
		private Class_362 field_2;

		// Token: 0x04000A15 RID: 2581
		private Class_361 field_3;
	}
}
