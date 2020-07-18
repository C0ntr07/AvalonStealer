using System;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x0200019E RID: 414
	public abstract class Class_303<T> : Class_299
	{
		// Token: 0x06000BFB RID: 3067 RVA: 0x00042EAA File Offset: 0x000410AA
		public virtual void cmethod_2154(Class_296 arg_0, object obje_0, Class_418 arg_1)
		{
			throw new NotSupportedException("CustomCreationConverter should only be used while deserializing.");
		}

		// Token: 0x06000BFC RID: 3068 RVA: 0x00042EB8 File Offset: 0x000410B8
		public virtual object vmethod_2155(Class_285 arg_0, Type arg_1, object obje_0, Class_418 arg_2)
		{
			if (arg_0.prop_9 == Class_508.Null)
			{
				return null;
			}
			T t = this.Create(arg_1);
			if (t == null)
			{
				throw new Class_417("No object created.");
			}
			arg_2.vmethod_3165(arg_0, t);
			return t;
		}

		// Token: 0x06000BFD RID: 3069
		public abstract T dmethod_2156(Type arg_0);

		// Token: 0x06000BFE RID: 3070 RVA: 0x00042F06 File Offset: 0x00041106
		public virtual bool kmethod_2157(Type arg_0)
		{
			return typeof(T).IsAssignableFrom(arg_0);
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x06000BFF RID: 3071 RVA: 0x00018464 File Offset: 0x00016664
		public virtual bool prop_0
		{
			get
			{
				return false;
			}
		}
	}
}
