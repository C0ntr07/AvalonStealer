using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x020001BF RID: 447
	internal class Class_333 : Class_329
	{
		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x06000CA5 RID: 3237 RVA: 0x00045596 File Offset: 0x00043796
		// (set) Token: 0x06000CA6 RID: 3238 RVA: 0x0004559E File Offset: 0x0004379E
		public string prop_0 { get; set; }

		// Token: 0x06000CA7 RID: 3239 RVA: 0x000455A8 File Offset: 0x000437A8
		public virtual IEnumerable<Class_361> gmethod_2263(IEnumerable<Class_361> arg_0, bool bool_0)
		{
			foreach (Class_361 class_ in arg_0)
			{
				Class_423 class_2 = class_ as Class_423;
				if (class_2 != null)
				{
					if (this.prop_0 != null)
					{
						Class_361 class_3 = class_2.kmethod_3307(this.prop_0);
						if (class_3 != null)
						{
							yield return class_3;
						}
						else if (bool_0)
						{
							throw new Class_318("Property '{0}' does not exist on JObject.".FormatWith(CultureInfo.InvariantCulture, this.prop_0));
						}
					}
					else
					{
						using (IEnumerator<KeyValuePair<string, Class_361>> enumerator2 = class_2.smethod_3330())
						{
							while (enumerator2.MoveNext())
							{
								KeyValuePair<string, Class_361> keyValuePair = enumerator2.Current;
								KeyValuePair<string, Class_361> keyValuePair2 = keyValuePair;
								yield return keyValuePair2.Value;
							}
						}
					}
				}
				else if (bool_0)
				{
					throw new Class_318("Property '{0}' not valid on {1}.".FormatWith(CultureInfo.InvariantCulture, this.prop_0 ?? "*", class_.GetType().Name));
				}
			}
			yield break;
		}

		// Token: 0x04000810 RID: 2064
		[CompilerGenerated]
		private string field_0;
	}
}
