using System;
using System.Collections;
using System.Globalization;
using System.Reflection;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020001A0 RID: 416
	public class Class_305 : Class_299
	{
		// Token: 0x06000C03 RID: 3075 RVA: 0x00042F80 File Offset: 0x00041180
		public virtual void smethod_2160(Class_296 arg_0, object obje_0, Class_418 arg_1)
		{
			Class_441 class_ = arg_1.prop_14 as Class_441;
			Type type = obje_0.GetType();
			Class_489<object, object> getUnionFields = Class_484.GetUnionFields;
			object target = null;
			object[] array = new object[3];
			array[0] = obje_0;
			array[1] = type;
			object arg = getUnionFields(target, array);
			object arg2 = Class_484.GetUnionCaseInfo(arg);
			object obj = Class_484.GetUnionCaseFields(arg);
			object obj2 = Class_484.GetUnionCaseInfoName(arg2);
			object[] array2 = obj as object[];
			arg_0.kmethod_2007();
			arg_0.gmethod_2013((class_ != null) ? class_.smethod_3590("Case") : "Case");
			arg_0.kmethod_2037((string)obj2);
			if (array2 != null && array2.Length > 0)
			{
				arg_0.gmethod_2013((class_ != null) ? class_.smethod_3590("Fields") : "Fields");
				arg_1.kmethod_3177(arg_0, obj);
			}
			arg_0.lmethod_2008();
		}

		// Token: 0x06000C04 RID: 3076 RVA: 0x00043064 File Offset: 0x00041264
		public virtual object xmethod_2161(Class_285 arg_0, Type arg_1, object obje_0, Class_418 arg_2)
		{
			if (arg_0.prop_9 == Class_508.Null)
			{
				return null;
			}
			object obj = null;
			string text = null;
			Class_424 class_ = null;
			Class_305.gmethod_2163(arg_0);
			while (arg_0.prop_9 == Class_508.PropertyName)
			{
				string text2 = arg_0.prop_10.ToString();
				if (string.Equals(text2, "Case", StringComparison.OrdinalIgnoreCase))
				{
					Class_305.gmethod_2163(arg_0);
					Class_489<object, object> getUnionCases = Class_484.GetUnionCases;
					object target = null;
					object[] array = new object[2];
					array[0] = arg_1;
					IEnumerable enumerable = (IEnumerable)getUnionCases(target, array);
					text = arg_0.prop_10.ToString();
					foreach (object obj2 in enumerable)
					{
						if ((string)Class_484.GetUnionCaseInfoName(obj2) == text)
						{
							obj = obj2;
							break;
						}
					}
					if (obj == null)
					{
						throw Class_417.xmethod_3101(arg_0, "No union type found with the name '{0}'.".FormatWith(CultureInfo.InvariantCulture, text));
					}
				}
				else
				{
					if (!string.Equals(text2, "Fields", StringComparison.OrdinalIgnoreCase))
					{
						throw Class_417.xmethod_3101(arg_0, "Unexpected property '{0}' found when reading union.".FormatWith(CultureInfo.InvariantCulture, text2));
					}
					Class_305.gmethod_2163(arg_0);
					if (arg_0.prop_9 != Class_508.StartArray)
					{
						throw Class_417.xmethod_3101(arg_0, "Union fields must been an array.");
					}
					class_ = (Class_424)Class_361.dmethod_2566(arg_0);
				}
				Class_305.gmethod_2163(arg_0);
			}
			if (obj == null)
			{
				throw Class_417.xmethod_3101(arg_0, "No '{0}' property with union name found.".FormatWith(CultureInfo.InvariantCulture, "Case"));
			}
			PropertyInfo[] array2 = (PropertyInfo[])Class_484.GetUnionCaseInfoFields(obj, new object[0]);
			object[] array3 = new object[array2.Length];
			if (array2.Length > 0 && class_ == null)
			{
				throw Class_417.xmethod_3101(arg_0, "No '{0}' property with union fields found.".FormatWith(CultureInfo.InvariantCulture, "Fields"));
			}
			if (class_ != null)
			{
				if (array2.Length != class_.prop_9)
				{
					throw Class_417.xmethod_3101(arg_0, "The number of field values does not match the number of properties definied by union '{0}'.".FormatWith(CultureInfo.InvariantCulture, text));
				}
				for (int i = 0; i < class_.prop_9; i++)
				{
					Class_361 class_2 = class_.lmethod_3358(i);
					PropertyInfo propertyInfo = array2[i];
					array3[i] = class_2.vmethod_2565(propertyInfo.PropertyType, arg_2);
				}
			}
			Class_489<object, object> makeUnion = Class_484.MakeUnion;
			object target2 = null;
			object[] array4 = new object[3];
			array4[0] = obj;
			array4[1] = array3;
			return makeUnion(target2, array4);
		}

		// Token: 0x06000C05 RID: 3077 RVA: 0x000432D8 File Offset: 0x000414D8
		public virtual bool tmethod_2162(Type arg_0)
		{
			if (typeof(IEnumerable).IsAssignableFrom(arg_0))
			{
				return false;
			}
			object[] customAttributes = arg_0.GetCustomAttributes(true);
			bool flag = false;
			foreach (object obj in customAttributes)
			{
				Type type = obj.GetType();
				if (type.FullName == "Microsoft.FSharp.Core.CompilationMappingAttribute")
				{
					Class_484.EnsureInitialized(type.Assembly);
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				return false;
			}
			Class_489<object, object> isUnion = Class_484.IsUnion;
			object target = null;
			object[] array2 = new object[2];
			array2[0] = arg_0;
			return (bool)isUnion(target, array2);
		}

		// Token: 0x06000C06 RID: 3078 RVA: 0x00043377 File Offset: 0x00041577
		private static void gmethod_2163(Class_285 arg_0)
		{
			if (!arg_0.vmethod_1885())
			{
				throw Class_417.xmethod_3101(arg_0, "Unexpected end when reading union.");
			}
		}

		// Token: 0x040007A2 RID: 1954
		private const string field_0 = "Case";

		// Token: 0x040007A3 RID: 1955
		private const string field_1 = "Fields";
	}
}
