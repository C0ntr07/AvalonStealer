using System;
using System.Globalization;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x020001F5 RID: 501
	internal class Class_374 : Class_373
	{
		// Token: 0x06000EDA RID: 3802 RVA: 0x0004D9C0 File Offset: 0x0004BBC0
		private Class_495<string, object> vmethod_2685(object obje_0)
		{
			Class_465 class_;
			if (obje_0 is Class_465)
			{
				class_ = (Class_465)obje_0;
			}
			else
			{
				if (!(obje_0 is Class_468))
				{
					throw new Class_318("The DefaultReferenceResolver can only be used internally.");
				}
				class_ = ((Class_468)obje_0).cmethod_3994();
			}
			return class_.prop_0;
		}

		// Token: 0x06000EDB RID: 3803 RVA: 0x0004DA14 File Offset: 0x0004BC14
		public object dmethod_2686(object obje_0, string str_0)
		{
			object result;
			this.vmethod_2685(obje_0).TryGetByFirst(str_0, ref result);
			return result;
		}

		// Token: 0x06000EDC RID: 3804 RVA: 0x0004DA34 File Offset: 0x0004BC34
		public string kmethod_2687(object obje_0, object obje_1)
		{
			Class_495<string, object> class_ = this.vmethod_2685(obje_0);
			string text;
			if (!class_.TryGetBySecond(obje_1, ref text))
			{
				this.field_0++;
				text = this.field_0.ToString(CultureInfo.InvariantCulture);
				class_.Set(text, obje_1);
			}
			return text;
		}

		// Token: 0x06000EDD RID: 3805 RVA: 0x0004DA7F File Offset: 0x0004BC7F
		public void lmethod_2688(object obje_0, string str_0, object obje_1)
		{
			this.vmethod_2685(obje_0).Set(str_0, obje_1);
		}

		// Token: 0x06000EDE RID: 3806 RVA: 0x0004DA90 File Offset: 0x0004BC90
		public bool pmethod_2689(object obje_0, object obje_1)
		{
			string text;
			return this.vmethod_2685(obje_0).TryGetBySecond(obje_1, ref text);
		}

		// Token: 0x040008F7 RID: 2295
		private int field_0;
	}
}
