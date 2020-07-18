using System;
using System.Globalization;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020001A1 RID: 417
	public class Class_306 : Class_299
	{
		// Token: 0x06000C08 RID: 3080 RVA: 0x00043390 File Offset: 0x00041590
		public virtual void cmethod_2164(Class_296 arg_0, object obje_0, Class_418 arg_1)
		{
			Class_306.lmethod_2168(obje_0.GetType());
			Class_441 class_ = arg_1.prop_14 as Class_441;
			string str_ = (string)Class_306.field_4.tmethod_4062(obje_0, "Key");
			object obj = Class_306.field_4.tmethod_4062(obje_0, "Value");
			Type type = (obj != null) ? obj.GetType() : null;
			arg_0.kmethod_2007();
			arg_0.gmethod_2013((class_ != null) ? class_.smethod_3590("Key") : "Key");
			arg_0.kmethod_2037(str_);
			arg_0.gmethod_2013((class_ != null) ? class_.smethod_3590("Type") : "Type");
			arg_0.kmethod_2037((type != null) ? type.FullName : null);
			arg_0.gmethod_2013((class_ != null) ? class_.smethod_3590("Value") : "Value");
			if (type != null)
			{
				string str_2;
				if (Class_467.gmethod_3913(obj, type, out str_2))
				{
					arg_0.kmethod_2037(str_2);
				}
				else
				{
					arg_0.cmethod_2074(obj);
				}
			}
			else
			{
				arg_0.gmethod_2033();
			}
			arg_0.lmethod_2008();
		}

		// Token: 0x06000C09 RID: 3081 RVA: 0x000434BC File Offset: 0x000416BC
		private static void vmethod_2165(Class_285 arg_0, string str_0)
		{
			Class_306.dmethod_2166(arg_0);
			if (arg_0.prop_9 != Class_508.PropertyName || !string.Equals(arg_0.prop_10.ToString(), str_0, StringComparison.OrdinalIgnoreCase))
			{
				throw new Class_417("Expected JSON property '{0}'.".FormatWith(CultureInfo.InvariantCulture, str_0));
			}
		}

		// Token: 0x06000C0A RID: 3082 RVA: 0x00043508 File Offset: 0x00041708
		private static void dmethod_2166(Class_285 arg_0)
		{
			if (!arg_0.vmethod_1885())
			{
				throw new Class_417("Unexpected end.");
			}
		}

		// Token: 0x06000C0B RID: 3083 RVA: 0x00043520 File Offset: 0x00041720
		public virtual object kmethod_2167(Class_285 arg_0, Type arg_1, object obje_0, Class_418 arg_2)
		{
			Class_306.lmethod_2168(arg_1);
			object obj = Class_306.field_4.prop_0(new object[0]);
			Class_306.vmethod_2165(arg_0, "Key");
			Class_306.dmethod_2166(arg_0);
			Class_306.field_4.gmethod_4063(obj, "Key", arg_0.prop_10.ToString());
			Class_306.vmethod_2165(arg_0, "Type");
			Class_306.dmethod_2166(arg_0);
			string typeName = arg_0.prop_10.ToString();
			Type type = Type.GetType(typeName);
			Class_306.vmethod_2165(arg_0, "Value");
			Class_306.dmethod_2166(arg_0);
			Class_306.field_4.gmethod_4063(obj, "Value", arg_2.smethod_3170(arg_0, type));
			Class_306.dmethod_2166(arg_0);
			return obj;
		}

		// Token: 0x06000C0C RID: 3084 RVA: 0x000435CC File Offset: 0x000417CC
		private static void lmethod_2168(Type arg_0)
		{
			if (Class_306.field_4 == null)
			{
				Class_306.field_4 = Class_491.vmethod_4065(arg_0, new string[]
				{
					"Key",
					"Value"
				});
			}
		}

		// Token: 0x06000C0D RID: 3085 RVA: 0x0004360E File Offset: 0x0004180E
		public virtual bool pmethod_2169(Type arg_0)
		{
			return arg_0.AssignableToTypeName("System.Data.EntityKeyMember");
		}

		// Token: 0x040007A4 RID: 1956
		private const string field_0 = "System.Data.EntityKeyMember";

		// Token: 0x040007A5 RID: 1957
		private const string field_1 = "Key";

		// Token: 0x040007A6 RID: 1958
		private const string field_2 = "Type";

		// Token: 0x040007A7 RID: 1959
		private const string field_3 = "Value";

		// Token: 0x040007A8 RID: 1960
		private static Class_491 field_4;
	}
}
