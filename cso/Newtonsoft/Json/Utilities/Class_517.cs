using System;
using System.Globalization;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x020002C8 RID: 712
	internal static class Class_517
	{
		// Token: 0x060017B0 RID: 6064 RVA: 0x00070296 File Offset: 0x0006E496
		public static void ArgumentNotNullOrEmpty(string value, string parameterName)
		{
			if (value == null)
			{
				throw new ArgumentNullException(parameterName);
			}
			if (value.Length == 0)
			{
				throw new ArgumentException("'{0}' cannot be empty.".FormatWith(CultureInfo.InvariantCulture, parameterName), parameterName);
			}
		}

		// Token: 0x060017B1 RID: 6065 RVA: 0x000702C7 File Offset: 0x0006E4C7
		public static void ArgumentTypeIsEnum(Type enumType, string parameterName)
		{
			Class_517.ArgumentNotNull(enumType, "enumType");
			if (!enumType.IsEnum)
			{
				throw new ArgumentException("Type {0} is not an Enum.".FormatWith(CultureInfo.InvariantCulture, enumType), parameterName);
			}
		}

		// Token: 0x060017B2 RID: 6066 RVA: 0x000702F6 File Offset: 0x0006E4F6
		public static void ArgumentNotNull(object value, string parameterName)
		{
			if (value == null)
			{
				throw new ArgumentNullException(parameterName);
			}
		}
	}
}
