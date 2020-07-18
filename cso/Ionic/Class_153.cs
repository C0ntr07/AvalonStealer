using System;
using System.ComponentModel;
using System.Reflection;

namespace Ionic
{
	// Token: 0x020000C2 RID: 194
	internal sealed class Class_153
	{
		// Token: 0x06000390 RID: 912 RVA: 0x0000237C File Offset: 0x0000057C
		private Class_153()
		{
		}

		// Token: 0x06000391 RID: 913 RVA: 0x0001831C File Offset: 0x0001651C
		internal static string GetDescription(Enum value)
		{
			FieldInfo field = value.GetType().GetField(value.ToString());
			DescriptionAttribute[] array = (DescriptionAttribute[])field.GetCustomAttributes(typeof(DescriptionAttribute), false);
			if (array.Length > 0)
			{
				return array[0].Description;
			}
			return value.ToString();
		}

		// Token: 0x06000392 RID: 914 RVA: 0x0001836E File Offset: 0x0001656E
		internal static object Parse(Type enumType, string stringRepresentation)
		{
			return Class_153.Parse(enumType, stringRepresentation, false);
		}

		// Token: 0x06000393 RID: 915 RVA: 0x00018378 File Offset: 0x00016578
		internal static object Parse(Type enumType, string stringRepresentation, bool ignoreCase)
		{
			if (ignoreCase)
			{
				stringRepresentation = stringRepresentation.ToLower();
			}
			foreach (object obj in Enum.GetValues(enumType))
			{
				Enum @enum = (Enum)obj;
				string text = Class_153.GetDescription(@enum);
				if (ignoreCase)
				{
					text = text.ToLower();
				}
				if (text == stringRepresentation)
				{
					return @enum;
				}
			}
			return Enum.Parse(enumType, stringRepresentation, ignoreCase);
		}
	}
}
