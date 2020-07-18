using System;
using System.Globalization;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x02000201 RID: 513
	public class Class_385 : Class_304
	{
		// Token: 0x17000336 RID: 822
		// (get) Token: 0x06000F78 RID: 3960 RVA: 0x0004FBB3 File Offset: 0x0004DDB3
		// (set) Token: 0x06000F79 RID: 3961 RVA: 0x0004FBBB File Offset: 0x0004DDBB
		public new DateTimeStyles prop_0
		{
			get
			{
				return this.field_1;
			}
			set
			{
				this.field_1 = value;
			}
		}

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x06000F7A RID: 3962 RVA: 0x0004FBC4 File Offset: 0x0004DDC4
		// (set) Token: 0x06000F7B RID: 3963 RVA: 0x0004FBD8 File Offset: 0x0004DDD8
		public new string prop_1
		{
			get
			{
				return this.field_2 ?? string.Empty;
			}
			set
			{
				this.field_2 = Class_515.NullEmptyString(value);
			}
		}

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x06000F7C RID: 3964 RVA: 0x0004FBE6 File Offset: 0x0004DDE6
		// (set) Token: 0x06000F7D RID: 3965 RVA: 0x0004FBFA File Offset: 0x0004DDFA
		public CultureInfo prop_2
		{
			get
			{
				return this.field_3 ?? CultureInfo.CurrentCulture;
			}
			set
			{
				this.field_3 = value;
			}
		}

		// Token: 0x06000F7E RID: 3966 RVA: 0x0004FC04 File Offset: 0x0004DE04
		public virtual void dmethod_2806(Class_296 arg_0, object obje_0, Class_418 arg_1)
		{
			string str_;
			if (obje_0 is DateTime)
			{
				DateTime dateTime = (DateTime)obje_0;
				if ((this.field_1 & DateTimeStyles.AdjustToUniversal) == DateTimeStyles.AdjustToUniversal || (this.field_1 & DateTimeStyles.AssumeUniversal) == DateTimeStyles.AssumeUniversal)
				{
					dateTime = dateTime.ToUniversalTime();
				}
				str_ = dateTime.ToString(this.field_2 ?? "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK", this.prop_2);
			}
			else
			{
				if (!(obje_0 is DateTimeOffset))
				{
					throw new Class_417("Unexpected value when converting date. Expected DateTime or DateTimeOffset, got {0}.".FormatWith(CultureInfo.InvariantCulture, Class_514.GetObjectType(obje_0)));
				}
				DateTimeOffset dateTimeOffset = (DateTimeOffset)obje_0;
				if ((this.field_1 & DateTimeStyles.AdjustToUniversal) == DateTimeStyles.AdjustToUniversal || (this.field_1 & DateTimeStyles.AssumeUniversal) == DateTimeStyles.AssumeUniversal)
				{
					dateTimeOffset = dateTimeOffset.ToUniversalTime();
				}
				str_ = dateTimeOffset.ToString(this.field_2 ?? "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK", this.prop_2);
			}
			arg_0.kmethod_2037(str_);
		}

		// Token: 0x06000F7F RID: 3967 RVA: 0x0004FCF4 File Offset: 0x0004DEF4
		public virtual object kmethod_2807(Class_285 arg_0, Type arg_1, object obje_0, Class_418 arg_2)
		{
			bool flag = Class_514.IsNullableType(arg_1);
			Type left = flag ? Nullable.GetUnderlyingType(arg_1) : arg_1;
			if (arg_0.prop_9 == Class_508.Null)
			{
				if (!Class_514.IsNullableType(arg_1))
				{
					throw Class_417.xmethod_3101(arg_0, "Cannot convert null value to {0}.".FormatWith(CultureInfo.InvariantCulture, arg_1));
				}
				return null;
			}
			else if (arg_0.prop_9 == Class_508.Date)
			{
				if (!(left == typeof(DateTimeOffset)))
				{
					return arg_0.prop_10;
				}
				if (!(arg_0.prop_10 is DateTimeOffset))
				{
					return new DateTimeOffset((DateTime)arg_0.prop_10);
				}
				return arg_0.prop_10;
			}
			else
			{
				if (arg_0.prop_9 != Class_508.String)
				{
					throw Class_417.xmethod_3101(arg_0, "Unexpected token parsing date. Expected String, got {0}.".FormatWith(CultureInfo.InvariantCulture, arg_0.prop_9));
				}
				string text = arg_0.prop_10.ToString();
				if (string.IsNullOrEmpty(text) && flag)
				{
					return null;
				}
				if (left == typeof(DateTimeOffset))
				{
					if (!string.IsNullOrEmpty(this.field_2))
					{
						return DateTimeOffset.ParseExact(text, this.field_2, this.prop_2, this.field_1);
					}
					return DateTimeOffset.Parse(text, this.prop_2, this.field_1);
				}
				else
				{
					if (!string.IsNullOrEmpty(this.field_2))
					{
						return DateTime.ParseExact(text, this.field_2, this.prop_2, this.field_1);
					}
					return DateTime.Parse(text, this.prop_2, this.field_1);
				}
			}
		}

		// Token: 0x0400095C RID: 2396
		private const string field_0 = "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK";

		// Token: 0x0400095D RID: 2397
		private DateTimeStyles field_1 = DateTimeStyles.RoundtripKind;

		// Token: 0x0400095E RID: 2398
		private string field_2;

		// Token: 0x0400095F RID: 2399
		private CultureInfo field_3;
	}
}
