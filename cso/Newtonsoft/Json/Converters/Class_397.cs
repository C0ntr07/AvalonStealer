using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Linq;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x0200020D RID: 525
	internal class Class_397 : Class_387
	{
		// Token: 0x06000FD1 RID: 4049 RVA: 0x0005045C File Offset: 0x0004E65C
		public Class_397(XObject arg_0)
		{
			this.field_0 = arg_0;
		}

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x06000FD2 RID: 4050 RVA: 0x0005046B File Offset: 0x0004E66B
		public object prop_0
		{
			get
			{
				return this.field_0;
			}
		}

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x06000FD3 RID: 4051 RVA: 0x00050473 File Offset: 0x0004E673
		public virtual XmlNodeType prop_1
		{
			get
			{
				return this.field_0.NodeType;
			}
		}

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x06000FD4 RID: 4052 RVA: 0x0004259A File Offset: 0x0004079A
		public virtual string prop_2
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x06000FD5 RID: 4053 RVA: 0x00050480 File Offset: 0x0004E680
		public virtual IList<Class_387> prop_3
		{
			get
			{
				return new List<Class_387>();
			}
		}

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x06000FD6 RID: 4054 RVA: 0x0004259A File Offset: 0x0004079A
		public virtual IList<Class_387> prop_4
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x06000FD7 RID: 4055 RVA: 0x0004259A File Offset: 0x0004079A
		public virtual Class_387 prop_5
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x06000FD8 RID: 4056 RVA: 0x0004259A File Offset: 0x0004079A
		// (set) Token: 0x06000FD9 RID: 4057 RVA: 0x0001353B File Offset: 0x0001173B
		public virtual string prop_6
		{
			get
			{
				return null;
			}
			set
			{
				throw new InvalidOperationException();
			}
		}

		// Token: 0x06000FDA RID: 4058 RVA: 0x0001353B File Offset: 0x0001173B
		public virtual Class_387 smethod_2890(Class_387 arg_0)
		{
			throw new InvalidOperationException();
		}

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x06000FDB RID: 4059 RVA: 0x0004259A File Offset: 0x0004079A
		public virtual string prop_7
		{
			get
			{
				return null;
			}
		}

		// Token: 0x04000966 RID: 2406
		private readonly XObject field_0;
	}
}
