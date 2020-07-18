using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.Linq.Expressions;
using System.Numerics;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x020001E8 RID: 488
	public class Class_362 : Class_361, IComparable, IConvertible, IFormattable, IEquatable<Class_362>, IComparable<Class_362>
	{
		// Token: 0x06000E5C RID: 3676 RVA: 0x0004C06E File Offset: 0x0004A26E
		internal Class_362(object obje_0, Class_428 arg_0)
		{
			this.field_1 = obje_0;
			this.field_0 = arg_0;
		}

		// Token: 0x06000E5D RID: 3677 RVA: 0x0004C084 File Offset: 0x0004A284
		public Class_362(Class_362 arg_0) : this(arg_0.prop_2, arg_0.prop_3)
		{
		}

		// Token: 0x06000E5E RID: 3678 RVA: 0x0004C098 File Offset: 0x0004A298
		public Class_362(long sayıUınt_0) : this(sayıUınt_0, Class_428.Integer)
		{
		}

		// Token: 0x06000E5F RID: 3679 RVA: 0x0004C0A7 File Offset: 0x0004A2A7
		public Class_362(decimal arg_0) : this(arg_0, Class_428.Float)
		{
		}

		// Token: 0x06000E60 RID: 3680 RVA: 0x0004C0B6 File Offset: 0x0004A2B6
		public Class_362(char char_0) : this(char_0, Class_428.String)
		{
		}

		// Token: 0x06000E61 RID: 3681 RVA: 0x0004C0C5 File Offset: 0x0004A2C5
		[CLSCompliant(false)]
		public Class_362(ulong arg_0) : this(arg_0, Class_428.Integer)
		{
		}

		// Token: 0x06000E62 RID: 3682 RVA: 0x0004C0D4 File Offset: 0x0004A2D4
		public Class_362(double double_0) : this(double_0, Class_428.Float)
		{
		}

		// Token: 0x06000E63 RID: 3683 RVA: 0x0004C0E3 File Offset: 0x0004A2E3
		public Class_362(float arg_0) : this(arg_0, Class_428.Float)
		{
		}

		// Token: 0x06000E64 RID: 3684 RVA: 0x0004C0F2 File Offset: 0x0004A2F2
		public Class_362(DateTime arg_0) : this(arg_0, Class_428.Date)
		{
		}

		// Token: 0x06000E65 RID: 3685 RVA: 0x0004C102 File Offset: 0x0004A302
		public Class_362(DateTimeOffset arg_0) : this(arg_0, Class_428.Date)
		{
		}

		// Token: 0x06000E66 RID: 3686 RVA: 0x0004C112 File Offset: 0x0004A312
		public Class_362(bool bool_0) : this(bool_0, Class_428.Boolean)
		{
		}

		// Token: 0x06000E67 RID: 3687 RVA: 0x0004C122 File Offset: 0x0004A322
		public Class_362(string str_0) : this(str_0, Class_428.String)
		{
		}

		// Token: 0x06000E68 RID: 3688 RVA: 0x0004C12C File Offset: 0x0004A32C
		public Class_362(Guid arg_0) : this(arg_0, Class_428.Guid)
		{
		}

		// Token: 0x06000E69 RID: 3689 RVA: 0x0004C13C File Offset: 0x0004A33C
		public Class_362(Uri arg_0) : this(arg_0, (arg_0 != null) ? Class_428.Uri : Class_428.Null)
		{
		}

		// Token: 0x06000E6A RID: 3690 RVA: 0x0004C15A File Offset: 0x0004A35A
		public Class_362(TimeSpan arg_0) : this(arg_0, Class_428.TimeSpan)
		{
		}

		// Token: 0x06000E6B RID: 3691 RVA: 0x0004C16C File Offset: 0x0004A36C
		public Class_362(object obje_0) : this(obje_0, Class_362.pmethod_2599(null, obje_0))
		{
		}

		// Token: 0x06000E6C RID: 3692 RVA: 0x0004C190 File Offset: 0x0004A390
		internal virtual bool lmethod_2588(Class_361 arg_0)
		{
			Class_362 class_ = arg_0 as Class_362;
			return class_ != null && (class_ == this || Class_362.dmethod_2606(this, class_));
		}

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x06000E6D RID: 3693 RVA: 0x00018464 File Offset: 0x00016664
		public virtual bool prop_0
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000E6E RID: 3694 RVA: 0x0004C1BC File Offset: 0x0004A3BC
		private static int smethod_2590(BigInteger arg_0, object obje_0)
		{
			int num = arg_0.CompareTo(Class_499.ToBigInteger(obje_0));
			if (num != 0)
			{
				return num;
			}
			if (obje_0 is decimal)
			{
				decimal num2 = (decimal)obje_0;
				return 0m.CompareTo(Math.Abs(num2 - Math.Truncate(num2)));
			}
			if (obje_0 is double || obje_0 is float)
			{
				double num3 = Convert.ToDouble(obje_0, CultureInfo.InvariantCulture);
				return 0.0.CompareTo(Math.Abs(num3 - Math.Truncate(num3)));
			}
			return num;
		}

		// Token: 0x06000E6F RID: 3695 RVA: 0x0004C254 File Offset: 0x0004A454
		internal static int xmethod_2591(Class_428 arg_0, object obje_0, object obje_1)
		{
			if (obje_0 == null && obje_1 == null)
			{
				return 0;
			}
			if (obje_0 != null && obje_1 == null)
			{
				return 1;
			}
			if (obje_0 == null && obje_1 != null)
			{
				return -1;
			}
			switch (arg_0)
			{
			case Class_428.Comment:
			case Class_428.String:
			case Class_428.Raw:
			{
				string strA = Convert.ToString(obje_0, CultureInfo.InvariantCulture);
				string strB = Convert.ToString(obje_1, CultureInfo.InvariantCulture);
				return string.CompareOrdinal(strA, strB);
			}
			case Class_428.Integer:
				if (obje_0 is BigInteger)
				{
					return Class_362.smethod_2590((BigInteger)obje_0, obje_1);
				}
				if (obje_1 is BigInteger)
				{
					return -Class_362.smethod_2590((BigInteger)obje_1, obje_0);
				}
				if (obje_0 is ulong || obje_1 is ulong || obje_0 is decimal || obje_1 is decimal)
				{
					return Convert.ToDecimal(obje_0, CultureInfo.InvariantCulture).CompareTo(Convert.ToDecimal(obje_1, CultureInfo.InvariantCulture));
				}
				if (obje_0 is float || obje_1 is float || obje_0 is double || obje_1 is double)
				{
					return Class_362.tmethod_2592(obje_0, obje_1);
				}
				return Convert.ToInt64(obje_0, CultureInfo.InvariantCulture).CompareTo(Convert.ToInt64(obje_1, CultureInfo.InvariantCulture));
			case Class_428.Float:
				if (obje_0 is BigInteger)
				{
					return Class_362.smethod_2590((BigInteger)obje_0, obje_1);
				}
				if (obje_1 is BigInteger)
				{
					return -Class_362.smethod_2590((BigInteger)obje_1, obje_0);
				}
				return Class_362.tmethod_2592(obje_0, obje_1);
			case Class_428.Boolean:
			{
				bool flag = Convert.ToBoolean(obje_0, CultureInfo.InvariantCulture);
				bool value = Convert.ToBoolean(obje_1, CultureInfo.InvariantCulture);
				return flag.CompareTo(value);
			}
			case Class_428.Date:
			{
				if (obje_0 is DateTime)
				{
					DateTime dateTime = (DateTime)obje_0;
					DateTime value2;
					if (obje_1 is DateTimeOffset)
					{
						value2 = ((DateTimeOffset)obje_1).DateTime;
					}
					else
					{
						value2 = Convert.ToDateTime(obje_1, CultureInfo.InvariantCulture);
					}
					return dateTime.CompareTo(value2);
				}
				DateTimeOffset dateTimeOffset = (DateTimeOffset)obje_0;
				DateTimeOffset other;
				if (obje_1 is DateTimeOffset)
				{
					other = (DateTimeOffset)obje_1;
				}
				else
				{
					other = new DateTimeOffset(Convert.ToDateTime(obje_1, CultureInfo.InvariantCulture));
				}
				return dateTimeOffset.CompareTo(other);
			}
			case Class_428.Bytes:
			{
				if (!(obje_1 is byte[]))
				{
					throw new ArgumentException("Object must be of type byte[].");
				}
				byte[] array = obje_0 as byte[];
				byte[] array2 = obje_1 as byte[];
				if (array == null)
				{
					return -1;
				}
				if (array2 == null)
				{
					return 1;
				}
				return Class_513.ByteArrayCompare(array, array2);
			}
			case Class_428.Guid:
			{
				if (!(obje_1 is Guid))
				{
					throw new ArgumentException("Object must be of type Guid.");
				}
				Guid guid = (Guid)obje_0;
				Guid value3 = (Guid)obje_1;
				return guid.CompareTo(value3);
			}
			case Class_428.Uri:
			{
				if (!(obje_1 is Uri))
				{
					throw new ArgumentException("Object must be of type Uri.");
				}
				Uri uri = (Uri)obje_0;
				Uri uri2 = (Uri)obje_1;
				return Comparer<string>.Default.Compare(uri.ToString(), uri2.ToString());
			}
			case Class_428.TimeSpan:
			{
				if (!(obje_1 is TimeSpan))
				{
					throw new ArgumentException("Object must be of type TimeSpan.");
				}
				TimeSpan timeSpan = (TimeSpan)obje_0;
				TimeSpan value4 = (TimeSpan)obje_1;
				return timeSpan.CompareTo(value4);
			}
			}
			throw Class_513.CreateArgumentOutOfRangeException("valueType", arg_0, "Unexpected value type: {0}".FormatWith(CultureInfo.InvariantCulture, arg_0));
		}

		// Token: 0x06000E70 RID: 3696 RVA: 0x0004C5AC File Offset: 0x0004A7AC
		private static int tmethod_2592(object obje_0, object obje_1)
		{
			double d = Convert.ToDouble(obje_0, CultureInfo.InvariantCulture);
			double num = Convert.ToDouble(obje_1, CultureInfo.InvariantCulture);
			if (Class_511.ApproxEquals(d, num))
			{
				return 0;
			}
			return d.CompareTo(num);
		}

		// Token: 0x06000E71 RID: 3697 RVA: 0x0004C5E8 File Offset: 0x0004A7E8
		private static bool gmethod_2593(ExpressionType arg_0, object obje_0, object obje_1, out object arg_1)
		{
			if ((obje_0 is string || obje_1 is string) && (arg_0 == ExpressionType.Add || arg_0 == ExpressionType.AddAssign))
			{
				arg_1 = ((obje_0 != null) ? obje_0.ToString() : null) + ((obje_1 != null) ? obje_1.ToString() : null);
				return true;
			}
			if (obje_0 is BigInteger || obje_1 is BigInteger)
			{
				if (obje_0 == null || obje_1 == null)
				{
					arg_1 = null;
					return true;
				}
				BigInteger bigInteger = Class_499.ToBigInteger(obje_0);
				BigInteger bigInteger2 = Class_499.ToBigInteger(obje_1);
				if (arg_0 > ExpressionType.Multiply)
				{
					if (arg_0 <= ExpressionType.DivideAssign)
					{
						if (arg_0 != ExpressionType.Subtract)
						{
							switch (arg_0)
							{
							case ExpressionType.AddAssign:
								goto IL_EB;
							case ExpressionType.AndAssign:
								goto IL_49E;
							case ExpressionType.DivideAssign:
								goto IL_11B;
							default:
								goto IL_49E;
							}
						}
					}
					else
					{
						if (arg_0 == ExpressionType.MultiplyAssign)
						{
							goto IL_10B;
						}
						if (arg_0 != ExpressionType.SubtractAssign)
						{
							goto IL_49E;
						}
					}
					arg_1 = bigInteger - bigInteger2;
					return true;
				}
				if (arg_0 != ExpressionType.Add)
				{
					if (arg_0 == ExpressionType.Divide)
					{
						goto IL_11B;
					}
					if (arg_0 != ExpressionType.Multiply)
					{
						goto IL_49E;
					}
					goto IL_10B;
				}
				IL_EB:
				arg_1 = bigInteger + bigInteger2;
				return true;
				IL_10B:
				arg_1 = bigInteger * bigInteger2;
				return true;
				IL_11B:
				arg_1 = bigInteger / bigInteger2;
				return true;
			}
			else if (obje_0 is ulong || obje_1 is ulong || obje_0 is decimal || obje_1 is decimal)
			{
				if (obje_0 == null || obje_1 == null)
				{
					arg_1 = null;
					return true;
				}
				decimal d = Convert.ToDecimal(obje_0, CultureInfo.InvariantCulture);
				decimal d2 = Convert.ToDecimal(obje_1, CultureInfo.InvariantCulture);
				if (arg_0 > ExpressionType.Multiply)
				{
					if (arg_0 <= ExpressionType.DivideAssign)
					{
						if (arg_0 != ExpressionType.Subtract)
						{
							switch (arg_0)
							{
							case ExpressionType.AddAssign:
								goto IL_1F0;
							case ExpressionType.AndAssign:
								goto IL_49E;
							case ExpressionType.DivideAssign:
								goto IL_223;
							default:
								goto IL_49E;
							}
						}
					}
					else
					{
						if (arg_0 == ExpressionType.MultiplyAssign)
						{
							goto IL_212;
						}
						if (arg_0 != ExpressionType.SubtractAssign)
						{
							goto IL_49E;
						}
					}
					arg_1 = d - d2;
					return true;
				}
				if (arg_0 != ExpressionType.Add)
				{
					if (arg_0 == ExpressionType.Divide)
					{
						goto IL_223;
					}
					if (arg_0 != ExpressionType.Multiply)
					{
						goto IL_49E;
					}
					goto IL_212;
				}
				IL_1F0:
				arg_1 = d + d2;
				return true;
				IL_212:
				arg_1 = d * d2;
				return true;
				IL_223:
				arg_1 = d / d2;
				return true;
			}
			else if (obje_0 is float || obje_1 is float || obje_0 is double || obje_1 is double)
			{
				if (obje_0 == null || obje_1 == null)
				{
					arg_1 = null;
					return true;
				}
				double num = Convert.ToDouble(obje_0, CultureInfo.InvariantCulture);
				double num2 = Convert.ToDouble(obje_1, CultureInfo.InvariantCulture);
				if (arg_0 > ExpressionType.Multiply)
				{
					if (arg_0 <= ExpressionType.DivideAssign)
					{
						if (arg_0 != ExpressionType.Subtract)
						{
							switch (arg_0)
							{
							case ExpressionType.AddAssign:
								goto IL_2FA;
							case ExpressionType.AndAssign:
								goto IL_49E;
							case ExpressionType.DivideAssign:
								goto IL_324;
							default:
								goto IL_49E;
							}
						}
					}
					else
					{
						if (arg_0 == ExpressionType.MultiplyAssign)
						{
							goto IL_316;
						}
						if (arg_0 != ExpressionType.SubtractAssign)
						{
							goto IL_49E;
						}
					}
					arg_1 = num - num2;
					return true;
				}
				if (arg_0 != ExpressionType.Add)
				{
					if (arg_0 == ExpressionType.Divide)
					{
						goto IL_324;
					}
					if (arg_0 != ExpressionType.Multiply)
					{
						goto IL_49E;
					}
					goto IL_316;
				}
				IL_2FA:
				arg_1 = num + num2;
				return true;
				IL_316:
				arg_1 = num * num2;
				return true;
				IL_324:
				arg_1 = num / num2;
				return true;
			}
			else if (obje_0 is int || obje_0 is uint || obje_0 is long || obje_0 is short || obje_0 is ushort || obje_0 is sbyte || obje_0 is byte || obje_1 is int || obje_1 is uint || obje_1 is long || obje_1 is short || obje_1 is ushort || obje_1 is sbyte || obje_1 is byte)
			{
				if (obje_0 == null || obje_1 == null)
				{
					arg_1 = null;
					return true;
				}
				long num3 = Convert.ToInt64(obje_0, CultureInfo.InvariantCulture);
				long num4 = Convert.ToInt64(obje_1, CultureInfo.InvariantCulture);
				if (arg_0 > ExpressionType.Multiply)
				{
					if (arg_0 <= ExpressionType.DivideAssign)
					{
						if (arg_0 != ExpressionType.Subtract)
						{
							switch (arg_0)
							{
							case ExpressionType.AddAssign:
								goto IL_466;
							case ExpressionType.AndAssign:
								goto IL_49E;
							case ExpressionType.DivideAssign:
								goto IL_490;
							default:
								goto IL_49E;
							}
						}
					}
					else
					{
						if (arg_0 == ExpressionType.MultiplyAssign)
						{
							goto IL_482;
						}
						if (arg_0 != ExpressionType.SubtractAssign)
						{
							goto IL_49E;
						}
					}
					arg_1 = num3 - num4;
					return true;
				}
				if (arg_0 != ExpressionType.Add)
				{
					if (arg_0 == ExpressionType.Divide)
					{
						goto IL_490;
					}
					if (arg_0 != ExpressionType.Multiply)
					{
						goto IL_49E;
					}
					goto IL_482;
				}
				IL_466:
				arg_1 = num3 + num4;
				return true;
				IL_482:
				arg_1 = num3 * num4;
				return true;
				IL_490:
				arg_1 = num3 / num4;
				return true;
			}
			IL_49E:
			arg_1 = null;
			return false;
		}

		// Token: 0x06000E72 RID: 3698 RVA: 0x0004CA97 File Offset: 0x0004AC97
		internal virtual Class_361 cmethod_2594()
		{
			return new Class_362(this);
		}

		// Token: 0x06000E73 RID: 3699 RVA: 0x0004CA9F File Offset: 0x0004AC9F
		public static Class_362 vmethod_2595(string str_0)
		{
			return new Class_362(str_0, Class_428.Comment);
		}

		// Token: 0x06000E74 RID: 3700 RVA: 0x0004CAA8 File Offset: 0x0004ACA8
		public static Class_362 dmethod_2596(string str_0)
		{
			return new Class_362(str_0, Class_428.String);
		}

		// Token: 0x06000E75 RID: 3701 RVA: 0x0004CAB1 File Offset: 0x0004ACB1
		public static Class_362 kmethod_2597()
		{
			return new Class_362(null, Class_428.Null);
		}

		// Token: 0x06000E76 RID: 3702 RVA: 0x0004CABB File Offset: 0x0004ACBB
		public static Class_362 lmethod_2598()
		{
			return new Class_362(null, Class_428.Undefined);
		}

		// Token: 0x06000E77 RID: 3703 RVA: 0x0004CAC8 File Offset: 0x0004ACC8
		private static Class_428 pmethod_2599(Class_428? arg_0, object obje_0)
		{
			if (obje_0 == null)
			{
				return Class_428.Null;
			}
			if (obje_0 == DBNull.Value)
			{
				return Class_428.Null;
			}
			if (obje_0 is string)
			{
				return Class_362.smethod_2600(arg_0);
			}
			if (obje_0 is long || obje_0 is int || obje_0 is short || obje_0 is sbyte || obje_0 is ulong || obje_0 is uint || obje_0 is ushort || obje_0 is byte)
			{
				return Class_428.Integer;
			}
			if (obje_0 is Enum)
			{
				return Class_428.Integer;
			}
			if (obje_0 is BigInteger)
			{
				return Class_428.Integer;
			}
			if (obje_0 is double || obje_0 is float || obje_0 is decimal)
			{
				return Class_428.Float;
			}
			if (obje_0 is DateTime)
			{
				return Class_428.Date;
			}
			if (obje_0 is DateTimeOffset)
			{
				return Class_428.Date;
			}
			if (obje_0 is byte[])
			{
				return Class_428.Bytes;
			}
			if (obje_0 is bool)
			{
				return Class_428.Boolean;
			}
			if (obje_0 is Guid)
			{
				return Class_428.Guid;
			}
			if (obje_0 is Uri)
			{
				return Class_428.Uri;
			}
			if (obje_0 is TimeSpan)
			{
				return Class_428.TimeSpan;
			}
			throw new ArgumentException("Could not determine JSON object type for type {0}.".FormatWith(CultureInfo.InvariantCulture, obje_0.GetType()));
		}

		// Token: 0x06000E78 RID: 3704 RVA: 0x0004CC14 File Offset: 0x0004AE14
		private static Class_428 smethod_2600(Class_428? arg_0)
		{
			if (arg_0 == null)
			{
				return Class_428.String;
			}
			Class_428 value = arg_0.Value;
			if (value == Class_428.Comment || value == Class_428.String || value == Class_428.Raw)
			{
				return arg_0.Value;
			}
			return Class_428.String;
		}

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x06000E79 RID: 3705 RVA: 0x0004CC56 File Offset: 0x0004AE56
		public virtual Class_428 prop_1
		{
			get
			{
				return this.field_0;
			}
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x06000E7A RID: 3706 RVA: 0x0004CC5E File Offset: 0x0004AE5E
		// (set) Token: 0x06000E7B RID: 3707 RVA: 0x0004CC68 File Offset: 0x0004AE68
		public new object prop_2
		{
			get
			{
				return this.field_1;
			}
			set
			{
				Type left = (this.field_1 != null) ? this.field_1.GetType() : null;
				Type right = (value != null) ? value.GetType() : null;
				if (left != right)
				{
					this.field_0 = Class_362.pmethod_2599(new Class_428?(this.field_0), value);
				}
				this.field_1 = value;
			}
		}

		// Token: 0x06000E7C RID: 3708 RVA: 0x0004CCD0 File Offset: 0x0004AED0
		public virtual void cmethod_2604(Class_296 arg_0, params Class_299[] arg_1)
		{
			if (arg_1 != null && arg_1.Length > 0 && this.field_1 != null)
			{
				Class_299 class_ = Class_418.xmethod_3181(arg_1, this.field_1.GetType());
				if (class_ != null && class_.prop_1)
				{
					class_.tmethod_2132(arg_0, this.field_1, Class_418.xmethod_3161());
					return;
				}
			}
			switch (this.field_0)
			{
			case Class_428.Comment:
				arg_0.vmethod_2075((this.field_1 != null) ? this.field_1.ToString() : null);
				return;
			case Class_428.Integer:
				if (this.field_1 is BigInteger)
				{
					arg_0.cmethod_2074((BigInteger)this.field_1);
					return;
				}
				arg_0.smethod_2040(Convert.ToInt64(this.field_1, CultureInfo.InvariantCulture));
				return;
			case Class_428.Float:
				if (this.field_1 is decimal)
				{
					arg_0.smethod_2050((decimal)this.field_1);
					return;
				}
				if (this.field_1 is double)
				{
					arg_0.gmethod_2043((double)this.field_1);
					return;
				}
				if (this.field_1 is float)
				{
					arg_0.tmethod_2042((float)this.field_1);
					return;
				}
				arg_0.gmethod_2043(Convert.ToDouble(this.field_1, CultureInfo.InvariantCulture));
				return;
			case Class_428.String:
				arg_0.kmethod_2037((this.field_1 != null) ? this.field_1.ToString() : null);
				return;
			case Class_428.Boolean:
				arg_0.cmethod_2044(Convert.ToBoolean(this.field_1, CultureInfo.InvariantCulture));
				return;
			case Class_428.Null:
				arg_0.gmethod_2033();
				return;
			case Class_428.Undefined:
				arg_0.cmethod_2034();
				return;
			case Class_428.Date:
				if (this.field_1 is DateTimeOffset)
				{
					arg_0.tmethod_2052((DateTimeOffset)this.field_1);
					return;
				}
				arg_0.xmethod_2051(Convert.ToDateTime(this.field_1, CultureInfo.InvariantCulture));
				return;
			case Class_428.Raw:
				arg_0.dmethod_2036((this.field_1 != null) ? this.field_1.ToString() : null);
				return;
			case Class_428.Bytes:
				arg_0.tmethod_2072((byte[])this.field_1);
				return;
			case Class_428.Guid:
			case Class_428.Uri:
			case Class_428.TimeSpan:
				arg_0.kmethod_2037((this.field_1 != null) ? this.field_1.ToString() : null);
				return;
			default:
				throw Class_513.CreateArgumentOutOfRangeException("TokenType", this.field_0, "Unexpected token type.");
			}
		}

		// Token: 0x06000E7D RID: 3709 RVA: 0x0004CF48 File Offset: 0x0004B148
		internal virtual int vmethod_2605()
		{
			int num = (this.field_1 != null) ? this.field_1.GetHashCode() : 0;
			int num2 = (int)this.field_0;
			return num2.GetHashCode() ^ num;
		}

		// Token: 0x06000E7E RID: 3710 RVA: 0x0004CF82 File Offset: 0x0004B182
		private static bool dmethod_2606(Class_362 arg_0, Class_362 arg_1)
		{
			return arg_0 == arg_1 || (arg_0.field_0 == arg_1.field_0 && Class_362.xmethod_2591(arg_0.field_0, arg_0.field_1, arg_1.field_1) == 0);
		}

		// Token: 0x06000E7F RID: 3711 RVA: 0x0004CFBA File Offset: 0x0004B1BA
		public bool kmethod_2607(Class_362 arg_0)
		{
			return arg_0 != null && Class_362.dmethod_2606(this, arg_0);
		}

		// Token: 0x06000E80 RID: 3712 RVA: 0x0004CFCC File Offset: 0x0004B1CC
		public virtual bool lmethod_2608(object obje_0)
		{
			if (obje_0 == null)
			{
				return false;
			}
			Class_362 class_ = obje_0 as Class_362;
			if (class_ != null)
			{
				return this.kmethod_2607(class_);
			}
			return base.Equals(obje_0);
		}

		// Token: 0x06000E81 RID: 3713 RVA: 0x0004CFFD File Offset: 0x0004B1FD
		public virtual int pmethod_2609()
		{
			if (this.field_1 == null)
			{
				return 0;
			}
			return this.field_1.GetHashCode();
		}

		// Token: 0x06000E82 RID: 3714 RVA: 0x0004D017 File Offset: 0x0004B217
		public virtual string smethod_2610()
		{
			if (this.field_1 == null)
			{
				return string.Empty;
			}
			return this.field_1.ToString();
		}

		// Token: 0x06000E83 RID: 3715 RVA: 0x0004D035 File Offset: 0x0004B235
		public string xmethod_2611(string str_0)
		{
			return this.gmethod_2613(str_0, CultureInfo.CurrentCulture);
		}

		// Token: 0x06000E84 RID: 3716 RVA: 0x0004D043 File Offset: 0x0004B243
		public string tmethod_2612(IFormatProvider arg_0)
		{
			return this.gmethod_2613(null, arg_0);
		}

		// Token: 0x06000E85 RID: 3717 RVA: 0x0004D050 File Offset: 0x0004B250
		public string gmethod_2613(string str_0, IFormatProvider arg_0)
		{
			if (this.field_1 == null)
			{
				return string.Empty;
			}
			IFormattable formattable = this.field_1 as IFormattable;
			if (formattable != null)
			{
				return formattable.ToString(str_0, arg_0);
			}
			return this.field_1.ToString();
		}

		// Token: 0x06000E86 RID: 3718 RVA: 0x0004D094 File Offset: 0x0004B294
		protected virtual DynamicMetaObject cmethod_2614(Expression arg_0)
		{
			return new Class_475<Class_362>(arg_0, this, new Class_362.NClass_0(), true);
		}

		// Token: 0x06000E87 RID: 3719 RVA: 0x0004D0A4 File Offset: 0x0004B2A4
		int IComparable.vmethod_2615(object obje_0)
		{
			if (obje_0 == null)
			{
				return 1;
			}
			object obje_ = (obje_0 is Class_362) ? ((Class_362)obje_0).prop_2 : obje_0;
			return Class_362.xmethod_2591(this.field_0, this.field_1, obje_);
		}

		// Token: 0x06000E88 RID: 3720 RVA: 0x0004D0E8 File Offset: 0x0004B2E8
		public int dmethod_2616(Class_362 arg_0)
		{
			if (arg_0 == null)
			{
				return 1;
			}
			return Class_362.xmethod_2591(this.field_0, this.field_1, arg_0.field_1);
		}

		// Token: 0x06000E89 RID: 3721 RVA: 0x0004D10C File Offset: 0x0004B30C
		TypeCode IConvertible.kmethod_2617()
		{
			if (this.field_1 == null)
			{
				return TypeCode.Empty;
			}
			if (this.field_1 is DateTimeOffset)
			{
				return TypeCode.DateTime;
			}
			if (this.field_1 is BigInteger)
			{
				return TypeCode.Object;
			}
			return Type.GetTypeCode(this.field_1.GetType());
		}

		// Token: 0x06000E8A RID: 3722 RVA: 0x0004D15B File Offset: 0x0004B35B
		bool IConvertible.lmethod_2618(IFormatProvider arg_0)
		{
			return Class_361.smethod_2480(this);
		}

		// Token: 0x06000E8B RID: 3723 RVA: 0x0004D163 File Offset: 0x0004B363
		char IConvertible.pmethod_2619(IFormatProvider arg_0)
		{
			return Class_361.tmethod_2492(this);
		}

		// Token: 0x06000E8C RID: 3724 RVA: 0x0004D16B File Offset: 0x0004B36B
		sbyte IConvertible.smethod_2620(IFormatProvider arg_0)
		{
			return Class_361.cmethod_2494(this);
		}

		// Token: 0x06000E8D RID: 3725 RVA: 0x0004D173 File Offset: 0x0004B373
		byte IConvertible.xmethod_2621(IFormatProvider arg_0)
		{
			return Class_361.gmethod_2493(this);
		}

		// Token: 0x06000E8E RID: 3726 RVA: 0x0004D17B File Offset: 0x0004B37B
		short IConvertible.tmethod_2622(IFormatProvider arg_0)
		{
			return Class_361.smethod_2490(this);
		}

		// Token: 0x06000E8F RID: 3727 RVA: 0x0004D183 File Offset: 0x0004B383
		ushort IConvertible.gmethod_2623(IFormatProvider arg_0)
		{
			return Class_361.xmethod_2491(this);
		}

		// Token: 0x06000E90 RID: 3728 RVA: 0x0004D18B File Offset: 0x0004B38B
		int IConvertible.cmethod_2624(IFormatProvider arg_0)
		{
			return Class_361.pmethod_2489(this);
		}

		// Token: 0x06000E91 RID: 3729 RVA: 0x0004D193 File Offset: 0x0004B393
		uint IConvertible.vmethod_2625(IFormatProvider arg_0)
		{
			return Class_361.pmethod_2509(this);
		}

		// Token: 0x06000E92 RID: 3730 RVA: 0x0004D19B File Offset: 0x0004B39B
		long IConvertible.dmethod_2626(IFormatProvider arg_0)
		{
			return Class_361.gmethod_2483(this);
		}

		// Token: 0x06000E93 RID: 3731 RVA: 0x0004D1A3 File Offset: 0x0004B3A3
		ulong IConvertible.kmethod_2627(IFormatProvider arg_0)
		{
			return Class_361.smethod_2510(this);
		}

		// Token: 0x06000E94 RID: 3732 RVA: 0x0004D1AB File Offset: 0x0004B3AB
		float IConvertible.lmethod_2628(IFormatProvider arg_0)
		{
			return Class_361.kmethod_2507(this);
		}

		// Token: 0x06000E95 RID: 3733 RVA: 0x0004D1B4 File Offset: 0x0004B3B4
		double IConvertible.pmethod_2629(IFormatProvider arg_0)
		{
			return Class_361.dmethod_2506(this);
		}

		// Token: 0x06000E96 RID: 3734 RVA: 0x0004D1BD File Offset: 0x0004B3BD
		decimal IConvertible.smethod_2630(IFormatProvider arg_0)
		{
			return Class_361.gmethod_2503(this);
		}

		// Token: 0x06000E97 RID: 3735 RVA: 0x0004D1C5 File Offset: 0x0004B3C5
		DateTime IConvertible.xmethod_2631(IFormatProvider arg_0)
		{
			return Class_361.smethod_2500(this);
		}

		// Token: 0x06000E98 RID: 3736 RVA: 0x0004D1CD File Offset: 0x0004B3CD
		object IConvertible.tmethod_2632(Type arg_0, IFormatProvider arg_1)
		{
			return base.gmethod_2563(arg_0);
		}

		// Token: 0x040008E3 RID: 2275
		private Class_428 field_0;

		// Token: 0x040008E4 RID: 2276
		private object field_1;

		// Token: 0x020001E9 RID: 489
		private class NClass_0 : Class_359<Class_362>
		{
			// Token: 0x06000E99 RID: 3737 RVA: 0x0004D1D8 File Offset: 0x0004B3D8
			public virtual bool nmethod_0(Class_362 arg_0, ConvertBinder arg_1, out object arg_2)
			{
				if (arg_1.Type == typeof(Class_362))
				{
					arg_2 = arg_0;
					return true;
				}
				object obj = arg_0.prop_2;
				if (obj == null)
				{
					arg_2 = null;
					return Class_514.IsNullable(arg_1.Type);
				}
				arg_2 = Class_499.Convert(obj, CultureInfo.InvariantCulture, arg_1.Type);
				return true;
			}

			// Token: 0x06000E9A RID: 3738 RVA: 0x0004D234 File Offset: 0x0004B434
			public virtual bool nmethod_1(Class_362 arg_0, BinaryOperationBinder arg_1, object obje_0, out object arg_2)
			{
				object obje_ = (obje_0 is Class_362) ? ((Class_362)obje_0).prop_2 : obje_0;
				ExpressionType operation = arg_1.Operation;
				if (operation <= ExpressionType.NotEqual)
				{
					if (operation <= ExpressionType.LessThanOrEqual)
					{
						if (operation != ExpressionType.Add)
						{
							switch (operation)
							{
							case ExpressionType.Divide:
								break;
							case ExpressionType.Equal:
								arg_2 = (Class_362.xmethod_2591(arg_0.prop_3, arg_0.prop_2, obje_) == 0);
								return true;
							case ExpressionType.ExclusiveOr:
							case ExpressionType.Invoke:
							case ExpressionType.Lambda:
							case ExpressionType.LeftShift:
								goto IL_1AE;
							case ExpressionType.GreaterThan:
								arg_2 = (Class_362.xmethod_2591(arg_0.prop_3, arg_0.prop_2, obje_) > 0);
								return true;
							case ExpressionType.GreaterThanOrEqual:
								arg_2 = (Class_362.xmethod_2591(arg_0.prop_3, arg_0.prop_2, obje_) >= 0);
								return true;
							case ExpressionType.LessThan:
								arg_2 = (Class_362.xmethod_2591(arg_0.prop_3, arg_0.prop_2, obje_) < 0);
								return true;
							case ExpressionType.LessThanOrEqual:
								arg_2 = (Class_362.xmethod_2591(arg_0.prop_3, arg_0.prop_2, obje_) <= 0);
								return true;
							default:
								goto IL_1AE;
							}
						}
					}
					else if (operation != ExpressionType.Multiply)
					{
						if (operation != ExpressionType.NotEqual)
						{
							goto IL_1AE;
						}
						arg_2 = (Class_362.xmethod_2591(arg_0.prop_3, arg_0.prop_2, obje_) != 0);
						return true;
					}
				}
				else if (operation <= ExpressionType.DivideAssign)
				{
					if (operation != ExpressionType.Subtract)
					{
						switch (operation)
						{
						case ExpressionType.AddAssign:
						case ExpressionType.DivideAssign:
							break;
						case ExpressionType.AndAssign:
							goto IL_1AE;
						default:
							goto IL_1AE;
						}
					}
				}
				else if (operation != ExpressionType.MultiplyAssign && operation != ExpressionType.SubtractAssign)
				{
					goto IL_1AE;
				}
				if (Class_362.gmethod_2593(arg_1.Operation, arg_0.prop_2, obje_, out arg_2))
				{
					arg_2 = new Class_362(arg_2);
					return true;
				}
				IL_1AE:
				arg_2 = null;
				return false;
			}

			// Token: 0x06000E9B RID: 3739 RVA: 0x0004D3F4 File Offset: 0x0004B5F4
			public void nmethod_2()
			{
				base..ctor();
			}
		}
	}
}
