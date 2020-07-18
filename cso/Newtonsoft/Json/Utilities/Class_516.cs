using System;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x020002C7 RID: 711
	internal static class Class_516
	{
		// Token: 0x060017AE RID: 6062 RVA: 0x00070200 File Offset: 0x0006E400
		public static bool AssignableToTypeName(this Type type, string fullTypeName, out Type match)
		{
			Type type2 = type;
			while (type2 != null)
			{
				if (string.Equals(type2.FullName, fullTypeName, StringComparison.Ordinal))
				{
					match = type2;
					return true;
				}
				type2 = type2.BaseType;
			}
			foreach (Type type3 in type.GetInterfaces())
			{
				if (string.Equals(type3.Name, fullTypeName, StringComparison.Ordinal))
				{
					match = type;
					return true;
				}
			}
			match = null;
			return false;
		}

		// Token: 0x060017AF RID: 6063 RVA: 0x00070280 File Offset: 0x0006E480
		public static bool AssignableToTypeName(this Type type, string fullTypeName)
		{
			Type type2;
			return type.AssignableToTypeName(fullTypeName, out type2);
		}
	}
}
