using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Threading;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x0200022D RID: 557
	public abstract class Class_420 : Class_361, IEnumerable, IEnumerable<Class_361>, IList<Class_361>, ICollection<Class_361>, ITypedList, IList, ICollection, IBindingList, INotifyCollectionChanged
	{
		// Token: 0x1400000A RID: 10
		// (add) Token: 0x060011C0 RID: 4544 RVA: 0x0005789F File Offset: 0x00055A9F
		// (remove) Token: 0x060011C1 RID: 4545 RVA: 0x000578B8 File Offset: 0x00055AB8
		public event ListChangedEventHandler ListChanged
		{
			add
			{
				this.field_0 = (ListChangedEventHandler)Delegate.Combine(this.field_0, value);
			}
			remove
			{
				this.field_0 = (ListChangedEventHandler)Delegate.Remove(this.field_0, value);
			}
		}

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x060011C2 RID: 4546 RVA: 0x000578D1 File Offset: 0x00055AD1
		// (remove) Token: 0x060011C3 RID: 4547 RVA: 0x000578EA File Offset: 0x00055AEA
		public event AddingNewEventHandler AddingNew
		{
			add
			{
				this.field_1 = (AddingNewEventHandler)Delegate.Combine(this.field_1, value);
			}
			remove
			{
				this.field_1 = (AddingNewEventHandler)Delegate.Remove(this.field_1, value);
			}
		}

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x060011C4 RID: 4548 RVA: 0x00057903 File Offset: 0x00055B03
		// (remove) Token: 0x060011C5 RID: 4549 RVA: 0x0005791C File Offset: 0x00055B1C
		public event NotifyCollectionChangedEventHandler CollectionChanged
		{
			add
			{
				this.field_2 = (NotifyCollectionChangedEventHandler)Delegate.Combine(this.field_2, value);
			}
			remove
			{
				this.field_2 = (NotifyCollectionChangedEventHandler)Delegate.Remove(this.field_2, value);
			}
		}

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x060011C6 RID: 4550
		protected new abstract IList<Class_361> prop_0 { get; }

		// Token: 0x060011C7 RID: 4551 RVA: 0x00057935 File Offset: 0x00055B35
		internal Class_420()
		{
		}

		// Token: 0x060011C8 RID: 4552 RVA: 0x00057940 File Offset: 0x00055B40
		internal Class_420(Class_420 arg_0) : this()
		{
			Class_517.ArgumentNotNull(arg_0, "c");
			int num = 0;
			foreach (Class_361 obje_ in ((IEnumerable<Class_361>)arg_0))
			{
				this.xmethod_3221(num, obje_, false);
				num++;
			}
		}

		// Token: 0x060011C9 RID: 4553 RVA: 0x000579AC File Offset: 0x00055BAC
		internal void smethod_3190()
		{
			if (this.field_4)
			{
				throw new InvalidOperationException("Cannot change {0} during a collection change event.".FormatWith(CultureInfo.InvariantCulture, base.GetType()));
			}
		}

		// Token: 0x060011CA RID: 4554 RVA: 0x000579D4 File Offset: 0x00055BD4
		internal virtual IList<Class_361> xmethod_3191()
		{
			return new List<Class_361>();
		}

		// Token: 0x060011CB RID: 4555 RVA: 0x000579DC File Offset: 0x00055BDC
		protected virtual void tmethod_3192(AddingNewEventArgs arg_0)
		{
			AddingNewEventHandler addingNewEventHandler = this.field_1;
			if (addingNewEventHandler != null)
			{
				addingNewEventHandler(this, arg_0);
			}
		}

		// Token: 0x060011CC RID: 4556 RVA: 0x00057A00 File Offset: 0x00055C00
		protected virtual void gmethod_3193(ListChangedEventArgs arg_0)
		{
			ListChangedEventHandler listChangedEventHandler = this.field_0;
			if (listChangedEventHandler != null)
			{
				this.field_4 = true;
				try
				{
					listChangedEventHandler(this, arg_0);
				}
				finally
				{
					this.field_4 = false;
				}
			}
		}

		// Token: 0x060011CD RID: 4557 RVA: 0x00057A48 File Offset: 0x00055C48
		protected virtual void cmethod_3194(NotifyCollectionChangedEventArgs arg_0)
		{
			NotifyCollectionChangedEventHandler notifyCollectionChangedEventHandler = this.field_2;
			if (notifyCollectionChangedEventHandler != null)
			{
				this.field_4 = true;
				try
				{
					notifyCollectionChangedEventHandler(this, arg_0);
				}
				finally
				{
					this.field_4 = false;
				}
			}
		}

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x060011CE RID: 4558 RVA: 0x00057A90 File Offset: 0x00055C90
		public virtual bool prop_1
		{
			get
			{
				return this.prop_0.Count > 0;
			}
		}

		// Token: 0x060011CF RID: 4559 RVA: 0x00057AA0 File Offset: 0x00055CA0
		internal bool dmethod_3196(Class_420 arg_0)
		{
			if (arg_0 == this)
			{
				return true;
			}
			IList<Class_361> list = this.prop_0;
			IList<Class_361> list2 = arg_0.prop_0;
			if (list.Count != list2.Count)
			{
				return false;
			}
			for (int i = 0; i < list.Count; i++)
			{
				if (!list[i].lmethod_2448(list2[i]))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x060011D0 RID: 4560 RVA: 0x00057B06 File Offset: 0x00055D06
		public virtual Class_361 prop_2
		{
			get
			{
				return this.prop_0.FirstOrDefault<Class_361>();
			}
		}

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x060011D1 RID: 4561 RVA: 0x00057B13 File Offset: 0x00055D13
		public virtual Class_361 prop_3
		{
			get
			{
				return this.prop_0.LastOrDefault<Class_361>();
			}
		}

		// Token: 0x060011D2 RID: 4562 RVA: 0x00057B20 File Offset: 0x00055D20
		public virtual Class_422<Class_361> pmethod_3199()
		{
			return new Class_422<Class_361>(this.prop_0);
		}

		// Token: 0x060011D3 RID: 4563 RVA: 0x00057B2D File Offset: 0x00055D2D
		public virtual IEnumerable<T> smethod_3200<T>()
		{
			return this.prop_0.Convert<Class_361, T>();
		}

		// Token: 0x060011D4 RID: 4564 RVA: 0x00057B3A File Offset: 0x00055D3A
		public IEnumerable<Class_361> xmethod_3201()
		{
			return this.gmethod_3203(false);
		}

		// Token: 0x060011D5 RID: 4565 RVA: 0x00057B43 File Offset: 0x00055D43
		public IEnumerable<Class_361> tmethod_3202()
		{
			return this.gmethod_3203(true);
		}

		// Token: 0x060011D6 RID: 4566 RVA: 0x00057B4C File Offset: 0x00055D4C
		internal IEnumerable<Class_361> gmethod_3203(bool bool_0)
		{
			if (bool_0)
			{
				yield return this;
			}
			foreach (Class_361 class_ in this.prop_0)
			{
				yield return class_;
				Class_420 class_2 = class_ as Class_420;
				if (class_2 != null)
				{
					foreach (Class_361 class_3 in class_2.xmethod_3201())
					{
						yield return class_3;
					}
				}
			}
			yield break;
		}

		// Token: 0x060011D7 RID: 4567 RVA: 0x00057B70 File Offset: 0x00055D70
		internal bool cmethod_3204(object obje_0)
		{
			return obje_0 is IEnumerable && !(obje_0 is string) && !(obje_0 is Class_361) && !(obje_0 is byte[]);
		}

		// Token: 0x060011D8 RID: 4568 RVA: 0x00057BA4 File Offset: 0x00055DA4
		internal Class_361 vmethod_3205(Class_361 arg_0, bool bool_0)
		{
			if (arg_0 == null)
			{
				return Class_362.kmethod_2597();
			}
			if (bool_0)
			{
				return arg_0;
			}
			if (arg_0.prop_1 != null || arg_0 == this || (arg_0.prop_4 && base.prop_2 == arg_0))
			{
				arg_0 = arg_0.kmethod_2447();
			}
			return arg_0;
		}

		// Token: 0x060011D9 RID: 4569 RVA: 0x00057BF7 File Offset: 0x00055DF7
		internal int dmethod_3206(Class_361 arg_0)
		{
			return this.prop_0.IndexOf(arg_0, Class_420.NClass_0.field_30);
		}

		// Token: 0x060011DA RID: 4570 RVA: 0x00057C0C File Offset: 0x00055E0C
		internal virtual void kmethod_3207(int sayıInt_0, Class_361 arg_0, bool bool_0)
		{
			if (sayıInt_0 > this.prop_0.Count)
			{
				throw new ArgumentOutOfRangeException("index", "Index must be within the bounds of the List.");
			}
			this.smethod_3190();
			arg_0 = this.vmethod_3205(arg_0, bool_0);
			Class_361 class_ = (sayıInt_0 == 0) ? null : this.prop_0[sayıInt_0 - 1];
			Class_361 class_2 = (sayıInt_0 == this.prop_0.Count) ? null : this.prop_0[sayıInt_0];
			this.kmethod_3217(arg_0, null);
			arg_0.prop_1 = this;
			arg_0.prop_6 = class_;
			if (class_ != null)
			{
				class_.prop_5 = arg_0;
			}
			arg_0.prop_5 = class_2;
			if (class_2 != null)
			{
				class_2.prop_6 = arg_0;
			}
			this.prop_0.Insert(sayıInt_0, arg_0);
			if (this.field_0 != null)
			{
				this.gmethod_3193(new ListChangedEventArgs(ListChangedType.ItemAdded, sayıInt_0));
			}
			if (this.field_2 != null)
			{
				this.cmethod_3194(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, arg_0, sayıInt_0));
			}
		}

		// Token: 0x060011DB RID: 4571 RVA: 0x00057D00 File Offset: 0x00055F00
		internal virtual void lmethod_3208(int sayıInt_0)
		{
			if (sayıInt_0 < 0)
			{
				throw new ArgumentOutOfRangeException("index", "Index is less than 0.");
			}
			if (sayıInt_0 >= this.prop_0.Count)
			{
				throw new ArgumentOutOfRangeException("index", "Index is equal to or greater than Count.");
			}
			this.smethod_3190();
			Class_361 class_ = this.prop_0[sayıInt_0];
			Class_361 class_2 = (sayıInt_0 == 0) ? null : this.prop_0[sayıInt_0 - 1];
			Class_361 class_3 = (sayıInt_0 == this.prop_0.Count - 1) ? null : this.prop_0[sayıInt_0 + 1];
			if (class_2 != null)
			{
				class_2.prop_5 = class_3;
			}
			if (class_3 != null)
			{
				class_3.prop_6 = class_2;
			}
			class_.prop_1 = null;
			class_.prop_6 = null;
			class_.prop_5 = null;
			this.prop_0.RemoveAt(sayıInt_0);
			if (this.field_0 != null)
			{
				this.gmethod_3193(new ListChangedEventArgs(ListChangedType.ItemDeleted, sayıInt_0));
			}
			if (this.field_2 != null)
			{
				this.cmethod_3194(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, class_, sayıInt_0));
			}
		}

		// Token: 0x060011DC RID: 4572 RVA: 0x00057E08 File Offset: 0x00056008
		internal virtual bool pmethod_3209(Class_361 arg_0)
		{
			int num = this.dmethod_3206(arg_0);
			if (num >= 0)
			{
				this.lmethod_3208(num);
				return true;
			}
			return false;
		}

		// Token: 0x060011DD RID: 4573 RVA: 0x00057E2E File Offset: 0x0005602E
		internal virtual Class_361 smethod_3210(int sayıInt_0)
		{
			return this.prop_0[sayıInt_0];
		}

		// Token: 0x060011DE RID: 4574 RVA: 0x00057E3C File Offset: 0x0005603C
		internal virtual void xmethod_3211(int sayıInt_0, Class_361 arg_0)
		{
			if (sayıInt_0 < 0)
			{
				throw new ArgumentOutOfRangeException("index", "Index is less than 0.");
			}
			if (sayıInt_0 >= this.prop_0.Count)
			{
				throw new ArgumentOutOfRangeException("index", "Index is equal to or greater than Count.");
			}
			Class_361 class_ = this.prop_0[sayıInt_0];
			if (Class_420.dmethod_3216(class_, arg_0))
			{
				return;
			}
			this.smethod_3190();
			arg_0 = this.vmethod_3205(arg_0, false);
			this.kmethod_3217(arg_0, class_);
			Class_361 class_2 = (sayıInt_0 == 0) ? null : this.prop_0[sayıInt_0 - 1];
			Class_361 class_3 = (sayıInt_0 == this.prop_0.Count - 1) ? null : this.prop_0[sayıInt_0 + 1];
			arg_0.prop_1 = this;
			arg_0.prop_6 = class_2;
			if (class_2 != null)
			{
				class_2.prop_5 = arg_0;
			}
			arg_0.prop_5 = class_3;
			if (class_3 != null)
			{
				class_3.prop_6 = arg_0;
			}
			this.prop_0[sayıInt_0] = arg_0;
			class_.prop_1 = null;
			class_.prop_6 = null;
			class_.prop_5 = null;
			if (this.field_0 != null)
			{
				this.gmethod_3193(new ListChangedEventArgs(ListChangedType.ItemChanged, sayıInt_0));
			}
			if (this.field_2 != null)
			{
				this.cmethod_3194(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Replace, arg_0, class_, sayıInt_0));
			}
		}

		// Token: 0x060011DF RID: 4575 RVA: 0x00057F7C File Offset: 0x0005617C
		internal virtual void tmethod_3212()
		{
			this.smethod_3190();
			foreach (Class_361 class_ in this.prop_0)
			{
				class_.prop_1 = null;
				class_.prop_6 = null;
				class_.prop_5 = null;
			}
			this.prop_0.Clear();
			if (this.field_0 != null)
			{
				this.gmethod_3193(new ListChangedEventArgs(ListChangedType.Reset, -1));
			}
			if (this.field_2 != null)
			{
				this.cmethod_3194(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
			}
		}

		// Token: 0x060011E0 RID: 4576 RVA: 0x00058020 File Offset: 0x00056220
		internal virtual void gmethod_3213(Class_361 arg_0, Class_361 arg_1)
		{
			if (arg_0 == null || arg_0.prop_1 != this)
			{
				return;
			}
			int sayıInt_ = this.dmethod_3206(arg_0);
			this.xmethod_3211(sayıInt_, arg_1);
		}

		// Token: 0x060011E1 RID: 4577 RVA: 0x00058050 File Offset: 0x00056250
		internal virtual bool cmethod_3214(Class_361 arg_0)
		{
			return this.dmethod_3206(arg_0) != -1;
		}

		// Token: 0x060011E2 RID: 4578 RVA: 0x00058060 File Offset: 0x00056260
		internal virtual void vmethod_3215(Array arg_0, int sayıInt_0)
		{
			if (arg_0 == null)
			{
				throw new ArgumentNullException("array");
			}
			if (sayıInt_0 < 0)
			{
				throw new ArgumentOutOfRangeException("arrayIndex", "arrayIndex is less than 0.");
			}
			if (sayıInt_0 >= arg_0.Length && sayıInt_0 != 0)
			{
				throw new ArgumentException("arrayIndex is equal to or greater than the length of array.");
			}
			if (this.prop_9 > arg_0.Length - sayıInt_0)
			{
				throw new ArgumentException("The number of elements in the source JObject is greater than the available space from arrayIndex to the end of the destination array.");
			}
			int num = 0;
			foreach (Class_361 value in this.prop_0)
			{
				arg_0.SetValue(value, sayıInt_0 + num);
				num++;
			}
		}

		// Token: 0x060011E3 RID: 4579 RVA: 0x00058124 File Offset: 0x00056324
		internal static bool dmethod_3216(Class_361 arg_0, Class_361 arg_1)
		{
			Class_362 class_ = arg_0 as Class_362;
			return class_ != null && ((class_.prop_3 == Class_428.Null && arg_1 == null) || class_.Equals(arg_1));
		}

		// Token: 0x060011E4 RID: 4580 RVA: 0x0005815C File Offset: 0x0005635C
		internal virtual void kmethod_3217(Class_361 arg_0, Class_361 arg_1)
		{
			Class_517.ArgumentNotNull(arg_0, "o");
			if (arg_0.prop_3 == Class_428.Property)
			{
				throw new ArgumentException("Can not add {0} to {1}.".FormatWith(CultureInfo.InvariantCulture, arg_0.GetType(), base.GetType()));
			}
		}

		// Token: 0x060011E5 RID: 4581 RVA: 0x00058196 File Offset: 0x00056396
		public virtual void lmethod_3218(object obje_0)
		{
			this.xmethod_3221(this.prop_0.Count, obje_0, false);
		}

		// Token: 0x060011E6 RID: 4582 RVA: 0x000581AB File Offset: 0x000563AB
		internal void pmethod_3219(Class_361 arg_0)
		{
			this.xmethod_3221(this.prop_0.Count, arg_0, true);
		}

		// Token: 0x060011E7 RID: 4583 RVA: 0x000581C0 File Offset: 0x000563C0
		public void smethod_3220(object obje_0)
		{
			this.xmethod_3221(0, obje_0, false);
		}

		// Token: 0x060011E8 RID: 4584 RVA: 0x000581CC File Offset: 0x000563CC
		internal void xmethod_3221(int sayıInt_0, object obje_0, bool bool_0)
		{
			if (this.cmethod_3204(obje_0))
			{
				IEnumerable enumerable = (IEnumerable)obje_0;
				int num = sayıInt_0;
				using (IEnumerator enumerator = enumerable.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						object obje_ = enumerator.Current;
						this.xmethod_3221(num, obje_, bool_0);
						num++;
					}
					return;
				}
			}
			Class_361 arg_ = Class_420.tmethod_3222(obje_0);
			this.kmethod_3207(sayıInt_0, arg_, bool_0);
		}

		// Token: 0x060011E9 RID: 4585 RVA: 0x00058254 File Offset: 0x00056454
		internal static Class_361 tmethod_3222(object obje_0)
		{
			if (obje_0 is Class_361)
			{
				return (Class_361)obje_0;
			}
			return new Class_362(obje_0);
		}

		// Token: 0x060011EA RID: 4586 RVA: 0x0005826E File Offset: 0x0005646E
		public Class_296 gmethod_3223()
		{
			return new Class_426(this);
		}

		// Token: 0x060011EB RID: 4587 RVA: 0x00058276 File Offset: 0x00056476
		public void cmethod_3224(object obje_0)
		{
			this.tmethod_3212();
			this.lmethod_3218(obje_0);
		}

		// Token: 0x060011EC RID: 4588 RVA: 0x00058285 File Offset: 0x00056485
		public void vmethod_3225()
		{
			this.tmethod_3212();
		}

		// Token: 0x060011ED RID: 4589
		internal abstract void dmethod_3226(object obje_0, Class_328 arg_0);

		// Token: 0x060011EE RID: 4590 RVA: 0x0005828D File Offset: 0x0005648D
		public void kmethod_3227(object obje_0)
		{
			this.dmethod_3226(obje_0, new Class_328());
		}

		// Token: 0x060011EF RID: 4591 RVA: 0x0005829B File Offset: 0x0005649B
		public void lmethod_3228(object obje_0, Class_328 arg_0)
		{
			this.dmethod_3226(obje_0, arg_0);
		}

		// Token: 0x060011F0 RID: 4592 RVA: 0x000582A8 File Offset: 0x000564A8
		internal void pmethod_3229(Class_285 arg_0)
		{
			int num = arg_0.prop_12;
			if (!arg_0.vmethod_1885())
			{
				throw Class_414.lmethod_3098(arg_0, "Error reading {0} from JsonReader.".FormatWith(CultureInfo.InvariantCulture, base.GetType().Name));
			}
			this.smethod_3230(arg_0);
			int num2 = arg_0.prop_12;
			if (num2 > num)
			{
				throw Class_414.lmethod_3098(arg_0, "Unexpected end of content while loading {0}.".FormatWith(CultureInfo.InvariantCulture, base.GetType().Name));
			}
		}

		// Token: 0x060011F1 RID: 4593 RVA: 0x00058320 File Offset: 0x00056520
		internal void smethod_3230(Class_285 arg_0)
		{
			Class_517.ArgumentNotNull(arg_0, "r");
			Class_353 arg_ = arg_0 as Class_353;
			Class_420 class_ = this;
			for (;;)
			{
				if (class_ is Class_427 && ((Class_427)class_).prop_2 != null)
				{
					if (class_ == this)
					{
						break;
					}
					class_ = class_.prop_1;
				}
				switch (arg_0.prop_9)
				{
				case Class_508.None:
					goto IL_22F;
				case Class_508.StartObject:
				{
					Class_423 class_2 = new Class_423();
					class_2.lmethod_2568(arg_);
					class_.lmethod_3218(class_2);
					class_ = class_2;
					goto IL_22F;
				}
				case Class_508.StartArray:
				{
					Class_424 class_3 = new Class_424();
					class_3.lmethod_2568(arg_);
					class_.lmethod_3218(class_3);
					class_ = class_3;
					goto IL_22F;
				}
				case Class_508.StartConstructor:
				{
					Class_421 class_4 = new Class_421(arg_0.prop_10.ToString());
					class_4.lmethod_2568(arg_);
					class_.lmethod_3218(class_4);
					class_ = class_4;
					goto IL_22F;
				}
				case Class_508.PropertyName:
				{
					string str_ = arg_0.prop_10.ToString();
					Class_427 class_5 = new Class_427(str_);
					class_5.lmethod_2568(arg_);
					Class_423 class_6 = (Class_423)class_;
					Class_427 class_7 = class_6.gmethod_3303(str_);
					if (class_7 == null)
					{
						class_.lmethod_3218(class_5);
					}
					else
					{
						class_7.gmethod_2473(class_5);
					}
					class_ = class_5;
					goto IL_22F;
				}
				case Class_508.Comment:
				{
					Class_362 class_8 = Class_362.vmethod_2595(arg_0.prop_10.ToString());
					class_8.lmethod_2568(arg_);
					class_.lmethod_3218(class_8);
					goto IL_22F;
				}
				case Class_508.Integer:
				case Class_508.Float:
				case Class_508.String:
				case Class_508.Boolean:
				case Class_508.Date:
				case Class_508.Bytes:
				{
					Class_362 class_8 = new Class_362(arg_0.prop_10);
					class_8.lmethod_2568(arg_);
					class_.lmethod_3218(class_8);
					goto IL_22F;
				}
				case Class_508.Null:
				{
					Class_362 class_8 = Class_362.kmethod_2597();
					class_8.lmethod_2568(arg_);
					class_.lmethod_3218(class_8);
					goto IL_22F;
				}
				case Class_508.Undefined:
				{
					Class_362 class_8 = Class_362.lmethod_2598();
					class_8.lmethod_2568(arg_);
					class_.lmethod_3218(class_8);
					goto IL_22F;
				}
				case Class_508.EndObject:
					if (class_ == this)
					{
						return;
					}
					class_ = class_.prop_1;
					goto IL_22F;
				case Class_508.EndArray:
					if (class_ == this)
					{
						return;
					}
					class_ = class_.prop_1;
					goto IL_22F;
				case Class_508.EndConstructor:
					if (class_ == this)
					{
						return;
					}
					class_ = class_.prop_1;
					goto IL_22F;
				}
				goto Block_4;
				IL_22F:
				if (!arg_0.vmethod_1885())
				{
					return;
				}
			}
			return;
			Block_4:
			throw new InvalidOperationException("The JsonReader should not be on a token of type {0}.".FormatWith(CultureInfo.InvariantCulture, arg_0.prop_9));
		}

		// Token: 0x060011F2 RID: 4594 RVA: 0x00058568 File Offset: 0x00056768
		internal int xmethod_3231()
		{
			int num = 0;
			foreach (Class_361 class_ in this.prop_0)
			{
				num ^= class_.dmethod_2556();
			}
			return num;
		}

		// Token: 0x060011F3 RID: 4595 RVA: 0x000585C4 File Offset: 0x000567C4
		string ITypedList.tmethod_3232(PropertyDescriptor[] arg_0)
		{
			return string.Empty;
		}

		// Token: 0x060011F4 RID: 4596 RVA: 0x000585CC File Offset: 0x000567CC
		PropertyDescriptorCollection ITypedList.gmethod_3233(PropertyDescriptor[] arg_0)
		{
			ICustomTypeDescriptor customTypeDescriptor = this.prop_9 as ICustomTypeDescriptor;
			if (customTypeDescriptor != null)
			{
				return customTypeDescriptor.GetProperties();
			}
			return null;
		}

		// Token: 0x060011F5 RID: 4597 RVA: 0x000585F3 File Offset: 0x000567F3
		int IList<Class_361>.cmethod_3234(Class_361 arg_0)
		{
			return this.dmethod_3206(arg_0);
		}

		// Token: 0x060011F6 RID: 4598 RVA: 0x000585FC File Offset: 0x000567FC
		void IList<Class_361>.vmethod_3235(int sayıInt_0, Class_361 arg_0)
		{
			this.kmethod_3207(sayıInt_0, arg_0, false);
		}

		// Token: 0x060011F7 RID: 4599 RVA: 0x00058607 File Offset: 0x00056807
		void IList<Class_361>.dmethod_3236(int sayıInt_0)
		{
			this.lmethod_3208(sayıInt_0);
		}

		// Token: 0x170003C8 RID: 968
		Class_361 IList<Class_361>.this[int sayıInt_0]
		{
			get
			{
				return this.smethod_3210(sayıInt_0);
			}
			set
			{
				this.xmethod_3211(sayıInt_0, value);
			}
		}

		// Token: 0x060011FA RID: 4602 RVA: 0x00058623 File Offset: 0x00056823
		void ICollection<Class_361>.pmethod_3239(Class_361 arg_0)
		{
			this.lmethod_3218(arg_0);
		}

		// Token: 0x060011FB RID: 4603 RVA: 0x00058285 File Offset: 0x00056485
		void ICollection<Class_361>.smethod_3240()
		{
			this.tmethod_3212();
		}

		// Token: 0x060011FC RID: 4604 RVA: 0x0005862C File Offset: 0x0005682C
		bool ICollection<Class_361>.xmethod_3241(Class_361 arg_0)
		{
			return this.cmethod_3214(arg_0);
		}

		// Token: 0x060011FD RID: 4605 RVA: 0x00058635 File Offset: 0x00056835
		void ICollection<Class_361>.tmethod_3242(Class_361[] arg_0, int sayıInt_0)
		{
			this.vmethod_3215(arg_0, sayıInt_0);
		}

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x060011FE RID: 4606 RVA: 0x00018464 File Offset: 0x00016664
		bool ICollection<Class_361>.prop_5
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060011FF RID: 4607 RVA: 0x0005863F File Offset: 0x0005683F
		bool ICollection<Class_361>.cmethod_3244(Class_361 arg_0)
		{
			return this.pmethod_3209(arg_0);
		}

		// Token: 0x06001200 RID: 4608 RVA: 0x00058648 File Offset: 0x00056848
		private Class_361 vmethod_3245(object obje_0)
		{
			if (obje_0 == null)
			{
				return null;
			}
			if (obje_0 is Class_361)
			{
				return (Class_361)obje_0;
			}
			throw new ArgumentException("Argument is not a JToken.");
		}

		// Token: 0x06001201 RID: 4609 RVA: 0x0005866E File Offset: 0x0005686E
		int IList.dmethod_3246(object obje_0)
		{
			this.lmethod_3218(this.vmethod_3245(obje_0));
			return this.prop_9 - 1;
		}

		// Token: 0x06001202 RID: 4610 RVA: 0x00058285 File Offset: 0x00056485
		void IList.kmethod_3247()
		{
			this.tmethod_3212();
		}

		// Token: 0x06001203 RID: 4611 RVA: 0x00058685 File Offset: 0x00056885
		bool IList.lmethod_3248(object obje_0)
		{
			return this.cmethod_3214(this.vmethod_3245(obje_0));
		}

		// Token: 0x06001204 RID: 4612 RVA: 0x00058694 File Offset: 0x00056894
		int IList.pmethod_3249(object obje_0)
		{
			return this.dmethod_3206(this.vmethod_3245(obje_0));
		}

		// Token: 0x06001205 RID: 4613 RVA: 0x000586A3 File Offset: 0x000568A3
		void IList.smethod_3250(int sayıInt_0, object obje_0)
		{
			this.kmethod_3207(sayıInt_0, this.vmethod_3245(obje_0), false);
		}

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x06001206 RID: 4614 RVA: 0x00018464 File Offset: 0x00016664
		bool IList.prop_6
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x06001207 RID: 4615 RVA: 0x00018464 File Offset: 0x00016664
		bool IList.prop_7
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06001208 RID: 4616 RVA: 0x000586B4 File Offset: 0x000568B4
		void IList.gmethod_3253(object obje_0)
		{
			this.pmethod_3209(this.vmethod_3245(obje_0));
		}

		// Token: 0x06001209 RID: 4617 RVA: 0x00058607 File Offset: 0x00056807
		void IList.cmethod_3254(int sayıInt_0)
		{
			this.lmethod_3208(sayıInt_0);
		}

		// Token: 0x170003CC RID: 972
		object IList.this[int sayıInt_0]
		{
			get
			{
				return this.smethod_3210(sayıInt_0);
			}
			set
			{
				this.xmethod_3211(sayıInt_0, this.vmethod_3245(value));
			}
		}

		// Token: 0x0600120C RID: 4620 RVA: 0x00058635 File Offset: 0x00056835
		void ICollection.kmethod_3257(Array arg_0, int sayıInt_0)
		{
			this.vmethod_3215(arg_0, sayıInt_0);
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x0600120D RID: 4621 RVA: 0x000586D4 File Offset: 0x000568D4
		public new int prop_9
		{
			get
			{
				return this.prop_0.Count;
			}
		}

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x0600120E RID: 4622 RVA: 0x00018464 File Offset: 0x00016664
		bool ICollection.prop_10
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x0600120F RID: 4623 RVA: 0x000586E1 File Offset: 0x000568E1
		object ICollection.prop_11
		{
			get
			{
				if (this.field_3 == null)
				{
					Interlocked.CompareExchange(ref this.field_3, new object(), null);
				}
				return this.field_3;
			}
		}

		// Token: 0x06001210 RID: 4624 RVA: 0x00002050 File Offset: 0x00000250
		void IBindingList.xmethod_3261(PropertyDescriptor arg_0)
		{
		}

		// Token: 0x06001211 RID: 4625 RVA: 0x00058708 File Offset: 0x00056908
		object IBindingList.tmethod_3262()
		{
			AddingNewEventArgs addingNewEventArgs = new AddingNewEventArgs();
			this.tmethod_3192(addingNewEventArgs);
			if (addingNewEventArgs.NewObject == null)
			{
				throw new Class_318("Could not determine new value to add to '{0}'.".FormatWith(CultureInfo.InvariantCulture, base.GetType()));
			}
			if (!(addingNewEventArgs.NewObject is Class_361))
			{
				throw new Class_318("New item to be added to collection must be compatible with {0}.".FormatWith(CultureInfo.InvariantCulture, typeof(Class_361)));
			}
			Class_361 class_ = (Class_361)addingNewEventArgs.NewObject;
			this.lmethod_3218(class_);
			return class_;
		}

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x06001212 RID: 4626 RVA: 0x00025DB5 File Offset: 0x00023FB5
		bool IBindingList.prop_12
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x06001213 RID: 4627 RVA: 0x00025DB5 File Offset: 0x00023FB5
		bool IBindingList.prop_13
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x06001214 RID: 4628 RVA: 0x00025DB5 File Offset: 0x00023FB5
		bool IBindingList.prop_14
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06001215 RID: 4629 RVA: 0x0001429B File Offset: 0x0001249B
		void IBindingList.dmethod_3266(PropertyDescriptor arg_0, ListSortDirection arg_1)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001216 RID: 4630 RVA: 0x0001429B File Offset: 0x0001249B
		int IBindingList.kmethod_3267(PropertyDescriptor arg_0, object obje_0)
		{
			throw new NotSupportedException();
		}

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x06001217 RID: 4631 RVA: 0x00018464 File Offset: 0x00016664
		bool IBindingList.prop_15
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06001218 RID: 4632 RVA: 0x00002050 File Offset: 0x00000250
		void IBindingList.pmethod_3269(PropertyDescriptor arg_0)
		{
		}

		// Token: 0x06001219 RID: 4633 RVA: 0x0001429B File Offset: 0x0001249B
		void IBindingList.smethod_3270()
		{
			throw new NotSupportedException();
		}

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x0600121A RID: 4634 RVA: 0x00018464 File Offset: 0x00016664
		ListSortDirection IBindingList.prop_16
		{
			get
			{
				return ListSortDirection.Ascending;
			}
		}

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x0600121B RID: 4635 RVA: 0x0004259A File Offset: 0x0004079A
		PropertyDescriptor IBindingList.prop_17
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x0600121C RID: 4636 RVA: 0x00025DB5 File Offset: 0x00023FB5
		bool IBindingList.prop_18
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x0600121D RID: 4637 RVA: 0x00018464 File Offset: 0x00016664
		bool IBindingList.prop_19
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x0600121E RID: 4638 RVA: 0x00018464 File Offset: 0x00016664
		bool IBindingList.prop_20
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0600121F RID: 4639 RVA: 0x0005878C File Offset: 0x0005698C
		internal static void dmethod_3276(Class_420 arg_0, IEnumerable arg_1, Class_328 arg_2)
		{
			switch (arg_2.prop_0)
			{
			case Class_342.Concat:
				using (IEnumerator enumerator = arg_1.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						object obj = enumerator.Current;
						Class_361 obje_ = (Class_361)obj;
						arg_0.lmethod_3218(obje_);
					}
					return;
				}
				break;
			case Class_342.Union:
				break;
			case Class_342.Replace:
				goto IL_C6;
			case Class_342.Merge:
				goto IL_115;
			default:
				goto IL_1D2;
			}
			HashSet<Class_361> hashSet = new HashSet<Class_361>(arg_0, Class_361.prop_0);
			using (IEnumerator enumerator2 = arg_1.GetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					object obj2 = enumerator2.Current;
					Class_361 class_ = (Class_361)obj2;
					if (hashSet.Add(class_))
					{
						arg_0.lmethod_3218(class_);
					}
				}
				return;
			}
			IL_C6:
			arg_0.tmethod_3212();
			using (IEnumerator enumerator3 = arg_1.GetEnumerator())
			{
				while (enumerator3.MoveNext())
				{
					object obj3 = enumerator3.Current;
					Class_361 obje_2 = (Class_361)obj3;
					arg_0.lmethod_3218(obje_2);
				}
				return;
			}
			IL_115:
			int num = 0;
			using (IEnumerator enumerator4 = arg_1.GetEnumerator())
			{
				while (enumerator4.MoveNext())
				{
					object obj4 = enumerator4.Current;
					if (num < arg_0.prop_9)
					{
						Class_361 class_2 = arg_0.cmethod_2464(num);
						Class_420 class_3 = class_2 as Class_420;
						if (class_3 != null)
						{
							class_3.lmethod_3228(obj4, arg_2);
						}
						else if (obj4 != null)
						{
							Class_361 class_4 = Class_420.tmethod_3222(obj4);
							if (class_4.prop_3 != Class_428.Null)
							{
								arg_0.vmethod_2465(num, class_4);
							}
						}
					}
					else
					{
						arg_0.lmethod_3218(obj4);
					}
					num++;
				}
				return;
			}
			IL_1D2:
			throw new ArgumentOutOfRangeException("settings", "Unexpected merge array handling when merging JSON.");
		}

		// Token: 0x040009EE RID: 2542
		internal ListChangedEventHandler field_0;

		// Token: 0x040009EF RID: 2543
		internal AddingNewEventHandler field_1;

		// Token: 0x040009F0 RID: 2544
		internal NotifyCollectionChangedEventHandler field_2;

		// Token: 0x040009F1 RID: 2545
		private object field_3;

		// Token: 0x040009F2 RID: 2546
		private bool field_4;

		// Token: 0x0200022E RID: 558
		private class NClass_0 : IEqualityComparer<Class_361>
		{
			// Token: 0x06001220 RID: 4640 RVA: 0x000589B0 File Offset: 0x00056BB0
			public bool nmethod_0(Class_361 arg_0, Class_361 arg_1)
			{
				return object.ReferenceEquals(arg_0, arg_1);
			}

			// Token: 0x06001221 RID: 4641 RVA: 0x000589B9 File Offset: 0x00056BB9
			public int nmethod_1(Class_361 arg_0)
			{
				if (arg_0 == null)
				{
					return 0;
				}
				return arg_0.GetHashCode();
			}

			// Token: 0x06001222 RID: 4642 RVA: 0x0000237C File Offset: 0x0000057C
			public void nmethod_2()
			{
				base..ctor();
			}

			// Token: 0x06001223 RID: 4643 RVA: 0x000589C9 File Offset: 0x00056BC9
			private static void nmethod_3()
			{
				Class_420.NClass_0.field_30 = new Class_420.NClass_0();
			}

			// Token: 0x040009F3 RID: 2547
			public static readonly Class_420.NClass_0 field_30;
		}
	}
}
