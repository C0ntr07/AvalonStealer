using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020001A6 RID: 422
	public class Class_311 : Class_299
	{
		// Token: 0x1700028A RID: 650
		// (get) Token: 0x06000C2B RID: 3115 RVA: 0x00043E79 File Offset: 0x00042079
		// (set) Token: 0x06000C2C RID: 3116 RVA: 0x00043E81 File Offset: 0x00042081
		public new bool prop_0 { get; set; }

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x06000C2D RID: 3117 RVA: 0x00043E8A File Offset: 0x0004208A
		// (set) Token: 0x06000C2E RID: 3118 RVA: 0x00043E92 File Offset: 0x00042092
		public new bool prop_1 { get; set; }

		// Token: 0x06000C2F RID: 3119 RVA: 0x00043E9B File Offset: 0x0004209B
		public Class_311()
		{
			this.prop_1 = true;
		}

		// Token: 0x06000C30 RID: 3120 RVA: 0x00043EAC File Offset: 0x000420AC
		public virtual void kmethod_2197(Class_296 arg_0, object obje_0, Class_418 arg_1)
		{
			if (obje_0 == null)
			{
				arg_0.gmethod_2033();
				return;
			}
			Enum @enum = (Enum)obje_0;
			string text = @enum.ToString("G");
			if (char.IsNumber(text[0]) || text[0] == '-')
			{
				arg_0.cmethod_2074(obje_0);
				return;
			}
			Type type = @enum.GetType();
			string str_ = Class_505.ToEnumName(type, text, this.prop_0);
			arg_0.kmethod_2037(str_);
		}

		// Token: 0x06000C31 RID: 3121 RVA: 0x00043F1C File Offset: 0x0004211C
		public virtual object lmethod_2198(Class_285 arg_0, Type arg_1, object obje_0, Class_418 arg_2)
		{
			bool flag = Class_514.IsNullableType(arg_1);
			Type type = flag ? Nullable.GetUnderlyingType(arg_1) : arg_1;
			if (arg_0.prop_9 != Class_508.Null)
			{
				try
				{
					if (arg_0.prop_9 == Class_508.String)
					{
						string enumText = arg_0.prop_10.ToString();
						return Class_505.ParseEnumName(enumText, flag, type);
					}
					if (arg_0.prop_9 == Class_508.Integer)
					{
						if (!this.prop_1)
						{
							throw Class_417.xmethod_3101(arg_0, "Integer value {0} is not allowed.".FormatWith(CultureInfo.InvariantCulture, arg_0.prop_10));
						}
						return Class_499.ConvertOrCast(arg_0.prop_10, CultureInfo.InvariantCulture, type);
					}
				}
				catch (Exception arg_3)
				{
					throw Class_417.tmethod_3102(arg_0, "Error converting value {0} to type '{1}'.".FormatWith(CultureInfo.InvariantCulture, Class_513.FormatValueForPrint(arg_0.prop_10), arg_1), arg_3);
				}
				throw Class_417.xmethod_3101(arg_0, "Unexpected token {0} when parsing enum.".FormatWith(CultureInfo.InvariantCulture, arg_0.prop_9));
			}
			if (!Class_514.IsNullableType(arg_1))
			{
				throw Class_417.xmethod_3101(arg_0, "Cannot convert null value to {0}.".FormatWith(CultureInfo.InvariantCulture, arg_1));
			}
			return null;
		}

		// Token: 0x06000C32 RID: 3122 RVA: 0x00044044 File Offset: 0x00042244
		public virtual bool pmethod_2199(Type arg_0)
		{
			Type type = Class_514.IsNullableType(arg_0) ? Nullable.GetUnderlyingType(arg_0) : arg_0;
			return type.IsEnum;
		}

		// Token: 0x040007AE RID: 1966
		[CompilerGenerated]
		private bool field_0;

		// Token: 0x040007AF RID: 1967
		[CompilerGenerated]
		private bool field_1;
	}
}
