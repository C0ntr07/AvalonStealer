using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace \u030E\u0360\u0313\u034E\u0315\u0E47\u0020\u0305\u035C\u0351\u0E47\u0351\u0320\u0301\u036B\u0300zcryfxllszuahcty\u0347\u0334\u0342\u0E47\u0310\u032C\u0358\u0340\u036B\u0331\u0329\u036B\u0340\u032F\u0308\u0E47cexuwlosbhsreyjl
{
	// Token: 0x0200007F RID: 127
	[DefaultMember("Item")]
	public class Class_100 : Class_103, ICollection<KeyValuePair<string, Class_103>>, IEnumerable<KeyValuePair<string, Class_103>>, IEnumerable, IDictionary<string, Class_103>
	{
		// Token: 0x06000247 RID: 583 RVA: 0x00012D0A File Offset: 0x00010F0A
		public Class_100(IEnumerable<KeyValuePair<string, Class_103>> arg_0)
		{
			if (arg_0 == null)
			{
				throw new ArgumentNullException("items");
			}
			this.field_0 = new SortedDictionary<string, Class_103>(StringComparer.Ordinal);
			this.gmethod_313(arg_0);
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000248 RID: 584 RVA: 0x00012D41 File Offset: 0x00010F41
		public virtual Class_102 prop_0
		{
			get
			{
				return Class_102.\u0317\u0340\u0358\u0347\u0350\u032F\u0020\u0349\u0306\u031C\u035C\u032E\u0331\u0339\u0358\u033Byxxiufgypxhgqoxx\u035D\u034E\u0366h\u0367\u0315\u0E47\u0311\u030D\u032A\u0325\u030B\u0306\u036D\u0347\u036Cjvklzujfhndqipfi;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000249 RID: 585 RVA: 0x00012D4B File Offset: 0x00010F4B
		public new virtual int prop_1
		{
			get
			{
				return this.field_0.Count;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x0600024A RID: 586 RVA: 0x00012D5F File Offset: 0x00010F5F
		// (set) Token: 0x0600024B RID: 587 RVA: 0x00012D74 File Offset: 0x00010F74
		public sealed Class_103 prop_2
		{
			get
			{
				return this.field_0[str_0];
			}
			set
			{
				this.field_0[str_0] = value;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x0600024C RID: 588 RVA: 0x00012D8A File Offset: 0x00010F8A
		public ICollection<string> prop_3
		{
			get
			{
				return this.field_0.Keys;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x0600024D RID: 589 RVA: 0x00012D9E File Offset: 0x00010F9E
		public ICollection<Class_103> prop_4
		{
			get
			{
				return this.field_0.Values;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x0600024E RID: 590 RVA: 0x00012DB2 File Offset: 0x00010FB2
		bool ICollection<KeyValuePair<string, Class_103>>.prop_5
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0600024F RID: 591 RVA: 0x00012DBC File Offset: 0x00010FBC
		public IEnumerator<KeyValuePair<string, Class_103>> tmethod_302()
		{
			return this.field_0.GetEnumerator();
		}

		// Token: 0x06000250 RID: 592 RVA: 0x00012DBC File Offset: 0x00010FBC
		IEnumerator IEnumerable.gmethod_303()
		{
			return this.field_0.GetEnumerator();
		}

		// Token: 0x06000251 RID: 593 RVA: 0x00012DD5 File Offset: 0x00010FD5
		public void cmethod_304(string str_0, Class_103 arg_0)
		{
			if (str_0 == null)
			{
				throw new ArgumentNullException("key");
			}
			this.field_0.Add(str_0, arg_0);
		}

		// Token: 0x06000252 RID: 594 RVA: 0x00012DFC File Offset: 0x00010FFC
		public void vmethod_305(KeyValuePair<string, Class_103> arg_0)
		{
			this.cmethod_304(arg_0.Key, arg_0.Value);
		}

		// Token: 0x06000253 RID: 595 RVA: 0x00012E19 File Offset: 0x00011019
		public void dmethod_306()
		{
			this.field_0.Clear();
		}

		// Token: 0x06000254 RID: 596 RVA: 0x00012E2D File Offset: 0x0001102D
		bool ICollection<KeyValuePair<string, Class_103>>.kmethod_307(KeyValuePair<string, Class_103> arg_0)
		{
			return ((ICollection<KeyValuePair<string, Class_103>>)this.field_0).Contains(arg_0);
		}

		// Token: 0x06000255 RID: 597 RVA: 0x00012E42 File Offset: 0x00011042
		bool ICollection<KeyValuePair<string, Class_103>>.lmethod_308(KeyValuePair<string, Class_103> arg_0)
		{
			return ((ICollection<KeyValuePair<string, Class_103>>)this.field_0).Remove(arg_0);
		}

		// Token: 0x06000256 RID: 598 RVA: 0x00012E57 File Offset: 0x00011057
		public virtual bool pmethod_309(string str_0)
		{
			if (str_0 == null)
			{
				throw new ArgumentNullException("key");
			}
			return this.field_0.ContainsKey(str_0);
		}

		// Token: 0x06000257 RID: 599 RVA: 0x00012E7D File Offset: 0x0001107D
		public void smethod_310(KeyValuePair<string, Class_103>[] arg_0, int sayıInt_0)
		{
			((ICollection<KeyValuePair<string, Class_103>>)this.field_0).CopyTo(arg_0, sayıInt_0);
		}

		// Token: 0x06000258 RID: 600 RVA: 0x00012E93 File Offset: 0x00011093
		public bool xmethod_311(string str_0)
		{
			if (str_0 == null)
			{
				throw new ArgumentNullException("key");
			}
			return this.field_0.Remove(str_0);
		}

		// Token: 0x06000259 RID: 601 RVA: 0x00012EB9 File Offset: 0x000110B9
		public bool tmethod_312(string str_0, out Class_103 arg_0)
		{
			return this.field_0.TryGetValue(str_0, out arg_0);
		}

		// Token: 0x0600025A RID: 602 RVA: 0x00012ED0 File Offset: 0x000110D0
		public void gmethod_313(IEnumerable<KeyValuePair<string, Class_103>> arg_0)
		{
			if (arg_0 == null)
			{
				throw new ArgumentNullException("items");
			}
			foreach (KeyValuePair<string, Class_103> keyValuePair in arg_0)
			{
				this.field_0.Add(keyValuePair.Key, keyValuePair.Value);
			}
		}

		// Token: 0x0600025B RID: 603 RVA: 0x00012F4C File Offset: 0x0001114C
		public virtual void cmethod_314(Stream stream_, bool bool_0)
		{
			if (stream_ == null)
			{
				throw new ArgumentNullException("stream");
			}
			stream_.WriteByte(123);
			foreach (KeyValuePair<string, Class_103> keyValuePair in this.field_0)
			{
				stream_.WriteByte(34);
				byte[] bytes = Encoding.UTF8.GetBytes(base.vmethod_335(keyValuePair.Key));
				stream_.Write(bytes, 0, bytes.Length);
				stream_.WriteByte(34);
				stream_.WriteByte(44);
				stream_.WriteByte(32);
				if (keyValuePair.Value == null)
				{
					stream_.WriteByte(110);
					stream_.WriteByte(117);
					stream_.WriteByte(108);
					stream_.WriteByte(108);
				}
				else
				{
					keyValuePair.Value.smethod_330(stream_, bool_0);
				}
			}
			stream_.WriteByte(125);
		}

		// Token: 0x04000182 RID: 386
		private new SortedDictionary<string, Class_103> field_0;
	}
}
