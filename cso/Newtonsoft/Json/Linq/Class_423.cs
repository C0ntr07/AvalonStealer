using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x02000232 RID: 562
	[DefaultMember("Item")]
	public class Class_423 : Class_420, IEnumerable, IDictionary<string, Class_361>, ICollection<KeyValuePair<string, Class_361>>, ICustomTypeDescriptor, INotifyPropertyChanged, INotifyPropertyChanging, IEnumerable<KeyValuePair<string, Class_361>>
	{
		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x06001247 RID: 4679 RVA: 0x00059021 File Offset: 0x00057221
		protected virtual IList<Class_361> prop_0
		{
			get
			{
				return this.field_0;
			}
		}

		// Token: 0x1400000D RID: 13
		// (add) Token: 0x06001248 RID: 4680 RVA: 0x0005902C File Offset: 0x0005722C
		// (remove) Token: 0x06001249 RID: 4681 RVA: 0x00059064 File Offset: 0x00057264
		public event PropertyChangedEventHandler PropertyChanged
		{
			add
			{
				PropertyChangedEventHandler propertyChangedEventHandler = this.field_1;
				PropertyChangedEventHandler propertyChangedEventHandler2;
				do
				{
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Combine(propertyChangedEventHandler2, value);
					propertyChangedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.field_1, value2, propertyChangedEventHandler2);
				}
				while (propertyChangedEventHandler != propertyChangedEventHandler2);
			}
			remove
			{
				PropertyChangedEventHandler propertyChangedEventHandler = this.field_1;
				PropertyChangedEventHandler propertyChangedEventHandler2;
				do
				{
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Remove(propertyChangedEventHandler2, value);
					propertyChangedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.field_1, value2, propertyChangedEventHandler2);
				}
				while (propertyChangedEventHandler != propertyChangedEventHandler2);
			}
		}

		// Token: 0x1400000E RID: 14
		// (add) Token: 0x0600124A RID: 4682 RVA: 0x0005909C File Offset: 0x0005729C
		// (remove) Token: 0x0600124B RID: 4683 RVA: 0x000590D4 File Offset: 0x000572D4
		public event PropertyChangingEventHandler PropertyChanging
		{
			add
			{
				PropertyChangingEventHandler propertyChangingEventHandler = this.field_2;
				PropertyChangingEventHandler propertyChangingEventHandler2;
				do
				{
					propertyChangingEventHandler2 = propertyChangingEventHandler;
					PropertyChangingEventHandler value2 = (PropertyChangingEventHandler)Delegate.Combine(propertyChangingEventHandler2, value);
					propertyChangingEventHandler = Interlocked.CompareExchange<PropertyChangingEventHandler>(ref this.field_2, value2, propertyChangingEventHandler2);
				}
				while (propertyChangingEventHandler != propertyChangingEventHandler2);
			}
			remove
			{
				PropertyChangingEventHandler propertyChangingEventHandler = this.field_2;
				PropertyChangingEventHandler propertyChangingEventHandler2;
				do
				{
					propertyChangingEventHandler2 = propertyChangingEventHandler;
					PropertyChangingEventHandler value2 = (PropertyChangingEventHandler)Delegate.Remove(propertyChangingEventHandler2, value);
					propertyChangingEventHandler = Interlocked.CompareExchange<PropertyChangingEventHandler>(ref this.field_2, value2, propertyChangingEventHandler2);
				}
				while (propertyChangingEventHandler != propertyChangingEventHandler2);
			}
		}

		// Token: 0x0600124C RID: 4684 RVA: 0x00059109 File Offset: 0x00057309
		public Class_423()
		{
		}

		// Token: 0x0600124D RID: 4685 RVA: 0x0005911C File Offset: 0x0005731C
		public Class_423(Class_423 arg_0) : base(arg_0)
		{
		}

		// Token: 0x0600124E RID: 4686 RVA: 0x00059130 File Offset: 0x00057330
		public Class_423(params object[] arg_0) : this(arg_0)
		{
		}

		// Token: 0x0600124F RID: 4687 RVA: 0x00059139 File Offset: 0x00057339
		public Class_423(object obje_0)
		{
			this.lmethod_3218(obje_0);
		}

		// Token: 0x06001250 RID: 4688 RVA: 0x00059154 File Offset: 0x00057354
		internal virtual bool cmethod_3294(Class_361 arg_0)
		{
			Class_423 class_ = arg_0 as Class_423;
			return class_ != null && this.field_0.tmethod_2242(class_.field_0);
		}

		// Token: 0x06001251 RID: 4689 RVA: 0x00059181 File Offset: 0x00057381
		internal virtual void vmethod_3295(int sayıInt_0, Class_361 arg_0, bool bool_0)
		{
			if (arg_0 != null && arg_0.prop_3 == Class_428.Comment)
			{
				return;
			}
			base.kmethod_3207(sayıInt_0, arg_0, bool_0);
		}

		// Token: 0x06001252 RID: 4690 RVA: 0x000591A0 File Offset: 0x000573A0
		internal virtual void dmethod_3296(Class_361 arg_0, Class_361 arg_1)
		{
			Class_517.ArgumentNotNull(arg_0, "o");
			if (arg_0.prop_3 != Class_428.Property)
			{
				throw new ArgumentException("Can not add {0} to {1}.".FormatWith(CultureInfo.InvariantCulture, arg_0.GetType(), base.GetType()));
			}
			Class_427 class_ = (Class_427)arg_0;
			if (arg_1 != null)
			{
				Class_427 class_2 = (Class_427)arg_1;
				if (class_.prop_1 == class_2.prop_1)
				{
					return;
				}
			}
			if (this.field_0.pmethod_2239(class_.prop_1, out arg_1))
			{
				throw new ArgumentException("Can not add property {0} to {1}. Property with the same name already exists on object.".FormatWith(CultureInfo.InvariantCulture, class_.prop_1, base.GetType()));
			}
		}

		// Token: 0x06001253 RID: 4691 RVA: 0x0005924C File Offset: 0x0005744C
		internal virtual void kmethod_3297(object obje_0, Class_328 arg_0)
		{
			Class_423 class_ = obje_0 as Class_423;
			if (class_ == null)
			{
				return;
			}
			using (IEnumerator<KeyValuePair<string, Class_361>> enumerator = class_.smethod_3330())
			{
				while (enumerator.MoveNext())
				{
					KeyValuePair<string, Class_361> keyValuePair = enumerator.Current;
					Class_427 class_2 = this.gmethod_3303(keyValuePair.Key);
					if (class_2 == null)
					{
						this.kmethod_3317(keyValuePair.Key, keyValuePair.Value);
					}
					else if (keyValuePair.Value != null)
					{
						Class_420 class_3 = class_2.prop_2 as Class_420;
						if (class_3 == null)
						{
							if (keyValuePair.Value.prop_3 != Class_428.Null)
							{
								class_2.prop_2 = keyValuePair.Value;
							}
						}
						else if (class_3.prop_3 != keyValuePair.Value.prop_3)
						{
							class_2.prop_2 = keyValuePair.Value;
						}
						else
						{
							class_3.lmethod_3228(keyValuePair.Value, arg_0);
						}
					}
				}
			}
		}

		// Token: 0x06001254 RID: 4692 RVA: 0x00059354 File Offset: 0x00057554
		internal void lmethod_3298(Class_427 arg_0)
		{
			this.xmethod_3331(arg_0.prop_1);
			if (this.field_0 != null)
			{
				this.gmethod_3193(new ListChangedEventArgs(ListChangedType.ItemChanged, base.dmethod_3206(arg_0)));
			}
			if (this.field_2 != null)
			{
				this.cmethod_3194(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Replace, arg_0, arg_0, base.dmethod_3206(arg_0)));
			}
		}

		// Token: 0x06001255 RID: 4693 RVA: 0x000593AB File Offset: 0x000575AB
		internal void pmethod_3299(Class_427 arg_0)
		{
			this.tmethod_3332(arg_0.prop_1);
		}

		// Token: 0x06001256 RID: 4694 RVA: 0x000593B9 File Offset: 0x000575B9
		internal virtual Class_361 smethod_3300()
		{
			return new Class_423(this);
		}

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x06001257 RID: 4695 RVA: 0x00025DB5 File Offset: 0x00023FB5
		public virtual Class_428 prop_1
		{
			get
			{
				return Class_428.Object;
			}
		}

		// Token: 0x06001258 RID: 4696 RVA: 0x000593C1 File Offset: 0x000575C1
		public IEnumerable<Class_427> tmethod_3302()
		{
			return this.field_0.Cast<Class_427>();
		}

		// Token: 0x06001259 RID: 4697 RVA: 0x000593D0 File Offset: 0x000575D0
		public Class_427 gmethod_3303(string str_0)
		{
			if (str_0 == null)
			{
				return null;
			}
			Class_361 class_;
			this.field_0.pmethod_2239(str_0, out class_);
			return (Class_427)class_;
		}

		// Token: 0x0600125A RID: 4698 RVA: 0x000593FA File Offset: 0x000575FA
		public Class_422<Class_361> cmethod_3304()
		{
			IEnumerable<Class_427> source = this.tmethod_3302();
			if (Class_423.field_3 == null)
			{
				Class_423.field_3 = new Func<Class_427, Class_361>(Class_423.dmethod_3346);
			}
			return new Class_422<Class_361>(source.Select(Class_423.field_3));
		}

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x0600125B RID: 4699 RVA: 0x0005942C File Offset: 0x0005762C
		// (set) Token: 0x0600125C RID: 4700 RVA: 0x00059474 File Offset: 0x00057674
		public virtual Class_361 prop_2
		{
			get
			{
				Class_517.ArgumentNotNull(obje_0, "o");
				string text = obje_0 as string;
				if (text == null)
				{
					throw new ArgumentException("Accessed JObject values with invalid key value: {0}. Object property name expected.".FormatWith(CultureInfo.InvariantCulture, Class_513.ToString(obje_0)));
				}
				return this.kmethod_3307(text);
			}
			set
			{
				Class_517.ArgumentNotNull(obje_0, "o");
				string text = obje_0 as string;
				if (text == null)
				{
					throw new ArgumentException("Set JObject values with invalid key value: {0}. Object property name expected.".FormatWith(CultureInfo.InvariantCulture, Class_513.ToString(obje_0)));
				}
				this.lmethod_3308(text, value);
			}
		}

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x0600125D RID: 4701 RVA: 0x000594BC File Offset: 0x000576BC
		// (set) Token: 0x0600125E RID: 4702 RVA: 0x000594EC File Offset: 0x000576EC
		public new Class_361 prop_3
		{
			get
			{
				Class_517.ArgumentNotNull(str_0, "propertyName");
				Class_427 class_ = this.gmethod_3303(str_0);
				if (class_ == null)
				{
					return null;
				}
				return class_.prop_2;
			}
			set
			{
				Class_427 class_ = this.gmethod_3303(str_0);
				if (class_ != null)
				{
					class_.prop_2 = value;
					return;
				}
				this.tmethod_3332(str_0);
				this.lmethod_3218(new Class_427(str_0, value));
				this.xmethod_3331(str_0);
			}
		}

		// Token: 0x0600125F RID: 4703 RVA: 0x0005952C File Offset: 0x0005772C
		public static Class_423 pmethod_3309(Class_285 arg_0)
		{
			Class_517.ArgumentNotNull(arg_0, "reader");
			if (arg_0.prop_9 == Class_508.None && !arg_0.vmethod_1885())
			{
				throw Class_414.lmethod_3098(arg_0, "Error reading JObject from JsonReader.");
			}
			while (arg_0.prop_9 == Class_508.Comment)
			{
				arg_0.vmethod_1885();
			}
			if (arg_0.prop_9 != Class_508.StartObject)
			{
				throw Class_414.lmethod_3098(arg_0, "Error reading JObject from JsonReader. Current JsonReader item is not an object: {0}".FormatWith(CultureInfo.InvariantCulture, arg_0.prop_9));
			}
			Class_423 class_ = new Class_423();
			class_.lmethod_2568(arg_0 as Class_353);
			class_.pmethod_3229(arg_0);
			return class_;
		}

		// Token: 0x06001260 RID: 4704 RVA: 0x000595C0 File Offset: 0x000577C0
		public static Class_423 smethod_3310(string str_0)
		{
			Class_423 result;
			using (Class_285 class_ = new Class_409(new StringReader(str_0)))
			{
				Class_423 class_2 = Class_423.pmethod_3309(class_);
				if (class_.vmethod_1885() && class_.prop_9 != Class_508.Comment)
				{
					throw Class_414.lmethod_3098(class_, "Additional text found in JSON string after parsing content.");
				}
				result = class_2;
			}
			return result;
		}

		// Token: 0x06001261 RID: 4705 RVA: 0x00059628 File Offset: 0x00057828
		public static Class_423 xmethod_3311(object obje_0)
		{
			return Class_423.tmethod_3312(obje_0, Class_418.xmethod_3161());
		}

		// Token: 0x06001262 RID: 4706 RVA: 0x00059638 File Offset: 0x00057838
		public static Class_423 tmethod_3312(object obje_0, Class_418 arg_0)
		{
			Class_361 class_ = Class_361.pmethod_2559(obje_0, arg_0);
			if (class_ != null && class_.prop_3 != Class_428.Object)
			{
				throw new ArgumentException("Object serialized to {0}. JObject instance expected.".FormatWith(CultureInfo.InvariantCulture, class_.prop_3));
			}
			return (Class_423)class_;
		}

		// Token: 0x06001263 RID: 4707 RVA: 0x00059688 File Offset: 0x00057888
		public virtual void gmethod_3313(Class_296 arg_0, params Class_299[] arg_1)
		{
			arg_0.kmethod_2007();
			for (int i = 0; i < this.field_0.Count; i++)
			{
				this.field_0[i].cmethod_2474(arg_0, arg_1);
			}
			arg_0.lmethod_2008();
		}

		// Token: 0x06001264 RID: 4708 RVA: 0x000596CD File Offset: 0x000578CD
		public Class_361 cmethod_3314(string str_0)
		{
			return this.vmethod_3315(str_0, StringComparison.Ordinal);
		}

		// Token: 0x06001265 RID: 4709 RVA: 0x000596D8 File Offset: 0x000578D8
		public Class_361 vmethod_3315(string str_0, StringComparison arg_0)
		{
			if (str_0 == null)
			{
				return null;
			}
			Class_427 class_ = this.gmethod_3303(str_0);
			if (class_ != null)
			{
				return class_.prop_2;
			}
			if (arg_0 != StringComparison.Ordinal)
			{
				foreach (Class_361 class_2 in this.field_0)
				{
					Class_427 class_3 = (Class_427)class_2;
					if (string.Equals(class_3.prop_1, str_0, arg_0))
					{
						return class_3.prop_2;
					}
				}
			}
			return null;
		}

		// Token: 0x06001266 RID: 4710 RVA: 0x00059774 File Offset: 0x00057974
		public bool dmethod_3316(string str_0, StringComparison arg_0, out Class_361 arg_1)
		{
			arg_1 = this.vmethod_3315(str_0, arg_0);
			return arg_1 != null;
		}

		// Token: 0x06001267 RID: 4711 RVA: 0x00059788 File Offset: 0x00057988
		public void kmethod_3317(string str_0, Class_361 arg_0)
		{
			this.lmethod_3218(new Class_427(str_0, arg_0));
		}

		// Token: 0x06001268 RID: 4712 RVA: 0x00059797 File Offset: 0x00057997
		bool IDictionary<string, Class_361>.lmethod_3318(string str_0)
		{
			return this.field_0.pmethod_2229(str_0);
		}

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x06001269 RID: 4713 RVA: 0x000597A5 File Offset: 0x000579A5
		ICollection<string> IDictionary<string, Class_361>.prop_4
		{
			get
			{
				return this.field_0.prop_1;
			}
		}

		// Token: 0x0600126A RID: 4714 RVA: 0x000597B4 File Offset: 0x000579B4
		public bool smethod_3320(string str_0)
		{
			Class_427 class_ = this.gmethod_3303(str_0);
			if (class_ == null)
			{
				return false;
			}
			class_.tmethod_2472();
			return true;
		}

		// Token: 0x0600126B RID: 4715 RVA: 0x000597D8 File Offset: 0x000579D8
		public bool xmethod_3321(string str_0, out Class_361 arg_0)
		{
			Class_427 class_ = this.gmethod_3303(str_0);
			if (class_ == null)
			{
				arg_0 = null;
				return false;
			}
			arg_0 = class_.prop_2;
			return true;
		}

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x0600126C RID: 4716 RVA: 0x00018443 File Offset: 0x00016643
		ICollection<Class_361> IDictionary<string, Class_361>.prop_5
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		// Token: 0x0600126D RID: 4717 RVA: 0x00059801 File Offset: 0x00057A01
		void ICollection<KeyValuePair<string, Class_361>>.gmethod_3323(KeyValuePair<string, Class_361> arg_0)
		{
			this.lmethod_3218(new Class_427(arg_0.Key, arg_0.Value));
		}

		// Token: 0x0600126E RID: 4718 RVA: 0x0005981C File Offset: 0x00057A1C
		void ICollection<KeyValuePair<string, Class_361>>.cmethod_3324()
		{
			base.vmethod_3225();
		}

		// Token: 0x0600126F RID: 4719 RVA: 0x00059824 File Offset: 0x00057A24
		bool ICollection<KeyValuePair<string, Class_361>>.vmethod_3325(KeyValuePair<string, Class_361> arg_0)
		{
			Class_427 class_ = this.gmethod_3303(arg_0.Key);
			return class_ != null && class_.prop_2 == arg_0.Value;
		}

		// Token: 0x06001270 RID: 4720 RVA: 0x00059858 File Offset: 0x00057A58
		void ICollection<KeyValuePair<string, Class_361>>.dmethod_3326(KeyValuePair<string, Class_361>[] arg_0, int sayıInt_0)
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
			if (base.prop_9 > arg_0.Length - sayıInt_0)
			{
				throw new ArgumentException("The number of elements in the source JObject is greater than the available space from arrayIndex to the end of the destination array.");
			}
			int num = 0;
			foreach (Class_361 class_ in this.field_0)
			{
				Class_427 class_2 = (Class_427)class_;
				arg_0[sayıInt_0 + num] = new KeyValuePair<string, Class_361>(class_2.prop_1, class_2.prop_2);
				num++;
			}
		}

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x06001271 RID: 4721 RVA: 0x00018464 File Offset: 0x00016664
		bool ICollection<KeyValuePair<string, Class_361>>.prop_6
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06001272 RID: 4722 RVA: 0x00059930 File Offset: 0x00057B30
		bool ICollection<KeyValuePair<string, Class_361>>.lmethod_3328(KeyValuePair<string, Class_361> arg_0)
		{
			if (!((ICollection<KeyValuePair<string, Class_361>>)this).Contains(arg_0))
			{
				return false;
			}
			((IDictionary<string, Class_361>)this).Remove(arg_0.Key);
			return true;
		}

		// Token: 0x06001273 RID: 4723 RVA: 0x0005994F File Offset: 0x00057B4F
		internal virtual int pmethod_3329()
		{
			return base.xmethod_3231();
		}

		// Token: 0x06001274 RID: 4724 RVA: 0x00059958 File Offset: 0x00057B58
		public IEnumerator<KeyValuePair<string, Class_361>> smethod_3330()
		{
			foreach (Class_361 class_ in this.field_0)
			{
				Class_427 class_2 = (Class_427)class_;
				yield return new KeyValuePair<string, Class_361>(class_2.prop_1, class_2.prop_2);
			}
			yield break;
		}

		// Token: 0x06001275 RID: 4725 RVA: 0x00059974 File Offset: 0x00057B74
		protected virtual void xmethod_3331(string str_0)
		{
			if (this.field_1 != null)
			{
				this.field_1(this, new PropertyChangedEventArgs(str_0));
			}
		}

		// Token: 0x06001276 RID: 4726 RVA: 0x00059993 File Offset: 0x00057B93
		protected virtual void tmethod_3332(string str_0)
		{
			if (this.field_2 != null)
			{
				this.field_2(this, new PropertyChangingEventArgs(str_0));
			}
		}

		// Token: 0x06001277 RID: 4727 RVA: 0x000599B2 File Offset: 0x00057BB2
		PropertyDescriptorCollection ICustomTypeDescriptor.gmethod_3333()
		{
			return ((ICustomTypeDescriptor)this).GetProperties(null);
		}

		// Token: 0x06001278 RID: 4728 RVA: 0x000599BC File Offset: 0x00057BBC
		PropertyDescriptorCollection ICustomTypeDescriptor.cmethod_3334(Attribute[] arg_0)
		{
			PropertyDescriptorCollection propertyDescriptorCollection = new PropertyDescriptorCollection(null);
			using (IEnumerator<KeyValuePair<string, Class_361>> enumerator = this.smethod_3330())
			{
				while (enumerator.MoveNext())
				{
					KeyValuePair<string, Class_361> keyValuePair = enumerator.Current;
					propertyDescriptorCollection.Add(new Class_372(keyValuePair.Key));
				}
			}
			return propertyDescriptorCollection;
		}

		// Token: 0x06001279 RID: 4729 RVA: 0x00059A24 File Offset: 0x00057C24
		AttributeCollection ICustomTypeDescriptor.vmethod_3335()
		{
			return AttributeCollection.Empty;
		}

		// Token: 0x0600127A RID: 4730 RVA: 0x0004259A File Offset: 0x0004079A
		string ICustomTypeDescriptor.dmethod_3336()
		{
			return null;
		}

		// Token: 0x0600127B RID: 4731 RVA: 0x0004259A File Offset: 0x0004079A
		string ICustomTypeDescriptor.kmethod_3337()
		{
			return null;
		}

		// Token: 0x0600127C RID: 4732 RVA: 0x00059A2B File Offset: 0x00057C2B
		TypeConverter ICustomTypeDescriptor.lmethod_3338()
		{
			return new TypeConverter();
		}

		// Token: 0x0600127D RID: 4733 RVA: 0x0004259A File Offset: 0x0004079A
		EventDescriptor ICustomTypeDescriptor.pmethod_3339()
		{
			return null;
		}

		// Token: 0x0600127E RID: 4734 RVA: 0x0004259A File Offset: 0x0004079A
		PropertyDescriptor ICustomTypeDescriptor.smethod_3340()
		{
			return null;
		}

		// Token: 0x0600127F RID: 4735 RVA: 0x0004259A File Offset: 0x0004079A
		object ICustomTypeDescriptor.xmethod_3341(Type arg_0)
		{
			return null;
		}

		// Token: 0x06001280 RID: 4736 RVA: 0x00059A32 File Offset: 0x00057C32
		EventDescriptorCollection ICustomTypeDescriptor.tmethod_3342(Attribute[] arg_0)
		{
			return EventDescriptorCollection.Empty;
		}

		// Token: 0x06001281 RID: 4737 RVA: 0x00059A32 File Offset: 0x00057C32
		EventDescriptorCollection ICustomTypeDescriptor.gmethod_3343()
		{
			return EventDescriptorCollection.Empty;
		}

		// Token: 0x06001282 RID: 4738 RVA: 0x0004259A File Offset: 0x0004079A
		object ICustomTypeDescriptor.cmethod_3344(PropertyDescriptor arg_0)
		{
			return null;
		}

		// Token: 0x06001283 RID: 4739 RVA: 0x00059A39 File Offset: 0x00057C39
		protected virtual DynamicMetaObject vmethod_3345(Expression arg_0)
		{
			return new Class_475<Class_423>(arg_0, this, new Class_423.NClass_0(), true);
		}

		// Token: 0x06001284 RID: 4740 RVA: 0x00059A48 File Offset: 0x00057C48
		[CompilerGenerated]
		private static Class_361 dmethod_3346(Class_427 arg_0)
		{
			return arg_0.prop_2;
		}

		// Token: 0x04000A03 RID: 2563
		private new readonly Class_327 field_0 = new Class_327();

		// Token: 0x04000A04 RID: 2564
		private new PropertyChangedEventHandler field_1;

		// Token: 0x04000A05 RID: 2565
		private new PropertyChangingEventHandler field_2;

		// Token: 0x04000A06 RID: 2566
		[CompilerGenerated]
		private static Func<Class_427, Class_361> field_3;

		// Token: 0x02000233 RID: 563
		private class NClass_0 : Class_359<Class_423>
		{
			// Token: 0x06001285 RID: 4741 RVA: 0x00059A50 File Offset: 0x00057C50
			public virtual bool nmethod_0(Class_423 arg_0, GetMemberBinder arg_1, out object arg_2)
			{
				arg_2 = arg_0.kmethod_3307(arg_1.Name);
				return true;
			}

			// Token: 0x06001286 RID: 4742 RVA: 0x00059A64 File Offset: 0x00057C64
			public virtual bool nmethod_1(Class_423 arg_0, SetMemberBinder arg_1, object obje_0)
			{
				Class_361 class_ = obje_0 as Class_361;
				if (class_ == null)
				{
					class_ = new Class_362(obje_0);
				}
				arg_0.lmethod_3308(arg_1.Name, class_);
				return true;
			}

			// Token: 0x06001287 RID: 4743 RVA: 0x00059A93 File Offset: 0x00057C93
			public virtual IEnumerable<string> nmethod_2(Class_423 arg_0)
			{
				IEnumerable<Class_427> source = arg_0.tmethod_3302();
				if (Class_423.NClass_0.field_2 == null)
				{
					Class_423.NClass_0.field_2 = new Func<Class_427, string>(Class_423.NClass_0.nmethod_4);
				}
				return source.Select(Class_423.NClass_0.field_2);
			}

			// Token: 0x06001288 RID: 4744 RVA: 0x00059AC0 File Offset: 0x00057CC0
			public void nmethod_3()
			{
				base..ctor();
			}

			// Token: 0x06001289 RID: 4745 RVA: 0x00059AC8 File Offset: 0x00057CC8
			[CompilerGenerated]
			private static string nmethod_4(Class_427 arg_0)
			{
				return arg_0.prop_1;
			}

			// Token: 0x04000A07 RID: 2567
			[CompilerGenerated]
			private static Func<Class_427, string> field_2;
		}
	}
}
