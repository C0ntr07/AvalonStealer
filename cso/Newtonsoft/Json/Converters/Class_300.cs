using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Globalization;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x0200019B RID: 411
	public class Class_300 : Class_299
	{
		// Token: 0x06000BE8 RID: 3048 RVA: 0x000425A0 File Offset: 0x000407A0
		public virtual void lmethod_2138(Class_296 arg_0, object obje_0, Class_418 arg_1)
		{
			if (obje_0 == null)
			{
				arg_0.gmethod_2033();
				return;
			}
			byte[] byteDizi_ = this.pmethod_2139(obje_0);
			arg_0.tmethod_2072(byteDizi_);
		}

		// Token: 0x06000BE9 RID: 3049 RVA: 0x000425CC File Offset: 0x000407CC
		private byte[] pmethod_2139(object obje_0)
		{
			if (obje_0.GetType().AssignableToTypeName("System.Data.Linq.Binary"))
			{
				this.smethod_2140(obje_0.GetType());
				return (byte[])this.field_2.tmethod_4062(obje_0, "ToArray");
			}
			if (obje_0 is SqlBinary)
			{
				return ((SqlBinary)obje_0).Value;
			}
			throw new Class_417("Unexpected value type when writing binary: {0}".FormatWith(CultureInfo.InvariantCulture, obje_0.GetType()));
		}

		// Token: 0x06000BEA RID: 3050 RVA: 0x00042648 File Offset: 0x00040848
		private void smethod_2140(Type arg_0)
		{
			if (this.field_2 == null)
			{
				this.field_2 = Class_491.dmethod_4066(arg_0, arg_0.GetConstructor(new Type[]
				{
					typeof(byte[])
				}), new string[]
				{
					"ToArray"
				});
			}
		}

		// Token: 0x06000BEB RID: 3051 RVA: 0x000426A0 File Offset: 0x000408A0
		public virtual object xmethod_2141(Class_285 arg_0, Type arg_1, object obje_0, Class_418 arg_2)
		{
			Type type = Class_514.IsNullableType(arg_1) ? Nullable.GetUnderlyingType(arg_1) : arg_1;
			if (arg_0.prop_9 == Class_508.Null)
			{
				if (!Class_514.IsNullable(arg_1))
				{
					throw Class_417.xmethod_3101(arg_0, "Cannot convert null value to {0}.".FormatWith(CultureInfo.InvariantCulture, arg_1));
				}
				return null;
			}
			else
			{
				byte[] array;
				if (arg_0.prop_9 == Class_508.StartArray)
				{
					array = this.tmethod_2142(arg_0);
				}
				else
				{
					if (arg_0.prop_9 != Class_508.String)
					{
						throw Class_417.xmethod_3101(arg_0, "Unexpected token parsing binary. Expected String or StartArray, got {0}.".FormatWith(CultureInfo.InvariantCulture, arg_0.prop_9));
					}
					string s = arg_0.prop_10.ToString();
					array = Convert.FromBase64String(s);
				}
				if (type.AssignableToTypeName("System.Data.Linq.Binary"))
				{
					this.smethod_2140(type);
					return this.field_2.prop_0(new object[]
					{
						array
					});
				}
				if (type == typeof(SqlBinary))
				{
					return new SqlBinary(array);
				}
				throw Class_417.xmethod_3101(arg_0, "Unexpected object type when writing binary: {0}".FormatWith(CultureInfo.InvariantCulture, arg_1));
			}
		}

		// Token: 0x06000BEC RID: 3052 RVA: 0x000427C0 File Offset: 0x000409C0
		private byte[] tmethod_2142(Class_285 arg_0)
		{
			List<byte> list = new List<byte>();
			while (arg_0.vmethod_1885())
			{
				Class_508 class_ = arg_0.prop_9;
				switch (class_)
				{
				case Class_508.Comment:
					continue;
				case Class_508.Raw:
					break;
				case Class_508.Integer:
					list.Add(Convert.ToByte(arg_0.prop_10, CultureInfo.InvariantCulture));
					continue;
				default:
					if (class_ == Class_508.EndArray)
					{
						return list.ToArray();
					}
					break;
				}
				throw Class_417.xmethod_3101(arg_0, "Unexpected token when reading bytes: {0}".FormatWith(CultureInfo.InvariantCulture, arg_0.prop_9));
			}
			throw Class_417.xmethod_3101(arg_0, "Unexpected end when reading bytes.");
		}

		// Token: 0x06000BED RID: 3053 RVA: 0x00042858 File Offset: 0x00040A58
		public virtual bool gmethod_2143(Type arg_0)
		{
			return arg_0.AssignableToTypeName("System.Data.Linq.Binary") || (arg_0 == typeof(SqlBinary) || arg_0 == typeof(SqlBinary?));
		}

		// Token: 0x0400079F RID: 1951
		private const string field_0 = "System.Data.Linq.Binary";

		// Token: 0x040007A0 RID: 1952
		private const string field_1 = "ToArray";

		// Token: 0x040007A1 RID: 1953
		private Class_491 field_2;
	}
}
