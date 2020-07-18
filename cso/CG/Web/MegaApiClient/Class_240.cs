using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CG.Web.MegaApiClient.Serialization;
using Newtonsoft.Json;

namespace CG.Web.MegaApiClient
{
	// Token: 0x02000145 RID: 325
	[DebuggerDisplay("NodeInfo - Type: {Type} - Name: {Name} - Id: {Id}")]
	internal class Class_240 : IEquatable<Class_232>, Class_232
	{
		// Token: 0x06000922 RID: 2338 RVA: 0x0000237C File Offset: 0x0000057C
		protected Class_240()
		{
		}

		// Token: 0x06000923 RID: 2339 RVA: 0x0003B7ED File Offset: 0x000399ED
		internal Class_240(string str_0, Class_259 arg_0, byte[] byteDizi_0)
		{
			this.prop_3 = str_0;
			this.prop_6 = Class_223.lmethod_1478(arg_0.prop_2.FromBase64(), byteDizi_0);
			this.prop_1 = arg_0.prop_1;
			this.prop_2 = Class_235.File;
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x06000924 RID: 2340 RVA: 0x0003B826 File Offset: 0x00039A26
		[Class_411]
		public string prop_0
		{
			get
			{
				Class_254 class_ = this.prop_6;
				if (class_ == null)
				{
					return null;
				}
				return class_.prop_0;
			}
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x06000925 RID: 2341 RVA: 0x0003B83C File Offset: 0x00039A3C
		// (set) Token: 0x06000926 RID: 2342 RVA: 0x0003B844 File Offset: 0x00039A44
		[Class_410("s")]
		public long prop_1 { get; protected set; }

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x06000927 RID: 2343 RVA: 0x0003B84D File Offset: 0x00039A4D
		// (set) Token: 0x06000928 RID: 2344 RVA: 0x0003B855 File Offset: 0x00039A55
		[Class_410("t")]
		public Class_235 prop_2 { get; protected set; }

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x06000929 RID: 2345 RVA: 0x0003B85E File Offset: 0x00039A5E
		// (set) Token: 0x0600092A RID: 2346 RVA: 0x0003B866 File Offset: 0x00039A66
		[Class_410("h")]
		public string prop_3 { get; private set; }

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x0600092B RID: 2347 RVA: 0x0003B870 File Offset: 0x00039A70
		[Class_411]
		public DateTime? prop_4
		{
			get
			{
				Class_254 class_ = this.prop_6;
				if (class_ == null)
				{
					return null;
				}
				return class_.prop_2;
			}
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x0600092C RID: 2348 RVA: 0x0003B899 File Offset: 0x00039A99
		[Class_411]
		public string prop_5
		{
			get
			{
				Class_254 class_ = this.prop_6;
				if (class_ == null)
				{
					return null;
				}
				return class_.prop_1;
			}
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x0600092D RID: 2349 RVA: 0x0003B8AF File Offset: 0x00039AAF
		// (set) Token: 0x0600092E RID: 2350 RVA: 0x0003B8B7 File Offset: 0x00039AB7
		[Class_411]
		public Class_254 prop_6 { get; protected set; }

		// Token: 0x0600092F RID: 2351 RVA: 0x0003B8C0 File Offset: 0x00039AC0
		public bool smethod_1600(Class_232 arg_0)
		{
			return arg_0 != null && this.prop_3 == arg_0.prop_0;
		}

		// Token: 0x06000930 RID: 2352 RVA: 0x0003B8DB File Offset: 0x00039ADB
		public virtual int xmethod_1601()
		{
			return this.prop_3.GetHashCode();
		}

		// Token: 0x06000931 RID: 2353 RVA: 0x0003B8E8 File Offset: 0x00039AE8
		public virtual bool tmethod_1602(object obje_0)
		{
			return this.smethod_1600(obje_0 as Class_232);
		}

		// Token: 0x0400065D RID: 1629
		[CompilerGenerated]
		private long field_0;

		// Token: 0x0400065E RID: 1630
		[CompilerGenerated]
		private Class_235 field_1;

		// Token: 0x0400065F RID: 1631
		[CompilerGenerated]
		private string field_2;

		// Token: 0x04000660 RID: 1632
		[CompilerGenerated]
		private Class_254 field_3;
	}
}
