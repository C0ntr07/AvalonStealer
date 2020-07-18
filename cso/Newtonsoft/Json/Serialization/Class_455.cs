using System;
using System.Collections.ObjectModel;
using System.Globalization;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200025E RID: 606
	public class Class_455 : KeyedCollection<string, Class_454>
	{
		// Token: 0x06001463 RID: 5219 RVA: 0x0005F0CF File Offset: 0x0005D2CF
		public Class_455(Type arg_0) : base(StringComparer.Ordinal)
		{
			Class_517.ArgumentNotNull(arg_0, "type");
			this.field_0 = arg_0;
		}

		// Token: 0x06001464 RID: 5220 RVA: 0x0005F0EE File Offset: 0x0005D2EE
		protected virtual string tmethod_3702(Class_454 arg_0)
		{
			return arg_0.prop_1;
		}

		// Token: 0x06001465 RID: 5221 RVA: 0x0005F0F8 File Offset: 0x0005D2F8
		public void gmethod_3703(Class_454 arg_0)
		{
			if (base.Contains(arg_0.prop_1))
			{
				if (arg_0.prop_10)
				{
					return;
				}
				Class_454 class_ = base[arg_0.prop_1];
				bool flag = true;
				if (class_.prop_10)
				{
					base.Remove(class_);
					flag = false;
				}
				else if (arg_0.prop_2 != null && class_.prop_2 != null)
				{
					if (arg_0.prop_2.IsSubclassOf(class_.prop_2))
					{
						base.Remove(class_);
						flag = false;
					}
					if (class_.prop_2.IsSubclassOf(arg_0.prop_2))
					{
						return;
					}
				}
				if (flag)
				{
					throw new Class_417("A member with the name '{0}' already exists on '{1}'. Use the JsonPropertyAttribute to specify another name.".FormatWith(CultureInfo.InvariantCulture, arg_0.prop_1, this.field_0));
				}
			}
			base.Add(arg_0);
		}

		// Token: 0x06001466 RID: 5222 RVA: 0x0005F1D4 File Offset: 0x0005D3D4
		public Class_454 cmethod_3704(string str_0)
		{
			Class_454 class_ = this.dmethod_3706(str_0, StringComparison.Ordinal);
			if (class_ == null)
			{
				class_ = this.dmethod_3706(str_0, StringComparison.OrdinalIgnoreCase);
			}
			return class_;
		}

		// Token: 0x06001467 RID: 5223 RVA: 0x0005F1FA File Offset: 0x0005D3FA
		private bool vmethod_3705(string str_0, out Class_454 arg_0)
		{
			if (base.Dictionary == null)
			{
				arg_0 = null;
				return false;
			}
			return base.Dictionary.TryGetValue(str_0, out arg_0);
		}

		// Token: 0x06001468 RID: 5224 RVA: 0x0005F21C File Offset: 0x0005D41C
		public Class_454 dmethod_3706(string str_0, StringComparison arg_0)
		{
			if (arg_0 != StringComparison.Ordinal)
			{
				foreach (Class_454 class_ in this)
				{
					if (string.Equals(str_0, class_.prop_1, arg_0))
					{
						return class_;
					}
				}
				return null;
			}
			Class_454 result;
			if (this.vmethod_3705(str_0, out result))
			{
				return result;
			}
			return null;
		}

		// Token: 0x04000AC8 RID: 2760
		private readonly Type field_0;
	}
}
