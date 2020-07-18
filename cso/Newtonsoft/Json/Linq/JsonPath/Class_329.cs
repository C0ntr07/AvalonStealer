using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x020001B8 RID: 440
	internal abstract class Class_329
	{
		// Token: 0x06000C74 RID: 3188
		public abstract IEnumerable<Class_361> vmethod_2245(IEnumerable<Class_361> arg_0, bool bool_0);

		// Token: 0x06000C75 RID: 3189 RVA: 0x000448F8 File Offset: 0x00042AF8
		protected static Class_361 dmethod_2246(Class_361 arg_0, bool bool_0, int sayıInt_0)
		{
			Class_424 class_ = arg_0 as Class_424;
			Class_421 class_2 = arg_0 as Class_421;
			if (class_ != null)
			{
				if (class_.prop_9 > sayıInt_0)
				{
					return class_.lmethod_3358(sayıInt_0);
				}
				if (bool_0)
				{
					throw new Class_318("Index {0} outside the bounds of JArray.".FormatWith(CultureInfo.InvariantCulture, sayıInt_0));
				}
				return null;
			}
			else if (class_2 != null)
			{
				if (class_2.prop_9 > sayıInt_0)
				{
					return class_2.cmethod_2464(sayıInt_0);
				}
				if (bool_0)
				{
					throw new Class_318("Index {0} outside the bounds of JConstructor.".FormatWith(CultureInfo.InvariantCulture, sayıInt_0));
				}
				return null;
			}
			else
			{
				if (bool_0)
				{
					throw new Class_318("Index {0} not valid on {1}.".FormatWith(CultureInfo.InvariantCulture, sayıInt_0, arg_0.GetType().Name));
				}
				return null;
			}
		}
	}
}
