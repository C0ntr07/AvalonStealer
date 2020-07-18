using System;
using System.Globalization;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020001A8 RID: 424
	public class Class_313 : Class_299
	{
		// Token: 0x06000C33 RID: 3123 RVA: 0x0004406F File Offset: 0x0004226F
		public virtual void smethod_2200(Class_296 arg_0, object obje_0, Class_418 arg_1)
		{
			if (obje_0 == null)
			{
				arg_0.gmethod_2033();
				return;
			}
			if (obje_0 is Version)
			{
				arg_0.kmethod_2037(obje_0.ToString());
				return;
			}
			throw new Class_417("Expected Version object value");
		}

		// Token: 0x06000C34 RID: 3124 RVA: 0x000440A0 File Offset: 0x000422A0
		public virtual object xmethod_2201(Class_285 arg_0, Type arg_1, object obje_0, Class_418 arg_2)
		{
			if (arg_0.prop_9 == Class_508.Null)
			{
				return null;
			}
			if (arg_0.prop_9 == Class_508.String)
			{
				try
				{
					return new Version((string)arg_0.prop_10);
				}
				catch (Exception arg_3)
				{
					throw Class_417.tmethod_3102(arg_0, "Error parsing version string: {0}".FormatWith(CultureInfo.InvariantCulture, arg_0.prop_10), arg_3);
				}
			}
			throw Class_417.xmethod_3101(arg_0, "Unexpected token or value when parsing version. Token: {0}, Value: {1}".FormatWith(CultureInfo.InvariantCulture, arg_0.prop_9, arg_0.prop_10));
		}

		// Token: 0x06000C35 RID: 3125 RVA: 0x00044138 File Offset: 0x00042338
		public virtual bool tmethod_2202(Type arg_0)
		{
			return arg_0 == typeof(Version);
		}
	}
}
