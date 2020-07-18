using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020001A2 RID: 418
	public class Class_307 : Class_299
	{
		// Token: 0x06000C0F RID: 3087 RVA: 0x00002050 File Offset: 0x00000250
		public virtual void smethod_2170(Class_296 arg_0, object obje_0, Class_418 arg_1)
		{
		}

		// Token: 0x06000C10 RID: 3088 RVA: 0x0004361B File Offset: 0x0004181B
		public virtual object xmethod_2171(Class_285 arg_0, Type arg_1, object obje_0, Class_418 arg_2)
		{
			return this.tmethod_2172(arg_0);
		}

		// Token: 0x06000C11 RID: 3089 RVA: 0x00043624 File Offset: 0x00041824
		private object tmethod_2172(Class_285 arg_0)
		{
			while (arg_0.prop_9 == Class_508.Comment)
			{
				if (!arg_0.vmethod_1885())
				{
					throw Class_417.xmethod_3101(arg_0, "Unexpected end when reading ExpandoObject.");
				}
			}
			switch (arg_0.prop_9)
			{
			case Class_508.StartObject:
				return this.cmethod_2174(arg_0);
			case Class_508.StartArray:
				return this.gmethod_2173(arg_0);
			default:
				if (Class_486.IsPrimitiveToken(arg_0.prop_9))
				{
					return arg_0.prop_10;
				}
				throw Class_417.xmethod_3101(arg_0, "Unexpected token when converting ExpandoObject: {0}".FormatWith(CultureInfo.InvariantCulture, arg_0.prop_9));
			}
		}

		// Token: 0x06000C12 RID: 3090 RVA: 0x000436BC File Offset: 0x000418BC
		private object gmethod_2173(Class_285 arg_0)
		{
			IList<object> list = new List<object>();
			while (arg_0.vmethod_1885())
			{
				Class_508 class_ = arg_0.prop_9;
				if (class_ != Class_508.Comment)
				{
					if (class_ == Class_508.EndArray)
					{
						return list;
					}
					object item = this.tmethod_2172(arg_0);
					list.Add(item);
				}
			}
			throw Class_417.xmethod_3101(arg_0, "Unexpected end when reading ExpandoObject.");
		}

		// Token: 0x06000C13 RID: 3091 RVA: 0x00043714 File Offset: 0x00041914
		private object cmethod_2174(Class_285 arg_0)
		{
			IDictionary<string, object> dictionary = new ExpandoObject();
			while (arg_0.vmethod_1885())
			{
				Class_508 class_ = arg_0.prop_9;
				switch (class_)
				{
				case Class_508.PropertyName:
				{
					string key = arg_0.prop_10.ToString();
					if (!arg_0.vmethod_1885())
					{
						throw Class_417.xmethod_3101(arg_0, "Unexpected end when reading ExpandoObject.");
					}
					object value = this.tmethod_2172(arg_0);
					dictionary[key] = value;
					break;
				}
				case Class_508.Comment:
					break;
				default:
					if (class_ == Class_508.EndObject)
					{
						return dictionary;
					}
					break;
				}
			}
			throw Class_417.xmethod_3101(arg_0, "Unexpected end when reading ExpandoObject.");
		}

		// Token: 0x06000C14 RID: 3092 RVA: 0x0004379D File Offset: 0x0004199D
		public virtual bool vmethod_2175(Type arg_0)
		{
			return arg_0 == typeof(ExpandoObject);
		}

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x06000C15 RID: 3093 RVA: 0x00018464 File Offset: 0x00016664
		public virtual bool prop_0
		{
			get
			{
				return false;
			}
		}
	}
}
