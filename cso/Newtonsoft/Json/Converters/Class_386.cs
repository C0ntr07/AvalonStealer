using System;
using System.Globalization;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x02000202 RID: 514
	public class Class_386 : Class_304
	{
		// Token: 0x06000F81 RID: 3969 RVA: 0x0004FEA4 File Offset: 0x0004E0A4
		public virtual void lmethod_2808(Class_296 arg_0, object obje_0, Class_418 arg_1)
		{
			long sayıUınt_;
			if (obje_0 is DateTime)
			{
				DateTime dateTime = ((DateTime)obje_0).ToUniversalTime();
				sayıUınt_ = Class_502.ConvertDateTimeToJavaScriptTicks(dateTime);
			}
			else
			{
				if (!(obje_0 is DateTimeOffset))
				{
					throw new Class_417("Expected date object value.");
				}
				sayıUınt_ = Class_502.ConvertDateTimeToJavaScriptTicks(((DateTimeOffset)obje_0).ToUniversalTime().UtcDateTime);
			}
			arg_0.xmethod_2011("Date");
			arg_0.smethod_2040(sayıUınt_);
			arg_0.tmethod_2012();
		}

		// Token: 0x06000F82 RID: 3970 RVA: 0x0004FF28 File Offset: 0x0004E128
		public virtual object pmethod_2809(Class_285 arg_0, Type arg_1, object obje_0, Class_418 arg_2)
		{
			Type left = Class_514.IsNullableType(arg_1) ? Nullable.GetUnderlyingType(arg_1) : arg_1;
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
				if (arg_0.prop_9 != Class_508.StartConstructor || !string.Equals(arg_0.prop_10.ToString(), "Date", StringComparison.Ordinal))
				{
					throw Class_417.xmethod_3101(arg_0, "Unexpected token or value when parsing date. Token: {0}, Value: {1}".FormatWith(CultureInfo.InvariantCulture, arg_0.prop_9, arg_0.prop_10));
				}
				arg_0.vmethod_1885();
				if (arg_0.prop_9 != Class_508.Integer)
				{
					throw Class_417.xmethod_3101(arg_0, "Unexpected token parsing date. Expected Integer, got {0}.".FormatWith(CultureInfo.InvariantCulture, arg_0.prop_9));
				}
				long javaScriptTicks = (long)arg_0.prop_10;
				DateTime dateTime = Class_502.ConvertJavaScriptTicksToDateTime(javaScriptTicks);
				arg_0.vmethod_1885();
				if (arg_0.prop_9 != Class_508.EndConstructor)
				{
					throw Class_417.xmethod_3101(arg_0, "Unexpected token parsing date. Expected EndConstructor, got {0}.".FormatWith(CultureInfo.InvariantCulture, arg_0.prop_9));
				}
				if (left == typeof(DateTimeOffset))
				{
					return new DateTimeOffset(dateTime);
				}
				return dateTime;
			}
		}
	}
}
