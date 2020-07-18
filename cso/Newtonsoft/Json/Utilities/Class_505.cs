using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x020002B9 RID: 697
	internal static class Class_505
	{
		// Token: 0x06001724 RID: 5924 RVA: 0x0006D548 File Offset: 0x0006B748
		private static Class_495<string, string> InitializeEnumType(Type type)
		{
			Class_495<string, string> class_ = new Class_495<string, string>(StringComparer.OrdinalIgnoreCase, StringComparer.OrdinalIgnoreCase);
			foreach (FieldInfo fieldInfo in type.GetFields())
			{
				string name = fieldInfo.Name;
				string text = (from EnumMemberAttribute a in fieldInfo.GetCustomAttributes(typeof(EnumMemberAttribute), true)
				select a.Value).SingleOrDefault<string>() ?? fieldInfo.Name;
				string text2;
				if (class_.TryGetBySecond(text, ref text2))
				{
					throw new InvalidOperationException("Enum name '{0}' already exists on enum '{1}'.".FormatWith(CultureInfo.InvariantCulture, text, type.Name));
				}
				class_.Set(name, text);
			}
			return class_;
		}

		// Token: 0x06001725 RID: 5925 RVA: 0x0006D618 File Offset: 0x0006B818
		public static IList<T> GetFlagsValues<T>(T value) where T : struct
		{
			Type typeFromHandle = typeof(T);
			if (!typeFromHandle.IsDefined(typeof(FlagsAttribute), false))
			{
				throw new ArgumentException("Enum type {0} is not a set of flags.".FormatWith(CultureInfo.InvariantCulture, typeFromHandle));
			}
			Type underlyingType = Enum.GetUnderlyingType(value.GetType());
			ulong num = Convert.ToUInt64(value, CultureInfo.InvariantCulture);
			IList<Class_506<ulong>> namesAndValues = Class_505.GetNamesAndValues<T>();
			IList<T> list = new List<T>();
			foreach (Class_506<ulong> class_ in namesAndValues)
			{
				if ((num & class_.Value) == class_.Value && class_.Value != 0UL)
				{
					list.Add((T)((object)Convert.ChangeType(class_.Value, underlyingType, CultureInfo.CurrentCulture)));
				}
			}
			if (list.Count == 0 && namesAndValues.SingleOrDefault((Class_506<ulong> v) => v.Value == 0UL) != null)
			{
				list.Add(default(T));
			}
			return list;
		}

		// Token: 0x06001726 RID: 5926 RVA: 0x0006D74C File Offset: 0x0006B94C
		public static IList<Class_506<ulong>> GetNamesAndValues<T>() where T : struct
		{
			return Class_505.GetNamesAndValues<ulong>(typeof(T));
		}

		// Token: 0x06001727 RID: 5927 RVA: 0x0006D760 File Offset: 0x0006B960
		public static IList<Class_506<TUnderlyingType>> GetNamesAndValues<TUnderlyingType>(Type enumType) where TUnderlyingType : struct
		{
			if (enumType == null)
			{
				throw new ArgumentNullException("enumType");
			}
			Class_517.ArgumentTypeIsEnum(enumType, "enumType");
			IList<object> values = Class_505.GetValues(enumType);
			IList<string> names = Class_505.GetNames(enumType);
			IList<Class_506<TUnderlyingType>> list = new List<Class_506<TUnderlyingType>>();
			for (int i = 0; i < values.Count; i++)
			{
				try
				{
					list.Add(new Class_506<TUnderlyingType>(names[i], (TUnderlyingType)((object)Convert.ChangeType(values[i], typeof(TUnderlyingType), CultureInfo.CurrentCulture))));
				}
				catch (OverflowException innerException)
				{
					throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture, "Value from enum with the underlying type of {0} cannot be added to dictionary with a value type of {1}. Value was too large: {2}", new object[]
					{
						Enum.GetUnderlyingType(enumType),
						typeof(TUnderlyingType),
						Convert.ToUInt64(values[i], CultureInfo.InvariantCulture)
					}), innerException);
				}
			}
			return list;
		}

		// Token: 0x06001728 RID: 5928 RVA: 0x0006D858 File Offset: 0x0006BA58
		public static IList<object> GetValues(Type enumType)
		{
			if (!enumType.IsEnum)
			{
				throw new ArgumentException("Type '" + enumType.Name + "' is not an enum.");
			}
			List<object> list = new List<object>();
			IEnumerable<FieldInfo> enumerable = from f in enumType.GetFields()
			where f.IsLiteral
			select f;
			foreach (FieldInfo fieldInfo in enumerable)
			{
				object value = fieldInfo.GetValue(enumType);
				list.Add(value);
			}
			return list;
		}

		// Token: 0x06001729 RID: 5929 RVA: 0x0006D90C File Offset: 0x0006BB0C
		public static IList<string> GetNames(Type enumType)
		{
			if (!enumType.IsEnum)
			{
				throw new ArgumentException("Type '" + enumType.Name + "' is not an enum.");
			}
			List<string> list = new List<string>();
			IEnumerable<FieldInfo> enumerable = from f in enumType.GetFields()
			where f.IsLiteral
			select f;
			foreach (FieldInfo fieldInfo in enumerable)
			{
				list.Add(fieldInfo.Name);
			}
			return list;
		}

		// Token: 0x0600172A RID: 5930 RVA: 0x0006D9BC File Offset: 0x0006BBBC
		public static object ParseEnumName(string enumText, bool isNullable, Type t)
		{
			if (enumText == string.Empty && isNullable)
			{
				return null;
			}
			Class_495<string, string> map = Class_505.EnumMemberNamesPerType.Get(t);
			string value;
			if (enumText.IndexOf(',') != -1)
			{
				string[] array = enumText.Split(new char[]
				{
					','
				});
				for (int i = 0; i < array.Length; i++)
				{
					string enumText2 = array[i].Trim();
					array[i] = Class_505.ResolvedEnumName(map, enumText2);
				}
				value = string.Join(", ", array);
			}
			else
			{
				value = Class_505.ResolvedEnumName(map, enumText);
			}
			return Enum.Parse(t, value, true);
		}

		// Token: 0x0600172B RID: 5931 RVA: 0x0006DA64 File Offset: 0x0006BC64
		public static string ToEnumName(Type enumType, string enumText, bool camelCaseText)
		{
			Class_495<string, string> class_ = Class_505.EnumMemberNamesPerType.Get(enumType);
			string[] array = enumText.Split(new char[]
			{
				','
			});
			for (int i = 0; i < array.Length; i++)
			{
				string text = array[i].Trim();
				string text2;
				class_.TryGetByFirst(text, ref text2);
				text2 = (text2 ?? text);
				if (camelCaseText)
				{
					text2 = Class_515.ToCamelCase(text2);
				}
				array[i] = text2;
			}
			return string.Join(", ", array);
		}

		// Token: 0x0600172C RID: 5932 RVA: 0x0006DAF0 File Offset: 0x0006BCF0
		private static string ResolvedEnumName(Class_495<string, string> map, string enumText)
		{
			string text;
			map.TryGetBySecond(enumText, ref text);
			text = (text ?? enumText);
			return text;
		}

		// Token: 0x04000C2C RID: 3116
		private static readonly Class_493<Type, Class_495<string, string>> EnumMemberNamesPerType = new Class_493<Type, Class_495<string, string>>(new Func<Type, Class_495<string, string>>(Class_505.InitializeEnumType));
	}
}
