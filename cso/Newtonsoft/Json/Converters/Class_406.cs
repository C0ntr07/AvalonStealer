using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x02000216 RID: 534
	internal class Class_406 : Class_400, Class_387, Class_391
	{
		// Token: 0x17000382 RID: 898
		// (get) Token: 0x06001018 RID: 4120 RVA: 0x00050951 File Offset: 0x0004EB51
		private new XElement prop_0
		{
			get
			{
				return (XElement)base.prop_0;
			}
		}

		// Token: 0x06001019 RID: 4121 RVA: 0x0005069B File Offset: 0x0004E89B
		public Class_406(XElement arg_0) : base(arg_0)
		{
		}

		// Token: 0x0600101A RID: 4122 RVA: 0x00050960 File Offset: 0x0004EB60
		public void vmethod_2945(Class_387 arg_0)
		{
			Class_397 class_ = (Class_397)arg_0;
			this.prop_0.Add(class_.prop_0);
		}

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x0600101B RID: 4123 RVA: 0x00050985 File Offset: 0x0004EB85
		public virtual IList<Class_387> prop_1
		{
			get
			{
				IEnumerable<XAttribute> source = this.prop_0.Attributes();
				if (Class_406.field_0 == null)
				{
					Class_406.field_0 = new Func<XAttribute, Class_405>(Class_406.gmethod_2953);
				}
				return source.Select(Class_406.field_0).Cast<Class_387>().ToList<Class_387>();
			}
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x0600101C RID: 4124 RVA: 0x000509C1 File Offset: 0x0004EBC1
		// (set) Token: 0x0600101D RID: 4125 RVA: 0x000509CE File Offset: 0x0004EBCE
		public virtual string prop_2
		{
			get
			{
				return this.prop_0.Value;
			}
			set
			{
				this.prop_0.Value = value;
			}
		}

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x0600101E RID: 4126 RVA: 0x000509DC File Offset: 0x0004EBDC
		public virtual string prop_3
		{
			get
			{
				return this.prop_0.Name.LocalName;
			}
		}

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x0600101F RID: 4127 RVA: 0x000509EE File Offset: 0x0004EBEE
		public virtual string prop_4
		{
			get
			{
				return this.prop_0.Name.NamespaceName;
			}
		}

		// Token: 0x06001020 RID: 4128 RVA: 0x00050A00 File Offset: 0x0004EC00
		public string xmethod_2951(string str_0)
		{
			return this.prop_0.GetPrefixOfNamespace(str_0);
		}

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x06001021 RID: 4129 RVA: 0x00050A13 File Offset: 0x0004EC13
		public new bool prop_5
		{
			get
			{
				return this.prop_0.IsEmpty;
			}
		}

		// Token: 0x06001022 RID: 4130 RVA: 0x00050A20 File Offset: 0x0004EC20
		[CompilerGenerated]
		private static Class_405 gmethod_2953(XAttribute arg_0)
		{
			return new Class_405(arg_0);
		}

		// Token: 0x0400096A RID: 2410
		[CompilerGenerated]
		private static Func<XAttribute, Class_405> field_0;
	}
}
