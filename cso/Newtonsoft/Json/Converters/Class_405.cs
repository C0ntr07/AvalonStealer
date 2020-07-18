using System;
using System.Xml.Linq;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x02000215 RID: 533
	internal class Class_405 : Class_397
	{
		// Token: 0x1700037D RID: 893
		// (get) Token: 0x06001011 RID: 4113 RVA: 0x000508E1 File Offset: 0x0004EAE1
		private new XAttribute prop_0
		{
			get
			{
				return (XAttribute)base.prop_0;
			}
		}

		// Token: 0x06001012 RID: 4114 RVA: 0x00050540 File Offset: 0x0004E740
		public Class_405(XAttribute arg_0) : base(arg_0)
		{
		}

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x06001013 RID: 4115 RVA: 0x000508EE File Offset: 0x0004EAEE
		// (set) Token: 0x06001014 RID: 4116 RVA: 0x000508FB File Offset: 0x0004EAFB
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

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x06001015 RID: 4117 RVA: 0x00050909 File Offset: 0x0004EB09
		public virtual string prop_2
		{
			get
			{
				return this.prop_0.Name.LocalName;
			}
		}

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x06001016 RID: 4118 RVA: 0x0005091B File Offset: 0x0004EB1B
		public virtual string prop_3
		{
			get
			{
				return this.prop_0.Name.NamespaceName;
			}
		}

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x06001017 RID: 4119 RVA: 0x0005092D File Offset: 0x0004EB2D
		public virtual Class_387 prop_4
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
