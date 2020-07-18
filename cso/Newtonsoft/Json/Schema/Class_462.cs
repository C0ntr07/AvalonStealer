using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Schema
{
	// Token: 0x02000266 RID: 614
	public class Class_462
	{
		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x060014CF RID: 5327 RVA: 0x000606A9 File Offset: 0x0005E8A9
		// (set) Token: 0x060014D0 RID: 5328 RVA: 0x000606B1 File Offset: 0x0005E8B1
		public Class_437 prop_0 { get; set; }

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x060014D1 RID: 5329 RVA: 0x000606BA File Offset: 0x0005E8BA
		// (set) Token: 0x060014D2 RID: 5330 RVA: 0x000606D3 File Offset: 0x0005E8D3
		public Class_440 prop_1
		{
			get
			{
				if (this.field_0 == null)
				{
					return Class_441.prop_0;
				}
				return this.field_0;
			}
			set
			{
				this.field_0 = value;
			}
		}

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x060014D3 RID: 5331 RVA: 0x000606DC File Offset: 0x0005E8DC
		private Class_459 prop_2
		{
			get
			{
				return this.field_3;
			}
		}

		// Token: 0x060014D4 RID: 5332 RVA: 0x000606E4 File Offset: 0x0005E8E4
		private void pmethod_3809(Class_462.NClass_0 arg_0)
		{
			this.field_3 = arg_0.nprop_1;
			this.field_2.Add(arg_0);
			this.field_1.prop_0.Add(arg_0.nprop_1);
		}

		// Token: 0x060014D5 RID: 5333 RVA: 0x00060714 File Offset: 0x0005E914
		private Class_462.NClass_0 smethod_3810()
		{
			Class_462.NClass_0 result = this.field_2[this.field_2.Count - 1];
			this.field_2.RemoveAt(this.field_2.Count - 1);
			Class_462.NClass_0 nclass_ = this.field_2.LastOrDefault<Class_462.NClass_0>();
			if (nclass_ != null)
			{
				this.field_3 = nclass_.nprop_1;
			}
			else
			{
				this.field_3 = null;
			}
			return result;
		}

		// Token: 0x060014D6 RID: 5334 RVA: 0x0006077D File Offset: 0x0005E97D
		public Class_459 xmethod_3811(Type arg_0)
		{
			return this.cmethod_3814(arg_0, new Class_435(), false);
		}

		// Token: 0x060014D7 RID: 5335 RVA: 0x0006078C File Offset: 0x0005E98C
		public Class_459 tmethod_3812(Type arg_0, Class_435 arg_1)
		{
			return this.cmethod_3814(arg_0, arg_1, false);
		}

		// Token: 0x060014D8 RID: 5336 RVA: 0x00060797 File Offset: 0x0005E997
		public Class_459 gmethod_3813(Type arg_0, bool bool_0)
		{
			return this.cmethod_3814(arg_0, new Class_435(), bool_0);
		}

		// Token: 0x060014D9 RID: 5337 RVA: 0x000607A6 File Offset: 0x0005E9A6
		public Class_459 cmethod_3814(Type arg_0, Class_435 arg_1, bool bool_0)
		{
			Class_517.ArgumentNotNull(arg_0, "type");
			Class_517.ArgumentNotNull(arg_1, "resolver");
			this.field_1 = arg_1;
			return this.lmethod_3818(arg_0, (!bool_0) ? Class_364.Always : Class_364.Default, false);
		}

		// Token: 0x060014DA RID: 5338 RVA: 0x000607DC File Offset: 0x0005E9DC
		private string vmethod_3815(Type arg_0)
		{
			Class_316 cachedAttribute = Class_470.GetCachedAttribute<Class_316>(arg_0);
			if (cachedAttribute != null && !string.IsNullOrEmpty(cachedAttribute.prop_1))
			{
				return cachedAttribute.prop_1;
			}
			return null;
		}

		// Token: 0x060014DB RID: 5339 RVA: 0x00060810 File Offset: 0x0005EA10
		private string dmethod_3816(Type arg_0)
		{
			Class_316 cachedAttribute = Class_470.GetCachedAttribute<Class_316>(arg_0);
			if (cachedAttribute != null && !string.IsNullOrEmpty(cachedAttribute.prop_2))
			{
				return cachedAttribute.prop_2;
			}
			DescriptionAttribute attribute = Class_514.GetAttribute<DescriptionAttribute>(arg_0);
			if (attribute != null)
			{
				return attribute.Description;
			}
			return null;
		}

		// Token: 0x060014DC RID: 5340 RVA: 0x00060858 File Offset: 0x0005EA58
		private string kmethod_3817(Type arg_0, bool bool_0)
		{
			Class_316 cachedAttribute = Class_470.GetCachedAttribute<Class_316>(arg_0);
			if (cachedAttribute != null && !string.IsNullOrEmpty(cachedAttribute.prop_0))
			{
				return cachedAttribute.prop_0;
			}
			if (bool_0)
			{
				return null;
			}
			switch (this.prop_0)
			{
			case Class_437.UseTypeName:
				return arg_0.FullName;
			case Class_437.UseAssemblyQualifiedName:
				return arg_0.AssemblyQualifiedName;
			default:
				return null;
			}
		}

		// Token: 0x060014DD RID: 5341 RVA: 0x000608BC File Offset: 0x0005EABC
		private Class_459 lmethod_3818(Type arg_0, Class_364 arg_1, bool bool_0)
		{
			Class_462.NClass_1 nclass_ = new Class_462.NClass_1();
			nclass_.field_7 = arg_0;
			Class_517.ArgumentNotNull(nclass_.field_7, "type");
			string text = this.kmethod_3817(nclass_.field_7, false);
			string text2 = this.kmethod_3817(nclass_.field_7, true);
			if (!string.IsNullOrEmpty(text))
			{
				Class_459 class_ = this.field_1.xmethod_3531(text);
				if (class_ != null)
				{
					if (arg_1 != Class_364.Always && !Class_462.gmethod_3823(class_.prop_7, Class_463.Null))
					{
						class_.prop_7 |= Class_463.Null;
					}
					if (bool_0 && class_.prop_2 != true)
					{
						class_.prop_2 = new bool?(true);
					}
					return class_;
				}
			}
			if (this.field_2.Any(new Func<Class_462.NClass_0, bool>(nclass_.nmethod_6)))
			{
				throw new Class_318("Unresolved circular reference for type '{0}'. Explicitly define an Id for the type using a JsonObject/JsonArray attribute or automatically generate a type Id using the UndefinedSchemaIdHandling property.".FormatWith(CultureInfo.InvariantCulture, nclass_.field_7));
			}
			Class_349 class_2 = this.prop_1.tmethod_3542(nclass_.field_7);
			Class_299 class_3;
			if ((class_3 = class_2.prop_3) != null || (class_3 = class_2.prop_4) != null)
			{
				Class_459 class_4 = class_3.vmethod_2135();
				if (class_4 != null)
				{
					return class_4;
				}
			}
			this.pmethod_3809(new Class_462.NClass_0(nclass_.field_7, new Class_459()));
			if (text2 != null)
			{
				this.prop_2.prop_0 = text2;
			}
			if (bool_0)
			{
				this.prop_2.prop_2 = new bool?(true);
			}
			this.prop_2.prop_1 = this.vmethod_3815(nclass_.field_7);
			this.prop_2.prop_6 = this.dmethod_3816(nclass_.field_7);
			if (class_3 != null)
			{
				this.prop_2.prop_7 = new Class_463?(Class_463.Any);
			}
			else
			{
				switch (class_2.field_5)
				{
				case Class_448.Object:
					this.prop_2.prop_7 = new Class_463?(this.pmethod_3819(Class_463.Object, arg_1));
					this.prop_2.prop_0 = this.kmethod_3817(nclass_.field_7, false);
					this.xmethod_3821(nclass_.field_7, (Class_464)class_2);
					goto IL_519;
				case Class_448.Array:
				{
					this.prop_2.prop_7 = new Class_463?(this.pmethod_3819(Class_463.Array, arg_1));
					this.prop_2.prop_0 = this.kmethod_3817(nclass_.field_7, false);
					Class_376 cachedAttribute = Class_470.GetCachedAttribute<Class_376>(nclass_.field_7);
					bool flag = cachedAttribute == null || cachedAttribute.AllowNullItems;
					Type collectionItemType = Class_514.GetCollectionItemType(nclass_.field_7);
					if (collectionItemType != null)
					{
						this.prop_2.prop_18 = new List<Class_459>();
						this.prop_2.prop_18.Add(this.lmethod_3818(collectionItemType, (!flag) ? Class_364.Always : Class_364.Default, false));
						goto IL_519;
					}
					goto IL_519;
				}
				case Class_448.Primitive:
				{
					this.prop_2.prop_7 = new Class_463?(this.cmethod_3824(nclass_.field_7, arg_1));
					if (!(this.prop_2.prop_7 == Class_463.Integer) || !nclass_.field_7.IsEnum || nclass_.field_7.IsDefined(typeof(FlagsAttribute), true))
					{
						goto IL_519;
					}
					this.prop_2.prop_28 = new List<Class_361>();
					IList<Class_506<long>> namesAndValues = Class_505.GetNamesAndValues<long>(nclass_.field_7);
					using (IEnumerator<Class_506<long>> enumerator = namesAndValues.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							Class_506<long> class_5 = enumerator.Current;
							Class_361 item = Class_361.smethod_2560(class_5.Value);
							this.prop_2.prop_28.Add(item);
						}
						goto IL_519;
					}
					break;
				}
				case Class_448.String:
					break;
				case Class_448.Dictionary:
				{
					this.prop_2.prop_7 = new Class_463?(this.pmethod_3819(Class_463.Object, arg_1));
					Type type;
					Type arg_2;
					Class_514.GetDictionaryKeyValueTypes(nclass_.field_7, out type, out arg_2);
					if (!(type != null))
					{
						goto IL_519;
					}
					Class_349 class_6 = this.prop_1.tmethod_3542(type);
					if (class_6.field_5 == Class_448.Primitive)
					{
						this.prop_2.prop_24 = this.lmethod_3818(arg_2, Class_364.Default, false);
						goto IL_519;
					}
					goto IL_519;
				}
				case Class_448.Dynamic:
				case Class_448.Linq:
					this.prop_2.prop_7 = new Class_463?(Class_463.Any);
					goto IL_519;
				case Class_448.Serializable:
					this.prop_2.prop_7 = new Class_463?(this.pmethod_3819(Class_463.Object, arg_1));
					this.prop_2.prop_0 = this.kmethod_3817(nclass_.field_7, false);
					this.tmethod_3822(nclass_.field_7, (Class_367)class_2);
					goto IL_519;
				default:
					throw new Class_318("Unexpected contract type: {0}".FormatWith(CultureInfo.InvariantCulture, class_2));
				}
				Class_463 value = (!Class_514.IsNullable(class_2.prop_0)) ? Class_463.String : this.pmethod_3819(Class_463.String, arg_1);
				this.prop_2.prop_7 = new Class_463?(value);
			}
			IL_519:
			return this.smethod_3810().nprop_1;
		}

		// Token: 0x060014DE RID: 5342 RVA: 0x00060E00 File Offset: 0x0005F000
		private Class_463 pmethod_3819(Class_463 arg_0, Class_364 arg_1)
		{
			if (arg_1 != Class_364.Always)
			{
				return arg_0 | Class_463.Null;
			}
			return arg_0;
		}

		// Token: 0x060014DF RID: 5343 RVA: 0x00043B2F File Offset: 0x00041D2F
		private bool smethod_3820(Class_377 arg_0, Class_377 arg_1)
		{
			return (arg_0 & arg_1) == arg_1;
		}

		// Token: 0x060014E0 RID: 5344 RVA: 0x00060E10 File Offset: 0x0005F010
		private void xmethod_3821(Type arg_0, Class_464 arg_1)
		{
			this.prop_2.prop_23 = new Dictionary<string, Class_459>();
			foreach (Class_454 class_ in arg_1.prop_2)
			{
				if (!class_.prop_10)
				{
					bool flag = class_.prop_17 == Class_457.Ignore || this.smethod_3820(class_.prop_18.GetValueOrDefault(), Class_377.Ignore) || class_.prop_22 != null || class_.prop_23 != null;
					Class_459 class_2 = this.lmethod_3818(class_.prop_7, class_.prop_15, !flag);
					if (class_.prop_14 != null)
					{
						class_2.prop_30 = Class_361.smethod_2560(class_.prop_14);
					}
					this.prop_2.prop_23.Add(class_.prop_1, class_2);
				}
			}
			if (arg_0.IsSealed)
			{
				this.prop_2.prop_26 = false;
			}
		}

		// Token: 0x060014E1 RID: 5345 RVA: 0x00060F44 File Offset: 0x0005F144
		private void tmethod_3822(Type arg_0, Class_367 arg_1)
		{
			this.prop_2.prop_26 = true;
		}

		// Token: 0x060014E2 RID: 5346 RVA: 0x00060F54 File Offset: 0x0005F154
		internal static bool gmethod_3823(Class_463? arg_0, Class_463 arg_1)
		{
			if (arg_0 == null)
			{
				return true;
			}
			bool flag = (arg_0 & arg_1) == arg_1;
			return flag || (arg_1 == Class_463.Integer && (arg_0 & Class_463.Float) == Class_463.Float);
		}

		// Token: 0x060014E3 RID: 5347 RVA: 0x0006101C File Offset: 0x0005F21C
		private Class_463 cmethod_3824(Type arg_0, Class_364 arg_1)
		{
			Class_463 class_ = Class_463.None;
			if (arg_1 != Class_364.Always && Class_514.IsNullable(arg_0))
			{
				class_ = Class_463.Null;
				if (Class_514.IsNullableType(arg_0))
				{
					arg_0 = Nullable.GetUnderlyingType(arg_0);
				}
			}
			Class_496 typeCode = Class_499.GetTypeCode(arg_0);
			switch (typeCode)
			{
			case Class_496.Empty:
			case Class_496.Object:
				return class_ | Class_463.String;
			case Class_496.Char:
				return class_ | Class_463.String;
			case Class_496.Boolean:
				return class_ | Class_463.Boolean;
			case Class_496.SByte:
			case Class_496.Int16:
			case Class_496.UInt16:
			case Class_496.Int32:
			case Class_496.Byte:
			case Class_496.UInt32:
			case Class_496.Int64:
			case Class_496.UInt64:
			case Class_496.BigInteger:
				return class_ | Class_463.Integer;
			case Class_496.Single:
			case Class_496.Double:
			case Class_496.Decimal:
				return class_ | Class_463.Float;
			case Class_496.DateTime:
			case Class_496.DateTimeOffset:
				return class_ | Class_463.String;
			case Class_496.Guid:
			case Class_496.TimeSpan:
			case Class_496.Uri:
			case Class_496.String:
			case Class_496.Bytes:
				return class_ | Class_463.String;
			case Class_496.DBNull:
				return class_ | Class_463.Null;
			}
			throw new Class_318("Unexpected type code '{0}' for type '{1}'.".FormatWith(CultureInfo.InvariantCulture, typeCode, arg_0));
		}

		// Token: 0x04000B1F RID: 2847
		private Class_440 field_0;

		// Token: 0x04000B20 RID: 2848
		private Class_435 field_1;

		// Token: 0x04000B21 RID: 2849
		private readonly IList<Class_462.NClass_0> field_2 = new List<Class_462.NClass_0>();

		// Token: 0x04000B22 RID: 2850
		private Class_459 field_3;

		// Token: 0x04000B23 RID: 2851
		[CompilerGenerated]
		private Class_437 field_4;

		// Token: 0x02000267 RID: 615
		private class NClass_0
		{
			// Token: 0x17000484 RID: 1156
			// (get) Token: 0x060014E5 RID: 5349 RVA: 0x0006115E File Offset: 0x0005F35E
			// (set) Token: 0x060014E6 RID: 5350 RVA: 0x00061166 File Offset: 0x0005F366
			public Type nprop_0 { get; private set; }

			// Token: 0x17000485 RID: 1157
			// (get) Token: 0x060014E7 RID: 5351 RVA: 0x0006116F File Offset: 0x0005F36F
			// (set) Token: 0x060014E8 RID: 5352 RVA: 0x00061177 File Offset: 0x0005F377
			public Class_459 nprop_1 { get; private set; }

			// Token: 0x060014E9 RID: 5353 RVA: 0x00061180 File Offset: 0x0005F380
			public void nmethod_4(Type arg_0, Class_459 arg_1)
			{
				base..ctor();
				Class_517.ArgumentNotNull(arg_0, "type");
				Class_517.ArgumentNotNull(arg_1, "schema");
				this.nprop_0 = arg_0;
				this.nprop_1 = arg_1;
			}

			// Token: 0x04000B24 RID: 2852
			[CompilerGenerated]
			private Type field_5;

			// Token: 0x04000B25 RID: 2853
			[CompilerGenerated]
			private Class_459 field_6;
		}

		// Token: 0x02000268 RID: 616
		[CompilerGenerated]
		private sealed class NClass_1
		{
			// Token: 0x060014EA RID: 5354 RVA: 0x0000237C File Offset: 0x0000057C
			public void nmethod_5()
			{
				base..ctor();
			}

			// Token: 0x060014EB RID: 5355 RVA: 0x000611AC File Offset: 0x0005F3AC
			public bool nmethod_6(Class_462.NClass_0 arg_0)
			{
				return arg_0.nprop_0 == this.field_7;
			}

			// Token: 0x04000B26 RID: 2854
			public Type field_7;
		}
	}
}
