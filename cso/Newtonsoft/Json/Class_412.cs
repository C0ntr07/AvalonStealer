using System;
using System.Globalization;
using System.IO;
using System.Numerics;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json
{
	// Token: 0x0200021F RID: 543
	public class Class_412 : Class_296
	{
		// Token: 0x1700039B RID: 923
		// (get) Token: 0x06001099 RID: 4249 RVA: 0x0005471E File Offset: 0x0005291E
		private new Class_474 prop_0
		{
			get
			{
				if (this.field_1 == null)
				{
					this.field_1 = new Class_474(this.field_0);
				}
				return this.field_1;
			}
		}

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x0600109A RID: 4250 RVA: 0x00054742 File Offset: 0x00052942
		// (set) Token: 0x0600109B RID: 4251 RVA: 0x0005474A File Offset: 0x0005294A
		public new int prop_1
		{
			get
			{
				return this.field_3;
			}
			set
			{
				if (value < 0)
				{
					throw new ArgumentException("Indentation value must be greater than 0.");
				}
				this.field_3 = value;
			}
		}

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x0600109C RID: 4252 RVA: 0x00054765 File Offset: 0x00052965
		// (set) Token: 0x0600109D RID: 4253 RVA: 0x0005476D File Offset: 0x0005296D
		public new char prop_2
		{
			get
			{
				return this.field_4;
			}
			set
			{
				if (value != '"' && value != '\'')
				{
					throw new ArgumentException("Invalid JavaScript string quote character. Valid quote characters are ' and \".");
				}
				this.field_4 = value;
				this.xmethod_3051();
			}
		}

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x0600109E RID: 4254 RVA: 0x00054797 File Offset: 0x00052997
		// (set) Token: 0x0600109F RID: 4255 RVA: 0x0005479F File Offset: 0x0005299F
		public new char prop_3
		{
			get
			{
				return this.field_2;
			}
			set
			{
				if (value != this.field_2)
				{
					this.field_2 = value;
					this.field_8 = null;
				}
			}
		}

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x060010A0 RID: 4256 RVA: 0x000547BB File Offset: 0x000529BB
		// (set) Token: 0x060010A1 RID: 4257 RVA: 0x000547C3 File Offset: 0x000529C3
		public new bool prop_4
		{
			get
			{
				return this.field_5;
			}
			set
			{
				this.field_5 = value;
			}
		}

		// Token: 0x060010A2 RID: 4258 RVA: 0x000547CC File Offset: 0x000529CC
		public Class_412(TextWriter arg_0)
		{
			if (arg_0 == null)
			{
				throw new ArgumentNullException("textWriter");
			}
			this.field_0 = arg_0;
			this.field_4 = '"';
			this.field_5 = true;
			this.field_2 = ' ';
			this.field_3 = 2;
			this.xmethod_3051();
		}

		// Token: 0x060010A3 RID: 4259 RVA: 0x0005481B File Offset: 0x00052A1B
		public virtual void tmethod_3042()
		{
			this.field_0.Flush();
		}

		// Token: 0x060010A4 RID: 4260 RVA: 0x00054828 File Offset: 0x00052A28
		public virtual void gmethod_3043()
		{
			base.dmethod_2006();
			if (base.prop_0 && this.field_0 != null)
			{
				this.field_0.Close();
			}
		}

		// Token: 0x060010A5 RID: 4261 RVA: 0x00054851 File Offset: 0x00052A51
		public virtual void cmethod_3044()
		{
			base.vmethod_2085(Class_508.StartObject, Class_325.Object);
			this.field_0.Write('{');
		}

		// Token: 0x060010A6 RID: 4262 RVA: 0x00054868 File Offset: 0x00052A68
		public virtual void vmethod_3045()
		{
			base.vmethod_2085(Class_508.StartArray, Class_325.Array);
			this.field_0.Write('[');
		}

		// Token: 0x060010A7 RID: 4263 RVA: 0x0005487F File Offset: 0x00052A7F
		public virtual void dmethod_3046(string str_0)
		{
			base.vmethod_2085(Class_508.StartConstructor, Class_325.Constructor);
			this.field_0.Write("new ");
			this.field_0.Write(str_0);
			this.field_0.Write('(');
		}

		// Token: 0x060010A8 RID: 4264 RVA: 0x000548B4 File Offset: 0x00052AB4
		protected virtual void kmethod_3047(Class_508 arg_0)
		{
			switch (arg_0)
			{
			case Class_508.EndObject:
				this.field_0.Write('}');
				return;
			case Class_508.EndArray:
				this.field_0.Write(']');
				return;
			case Class_508.EndConstructor:
				this.field_0.Write(')');
				return;
			default:
				throw Class_413.smethod_3090(this, "Invalid JsonToken: " + arg_0, null);
			}
		}

		// Token: 0x060010A9 RID: 4265 RVA: 0x0005491E File Offset: 0x00052B1E
		public virtual void lmethod_3048(string str_0)
		{
			base.gmethod_2083(str_0);
			this.xmethod_3061(str_0, this.field_5);
			this.field_0.Write(':');
		}

		// Token: 0x060010AA RID: 4266 RVA: 0x00054944 File Offset: 0x00052B44
		public virtual void pmethod_3049(string str_0, bool bool_0)
		{
			base.gmethod_2083(str_0);
			if (bool_0)
			{
				this.xmethod_3061(str_0, this.field_5);
			}
			else
			{
				if (this.field_5)
				{
					this.field_0.Write(this.field_4);
				}
				this.field_0.Write(str_0);
				if (this.field_5)
				{
					this.field_0.Write(this.field_4);
				}
			}
			this.field_0.Write(':');
		}

		// Token: 0x060010AB RID: 4267 RVA: 0x000549C1 File Offset: 0x00052BC1
		internal virtual void smethod_3050()
		{
			this.xmethod_3051();
		}

		// Token: 0x060010AC RID: 4268 RVA: 0x000549C9 File Offset: 0x00052BC9
		private void xmethod_3051()
		{
			this.field_6 = Class_507.GetCharEscapeFlags(base.prop_8, this.field_4);
		}

		// Token: 0x060010AD RID: 4269 RVA: 0x000549E4 File Offset: 0x00052BE4
		protected virtual void tmethod_3052()
		{
			this.field_0.WriteLine();
			int i = base.prop_1 * this.field_3;
			if (i > 0)
			{
				if (this.field_8 == null)
				{
					this.field_8 = new string(this.field_2, 10).ToCharArray();
				}
				while (i > 0)
				{
					int num = Math.Min(i, 10);
					this.field_0.Write(this.field_8, 0, num);
					i -= num;
				}
			}
		}

		// Token: 0x060010AE RID: 4270 RVA: 0x00054A5D File Offset: 0x00052C5D
		protected virtual void gmethod_3053()
		{
			this.field_0.Write(',');
		}

		// Token: 0x060010AF RID: 4271 RVA: 0x00054A6C File Offset: 0x00052C6C
		protected virtual void cmethod_3054()
		{
			this.field_0.Write(' ');
		}

		// Token: 0x060010B0 RID: 4272 RVA: 0x00054A7B File Offset: 0x00052C7B
		private void vmethod_3055(string str_0, Class_508 arg_0)
		{
			this.field_0.Write(str_0);
		}

		// Token: 0x060010B1 RID: 4273 RVA: 0x00054A8C File Offset: 0x00052C8C
		public virtual void dmethod_3056(object obje_0)
		{
			if (obje_0 is BigInteger)
			{
				base.dmethod_2086(Class_508.Integer);
				this.vmethod_3055(((BigInteger)obje_0).ToString(CultureInfo.InvariantCulture), Class_508.String);
				return;
			}
			base.cmethod_2074(obje_0);
		}

		// Token: 0x060010B2 RID: 4274 RVA: 0x00054ACE File Offset: 0x00052CCE
		public virtual void kmethod_3057()
		{
			base.dmethod_2086(Class_508.Null);
			this.vmethod_3055(Class_416.Null, Class_508.Null);
		}

		// Token: 0x060010B3 RID: 4275 RVA: 0x00054AE5 File Offset: 0x00052CE5
		public virtual void lmethod_3058()
		{
			base.dmethod_2086(Class_508.Undefined);
			this.vmethod_3055(Class_416.Undefined, Class_508.Undefined);
		}

		// Token: 0x060010B4 RID: 4276 RVA: 0x00054AFC File Offset: 0x00052CFC
		public virtual void pmethod_3059(string str_0)
		{
			base.cmethod_2084();
			this.field_0.Write(str_0);
		}

		// Token: 0x060010B5 RID: 4277 RVA: 0x00054B10 File Offset: 0x00052D10
		public virtual void smethod_3060(string str_0)
		{
			base.dmethod_2086(Class_508.String);
			if (str_0 == null)
			{
				this.vmethod_3055(Class_416.Null, Class_508.Null);
				return;
			}
			this.xmethod_3061(str_0, true);
		}

		// Token: 0x060010B6 RID: 4278 RVA: 0x00054B36 File Offset: 0x00052D36
		private void xmethod_3061(string str_0, bool bool_0)
		{
			this.vmethod_3085();
			Class_507.WriteEscapedJavaScriptString(this.field_0, str_0, this.field_4, bool_0, this.field_6, base.prop_8, ref this.field_7);
		}

		// Token: 0x060010B7 RID: 4279 RVA: 0x00054B63 File Offset: 0x00052D63
		public virtual void tmethod_3062(int sayıInt_0)
		{
			base.dmethod_2086(Class_508.Integer);
			this.dmethod_3086((long)sayıInt_0);
		}

		// Token: 0x060010B8 RID: 4280 RVA: 0x00054B74 File Offset: 0x00052D74
		[CLSCompliant(false)]
		public virtual void gmethod_3063(uint arg_0)
		{
			base.dmethod_2086(Class_508.Integer);
			this.dmethod_3086((long)((ulong)arg_0));
		}

		// Token: 0x060010B9 RID: 4281 RVA: 0x00054B85 File Offset: 0x00052D85
		public virtual void cmethod_3064(long sayıUınt_0)
		{
			base.dmethod_2086(Class_508.Integer);
			this.dmethod_3086(sayıUınt_0);
		}

		// Token: 0x060010BA RID: 4282 RVA: 0x00054B95 File Offset: 0x00052D95
		[CLSCompliant(false)]
		public virtual void vmethod_3065(ulong arg_0)
		{
			base.dmethod_2086(Class_508.Integer);
			this.kmethod_3087(arg_0);
		}

		// Token: 0x060010BB RID: 4283 RVA: 0x00054BA5 File Offset: 0x00052DA5
		public virtual void dmethod_3066(float arg_0)
		{
			base.dmethod_2086(Class_508.Float);
			this.vmethod_3055(Class_416.ToString(arg_0, base.prop_9, this.prop_2, false), Class_508.Float);
		}

		// Token: 0x060010BC RID: 4284 RVA: 0x00054BC8 File Offset: 0x00052DC8
		public virtual void kmethod_3067(float? arg_0)
		{
			if (arg_0 == null)
			{
				this.gmethod_2033();
				return;
			}
			base.dmethod_2086(Class_508.Float);
			this.vmethod_3055(Class_416.ToString(arg_0.Value, base.prop_9, this.prop_2, true), Class_508.Float);
		}

		// Token: 0x060010BD RID: 4285 RVA: 0x00054C04 File Offset: 0x00052E04
		public virtual void lmethod_3068(double double_0)
		{
			base.dmethod_2086(Class_508.Float);
			this.vmethod_3055(Class_416.ToString(double_0, base.prop_9, this.prop_2, false), Class_508.Float);
		}

		// Token: 0x060010BE RID: 4286 RVA: 0x00054C27 File Offset: 0x00052E27
		public virtual void pmethod_3069(double? arg_0)
		{
			if (arg_0 == null)
			{
				this.gmethod_2033();
				return;
			}
			base.dmethod_2086(Class_508.Float);
			this.vmethod_3055(Class_416.ToString(arg_0.Value, base.prop_9, this.prop_2, true), Class_508.Float);
		}

		// Token: 0x060010BF RID: 4287 RVA: 0x00054C63 File Offset: 0x00052E63
		public virtual void smethod_3070(bool bool_0)
		{
			base.dmethod_2086(Class_508.Boolean);
			this.vmethod_3055(Class_416.ToString(bool_0), Class_508.Boolean);
		}

		// Token: 0x060010C0 RID: 4288 RVA: 0x00054B63 File Offset: 0x00052D63
		public virtual void xmethod_3071(short sayıShort_0)
		{
			base.dmethod_2086(Class_508.Integer);
			this.dmethod_3086((long)sayıShort_0);
		}

		// Token: 0x060010C1 RID: 4289 RVA: 0x00054B74 File Offset: 0x00052D74
		[CLSCompliant(false)]
		public virtual void tmethod_3072(ushort arg_0)
		{
			base.dmethod_2086(Class_508.Integer);
			this.dmethod_3086((long)((ulong)arg_0));
		}

		// Token: 0x060010C2 RID: 4290 RVA: 0x00054C7B File Offset: 0x00052E7B
		public virtual void gmethod_3073(char char_0)
		{
			base.dmethod_2086(Class_508.String);
			this.vmethod_3055(Class_416.ToString(char_0), Class_508.String);
		}

		// Token: 0x060010C3 RID: 4291 RVA: 0x00054B74 File Offset: 0x00052D74
		public virtual void cmethod_3074(byte byte_0)
		{
			base.dmethod_2086(Class_508.Integer);
			this.dmethod_3086((long)((ulong)byte_0));
		}

		// Token: 0x060010C4 RID: 4292 RVA: 0x00054B63 File Offset: 0x00052D63
		[CLSCompliant(false)]
		public virtual void vmethod_3075(sbyte arg_0)
		{
			base.dmethod_2086(Class_508.Integer);
			this.dmethod_3086((long)arg_0);
		}

		// Token: 0x060010C5 RID: 4293 RVA: 0x00054C93 File Offset: 0x00052E93
		public virtual void dmethod_3076(decimal arg_0)
		{
			base.dmethod_2086(Class_508.Float);
			this.vmethod_3055(Class_416.ToString(arg_0), Class_508.Float);
		}

		// Token: 0x060010C6 RID: 4294 RVA: 0x00054CAC File Offset: 0x00052EAC
		public virtual void kmethod_3077(DateTime arg_0)
		{
			base.dmethod_2086(Class_508.Date);
			arg_0 = Class_502.EnsureDateTime(arg_0, base.prop_7);
			if (string.IsNullOrEmpty(base.prop_10))
			{
				this.vmethod_3085();
				int num = 0;
				this.field_7[num++] = this.field_4;
				num = Class_502.WriteDateTimeString(this.field_7, num, arg_0, null, arg_0.Kind, base.prop_6);
				this.field_7[num++] = this.field_4;
				this.field_0.Write(this.field_7, 0, num);
				return;
			}
			this.field_0.Write(this.field_4);
			this.field_0.Write(arg_0.ToString(base.prop_10, base.prop_11));
			this.field_0.Write(this.field_4);
		}

		// Token: 0x060010C7 RID: 4295 RVA: 0x00054D84 File Offset: 0x00052F84
		public virtual void lmethod_3078(byte[] byteDizi_0)
		{
			if (byteDizi_0 == null)
			{
				this.gmethod_2033();
				return;
			}
			base.dmethod_2086(Class_508.Bytes);
			this.field_0.Write(this.field_4);
			this.prop_0.smethod_4000(byteDizi_0, 0, byteDizi_0.Length);
			this.prop_0.xmethod_4001();
			this.field_0.Write(this.field_4);
		}

		// Token: 0x060010C8 RID: 4296 RVA: 0x00054DE4 File Offset: 0x00052FE4
		public virtual void pmethod_3079(DateTimeOffset arg_0)
		{
			base.dmethod_2086(Class_508.Date);
			if (string.IsNullOrEmpty(base.prop_10))
			{
				this.vmethod_3085();
				int num = 0;
				this.field_7[num++] = this.field_4;
				num = Class_502.WriteDateTimeString(this.field_7, num, (base.prop_6 == Class_319.IsoDateFormat) ? arg_0.DateTime : arg_0.UtcDateTime, new TimeSpan?(arg_0.Offset), DateTimeKind.Local, base.prop_6);
				this.field_7[num++] = this.field_4;
				this.field_0.Write(this.field_7, 0, num);
				return;
			}
			this.field_0.Write(this.field_4);
			this.field_0.Write(arg_0.ToString(base.prop_10, base.prop_11));
			this.field_0.Write(this.field_4);
		}

		// Token: 0x060010C9 RID: 4297 RVA: 0x00054EC8 File Offset: 0x000530C8
		public virtual void smethod_3080(Guid arg_0)
		{
			base.dmethod_2086(Class_508.String);
			string value = arg_0.ToString("D", CultureInfo.InvariantCulture);
			this.field_0.Write(this.field_4);
			this.field_0.Write(value);
			this.field_0.Write(this.field_4);
		}

		// Token: 0x060010CA RID: 4298 RVA: 0x00054F20 File Offset: 0x00053120
		public virtual void xmethod_3081(TimeSpan arg_0)
		{
			base.dmethod_2086(Class_508.String);
			string value = arg_0.ToString(null, CultureInfo.InvariantCulture);
			this.field_0.Write(this.field_4);
			this.field_0.Write(value);
			this.field_0.Write(this.field_4);
		}

		// Token: 0x060010CB RID: 4299 RVA: 0x00054F71 File Offset: 0x00053171
		public virtual void tmethod_3082(Uri arg_0)
		{
			if (arg_0 == null)
			{
				this.gmethod_2033();
				return;
			}
			base.dmethod_2086(Class_508.String);
			this.xmethod_3061(arg_0.OriginalString, true);
		}

		// Token: 0x060010CC RID: 4300 RVA: 0x00054F9B File Offset: 0x0005319B
		public virtual void gmethod_3083(string str_0)
		{
			base.lmethod_2088();
			this.field_0.Write("/*");
			this.field_0.Write(str_0);
			this.field_0.Write("*/");
		}

		// Token: 0x060010CD RID: 4301 RVA: 0x00054FCF File Offset: 0x000531CF
		public virtual void cmethod_3084(string str_0)
		{
			base.kmethod_2087(str_0);
			this.field_0.Write(str_0);
		}

		// Token: 0x060010CE RID: 4302 RVA: 0x00054FE4 File Offset: 0x000531E4
		private void vmethod_3085()
		{
			if (this.field_7 == null)
			{
				this.field_7 = new char[35];
			}
		}

		// Token: 0x060010CF RID: 4303 RVA: 0x00055000 File Offset: 0x00053200
		private void dmethod_3086(long sayıUınt_0)
		{
			if (sayıUınt_0 >= 0L && sayıUınt_0 <= 9L)
			{
				this.field_0.Write((char)(48L + sayıUınt_0));
				return;
			}
			ulong arg_ = (ulong)((sayıUınt_0 < 0L) ? (-(ulong)sayıUınt_0) : sayıUınt_0);
			if (sayıUınt_0 < 0L)
			{
				this.field_0.Write('-');
			}
			this.kmethod_3087(arg_);
		}

		// Token: 0x060010D0 RID: 4304 RVA: 0x00055060 File Offset: 0x00053260
		private void kmethod_3087(ulong arg_0)
		{
			if (arg_0 <= 9UL)
			{
				this.field_0.Write((char)(48UL + arg_0));
				return;
			}
			this.vmethod_3085();
			int num = Class_511.IntLength(arg_0);
			int num2 = 0;
			do
			{
				this.field_7[num - ++num2] = (char)(48UL + arg_0 % 10UL);
				arg_0 /= 10UL;
			}
			while (arg_0 != 0UL);
			this.field_0.Write(this.field_7, 0, num2);
		}

		// Token: 0x0400099C RID: 2460
		private readonly TextWriter field_0;

		// Token: 0x0400099D RID: 2461
		private new Class_474 field_1;

		// Token: 0x0400099E RID: 2462
		private char field_2;

		// Token: 0x0400099F RID: 2463
		private int field_3;

		// Token: 0x040009A0 RID: 2464
		private char field_4;

		// Token: 0x040009A1 RID: 2465
		private bool field_5;

		// Token: 0x040009A2 RID: 2466
		private bool[] field_6;

		// Token: 0x040009A3 RID: 2467
		private char[] field_7;

		// Token: 0x040009A4 RID: 2468
		private char[] field_8;
	}
}
