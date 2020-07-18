using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x02000231 RID: 561
	public struct Class_422<T> : IEnumerable, IEnumerable<T>, Class_360<T>, IEquatable<Class_422<T>> where T : Class_361
	{
		// Token: 0x0600123F RID: 4671 RVA: 0x00058F49 File Offset: 0x00057149
		public Class_422(IEnumerable<T> enumerable)
		{
			Class_517.ArgumentNotNull(enumerable, "enumerable");
			this._enumerable = enumerable;
		}

		// Token: 0x06001240 RID: 4672 RVA: 0x00058F60 File Offset: 0x00057160
		public IEnumerator<T> GetEnumerator()
		{
			if (this._enumerable == null)
			{
				return Class_422<T>.Empty.GetEnumerator();
			}
			return this._enumerable.GetEnumerator();
		}

		// Token: 0x06001241 RID: 4673 RVA: 0x00058F91 File Offset: 0x00057191
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x170003DF RID: 991
		public Class_360<Class_361> this[object key]
		{
			get
			{
				if (this._enumerable == null)
				{
					return Class_422<Class_361>.Empty;
				}
				return new Class_422<Class_361>(this._enumerable.Values(key));
			}
		}

		// Token: 0x06001243 RID: 4675 RVA: 0x00058FC7 File Offset: 0x000571C7
		public bool Equals(Class_422<T> other)
		{
			return object.Equals(this._enumerable, other._enumerable);
		}

		// Token: 0x06001244 RID: 4676 RVA: 0x00058FDB File Offset: 0x000571DB
		public override bool Equals(object obj)
		{
			return obj is Class_422<T> && this.Equals((Class_422<T>)obj);
		}

		// Token: 0x06001245 RID: 4677 RVA: 0x00058FF6 File Offset: 0x000571F6
		public override int GetHashCode()
		{
			if (this._enumerable == null)
			{
				return 0;
			}
			return this._enumerable.GetHashCode();
		}

		// Token: 0x04000A01 RID: 2561
		public static readonly Class_422<T> Empty = new Class_422<T>(Enumerable.Empty<T>());

		// Token: 0x04000A02 RID: 2562
		private readonly IEnumerable<T> _enumerable;
	}
}
