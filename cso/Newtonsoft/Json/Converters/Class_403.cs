using System;
using System.Xml.Linq;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x02000213 RID: 531
	internal class Class_403 : Class_397
	{
		// Token: 0x17000377 RID: 887
		// (get) Token: 0x06001007 RID: 4103 RVA: 0x00050860 File Offset: 0x0004EA60
		private new XComment prop_0
		{
			get
			{
				return (XComment)base.prop_0;
			}
		}

		// Token: 0x06001008 RID: 4104 RVA: 0x00050540 File Offset: 0x0004E740
		public Class_403(XComment arg_0) : base(arg_0)
		{
		}

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06001009 RID: 4105 RVA: 0x0005086D File Offset: 0x0004EA6D
		// (set) Token: 0x0600100A RID: 4106 RVA: 0x0005087A File Offset: 0x0004EA7A
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

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x0600100B RID: 4107 RVA: 0x00050888 File Offset: 0x0004EA88
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
