using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace \u030E\u0360\u0313\u034E\u0315\u0E47\u0020\u0305\u035C\u0351\u0E47\u0351\u0320\u0301\u036B\u0300zcryfxllszuahcty\u0347\u0334\u0342\u0E47\u0310\u032C\u0358\u0340\u036B\u0331\u0329\u036B\u0340\u032F\u0308\u0E47cexuwlosbhsreyjl
{
	// Token: 0x0200007D RID: 125
	[DefaultMember("Item")]
	public class Class_98 : Class_103, IEnumerable<Class_103>, IEnumerable, IList<Class_103>, ICollection<Class_103>
	{
		// Token: 0x06000235 RID: 565 RVA: 0x00012AA3 File Offset: 0x00010CA3
		public Class_98(IEnumerable<Class_103> arg_0)
		{
			if (arg_0 == null)
			{
				throw new ArgumentNullException("items");
			}
			this.field_0 = new List<Class_103>(arg_0);
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000236 RID: 566 RVA: 0x00012AD4 File Offset: 0x00010CD4
		public virtual Class_102 prop_0
		{
			get
			{
				return Class_102.\u0320\u0322\u030D\u0322\u0328\u0329\u0326\u033F\u0349\u0346\u032A\u032F\u034D\u0E47\u0363\u035Fwhntkywlfriguado\u0335\u0E47\u0020\u0326\u0322\u0346\u032F\u0313\u034F\u0346\u0358\u033C\u0347\u0020\u0325\u033Dsievsoxohtygiqah;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000237 RID: 567 RVA: 0x00012AE3 File Offset: 0x00010CE3
		public new virtual int prop_1
		{
			get
			{
				return this.field_0.Count;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000238 RID: 568 RVA: 0x00012AFC File Offset: 0x00010CFC
		public new bool prop_2
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000239 RID: 569 RVA: 0x00012B0B File Offset: 0x00010D0B
		// (set) Token: 0x0600023A RID: 570 RVA: 0x00012B25 File Offset: 0x00010D25
		public sealed Class_103 prop_3
		{
			get
			{
				return this.field_0[sayıInt_0];
			}
			set
			{
				this.field_0[sayıInt_0] = value;
			}
		}

		// Token: 0x0600023B RID: 571 RVA: 0x00012B40 File Offset: 0x00010D40
		public void cmethod_284(Class_103 arg_0)
		{
			if (arg_0 == null)
			{
				throw new ArgumentNullException("item");
			}
			this.field_0.Add(arg_0);
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00012B6B File Offset: 0x00010D6B
		public void vmethod_285()
		{
			this.field_0.Clear();
		}

		// Token: 0x0600023D RID: 573 RVA: 0x00012B84 File Offset: 0x00010D84
		public bool dmethod_286(Class_103 arg_0)
		{
			return this.field_0.Contains(arg_0);
		}

		// Token: 0x0600023E RID: 574 RVA: 0x00012B9E File Offset: 0x00010D9E
		public void kmethod_287(Class_103[] arg_0, int sayıInt_0)
		{
			this.field_0.CopyTo(arg_0, sayıInt_0);
		}

		// Token: 0x0600023F RID: 575 RVA: 0x00012BB9 File Offset: 0x00010DB9
		public int lmethod_288(Class_103 arg_0)
		{
			return this.field_0.IndexOf(arg_0);
		}

		// Token: 0x06000240 RID: 576 RVA: 0x00012BD3 File Offset: 0x00010DD3
		public void pmethod_289(int sayıInt_0, Class_103 arg_0)
		{
			this.field_0.Insert(sayıInt_0, arg_0);
		}

		// Token: 0x06000241 RID: 577 RVA: 0x00012BEE File Offset: 0x00010DEE
		public bool smethod_290(Class_103 arg_0)
		{
			return this.field_0.Remove(arg_0);
		}

		// Token: 0x06000242 RID: 578 RVA: 0x00012C08 File Offset: 0x00010E08
		public void xmethod_291(int sayıInt_0)
		{
			this.field_0.RemoveAt(sayıInt_0);
		}

		// Token: 0x06000243 RID: 579 RVA: 0x00012C22 File Offset: 0x00010E22
		IEnumerator<Class_103> IEnumerable<Class_103>.tmethod_292()
		{
			return this.field_0.GetEnumerator();
		}

		// Token: 0x06000244 RID: 580 RVA: 0x00012C22 File Offset: 0x00010E22
		IEnumerator IEnumerable.gmethod_293()
		{
			return this.field_0.GetEnumerator();
		}

		// Token: 0x06000245 RID: 581 RVA: 0x00012C40 File Offset: 0x00010E40
		public virtual void cmethod_294(Stream stream_, bool bool_0)
		{
			if (stream_ == null)
			{
				throw new ArgumentNullException("stream");
			}
			stream_.WriteByte(91);
			for (int i = 0; i < this.field_0.Count; i++)
			{
				Class_103 class_ = this.field_0[i];
				if (class_ != null)
				{
					class_.smethod_330(stream_, bool_0);
				}
				else
				{
					stream_.WriteByte(110);
					stream_.WriteByte(117);
					stream_.WriteByte(108);
					stream_.WriteByte(108);
				}
				if (i < this.prop_1 - 1)
				{
					stream_.WriteByte(44);
					stream_.WriteByte(32);
				}
			}
			stream_.WriteByte(93);
		}

		// Token: 0x04000181 RID: 385
		private new List<Class_103> field_0;
	}
}
