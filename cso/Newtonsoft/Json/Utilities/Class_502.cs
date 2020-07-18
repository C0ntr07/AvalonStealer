using System;
using System.Globalization;
using System.IO;
using System.Xml;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x020002B5 RID: 693
	internal static class Class_502
	{
		// Token: 0x060016E3 RID: 5859 RVA: 0x0006C1A6 File Offset: 0x0006A3A6
		public static TimeSpan GetUtcOffset(this DateTime d)
		{
			return TimeZoneInfo.Local.GetUtcOffset(d);
		}

		// Token: 0x060016E4 RID: 5860 RVA: 0x0006C1B4 File Offset: 0x0006A3B4
		public static XmlDateTimeSerializationMode ToSerializationMode(DateTimeKind kind)
		{
			switch (kind)
			{
			case DateTimeKind.Unspecified:
				return XmlDateTimeSerializationMode.Unspecified;
			case DateTimeKind.Utc:
				return XmlDateTimeSerializationMode.Utc;
			case DateTimeKind.Local:
				return XmlDateTimeSerializationMode.Local;
			default:
				throw Class_513.CreateArgumentOutOfRangeException("kind", kind, "Unexpected DateTimeKind value.");
			}
		}

		// Token: 0x060016E5 RID: 5861 RVA: 0x0006C1F8 File Offset: 0x0006A3F8
		internal static DateTime EnsureDateTime(DateTime value, Class_321 timeZone)
		{
			switch (timeZone)
			{
			case Class_321.Local:
				value = Class_502.SwitchToLocalTime(value);
				break;
			case Class_321.Utc:
				value = Class_502.SwitchToUtcTime(value);
				break;
			case Class_321.Unspecified:
				value = new DateTime(value.Ticks, DateTimeKind.Unspecified);
				break;
			case Class_321.RoundtripKind:
				break;
			default:
				throw new ArgumentException("Invalid date time handling value.");
			}
			return value;
		}

		// Token: 0x060016E6 RID: 5862 RVA: 0x0006C25C File Offset: 0x0006A45C
		private static DateTime SwitchToLocalTime(DateTime value)
		{
			switch (value.Kind)
			{
			case DateTimeKind.Unspecified:
				return new DateTime(value.Ticks, DateTimeKind.Local);
			case DateTimeKind.Utc:
				return value.ToLocalTime();
			case DateTimeKind.Local:
				return value;
			default:
				return value;
			}
		}

		// Token: 0x060016E7 RID: 5863 RVA: 0x0006C2A4 File Offset: 0x0006A4A4
		private static DateTime SwitchToUtcTime(DateTime value)
		{
			switch (value.Kind)
			{
			case DateTimeKind.Unspecified:
				return new DateTime(value.Ticks, DateTimeKind.Utc);
			case DateTimeKind.Utc:
				return value;
			case DateTimeKind.Local:
				return value.ToUniversalTime();
			default:
				return value;
			}
		}

		// Token: 0x060016E8 RID: 5864 RVA: 0x0006C2E9 File Offset: 0x0006A4E9
		private static long ToUniversalTicks(DateTime dateTime)
		{
			if (dateTime.Kind == DateTimeKind.Utc)
			{
				return dateTime.Ticks;
			}
			return Class_502.ToUniversalTicks(dateTime, dateTime.GetUtcOffset());
		}

		// Token: 0x060016E9 RID: 5865 RVA: 0x0006C30C File Offset: 0x0006A50C
		private static long ToUniversalTicks(DateTime dateTime, TimeSpan offset)
		{
			if (dateTime.Kind == DateTimeKind.Utc || dateTime == DateTime.MaxValue || dateTime == DateTime.MinValue)
			{
				return dateTime.Ticks;
			}
			long num = dateTime.Ticks - offset.Ticks;
			if (num > 3155378975999999999L)
			{
				return 3155378975999999999L;
			}
			if (num < 0L)
			{
				return 0L;
			}
			return num;
		}

		// Token: 0x060016EA RID: 5866 RVA: 0x0006C384 File Offset: 0x0006A584
		internal static long ConvertDateTimeToJavaScriptTicks(DateTime dateTime, TimeSpan offset)
		{
			long universialTicks = Class_502.ToUniversalTicks(dateTime, offset);
			return Class_502.UniversialTicksToJavaScriptTicks(universialTicks);
		}

		// Token: 0x060016EB RID: 5867 RVA: 0x0006C39F File Offset: 0x0006A59F
		internal static long ConvertDateTimeToJavaScriptTicks(DateTime dateTime)
		{
			return Class_502.ConvertDateTimeToJavaScriptTicks(dateTime, true);
		}

		// Token: 0x060016EC RID: 5868 RVA: 0x0006C3A8 File Offset: 0x0006A5A8
		internal static long ConvertDateTimeToJavaScriptTicks(DateTime dateTime, bool convertToUtc)
		{
			long universialTicks = convertToUtc ? Class_502.ToUniversalTicks(dateTime) : dateTime.Ticks;
			return Class_502.UniversialTicksToJavaScriptTicks(universialTicks);
		}

		// Token: 0x060016ED RID: 5869 RVA: 0x0006C3D4 File Offset: 0x0006A5D4
		private static long UniversialTicksToJavaScriptTicks(long universialTicks)
		{
			return (universialTicks - Class_502.InitialJavaScriptDateTicks) / 10000L;
		}

		// Token: 0x060016EE RID: 5870 RVA: 0x0006C3F4 File Offset: 0x0006A5F4
		internal static DateTime ConvertJavaScriptTicksToDateTime(long javaScriptTicks)
		{
			DateTime result = new DateTime(javaScriptTicks * 10000L + Class_502.InitialJavaScriptDateTicks, DateTimeKind.Utc);
			return result;
		}

		// Token: 0x060016EF RID: 5871 RVA: 0x0006C418 File Offset: 0x0006A618
		internal static bool TryParseDateIso(string text, Class_320 dateParseHandling, Class_321 dateTimeZoneHandling, out object dt)
		{
			Class_358 class_ = default(Class_358);
			if (!class_.Parse(text))
			{
				dt = null;
				return false;
			}
			DateTime dateTime = new DateTime(class_.Year, class_.Month, class_.Day, class_.Hour, class_.Minute, class_.Second);
			dateTime = dateTime.AddTicks((long)class_.Fraction);
			if (dateParseHandling != Class_320.DateTimeOffset)
			{
				switch (class_.Zone)
				{
				case Class_357.Utc:
					dateTime = new DateTime(dateTime.Ticks, DateTimeKind.Utc);
					break;
				case Class_357.LocalWestOfUtc:
				{
					TimeSpan timeSpan = new TimeSpan(class_.ZoneHour, class_.ZoneMinute, 0);
					long num = dateTime.Ticks + timeSpan.Ticks;
					if (num <= DateTime.MaxValue.Ticks)
					{
						dateTime = new DateTime(num, DateTimeKind.Utc).ToLocalTime();
					}
					else
					{
						num += dateTime.GetUtcOffset().Ticks;
						if (num > DateTime.MaxValue.Ticks)
						{
							num = DateTime.MaxValue.Ticks;
						}
						dateTime = new DateTime(num, DateTimeKind.Local);
					}
					break;
				}
				case Class_357.LocalEastOfUtc:
				{
					TimeSpan timeSpan2 = new TimeSpan(class_.ZoneHour, class_.ZoneMinute, 0);
					long num = dateTime.Ticks - timeSpan2.Ticks;
					if (num >= DateTime.MinValue.Ticks)
					{
						dateTime = new DateTime(num, DateTimeKind.Utc).ToLocalTime();
					}
					else
					{
						num += dateTime.GetUtcOffset().Ticks;
						if (num < DateTime.MinValue.Ticks)
						{
							num = DateTime.MinValue.Ticks;
						}
						dateTime = new DateTime(num, DateTimeKind.Local);
					}
					break;
				}
				}
				dt = Class_502.EnsureDateTime(dateTime, dateTimeZoneHandling);
				return true;
			}
			TimeSpan utcOffset;
			switch (class_.Zone)
			{
			case Class_357.Utc:
				utcOffset = new TimeSpan(0L);
				break;
			case Class_357.LocalWestOfUtc:
				utcOffset = new TimeSpan(-class_.ZoneHour, -class_.ZoneMinute, 0);
				break;
			case Class_357.LocalEastOfUtc:
				utcOffset = new TimeSpan(class_.ZoneHour, class_.ZoneMinute, 0);
				break;
			default:
				utcOffset = TimeZoneInfo.Local.GetUtcOffset(dateTime);
				break;
			}
			long num2 = dateTime.Ticks - utcOffset.Ticks;
			if (num2 < 0L || num2 > 3155378975999999999L)
			{
				dt = null;
				return false;
			}
			dt = new DateTimeOffset(dateTime, utcOffset);
			return true;
		}

		// Token: 0x060016F0 RID: 5872 RVA: 0x0006C6B0 File Offset: 0x0006A8B0
		internal static bool TryParseDateTime(string s, Class_320 dateParseHandling, Class_321 dateTimeZoneHandling, string dateFormatString, CultureInfo culture, out object dt)
		{
			if (s.Length > 0)
			{
				if (s[0] == '/')
				{
					if (s.StartsWith("/Date(", StringComparison.Ordinal) && s.EndsWith(")/", StringComparison.Ordinal) && Class_502.TryParseDateMicrosoft(s, dateParseHandling, dateTimeZoneHandling, out dt))
					{
						return true;
					}
				}
				else if (s.Length >= 19 && s.Length <= 40 && char.IsDigit(s[0]) && s[10] == 'T' && Class_502.TryParseDateIso(s, dateParseHandling, dateTimeZoneHandling, out dt))
				{
					return true;
				}
				if (!string.IsNullOrEmpty(dateFormatString) && Class_502.TryParseDateExact(s, dateParseHandling, dateTimeZoneHandling, dateFormatString, culture, out dt))
				{
					return true;
				}
			}
			dt = null;
			return false;
		}

		// Token: 0x060016F1 RID: 5873 RVA: 0x0006C77C File Offset: 0x0006A97C
		private static bool TryParseDateMicrosoft(string text, Class_320 dateParseHandling, Class_321 dateTimeZoneHandling, out object dt)
		{
			string text2 = text.Substring(6, text.Length - 8);
			DateTimeKind dateTimeKind = DateTimeKind.Utc;
			int num = text2.IndexOf('+', 1);
			if (num == -1)
			{
				num = text2.IndexOf('-', 1);
			}
			TimeSpan timeSpan = TimeSpan.Zero;
			if (num != -1)
			{
				dateTimeKind = DateTimeKind.Local;
				timeSpan = Class_502.ReadOffset(text2.Substring(num));
				text2 = text2.Substring(0, num);
			}
			long javaScriptTicks;
			if (!long.TryParse(text2, NumberStyles.Integer, CultureInfo.InvariantCulture, out javaScriptTicks))
			{
				dt = null;
				return false;
			}
			DateTime dateTime = Class_502.ConvertJavaScriptTicksToDateTime(javaScriptTicks);
			if (dateParseHandling == Class_320.DateTimeOffset)
			{
				dt = new DateTimeOffset(dateTime.Add(timeSpan).Ticks, timeSpan);
				return true;
			}
			DateTime value;
			switch (dateTimeKind)
			{
			case DateTimeKind.Unspecified:
				value = DateTime.SpecifyKind(dateTime.ToLocalTime(), DateTimeKind.Unspecified);
				goto IL_DB;
			case DateTimeKind.Local:
				value = dateTime.ToLocalTime();
				goto IL_DB;
			}
			value = dateTime;
			IL_DB:
			dt = Class_502.EnsureDateTime(value, dateTimeZoneHandling);
			return true;
		}

		// Token: 0x060016F2 RID: 5874 RVA: 0x0006C874 File Offset: 0x0006AA74
		private static bool TryParseDateExact(string text, Class_320 dateParseHandling, Class_321 dateTimeZoneHandling, string dateFormatString, CultureInfo culture, out object dt)
		{
			DateTime dateTime;
			if (dateParseHandling == Class_320.DateTimeOffset)
			{
				DateTimeOffset dateTimeOffset;
				if (DateTimeOffset.TryParseExact(text, dateFormatString, culture, DateTimeStyles.RoundtripKind, out dateTimeOffset))
				{
					dt = dateTimeOffset;
					return true;
				}
			}
			else if (DateTime.TryParseExact(text, dateFormatString, culture, DateTimeStyles.RoundtripKind, out dateTime))
			{
				dateTime = Class_502.EnsureDateTime(dateTime, dateTimeZoneHandling);
				dt = dateTime;
				return true;
			}
			dt = null;
			return false;
		}

		// Token: 0x060016F3 RID: 5875 RVA: 0x0006C8D8 File Offset: 0x0006AAD8
		private static TimeSpan ReadOffset(string offsetText)
		{
			bool flag = offsetText[0] == '-';
			int num = int.Parse(offsetText.Substring(1, 2), NumberStyles.Integer, CultureInfo.InvariantCulture);
			int num2 = 0;
			if (offsetText.Length >= 5)
			{
				num2 = int.Parse(offsetText.Substring(3, 2), NumberStyles.Integer, CultureInfo.InvariantCulture);
			}
			TimeSpan result = TimeSpan.FromHours((double)num) + TimeSpan.FromMinutes((double)num2);
			if (flag)
			{
				result = result.Negate();
			}
			return result;
		}

		// Token: 0x060016F4 RID: 5876 RVA: 0x0006C94C File Offset: 0x0006AB4C
		internal static void WriteDateTimeString(TextWriter writer, DateTime value, Class_319 format, string formatString, CultureInfo culture)
		{
			if (string.IsNullOrEmpty(formatString))
			{
				char[] array = new char[64];
				int count = Class_502.WriteDateTimeString(array, 0, value, null, value.Kind, format);
				writer.Write(array, 0, count);
				return;
			}
			writer.Write(value.ToString(formatString, culture));
		}

		// Token: 0x060016F5 RID: 5877 RVA: 0x0006C9A0 File Offset: 0x0006ABA0
		internal static int WriteDateTimeString(char[] chars, int start, DateTime value, TimeSpan? offset, DateTimeKind kind, Class_319 format)
		{
			int num2;
			if (format == Class_319.MicrosoftDateFormat)
			{
				TimeSpan offset2 = offset ?? value.GetUtcOffset();
				long num = Class_502.ConvertDateTimeToJavaScriptTicks(value, offset2);
				"\\/Date(".CopyTo(0, chars, start, 7);
				num2 = start + 7;
				string text = num.ToString(CultureInfo.InvariantCulture);
				text.CopyTo(0, chars, num2, text.Length);
				num2 += text.Length;
				switch (kind)
				{
				case DateTimeKind.Unspecified:
					if (value != DateTime.MaxValue && value != DateTime.MinValue)
					{
						num2 = Class_502.WriteDateTimeOffset(chars, num2, offset2, format);
					}
					break;
				case DateTimeKind.Local:
					num2 = Class_502.WriteDateTimeOffset(chars, num2, offset2, format);
					break;
				}
				")\\/".CopyTo(0, chars, num2, 3);
				num2 += 3;
			}
			else
			{
				num2 = Class_502.WriteDefaultIsoDate(chars, start, value);
				switch (kind)
				{
				case DateTimeKind.Utc:
					chars[num2++] = 'Z';
					break;
				case DateTimeKind.Local:
					num2 = Class_502.WriteDateTimeOffset(chars, num2, offset ?? value.GetUtcOffset(), format);
					break;
				}
			}
			return num2;
		}

		// Token: 0x060016F6 RID: 5878 RVA: 0x0006CAE8 File Offset: 0x0006ACE8
		internal static int WriteDefaultIsoDate(char[] chars, int start, DateTime dt)
		{
			int num = 19;
			int value;
			int value2;
			int value3;
			Class_502.GetDateValues(dt, out value, out value2, out value3);
			Class_502.CopyIntToCharArray(chars, start, value, 4);
			chars[start + 4] = '-';
			Class_502.CopyIntToCharArray(chars, start + 5, value2, 2);
			chars[start + 7] = '-';
			Class_502.CopyIntToCharArray(chars, start + 8, value3, 2);
			chars[start + 10] = 'T';
			Class_502.CopyIntToCharArray(chars, start + 11, dt.Hour, 2);
			chars[start + 13] = ':';
			Class_502.CopyIntToCharArray(chars, start + 14, dt.Minute, 2);
			chars[start + 16] = ':';
			Class_502.CopyIntToCharArray(chars, start + 17, dt.Second, 2);
			int num2 = (int)(dt.Ticks % 10000000L);
			if (num2 != 0)
			{
				int num3 = 7;
				while (num2 % 10 == 0)
				{
					num3--;
					num2 /= 10;
				}
				chars[start + 19] = '.';
				Class_502.CopyIntToCharArray(chars, start + 20, num2, num3);
				num += num3 + 1;
			}
			return start + num;
		}

		// Token: 0x060016F7 RID: 5879 RVA: 0x0006CBD3 File Offset: 0x0006ADD3
		private static void CopyIntToCharArray(char[] chars, int start, int value, int digits)
		{
			while (digits-- != 0)
			{
				chars[start + digits] = (char)(value % 10 + 48);
				value /= 10;
			}
		}

		// Token: 0x060016F8 RID: 5880 RVA: 0x0006CBF8 File Offset: 0x0006ADF8
		internal static int WriteDateTimeOffset(char[] chars, int start, TimeSpan offset, Class_319 format)
		{
			chars[start++] = ((offset.Ticks >= 0L) ? '+' : '-');
			int value = Math.Abs(offset.Hours);
			Class_502.CopyIntToCharArray(chars, start, value, 2);
			start += 2;
			if (format == Class_319.IsoDateFormat)
			{
				chars[start++] = ':';
			}
			int value2 = Math.Abs(offset.Minutes);
			Class_502.CopyIntToCharArray(chars, start, value2, 2);
			start += 2;
			return start;
		}

		// Token: 0x060016F9 RID: 5881 RVA: 0x0006CC6C File Offset: 0x0006AE6C
		internal static void WriteDateTimeOffsetString(TextWriter writer, DateTimeOffset value, Class_319 format, string formatString, CultureInfo culture)
		{
			if (string.IsNullOrEmpty(formatString))
			{
				char[] array = new char[64];
				int count = Class_502.WriteDateTimeString(array, 0, (format == Class_319.IsoDateFormat) ? value.DateTime : value.UtcDateTime, new TimeSpan?(value.Offset), DateTimeKind.Local, format);
				writer.Write(array, 0, count);
				return;
			}
			writer.Write(value.ToString(formatString, culture));
		}

		// Token: 0x060016FA RID: 5882 RVA: 0x0006CCD8 File Offset: 0x0006AED8
		private static void GetDateValues(DateTime td, out int year, out int month, out int day)
		{
			long ticks = td.Ticks;
			int i = (int)(ticks / 864000000000L);
			int num = i / 146097;
			i -= num * 146097;
			int num2 = i / 36524;
			if (num2 == 4)
			{
				num2 = 3;
			}
			i -= num2 * 36524;
			int num3 = i / 1461;
			i -= num3 * 1461;
			int num4 = i / 365;
			if (num4 == 4)
			{
				num4 = 3;
			}
			year = num * 400 + num2 * 100 + num3 * 4 + num4 + 1;
			i -= num4 * 365;
			int[] array = (num4 == 3 && (num3 != 24 || num2 == 3)) ? Class_502.DaysToMonth366 : Class_502.DaysToMonth365;
			int num5 = i >> 6;
			while (i >= array[num5])
			{
				num5++;
			}
			month = num5;
			day = i - array[num5 - 1] + 1;
		}

		// Token: 0x04000C1F RID: 3103
		private const int DaysPer100Years = 36524;

		// Token: 0x04000C20 RID: 3104
		private const int DaysPer400Years = 146097;

		// Token: 0x04000C21 RID: 3105
		private const int DaysPer4Years = 1461;

		// Token: 0x04000C22 RID: 3106
		private const int DaysPerYear = 365;

		// Token: 0x04000C23 RID: 3107
		private const long TicksPerDay = 864000000000L;

		// Token: 0x04000C24 RID: 3108
		internal static readonly long InitialJavaScriptDateTicks = 621355968000000000L;

		// Token: 0x04000C25 RID: 3109
		private static readonly int[] DaysToMonth365 = new int[]
		{
			0,
			31,
			59,
			90,
			120,
			151,
			181,
			212,
			243,
			273,
			304,
			334,
			365
		};

		// Token: 0x04000C26 RID: 3110
		private static readonly int[] DaysToMonth366 = new int[]
		{
			0,
			31,
			60,
			91,
			121,
			152,
			182,
			213,
			244,
			274,
			305,
			335,
			366
		};
	}
}
