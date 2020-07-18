using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x02000210 RID: 528
	internal class Class_400 : Class_397
	{
		// Token: 0x1700036E RID: 878
		// (get) Token: 0x06000FEB RID: 4075 RVA: 0x00050533 File Offset: 0x0004E733
		private new XContainer prop_0
		{
			get
			{
				return (XContainer)base.prop_0;
			}
		}

		// Token: 0x06000FEC RID: 4076 RVA: 0x00050540 File Offset: 0x0004E740
		public Class_400(XContainer arg_0) : base(arg_0)
		{
		}

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x06000FED RID: 4077 RVA: 0x00050549 File Offset: 0x0004E749
		public virtual IList<Class_387> prop_1
		{
			get
			{
				if (this.field_0 == null)
				{
					this.field_0 = this.prop_0.Nodes().Select(new Func<XNode, Class_387>(Class_400.lmethod_2908)).ToList<Class_387>();
				}
				return this.field_0;
			}
		}

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x06000FEE RID: 4078 RVA: 0x00050583 File Offset: 0x0004E783
		public virtual Class_387 prop_2
		{
			get
			{
				if (this.prop_0.Parent == null)
				{
					return null;
				}
				return Class_400.lmethod_2908(this.prop_0.Parent);
			}
		}

		// Token: 0x06000FEF RID: 4079 RVA: 0x000505A8 File Offset: 0x0004E7A8
		internal static Class_387 lmethod_2908(XObject arg_0)
		{
			if (arg_0 is XDocument)
			{
				return new Class_401((XDocument)arg_0);
			}
			if (arg_0 is XElement)
			{
				return new Class_406((XElement)arg_0);
			}
			if (arg_0 is XContainer)
			{
				return new Class_400((XContainer)arg_0);
			}
			if (arg_0 is XProcessingInstruction)
			{
				return new Class_404((XProcessingInstruction)arg_0);
			}
			if (arg_0 is XText)
			{
				return new Class_402((XText)arg_0);
			}
			if (arg_0 is XComment)
			{
				return new Class_403((XComment)arg_0);
			}
			if (arg_0 is XAttribute)
			{
				return new Class_405((XAttribute)arg_0);
			}
			if (arg_0 is XDocumentType)
			{
				return new Class_399((XDocumentType)arg_0);
			}
			return new Class_397(arg_0);
		}

		// Token: 0x06000FF0 RID: 4080 RVA: 0x00050673 File Offset: 0x0004E873
		public virtual Class_387 pmethod_2909(Class_387 arg_0)
		{
			this.prop_0.Add(arg_0.prop_7);
			this.field_0 = null;
			return arg_0;
		}

		// Token: 0x04000969 RID: 2409
		private IList<Class_387> field_0;
	}
}
