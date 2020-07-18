using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x020002C5 RID: 709
	internal static class Class_515
	{
		// Token: 0x0600179D RID: 6045 RVA: 0x0006FEC8 File Offset: 0x0006E0C8
		public static string FormatWith(this string format, IFormatProvider provider, object arg0)
		{
			return format.FormatWith(provider, new object[]
			{
				arg0
			});
		}

		// Token: 0x0600179E RID: 6046 RVA: 0x0006FEE8 File Offset: 0x0006E0E8
		public static string FormatWith(this string format, IFormatProvider provider, object arg0, object arg1)
		{
			return format.FormatWith(provider, new object[]
			{
				arg0,
				arg1
			});
		}

		// Token: 0x0600179F RID: 6047 RVA: 0x0006FF0C File Offset: 0x0006E10C
		public static string FormatWith(this string format, IFormatProvider provider, object arg0, object arg1, object arg2)
		{
			return format.FormatWith(provider, new object[]
			{
				arg0,
				arg1,
				arg2
			});
		}

		// Token: 0x060017A0 RID: 6048 RVA: 0x0006FF38 File Offset: 0x0006E138
		public static string FormatWith(this string format, IFormatProvider provider, object arg0, object arg1, object arg2, object arg3)
		{
			return format.FormatWith(provider, new object[]
			{
				arg0,
				arg1,
				arg2,
				arg3
			});
		}

		// Token: 0x060017A1 RID: 6049 RVA: 0x0006FF66 File Offset: 0x0006E166
		private static string FormatWith(this string format, IFormatProvider provider, params object[] args)
		{
			Class_517.ArgumentNotNull(format, "format");
			return string.Format(provider, format, args);
		}

		// Token: 0x060017A2 RID: 6050 RVA: 0x0006FF7C File Offset: 0x0006E17C
		public static bool IsWhiteSpace(string s)
		{
			if (s == null)
			{
				throw new ArgumentNullException("s");
			}
			if (s.Length == 0)
			{
				return false;
			}
			for (int i = 0; i < s.Length; i++)
			{
				if (!char.IsWhiteSpace(s[i]))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060017A3 RID: 6051 RVA: 0x0006FFCF File Offset: 0x0006E1CF
		public static string NullEmptyString(string s)
		{
			if (!string.IsNullOrEmpty(s))
			{
				return s;
			}
			return null;
		}

		// Token: 0x060017A4 RID: 6052 RVA: 0x0006FFE0 File Offset: 0x0006E1E0
		public static StringWriter CreateStringWriter(int capacity)
		{
			StringBuilder sb = new StringBuilder(capacity);
			return new StringWriter(sb, CultureInfo.InvariantCulture);
		}

		// Token: 0x060017A5 RID: 6053 RVA: 0x00070004 File Offset: 0x0006E204
		public static int? GetLength(string value)
		{
			if (value == null)
			{
				return null;
			}
			return new int?(value.Length);
		}

		// Token: 0x060017A6 RID: 6054 RVA: 0x0007002C File Offset: 0x0006E22C
		public static void ToCharAsUnicode(char c, char[] buffer)
		{
			buffer[0] = '\\';
			buffer[1] = 'u';
			buffer[2] = Class_511.IntToHex((int)(c >> 12 & '\u000f'));
			buffer[3] = Class_511.IntToHex((int)(c >> 8 & '\u000f'));
			buffer[4] = Class_511.IntToHex((int)(c >> 4 & '\u000f'));
			buffer[5] = Class_511.IntToHex((int)(c & '\u000f'));
		}

		// Token: 0x060017A7 RID: 6055 RVA: 0x0007007C File Offset: 0x0006E27C
		public static TSource ForgivingCaseSensitiveFind<TSource>(this IEnumerable<TSource> source, Func<TSource, string> valueSelector, string testValue)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			if (valueSelector == null)
			{
				throw new ArgumentNullException("valueSelector");
			}
			IEnumerable<TSource> source2 = from s in source
			where string.Equals(valueSelector(s), testValue, StringComparison.OrdinalIgnoreCase)
			select s;
			if (source2.Count<TSource>() <= 1)
			{
				return source2.SingleOrDefault<TSource>();
			}
			IEnumerable<TSource> source3 = from s in source
			where string.Equals(valueSelector(s), testValue, StringComparison.Ordinal)
			select s;
			return source3.SingleOrDefault<TSource>();
		}

		// Token: 0x060017A8 RID: 6056 RVA: 0x00070110 File Offset: 0x0006E310
		public static string ToCamelCase(string s)
		{
			if (string.IsNullOrEmpty(s))
			{
				return s;
			}
			if (!char.IsUpper(s[0]))
			{
				return s;
			}
			char[] array = s.ToCharArray();
			for (int i = 0; i < array.Length; i++)
			{
				bool flag = i + 1 < array.Length;
				if (i > 0 && flag && !char.IsUpper(array[i + 1]))
				{
					break;
				}
				array[i] = char.ToLower(array[i], CultureInfo.InvariantCulture);
			}
			return new string(array);
		}

		// Token: 0x060017A9 RID: 6057 RVA: 0x00070190 File Offset: 0x0006E390
		public static bool StartsWith(this string source, char value)
		{
			return source.Length > 0 && source[0] == value;
		}

		// Token: 0x060017AA RID: 6058 RVA: 0x000701AA File Offset: 0x0006E3AA
		public static bool EndsWith(this string source, char value)
		{
			return source.Length > 0 && source[source.Length - 1] == value;
		}

		// Token: 0x04000C54 RID: 3156
		public const string CarriageReturnLineFeed = "\r\n";

		// Token: 0x04000C55 RID: 3157
		public const string Empty = "";

		// Token: 0x04000C56 RID: 3158
		public const char CarriageReturn = '\r';

		// Token: 0x04000C57 RID: 3159
		public const char LineFeed = '\n';

		// Token: 0x04000C58 RID: 3160
		public const char Tab = '\t';
	}
}
