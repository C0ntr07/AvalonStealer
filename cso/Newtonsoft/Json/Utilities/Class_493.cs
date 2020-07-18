using System;
using System.Collections.Generic;
using System.Threading;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x020002A9 RID: 681
	internal class Class_493<TKey, TValue>
	{
		// Token: 0x0600169F RID: 5791 RVA: 0x0006A9A2 File Offset: 0x00068BA2
		public Class_493(Func<TKey, TValue> arg_0)
		{
			this._lock = new object();
			base..ctor();
			if (arg_0 == null)
			{
				throw new ArgumentNullException("creator");
			}
			this._creator = arg_0;
			this._store = new Dictionary<TKey, TValue>();
		}

		// Token: 0x060016A0 RID: 5792 RVA: 0x0006A9D8 File Offset: 0x00068BD8
		public TValue kmethod_4067(TKey arg_0)
		{
			TValue result;
			if (!this._store.TryGetValue(arg_0, out result))
			{
				return this.AddValue(arg_0);
			}
			return result;
		}

		// Token: 0x060016A1 RID: 5793 RVA: 0x0006AA04 File Offset: 0x00068C04
		private TValue lmethod_4068(TKey arg_0)
		{
			TValue tvalue = this._creator(arg_0);
			TValue result2;
			lock (this._lock)
			{
				if (this._store == null)
				{
					this._store = new Dictionary<TKey, TValue>();
					this._store[arg_0] = tvalue;
				}
				else
				{
					TValue result;
					if (this._store.TryGetValue(arg_0, out result))
					{
						return result;
					}
					Dictionary<TKey, TValue> dictionary = new Dictionary<TKey, TValue>(this._store);
					dictionary[arg_0] = tvalue;
					Thread.MemoryBarrier();
					this._store = dictionary;
				}
				result2 = tvalue;
			}
			return result2;
		}

		// Token: 0x04000BD2 RID: 3026
		private readonly object field_0;

		// Token: 0x04000BD3 RID: 3027
		private Dictionary<TKey, TValue> field_1;

		// Token: 0x04000BD4 RID: 3028
		private readonly Func<TKey, TValue> field_2;
	}
}
