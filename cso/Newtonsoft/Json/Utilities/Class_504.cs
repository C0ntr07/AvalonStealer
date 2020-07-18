using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x020002B7 RID: 695
	[DefaultMember("Item")]
	internal class Class_504<TKey, TValue> : IEnumerable, ICollection, IDictionary, IEnumerable<KeyValuePair<TKey, TValue>>, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, Class_503
	{
		// Token: 0x060016FC RID: 5884 RVA: 0x0006CDD6 File Offset: 0x0006AFD6
		public Class_504(IDictionary arg_0)
		{
			Class_517.ArgumentNotNull(arg_0, "dictionary");
			this._dictionary = arg_0;
		}

		// Token: 0x060016FD RID: 5885 RVA: 0x0006CDF0 File Offset: 0x0006AFF0
		public Class_504(IDictionary<TKey, TValue> arg_0)
		{
			Class_517.ArgumentNotNull(arg_0, "dictionary");
			this._genericDictionary = arg_0;
		}

		// Token: 0x060016FE RID: 5886 RVA: 0x0006CE0C File Offset: 0x0006B00C
		public void tmethod_4102(TKey arg_0, TValue arg_1)
		{
			if (this._dictionary != null)
			{
				this._dictionary.Add(arg_0, arg_1);
				return;
			}
			if (this._genericDictionary != null)
			{
				this._genericDictionary.Add(arg_0, arg_1);
				return;
			}
			throw new NotSupportedException();
		}

		// Token: 0x060016FF RID: 5887 RVA: 0x0006CE5A File Offset: 0x0006B05A
		public bool gmethod_4103(TKey arg_0)
		{
			if (this._dictionary != null)
			{
				return this._dictionary.Contains(arg_0);
			}
			return this._genericDictionary.ContainsKey(arg_0);
		}

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x06001700 RID: 5888 RVA: 0x0006CE85 File Offset: 0x0006B085
		public ICollection<TKey> prop_0
		{
			get
			{
				if (this._dictionary != null)
				{
					return this._dictionary.Keys.Cast<TKey>().ToList<TKey>();
				}
				return this._genericDictionary.Keys;
			}
		}

		// Token: 0x06001701 RID: 5889 RVA: 0x0006CEB4 File Offset: 0x0006B0B4
		public bool vmethod_4105(TKey arg_0)
		{
			if (this._dictionary == null)
			{
				return this._genericDictionary.Remove(arg_0);
			}
			if (this._dictionary.Contains(arg_0))
			{
				this._dictionary.Remove(arg_0);
				return true;
			}
			return false;
		}

		// Token: 0x06001702 RID: 5890 RVA: 0x0006CF04 File Offset: 0x0006B104
		public bool dmethod_4106(TKey arg_0, out TValue arg_1)
		{
			if (this._dictionary == null)
			{
				return this._genericDictionary.TryGetValue(arg_0, out arg_1);
			}
			if (!this._dictionary.Contains(arg_0))
			{
				arg_1 = default(TValue);
				return false;
			}
			arg_1 = (TValue)((object)this._dictionary[arg_0]);
			return true;
		}

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x06001703 RID: 5891 RVA: 0x0006CF66 File Offset: 0x0006B166
		public ICollection<TValue> prop_1
		{
			get
			{
				if (this._dictionary != null)
				{
					return this._dictionary.Values.Cast<TValue>().ToList<TValue>();
				}
				return this._genericDictionary.Values;
			}
		}

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x06001704 RID: 5892 RVA: 0x0006CF94 File Offset: 0x0006B194
		// (set) Token: 0x06001705 RID: 5893 RVA: 0x0006CFC4 File Offset: 0x0006B1C4
		public TValue prop_2
		{
			get
			{
				if (this._dictionary != null)
				{
					return (TValue)((object)this._dictionary[arg_0]);
				}
				return this._genericDictionary[arg_0];
			}
			set
			{
				if (this._dictionary != null)
				{
					this._dictionary[arg_0] = value;
					return;
				}
				this._genericDictionary[arg_0] = value;
			}
		}

		// Token: 0x06001706 RID: 5894 RVA: 0x0006CFF6 File Offset: 0x0006B1F6
		public void smethod_4110(KeyValuePair<TKey, TValue> arg_0)
		{
			if (this._dictionary != null)
			{
				((IList)this._dictionary).Add(arg_0);
				return;
			}
			if (this._genericDictionary != null)
			{
				this._genericDictionary.Add(arg_0);
			}
		}

		// Token: 0x06001707 RID: 5895 RVA: 0x0006D032 File Offset: 0x0006B232
		public void xmethod_4111()
		{
			if (this._dictionary != null)
			{
				this._dictionary.Clear();
				return;
			}
			this._genericDictionary.Clear();
		}

		// Token: 0x06001708 RID: 5896 RVA: 0x0006D056 File Offset: 0x0006B256
		public bool tmethod_4112(KeyValuePair<TKey, TValue> arg_0)
		{
			if (this._dictionary != null)
			{
				return ((IList)this._dictionary).Contains(arg_0);
			}
			return this._genericDictionary.Contains(arg_0);
		}

		// Token: 0x06001709 RID: 5897 RVA: 0x0006D088 File Offset: 0x0006B288
		public void gmethod_4113(KeyValuePair<TKey, TValue>[] arg_0, int sayıInt_0)
		{
			if (this._dictionary != null)
			{
				using (IDictionaryEnumerator enumerator = this._dictionary.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						object obj = enumerator.Current;
						DictionaryEntry dictionaryEntry = (DictionaryEntry)obj;
						arg_0[sayıInt_0++] = new KeyValuePair<TKey, TValue>((TKey)((object)dictionaryEntry.Key), (TValue)((object)dictionaryEntry.Value));
					}
					return;
				}
			}
			this._genericDictionary.CopyTo(arg_0, sayıInt_0);
		}

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x0600170A RID: 5898 RVA: 0x0006D12C File Offset: 0x0006B32C
		public int prop_3
		{
			get
			{
				if (this._dictionary != null)
				{
					return this._dictionary.Count;
				}
				return this._genericDictionary.Count;
			}
		}

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x0600170B RID: 5899 RVA: 0x0006D150 File Offset: 0x0006B350
		public bool prop_4
		{
			get
			{
				if (this._dictionary != null)
				{
					return this._dictionary.IsReadOnly;
				}
				return this._genericDictionary.IsReadOnly;
			}
		}

		// Token: 0x0600170C RID: 5900 RVA: 0x0006D174 File Offset: 0x0006B374
		public bool dmethod_4116(KeyValuePair<TKey, TValue> arg_0)
		{
			if (this._dictionary == null)
			{
				return this._genericDictionary.Remove(arg_0);
			}
			if (!this._dictionary.Contains(arg_0.Key))
			{
				return true;
			}
			object objA = this._dictionary[arg_0.Key];
			if (object.Equals(objA, arg_0.Value))
			{
				this._dictionary.Remove(arg_0.Key);
				return true;
			}
			return false;
		}

		// Token: 0x0600170D RID: 5901 RVA: 0x0006D200 File Offset: 0x0006B400
		public IEnumerator<KeyValuePair<TKey, TValue>> kmethod_4117()
		{
			if (this._dictionary != null)
			{
				IEnumerable<DictionaryEntry> source = this._dictionary.Cast<DictionaryEntry>();
				if (Class_504<TKey, TValue>.CS$<>9__CachedAnonymousMethodDelegate1 == null)
				{
					Class_504<TKey, TValue>.CS$<>9__CachedAnonymousMethodDelegate1 = new Func<DictionaryEntry, KeyValuePair<TKey, TValue>>(Class_504<TKey, TValue>.<GetEnumerator>b__0);
				}
				return source.Select(Class_504<TKey, TValue>.CS$<>9__CachedAnonymousMethodDelegate1).GetEnumerator();
			}
			return this._genericDictionary.GetEnumerator();
		}

		// Token: 0x0600170E RID: 5902 RVA: 0x0006D259 File Offset: 0x0006B459
		IEnumerator IEnumerable.lmethod_4118()
		{
			return this.GetEnumerator();
		}

		// Token: 0x0600170F RID: 5903 RVA: 0x0006D261 File Offset: 0x0006B461
		void IDictionary.pmethod_4119(object obje_0, object obje_1)
		{
			if (this._dictionary != null)
			{
				this._dictionary.Add(obje_0, obje_1);
				return;
			}
			this._genericDictionary.Add((TKey)((object)obje_0), (TValue)((object)obje_1));
		}

		// Token: 0x170004D7 RID: 1239
		object IDictionary.this[object obje_0]
		{
			get
			{
				if (this._dictionary != null)
				{
					return this._dictionary[obje_0];
				}
				return this._genericDictionary[(TKey)((object)obje_0)];
			}
			set
			{
				if (this._dictionary != null)
				{
					this._dictionary[obje_0] = value;
					return;
				}
				this._genericDictionary[(TKey)((object)obje_0)] = (TValue)((object)value);
			}
		}

		// Token: 0x06001712 RID: 5906 RVA: 0x0006D2F5 File Offset: 0x0006B4F5
		IDictionaryEnumerator IDictionary.tmethod_4122()
		{
			if (this._dictionary != null)
			{
				return this._dictionary.GetEnumerator();
			}
			return new Class_504<TKey, TValue, TKey, TValue>.NClass_0(this._genericDictionary.GetEnumerator());
		}

		// Token: 0x06001713 RID: 5907 RVA: 0x0006D323 File Offset: 0x0006B523
		bool IDictionary.gmethod_4123(object obje_0)
		{
			if (this._genericDictionary != null)
			{
				return this._genericDictionary.ContainsKey((TKey)((object)obje_0));
			}
			return this._dictionary.Contains(obje_0);
		}

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x06001714 RID: 5908 RVA: 0x0006D34E File Offset: 0x0006B54E
		bool IDictionary.prop_6
		{
			get
			{
				return this._genericDictionary == null && this._dictionary.IsFixedSize;
			}
		}

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x06001715 RID: 5909 RVA: 0x0006D368 File Offset: 0x0006B568
		ICollection IDictionary.prop_7
		{
			get
			{
				if (this._genericDictionary != null)
				{
					return this._genericDictionary.Keys.ToList<TKey>();
				}
				return this._dictionary.Keys;
			}
		}

		// Token: 0x06001716 RID: 5910 RVA: 0x0006D391 File Offset: 0x0006B591
		public void dmethod_4126(object obje_0)
		{
			if (this._dictionary != null)
			{
				this._dictionary.Remove(obje_0);
				return;
			}
			this._genericDictionary.Remove((TKey)((object)obje_0));
		}

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x06001717 RID: 5911 RVA: 0x0006D3BD File Offset: 0x0006B5BD
		ICollection IDictionary.prop_8
		{
			get
			{
				if (this._genericDictionary != null)
				{
					return this._genericDictionary.Values.ToList<TValue>();
				}
				return this._dictionary.Values;
			}
		}

		// Token: 0x06001718 RID: 5912 RVA: 0x0006D3E6 File Offset: 0x0006B5E6
		void ICollection.lmethod_4128(Array arg_0, int sayıInt_0)
		{
			if (this._dictionary != null)
			{
				this._dictionary.CopyTo(arg_0, sayıInt_0);
				return;
			}
			this._genericDictionary.CopyTo((KeyValuePair<TKey, TValue>[])arg_0, sayıInt_0);
		}

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x06001719 RID: 5913 RVA: 0x0006D413 File Offset: 0x0006B613
		bool ICollection.prop_9
		{
			get
			{
				return this._dictionary != null && this._dictionary.IsSynchronized;
			}
		}

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x0600171A RID: 5914 RVA: 0x0006D42D File Offset: 0x0006B62D
		object ICollection.prop_10
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

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x0600171B RID: 5915 RVA: 0x0006D452 File Offset: 0x0006B652
		public object prop_11
		{
			get
			{
				if (this._dictionary != null)
				{
					return this._dictionary;
				}
				return this._genericDictionary;
			}
		}

		// Token: 0x0600171C RID: 5916 RVA: 0x0006D46C File Offset: 0x0006B66C
		[CompilerGenerated]
		private static KeyValuePair<TKey, TValue> tmethod_4132(DictionaryEntry arg_0)
		{
			return new KeyValuePair<TKey, TValue>((TKey)((object)arg_0.Key), (TValue)((object)arg_0.Value));
		}

		// Token: 0x04000C27 RID: 3111
		private readonly IDictionary field_0;

		// Token: 0x04000C28 RID: 3112
		private readonly IDictionary<TKey, TValue> field_1;

		// Token: 0x04000C29 RID: 3113
		private object field_2;

		// Token: 0x04000C2A RID: 3114
		[CompilerGenerated]
		private static Func<DictionaryEntry, KeyValuePair<TKey, TValue>> field_3;

		// Token: 0x020002B8 RID: 696
		private struct NClass_0<TEnumeratorKey, TEnumeratorValue> : IEnumerator, IDictionaryEnumerator
		{
			// Token: 0x0600171D RID: 5917 RVA: 0x0006D48B File Offset: 0x0006B68B
			public void nmethod_0(IEnumerator<KeyValuePair<TEnumeratorKey, TEnumeratorValue>> arg_0)
			{
				Class_517.ArgumentNotNull(arg_0, "e");
				this._e = arg_0;
			}

			// Token: 0x170004DE RID: 1246
			// (get) Token: 0x0600171E RID: 5918 RVA: 0x0006D49F File Offset: 0x0006B69F
			public DictionaryEntry nprop_0
			{
				get
				{
					return (DictionaryEntry)this.Current;
				}
			}

			// Token: 0x170004DF RID: 1247
			// (get) Token: 0x0600171F RID: 5919 RVA: 0x0006D4AC File Offset: 0x0006B6AC
			public object nprop_1
			{
				get
				{
					return this.Entry.Key;
				}
			}

			// Token: 0x170004E0 RID: 1248
			// (get) Token: 0x06001720 RID: 5920 RVA: 0x0006D4C8 File Offset: 0x0006B6C8
			public object nprop_2
			{
				get
				{
					return this.Entry.Value;
				}
			}

			// Token: 0x170004E1 RID: 1249
			// (get) Token: 0x06001721 RID: 5921 RVA: 0x0006D4E4 File Offset: 0x0006B6E4
			public object nprop_3
			{
				get
				{
					KeyValuePair<TEnumeratorKey, TEnumeratorValue> keyValuePair = this._e.Current;
					object key = keyValuePair.Key;
					KeyValuePair<TEnumeratorKey, TEnumeratorValue> keyValuePair2 = this._e.Current;
					return new DictionaryEntry(key, keyValuePair2.Value);
				}
			}

			// Token: 0x06001722 RID: 5922 RVA: 0x0006D52B File Offset: 0x0006B72B
			public bool nmethod_5()
			{
				return this._e.MoveNext();
			}

			// Token: 0x06001723 RID: 5923 RVA: 0x0006D538 File Offset: 0x0006B738
			public void nmethod_6()
			{
				this._e.Reset();
			}

			// Token: 0x04000C2B RID: 3115
			private readonly IEnumerator<KeyValuePair<TEnumeratorKey, TEnumeratorValue>> field_0;
		}
	}
}
