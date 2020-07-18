using System;

namespace Newtonsoft.Json
{
	// Token: 0x020001F9 RID: 505
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface | AttributeTargets.Parameter, AllowMultiple = false)]
	public sealed class Class_378 : Attribute
	{
		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06000EE5 RID: 3813 RVA: 0x0004DACC File Offset: 0x0004BCCC
		public Type ConverterType
		{
			get
			{
				return this._converterType;
			}
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06000EE6 RID: 3814 RVA: 0x0004DAD4 File Offset: 0x0004BCD4
		// (set) Token: 0x06000EE7 RID: 3815 RVA: 0x0004DADC File Offset: 0x0004BCDC
		public object[] ConverterParameters { get; private set; }

		// Token: 0x06000EE8 RID: 3816 RVA: 0x0004DAE5 File Offset: 0x0004BCE5
		public Class_378(Type converterType)
		{
			if (converterType == null)
			{
				throw new ArgumentNullException("converterType");
			}
			this._converterType = converterType;
		}

		// Token: 0x06000EE9 RID: 3817 RVA: 0x0004DB0B File Offset: 0x0004BD0B
		public Class_378(Type converterType, params object[] converterParameters) : this(converterType)
		{
			this.ConverterParameters = converterParameters;
		}

		// Token: 0x04000903 RID: 2307
		private readonly Type _converterType;
	}
}
