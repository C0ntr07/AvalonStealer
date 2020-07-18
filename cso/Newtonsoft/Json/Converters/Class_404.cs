using System;
using System.Xml.Linq;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x02000214 RID: 532
	internal class Class_404 : Class_397
	{
		// Token: 0x1700037A RID: 890
		// (get) Token: 0x0600100C RID: 4108 RVA: 0x000508AC File Offset: 0x0004EAAC
		private new XProcessingInstruction prop_0
		{
			get
			{
				return (XProcessingInstruction)base.prop_0;
			}
		}

		// Token: 0x0600100D RID: 4109 RVA: 0x00050540 File Offset: 0x0004E740
		public Class_404(XProcessingInstruction arg_0) : base(arg_0)
		{
		}

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x0600100E RID: 4110 RVA: 0x000508B9 File Offset: 0x0004EAB9
		public virtual string prop_1
		{
			get
			{
				return this.prop_0.Target;
			}
		}

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x0600100F RID: 4111 RVA: 0x000508C6 File Offset: 0x0004EAC6
		// (set) Token: 0x06001010 RID: 4112 RVA: 0x000508D3 File Offset: 0x0004EAD3
		public virtual string prop_2
		{
			get
			{
				return this.prop_0.Data;
			}
			set
			{
				this.prop_0.Data = value;
			}
		}
	}
}
