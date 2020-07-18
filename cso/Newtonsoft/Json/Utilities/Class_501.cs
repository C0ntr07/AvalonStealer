using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x020002B4 RID: 692
	internal class Class_501<T> : IEnumerable, IEnumerable<T>, IList, ICollection, ICollection<T>, Class_500
	{
		// Token: 0x060016C8 RID: 5832 RVA: 0x0006BD75 File Offset: 0x00069F75
		public Class_501(IList arg_0)
		{
			Class_517.ArgumentNotNull(arg_0, "list");
			if (arg_0 is ICollection<T>)
			{
				this._genericCollection = (ICollection<T>)arg_0;
				return;
			}
			this._list = arg_0;
		}

		// Token: 0x060016C9 RID: 5833 RVA: 0x0006BDA7 File Offset: 0x00069FA7
		public Class_501(ICollection<T> arg_0)
		{
			Class_517.ArgumentNotNull(arg_0, "list");
			this._genericCollection = arg_0;
		}

		// Token: 0x060016CA RID: 5834 RVA: 0x0006BDC1 File Offset: 0x00069FC1
		public virtual void kmethod_4077(T arg_0)
		{
			if (this._genericCollection != null)
			{
				this._genericCollection.Add(arg_0);
				return;
			}
			this._list.Add(arg_0);
		}

		// Token: 0x060016CB RID: 5835 RVA: 0x0006BDED File Offset: 0x00069FED
		public virtual void lmethod_4078()
		{
			if (this._genericCollection != null)
			{
				this._genericCollection.Clear();
				return;
			}
			this._list.Clear();
		}

		// Token: 0x060016CC RID: 5836 RVA: 0x0006BE11 File Offset: 0x0006A011
		public virtual bool pmethod_4079(T arg_0)
		{
			if (this._genericCollection != null)
			{
				return this._genericCollection.Contains(arg_0);
			}
			return this._list.Contains(arg_0);
		}

		// Token: 0x060016CD RID: 5837 RVA: 0x0006BE3C File Offset: 0x0006A03C
		public virtual void smethod_4080(T[] arg_0, int sayıInt_0)
		{
			if (this._genericCollection != null)
			{
				this._genericCollection.CopyTo(arg_0, sayıInt_0);
				return;
			}
			this._list.CopyTo(arg_0, sayıInt_0);
		}

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x060016CE RID: 5838 RVA: 0x0006BE64 File Offset: 0x0006A064
		public virtual int prop_0
		{
			get
			{
				if (this._genericCollection != null)
				{
					return this._genericCollection.Count;
				}
				return this._list.Count;
			}
		}

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x060016CF RID: 5839 RVA: 0x0006BE88 File Offset: 0x0006A088
		public virtual bool prop_1
		{
			get
			{
				if (this._genericCollection != null)
				{
					return this._genericCollection.IsReadOnly;
				}
				return this._list.IsReadOnly;
			}
		}

		// Token: 0x060016D0 RID: 5840 RVA: 0x0006BEAC File Offset: 0x0006A0AC
		public virtual bool gmethod_4083(T arg_0)
		{
			if (this._genericCollection != null)
			{
				return this._genericCollection.Remove(arg_0);
			}
			bool flag = this._list.Contains(arg_0);
			if (flag)
			{
				this._list.Remove(arg_0);
			}
			return flag;
		}

		// Token: 0x060016D1 RID: 5841 RVA: 0x0006BEFB File Offset: 0x0006A0FB
		public virtual IEnumerator<T> cmethod_4084()
		{
			if (this._genericCollection != null)
			{
				return this._genericCollection.GetEnumerator();
			}
			return this._list.Cast<T>().GetEnumerator();
		}

		// Token: 0x060016D2 RID: 5842 RVA: 0x0006BF24 File Offset: 0x0006A124
		IEnumerator IEnumerable.vmethod_4085()
		{
			if (this._genericCollection != null)
			{
				return this._genericCollection.GetEnumerator();
			}
			return this._list.GetEnumerator();
		}

		// Token: 0x060016D3 RID: 5843 RVA: 0x0006BF48 File Offset: 0x0006A148
		int IList.dmethod_4086(object obje_0)
		{
			Class_501<T>.VerifyValueType(obje_0);
			this.Add((T)((object)obje_0));
			return this.Count - 1;
		}

		// Token: 0x060016D4 RID: 5844 RVA: 0x0006BF64 File Offset: 0x0006A164
		bool IList.kmethod_4087(object obje_0)
		{
			return Class_501<T>.IsCompatibleObject(obje_0) && this.Contains((T)((object)obje_0));
		}

		// Token: 0x060016D5 RID: 5845 RVA: 0x0006BF7F File Offset: 0x0006A17F
		int IList.lmethod_4088(object obje_0)
		{
			if (this._genericCollection != null)
			{
				throw new InvalidOperationException("Wrapped ICollection<T> does not support IndexOf.");
			}
			if (Class_501<T>.IsCompatibleObject(obje_0))
			{
				return this._list.IndexOf((T)((object)obje_0));
			}
			return -1;
		}

		// Token: 0x060016D6 RID: 5846 RVA: 0x0006BFBA File Offset: 0x0006A1BA
		void IList.pmethod_4089(int sayıInt_0)
		{
			if (this._genericCollection != null)
			{
				throw new InvalidOperationException("Wrapped ICollection<T> does not support RemoveAt.");
			}
			this._list.RemoveAt(sayıInt_0);
		}

		// Token: 0x060016D7 RID: 5847 RVA: 0x0006BFDE File Offset: 0x0006A1DE
		void IList.smethod_4090(int sayıInt_0, object obje_0)
		{
			if (this._genericCollection != null)
			{
				throw new InvalidOperationException("Wrapped ICollection<T> does not support Insert.");
			}
			Class_501<T>.VerifyValueType(obje_0);
			this._list.Insert(sayıInt_0, (T)((object)obje_0));
		}

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x060016D8 RID: 5848 RVA: 0x0006C013 File Offset: 0x0006A213
		bool IList.prop_2
		{
			get
			{
				if (this._genericCollection != null)
				{
					return this._genericCollection.IsReadOnly;
				}
				return this._list.IsFixedSize;
			}
		}

		// Token: 0x060016D9 RID: 5849 RVA: 0x0006C037 File Offset: 0x0006A237
		void IList.tmethod_4092(object obje_0)
		{
			if (Class_501<T>.IsCompatibleObject(obje_0))
			{
				this.Remove((T)((object)obje_0));
			}
		}

		// Token: 0x170004CD RID: 1229
		object IList.this[int sayıInt_0]
		{
			get
			{
				if (this._genericCollection != null)
				{
					throw new InvalidOperationException("Wrapped ICollection<T> does not support indexer.");
				}
				return this._list[sayıInt_0];
			}
			set
			{
				if (this._genericCollection != null)
				{
					throw new InvalidOperationException("Wrapped ICollection<T> does not support indexer.");
				}
				Class_501<T>.VerifyValueType(value);
				this._list[sayıInt_0] = (T)((object)value);
			}
		}

		// Token: 0x060016DC RID: 5852 RVA: 0x0006C0AA File Offset: 0x0006A2AA
		void ICollection.vmethod_4095(Array arg_0, int sayıInt_0)
		{
			this.CopyTo((T[])arg_0, sayıInt_0);
		}

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x060016DD RID: 5853 RVA: 0x00018464 File Offset: 0x00016664
		bool ICollection.prop_4
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x060016DE RID: 5854 RVA: 0x0006C0B9 File Offset: 0x0006A2B9
		object ICollection.prop_5
		{
			get
			{
				if (this._syncRoot == null)
				{
					Interlocked.CompareExchange(ref this._syncRoot, new object(), null);
				}
				return this._syncRoot;
			}
		}

		// Token: 0x060016DF RID: 5855 RVA: 0x0006C0DE File Offset: 0x0006A2DE
		private static void lmethod_4098(object obje_0)
		{
			if (!Class_501<T>.IsCompatibleObject(obje_0))
			{
				throw new ArgumentException("The value '{0}' is not of type '{1}' and cannot be used in this generic collection.".FormatWith(CultureInfo.InvariantCulture, obje_0, typeof(T)), "value");
			}
		}

		// Token: 0x060016E0 RID: 5856 RVA: 0x0006C110 File Offset: 0x0006A310
		private static bool pmethod_4099(object obje_0)
		{
			return obje_0 is T || (obje_0 == null && (!typeof(T).IsValueType || Class_514.IsNullableType(typeof(T))));
		}

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x060016E1 RID: 5857 RVA: 0x0006C14E File Offset: 0x0006A34E
		public object prop_6
		{
			get
			{
				if (this._genericCollection != null)
				{
					return this._genericCollection;
				}
				return this._list;
			}
		}

		// Token: 0x04000C1C RID: 3100
		private readonly IList field_0;

		// Token: 0x04000C1D RID: 3101
		private readonly ICollection<T> field_1;

		// Token: 0x04000C1E RID: 3102
		private object field_2;
	}
}
