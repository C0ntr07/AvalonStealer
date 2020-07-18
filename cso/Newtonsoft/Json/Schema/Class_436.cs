using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Schema
{
	// Token: 0x02000246 RID: 582
	internal class Class_436
	{
		// Token: 0x06001381 RID: 4993 RVA: 0x0005BA5D File Offset: 0x00059C5D
		public Class_436(Class_296 arg_0, Class_435 arg_1)
		{
			Class_517.ArgumentNotNull(arg_0, "writer");
			this.field_0 = arg_0;
			this.field_1 = arg_1;
		}

		// Token: 0x06001382 RID: 4994 RVA: 0x0005BA80 File Offset: 0x00059C80
		private void tmethod_3532(Class_459 arg_0)
		{
			if (arg_0.prop_0 != null && this.field_1.xmethod_3531(arg_0.prop_0) != null)
			{
				this.field_0.kmethod_2007();
				this.field_0.gmethod_2013("$ref");
				this.field_0.kmethod_2037(arg_0.prop_0);
				this.field_0.lmethod_2008();
				return;
			}
			this.gmethod_3533(arg_0);
		}

		// Token: 0x06001383 RID: 4995 RVA: 0x0005BAF0 File Offset: 0x00059CF0
		public void gmethod_3533(Class_459 arg_0)
		{
			Class_517.ArgumentNotNull(arg_0, "schema");
			if (!this.field_1.prop_0.Contains(arg_0))
			{
				this.field_1.prop_0.Add(arg_0);
			}
			this.field_0.kmethod_2007();
			this.kmethod_3537(this.field_0, "id", arg_0.prop_0);
			this.kmethod_3537(this.field_0, "title", arg_0.prop_1);
			this.kmethod_3537(this.field_0, "description", arg_0.prop_6);
			this.kmethod_3537(this.field_0, "required", arg_0.prop_2);
			this.kmethod_3537(this.field_0, "readonly", arg_0.prop_3);
			this.kmethod_3537(this.field_0, "hidden", arg_0.prop_4);
			this.kmethod_3537(this.field_0, "transient", arg_0.prop_5);
			if (arg_0.prop_7 != null)
			{
				this.dmethod_3536("type", this.field_0, arg_0.prop_7.Value);
			}
			if (!arg_0.prop_26)
			{
				this.field_0.gmethod_2013("additionalProperties");
				this.field_0.cmethod_2044(arg_0.prop_26);
			}
			else if (arg_0.prop_24 != null)
			{
				this.field_0.gmethod_2013("additionalProperties");
				this.tmethod_3532(arg_0.prop_24);
			}
			if (!arg_0.prop_21)
			{
				this.field_0.gmethod_2013("additionalItems");
				this.field_0.cmethod_2044(arg_0.prop_21);
			}
			else if (arg_0.prop_20 != null)
			{
				this.field_0.gmethod_2013("additionalItems");
				this.tmethod_3532(arg_0.prop_20);
			}
			this.cmethod_3534(this.field_0, "properties", arg_0.prop_23);
			this.cmethod_3534(this.field_0, "patternProperties", arg_0.prop_25);
			this.vmethod_3535(arg_0);
			this.kmethod_3537(this.field_0, "minimum", arg_0.prop_12);
			this.kmethod_3537(this.field_0, "maximum", arg_0.prop_13);
			this.kmethod_3537(this.field_0, "exclusiveMinimum", arg_0.prop_14);
			this.kmethod_3537(this.field_0, "exclusiveMaximum", arg_0.prop_15);
			this.kmethod_3537(this.field_0, "minLength", arg_0.prop_9);
			this.kmethod_3537(this.field_0, "maxLength", arg_0.prop_10);
			this.kmethod_3537(this.field_0, "minItems", arg_0.prop_16);
			this.kmethod_3537(this.field_0, "maxItems", arg_0.prop_17);
			this.kmethod_3537(this.field_0, "divisibleBy", arg_0.prop_11);
			this.kmethod_3537(this.field_0, "format", arg_0.prop_32);
			this.kmethod_3537(this.field_0, "pattern", arg_0.prop_8);
			if (arg_0.prop_28 != null)
			{
				this.field_0.gmethod_2013("enum");
				this.field_0.pmethod_2009();
				foreach (Class_361 class_ in arg_0.prop_28)
				{
					class_.cmethod_2474(this.field_0, new Class_299[0]);
				}
				this.field_0.smethod_2010();
			}
			if (arg_0.prop_30 != null)
			{
				this.field_0.gmethod_2013("default");
				arg_0.prop_30.cmethod_2474(this.field_0, new Class_299[0]);
			}
			if (arg_0.prop_29 != null)
			{
				this.dmethod_3536("disallow", this.field_0, arg_0.prop_29.Value);
			}
			if (arg_0.prop_31 != null && arg_0.prop_31.Count > 0)
			{
				this.field_0.gmethod_2013("extends");
				if (arg_0.prop_31.Count == 1)
				{
					this.tmethod_3532(arg_0.prop_31[0]);
				}
				else
				{
					this.field_0.pmethod_2009();
					foreach (Class_459 arg_ in arg_0.prop_31)
					{
						this.tmethod_3532(arg_);
					}
					this.field_0.smethod_2010();
				}
			}
			this.field_0.lmethod_2008();
		}

		// Token: 0x06001384 RID: 4996 RVA: 0x0005BFDC File Offset: 0x0005A1DC
		private void cmethod_3534(Class_296 arg_0, string str_0, IDictionary<string, Class_459> arg_1)
		{
			if (arg_1 != null)
			{
				arg_0.gmethod_2013(str_0);
				arg_0.kmethod_2007();
				foreach (KeyValuePair<string, Class_459> keyValuePair in arg_1)
				{
					arg_0.gmethod_2013(keyValuePair.Key);
					this.tmethod_3532(keyValuePair.Value);
				}
				arg_0.lmethod_2008();
			}
		}

		// Token: 0x06001385 RID: 4997 RVA: 0x0005C05C File Offset: 0x0005A25C
		private void vmethod_3535(Class_459 arg_0)
		{
			if (arg_0.prop_18 == null && !arg_0.prop_19)
			{
				return;
			}
			this.field_0.gmethod_2013("items");
			if (arg_0.prop_19)
			{
				this.field_0.pmethod_2009();
				if (arg_0.prop_18 != null)
				{
					foreach (Class_459 arg_ in arg_0.prop_18)
					{
						this.tmethod_3532(arg_);
					}
				}
				this.field_0.smethod_2010();
				return;
			}
			if (arg_0.prop_18 != null && arg_0.prop_18.Count > 0)
			{
				this.tmethod_3532(arg_0.prop_18[0]);
				return;
			}
			this.field_0.kmethod_2007();
			this.field_0.lmethod_2008();
		}

		// Token: 0x06001386 RID: 4998 RVA: 0x0005C14C File Offset: 0x0005A34C
		private void dmethod_3536(string str_0, Class_296 arg_0, Class_463 arg_1)
		{
			IList<Class_463> list;
			if (Enum.IsDefined(typeof(Class_463), arg_1))
			{
				list = new List<Class_463>
				{
					arg_1
				};
			}
			else
			{
				IEnumerable<Class_463> flagsValues = Class_505.GetFlagsValues<Class_463>(arg_1);
				if (Class_436.field_2 == null)
				{
					Class_436.field_2 = new Func<Class_463, bool>(Class_436.lmethod_3538);
				}
				list = flagsValues.Where(Class_436.field_2).ToList<Class_463>();
			}
			if (list.Count == 0)
			{
				return;
			}
			arg_0.gmethod_2013(str_0);
			if (list.Count == 1)
			{
				arg_0.kmethod_2037(Class_460.gmethod_3803(list[0]));
				return;
			}
			arg_0.pmethod_2009();
			foreach (Class_463 arg_2 in list)
			{
				arg_0.kmethod_2037(Class_460.gmethod_3803(arg_2));
			}
			arg_0.smethod_2010();
		}

		// Token: 0x06001387 RID: 4999 RVA: 0x0005C240 File Offset: 0x0005A440
		private void kmethod_3537(Class_296 arg_0, string str_0, object obje_0)
		{
			if (obje_0 != null)
			{
				arg_0.gmethod_2013(str_0);
				arg_0.cmethod_2074(obje_0);
			}
		}

		// Token: 0x06001388 RID: 5000 RVA: 0x0005C256 File Offset: 0x0005A456
		[CompilerGenerated]
		private static bool lmethod_3538(Class_463 arg_0)
		{
			return arg_0 != Class_463.None;
		}

		// Token: 0x04000A59 RID: 2649
		private readonly Class_296 field_0;

		// Token: 0x04000A5A RID: 2650
		private readonly Class_435 field_1;

		// Token: 0x04000A5B RID: 2651
		[CompilerGenerated]
		private static Func<Class_463, bool> field_2;
	}
}
