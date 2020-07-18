using System;
using System.ComponentModel;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x020001F3 RID: 499
	public class Class_372 : PropertyDescriptor
	{
		// Token: 0x06000ECB RID: 3787 RVA: 0x0004D920 File Offset: 0x0004BB20
		public Class_372(string str_0) : base(str_0, null)
		{
		}

		// Token: 0x06000ECC RID: 3788 RVA: 0x0004D92A File Offset: 0x0004BB2A
		private static Class_423 xmethod_2671(object obje_0)
		{
			return (Class_423)obje_0;
		}

		// Token: 0x06000ECD RID: 3789 RVA: 0x00018464 File Offset: 0x00016664
		public virtual bool tmethod_2672(object obje_0)
		{
			return false;
		}

		// Token: 0x06000ECE RID: 3790 RVA: 0x0004D934 File Offset: 0x0004BB34
		public virtual object gmethod_2673(object obje_0)
		{
			return Class_372.xmethod_2671(obje_0).kmethod_3307(this.Name);
		}

		// Token: 0x06000ECF RID: 3791 RVA: 0x00002050 File Offset: 0x00000250
		public virtual void cmethod_2674(object obje_0)
		{
		}

		// Token: 0x06000ED0 RID: 3792 RVA: 0x0004D954 File Offset: 0x0004BB54
		public virtual void vmethod_2675(object obje_0, object obje_1)
		{
			Class_361 arg_ = (obje_1 is Class_361) ? ((Class_361)obje_1) : new Class_362(obje_1);
			Class_372.xmethod_2671(obje_0).lmethod_3308(this.Name, arg_);
		}

		// Token: 0x06000ED1 RID: 3793 RVA: 0x00018464 File Offset: 0x00016664
		public virtual bool dmethod_2676(object obje_0)
		{
			return false;
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06000ED2 RID: 3794 RVA: 0x0004D990 File Offset: 0x0004BB90
		public virtual Type prop_0
		{
			get
			{
				return typeof(Class_423);
			}
		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x06000ED3 RID: 3795 RVA: 0x00018464 File Offset: 0x00016664
		public virtual bool prop_1
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x06000ED4 RID: 3796 RVA: 0x0004D99C File Offset: 0x0004BB9C
		public virtual Type prop_2
		{
			get
			{
				return typeof(object);
			}
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06000ED5 RID: 3797 RVA: 0x0004D9A8 File Offset: 0x0004BBA8
		protected virtual int prop_3
		{
			get
			{
				return base.NameHashCode;
			}
		}
	}
}
