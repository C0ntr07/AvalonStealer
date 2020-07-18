using System;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000251 RID: 593
	internal struct Class_443 : IEquatable<Class_443>
	{
		// Token: 0x060013DC RID: 5084 RVA: 0x0005E233 File Offset: 0x0005C433
		public Class_443(Type resolverType, Type contractType)
		{
			this._resolverType = resolverType;
			this._contractType = contractType;
		}

		// Token: 0x060013DD RID: 5085 RVA: 0x0005E243 File Offset: 0x0005C443
		public override int GetHashCode()
		{
			return this._resolverType.GetHashCode() ^ this._contractType.GetHashCode();
		}

		// Token: 0x060013DE RID: 5086 RVA: 0x0005E25C File Offset: 0x0005C45C
		public override bool Equals(object obj)
		{
			return obj is Class_443 && this.Equals((Class_443)obj);
		}

		// Token: 0x060013DF RID: 5087 RVA: 0x0005E277 File Offset: 0x0005C477
		public bool Equals(Class_443 other)
		{
			return this._resolverType == other._resolverType && this._contractType == other._contractType;
		}

		// Token: 0x04000A7A RID: 2682
		private readonly Type _resolverType;

		// Token: 0x04000A7B RID: 2683
		private readonly Type _contractType;
	}
}
