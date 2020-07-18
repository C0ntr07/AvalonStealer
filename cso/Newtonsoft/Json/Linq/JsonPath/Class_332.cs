using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x020001BD RID: 445
	internal class Class_332 : Class_329
	{
		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x06000C93 RID: 3219 RVA: 0x00044FE0 File Offset: 0x000431E0
		// (set) Token: 0x06000C94 RID: 3220 RVA: 0x00044FE8 File Offset: 0x000431E8
		public int? prop_0 { get; set; }

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x06000C95 RID: 3221 RVA: 0x00044FF1 File Offset: 0x000431F1
		// (set) Token: 0x06000C96 RID: 3222 RVA: 0x00044FF9 File Offset: 0x000431F9
		public int? prop_1 { get; set; }

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x06000C97 RID: 3223 RVA: 0x00045002 File Offset: 0x00043202
		// (set) Token: 0x06000C98 RID: 3224 RVA: 0x0004500A File Offset: 0x0004320A
		public int? prop_2 { get; set; }

		// Token: 0x06000C99 RID: 3225 RVA: 0x00045014 File Offset: 0x00043214
		public virtual IEnumerable<Class_361> pmethod_2259(IEnumerable<Class_361> arg_0, bool bool_0)
		{
			if (this.prop_2 == 0)
			{
				throw new Class_318("Step cannot be zero.");
			}
			foreach (Class_361 class_ in arg_0)
			{
				Class_424 class_2 = class_ as Class_424;
				if (class_2 != null)
				{
					int num = this.prop_2 ?? 1;
					int num2 = this.prop_0 ?? ((num > 0) ? 0 : (class_2.prop_9 - 1));
					int num3 = this.prop_1 ?? ((num > 0) ? class_2.prop_9 : -1);
					if (this.prop_0 < 0)
					{
						num2 = class_2.prop_9 + num2;
					}
					if (this.prop_1 < 0)
					{
						num3 = class_2.prop_9 + num3;
					}
					num2 = Math.Max(num2, (num > 0) ? 0 : int.MinValue);
					num2 = Math.Min(num2, (num > 0) ? class_2.prop_9 : (class_2.prop_9 - 1));
					num3 = Math.Max(num3, -1);
					num3 = Math.Min(num3, class_2.prop_9);
					bool bool_ = num > 0;
					if (this.smethod_2260(num2, num3, bool_))
					{
						int num4 = num2;
						while (this.smethod_2260(num4, num3, bool_))
						{
							yield return class_2.lmethod_3358(num4);
							num4 += num;
						}
					}
					else if (bool_0)
					{
						throw new Class_318("Array slice of {0} to {1} returned no results.".FormatWith(CultureInfo.InvariantCulture, (this.prop_0 != null) ? this.prop_0.Value.ToString(CultureInfo.InvariantCulture) : "*", (this.prop_1 != null) ? this.prop_1.Value.ToString(CultureInfo.InvariantCulture) : "*"));
					}
				}
				else if (bool_0)
				{
					throw new Class_318("Array slice is not valid on {0}.".FormatWith(CultureInfo.InvariantCulture, class_.GetType().Name));
				}
			}
			yield break;
		}

		// Token: 0x06000C9A RID: 3226 RVA: 0x0004503F File Offset: 0x0004323F
		private bool smethod_2260(int sayıInt_0, int sayıInt_1, bool bool_0)
		{
			if (bool_0)
			{
				return sayıInt_0 < sayıInt_1;
			}
			return sayıInt_0 > sayıInt_1;
		}

		// Token: 0x040007FD RID: 2045
		[CompilerGenerated]
		private int? field_0;

		// Token: 0x040007FE RID: 2046
		[CompilerGenerated]
		private int? field_1;

		// Token: 0x040007FF RID: 2047
		[CompilerGenerated]
		private int? field_2;
	}
}
