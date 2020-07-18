using System;
using System.Dynamic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x020001EC RID: 492
	public class Class_365 : Class_350
	{
		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x06000EA0 RID: 3744 RVA: 0x0004D488 File Offset: 0x0004B688
		// (set) Token: 0x06000EA1 RID: 3745 RVA: 0x0004D490 File Offset: 0x0004B690
		public new Class_455 prop_0 { get; private set; }

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x06000EA2 RID: 3746 RVA: 0x0004D499 File Offset: 0x0004B699
		// (set) Token: 0x06000EA3 RID: 3747 RVA: 0x0004D4A1 File Offset: 0x0004B6A1
		public new Func<string, string> prop_1 { get; set; }

		// Token: 0x06000EA4 RID: 3748 RVA: 0x0004D4AC File Offset: 0x0004B6AC
		private static CallSite<Func<CallSite, object, object>> pmethod_2639(string str_0)
		{
			GetMemberBinder arg_ = (GetMemberBinder)Class_476.BinderWrapper.GetMember(str_0, typeof(Class_476));
			return CallSite<Func<CallSite, object, object>>.Create(new Class_477(arg_));
		}

		// Token: 0x06000EA5 RID: 3749 RVA: 0x0004D4DC File Offset: 0x0004B6DC
		private static CallSite<Func<CallSite, object, object, object>> smethod_2640(string str_0)
		{
			SetMemberBinder arg_ = (SetMemberBinder)Class_476.BinderWrapper.SetMember(str_0, typeof(Class_476));
			return CallSite<Func<CallSite, object, object, object>>.Create(new Class_478(arg_));
		}

		// Token: 0x06000EA6 RID: 3750 RVA: 0x0004D50C File Offset: 0x0004B70C
		public Class_365(Type arg_0) : base(arg_0)
		{
			this.field_5 = Class_448.Dynamic;
			this.prop_0 = new Class_455(base.prop_0);
		}

		// Token: 0x06000EA7 RID: 3751 RVA: 0x0004D568 File Offset: 0x0004B768
		internal bool xmethod_2641(IDynamicMetaObjectProvider arg_0, string str_0, out object arg_1)
		{
			Class_517.ArgumentNotNull(arg_0, "dynamicProvider");
			CallSite<Func<CallSite, object, object>> callSite = this.field_0.Get(str_0);
			object obj = callSite.Target(callSite, arg_0);
			if (!object.ReferenceEquals(obj, Class_479.field_0))
			{
				arg_1 = obj;
				return true;
			}
			arg_1 = null;
			return false;
		}

		// Token: 0x06000EA8 RID: 3752 RVA: 0x0004D5B4 File Offset: 0x0004B7B4
		internal bool tmethod_2642(IDynamicMetaObjectProvider arg_0, string str_0, object obje_0)
		{
			Class_517.ArgumentNotNull(arg_0, "dynamicProvider");
			CallSite<Func<CallSite, object, object, object>> callSite = this.field_1.Get(str_0);
			object objA = callSite.Target(callSite, arg_0, obje_0);
			return !object.ReferenceEquals(objA, Class_479.field_0);
		}

		// Token: 0x040008E9 RID: 2281
		private new readonly Class_493<string, CallSite<Func<CallSite, object, object>>> field_0 = new Class_493<string, CallSite<Func<CallSite, object, object>>>(new Func<string, CallSite<Func<CallSite, object, object>>>(Class_365.pmethod_2639));

		// Token: 0x040008EA RID: 2282
		private new readonly Class_493<string, CallSite<Func<CallSite, object, object, object>>> field_1 = new Class_493<string, CallSite<Func<CallSite, object, object, object>>>(new Func<string, CallSite<Func<CallSite, object, object, object>>>(Class_365.smethod_2640));

		// Token: 0x040008EB RID: 2283
		[CompilerGenerated]
		private new Class_455 field_2;

		// Token: 0x040008EC RID: 2284
		[CompilerGenerated]
		private new Func<string, string> field_3;
	}
}
