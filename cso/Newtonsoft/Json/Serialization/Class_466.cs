using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200026D RID: 621
	internal class Class_466 : Class_465
	{
		// Token: 0x0600150B RID: 5387 RVA: 0x00061612 File Offset: 0x0005F812
		public Class_466(Class_418 arg_0) : base(arg_0)
		{
		}

		// Token: 0x0600150C RID: 5388 RVA: 0x0006161C File Offset: 0x0005F81C
		public void xmethod_3851(Class_285 arg_0, object obje_0)
		{
			Class_517.ArgumentNotNull(obje_0, "target");
			Type type = obje_0.GetType();
			Class_349 class_ = this.field_3.field_11.tmethod_3542(type);
			if (arg_0.prop_9 == Class_508.None)
			{
				arg_0.vmethod_1885();
			}
			if (arg_0.prop_9 == Class_508.StartArray)
			{
				if (class_.field_5 == Class_448.Array)
				{
					Class_447 class_2 = (Class_447)class_;
					this.xmethod_3881(class_2.prop_3 ? class_2.vmethod_3625(obje_0) : ((IList)obje_0), arg_0, class_2, null, null);
					return;
				}
				throw Class_417.xmethod_3101(arg_0, "Cannot populate JSON array onto type '{0}'.".FormatWith(CultureInfo.InvariantCulture, type));
			}
			else
			{
				if (arg_0.prop_9 != Class_508.StartObject)
				{
					throw Class_417.xmethod_3101(arg_0, "Unexpected initial token '{0}' when populating object. Expected JSON object or array.".FormatWith(CultureInfo.InvariantCulture, arg_0.prop_9));
				}
				this.vmethod_3865(arg_0);
				string str_ = null;
				if (this.field_3.prop_12 != Class_343.Ignore && arg_0.prop_9 == Class_508.PropertyName && string.Equals(arg_0.prop_10.ToString(), "$id", StringComparison.Ordinal))
				{
					this.vmethod_3865(arg_0);
					str_ = ((arg_0.prop_10 != null) ? arg_0.prop_10.ToString() : null);
					this.vmethod_3865(arg_0);
				}
				if (class_.field_5 == Class_448.Dictionary)
				{
					Class_453 class_3 = (Class_453)class_;
					this.lmethod_3878(class_3.prop_4 ? class_3.pmethod_3639(obje_0) : ((IDictionary)obje_0), arg_0, class_3, null, str_);
					return;
				}
				if (class_.field_5 == Class_448.Object)
				{
					this.smethod_3890(obje_0, arg_0, (Class_464)class_, null, str_);
					return;
				}
				throw Class_417.xmethod_3101(arg_0, "Cannot populate JSON object onto type '{0}'.".FormatWith(CultureInfo.InvariantCulture, type));
			}
		}

		// Token: 0x0600150D RID: 5389 RVA: 0x000617CB File Offset: 0x0005F9CB
		private Class_349 tmethod_3852(Type arg_0)
		{
			if (arg_0 == null)
			{
				return null;
			}
			return this.field_3.field_11.tmethod_3542(arg_0);
		}

		// Token: 0x0600150E RID: 5390 RVA: 0x000617EC File Offset: 0x0005F9EC
		public object gmethod_3853(Class_285 arg_0, Type arg_1, bool bool_0)
		{
			if (arg_0 == null)
			{
				throw new ArgumentNullException("reader");
			}
			Class_349 class_ = this.tmethod_3852(arg_1);
			object result;
			try
			{
				Class_299 class_2 = this.pmethod_3859(class_, null, null, null);
				if (arg_0.prop_9 == Class_508.None && !this.lmethod_3888(arg_0, class_, class_2 != null))
				{
					if (class_ != null && !class_.field_0)
					{
						throw Class_417.xmethod_3101(arg_0, "No JSON content found and type '{0}' is not nullable.".FormatWith(CultureInfo.InvariantCulture, class_.prop_0));
					}
					result = null;
				}
				else
				{
					object obj;
					if (class_2 != null && class_2.prop_0)
					{
						obj = this.dmethod_3886(class_2, arg_0, arg_1, null);
					}
					else
					{
						obj = this.kmethod_3857(arg_0, arg_1, class_, null, null, null, null);
					}
					if (bool_0 && arg_0.vmethod_1885() && arg_0.prop_9 != Class_508.Comment)
					{
						throw new Class_417("Additional text found in JSON string after finishing deserializing object.");
					}
					result = obj;
				}
			}
			catch (Exception arg_2)
			{
				if (!base.smethod_3850(null, class_, null, arg_0 as Class_353, arg_0.prop_13, arg_2))
				{
					base.pmethod_3849();
					throw;
				}
				this.vmethod_3895(arg_0, false, 0);
				result = null;
			}
			return result;
		}

		// Token: 0x0600150F RID: 5391 RVA: 0x00061918 File Offset: 0x0005FB18
		private Class_468 cmethod_3854()
		{
			if (this.field_0 == null)
			{
				this.field_0 = new Class_468(this);
			}
			return this.field_0;
		}

		// Token: 0x06001510 RID: 5392 RVA: 0x00061938 File Offset: 0x0005FB38
		private Class_361 vmethod_3855(Class_285 arg_0, Class_349 arg_1)
		{
			Class_517.ArgumentNotNull(arg_0, "reader");
			if (arg_1 != null)
			{
				if (arg_1.prop_0 == typeof(Class_363))
				{
					return Class_363.gmethod_2633(arg_0);
				}
				if (arg_0.prop_9 == Class_508.Null && !(arg_1.prop_0 == typeof(Class_362)) && !(arg_1.prop_0 == typeof(Class_361)))
				{
					return null;
				}
			}
			Class_361 result;
			using (Class_426 class_ = new Class_426())
			{
				class_.dmethod_2016(arg_0);
				result = class_.prop_1;
			}
			return result;
		}

		// Token: 0x06001511 RID: 5393 RVA: 0x000619F4 File Offset: 0x0005FBF4
		private Class_361 dmethod_3856(Class_285 arg_0)
		{
			Class_517.ArgumentNotNull(arg_0, "reader");
			using (Class_426 class_ = new Class_426())
			{
				class_.kmethod_2007();
				for (;;)
				{
					if (arg_0.prop_9 == Class_508.PropertyName)
					{
						string str_ = (string)arg_0.prop_10;
						while (arg_0.vmethod_1885() && arg_0.prop_9 == Class_508.Comment)
						{
						}
						if (!this.xmethod_3891(arg_0, str_))
						{
							class_.gmethod_2013(str_);
							class_.smethod_2020(arg_0, true, true);
						}
					}
					else if (arg_0.prop_9 != Class_508.Comment)
					{
						break;
					}
					if (!arg_0.vmethod_1885())
					{
						goto Block_7;
					}
				}
				class_.lmethod_2008();
				return class_.prop_1;
				Block_7:
				throw Class_417.xmethod_3101(arg_0, "Unexpected end when deserializing object.");
			}
			Class_361 result;
			return result;
		}

		// Token: 0x06001512 RID: 5394 RVA: 0x00061AB8 File Offset: 0x0005FCB8
		private object kmethod_3857(Class_285 arg_0, Type arg_1, Class_349 arg_2, Class_454 arg_3, Class_350 arg_4, Class_454 arg_5, object obje_0)
		{
			if (arg_2 != null && arg_2.field_5 == Class_448.Linq)
			{
				return this.vmethod_3855(arg_0, arg_2);
			}
			for (;;)
			{
				switch (arg_0.prop_9)
				{
				case Class_508.StartObject:
					goto IL_73;
				case Class_508.StartArray:
					goto IL_85;
				case Class_508.StartConstructor:
					goto IL_129;
				case Class_508.Comment:
					if (!arg_0.vmethod_1885())
					{
						goto Block_11;
					}
					continue;
				case Class_508.Raw:
					goto IL_175;
				case Class_508.Integer:
				case Class_508.Float:
				case Class_508.Boolean:
				case Class_508.Date:
				case Class_508.Bytes:
					goto IL_94;
				case Class_508.String:
					goto IL_A9;
				case Class_508.Null:
				case Class_508.Undefined:
					goto IL_145;
				}
				break;
			}
			goto IL_186;
			IL_73:
			return this.smethod_3860(arg_0, arg_1, arg_2, arg_3, arg_4, arg_5, obje_0);
			IL_85:
			return this.dmethod_3866(arg_0, arg_1, arg_2, arg_3, obje_0, null);
			IL_94:
			return this.lmethod_3868(arg_0, arg_0.prop_10, CultureInfo.InvariantCulture, arg_2, arg_1);
			IL_A9:
			string text = (string)arg_0.prop_10;
			if (string.IsNullOrEmpty(text) && arg_1 != typeof(string) && arg_1 != typeof(object) && arg_2 != null && arg_2.field_0)
			{
				return null;
			}
			if (arg_1 == typeof(byte[]))
			{
				return Convert.FromBase64String(text);
			}
			return this.lmethod_3868(arg_0, text, CultureInfo.InvariantCulture, arg_2, arg_1);
			IL_129:
			string obje_ = arg_0.prop_10.ToString();
			return this.lmethod_3868(arg_0, obje_, CultureInfo.InvariantCulture, arg_2, arg_1);
			IL_145:
			if (arg_1 == typeof(DBNull))
			{
				return DBNull.Value;
			}
			return this.lmethod_3868(arg_0, arg_0.prop_10, CultureInfo.InvariantCulture, arg_2, arg_1);
			IL_175:
			return new Class_363((string)arg_0.prop_10);
			IL_186:
			throw Class_417.xmethod_3101(arg_0, "Unexpected token while deserializing object: " + arg_0.prop_9);
			Block_11:
			throw Class_417.xmethod_3101(arg_0, "Unexpected end when deserializing object.");
		}

		// Token: 0x06001513 RID: 5395 RVA: 0x00061C80 File Offset: 0x0005FE80
		internal string lmethod_3858(Class_349 arg_0)
		{
			switch (arg_0.field_5)
			{
			case Class_448.Object:
			case Class_448.Dictionary:
			case Class_448.Dynamic:
			case Class_448.Serializable:
				return "JSON object (e.g. {\"name\":\"value\"})";
			case Class_448.Array:
				return "JSON array (e.g. [1,2,3])";
			case Class_448.Primitive:
				return "JSON primitive value (e.g. string, number, boolean, null)";
			case Class_448.String:
				return "JSON string value";
			default:
				throw new ArgumentOutOfRangeException();
			}
		}

		// Token: 0x06001514 RID: 5396 RVA: 0x00061CDC File Offset: 0x0005FEDC
		private Class_299 pmethod_3859(Class_349 arg_0, Class_299 arg_1, Class_350 arg_2, Class_454 arg_3)
		{
			Class_299 result = null;
			if (arg_1 != null)
			{
				result = arg_1;
			}
			else if (arg_3 != null && arg_3.prop_25 != null)
			{
				result = arg_3.prop_25;
			}
			else if (arg_2 != null && arg_2.prop_2 != null)
			{
				result = arg_2.prop_2;
			}
			else if (arg_0 != null)
			{
				Class_299 class_;
				if (arg_0.prop_3 != null)
				{
					result = arg_0.prop_3;
				}
				else if ((class_ = this.field_3.smethod_3180(arg_0.prop_0)) != null)
				{
					result = class_;
				}
				else if (arg_0.prop_4 != null)
				{
					result = arg_0.prop_4;
				}
			}
			return result;
		}

		// Token: 0x06001515 RID: 5397 RVA: 0x00061D84 File Offset: 0x0005FF84
		private object smethod_3860(Class_285 arg_0, Type arg_1, Class_349 arg_2, Class_454 arg_3, Class_350 arg_4, Class_454 arg_5, object obje_0)
		{
			Type type = arg_1;
			string text;
			if (this.field_3.prop_12 == Class_343.Ignore)
			{
				this.vmethod_3865(arg_0);
				text = null;
			}
			else if (this.field_3.prop_12 == Class_343.ReadAhead)
			{
				Class_425 class_ = arg_0 as Class_425;
				if (class_ == null)
				{
					Class_361 class_2 = Class_361.dmethod_2566(arg_0);
					class_ = (Class_425)class_2.lmethod_2558();
					class_.prop_14 = arg_0.prop_14;
					class_.prop_7 = arg_0.prop_7;
					class_.prop_5 = arg_0.prop_5;
					class_.prop_4 = arg_0.prop_4;
					class_.prop_6 = arg_0.prop_6;
					class_.prop_2 = arg_0.prop_2;
					this.vmethod_3865(class_);
					arg_0 = class_;
				}
				object result;
				if (this.xmethod_3861(class_, ref type, ref arg_2, arg_3, arg_4, arg_5, obje_0, out result, out text))
				{
					return result;
				}
			}
			else
			{
				this.vmethod_3865(arg_0);
				object result2;
				if (this.tmethod_3862(arg_0, ref type, ref arg_2, arg_3, arg_4, arg_5, obje_0, out result2, out text))
				{
					return result2;
				}
			}
			if (this.kmethod_3867(arg_2))
			{
				return this.dmethod_3856(arg_0);
			}
			switch (arg_2.field_5)
			{
			case Class_448.Object:
			{
				bool flag = false;
				Class_464 arg_6 = (Class_464)arg_2;
				object obj;
				if (obje_0 != null && (type == arg_1 || type.IsAssignableFrom(obje_0.GetType())))
				{
					obj = obje_0;
				}
				else
				{
					obj = this.pmethod_3889(arg_0, arg_6, arg_3, arg_5, text, out flag);
				}
				if (flag)
				{
					return obj;
				}
				return this.smethod_3890(obj, arg_0, arg_6, arg_3, text);
			}
			case Class_448.Primitive:
			{
				Class_369 arg_7 = (Class_369)arg_2;
				if (this.field_3.prop_12 != Class_343.Ignore && arg_0.prop_9 == Class_508.PropertyName && string.Equals(arg_0.prop_10.ToString(), "$value", StringComparison.Ordinal))
				{
					this.vmethod_3865(arg_0);
					if (arg_0.prop_9 == Class_508.StartObject)
					{
						throw Class_417.xmethod_3101(arg_0, "Unexpected token when deserializing primitive value: " + arg_0.prop_9);
					}
					object result3 = this.kmethod_3857(arg_0, type, arg_7, arg_3, null, null, obje_0);
					this.vmethod_3865(arg_0);
					return result3;
				}
				break;
			}
			case Class_448.Dictionary:
			{
				Class_453 class_3 = (Class_453)arg_2;
				object result4;
				if (obje_0 == null)
				{
					bool flag2;
					IDictionary dictionary = this.vmethod_3875(arg_0, class_3, out flag2);
					if (flag2)
					{
						if (text != null)
						{
							throw Class_417.xmethod_3101(arg_0, "Cannot preserve reference to readonly dictionary, or dictionary created from a non-default constructor: {0}.".FormatWith(CultureInfo.InvariantCulture, arg_2.prop_0));
						}
						if (arg_2.prop_8.Count > 0)
						{
							throw Class_417.xmethod_3101(arg_0, "Cannot call OnSerializing on readonly dictionary, or dictionary created from a non-default constructor: {0}.".FormatWith(CultureInfo.InvariantCulture, arg_2.prop_0));
						}
						if (arg_2.prop_9.Count > 0)
						{
							throw Class_417.xmethod_3101(arg_0, "Cannot call OnError on readonly list, or dictionary created from a non-default constructor: {0}.".FormatWith(CultureInfo.InvariantCulture, arg_2.prop_0));
						}
						if (!class_3.prop_6)
						{
							throw Class_417.xmethod_3101(arg_0, "Cannot deserialize readonly or fixed size dictionary: {0}.".FormatWith(CultureInfo.InvariantCulture, arg_2.prop_0));
						}
					}
					this.lmethod_3878(dictionary, arg_0, class_3, arg_3, text);
					if (flag2)
					{
						return class_3.prop_5(new object[]
						{
							dictionary
						});
					}
					if (dictionary is Class_503)
					{
						return ((Class_503)dictionary).prop_0;
					}
					result4 = dictionary;
				}
				else
				{
					result4 = this.lmethod_3878(class_3.prop_4 ? class_3.pmethod_3639(obje_0) : ((IDictionary)obje_0), arg_0, class_3, arg_3, text);
				}
				return result4;
			}
			case Class_448.Dynamic:
			{
				Class_365 arg_8 = (Class_365)arg_2;
				return this.cmethod_3884(arg_0, arg_8, arg_3, text);
			}
			case Class_448.Serializable:
			{
				Class_367 arg_9 = (Class_367)arg_2;
				return this.tmethod_3882(arg_0, arg_9, arg_3, text);
			}
			}
			string text2 = "Cannot deserialize the current JSON object (e.g. {{\"name\":\"value\"}}) into type '{0}' because the type requires a {1} to deserialize correctly." + Environment.NewLine + "To fix this error either change the JSON to a {1} or change the deserialized type so that it is a normal .NET type (e.g. not a primitive type like integer, not a collection type like an array or List<T>) that can be deserialized from a JSON object. JsonObjectAttribute can also be added to the type to force it to deserialize from a JSON object." + Environment.NewLine;
			text2 = text2.FormatWith(CultureInfo.InvariantCulture, type, this.lmethod_3858(arg_2));
			throw Class_417.xmethod_3101(arg_0, text2);
		}

		// Token: 0x06001516 RID: 5398 RVA: 0x00062160 File Offset: 0x00060360
		private bool xmethod_3861(Class_425 arg_0, ref Type arg_1, ref Class_349 arg_2, Class_454 arg_3, Class_350 arg_4, Class_454 arg_5, object obje_0, out object arg_6, out string arg_7)
		{
			arg_7 = null;
			arg_6 = null;
			if (arg_0.prop_9 == Class_508.StartObject)
			{
				Class_423 class_ = (Class_423)arg_0.prop_0;
				Class_361 class_2 = class_.kmethod_3307("$ref");
				if (class_2 != null)
				{
					if (class_2.prop_3 != Class_428.String && class_2.prop_3 != Class_428.Null)
					{
						throw Class_417.gmethod_3103(class_2, class_2.prop_7, "JSON reference {0} property must have a string or null value.".FormatWith(CultureInfo.InvariantCulture, "$ref"), null);
					}
					Class_361 class_3 = class_2.prop_1;
					Class_361 class_4 = null;
					if (class_3.prop_5 != null)
					{
						class_4 = class_3.prop_5;
					}
					else if (class_3.prop_6 != null)
					{
						class_4 = class_3.prop_6;
					}
					string text = Class_361.lmethod_2508(class_2);
					if (text != null)
					{
						if (class_4 != null)
						{
							throw Class_417.gmethod_3103(class_4, class_4.prop_7, "Additional content found in JSON reference object. A JSON reference object should only have a {0} property.".FormatWith(CultureInfo.InvariantCulture, "$ref"), null);
						}
						arg_6 = this.field_3.pmethod_3179().xmethod_2681(this, text);
						if (this.field_4 != null && this.field_4.prop_0 >= TraceLevel.Info)
						{
							this.field_4.gmethod_2303(TraceLevel.Info, Class_326.FormatMessage(arg_0, arg_0.prop_13, "Resolved object reference '{0}' to {1}.".FormatWith(CultureInfo.InvariantCulture, text, arg_6.GetType())), null);
						}
						arg_0.smethod_1900();
						return true;
					}
				}
				Class_361 class_5 = class_.kmethod_3307("$type");
				if (class_5 != null)
				{
					string str_ = Class_361.lmethod_2508(class_5);
					Class_285 arg_8 = class_5.lmethod_2558();
					this.vmethod_3865(arg_8);
					this.gmethod_3863(arg_8, ref arg_1, ref arg_2, arg_3, arg_4, arg_5, str_);
					Class_361 class_6 = class_.kmethod_3307("$value");
					if (class_6 != null)
					{
						for (;;)
						{
							this.vmethod_3865(arg_0);
							if (arg_0.prop_9 == Class_508.PropertyName && (string)arg_0.prop_10 == "$value")
							{
								break;
							}
							this.vmethod_3865(arg_0);
							arg_0.smethod_1900();
						}
						return false;
					}
				}
				Class_361 class_7 = class_.kmethod_3307("$id");
				if (class_7 != null)
				{
					arg_7 = Class_361.lmethod_2508(class_7);
				}
				Class_361 class_8 = class_.kmethod_3307("$values");
				if (class_8 != null)
				{
					Class_285 arg_9 = class_8.lmethod_2558();
					this.vmethod_3865(arg_9);
					arg_6 = this.dmethod_3866(arg_9, arg_1, arg_2, arg_3, obje_0, arg_7);
					arg_0.smethod_1900();
					return true;
				}
			}
			this.vmethod_3865(arg_0);
			return false;
		}

		// Token: 0x06001517 RID: 5399 RVA: 0x000623AC File Offset: 0x000605AC
		private bool tmethod_3862(Class_285 arg_0, ref Type arg_1, ref Class_349 arg_2, Class_454 arg_3, Class_350 arg_4, Class_454 arg_5, object obje_0, out object arg_6, out string arg_7)
		{
			arg_7 = null;
			arg_6 = null;
			if (arg_0.prop_9 == Class_508.PropertyName)
			{
				string text = arg_0.prop_10.ToString();
				if (text.Length > 0 && text[0] == '$')
				{
					string text2;
					for (;;)
					{
						text = arg_0.prop_10.ToString();
						bool flag;
						if (string.Equals(text, "$ref", StringComparison.Ordinal))
						{
							this.vmethod_3865(arg_0);
							if (arg_0.prop_9 != Class_508.String && arg_0.prop_9 != Class_508.Null)
							{
								break;
							}
							text2 = ((arg_0.prop_10 != null) ? arg_0.prop_10.ToString() : null);
							this.vmethod_3865(arg_0);
							if (text2 != null)
							{
								goto Block_7;
							}
							flag = true;
						}
						else if (string.Equals(text, "$type", StringComparison.Ordinal))
						{
							this.vmethod_3865(arg_0);
							string str_ = arg_0.prop_10.ToString();
							this.gmethod_3863(arg_0, ref arg_1, ref arg_2, arg_3, arg_4, arg_5, str_);
							this.vmethod_3865(arg_0);
							flag = true;
						}
						else if (string.Equals(text, "$id", StringComparison.Ordinal))
						{
							this.vmethod_3865(arg_0);
							arg_7 = ((arg_0.prop_10 != null) ? arg_0.prop_10.ToString() : null);
							this.vmethod_3865(arg_0);
							flag = true;
						}
						else
						{
							if (string.Equals(text, "$values", StringComparison.Ordinal))
							{
								goto Block_14;
							}
							flag = false;
						}
						if (!flag || arg_0.prop_9 != Class_508.PropertyName)
						{
							return false;
						}
					}
					throw Class_417.xmethod_3101(arg_0, "JSON reference {0} property must have a string or null value.".FormatWith(CultureInfo.InvariantCulture, "$ref"));
					Block_7:
					if (arg_0.prop_9 == Class_508.PropertyName)
					{
						throw Class_417.xmethod_3101(arg_0, "Additional content found in JSON reference object. A JSON reference object should only have a {0} property.".FormatWith(CultureInfo.InvariantCulture, "$ref"));
					}
					arg_6 = this.field_3.pmethod_3179().xmethod_2681(this, text2);
					if (this.field_4 != null && this.field_4.prop_0 >= TraceLevel.Info)
					{
						this.field_4.gmethod_2303(TraceLevel.Info, Class_326.FormatMessage(arg_0 as Class_353, arg_0.prop_13, "Resolved object reference '{0}' to {1}.".FormatWith(CultureInfo.InvariantCulture, text2, arg_6.GetType())), null);
					}
					return true;
					Block_14:
					this.vmethod_3865(arg_0);
					object obj = this.dmethod_3866(arg_0, arg_1, arg_2, arg_3, obje_0, arg_7);
					this.vmethod_3865(arg_0);
					arg_6 = obj;
					return true;
				}
			}
			return false;
		}

		// Token: 0x06001518 RID: 5400 RVA: 0x000625E4 File Offset: 0x000607E4
		private void gmethod_3863(Class_285 arg_0, ref Type arg_1, ref Class_349 arg_2, Class_454 arg_3, Class_350 arg_4, Class_454 arg_5, string str_0)
		{
			Class_494 class_ = ((arg_3 != null) ? arg_3.prop_21 : null) ?? (((arg_4 != null) ? arg_4.prop_5 : null) ?? (((arg_5 != null) ? arg_5.prop_27 : null) ?? this.field_3.field_0));
			if (class_ != Class_494.None)
			{
				string typeName;
				string assemblyName;
				Class_514.SplitFullyQualifiedTypeName(str_0, out typeName, out assemblyName);
				Type type;
				try
				{
					type = this.field_3.field_13.BindToType(assemblyName, typeName);
				}
				catch (Exception arg_6)
				{
					throw Class_417.tmethod_3102(arg_0, "Error resolving type specified in JSON '{0}'.".FormatWith(CultureInfo.InvariantCulture, str_0), arg_6);
				}
				if (type == null)
				{
					throw Class_417.xmethod_3101(arg_0, "Type specified in JSON '{0}' was not resolved.".FormatWith(CultureInfo.InvariantCulture, str_0));
				}
				if (this.field_4 != null && this.field_4.prop_0 >= TraceLevel.Verbose)
				{
					this.field_4.gmethod_2303(TraceLevel.Verbose, Class_326.FormatMessage(arg_0 as Class_353, arg_0.prop_13, "Resolved type '{0}' to {1}.".FormatWith(CultureInfo.InvariantCulture, str_0, type)), null);
				}
				if (arg_1 != null && arg_1 != typeof(IDynamicMetaObjectProvider) && !arg_1.IsAssignableFrom(type))
				{
					throw Class_417.xmethod_3101(arg_0, "Type specified in JSON '{0}' is not compatible with '{1}'.".FormatWith(CultureInfo.InvariantCulture, type.AssemblyQualifiedName, arg_1.AssemblyQualifiedName));
				}
				arg_1 = type;
				arg_2 = this.tmethod_3852(type);
			}
		}

		// Token: 0x06001519 RID: 5401 RVA: 0x000627D0 File Offset: 0x000609D0
		private Class_447 cmethod_3864(Class_285 arg_0, Type arg_1, Class_349 arg_2)
		{
			if (arg_2 == null)
			{
				throw Class_417.xmethod_3101(arg_0, "Could not resolve type '{0}' to a JsonContract.".FormatWith(CultureInfo.InvariantCulture, arg_1));
			}
			Class_447 class_ = arg_2 as Class_447;
			if (class_ == null)
			{
				string text = "Cannot deserialize the current JSON array (e.g. [1,2,3]) into type '{0}' because the type requires a {1} to deserialize correctly." + Environment.NewLine + "To fix this error either change the JSON to a {1} or change the deserialized type to an array or a type that implements a collection interface (e.g. ICollection, IList) like List<T> that can be deserialized from a JSON array. JsonArrayAttribute can also be added to the type to force it to deserialize from a JSON array." + Environment.NewLine;
				text = text.FormatWith(CultureInfo.InvariantCulture, arg_1, this.lmethod_3858(arg_2));
				throw Class_417.xmethod_3101(arg_0, text);
			}
			return class_;
		}

		// Token: 0x0600151A RID: 5402 RVA: 0x0006283E File Offset: 0x00060A3E
		private void vmethod_3865(Class_285 arg_0)
		{
			if (!arg_0.vmethod_1885())
			{
				throw Class_417.xmethod_3101(arg_0, "Unexpected end when deserializing object.");
			}
		}

		// Token: 0x0600151B RID: 5403 RVA: 0x00062858 File Offset: 0x00060A58
		private object dmethod_3866(Class_285 arg_0, Type arg_1, Class_349 arg_2, Class_454 arg_3, object obje_0, string str_0)
		{
			if (this.kmethod_3867(arg_2))
			{
				return this.vmethod_3855(arg_0, arg_2);
			}
			Class_447 class_ = this.cmethod_3864(arg_0, arg_1, arg_2);
			object result;
			if (obje_0 == null)
			{
				bool flag;
				IList list = this.cmethod_3874(arg_0, class_, out flag);
				if (flag)
				{
					if (str_0 != null)
					{
						throw Class_417.xmethod_3101(arg_0, "Cannot preserve reference to array or readonly list, or list created from a non-default constructor: {0}.".FormatWith(CultureInfo.InvariantCulture, arg_2.prop_0));
					}
					if (arg_2.prop_8.Count > 0)
					{
						throw Class_417.xmethod_3101(arg_0, "Cannot call OnSerializing on an array or readonly list, or list created from a non-default constructor: {0}.".FormatWith(CultureInfo.InvariantCulture, arg_2.prop_0));
					}
					if (arg_2.prop_9.Count > 0)
					{
						throw Class_417.xmethod_3101(arg_0, "Cannot call OnError on an array or readonly list, or list created from a non-default constructor: {0}.".FormatWith(CultureInfo.InvariantCulture, arg_2.prop_0));
					}
					if (!class_.prop_6 && !class_.prop_2)
					{
						throw Class_417.xmethod_3101(arg_0, "Cannot deserialize readonly or fixed size list: {0}.".FormatWith(CultureInfo.InvariantCulture, arg_2.prop_0));
					}
				}
				if (!class_.prop_1)
				{
					this.xmethod_3881(list, arg_0, class_, arg_3, str_0);
				}
				else
				{
					this.pmethod_3879(list, arg_0, class_, arg_3, str_0);
				}
				if (flag)
				{
					if (class_.prop_1)
					{
						list = Class_510.ToMultidimensionalArray(list, class_.prop_0, arg_2.prop_1.GetArrayRank());
					}
					else
					{
						if (!class_.prop_2)
						{
							return class_.prop_5(new object[]
							{
								list
							});
						}
						Array array = Array.CreateInstance(class_.prop_0, list.Count);
						list.CopyTo(array, 0);
						list = array;
					}
				}
				else if (list is Class_500)
				{
					return ((Class_500)list).prop_0;
				}
				result = list;
			}
			else
			{
				if (!class_.prop_4)
				{
					throw Class_417.xmethod_3101(arg_0, "Cannot populate list type {0}.".FormatWith(CultureInfo.InvariantCulture, arg_2.prop_1));
				}
				result = this.xmethod_3881(class_.prop_3 ? class_.vmethod_3625(obje_0) : ((IList)obje_0), arg_0, class_, arg_3, str_0);
			}
			return result;
		}

		// Token: 0x0600151C RID: 5404 RVA: 0x00062A64 File Offset: 0x00060C64
		private bool kmethod_3867(Class_349 arg_0)
		{
			return arg_0 == null || arg_0.prop_0 == typeof(object) || arg_0.field_5 == Class_448.Linq || arg_0.prop_0 == typeof(IDynamicMetaObjectProvider);
		}

		// Token: 0x0600151D RID: 5405 RVA: 0x00062AB4 File Offset: 0x00060CB4
		private object lmethod_3868(Class_285 arg_0, object obje_0, CultureInfo arg_1, Class_349 arg_2, Type arg_3)
		{
			if (arg_3 == null)
			{
				return obje_0;
			}
			Type objectType = Class_514.GetObjectType(obje_0);
			if (objectType != arg_3)
			{
				if (obje_0 == null && arg_2.field_0)
				{
					return null;
				}
				try
				{
					if (!arg_2.field_1)
					{
						return Class_499.ConvertOrCast(obje_0, arg_1, arg_2.field_3);
					}
					Class_369 class_ = (Class_369)arg_2;
					if (arg_2.field_2)
					{
						if (obje_0 is string)
						{
							return Enum.Parse(arg_2.field_3, obje_0.ToString(), true);
						}
						if (Class_499.IsInteger(class_.prop_0))
						{
							return Enum.ToObject(arg_2.field_3, obje_0);
						}
					}
					if (obje_0 is BigInteger)
					{
						return Class_499.FromBigInteger((BigInteger)obje_0, arg_3);
					}
					return Convert.ChangeType(obje_0, arg_2.field_3, arg_1);
				}
				catch (Exception arg_4)
				{
					throw Class_417.tmethod_3102(arg_0, "Error converting value {0} to type '{1}'.".FormatWith(CultureInfo.InvariantCulture, Class_513.FormatValueForPrint(obje_0), arg_3), arg_4);
				}
				return obje_0;
			}
			return obje_0;
		}

		// Token: 0x0600151E RID: 5406 RVA: 0x00062BE0 File Offset: 0x00060DE0
		private bool pmethod_3869(Class_454 arg_0, Class_299 arg_1, Class_350 arg_2, Class_454 arg_3, Class_285 arg_4, object obje_0)
		{
			bool flag;
			object obj;
			Class_349 arg_5;
			bool flag2;
			if (this.smethod_3870(arg_0, ref arg_1, arg_2, arg_3, arg_4, obje_0, out flag, out obj, out arg_5, out flag2))
			{
				return false;
			}
			object obj2;
			if (arg_1 != null && arg_1.prop_0)
			{
				if (!flag2 && obje_0 != null && arg_0.prop_11)
				{
					obj = arg_0.prop_5.pmethod_2309(obje_0);
				}
				obj2 = this.dmethod_3886(arg_1, arg_4, arg_0.prop_7, obj);
			}
			else
			{
				obj2 = this.kmethod_3857(arg_4, arg_0.prop_7, arg_5, arg_0, arg_2, arg_3, flag ? obj : null);
			}
			if ((!flag || obj2 != obj) && this.gmethod_3873(arg_0, obj2))
			{
				arg_0.prop_5.lmethod_2308(obje_0, obj2);
				if (arg_0.prop_24 != null)
				{
					if (this.field_4 != null && this.field_4.prop_0 >= TraceLevel.Verbose)
					{
						this.field_4.gmethod_2303(TraceLevel.Verbose, Class_326.FormatMessage(arg_4 as Class_353, arg_4.prop_13, "IsSpecified for property '{0}' on {1} set to true.".FormatWith(CultureInfo.InvariantCulture, arg_0.prop_1, arg_0.prop_2)), null);
					}
					arg_0.prop_24(obje_0, true);
				}
				return true;
			}
			return flag;
		}

		// Token: 0x0600151F RID: 5407 RVA: 0x00062D20 File Offset: 0x00060F20
		private bool smethod_3870(Class_454 arg_0, ref Class_299 arg_1, Class_350 arg_2, Class_454 arg_3, Class_285 arg_4, object obje_0, out bool arg_5, out object arg_6, out Class_349 arg_7, out bool arg_8)
		{
			arg_6 = null;
			arg_5 = false;
			arg_7 = null;
			arg_8 = false;
			if (arg_0.prop_10)
			{
				return true;
			}
			Class_508 class_ = arg_4.prop_9;
			if (arg_0.prop_0 == null)
			{
				arg_0.prop_0 = this.tmethod_3852(arg_0.prop_7);
			}
			Class_384 valueOrDefault = arg_0.prop_20.GetValueOrDefault(this.field_3.field_5);
			if (valueOrDefault != Class_384.Replace && (class_ == Class_508.StartArray || class_ == Class_508.StartObject) && arg_0.prop_11)
			{
				arg_6 = arg_0.prop_5.pmethod_2309(obje_0);
				arg_8 = true;
				if (arg_6 != null)
				{
					arg_7 = this.tmethod_3852(arg_6.GetType());
					arg_5 = (!arg_7.field_6 && !arg_7.prop_0.IsValueType);
				}
			}
			if (!arg_0.prop_12 && !arg_5)
			{
				return true;
			}
			if (arg_0.prop_17.GetValueOrDefault(this.field_3.field_6) == Class_457.Ignore && class_ == Class_508.Null)
			{
				return true;
			}
			if (this.tmethod_3872(arg_0.prop_18.GetValueOrDefault(this.field_3.field_7), Class_377.Ignore) && !this.tmethod_3872(arg_0.prop_18.GetValueOrDefault(this.field_3.field_7), Class_377.Populate) && Class_486.IsPrimitiveToken(class_) && Class_513.ValueEquals(arg_4.prop_10, arg_0.xmethod_3671()))
			{
				return true;
			}
			if (arg_6 == null)
			{
				arg_7 = arg_0.prop_0;
			}
			else
			{
				arg_7 = this.tmethod_3852(arg_6.GetType());
				if (arg_7 != arg_0.prop_0)
				{
					arg_1 = this.pmethod_3859(arg_7, arg_0.prop_9, arg_2, arg_3);
				}
			}
			return false;
		}

		// Token: 0x06001520 RID: 5408 RVA: 0x00062EF4 File Offset: 0x000610F4
		private void xmethod_3871(Class_285 arg_0, string str_0, object obje_0)
		{
			try
			{
				if (this.field_4 != null && this.field_4.prop_0 >= TraceLevel.Verbose)
				{
					this.field_4.gmethod_2303(TraceLevel.Verbose, Class_326.FormatMessage(arg_0 as Class_353, arg_0.prop_13, "Read object reference Id '{0}' for {1}.".FormatWith(CultureInfo.InvariantCulture, str_0, obje_0.GetType())), null);
				}
				this.field_3.pmethod_3179().cmethod_2684(this, str_0, obje_0);
			}
			catch (Exception arg_)
			{
				throw Class_417.tmethod_3102(arg_0, "Error reading object reference '{0}'.".FormatWith(CultureInfo.InvariantCulture, str_0), arg_);
			}
		}

		// Token: 0x06001521 RID: 5409 RVA: 0x00043B2F File Offset: 0x00041D2F
		private bool tmethod_3872(Class_377 arg_0, Class_377 arg_1)
		{
			return (arg_0 & arg_1) == arg_1;
		}

		// Token: 0x06001522 RID: 5410 RVA: 0x00062F94 File Offset: 0x00061194
		private bool gmethod_3873(Class_454 arg_0, object obje_0)
		{
			return (arg_0.prop_17.GetValueOrDefault(this.field_3.field_6) != Class_457.Ignore || obje_0 != null) && (!this.tmethod_3872(arg_0.prop_18.GetValueOrDefault(this.field_3.field_7), Class_377.Ignore) || this.tmethod_3872(arg_0.prop_18.GetValueOrDefault(this.field_3.field_7), Class_377.Populate) || !Class_513.ValueEquals(obje_0, arg_0.xmethod_3671())) && arg_0.prop_12;
		}

		// Token: 0x06001523 RID: 5411 RVA: 0x00063034 File Offset: 0x00061234
		private IList cmethod_3874(Class_285 arg_0, Class_447 arg_1, out bool arg_2)
		{
			if (!arg_1.prop_4)
			{
				throw Class_417.xmethod_3101(arg_0, "Cannot create and populate list type {0}.".FormatWith(CultureInfo.InvariantCulture, arg_1.prop_1));
			}
			if (arg_1.field_6)
			{
				arg_2 = true;
				IList list = arg_1.dmethod_3626();
				if (arg_1.prop_3)
				{
					list = arg_1.vmethod_3625(list);
				}
				return list;
			}
			if (arg_1.prop_15 != null && (!arg_1.prop_16 || this.field_3.field_8 == Class_312.AllowNonPublicDefaultConstructor))
			{
				object obj = arg_1.prop_15();
				if (arg_1.prop_3)
				{
					obj = arg_1.vmethod_3625(obj);
				}
				arg_2 = false;
				return (IList)obj;
			}
			if (arg_1.prop_6)
			{
				arg_2 = true;
				return arg_1.dmethod_3626();
			}
			if (!arg_1.field_8)
			{
				throw Class_417.xmethod_3101(arg_0, "Could not create an instance of type {0}. Type is an interface or abstract class and cannot be instantiated.".FormatWith(CultureInfo.InvariantCulture, arg_1.prop_0));
			}
			throw Class_417.xmethod_3101(arg_0, "Unable to find a constructor to use for type {0}.".FormatWith(CultureInfo.InvariantCulture, arg_1.prop_0));
		}

		// Token: 0x06001524 RID: 5412 RVA: 0x0006313C File Offset: 0x0006133C
		private IDictionary vmethod_3875(Class_285 arg_0, Class_453 arg_1, out bool arg_2)
		{
			if (arg_1.field_6)
			{
				arg_2 = true;
				return arg_1.smethod_3640();
			}
			if (arg_1.prop_15 != null && (!arg_1.prop_16 || this.field_3.field_8 == Class_312.AllowNonPublicDefaultConstructor))
			{
				object obj = arg_1.prop_15();
				if (arg_1.prop_4)
				{
					obj = arg_1.pmethod_3639(obj);
				}
				arg_2 = false;
				return (IDictionary)obj;
			}
			if (arg_1.prop_6)
			{
				arg_2 = true;
				return arg_1.smethod_3640();
			}
			if (!arg_1.field_8)
			{
				throw Class_417.xmethod_3101(arg_0, "Could not create an instance of type {0}. Type is an interface or abstract class and cannot be instantiated.".FormatWith(CultureInfo.InvariantCulture, arg_1.prop_0));
			}
			throw Class_417.xmethod_3101(arg_0, "Unable to find a default constructor to use for type {0}.".FormatWith(CultureInfo.InvariantCulture, arg_1.prop_0));
		}

		// Token: 0x06001525 RID: 5413 RVA: 0x00063208 File Offset: 0x00061408
		private void dmethod_3876(Class_285 arg_0, Class_349 arg_1, object obje_0)
		{
			if (this.field_4 != null && this.field_4.prop_0 >= TraceLevel.Info)
			{
				this.field_4.gmethod_2303(TraceLevel.Info, Class_326.FormatMessage(arg_0 as Class_353, arg_0.prop_13, "Started deserializing {0}".FormatWith(CultureInfo.InvariantCulture, arg_1.prop_0)), null);
			}
			arg_1.vmethod_2345(obje_0, this.field_3.field_14);
		}

		// Token: 0x06001526 RID: 5414 RVA: 0x00063278 File Offset: 0x00061478
		private void kmethod_3877(Class_285 arg_0, Class_349 arg_1, object obje_0)
		{
			if (this.field_4 != null && this.field_4.prop_0 >= TraceLevel.Info)
			{
				this.field_4.gmethod_2303(TraceLevel.Info, Class_326.FormatMessage(arg_0 as Class_353, arg_0.prop_13, "Finished deserializing {0}".FormatWith(CultureInfo.InvariantCulture, arg_1.prop_0)), null);
			}
			arg_1.dmethod_2346(obje_0, this.field_3.field_14);
		}

		// Token: 0x06001527 RID: 5415 RVA: 0x000632E8 File Offset: 0x000614E8
		private object lmethod_3878(IDictionary arg_0, Class_285 arg_1, Class_453 arg_2, Class_454 arg_3, string str_0)
		{
			Class_503 class_ = arg_0 as Class_503;
			object obj = (class_ != null) ? class_.prop_0 : arg_0;
			if (str_0 != null)
			{
				this.xmethod_3871(arg_1, str_0, obj);
			}
			this.dmethod_3876(arg_1, arg_2, obj);
			int sayıInt_ = arg_1.prop_12;
			if (arg_2.prop_3 == null)
			{
				arg_2.prop_3 = this.tmethod_3852(arg_2.prop_1);
			}
			if (arg_2.prop_0 == null)
			{
				arg_2.prop_0 = this.tmethod_3852(arg_2.prop_2);
			}
			Class_299 class_2 = arg_2.prop_2 ?? this.pmethod_3859(arg_2.prop_0, null, arg_2, arg_3);
			Class_496 class_3 = (arg_2.prop_3 is Class_369) ? ((Class_369)arg_2.prop_3).prop_0 : Class_496.Empty;
			bool flag = false;
			for (;;)
			{
				Class_508 class_4 = arg_1.prop_9;
				switch (class_4)
				{
				case Class_508.PropertyName:
				{
					object obj2 = arg_1.prop_10;
					if (!this.xmethod_3891(arg_1, obj2.ToString()))
					{
						try
						{
							try
							{
								Class_320 class_5;
								switch (class_3)
								{
								case Class_496.DateTime:
								case Class_496.DateTimeNullable:
									class_5 = Class_320.DateTime;
									break;
								case Class_496.DateTimeOffset:
								case Class_496.DateTimeOffsetNullable:
									class_5 = Class_320.DateTimeOffset;
									break;
								default:
									class_5 = Class_320.None;
									break;
								}
								object obj3;
								if (class_5 != Class_320.None && Class_502.TryParseDateTime(obj2.ToString(), class_5, arg_1.prop_4, arg_1.prop_7, arg_1.prop_14, out obj3))
								{
									obj2 = obj3;
								}
								else
								{
									obj2 = this.lmethod_3868(arg_1, obj2, CultureInfo.InvariantCulture, arg_2.prop_3, arg_2.prop_1);
								}
							}
							catch (Exception arg_4)
							{
								throw Class_417.tmethod_3102(arg_1, "Could not convert string '{0}' to dictionary key type '{1}'. Create a TypeConverter to convert from the string to the key type object.".FormatWith(CultureInfo.InvariantCulture, arg_1.prop_10, arg_2.prop_1), arg_4);
							}
							if (!this.lmethod_3888(arg_1, arg_2.prop_0, class_2 != null))
							{
								throw Class_417.xmethod_3101(arg_1, "Unexpected end when deserializing object.");
							}
							object value;
							if (class_2 != null && class_2.prop_0)
							{
								value = this.dmethod_3886(class_2, arg_1, arg_2.prop_2, null);
							}
							else
							{
								value = this.kmethod_3857(arg_1, arg_2.prop_2, arg_2.prop_0, null, arg_2, arg_3, null);
							}
							arg_0[obj2] = value;
							break;
						}
						catch (Exception arg_5)
						{
							if (base.smethod_3850(obj, arg_2, obj2, arg_1 as Class_353, arg_1.prop_13, arg_5))
							{
								this.vmethod_3895(arg_1, true, sayıInt_);
								break;
							}
							throw;
						}
						goto IL_25D;
					}
					break;
				}
				case Class_508.Comment:
					break;
				default:
					if (class_4 != Class_508.EndObject)
					{
						goto Block_8;
					}
					goto IL_25D;
				}
				IL_281:
				if (flag || !arg_1.vmethod_1885())
				{
					goto IL_293;
				}
				continue;
				IL_25D:
				flag = true;
				goto IL_281;
			}
			Block_8:
			throw Class_417.xmethod_3101(arg_1, "Unexpected token when deserializing object: " + arg_1.prop_9);
			IL_293:
			if (!flag)
			{
				this.smethod_3880(arg_1, arg_2, obj, "Unexpected end when deserializing object.");
			}
			this.kmethod_3877(arg_1, arg_2, obj);
			return obj;
		}

		// Token: 0x06001528 RID: 5416 RVA: 0x000635DC File Offset: 0x000617DC
		private object pmethod_3879(IList arg_0, Class_285 arg_1, Class_447 arg_2, Class_454 arg_3, string str_0)
		{
			int arrayRank = arg_2.prop_0.GetArrayRank();
			if (str_0 != null)
			{
				this.xmethod_3871(arg_1, str_0, arg_0);
			}
			this.dmethod_3876(arg_1, arg_2, arg_0);
			Class_349 class_ = this.tmethod_3852(arg_2.prop_0);
			Class_299 class_2 = this.pmethod_3859(class_, null, arg_2, arg_3);
			int? num = null;
			Stack<IList> stack = new Stack<IList>();
			stack.Push(arg_0);
			IList list = arg_0;
			bool flag = false;
			for (;;)
			{
				int sayıInt_ = arg_1.prop_12;
				if (stack.Count == arrayRank)
				{
					try
					{
						if (this.lmethod_3888(arg_1, class_, class_2 != null))
						{
							Class_508 class_3 = arg_1.prop_9;
							if (class_3 != Class_508.Comment)
							{
								if (class_3 == Class_508.EndArray)
								{
									stack.Pop();
									list = stack.Peek();
									num = null;
								}
								else
								{
									object value;
									if (class_2 != null && class_2.prop_0)
									{
										value = this.dmethod_3886(class_2, arg_1, arg_2.prop_0, null);
									}
									else
									{
										value = this.kmethod_3857(arg_1, arg_2.prop_0, class_, null, arg_2, arg_3, null);
									}
									list.Add(value);
								}
							}
							goto IL_249;
						}
						goto IL_250;
					}
					catch (Exception ex)
					{
						Class_326 class_4 = arg_1.xmethod_1881(sayıInt_);
						if (!base.smethod_3850(arg_0, arg_2, class_4.Position, arg_1 as Class_353, arg_1.prop_13, ex))
						{
							throw;
						}
						this.vmethod_3895(arg_1, true, sayıInt_);
						if (num != null && num == class_4.Position)
						{
							throw Class_417.tmethod_3102(arg_1, "Infinite loop detected from error handling.", ex);
						}
						num = new int?(class_4.Position);
						goto IL_249;
					}
					goto IL_1AE;
				}
				goto IL_1AE;
				IL_249:
				if (flag)
				{
					goto IL_250;
				}
				continue;
				IL_1AE:
				if (!arg_1.vmethod_1885())
				{
					goto IL_250;
				}
				Class_508 class_5 = arg_1.prop_9;
				if (class_5 == Class_508.StartArray)
				{
					IList list2 = new List<object>();
					list.Add(list2);
					stack.Push(list2);
					list = list2;
					goto IL_249;
				}
				if (class_5 == Class_508.Comment)
				{
					goto IL_249;
				}
				if (class_5 != Class_508.EndArray)
				{
					break;
				}
				stack.Pop();
				if (stack.Count > 0)
				{
					list = stack.Peek();
					goto IL_249;
				}
				flag = true;
				goto IL_249;
			}
			throw Class_417.xmethod_3101(arg_1, "Unexpected token when deserializing multidimensional array: " + arg_1.prop_9);
			IL_250:
			if (!flag)
			{
				this.smethod_3880(arg_1, arg_2, arg_0, "Unexpected end when deserializing array.");
			}
			this.kmethod_3877(arg_1, arg_2, arg_0);
			return arg_0;
		}

		// Token: 0x06001529 RID: 5417 RVA: 0x00063868 File Offset: 0x00061A68
		private void smethod_3880(Class_285 arg_0, Class_349 arg_1, object obje_0, string str_0)
		{
			try
			{
				throw Class_417.xmethod_3101(arg_0, str_0);
			}
			catch (Exception arg_2)
			{
				if (!base.smethod_3850(obje_0, arg_1, null, arg_0 as Class_353, arg_0.prop_13, arg_2))
				{
					throw;
				}
				this.vmethod_3895(arg_0, false, 0);
			}
		}

		// Token: 0x0600152A RID: 5418 RVA: 0x000638C0 File Offset: 0x00061AC0
		private object xmethod_3881(IList arg_0, Class_285 arg_1, Class_447 arg_2, Class_454 arg_3, string str_0)
		{
			Class_500 class_ = arg_0 as Class_500;
			object obj = (class_ != null) ? class_.prop_0 : arg_0;
			if (str_0 != null)
			{
				this.xmethod_3871(arg_1, str_0, obj);
			}
			if (arg_0.IsFixedSize)
			{
				arg_1.smethod_1900();
				return obj;
			}
			this.dmethod_3876(arg_1, arg_2, obj);
			int sayıInt_ = arg_1.prop_12;
			if (arg_2.prop_0 == null)
			{
				arg_2.prop_0 = this.tmethod_3852(arg_2.prop_0);
			}
			Class_299 class_2 = this.pmethod_3859(arg_2.prop_0, null, arg_2, arg_3);
			int? num = null;
			bool flag = false;
			do
			{
				try
				{
					if (!this.lmethod_3888(arg_1, arg_2.prop_0, class_2 != null))
					{
						break;
					}
					Class_508 class_3 = arg_1.prop_9;
					if (class_3 != Class_508.Comment)
					{
						if (class_3 == Class_508.EndArray)
						{
							flag = true;
						}
						else
						{
							object value;
							if (class_2 != null && class_2.prop_0)
							{
								value = this.dmethod_3886(class_2, arg_1, arg_2.prop_0, null);
							}
							else
							{
								value = this.kmethod_3857(arg_1, arg_2.prop_0, arg_2.prop_0, null, arg_2, arg_3, null);
							}
							arg_0.Add(value);
						}
					}
				}
				catch (Exception ex)
				{
					Class_326 class_4 = arg_1.xmethod_1881(sayıInt_);
					if (!base.smethod_3850(obj, arg_2, class_4.Position, arg_1 as Class_353, arg_1.prop_13, ex))
					{
						throw;
					}
					this.vmethod_3895(arg_1, true, sayıInt_);
					if (num != null && num == class_4.Position)
					{
						throw Class_417.tmethod_3102(arg_1, "Infinite loop detected from error handling.", ex);
					}
					num = new int?(class_4.Position);
				}
			}
			while (!flag);
			if (!flag)
			{
				this.smethod_3880(arg_1, arg_2, obj, "Unexpected end when deserializing array.");
			}
			this.kmethod_3877(arg_1, arg_2, obj);
			return obj;
		}

		// Token: 0x0600152B RID: 5419 RVA: 0x00063ABC File Offset: 0x00061CBC
		private object tmethod_3882(Class_285 arg_0, Class_367 arg_1, Class_454 arg_2, string str_0)
		{
			Type arg = arg_1.prop_0;
			if (!Class_470.FullyTrusted)
			{
				string text = "Type '{0}' implements ISerializable but cannot be deserialized using the ISerializable interface because the current application is not fully trusted and ISerializable can expose secure data." + Environment.NewLine + "To fix this error either change the environment to be fully trusted, change the application to not deserialize the type, add JsonObjectAttribute to the type or change the JsonSerializer setting ContractResolver to use a new DefaultContractResolver with IgnoreSerializableInterface set to true." + Environment.NewLine;
				text = text.FormatWith(CultureInfo.InvariantCulture, arg);
				throw Class_417.xmethod_3101(arg_0, text);
			}
			if (this.field_4 != null && this.field_4.prop_0 >= TraceLevel.Info)
			{
				this.field_4.gmethod_2303(TraceLevel.Info, Class_326.FormatMessage(arg_0 as Class_353, arg_0.prop_13, "Deserializing {0} using ISerializable constructor.".FormatWith(CultureInfo.InvariantCulture, arg_1.prop_0)), null);
			}
			SerializationInfo serializationInfo = new SerializationInfo(arg_1.prop_0, new Class_366(this, arg_1, arg_2));
			bool flag = false;
			string text2;
			for (;;)
			{
				Class_508 class_ = arg_0.prop_9;
				switch (class_)
				{
				case Class_508.PropertyName:
					text2 = arg_0.prop_10.ToString();
					if (!arg_0.vmethod_1885())
					{
						goto Block_6;
					}
					serializationInfo.AddValue(text2, Class_361.dmethod_2566(arg_0));
					break;
				case Class_508.Comment:
					break;
				default:
					if (class_ != Class_508.EndObject)
					{
						goto Block_5;
					}
					flag = true;
					break;
				}
				if (flag || !arg_0.vmethod_1885())
				{
					goto IL_143;
				}
			}
			Block_5:
			throw Class_417.xmethod_3101(arg_0, "Unexpected token when deserializing object: " + arg_0.prop_9);
			Block_6:
			throw Class_417.xmethod_3101(arg_0, "Unexpected end when setting {0}'s value.".FormatWith(CultureInfo.InvariantCulture, text2));
			IL_143:
			if (!flag)
			{
				this.smethod_3880(arg_0, arg_1, serializationInfo, "Unexpected end when deserializing object.");
			}
			if (arg_1.prop_0 == null)
			{
				throw Class_417.xmethod_3101(arg_0, "ISerializable type '{0}' does not have a valid constructor. To correctly implement ISerializable a constructor that takes SerializationInfo and StreamingContext parameters should be present.".FormatWith(CultureInfo.InvariantCulture, arg));
			}
			object obj = arg_1.prop_0(new object[]
			{
				serializationInfo,
				this.field_3.field_14
			});
			if (str_0 != null)
			{
				this.xmethod_3871(arg_0, str_0, obj);
			}
			this.dmethod_3876(arg_0, arg_1, obj);
			this.kmethod_3877(arg_0, arg_1, obj);
			return obj;
		}

		// Token: 0x0600152C RID: 5420 RVA: 0x00063C9C File Offset: 0x00061E9C
		internal object gmethod_3883(Class_361 arg_0, Type arg_1, Class_367 arg_2, Class_454 arg_3)
		{
			Class_349 class_ = this.tmethod_3852(arg_1);
			Class_299 class_2 = this.pmethod_3859(class_, null, arg_2, arg_3);
			Class_285 class_3 = arg_0.lmethod_2558();
			this.vmethod_3865(class_3);
			object result;
			if (class_2 != null && class_2.prop_0)
			{
				result = this.dmethod_3886(class_2, class_3, arg_1, null);
			}
			else
			{
				result = this.kmethod_3857(class_3, arg_1, class_, null, arg_2, arg_3, null);
			}
			return result;
		}

		// Token: 0x0600152D RID: 5421 RVA: 0x00063CFC File Offset: 0x00061EFC
		private object cmethod_3884(Class_285 arg_0, Class_365 arg_1, Class_454 arg_2, string str_0)
		{
			if (!arg_1.field_8)
			{
				throw Class_417.xmethod_3101(arg_0, "Could not create an instance of type {0}. Type is an interface or abstract class and cannot be instantiated.".FormatWith(CultureInfo.InvariantCulture, arg_1.prop_0));
			}
			if (arg_1.prop_15 != null && (!arg_1.prop_16 || this.field_3.field_8 == Class_312.AllowNonPublicDefaultConstructor))
			{
				IDynamicMetaObjectProvider dynamicMetaObjectProvider = (IDynamicMetaObjectProvider)arg_1.prop_15();
				if (str_0 != null)
				{
					this.xmethod_3871(arg_0, str_0, dynamicMetaObjectProvider);
				}
				this.dmethod_3876(arg_0, arg_1, dynamicMetaObjectProvider);
				int sayıInt_ = arg_0.prop_12;
				bool flag = false;
				for (;;)
				{
					Class_508 class_ = arg_0.prop_9;
					if (class_ == Class_508.PropertyName)
					{
						string text = arg_0.prop_10.ToString();
						try
						{
							if (!arg_0.vmethod_1885())
							{
								throw Class_417.xmethod_3101(arg_0, "Unexpected end when setting {0}'s value.".FormatWith(CultureInfo.InvariantCulture, text));
							}
							Class_454 class_2 = arg_1.prop_0.cmethod_3704(text);
							if (class_2 != null && class_2.prop_12 && !class_2.prop_10)
							{
								if (class_2.prop_0 == null)
								{
									class_2.prop_0 = this.tmethod_3852(class_2.prop_7);
								}
								Class_299 arg_3 = this.pmethod_3859(class_2.prop_0, class_2.prop_9, null, null);
								if (!this.pmethod_3869(class_2, arg_3, null, arg_2, arg_0, dynamicMetaObjectProvider))
								{
									arg_0.smethod_1900();
								}
							}
							else
							{
								Type type = Class_486.IsPrimitiveToken(arg_0.prop_9) ? arg_0.prop_11 : typeof(IDynamicMetaObjectProvider);
								Class_349 class_3 = this.tmethod_3852(type);
								Class_299 class_4 = this.pmethod_3859(class_3, null, null, arg_2);
								object obje_;
								if (class_4 != null && class_4.prop_0)
								{
									obje_ = this.dmethod_3886(class_4, arg_0, type, null);
								}
								else
								{
									obje_ = this.kmethod_3857(arg_0, type, class_3, null, null, arg_2, null);
								}
								arg_1.tmethod_2642(dynamicMetaObjectProvider, text, obje_);
							}
							goto IL_24F;
						}
						catch (Exception arg_4)
						{
							if (base.smethod_3850(dynamicMetaObjectProvider, arg_1, text, arg_0 as Class_353, arg_0.prop_13, arg_4))
							{
								this.vmethod_3895(arg_0, true, sayıInt_);
								goto IL_24F;
							}
							throw;
						}
						goto IL_22C;
					}
					if (class_ != Class_508.EndObject)
					{
						break;
					}
					goto IL_22C;
					IL_24F:
					if (flag || !arg_0.vmethod_1885())
					{
						goto IL_260;
					}
					continue;
					IL_22C:
					flag = true;
					goto IL_24F;
				}
				throw Class_417.xmethod_3101(arg_0, "Unexpected token when deserializing object: " + arg_0.prop_9);
				IL_260:
				if (!flag)
				{
					this.smethod_3880(arg_0, arg_1, dynamicMetaObjectProvider, "Unexpected end when deserializing object.");
				}
				this.kmethod_3877(arg_0, arg_1, dynamicMetaObjectProvider);
				return dynamicMetaObjectProvider;
			}
			throw Class_417.xmethod_3101(arg_0, "Unable to find a default constructor to use for type {0}.".FormatWith(CultureInfo.InvariantCulture, arg_1.prop_0));
		}

		// Token: 0x0600152E RID: 5422 RVA: 0x00063FA4 File Offset: 0x000621A4
		private object vmethod_3885(Class_285 arg_0, Class_464 arg_1, Class_454 arg_2, Class_482<object> arg_3, string str_0)
		{
			Class_517.ArgumentNotNull(arg_3, "creator");
			Dictionary<Class_454, Class_466.NClass_0> dictionary;
			if (!arg_1.prop_11 && !this.tmethod_3872(this.field_3.field_7, Class_377.Populate))
			{
				dictionary = null;
			}
			else
			{
				IEnumerable<Class_454> source = arg_1.prop_2;
				if (Class_466.field_1 == null)
				{
					Class_466.field_1 = new Func<Class_454, Class_454>(Class_466.dmethod_3896);
				}
				Func<Class_454, Class_454> keySelector = Class_466.field_1;
				if (Class_466.field_2 == null)
				{
					Class_466.field_2 = new Func<Class_454, Class_466.NClass_0>(Class_466.kmethod_3897);
				}
				dictionary = source.ToDictionary(keySelector, Class_466.field_2);
			}
			Dictionary<Class_454, Class_466.NClass_0> dictionary2 = dictionary;
			Type arg_4 = arg_1.prop_0;
			if (this.field_4 != null && this.field_4.prop_0 >= TraceLevel.Info)
			{
				string separator = ", ";
				IEnumerable<Class_454> source2 = arg_1.prop_4;
				if (Class_466.field_3 == null)
				{
					Class_466.field_3 = new Func<Class_454, string>(Class_466.lmethod_3898);
				}
				string arg = string.Join(separator, source2.Select(Class_466.field_3).ToArray<string>());
				this.field_4.gmethod_2303(TraceLevel.Info, Class_326.FormatMessage(arg_0 as Class_353, arg_0.prop_13, "Deserializing {0} using creator with parameters: {1}.".FormatWith(CultureInfo.InvariantCulture, arg_1.prop_0, arg)), null);
			}
			IDictionary<string, object> dictionary4;
			IDictionary<Class_454, object> dictionary3 = this.kmethod_3887(arg_1, arg_2, arg_0, arg_4, out dictionary4);
			object[] array = new object[arg_1.prop_4.Count];
			IDictionary<Class_454, object> dictionary5 = new Dictionary<Class_454, object>();
			foreach (KeyValuePair<Class_454, object> item in dictionary3)
			{
				Func<Class_454, bool> func = null;
				Class_466.NClass_1 nclass_ = new Class_466.NClass_1();
				nclass_.field_9 = item.Key;
				Class_454 class_;
				if (arg_1.prop_4.Contains(nclass_.field_9))
				{
					class_ = nclass_.field_9;
				}
				else
				{
					IEnumerable<Class_454> source3 = arg_1.prop_4;
					if (Class_466.field_4 == null)
					{
						Class_466.field_4 = new Func<Class_454, string>(Class_466.pmethod_3899);
					}
					class_ = source3.ForgivingCaseSensitiveFind(Class_466.field_4, nclass_.field_9.prop_4);
				}
				if (class_ != null)
				{
					int num = arg_1.prop_4.IndexOf(class_);
					array[num] = item.Value;
				}
				else
				{
					dictionary5.Add(item);
				}
				if (dictionary2 != null)
				{
					IEnumerable<Class_454> keys = dictionary2.Keys;
					if (func == null)
					{
						func = new Func<Class_454, bool>(nclass_.nmethod_1);
					}
					Class_454 class_2 = keys.FirstOrDefault(func);
					if (class_2 != null)
					{
						dictionary2[class_2] = ((item.Value == null) ? Class_466.NClass_0.field_7 : Class_466.NClass_0.field_8);
					}
				}
			}
			object obj = arg_3(array);
			if (str_0 != null)
			{
				this.xmethod_3871(arg_0, str_0, obj);
			}
			this.dmethod_3876(arg_0, arg_1, obj);
			foreach (KeyValuePair<Class_454, object> keyValuePair in dictionary5)
			{
				Class_454 key = keyValuePair.Key;
				object value = keyValuePair.Value;
				if (this.gmethod_3873(key, value))
				{
					key.prop_5.lmethod_2308(obj, value);
				}
				else if (!key.prop_12 && value != null)
				{
					Class_349 class_3 = this.field_3.field_11.tmethod_3542(key.prop_7);
					if (class_3.field_5 == Class_448.Array)
					{
						Class_447 class_4 = (Class_447)class_3;
						object obj2 = key.prop_5.pmethod_2309(obj);
						if (obj2 == null)
						{
							continue;
						}
						Class_500 class_5 = class_4.vmethod_3625(obj2);
						Class_500 class_6 = class_4.vmethod_3625(value);
						using (IEnumerator enumerator3 = class_6.GetEnumerator())
						{
							while (enumerator3.MoveNext())
							{
								object value2 = enumerator3.Current;
								class_5.Add(value2);
							}
							continue;
						}
					}
					if (class_3.field_5 == Class_448.Dictionary)
					{
						Class_453 class_7 = (Class_453)class_3;
						object obj3 = key.prop_5.pmethod_2309(obj);
						if (obj3 != null)
						{
							IDictionary dictionary6 = class_7.prop_4 ? class_7.pmethod_3639(obj3) : ((IDictionary)obj3);
							IDictionary dictionary7 = class_7.prop_4 ? class_7.pmethod_3639(value) : ((IDictionary)value);
							foreach (object obj4 in dictionary7)
							{
								DictionaryEntry dictionaryEntry = (DictionaryEntry)obj4;
								dictionary6.Add(dictionaryEntry.Key, dictionaryEntry.Value);
							}
						}
					}
				}
			}
			if (dictionary4 != null)
			{
				foreach (KeyValuePair<string, object> keyValuePair2 in dictionary4)
				{
					arg_1.prop_9(obj, keyValuePair2.Key, keyValuePair2.Value);
				}
			}
			this.gmethod_3893(obj, arg_0, arg_1, arg_0.prop_12, dictionary2);
			this.kmethod_3877(arg_0, arg_1, obj);
			return obj;
		}

		// Token: 0x0600152F RID: 5423 RVA: 0x00064518 File Offset: 0x00062718
		private object dmethod_3886(Class_299 arg_0, Class_285 arg_1, Type arg_2, object obje_0)
		{
			if (this.field_4 != null && this.field_4.prop_0 >= TraceLevel.Info)
			{
				this.field_4.gmethod_2303(TraceLevel.Info, Class_326.FormatMessage(arg_1 as Class_353, arg_1.prop_13, "Started deserializing {0} with converter {1}.".FormatWith(CultureInfo.InvariantCulture, arg_2, arg_0.GetType())), null);
			}
			object result = arg_0.gmethod_2133(arg_1, arg_2, obje_0, this.cmethod_3854());
			if (this.field_4 != null && this.field_4.prop_0 >= TraceLevel.Info)
			{
				this.field_4.gmethod_2303(TraceLevel.Info, Class_326.FormatMessage(arg_1 as Class_353, arg_1.prop_13, "Finished deserializing {0} with converter {1}.".FormatWith(CultureInfo.InvariantCulture, arg_2, arg_0.GetType())), null);
			}
			return result;
		}

		// Token: 0x06001530 RID: 5424 RVA: 0x000645D8 File Offset: 0x000627D8
		private IDictionary<Class_454, object> kmethod_3887(Class_464 arg_0, Class_454 arg_1, Class_285 arg_2, Type arg_3, out IDictionary<string, object> arg_4)
		{
			arg_4 = ((arg_0.prop_9 != null) ? new Dictionary<string, object>() : null);
			IDictionary<Class_454, object> dictionary = new Dictionary<Class_454, object>();
			bool flag = false;
			string text;
			for (;;)
			{
				Class_508 class_ = arg_2.prop_9;
				switch (class_)
				{
				case Class_508.PropertyName:
				{
					text = arg_2.prop_10.ToString();
					Class_454 class_2 = arg_0.prop_4.cmethod_3704(text) ?? arg_0.prop_2.cmethod_3704(text);
					if (class_2 != null)
					{
						if (class_2.prop_0 == null)
						{
							class_2.prop_0 = this.tmethod_3852(class_2.prop_7);
						}
						Class_299 class_3 = this.pmethod_3859(class_2.prop_0, class_2.prop_9, arg_0, arg_1);
						if (!this.lmethod_3888(arg_2, class_2.prop_0, class_3 != null))
						{
							goto Block_7;
						}
						if (!class_2.prop_10)
						{
							if (class_2.prop_0 == null)
							{
								class_2.prop_0 = this.tmethod_3852(class_2.prop_7);
							}
							object value;
							if (class_3 != null && class_3.prop_0)
							{
								value = this.dmethod_3886(class_3, arg_2, class_2.prop_7, null);
							}
							else
							{
								value = this.kmethod_3857(arg_2, class_2.prop_7, class_2.prop_0, class_2, arg_0, arg_1, null);
							}
							dictionary[class_2] = value;
							break;
						}
					}
					else
					{
						if (!arg_2.vmethod_1885())
						{
							goto Block_12;
						}
						if (this.field_4 != null && this.field_4.prop_0 >= TraceLevel.Verbose)
						{
							this.field_4.gmethod_2303(TraceLevel.Verbose, Class_326.FormatMessage(arg_2 as Class_353, arg_2.prop_13, "Could not find member '{0}' on {1}.".FormatWith(CultureInfo.InvariantCulture, text, arg_0.prop_0)), null);
						}
						if (this.field_3.field_4 == Class_456.Error)
						{
							goto Block_15;
						}
					}
					if (arg_4 != null)
					{
						object value2 = this.kmethod_3857(arg_2, null, null, null, arg_0, arg_1, null);
						arg_4[text] = value2;
					}
					else
					{
						arg_2.smethod_1900();
					}
					break;
				}
				case Class_508.Comment:
					break;
				default:
					if (class_ != Class_508.EndObject)
					{
						goto Block_3;
					}
					flag = true;
					break;
				}
				if (flag || !arg_2.vmethod_1885())
				{
					return dictionary;
				}
			}
			Block_3:
			throw Class_417.xmethod_3101(arg_2, "Unexpected token when deserializing object: " + arg_2.prop_9);
			Block_7:
			throw Class_417.xmethod_3101(arg_2, "Unexpected end when setting {0}'s value.".FormatWith(CultureInfo.InvariantCulture, text));
			Block_12:
			throw Class_417.xmethod_3101(arg_2, "Unexpected end when setting {0}'s value.".FormatWith(CultureInfo.InvariantCulture, text));
			Block_15:
			throw Class_417.xmethod_3101(arg_2, "Could not find member '{0}' on object of type '{1}'".FormatWith(CultureInfo.InvariantCulture, text, arg_3.Name));
		}

		// Token: 0x06001531 RID: 5425 RVA: 0x00064854 File Offset: 0x00062A54
		private bool lmethod_3888(Class_285 arg_0, Class_349 arg_1, bool bool_0)
		{
			if (bool_0)
			{
				return arg_0.vmethod_1885();
			}
			switch ((arg_1 != null) ? arg_1.field_4 : Class_408.Read)
			{
			case Class_408.Read:
				while (arg_0.vmethod_1885())
				{
					if (arg_0.prop_9 != Class_508.Comment)
					{
						return true;
					}
				}
				return false;
			case Class_408.ReadAsInt32:
				arg_0.dmethod_1886();
				break;
			case Class_408.ReadAsBytes:
				arg_0.lmethod_1888();
				break;
			case Class_408.ReadAsString:
				arg_0.kmethod_1887();
				break;
			case Class_408.ReadAsDecimal:
				arg_0.pmethod_1889();
				break;
			case Class_408.ReadAsDateTime:
				arg_0.smethod_1890();
				break;
			case Class_408.ReadAsDateTimeOffset:
				arg_0.xmethod_1891();
				break;
			default:
				throw new ArgumentOutOfRangeException();
			}
			return arg_0.prop_9 != Class_508.None;
		}

		// Token: 0x06001532 RID: 5426 RVA: 0x0006491C File Offset: 0x00062B1C
		public object pmethod_3889(Class_285 arg_0, Class_464 arg_1, Class_454 arg_2, Class_454 arg_3, string str_0, out bool arg_4)
		{
			object obj = null;
			if (arg_1.prop_7 != null)
			{
				if (arg_1.prop_4.Count > 0)
				{
					arg_4 = true;
					return this.vmethod_3885(arg_0, arg_1, arg_2, arg_1.prop_7, str_0);
				}
				obj = arg_1.prop_7(new object[0]);
			}
			else if (arg_1.prop_15 != null && (!arg_1.prop_16 || this.field_3.field_8 == Class_312.AllowNonPublicDefaultConstructor || arg_1.prop_8 == null))
			{
				obj = arg_1.prop_15();
			}
			else if (arg_1.prop_8 != null)
			{
				arg_4 = true;
				return this.vmethod_3885(arg_0, arg_1, arg_2, arg_1.prop_8, str_0);
			}
			if (obj != null)
			{
				arg_4 = false;
				return obj;
			}
			if (!arg_1.field_8)
			{
				throw Class_417.xmethod_3101(arg_0, "Could not create an instance of type {0}. Type is an interface or abstract class and cannot be instantiated.".FormatWith(CultureInfo.InvariantCulture, arg_1.prop_0));
			}
			throw Class_417.xmethod_3101(arg_0, "Unable to find a constructor to use for type {0}. A class should either have a default constructor, one constructor with arguments or a constructor marked with the JsonConstructor attribute.".FormatWith(CultureInfo.InvariantCulture, arg_1.prop_0));
		}

		// Token: 0x06001533 RID: 5427 RVA: 0x00064A28 File Offset: 0x00062C28
		private object smethod_3890(object obje_0, Class_285 arg_0, Class_464 arg_1, Class_454 arg_2, string str_0)
		{
			this.dmethod_3876(arg_0, arg_1, obje_0);
			Dictionary<Class_454, Class_466.NClass_0> dictionary;
			if (!arg_1.prop_11 && !this.tmethod_3872(this.field_3.field_7, Class_377.Populate))
			{
				dictionary = null;
			}
			else
			{
				IEnumerable<Class_454> source = arg_1.prop_2;
				if (Class_466.field_5 == null)
				{
					Class_466.field_5 = new Func<Class_454, Class_454>(Class_466.smethod_3900);
				}
				Func<Class_454, Class_454> keySelector = Class_466.field_5;
				if (Class_466.field_6 == null)
				{
					Class_466.field_6 = new Func<Class_454, Class_466.NClass_0>(Class_466.xmethod_3901);
				}
				dictionary = source.ToDictionary(keySelector, Class_466.field_6);
			}
			Dictionary<Class_454, Class_466.NClass_0> arg_3 = dictionary;
			if (str_0 != null)
			{
				this.xmethod_3871(arg_0, str_0, obje_0);
			}
			int sayıInt_ = arg_0.prop_12;
			bool flag = false;
			for (;;)
			{
				Class_508 class_ = arg_0.prop_9;
				switch (class_)
				{
				case Class_508.PropertyName:
				{
					string text = arg_0.prop_10.ToString();
					if (!this.xmethod_3891(arg_0, text))
					{
						try
						{
							Class_454 class_2 = arg_1.prop_2.cmethod_3704(text);
							if (class_2 == null)
							{
								if (this.field_4 != null && this.field_4.prop_0 >= TraceLevel.Verbose)
								{
									this.field_4.gmethod_2303(TraceLevel.Verbose, Class_326.FormatMessage(arg_0 as Class_353, arg_0.prop_13, "Could not find member '{0}' on {1}".FormatWith(CultureInfo.InvariantCulture, text, arg_1.prop_0)), null);
								}
								if (this.field_3.field_4 == Class_456.Error)
								{
									throw Class_417.xmethod_3101(arg_0, "Could not find member '{0}' on object of type '{1}'".FormatWith(CultureInfo.InvariantCulture, text, arg_1.prop_0.Name));
								}
								if (!arg_0.vmethod_1885())
								{
									break;
								}
								this.tmethod_3892(arg_1, arg_2, arg_0, text, obje_0);
								break;
							}
							else
							{
								if (class_2.prop_0 == null)
								{
									class_2.prop_0 = this.tmethod_3852(class_2.prop_7);
								}
								Class_299 class_3 = this.pmethod_3859(class_2.prop_0, class_2.prop_9, arg_1, arg_2);
								if (!this.lmethod_3888(arg_0, class_2.prop_0, class_3 != null))
								{
									throw Class_417.xmethod_3101(arg_0, "Unexpected end when setting {0}'s value.".FormatWith(CultureInfo.InvariantCulture, text));
								}
								this.cmethod_3894(arg_0, class_2, arg_3);
								if (!this.pmethod_3869(class_2, class_3, arg_1, arg_2, arg_0, obje_0))
								{
									this.tmethod_3892(arg_1, arg_2, arg_0, text, obje_0);
								}
								break;
							}
						}
						catch (Exception arg_4)
						{
							if (base.smethod_3850(obje_0, arg_1, text, arg_0 as Class_353, arg_0.prop_13, arg_4))
							{
								this.vmethod_3895(arg_0, true, sayıInt_);
								break;
							}
							throw;
						}
						goto IL_263;
					}
					break;
				}
				case Class_508.Comment:
					break;
				default:
					if (class_ != Class_508.EndObject)
					{
						goto Block_7;
					}
					goto IL_263;
				}
				IL_286:
				if (flag || !arg_0.vmethod_1885())
				{
					goto IL_297;
				}
				continue;
				IL_263:
				flag = true;
				goto IL_286;
			}
			Block_7:
			throw Class_417.xmethod_3101(arg_0, "Unexpected token when deserializing object: " + arg_0.prop_9);
			IL_297:
			if (!flag)
			{
				this.smethod_3880(arg_0, arg_1, obje_0, "Unexpected end when deserializing object.");
			}
			this.gmethod_3893(obje_0, arg_0, arg_1, sayıInt_, arg_3);
			this.kmethod_3877(arg_0, arg_1, obje_0);
			return obje_0;
		}

		// Token: 0x06001534 RID: 5428 RVA: 0x00064D14 File Offset: 0x00062F14
		private bool xmethod_3891(Class_285 arg_0, string str_0)
		{
			if (this.field_3.prop_12 == Class_343.ReadAhead && str_0 != null && (str_0 == "$id" || str_0 == "$ref" || str_0 == "$type" || str_0 == "$values"))
			{
				arg_0.smethod_1900();
				return true;
			}
			return false;
		}

		// Token: 0x06001535 RID: 5429 RVA: 0x00064D84 File Offset: 0x00062F84
		private void tmethod_3892(Class_464 arg_0, Class_454 arg_1, Class_285 arg_2, string str_0, object obje_0)
		{
			if (arg_0.prop_9 != null)
			{
				try
				{
					object value = this.kmethod_3857(arg_2, null, null, null, arg_0, arg_1, null);
					arg_0.prop_9(obje_0, str_0, value);
					return;
				}
				catch (Exception arg_3)
				{
					throw Class_417.tmethod_3102(arg_2, "Error setting value in extension data for type '{0}'.".FormatWith(CultureInfo.InvariantCulture, arg_0.prop_0), arg_3);
				}
			}
			arg_2.smethod_1900();
		}

		// Token: 0x06001536 RID: 5430 RVA: 0x00064DF4 File Offset: 0x00062FF4
		private void gmethod_3893(object obje_0, Class_285 arg_0, Class_464 arg_1, int sayıInt_0, Dictionary<Class_454, Class_466.NClass_0> arg_2)
		{
			if (arg_2 != null)
			{
				foreach (KeyValuePair<Class_454, Class_466.NClass_0> keyValuePair in arg_2)
				{
					Class_454 key = keyValuePair.Key;
					Class_466.NClass_0 value = keyValuePair.Value;
					if (value != Class_466.NClass_0.field_6)
					{
						if (value != Class_466.NClass_0.field_7)
						{
							continue;
						}
					}
					try
					{
						Class_364 class_ = key.field_0 ?? (arg_1.prop_1 ?? Class_364.Default);
						switch (value)
						{
						case Class_466.NClass_0.field_6:
							if (class_ == Class_364.AllowNull || class_ == Class_364.Always)
							{
								throw Class_417.xmethod_3101(arg_0, "Required property '{0}' not found in JSON.".FormatWith(CultureInfo.InvariantCulture, key.prop_1));
							}
							if (key.prop_0 == null)
							{
								key.prop_0 = this.tmethod_3852(key.prop_7);
							}
							if (this.tmethod_3872(key.prop_18.GetValueOrDefault(this.field_3.field_7), Class_377.Populate) && key.prop_12 && !key.prop_10)
							{
								key.prop_5.lmethod_2308(obje_0, this.lmethod_3868(arg_0, key.xmethod_3671(), CultureInfo.InvariantCulture, key.prop_0, key.prop_7));
							}
							break;
						case Class_466.NClass_0.field_7:
							if (class_ == Class_364.Always)
							{
								throw Class_417.xmethod_3101(arg_0, "Required property '{0}' expects a value but got null.".FormatWith(CultureInfo.InvariantCulture, key.prop_1));
							}
							break;
						}
					}
					catch (Exception arg_3)
					{
						if (!base.smethod_3850(obje_0, arg_1, key.prop_1, arg_0 as Class_353, arg_0.prop_13, arg_3))
						{
							throw;
						}
						this.vmethod_3895(arg_0, true, sayıInt_0);
					}
				}
			}
		}

		// Token: 0x06001537 RID: 5431 RVA: 0x00065000 File Offset: 0x00063200
		private void cmethod_3894(Class_285 arg_0, Class_454 arg_1, Dictionary<Class_454, Class_466.NClass_0> arg_2)
		{
			if (arg_1 != null && arg_2 != null)
			{
				arg_2[arg_1] = ((arg_0.prop_9 == Class_508.Null || arg_0.prop_9 == Class_508.Undefined) ? Class_466.NClass_0.field_7 : Class_466.NClass_0.field_8);
			}
		}

		// Token: 0x06001538 RID: 5432 RVA: 0x00065036 File Offset: 0x00063236
		private void vmethod_3895(Class_285 arg_0, bool bool_0, int sayıInt_0)
		{
			base.pmethod_3849();
			if (bool_0)
			{
				arg_0.smethod_1900();
				while (arg_0.prop_12 > sayıInt_0 + 1)
				{
					if (!arg_0.vmethod_1885())
					{
						return;
					}
				}
			}
		}

		// Token: 0x06001539 RID: 5433 RVA: 0x0004FB80 File Offset: 0x0004DD80
		[CompilerGenerated]
		private static Class_454 dmethod_3896(Class_454 arg_0)
		{
			return arg_0;
		}

		// Token: 0x0600153A RID: 5434 RVA: 0x00018464 File Offset: 0x00016664
		[CompilerGenerated]
		private static Class_466.NClass_0 kmethod_3897(Class_454 arg_0)
		{
			return Class_466.NClass_0.field_6;
		}

		// Token: 0x0600153B RID: 5435 RVA: 0x00065066 File Offset: 0x00063266
		[CompilerGenerated]
		private static string lmethod_3898(Class_454 arg_0)
		{
			return arg_0.prop_1;
		}

		// Token: 0x0600153C RID: 5436 RVA: 0x00065066 File Offset: 0x00063266
		[CompilerGenerated]
		private static string pmethod_3899(Class_454 arg_0)
		{
			return arg_0.prop_1;
		}

		// Token: 0x0600153D RID: 5437 RVA: 0x0004FB80 File Offset: 0x0004DD80
		[CompilerGenerated]
		private static Class_454 smethod_3900(Class_454 arg_0)
		{
			return arg_0;
		}

		// Token: 0x0600153E RID: 5438 RVA: 0x00018464 File Offset: 0x00016664
		[CompilerGenerated]
		private static Class_466.NClass_0 xmethod_3901(Class_454 arg_0)
		{
			return Class_466.NClass_0.field_6;
		}

		// Token: 0x04000B41 RID: 2881
		private Class_468 field_0;

		// Token: 0x04000B42 RID: 2882
		[CompilerGenerated]
		private static Func<Class_454, Class_454> field_1;

		// Token: 0x04000B43 RID: 2883
		[CompilerGenerated]
		private static Func<Class_454, Class_466.NClass_0> field_2;

		// Token: 0x04000B44 RID: 2884
		[CompilerGenerated]
		private new static Func<Class_454, string> field_3;

		// Token: 0x04000B45 RID: 2885
		[CompilerGenerated]
		private new static Func<Class_454, string> field_4;

		// Token: 0x04000B46 RID: 2886
		[CompilerGenerated]
		private static Func<Class_454, Class_454> field_5;

		// Token: 0x04000B47 RID: 2887
		[CompilerGenerated]
		private static Func<Class_454, Class_466.NClass_0> field_6;

		// Token: 0x0200026E RID: 622
		internal enum NClass_0
		{
			// Token: 0x04000B49 RID: 2889
			field_6,
			// Token: 0x04000B4A RID: 2890
			field_7,
			// Token: 0x04000B4B RID: 2891
			field_8
		}

		// Token: 0x0200026F RID: 623
		[CompilerGenerated]
		private sealed class NClass_1
		{
			// Token: 0x0600153F RID: 5439 RVA: 0x0000237C File Offset: 0x0000057C
			public void nmethod_0()
			{
				base..ctor();
			}

			// Token: 0x06001540 RID: 5440 RVA: 0x0006506E File Offset: 0x0006326E
			public bool nmethod_1(Class_454 arg_0)
			{
				return arg_0.prop_1 == this.field_9.prop_1;
			}

			// Token: 0x04000B4C RID: 2892
			public Class_454 field_9;
		}
	}
}
