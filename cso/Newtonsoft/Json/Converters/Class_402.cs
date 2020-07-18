using System;
using System.Xml.Linq;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x02000212 RID: 530
	internal class Class_402 : Class_397
	{
		// Token: 0x17000374 RID: 884
		// (get) Token: 0x06001002 RID: 4098 RVA: 0x00050814 File Offset: 0x0004EA14
		private new XText prop_0
		{
			get
			{
				return (XText)base.prop_0;
			}
		}

		// Token: 0x06001003 RID: 4099 RVA: 0x00050540 File Offset: 0x0004E740
		public Class_402(XText arg_0) : base(arg_0)
		{
		}

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x06001004 RID: 4100 RVA: 0x00050821 File Offset: 0x0004EA21
		// (set) Token: 0x06001005 RID: 4101 RVA: 0x0005082E File Offset: 0x0004EA2E
		public virtual string prop_1
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

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x06001006 RID: 4102 RVA: 0x0005083C File Offset: 0x0004EA3C
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
	}
}
