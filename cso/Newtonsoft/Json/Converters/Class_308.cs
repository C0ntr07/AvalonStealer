using System;
using System.Collections.Generic;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020001A3 RID: 419
	public class Class_308 : Class_299
	{
		// Token: 0x06000C17 RID: 3095 RVA: 0x000437B0 File Offset: 0x000419B0
		private static Class_491 kmethod_2177(Type arg_0)
		{
			IList<Type> genericArguments = arg_0.GetGenericArguments();
			Type type = genericArguments[0];
			Type type2 = genericArguments[1];
			return Class_491.dmethod_4066(arg_0, arg_0.GetConstructor(new Type[]
			{
				type,
				type2
			}), new string[]
			{
				"Key",
				"Value"
			});
		}

		// Token: 0x06000C18 RID: 3096 RVA: 0x0004381C File Offset: 0x00041A1C
		public virtual void lmethod_2178(Class_296 arg_0, object obje_0, Class_418 arg_1)
		{
			Class_491 class_ = Class_308.field_2.Get(obje_0.GetType());
			Class_441 class_2 = arg_1.prop_14 as Class_441;
			arg_0.kmethod_2007();
			arg_0.gmethod_2013((class_2 != null) ? class_2.smethod_3590("Key") : "Key");
			arg_1.vmethod_3175(arg_0, class_.tmethod_4062(obje_0, "Key"), class_.cmethod_4064("Key"));
			arg_0.gmethod_2013((class_2 != null) ? class_2.smethod_3590("Value") : "Value");
			arg_1.vmethod_3175(arg_0, class_.tmethod_4062(obje_0, "Value"), class_.cmethod_4064("Value"));
			arg_0.lmethod_2008();
		}

		// Token: 0x06000C19 RID: 3097 RVA: 0x000438D0 File Offset: 0x00041AD0
		public virtual object pmethod_2179(Class_285 arg_0, Type arg_1, object obje_0, Class_418 arg_2)
		{
			bool flag = Class_514.IsNullableType(arg_1);
			Type type = flag ? Nullable.GetUnderlyingType(arg_1) : arg_1;
			Class_491 class_ = Class_308.field_2.Get(type);
			if (arg_0.prop_9 != Class_508.Null)
			{
				object obj = null;
				object obj2 = null;
				Class_308.xmethod_2181(arg_0);
				while (arg_0.prop_9 == Class_508.PropertyName)
				{
					string a = arg_0.prop_10.ToString();
					if (string.Equals(a, "Key", StringComparison.OrdinalIgnoreCase))
					{
						Class_308.xmethod_2181(arg_0);
						obj = arg_2.smethod_3170(arg_0, class_.cmethod_4064("Key"));
					}
					else if (string.Equals(a, "Value", StringComparison.OrdinalIgnoreCase))
					{
						Class_308.xmethod_2181(arg_0);
						obj2 = arg_2.smethod_3170(arg_0, class_.cmethod_4064("Value"));
					}
					else
					{
						arg_0.smethod_1900();
					}
					Class_308.xmethod_2181(arg_0);
				}
				return class_.prop_0(new object[]
				{
					obj,
					obj2
				});
			}
			if (!flag)
			{
				throw Class_417.xmethod_3101(arg_0, "Cannot convert null value to KeyValuePair.");
			}
			return null;
		}

		// Token: 0x06000C1A RID: 3098 RVA: 0x000439DC File Offset: 0x00041BDC
		public virtual bool smethod_2180(Type arg_0)
		{
			Type type = Class_514.IsNullableType(arg_0) ? Nullable.GetUnderlyingType(arg_0) : arg_0;
			return type.IsValueType && type.IsGenericType && type.GetGenericTypeDefinition() == typeof(KeyValuePair<, >);
		}

		// Token: 0x06000C1B RID: 3099 RVA: 0x00043A2E File Offset: 0x00041C2E
		private static void xmethod_2181(Class_285 arg_0)
		{
			if (!arg_0.vmethod_1885())
			{
				throw Class_417.xmethod_3101(arg_0, "Unexpected end when reading KeyValuePair.");
			}
		}

		// Token: 0x040007A9 RID: 1961
		private const string field_0 = "Key";

		// Token: 0x040007AA RID: 1962
		private const string field_1 = "Value";

		// Token: 0x040007AB RID: 1963
		private static readonly Class_493<Type, Class_491> field_2 = new Class_493<Type, Class_491>(new Func<Type, Class_491>(Class_308.kmethod_2177));
	}
}
