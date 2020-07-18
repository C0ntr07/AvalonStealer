using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Schema
{
	// Token: 0x02000263 RID: 611
	internal class Class_460
	{
		// Token: 0x060014BA RID: 5306 RVA: 0x0005F657 File Offset: 0x0005D857
		public Class_460(Class_435 arg_0)
		{
			this.field_0 = new List<Class_459>();
			this.field_2 = new Dictionary<string, Class_459>();
			this.field_1 = arg_0;
		}

		// Token: 0x060014BB RID: 5307 RVA: 0x0005F67C File Offset: 0x0005D87C
		private void kmethod_3787(Class_459 arg_0)
		{
			this.field_3 = arg_0;
			this.field_0.Add(arg_0);
			this.field_1.prop_0.Add(arg_0);
			this.field_2.Add(arg_0.prop_33, arg_0);
		}

		// Token: 0x060014BC RID: 5308 RVA: 0x0005F6B4 File Offset: 0x0005D8B4
		private Class_459 lmethod_3788()
		{
			Class_459 result = this.field_3;
			this.field_0.RemoveAt(this.field_0.Count - 1);
			this.field_3 = this.field_0.LastOrDefault<Class_459>();
			return result;
		}

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x060014BD RID: 5309 RVA: 0x0005F6F2 File Offset: 0x0005D8F2
		private Class_459 prop_0
		{
			get
			{
				return this.field_3;
			}
		}

		// Token: 0x060014BE RID: 5310 RVA: 0x0005F6FC File Offset: 0x0005D8FC
		internal Class_459 smethod_3790(Class_285 arg_0)
		{
			Class_361 class_ = Class_361.dmethod_2566(arg_0);
			this.field_4 = (class_ as Class_423);
			Class_459 class_2 = this.gmethod_3793(class_);
			this.tmethod_3792(class_2);
			return class_2;
		}

		// Token: 0x060014BF RID: 5311 RVA: 0x0005F72D File Offset: 0x0005D92D
		private string xmethod_3791(string str_0)
		{
			return Uri.UnescapeDataString(str_0).Replace("~1", "/").Replace("~0", "~");
		}

		// Token: 0x060014C0 RID: 5312 RVA: 0x0005F754 File Offset: 0x0005D954
		private Class_459 tmethod_3792(Class_459 arg_0)
		{
			if (arg_0.prop_35 != null)
			{
				string text = arg_0.prop_35;
				bool flag = text.StartsWith("#", StringComparison.Ordinal);
				if (flag)
				{
					text = this.xmethod_3791(text);
				}
				Class_459 class_ = this.field_1.xmethod_3531(text);
				if (class_ == null)
				{
					if (flag)
					{
						string[] array = arg_0.prop_35.TrimStart(new char[]
						{
							'#'
						}).Split(new char[]
						{
							'/'
						}, StringSplitOptions.RemoveEmptyEntries);
						Class_361 class_2 = this.field_4;
						foreach (string str_ in array)
						{
							string text2 = this.xmethod_3791(str_);
							if (class_2.prop_3 == Class_428.Object)
							{
								class_2 = class_2.cmethod_2464(text2);
							}
							else if (class_2.prop_3 == Class_428.Array || class_2.prop_3 == Class_428.Constructor)
							{
								int num;
								if (int.TryParse(text2, out num) && num >= 0 && num < class_2.Count<Class_361>())
								{
									class_2 = class_2.cmethod_2464(num);
								}
								else
								{
									class_2 = null;
								}
							}
							if (class_2 == null)
							{
								break;
							}
						}
						if (class_2 != null)
						{
							class_ = this.gmethod_3793(class_2);
						}
					}
					if (class_ == null)
					{
						throw new Class_318("Could not resolve schema reference '{0}'.".FormatWith(CultureInfo.InvariantCulture, arg_0.prop_35));
					}
				}
				arg_0 = class_;
			}
			if (arg_0.prop_36)
			{
				return arg_0;
			}
			arg_0.prop_36 = true;
			if (arg_0.prop_31 != null)
			{
				for (int j = 0; j < arg_0.prop_31.Count; j++)
				{
					arg_0.prop_31[j] = this.tmethod_3792(arg_0.prop_31[j]);
				}
			}
			if (arg_0.prop_18 != null)
			{
				for (int k = 0; k < arg_0.prop_18.Count; k++)
				{
					arg_0.prop_18[k] = this.tmethod_3792(arg_0.prop_18[k]);
				}
			}
			if (arg_0.prop_20 != null)
			{
				arg_0.prop_20 = this.tmethod_3792(arg_0.prop_20);
			}
			if (arg_0.prop_25 != null)
			{
				foreach (KeyValuePair<string, Class_459> keyValuePair in arg_0.prop_25.ToList<KeyValuePair<string, Class_459>>())
				{
					arg_0.prop_25[keyValuePair.Key] = this.tmethod_3792(keyValuePair.Value);
				}
			}
			if (arg_0.prop_23 != null)
			{
				foreach (KeyValuePair<string, Class_459> keyValuePair2 in arg_0.prop_23.ToList<KeyValuePair<string, Class_459>>())
				{
					arg_0.prop_23[keyValuePair2.Key] = this.tmethod_3792(keyValuePair2.Value);
				}
			}
			if (arg_0.prop_24 != null)
			{
				arg_0.prop_24 = this.tmethod_3792(arg_0.prop_24);
			}
			return arg_0;
		}

		// Token: 0x060014C1 RID: 5313 RVA: 0x0005FA88 File Offset: 0x0005DC88
		private Class_459 gmethod_3793(Class_361 arg_0)
		{
			Class_423 class_ = arg_0 as Class_423;
			if (class_ == null)
			{
				throw Class_318.xmethod_2221(arg_0, arg_0.prop_7, "Expected object while parsing schema object, got {0}.".FormatWith(CultureInfo.InvariantCulture, arg_0.prop_3));
			}
			Class_361 arg_;
			if (class_.xmethod_3321("$ref", out arg_))
			{
				return new Class_459
				{
					prop_35 = Class_361.lmethod_2508(arg_)
				};
			}
			string text = arg_0.prop_7.Replace(".", "/").Replace("[", "/").Replace("]", string.Empty);
			if (!string.IsNullOrEmpty(text))
			{
				text = "/" + text;
			}
			text = "#" + text;
			Class_459 result;
			if (this.field_2.TryGetValue(text, out result))
			{
				return result;
			}
			this.kmethod_3787(new Class_459
			{
				prop_33 = text
			});
			this.cmethod_3794(class_);
			return this.lmethod_3788();
		}

		// Token: 0x060014C2 RID: 5314 RVA: 0x0005FB80 File Offset: 0x0005DD80
		private void cmethod_3794(Class_423 arg_0)
		{
			using (IEnumerator<KeyValuePair<string, Class_361>> enumerator = arg_0.smethod_3330())
			{
				while (enumerator.MoveNext())
				{
					KeyValuePair<string, Class_361> keyValuePair = enumerator.Current;
					string key;
					switch (key = keyValuePair.Key)
					{
					case "type":
						this.prop_0.prop_7 = this.xmethod_3801(keyValuePair.Value);
						break;
					case "id":
						this.prop_0.prop_0 = Class_361.lmethod_2508(keyValuePair.Value);
						break;
					case "title":
						this.prop_0.prop_1 = Class_361.lmethod_2508(keyValuePair.Value);
						break;
					case "description":
						this.prop_0.prop_6 = Class_361.lmethod_2508(keyValuePair.Value);
						break;
					case "properties":
						this.prop_0.prop_23 = this.pmethod_3799(keyValuePair.Value);
						break;
					case "items":
						this.smethod_3800(keyValuePair.Value);
						break;
					case "additionalProperties":
						this.kmethod_3797(keyValuePair.Value);
						break;
					case "additionalItems":
						this.lmethod_3798(keyValuePair.Value);
						break;
					case "patternProperties":
						this.prop_0.prop_25 = this.pmethod_3799(keyValuePair.Value);
						break;
					case "required":
						this.prop_0.prop_2 = new bool?(Class_361.smethod_2480(keyValuePair.Value));
						break;
					case "requires":
						this.prop_0.prop_27 = Class_361.lmethod_2508(keyValuePair.Value);
						break;
					case "minimum":
						this.prop_0.prop_12 = new double?(Class_361.dmethod_2506(keyValuePair.Value));
						break;
					case "maximum":
						this.prop_0.prop_13 = new double?(Class_361.dmethod_2506(keyValuePair.Value));
						break;
					case "exclusiveMinimum":
						this.prop_0.prop_14 = new bool?(Class_361.smethod_2480(keyValuePair.Value));
						break;
					case "exclusiveMaximum":
						this.prop_0.prop_15 = new bool?(Class_361.smethod_2480(keyValuePair.Value));
						break;
					case "maxLength":
						this.prop_0.prop_10 = new int?(Class_361.pmethod_2489(keyValuePair.Value));
						break;
					case "minLength":
						this.prop_0.prop_9 = new int?(Class_361.pmethod_2489(keyValuePair.Value));
						break;
					case "maxItems":
						this.prop_0.prop_17 = new int?(Class_361.pmethod_2489(keyValuePair.Value));
						break;
					case "minItems":
						this.prop_0.prop_16 = new int?(Class_361.pmethod_2489(keyValuePair.Value));
						break;
					case "divisibleBy":
						this.prop_0.prop_11 = new double?(Class_361.dmethod_2506(keyValuePair.Value));
						break;
					case "disallow":
						this.prop_0.prop_29 = this.xmethod_3801(keyValuePair.Value);
						break;
					case "default":
						this.prop_0.prop_30 = keyValuePair.Value.smethod_2580();
						break;
					case "hidden":
						this.prop_0.prop_4 = new bool?(Class_361.smethod_2480(keyValuePair.Value));
						break;
					case "readonly":
						this.prop_0.prop_3 = new bool?(Class_361.smethod_2480(keyValuePair.Value));
						break;
					case "format":
						this.prop_0.prop_32 = Class_361.lmethod_2508(keyValuePair.Value);
						break;
					case "pattern":
						this.prop_0.prop_8 = Class_361.lmethod_2508(keyValuePair.Value);
						break;
					case "enum":
						this.dmethod_3796(keyValuePair.Value);
						break;
					case "extends":
						this.vmethod_3795(keyValuePair.Value);
						break;
					case "uniqueItems":
						this.prop_0.prop_22 = Class_361.smethod_2480(keyValuePair.Value);
						break;
					}
				}
			}
		}

		// Token: 0x060014C3 RID: 5315 RVA: 0x0006013C File Offset: 0x0005E33C
		private void vmethod_3795(Class_361 arg_0)
		{
			IList<Class_459> list = new List<Class_459>();
			if (arg_0.prop_3 == Class_428.Array)
			{
				using (IEnumerator<Class_361> enumerator = ((IEnumerable<Class_361>)arg_0).GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						Class_361 arg_ = enumerator.Current;
						list.Add(this.gmethod_3793(arg_));
					}
					goto IL_61;
				}
			}
			Class_459 class_ = this.gmethod_3793(arg_0);
			if (class_ != null)
			{
				list.Add(class_);
			}
			IL_61:
			if (list.Count > 0)
			{
				this.prop_0.prop_31 = list;
			}
		}

		// Token: 0x060014C4 RID: 5316 RVA: 0x000601D4 File Offset: 0x0005E3D4
		private void dmethod_3796(Class_361 arg_0)
		{
			if (arg_0.prop_3 != Class_428.Array)
			{
				throw Class_318.xmethod_2221(arg_0, arg_0.prop_7, "Expected Array token while parsing enum values, got {0}.".FormatWith(CultureInfo.InvariantCulture, arg_0.prop_3));
			}
			this.prop_0.prop_28 = new List<Class_361>();
			foreach (Class_361 class_ in ((IEnumerable<Class_361>)arg_0))
			{
				this.prop_0.prop_28.Add(class_.smethod_2580());
			}
		}

		// Token: 0x060014C5 RID: 5317 RVA: 0x00060278 File Offset: 0x0005E478
		private void kmethod_3797(Class_361 arg_0)
		{
			if (arg_0.prop_3 == Class_428.Boolean)
			{
				this.prop_0.prop_26 = Class_361.smethod_2480(arg_0);
				return;
			}
			this.prop_0.prop_24 = this.gmethod_3793(arg_0);
		}

		// Token: 0x060014C6 RID: 5318 RVA: 0x000602AB File Offset: 0x0005E4AB
		private void lmethod_3798(Class_361 arg_0)
		{
			if (arg_0.prop_3 == Class_428.Boolean)
			{
				this.prop_0.prop_21 = Class_361.smethod_2480(arg_0);
				return;
			}
			this.prop_0.prop_20 = this.gmethod_3793(arg_0);
		}

		// Token: 0x060014C7 RID: 5319 RVA: 0x000602E0 File Offset: 0x0005E4E0
		private IDictionary<string, Class_459> pmethod_3799(Class_361 arg_0)
		{
			IDictionary<string, Class_459> dictionary = new Dictionary<string, Class_459>();
			if (arg_0.prop_3 != Class_428.Object)
			{
				throw Class_318.xmethod_2221(arg_0, arg_0.prop_7, "Expected Object token while parsing schema properties, got {0}.".FormatWith(CultureInfo.InvariantCulture, arg_0.prop_3));
			}
			foreach (Class_361 class_ in ((IEnumerable<Class_361>)arg_0))
			{
				Class_427 class_2 = (Class_427)class_;
				if (dictionary.ContainsKey(class_2.prop_1))
				{
					throw new Class_318("Property {0} has already been defined in schema.".FormatWith(CultureInfo.InvariantCulture, class_2.prop_1));
				}
				dictionary.Add(class_2.prop_1, this.gmethod_3793(class_2.prop_2));
			}
			return dictionary;
		}

		// Token: 0x060014C8 RID: 5320 RVA: 0x000603B0 File Offset: 0x0005E5B0
		private void smethod_3800(Class_361 arg_0)
		{
			this.prop_0.prop_18 = new List<Class_459>();
			switch (arg_0.prop_3)
			{
			case Class_428.Object:
				this.prop_0.prop_18.Add(this.gmethod_3793(arg_0));
				this.prop_0.prop_19 = false;
				return;
			case Class_428.Array:
				this.prop_0.prop_19 = true;
				using (IEnumerator<Class_361> enumerator = ((IEnumerable<Class_361>)arg_0).GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						Class_361 arg_ = enumerator.Current;
						this.prop_0.prop_18.Add(this.gmethod_3793(arg_));
					}
					return;
				}
				break;
			}
			throw Class_318.xmethod_2221(arg_0, arg_0.prop_7, "Expected array or JSON schema object, got {0}.".FormatWith(CultureInfo.InvariantCulture, arg_0.prop_3));
		}

		// Token: 0x060014C9 RID: 5321 RVA: 0x00060494 File Offset: 0x0005E694
		private Class_463? xmethod_3801(Class_361 arg_0)
		{
			Class_428 class_ = arg_0.prop_3;
			if (class_ == Class_428.Array)
			{
				Class_463? class_2 = new Class_463?(Class_463.None);
				foreach (Class_361 class_3 in ((IEnumerable<Class_361>)arg_0))
				{
					if (class_3.prop_3 != Class_428.String)
					{
						throw Class_318.xmethod_2221(class_3, class_3.prop_7, "Exception JSON schema type string token, got {0}.".FormatWith(CultureInfo.InvariantCulture, arg_0.prop_3));
					}
					class_2 |= Class_460.tmethod_3802(Class_361.lmethod_2508(class_3));
				}
				return class_2;
			}
			if (class_ != Class_428.String)
			{
				throw Class_318.xmethod_2221(arg_0, arg_0.prop_7, "Expected array or JSON schema type string token, got {0}.".FormatWith(CultureInfo.InvariantCulture, arg_0.prop_3));
			}
			return new Class_463?(Class_460.tmethod_3802(Class_361.lmethod_2508(arg_0)));
		}

		// Token: 0x060014CA RID: 5322 RVA: 0x000605A8 File Offset: 0x0005E7A8
		internal static Class_463 tmethod_3802(string str_0)
		{
			Class_463 result;
			if (!Class_461.JsonSchemaTypeMapping.TryGetValue(str_0, out result))
			{
				throw new Class_318("Invalid JSON schema type: {0}".FormatWith(CultureInfo.InvariantCulture, str_0));
			}
			return result;
		}

		// Token: 0x060014CB RID: 5323 RVA: 0x000605E0 File Offset: 0x0005E7E0
		internal static string gmethod_3803(Class_463 arg_0)
		{
			Class_460.NClass_0 nclass_ = new Class_460.NClass_0();
			nclass_.field_37 = arg_0;
			return Class_461.JsonSchemaTypeMapping.Single(new Func<KeyValuePair<string, Class_463>, bool>(nclass_.nmethod_1)).Key;
		}

		// Token: 0x04000AF8 RID: 2808
		private readonly IList<Class_459> field_0;

		// Token: 0x04000AF9 RID: 2809
		private readonly Class_435 field_1;

		// Token: 0x04000AFA RID: 2810
		private readonly IDictionary<string, Class_459> field_2;

		// Token: 0x04000AFB RID: 2811
		private Class_459 field_3;

		// Token: 0x04000AFC RID: 2812
		private Class_423 field_4;

		// Token: 0x02000264 RID: 612
		[CompilerGenerated]
		private sealed class NClass_0
		{
			// Token: 0x060014CC RID: 5324 RVA: 0x0000237C File Offset: 0x0000057C
			public void nmethod_0()
			{
				base..ctor();
			}

			// Token: 0x060014CD RID: 5325 RVA: 0x00060618 File Offset: 0x0005E818
			public bool nmethod_1(KeyValuePair<string, Class_463> arg_0)
			{
				return arg_0.Value == this.field_37;
			}

			// Token: 0x04000AFD RID: 2813
			public Class_463 field_37;
		}
	}
}
