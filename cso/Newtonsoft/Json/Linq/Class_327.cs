using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x020001B6 RID: 438
	[DefaultMember("Item")]
	internal class Class_327 : Collection<Class_361>
	{
		// Token: 0x06000C5E RID: 3166 RVA: 0x000444ED File Offset: 0x000426ED
		private void dmethod_2226(string str_0, Class_361 arg_0)
		{
			this.xmethod_2231();
			this.field_1[str_0] = arg_0;
		}

		// Token: 0x06000C5F RID: 3167 RVA: 0x00044504 File Offset: 0x00042704
		protected void kmethod_2227(Class_361 arg_0, string str_0)
		{
			if (!this.smethod_2230(arg_0))
			{
				throw new ArgumentException("The specified item does not exist in this KeyedCollection.");
			}
			string text = this.tmethod_2232(arg_0);
			if (!Class_327.field_0.Equals(text, str_0))
			{
				if (str_0 != null)
				{
					this.dmethod_2226(str_0, arg_0);
				}
				if (text != null)
				{
					this.dmethod_2236(text);
				}
			}
		}

		// Token: 0x06000C60 RID: 3168 RVA: 0x0004455C File Offset: 0x0004275C
		protected virtual void lmethod_2228()
		{
			base.ClearItems();
			if (this.field_1 != null)
			{
				this.field_1.Clear();
			}
		}

		// Token: 0x06000C61 RID: 3169 RVA: 0x0004457A File Offset: 0x0004277A
		public bool pmethod_2229(string str_0)
		{
			if (str_0 == null)
			{
				throw new ArgumentNullException("key");
			}
			return this.field_1 != null && this.field_1.ContainsKey(str_0);
		}

		// Token: 0x06000C62 RID: 3170 RVA: 0x000445A8 File Offset: 0x000427A8
		private bool smethod_2230(Class_361 arg_0)
		{
			if (this.field_1 == null)
			{
				return false;
			}
			string key = this.tmethod_2232(arg_0);
			Class_361 class_;
			return this.field_1.TryGetValue(key, out class_);
		}

		// Token: 0x06000C63 RID: 3171 RVA: 0x000445D8 File Offset: 0x000427D8
		private void xmethod_2231()
		{
			if (this.field_1 == null)
			{
				this.field_1 = new Dictionary<string, Class_361>(Class_327.field_0);
			}
		}

		// Token: 0x06000C64 RID: 3172 RVA: 0x000445F5 File Offset: 0x000427F5
		private string tmethod_2232(Class_361 arg_0)
		{
			return ((Class_427)arg_0).prop_1;
		}

		// Token: 0x06000C65 RID: 3173 RVA: 0x00044602 File Offset: 0x00042802
		protected virtual void gmethod_2233(int sayıInt_0, Class_361 arg_0)
		{
			this.dmethod_2226(this.tmethod_2232(arg_0), arg_0);
			base.InsertItem(sayıInt_0, arg_0);
		}

		// Token: 0x06000C66 RID: 3174 RVA: 0x0004461C File Offset: 0x0004281C
		public bool cmethod_2234(string str_0)
		{
			if (str_0 == null)
			{
				throw new ArgumentNullException("key");
			}
			return this.field_1 != null && this.field_1.ContainsKey(str_0) && base.Remove(this.field_1[str_0]);
		}

		// Token: 0x06000C67 RID: 3175 RVA: 0x0004466C File Offset: 0x0004286C
		protected virtual void vmethod_2235(int sayıInt_0)
		{
			string str_ = this.tmethod_2232(base.Items[sayıInt_0]);
			this.dmethod_2236(str_);
			base.RemoveItem(sayıInt_0);
		}

		// Token: 0x06000C68 RID: 3176 RVA: 0x0004469A File Offset: 0x0004289A
		private void dmethod_2236(string str_0)
		{
			if (this.field_1 != null)
			{
				this.field_1.Remove(str_0);
			}
		}

		// Token: 0x06000C69 RID: 3177 RVA: 0x000446B4 File Offset: 0x000428B4
		protected virtual void kmethod_2237(int sayıInt_0, Class_361 arg_0)
		{
			string text = this.tmethod_2232(arg_0);
			string text2 = this.tmethod_2232(base.Items[sayıInt_0]);
			if (Class_327.field_0.Equals(text2, text))
			{
				if (this.field_1 != null)
				{
					this.field_1[text] = arg_0;
				}
			}
			else
			{
				this.dmethod_2226(text, arg_0);
				if (text2 != null)
				{
					this.dmethod_2236(text2);
				}
			}
			base.SetItem(sayıInt_0, arg_0);
		}

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x06000C6A RID: 3178 RVA: 0x00044727 File Offset: 0x00042927
		public Class_361 prop_0
		{
			get
			{
				if (str_0 == null)
				{
					throw new ArgumentNullException("key");
				}
				if (this.field_1 != null)
				{
					return this.field_1[str_0];
				}
				throw new KeyNotFoundException();
			}
		}

		// Token: 0x06000C6B RID: 3179 RVA: 0x00044757 File Offset: 0x00042957
		public bool pmethod_2239(string str_0, out Class_361 arg_0)
		{
			if (this.field_1 == null)
			{
				arg_0 = null;
				return false;
			}
			return this.field_1.TryGetValue(str_0, out arg_0);
		}

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x06000C6C RID: 3180 RVA: 0x00044776 File Offset: 0x00042976
		public ICollection<string> prop_1
		{
			get
			{
				this.xmethod_2231();
				return this.field_1.Keys;
			}
		}

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x06000C6D RID: 3181 RVA: 0x00044789 File Offset: 0x00042989
		public ICollection<Class_361> prop_2
		{
			get
			{
				this.xmethod_2231();
				return this.field_1.Values;
			}
		}

		// Token: 0x06000C6E RID: 3182 RVA: 0x0004479C File Offset: 0x0004299C
		public bool tmethod_2242(Class_327 arg_0)
		{
			if (this == arg_0)
			{
				return true;
			}
			Dictionary<string, Class_361> dictionary = this.field_1;
			Dictionary<string, Class_361> dictionary2 = arg_0.field_1;
			if (dictionary == null && dictionary2 == null)
			{
				return true;
			}
			if (dictionary == null)
			{
				return dictionary2.Count == 0;
			}
			if (dictionary2 == null)
			{
				return dictionary.Count == 0;
			}
			if (dictionary.Count != dictionary2.Count)
			{
				return false;
			}
			foreach (KeyValuePair<string, Class_361> keyValuePair in dictionary)
			{
				Class_361 class_;
				if (!dictionary2.TryGetValue(keyValuePair.Key, out class_))
				{
					return false;
				}
				Class_427 class_2 = (Class_427)keyValuePair.Value;
				Class_427 class_3 = (Class_427)class_;
				if (class_2.prop_2 == null)
				{
					return class_3.prop_2 == null;
				}
				if (!class_2.prop_2.lmethod_2448(class_3.prop_2))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x040007DE RID: 2014
		private static readonly IEqualityComparer<string> field_0 = StringComparer.Ordinal;

		// Token: 0x040007DF RID: 2015
		private Dictionary<string, Class_361> field_1;
	}
}
