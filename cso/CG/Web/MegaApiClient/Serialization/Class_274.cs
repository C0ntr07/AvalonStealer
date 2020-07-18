using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CG.Web.MegaApiClient.Serialization
{
	// Token: 0x02000171 RID: 369
	[Class_378(typeof(SessionHistoryResponse.SessionHistoryConverter))]
	internal class Class_274 : Collection<Class_236>
	{
		// Token: 0x02000172 RID: 370
		internal class NClass_0 : Class_299
		{
			// Token: 0x06000A52 RID: 2642 RVA: 0x0003D6B9 File Offset: 0x0003B8B9
			public virtual bool nmethod_0(Type arg_0)
			{
				return typeof(Class_274.NClass_0.Session) == arg_0;
			}

			// Token: 0x06000A53 RID: 2643 RVA: 0x0003D6CC File Offset: 0x0003B8CC
			public virtual object nmethod_1(Class_285 arg_0, Type arg_1, object obje_0, Class_418 arg_2)
			{
				if (arg_0.prop_9 == Class_508.Null)
				{
					return null;
				}
				Class_274 class_ = new Class_274();
				foreach (Class_424 jArray in Class_424.xmethod_3351(arg_0).OfType<Class_424>())
				{
					class_.Add(new Class_274.NClass_0.Session(jArray));
				}
				return class_;
			}

			// Token: 0x06000A54 RID: 2644 RVA: 0x0001429B File Offset: 0x0001249B
			public virtual void nmethod_2(Class_296 arg_0, object obje_0, Class_418 arg_1)
			{
				throw new NotSupportedException();
			}

			// Token: 0x06000A55 RID: 2645 RVA: 0x0003D744 File Offset: 0x0003B944
			public void nmethod_3()
			{
				base..ctor();
			}

			// Token: 0x02000173 RID: 371
			private class Session : Class_236
			{
				// Token: 0x06000A56 RID: 2646 RVA: 0x0003D74C File Offset: 0x0003B94C
				public Session(Class_424 jArray)
				{
					try
					{
						this.LoginTime = jArray.dmethod_2466<long>(0).ToDateTime();
						this.LastSeenTime = jArray.dmethod_2466<long>(1).ToDateTime();
						this.Client = jArray.dmethod_2466<string>(2);
						this.IpAddress = IPAddress.Parse(jArray.dmethod_2466<string>(3));
						this.Country = jArray.dmethod_2466<string>(4);
						this.SessionId = jArray.dmethod_2466<string>(6);
						jArray.dmethod_2466<long>(7);
						if (jArray.dmethod_2466<long>(5) == 1L)
						{
							this.Status |= Class_237.Current;
						}
						if (jArray.dmethod_2466<long>(7) == 1L)
						{
							this.Status |= Class_237.Active;
						}
						if (this.Status == Class_237.Undefined)
						{
							this.Status = Class_237.Expired;
						}
					}
					catch (Exception ex)
					{
						this.Client = "Deserialization error: " + ex.Message;
					}
				}

				// Token: 0x1700023B RID: 571
				// (get) Token: 0x06000A57 RID: 2647 RVA: 0x0003D86C File Offset: 0x0003BA6C
				// (set) Token: 0x06000A58 RID: 2648 RVA: 0x0003D874 File Offset: 0x0003BA74
				public string Client { get; private set; }

				// Token: 0x1700023C RID: 572
				// (get) Token: 0x06000A59 RID: 2649 RVA: 0x0003D87D File Offset: 0x0003BA7D
				// (set) Token: 0x06000A5A RID: 2650 RVA: 0x0003D885 File Offset: 0x0003BA85
				public IPAddress IpAddress { get; private set; }

				// Token: 0x1700023D RID: 573
				// (get) Token: 0x06000A5B RID: 2651 RVA: 0x0003D88E File Offset: 0x0003BA8E
				// (set) Token: 0x06000A5C RID: 2652 RVA: 0x0003D896 File Offset: 0x0003BA96
				public string Country { get; private set; }

				// Token: 0x1700023E RID: 574
				// (get) Token: 0x06000A5D RID: 2653 RVA: 0x0003D89F File Offset: 0x0003BA9F
				// (set) Token: 0x06000A5E RID: 2654 RVA: 0x0003D8A7 File Offset: 0x0003BAA7
				public DateTime LoginTime { get; private set; }

				// Token: 0x1700023F RID: 575
				// (get) Token: 0x06000A5F RID: 2655 RVA: 0x0003D8B0 File Offset: 0x0003BAB0
				// (set) Token: 0x06000A60 RID: 2656 RVA: 0x0003D8B8 File Offset: 0x0003BAB8
				public DateTime LastSeenTime { get; private set; }

				// Token: 0x17000240 RID: 576
				// (get) Token: 0x06000A61 RID: 2657 RVA: 0x0003D8C1 File Offset: 0x0003BAC1
				// (set) Token: 0x06000A62 RID: 2658 RVA: 0x0003D8C9 File Offset: 0x0003BAC9
				public Class_237 Status { get; private set; }

				// Token: 0x17000241 RID: 577
				// (get) Token: 0x06000A63 RID: 2659 RVA: 0x0003D8D2 File Offset: 0x0003BAD2
				// (set) Token: 0x06000A64 RID: 2660 RVA: 0x0003D8DA File Offset: 0x0003BADA
				public string SessionId { get; private set; }
			}
		}
	}
}
