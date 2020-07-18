using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Globalization;
using System.Numerics;
using System.Reflection;
using Newtonsoft.Json.Serialization;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x020002AF RID: 687
	internal static class Class_499
	{
		// Token: 0x060016AD RID: 5805 RVA: 0x0006AC0C File Offset: 0x00068E0C
		public static Class_496 GetTypeCode(Type t)
		{
			bool flag;
			return Class_499.GetTypeCode(t, out flag);
		}

		// Token: 0x060016AE RID: 5806 RVA: 0x0006AC24 File Offset: 0x00068E24
		public static Class_496 GetTypeCode(Type t, out bool isEnum)
		{
			Class_496 result;
			if (Class_499.TypeCodeMap.TryGetValue(t, out result))
			{
				isEnum = false;
				return result;
			}
			if (t.IsEnum)
			{
				isEnum = true;
				return Class_499.GetTypeCode(Enum.GetUnderlyingType(t));
			}
			if (Class_514.IsNullableType(t))
			{
				Type underlyingType = Nullable.GetUnderlyingType(t);
				if (underlyingType.IsEnum)
				{
					Type t2 = typeof(Nullable<>).MakeGenericType(new Type[]
					{
						Enum.GetUnderlyingType(underlyingType)
					});
					isEnum = true;
					return Class_499.GetTypeCode(t2);
				}
			}
			isEnum = false;
			return Class_496.Object;
		}

		// Token: 0x060016AF RID: 5807 RVA: 0x0006ACB4 File Offset: 0x00068EB4
		public static Class_497 GetTypeInformation(IConvertible convertable)
		{
			return Class_499.PrimitiveTypeCodes[(int)convertable.GetTypeCode()];
		}

		// Token: 0x060016B0 RID: 5808 RVA: 0x0006ACD3 File Offset: 0x00068ED3
		public static bool IsConvertible(Type t)
		{
			return typeof(IConvertible).IsAssignableFrom(t);
		}

		// Token: 0x060016B1 RID: 5809 RVA: 0x0006ACE5 File Offset: 0x00068EE5
		public static TimeSpan ParseTimeSpan(string input)
		{
			return TimeSpan.Parse(input, CultureInfo.InvariantCulture);
		}

		// Token: 0x060016B2 RID: 5810 RVA: 0x0006ACF4 File Offset: 0x00068EF4
		private static Func<object, object> CreateCastConverter(Class_499.TypeConvertKey t)
		{
			MethodInfo method = t.TargetType.GetMethod("op_Implicit", new Type[]
			{
				t.InitialType
			});
			if (method == null)
			{
				method = t.TargetType.GetMethod("op_Explicit", new Type[]
				{
					t.InitialType
				});
			}
			if (method == null)
			{
				return null;
			}
			Class_489<object, object> call = Class_470.ReflectionDelegateFactory.lmethod_4008<object>(method);
			return (object o) => call(null, new object[]
			{
				o
			});
		}

		// Token: 0x060016B3 RID: 5811 RVA: 0x0006AD90 File Offset: 0x00068F90
		internal static BigInteger ToBigInteger(object value)
		{
			if (value is BigInteger)
			{
				return (BigInteger)value;
			}
			if (value is string)
			{
				return BigInteger.Parse((string)value, CultureInfo.InvariantCulture);
			}
			if (value is float)
			{
				return new BigInteger((float)value);
			}
			if (value is double)
			{
				return new BigInteger((double)value);
			}
			if (value is decimal)
			{
				return new BigInteger((decimal)value);
			}
			if (value is int)
			{
				return new BigInteger((int)value);
			}
			if (value is long)
			{
				return new BigInteger((long)value);
			}
			if (value is uint)
			{
				return new BigInteger((uint)value);
			}
			if (value is ulong)
			{
				return new BigInteger((ulong)value);
			}
			if (value is byte[])
			{
				return new BigInteger((byte[])value);
			}
			throw new InvalidCastException("Cannot convert {0} to BigInteger.".FormatWith(CultureInfo.InvariantCulture, value.GetType()));
		}

		// Token: 0x060016B4 RID: 5812 RVA: 0x0006AEA0 File Offset: 0x000690A0
		public static object FromBigInteger(BigInteger i, Type targetType)
		{
			if (targetType == typeof(decimal))
			{
				return (decimal)i;
			}
			if (targetType == typeof(double))
			{
				return (double)i;
			}
			if (targetType == typeof(float))
			{
				return (float)i;
			}
			if (targetType == typeof(ulong))
			{
				return (ulong)i;
			}
			object result;
			try
			{
				result = System.Convert.ChangeType((long)i, targetType, CultureInfo.InvariantCulture);
			}
			catch (Exception innerException)
			{
				throw new InvalidOperationException("Can not convert from BigInteger to {0}.".FormatWith(CultureInfo.InvariantCulture, targetType), innerException);
			}
			return result;
		}

		// Token: 0x060016B5 RID: 5813 RVA: 0x0006AF78 File Offset: 0x00069178
		public static object Convert(object initialValue, CultureInfo culture, Type targetType)
		{
			object result;
			switch (Class_499.TryConvertInternal(initialValue, culture, targetType, out result))
			{
			case Class_499.ConvertResult.Success:
				return result;
			case Class_499.ConvertResult.CannotConvertNull:
				throw new Exception("Can not convert null {0} into non-nullable {1}.".FormatWith(CultureInfo.InvariantCulture, initialValue.GetType(), targetType));
			case Class_499.ConvertResult.NotInstantiableType:
				throw new ArgumentException("Target type {0} is not a value type or a non-abstract class.".FormatWith(CultureInfo.InvariantCulture, targetType), "targetType");
			case Class_499.ConvertResult.NoValidConversion:
				throw new InvalidOperationException("Can not convert from {0} to {1}.".FormatWith(CultureInfo.InvariantCulture, initialValue.GetType(), targetType));
			default:
				throw new InvalidOperationException("Unexpected conversion result.");
			}
		}

		// Token: 0x060016B6 RID: 5814 RVA: 0x0006B00C File Offset: 0x0006920C
		private static bool TryConvert(object initialValue, CultureInfo culture, Type targetType, out object value)
		{
			bool result;
			try
			{
				if (Class_499.TryConvertInternal(initialValue, culture, targetType, out value) == Class_499.ConvertResult.Success)
				{
					result = true;
				}
				else
				{
					value = null;
					result = false;
				}
			}
			catch
			{
				value = null;
				result = false;
			}
			return result;
		}

		// Token: 0x060016B7 RID: 5815 RVA: 0x0006B054 File Offset: 0x00069254
		private static Class_499.ConvertResult TryConvertInternal(object initialValue, CultureInfo culture, Type targetType, out object value)
		{
			if (initialValue == null)
			{
				throw new ArgumentNullException("initialValue");
			}
			if (Class_514.IsNullableType(targetType))
			{
				targetType = Nullable.GetUnderlyingType(targetType);
			}
			Type type = initialValue.GetType();
			if (targetType == type)
			{
				value = initialValue;
				return Class_499.ConvertResult.Success;
			}
			if (Class_499.IsConvertible(initialValue.GetType()) && Class_499.IsConvertible(targetType))
			{
				if (targetType.IsEnum)
				{
					if (initialValue is string)
					{
						value = Enum.Parse(targetType, initialValue.ToString(), true);
						return Class_499.ConvertResult.Success;
					}
					if (Class_499.IsInteger(initialValue))
					{
						value = Enum.ToObject(targetType, initialValue);
						return Class_499.ConvertResult.Success;
					}
				}
				value = System.Convert.ChangeType(initialValue, targetType, culture);
				return Class_499.ConvertResult.Success;
			}
			if (initialValue is DateTime && targetType == typeof(DateTimeOffset))
			{
				value = new DateTimeOffset((DateTime)initialValue);
				return Class_499.ConvertResult.Success;
			}
			if (initialValue is byte[] && targetType == typeof(Guid))
			{
				value = new Guid((byte[])initialValue);
				return Class_499.ConvertResult.Success;
			}
			if (initialValue is Guid && targetType == typeof(byte[]))
			{
				value = ((Guid)initialValue).ToByteArray();
				return Class_499.ConvertResult.Success;
			}
			if (initialValue is string)
			{
				if (targetType == typeof(Guid))
				{
					value = new Guid((string)initialValue);
					return Class_499.ConvertResult.Success;
				}
				if (targetType == typeof(Uri))
				{
					value = new Uri((string)initialValue, UriKind.RelativeOrAbsolute);
					return Class_499.ConvertResult.Success;
				}
				if (targetType == typeof(TimeSpan))
				{
					value = Class_499.ParseTimeSpan((string)initialValue);
					return Class_499.ConvertResult.Success;
				}
				if (targetType == typeof(byte[]))
				{
					value = System.Convert.FromBase64String((string)initialValue);
					return Class_499.ConvertResult.Success;
				}
				if (typeof(Type).IsAssignableFrom(targetType))
				{
					value = Type.GetType((string)initialValue, true);
					return Class_499.ConvertResult.Success;
				}
			}
			if (targetType == typeof(BigInteger))
			{
				value = Class_499.ToBigInteger(initialValue);
				return Class_499.ConvertResult.Success;
			}
			if (initialValue is BigInteger)
			{
				value = Class_499.FromBigInteger((BigInteger)initialValue, targetType);
				return Class_499.ConvertResult.Success;
			}
			TypeConverter typeConverter = Class_470.GetTypeConverter(type);
			if (typeConverter != null && typeConverter.CanConvertTo(targetType))
			{
				value = typeConverter.ConvertTo(null, culture, initialValue, targetType);
				return Class_499.ConvertResult.Success;
			}
			TypeConverter typeConverter2 = Class_470.GetTypeConverter(targetType);
			if (typeConverter2 != null && typeConverter2.CanConvertFrom(type))
			{
				value = typeConverter2.ConvertFrom(null, culture, initialValue);
				return Class_499.ConvertResult.Success;
			}
			if (initialValue == DBNull.Value)
			{
				if (Class_514.IsNullable(targetType))
				{
					value = Class_499.EnsureTypeAssignable(null, type, targetType);
					return Class_499.ConvertResult.Success;
				}
				value = null;
				return Class_499.ConvertResult.CannotConvertNull;
			}
			else
			{
				if (initialValue is INullable)
				{
					value = Class_499.EnsureTypeAssignable(Class_499.ToValue((INullable)initialValue), type, targetType);
					return Class_499.ConvertResult.Success;
				}
				if (targetType.IsInterface || targetType.IsGenericTypeDefinition || targetType.IsAbstract)
				{
					value = null;
					return Class_499.ConvertResult.NotInstantiableType;
				}
				value = null;
				return Class_499.ConvertResult.NoValidConversion;
			}
		}

		// Token: 0x060016B8 RID: 5816 RVA: 0x0006B364 File Offset: 0x00069564
		public static object ConvertOrCast(object initialValue, CultureInfo culture, Type targetType)
		{
			if (targetType == typeof(object))
			{
				return initialValue;
			}
			if (initialValue == null && Class_514.IsNullable(targetType))
			{
				return null;
			}
			object result;
			if (Class_499.TryConvert(initialValue, culture, targetType, out result))
			{
				return result;
			}
			return Class_499.EnsureTypeAssignable(initialValue, Class_514.GetObjectType(initialValue), targetType);
		}

		// Token: 0x060016B9 RID: 5817 RVA: 0x0006B3BC File Offset: 0x000695BC
		private static object EnsureTypeAssignable(object value, Type initialType, Type targetType)
		{
			Type type = (value != null) ? value.GetType() : null;
			if (value != null)
			{
				if (targetType.IsAssignableFrom(type))
				{
					return value;
				}
				Func<object, object> func = Class_499.CastConverters.Get(new Class_499.TypeConvertKey(type, targetType));
				if (func != null)
				{
					return func(value);
				}
			}
			else if (Class_514.IsNullable(targetType))
			{
				return null;
			}
			throw new ArgumentException("Could not cast or convert from {0} to {1}.".FormatWith(CultureInfo.InvariantCulture, (initialType != null) ? initialType.ToString() : "{null}", targetType));
		}

		// Token: 0x060016BA RID: 5818 RVA: 0x0006B450 File Offset: 0x00069650
		public static object ToValue(INullable nullableValue)
		{
			if (nullableValue == null)
			{
				return null;
			}
			if (nullableValue is SqlInt32)
			{
				return Class_499.ToValue((SqlInt32)nullableValue);
			}
			if (nullableValue is SqlInt64)
			{
				return Class_499.ToValue((SqlInt64)nullableValue);
			}
			if (nullableValue is SqlBoolean)
			{
				return Class_499.ToValue((SqlBoolean)nullableValue);
			}
			if (nullableValue is SqlString)
			{
				return Class_499.ToValue((SqlString)nullableValue);
			}
			if (nullableValue is SqlDateTime)
			{
				return Class_499.ToValue((SqlDateTime)nullableValue);
			}
			throw new ArgumentException("Unsupported INullable type: {0}".FormatWith(CultureInfo.InvariantCulture, nullableValue.GetType()));
		}

		// Token: 0x060016BB RID: 5819 RVA: 0x0006B50C File Offset: 0x0006970C
		public static bool IsInteger(object value)
		{
			switch (Class_499.GetTypeCode(value.GetType()))
			{
			case Class_496.SByte:
			case Class_496.Int16:
			case Class_496.UInt16:
			case Class_496.Int32:
			case Class_496.Byte:
			case Class_496.UInt32:
			case Class_496.Int64:
			case Class_496.UInt64:
				return true;
			}
			return false;
		}

		// Token: 0x060016BC RID: 5820 RVA: 0x0006B574 File Offset: 0x00069774
		public static Class_498 Int32TryParse(char[] chars, int start, int length, out int value)
		{
			value = 0;
			if (length == 0)
			{
				return Class_498.Invalid;
			}
			bool flag = chars[start] == '-';
			if (flag)
			{
				if (length == 1)
				{
					return Class_498.Invalid;
				}
				start++;
				length--;
			}
			int num = start + length;
			for (int i = start; i < num; i++)
			{
				int num2 = (int)(chars[i] - '0');
				if (num2 < 0 || num2 > 9)
				{
					return Class_498.Invalid;
				}
				int num3 = 10 * value - num2;
				if (num3 > value)
				{
					for (i++; i < num; i++)
					{
						num2 = (int)(chars[i] - '0');
						if (num2 < 0 || num2 > 9)
						{
							return Class_498.Invalid;
						}
					}
					return Class_498.Overflow;
				}
				value = num3;
			}
			if (!flag)
			{
				if (value == -2147483648)
				{
					return Class_498.Overflow;
				}
				value = -value;
			}
			return Class_498.Success;
		}

		// Token: 0x060016BD RID: 5821 RVA: 0x0006B634 File Offset: 0x00069834
		public static Class_498 Int64TryParse(char[] chars, int start, int length, out long value)
		{
			value = 0L;
			if (length == 0)
			{
				return Class_498.Invalid;
			}
			bool flag = chars[start] == '-';
			if (flag)
			{
				if (length == 1)
				{
					return Class_498.Invalid;
				}
				start++;
				length--;
			}
			int num = start + length;
			for (int i = start; i < num; i++)
			{
				int num2 = (int)(chars[i] - '0');
				if (num2 < 0 || num2 > 9)
				{
					return Class_498.Invalid;
				}
				long num3 = 10L * value - (long)num2;
				if (num3 > value)
				{
					for (i++; i < num; i++)
					{
						num2 = (int)(chars[i] - '0');
						if (num2 < 0 || num2 > 9)
						{
							return Class_498.Invalid;
						}
					}
					return Class_498.Overflow;
				}
				value = num3;
			}
			if (!flag)
			{
				if (value == -9223372036854775808L)
				{
					return Class_498.Overflow;
				}
				value = -value;
			}
			return Class_498.Success;
		}

		// Token: 0x04000C11 RID: 3089
		private static readonly Dictionary<Type, Class_496> TypeCodeMap = new Dictionary<Type, Class_496>
		{
			{
				typeof(char),
				Class_496.Char
			},
			{
				typeof(char?),
				Class_496.CharNullable
			},
			{
				typeof(bool),
				Class_496.Boolean
			},
			{
				typeof(bool?),
				Class_496.BooleanNullable
			},
			{
				typeof(sbyte),
				Class_496.SByte
			},
			{
				typeof(sbyte?),
				Class_496.SByteNullable
			},
			{
				typeof(short),
				Class_496.Int16
			},
			{
				typeof(short?),
				Class_496.Int16Nullable
			},
			{
				typeof(ushort),
				Class_496.UInt16
			},
			{
				typeof(ushort?),
				Class_496.UInt16Nullable
			},
			{
				typeof(int),
				Class_496.Int32
			},
			{
				typeof(int?),
				Class_496.Int32Nullable
			},
			{
				typeof(byte),
				Class_496.Byte
			},
			{
				typeof(byte?),
				Class_496.ByteNullable
			},
			{
				typeof(uint),
				Class_496.UInt32
			},
			{
				typeof(uint?),
				Class_496.UInt32Nullable
			},
			{
				typeof(long),
				Class_496.Int64
			},
			{
				typeof(long?),
				Class_496.Int64Nullable
			},
			{
				typeof(ulong),
				Class_496.UInt64
			},
			{
				typeof(ulong?),
				Class_496.UInt64Nullable
			},
			{
				typeof(float),
				Class_496.Single
			},
			{
				typeof(float?),
				Class_496.SingleNullable
			},
			{
				typeof(double),
				Class_496.Double
			},
			{
				typeof(double?),
				Class_496.DoubleNullable
			},
			{
				typeof(DateTime),
				Class_496.DateTime
			},
			{
				typeof(DateTime?),
				Class_496.DateTimeNullable
			},
			{
				typeof(DateTimeOffset),
				Class_496.DateTimeOffset
			},
			{
				typeof(DateTimeOffset?),
				Class_496.DateTimeOffsetNullable
			},
			{
				typeof(decimal),
				Class_496.Decimal
			},
			{
				typeof(decimal?),
				Class_496.DecimalNullable
			},
			{
				typeof(Guid),
				Class_496.Guid
			},
			{
				typeof(Guid?),
				Class_496.GuidNullable
			},
			{
				typeof(TimeSpan),
				Class_496.TimeSpan
			},
			{
				typeof(TimeSpan?),
				Class_496.TimeSpanNullable
			},
			{
				typeof(BigInteger),
				Class_496.BigInteger
			},
			{
				typeof(BigInteger?),
				Class_496.BigIntegerNullable
			},
			{
				typeof(Uri),
				Class_496.Uri
			},
			{
				typeof(string),
				Class_496.String
			},
			{
				typeof(byte[]),
				Class_496.Bytes
			},
			{
				typeof(DBNull),
				Class_496.DBNull
			}
		};

		// Token: 0x04000C12 RID: 3090
		private static readonly Class_497[] PrimitiveTypeCodes = new Class_497[]
		{
			new Class_497
			{
				prop_0 = typeof(object),
				prop_1 = Class_496.Empty
			},
			new Class_497
			{
				prop_0 = typeof(object),
				prop_1 = Class_496.Object
			},
			new Class_497
			{
				prop_0 = typeof(object),
				prop_1 = Class_496.DBNull
			},
			new Class_497
			{
				prop_0 = typeof(bool),
				prop_1 = Class_496.Boolean
			},
			new Class_497
			{
				prop_0 = typeof(char),
				prop_1 = Class_496.Char
			},
			new Class_497
			{
				prop_0 = typeof(sbyte),
				prop_1 = Class_496.SByte
			},
			new Class_497
			{
				prop_0 = typeof(byte),
				prop_1 = Class_496.Byte
			},
			new Class_497
			{
				prop_0 = typeof(short),
				prop_1 = Class_496.Int16
			},
			new Class_497
			{
				prop_0 = typeof(ushort),
				prop_1 = Class_496.UInt16
			},
			new Class_497
			{
				prop_0 = typeof(int),
				prop_1 = Class_496.Int32
			},
			new Class_497
			{
				prop_0 = typeof(uint),
				prop_1 = Class_496.UInt32
			},
			new Class_497
			{
				prop_0 = typeof(long),
				prop_1 = Class_496.Int64
			},
			new Class_497
			{
				prop_0 = typeof(ulong),
				prop_1 = Class_496.UInt64
			},
			new Class_497
			{
				prop_0 = typeof(float),
				prop_1 = Class_496.Single
			},
			new Class_497
			{
				prop_0 = typeof(double),
				prop_1 = Class_496.Double
			},
			new Class_497
			{
				prop_0 = typeof(decimal),
				prop_1 = Class_496.Decimal
			},
			new Class_497
			{
				prop_0 = typeof(DateTime),
				prop_1 = Class_496.DateTime
			},
			new Class_497
			{
				prop_0 = typeof(object),
				prop_1 = Class_496.Empty
			},
			new Class_497
			{
				prop_0 = typeof(string),
				prop_1 = Class_496.String
			}
		};

		// Token: 0x04000C13 RID: 3091
		private static readonly Class_493<Class_499.TypeConvertKey, Func<object, object>> CastConverters = new Class_493<Class_499.TypeConvertKey, Func<object, object>>(new Func<Class_499.TypeConvertKey, Func<object, object>>(Class_499.CreateCastConverter));

		// Token: 0x020002B0 RID: 688
		internal struct TypeConvertKey : IEquatable<Class_499.TypeConvertKey>
		{
			// Token: 0x170004C7 RID: 1223
			// (get) Token: 0x060016BF RID: 5823 RVA: 0x0006BCCF File Offset: 0x00069ECF
			public Type InitialType
			{
				get
				{
					return this._initialType;
				}
			}

			// Token: 0x170004C8 RID: 1224
			// (get) Token: 0x060016C0 RID: 5824 RVA: 0x0006BCD7 File Offset: 0x00069ED7
			public Type TargetType
			{
				get
				{
					return this._targetType;
				}
			}

			// Token: 0x060016C1 RID: 5825 RVA: 0x0006BCDF File Offset: 0x00069EDF
			public TypeConvertKey(Type initialType, Type targetType)
			{
				this._initialType = initialType;
				this._targetType = targetType;
			}

			// Token: 0x060016C2 RID: 5826 RVA: 0x0006BCEF File Offset: 0x00069EEF
			public override int GetHashCode()
			{
				return this._initialType.GetHashCode() ^ this._targetType.GetHashCode();
			}

			// Token: 0x060016C3 RID: 5827 RVA: 0x0006BD08 File Offset: 0x00069F08
			public override bool Equals(object obj)
			{
				return obj is Class_499.TypeConvertKey && this.Equals((Class_499.TypeConvertKey)obj);
			}

			// Token: 0x060016C4 RID: 5828 RVA: 0x0006BD23 File Offset: 0x00069F23
			public bool Equals(Class_499.TypeConvertKey other)
			{
				return this._initialType == other._initialType && this._targetType == other._targetType;
			}

			// Token: 0x04000C14 RID: 3092
			private readonly Type _initialType;

			// Token: 0x04000C15 RID: 3093
			private readonly Type _targetType;
		}

		// Token: 0x020002B1 RID: 689
		internal enum ConvertResult
		{
			// Token: 0x04000C17 RID: 3095
			Success,
			// Token: 0x04000C18 RID: 3096
			CannotConvertNull,
			// Token: 0x04000C19 RID: 3097
			NotInstantiableType,
			// Token: 0x04000C1A RID: 3098
			NoValidConversion
		}
	}
}
