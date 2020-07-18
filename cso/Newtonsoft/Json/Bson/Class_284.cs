using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x02000187 RID: 391
	internal class Class_284
	{
		// Token: 0x17000256 RID: 598
		// (get) Token: 0x06000AAD RID: 2733 RVA: 0x0003E1A0 File Offset: 0x0003C3A0
		// (set) Token: 0x06000AAE RID: 2734 RVA: 0x0003E1A8 File Offset: 0x0003C3A8
		public DateTimeKind prop_0 { get; set; }

		// Token: 0x06000AAF RID: 2735 RVA: 0x0003E1B1 File Offset: 0x0003C3B1
		public Class_284(BinaryWriter arg_0)
		{
			this.prop_0 = DateTimeKind.Utc;
			this.field_1 = arg_0;
		}

		// Token: 0x06000AB0 RID: 2736 RVA: 0x0003E1C7 File Offset: 0x0003C3C7
		public void lmethod_1848()
		{
			this.field_1.Flush();
		}

		// Token: 0x06000AB1 RID: 2737 RVA: 0x0003E1D4 File Offset: 0x0003C3D4
		public void pmethod_1849()
		{
			this.field_1.Close();
		}

		// Token: 0x06000AB2 RID: 2738 RVA: 0x0003E1E1 File Offset: 0x0003C3E1
		public void smethod_1850(Class_287 arg_0)
		{
			this.dmethod_1856(arg_0);
			this.xmethod_1851(arg_0);
		}

		// Token: 0x06000AB3 RID: 2739 RVA: 0x0003E1F4 File Offset: 0x0003C3F4
		private void xmethod_1851(Class_287 arg_0)
		{
			switch (arg_0.prop_0)
			{
			case Class_295.Number:
			{
				Class_290 class_ = (Class_290)arg_0;
				this.field_1.Write(Convert.ToDouble(class_.prop_0, CultureInfo.InvariantCulture));
				return;
			}
			case Class_295.String:
			{
				Class_291 class_2 = (Class_291)arg_0;
				this.tmethod_1852((string)class_2.prop_0, class_2.prop_0, new int?(class_2.prop_2 - 4));
				return;
			}
			case Class_295.Object:
			{
				Class_288 class_3 = (Class_288)arg_0;
				this.field_1.Write(class_3.prop_2);
				using (IEnumerator<Class_294> enumerator = class_3.dmethod_1956())
				{
					while (enumerator.MoveNext())
					{
						Class_294 class_4 = enumerator.Current;
						this.field_1.Write((sbyte)class_4.prop_1.prop_0);
						this.tmethod_1852((string)class_4.prop_0.prop_0, class_4.prop_0.prop_0, null);
						this.xmethod_1851(class_4.prop_1);
					}
				}
				this.field_1.Write(0);
				return;
			}
			case Class_295.Array:
			{
				Class_289 class_5 = (Class_289)arg_0;
				this.field_1.Write(class_5.prop_2);
				ulong num = 0UL;
				using (IEnumerator<Class_287> enumerator2 = class_5.smethod_1960())
				{
					while (enumerator2.MoveNext())
					{
						Class_287 class_6 = enumerator2.Current;
						this.field_1.Write((sbyte)class_6.prop_0);
						this.tmethod_1852(num.ToString(CultureInfo.InvariantCulture), Class_511.IntLength(num), null);
						this.xmethod_1851(class_6);
						num += 1UL;
					}
				}
				this.field_1.Write(0);
				return;
			}
			case Class_295.Binary:
			{
				Class_292 class_7 = (Class_292)arg_0;
				byte[] array = (byte[])class_7.prop_0;
				this.field_1.Write(array.Length);
				this.field_1.Write((byte)class_7.prop_0);
				this.field_1.Write(array);
				return;
			}
			case Class_295.Undefined:
			case Class_295.Null:
				return;
			case Class_295.Oid:
			{
				Class_290 class_8 = (Class_290)arg_0;
				byte[] buffer = (byte[])class_8.prop_0;
				this.field_1.Write(buffer);
				return;
			}
			case Class_295.Boolean:
			{
				Class_290 class_9 = (Class_290)arg_0;
				this.field_1.Write((bool)class_9.prop_0);
				return;
			}
			case Class_295.Date:
			{
				Class_290 class_10 = (Class_290)arg_0;
				long value;
				if (class_10.prop_0 is DateTime)
				{
					DateTime dateTime = (DateTime)class_10.prop_0;
					if (this.prop_0 == DateTimeKind.Utc)
					{
						dateTime = dateTime.ToUniversalTime();
					}
					else if (this.prop_0 == DateTimeKind.Local)
					{
						dateTime = dateTime.ToLocalTime();
					}
					value = Class_502.ConvertDateTimeToJavaScriptTicks(dateTime, false);
				}
				else
				{
					DateTimeOffset dateTimeOffset = (DateTimeOffset)class_10.prop_0;
					value = Class_502.ConvertDateTimeToJavaScriptTicks(dateTimeOffset.UtcDateTime, dateTimeOffset.Offset);
				}
				this.field_1.Write(value);
				return;
			}
			case Class_295.Regex:
			{
				Class_293 class_11 = (Class_293)arg_0;
				this.tmethod_1852((string)class_11.prop_0.prop_0, class_11.prop_0.prop_0, null);
				this.tmethod_1852((string)class_11.prop_1.prop_0, class_11.prop_1.prop_0, null);
				return;
			}
			case Class_295.Integer:
			{
				Class_290 class_12 = (Class_290)arg_0;
				this.field_1.Write(Convert.ToInt32(class_12.prop_0, CultureInfo.InvariantCulture));
				return;
			}
			case Class_295.Long:
			{
				Class_290 class_13 = (Class_290)arg_0;
				this.field_1.Write(Convert.ToInt64(class_13.prop_0, CultureInfo.InvariantCulture));
				return;
			}
			}
			throw new ArgumentOutOfRangeException("t", "Unexpected token when writing BSON: {0}".FormatWith(CultureInfo.InvariantCulture, arg_0.prop_0));
		}

		// Token: 0x06000AB4 RID: 2740 RVA: 0x0003E608 File Offset: 0x0003C808
		private void tmethod_1852(string str_0, int sayıInt_0, int? arg_0)
		{
			if (arg_0 != null)
			{
				this.field_1.Write(arg_0.Value);
			}
			this.gmethod_1853(str_0, sayıInt_0);
			this.field_1.Write(0);
		}

		// Token: 0x06000AB5 RID: 2741 RVA: 0x0003E63C File Offset: 0x0003C83C
		public void gmethod_1853(string str_0, int sayıInt_0)
		{
			if (str_0 != null)
			{
				if (this.field_2 == null)
				{
					this.field_2 = new byte[256];
				}
				if (sayıInt_0 <= 256)
				{
					Class_284.field_0.GetBytes(str_0, 0, str_0.Length, this.field_2, 0);
					this.field_1.Write(this.field_2, 0, sayıInt_0);
					return;
				}
				byte[] bytes = Class_284.field_0.GetBytes(str_0);
				this.field_1.Write(bytes);
			}
		}

		// Token: 0x06000AB6 RID: 2742 RVA: 0x0003E6BB File Offset: 0x0003C8BB
		private int cmethod_1854(int sayıInt_0)
		{
			return sayıInt_0 + 1;
		}

		// Token: 0x06000AB7 RID: 2743 RVA: 0x0003E6C0 File Offset: 0x0003C8C0
		private int vmethod_1855(int sayıInt_0, bool bool_0)
		{
			int num = bool_0 ? 5 : 1;
			return num + sayıInt_0;
		}

		// Token: 0x06000AB8 RID: 2744 RVA: 0x0003E6E0 File Offset: 0x0003C8E0
		private int dmethod_1856(Class_287 arg_0)
		{
			switch (arg_0.prop_0)
			{
			case Class_295.Number:
				return 8;
			case Class_295.String:
			{
				Class_291 class_ = (Class_291)arg_0;
				string text = (string)class_.prop_0;
				class_.prop_0 = ((text != null) ? Class_284.field_0.GetByteCount(text) : 0);
				class_.prop_2 = this.vmethod_1855(class_.prop_0, class_.prop_1);
				return class_.prop_2;
			}
			case Class_295.Object:
			{
				Class_288 class_2 = (Class_288)arg_0;
				int num = 4;
				using (IEnumerator<Class_294> enumerator = class_2.dmethod_1956())
				{
					while (enumerator.MoveNext())
					{
						Class_294 class_3 = enumerator.Current;
						int num2 = 1;
						num2 += this.dmethod_1856(class_3.prop_0);
						num2 += this.dmethod_1856(class_3.prop_1);
						num += num2;
					}
				}
				num++;
				class_2.prop_2 = num;
				return num;
			}
			case Class_295.Array:
			{
				Class_289 class_4 = (Class_289)arg_0;
				int num3 = 4;
				ulong num4 = 0UL;
				using (IEnumerator<Class_287> enumerator2 = class_4.smethod_1960())
				{
					while (enumerator2.MoveNext())
					{
						Class_287 arg_ = enumerator2.Current;
						num3++;
						num3 += this.cmethod_1854(Class_511.IntLength(num4));
						num3 += this.dmethod_1856(arg_);
						num4 += 1UL;
					}
				}
				num3++;
				class_4.prop_2 = num3;
				return class_4.prop_2;
			}
			case Class_295.Binary:
			{
				Class_292 class_5 = (Class_292)arg_0;
				byte[] array = (byte[])class_5.prop_0;
				class_5.prop_2 = 5 + array.Length;
				return class_5.prop_2;
			}
			case Class_295.Undefined:
			case Class_295.Null:
				return 0;
			case Class_295.Oid:
				return 12;
			case Class_295.Boolean:
				return 1;
			case Class_295.Date:
				return 8;
			case Class_295.Regex:
			{
				Class_293 class_6 = (Class_293)arg_0;
				int num5 = 0;
				num5 += this.dmethod_1856(class_6.prop_0);
				num5 += this.dmethod_1856(class_6.prop_1);
				class_6.prop_2 = num5;
				return class_6.prop_2;
			}
			case Class_295.Integer:
				return 4;
			case Class_295.Long:
				return 8;
			}
			throw new ArgumentOutOfRangeException("t", "Unexpected token when writing BSON: {0}".FormatWith(CultureInfo.InvariantCulture, arg_0.prop_0));
		}

		// Token: 0x04000722 RID: 1826
		private static readonly Encoding field_0 = new UTF8Encoding(false);

		// Token: 0x04000723 RID: 1827
		private readonly BinaryWriter field_1;

		// Token: 0x04000724 RID: 1828
		private byte[] field_2;

		// Token: 0x04000725 RID: 1829
		[CompilerGenerated]
		private DateTimeKind field_3;
	}
}
