using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x020001C1 RID: 449
	internal class Class_334 : Class_329
	{
		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x06000CB3 RID: 3251 RVA: 0x00045931 File Offset: 0x00043B31
		// (set) Token: 0x06000CB4 RID: 3252 RVA: 0x00045939 File Offset: 0x00043B39
		public List<string> prop_0 { get; set; }

		// Token: 0x06000CB5 RID: 3253 RVA: 0x00045944 File Offset: 0x00043B44
		public virtual IEnumerable<Class_361> dmethod_2266(IEnumerable<Class_361> arg_0, bool bool_0)
		{
			foreach (Class_361 class_ in arg_0)
			{
				Class_423 class_2 = class_ as Class_423;
				if (class_2 != null)
				{
					foreach (string text in this.prop_0)
					{
						Class_361 class_3 = class_2.kmethod_3307(text);
						if (class_3 != null)
						{
							yield return class_3;
						}
						if (bool_0)
						{
							throw new Class_318("Property '{0}' does not exist on JObject.".FormatWith(CultureInfo.InvariantCulture, text));
						}
					}
				}
				else if (bool_0)
				{
					string format = "Properties {0} not valid on {1}.";
					IFormatProvider invariantCulture = CultureInfo.InvariantCulture;
					string separator = ", ";
					IEnumerable<string> source = this.prop_0;
					if (Class_334.field_1 == null)
					{
						Class_334.field_1 = new Func<string, string>(Class_334.kmethod_2267);
					}
					throw new Class_318(format.FormatWith(invariantCulture, string.Join(separator, source.Select(Class_334.field_1).ToArray<string>()), class_.GetType().Name));
				}
			}
			yield break;
		}

		// Token: 0x06000CB7 RID: 3255 RVA: 0x0004596F File Offset: 0x00043B6F
		[CompilerGenerated]
		private static string kmethod_2267(string str_0)
		{
			return "'" + str_0 + "'";
		}

		// Token: 0x0400081F RID: 2079
		[CompilerGenerated]
		private List<string> field_0;

		// Token: 0x04000820 RID: 2080
		[CompilerGenerated]
		private static Func<string, string> field_1;
	}
}
