using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json
{
	// Token: 0x020001FC RID: 508
	public class Class_381 : Class_285, Class_353
	{
		// Token: 0x14000008 RID: 8
		// (add) Token: 0x06000F2B RID: 3883 RVA: 0x0004E0C4 File Offset: 0x0004C2C4
		// (remove) Token: 0x06000F2C RID: 3884 RVA: 0x0004E0FC File Offset: 0x0004C2FC
		public event Class_439 ValidationEventHandler
		{
			add
			{
				Class_439 class_ = this.field_5;
				Class_439 class_2;
				do
				{
					class_2 = class_;
					Class_439 value2 = (Class_439)Delegate.Combine(class_2, value);
					class_ = Interlocked.CompareExchange<Class_439>(ref this.field_5, value2, class_2);
				}
				while (class_ != class_2);
			}
			remove
			{
				Class_439 class_ = this.field_5;
				Class_439 class_2;
				do
				{
					class_2 = class_;
					Class_439 value2 = (Class_439)Delegate.Remove(class_2, value);
					class_ = Interlocked.CompareExchange<Class_439>(ref this.field_5, value2, class_2);
				}
				while (class_ != class_2);
			}
		}

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x06000F2D RID: 3885 RVA: 0x0004E131 File Offset: 0x0004C331
		public virtual object prop_0
		{
			get
			{
				return this.field_0.prop_10;
			}
		}

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x06000F2E RID: 3886 RVA: 0x0004E13E File Offset: 0x0004C33E
		public virtual int prop_1
		{
			get
			{
				return this.field_0.prop_12;
			}
		}

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x06000F2F RID: 3887 RVA: 0x0004E14B File Offset: 0x0004C34B
		public virtual string prop_2
		{
			get
			{
				return this.field_0.prop_13;
			}
		}

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x06000F30 RID: 3888 RVA: 0x0004E158 File Offset: 0x0004C358
		// (set) Token: 0x06000F31 RID: 3889 RVA: 0x00002050 File Offset: 0x00000250
		public virtual char prop_3
		{
			get
			{
				return this.field_0.prop_3;
			}
			protected internal set
			{
			}
		}

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x06000F32 RID: 3890 RVA: 0x0004E165 File Offset: 0x0004C365
		public virtual Class_508 prop_4
		{
			get
			{
				return this.field_0.prop_9;
			}
		}

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x06000F33 RID: 3891 RVA: 0x0004E172 File Offset: 0x0004C372
		public virtual Type prop_5
		{
			get
			{
				return this.field_0.prop_11;
			}
		}

		// Token: 0x06000F34 RID: 3892 RVA: 0x0004E17F File Offset: 0x0004C37F
		private void vmethod_2755(Class_381.NClass_0 arg_0)
		{
			this.field_1.Push(arg_0);
			this.field_4 = arg_0;
		}

		// Token: 0x06000F35 RID: 3893 RVA: 0x0004E194 File Offset: 0x0004C394
		private Class_381.NClass_0 dmethod_2756()
		{
			Class_381.NClass_0 result = this.field_1.Pop();
			this.field_4 = ((this.field_1.Count != 0) ? this.field_1.Peek() : null);
			return result;
		}

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x06000F36 RID: 3894 RVA: 0x0004E1D5 File Offset: 0x0004C3D5
		private new IList<Class_431> prop_6
		{
			get
			{
				return this.field_4.nprop_5;
			}
		}

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x06000F37 RID: 3895 RVA: 0x0004E1E4 File Offset: 0x0004C3E4
		private new IList<Class_431> prop_7
		{
			get
			{
				if (this.field_4 == null)
				{
					return new List<Class_431>(new Class_431[]
					{
						this.field_3
					});
				}
				if (this.field_4.nprop_5 == null || this.field_4.nprop_5.Count == 0)
				{
					return Class_381.field_6;
				}
				switch (this.field_4.nprop_7)
				{
				case Class_428.None:
					return this.field_4.nprop_5;
				case Class_428.Object:
				{
					if (this.field_4.nprop_0 == null)
					{
						throw new Class_414("CurrentPropertyName has not been set on scope.");
					}
					IList<Class_431> list = new List<Class_431>();
					foreach (Class_431 class_ in this.prop_6)
					{
						Class_431 item;
						if (class_.prop_13 != null && class_.prop_13.TryGetValue(this.field_4.nprop_0, out item))
						{
							list.Add(item);
						}
						if (class_.prop_14 != null)
						{
							foreach (KeyValuePair<string, Class_431> keyValuePair in class_.prop_14)
							{
								if (Regex.IsMatch(this.field_4.nprop_0, keyValuePair.Key))
								{
									list.Add(keyValuePair.Value);
								}
							}
						}
						if (list.Count == 0 && class_.prop_18 && class_.prop_15 != null)
						{
							list.Add(class_.prop_15);
						}
					}
					return list;
				}
				case Class_428.Array:
				{
					IList<Class_431> list2 = new List<Class_431>();
					foreach (Class_431 class_2 in this.prop_6)
					{
						if (!class_2.prop_17)
						{
							if (class_2.prop_12 != null && class_2.prop_12.Count > 0)
							{
								list2.Add(class_2.prop_12[0]);
							}
						}
						else
						{
							if (class_2.prop_12 != null && class_2.prop_12.Count > 0 && class_2.prop_12.Count > this.field_4.nprop_1 - 1)
							{
								list2.Add(class_2.prop_12[this.field_4.nprop_1 - 1]);
							}
							if (class_2.prop_19 && class_2.prop_16 != null)
							{
								list2.Add(class_2.prop_16);
							}
						}
					}
					return list2;
				}
				case Class_428.Constructor:
					return Class_381.field_6;
				default:
					throw new ArgumentOutOfRangeException("TokenType", "Unexpected token type: {0}".FormatWith(CultureInfo.InvariantCulture, this.field_4.nprop_7));
				}
			}
		}

		// Token: 0x06000F38 RID: 3896 RVA: 0x0004E500 File Offset: 0x0004C700
		private void pmethod_2759(string str_0, Class_431 arg_0)
		{
			string str_ = ((Class_353)this).lmethod_2368() ? (str_0 + " Line {0}, position {1}.".FormatWith(CultureInfo.InvariantCulture, ((Class_353)this).prop_0, ((Class_353)this).prop_1)) : str_0;
			this.smethod_2760(new Class_430(str_, null, this.prop_13, ((Class_353)this).prop_0, ((Class_353)this).prop_1));
		}

		// Token: 0x06000F39 RID: 3897 RVA: 0x0004E56C File Offset: 0x0004C76C
		private void smethod_2760(Class_430 arg_0)
		{
			Class_439 class_ = this.field_5;
			if (class_ != null)
			{
				class_(this, new Class_438(arg_0));
				return;
			}
			throw arg_0;
		}

		// Token: 0x06000F3A RID: 3898 RVA: 0x0004E595 File Offset: 0x0004C795
		public Class_381(Class_285 arg_0)
		{
			Class_517.ArgumentNotNull(arg_0, "reader");
			this.field_0 = arg_0;
			this.field_1 = new Stack<Class_381.NClass_0>();
		}

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x06000F3B RID: 3899 RVA: 0x0004E5BA File Offset: 0x0004C7BA
		// (set) Token: 0x06000F3C RID: 3900 RVA: 0x0004E5C2 File Offset: 0x0004C7C2
		public new Class_459 prop_8
		{
			get
			{
				return this.field_2;
			}
			set
			{
				if (this.prop_9 != Class_508.None)
				{
					throw new InvalidOperationException("Cannot change schema while validating JSON.");
				}
				this.field_2 = value;
				this.field_3 = null;
			}
		}

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x06000F3D RID: 3901 RVA: 0x0004E5E8 File Offset: 0x0004C7E8
		public new Class_285 prop_9
		{
			get
			{
				return this.field_0;
			}
		}

		// Token: 0x06000F3E RID: 3902 RVA: 0x0004E5F0 File Offset: 0x0004C7F0
		private void cmethod_2764(Class_431 arg_0)
		{
			if (arg_0 == null)
			{
				return;
			}
			Class_463? class_ = this.vmethod_2765();
			if (class_ != null && Class_462.gmethod_3823(new Class_463?(arg_0.prop_22), class_.Value))
			{
				this.pmethod_2759("Type {0} is disallowed.".FormatWith(CultureInfo.InvariantCulture, class_), arg_0);
			}
		}

		// Token: 0x06000F3F RID: 3903 RVA: 0x0004E650 File Offset: 0x0004C850
		private Class_463? vmethod_2765()
		{
			switch (this.field_0.prop_9)
			{
			case Class_508.StartObject:
				return new Class_463?(Class_463.Object);
			case Class_508.StartArray:
				return new Class_463?(Class_463.Array);
			case Class_508.Integer:
				return new Class_463?(Class_463.Integer);
			case Class_508.Float:
				return new Class_463?(Class_463.Float);
			case Class_508.String:
				return new Class_463?(Class_463.String);
			case Class_508.Boolean:
				return new Class_463?(Class_463.Boolean);
			case Class_508.Null:
				return new Class_463?(Class_463.Null);
			}
			return null;
		}

		// Token: 0x06000F40 RID: 3904 RVA: 0x0004E6E0 File Offset: 0x0004C8E0
		public virtual int? dmethod_2766()
		{
			int? result = this.field_0.dmethod_1886();
			this.gmethod_2773();
			return result;
		}

		// Token: 0x06000F41 RID: 3905 RVA: 0x0004E700 File Offset: 0x0004C900
		public virtual byte[] kmethod_2767()
		{
			byte[] result = this.field_0.lmethod_1888();
			this.gmethod_2773();
			return result;
		}

		// Token: 0x06000F42 RID: 3906 RVA: 0x0004E720 File Offset: 0x0004C920
		public virtual decimal? lmethod_2768()
		{
			decimal? result = this.field_0.pmethod_1889();
			this.gmethod_2773();
			return result;
		}

		// Token: 0x06000F43 RID: 3907 RVA: 0x0004E740 File Offset: 0x0004C940
		public virtual string pmethod_2769()
		{
			string result = this.field_0.kmethod_1887();
			this.gmethod_2773();
			return result;
		}

		// Token: 0x06000F44 RID: 3908 RVA: 0x0004E760 File Offset: 0x0004C960
		public virtual DateTime? smethod_2770()
		{
			DateTime? result = this.field_0.smethod_1890();
			this.gmethod_2773();
			return result;
		}

		// Token: 0x06000F45 RID: 3909 RVA: 0x0004E780 File Offset: 0x0004C980
		public virtual DateTimeOffset? xmethod_2771()
		{
			DateTimeOffset? result = this.field_0.xmethod_1891();
			this.gmethod_2773();
			return result;
		}

		// Token: 0x06000F46 RID: 3910 RVA: 0x0004E7A0 File Offset: 0x0004C9A0
		public virtual bool tmethod_2772()
		{
			if (!this.field_0.vmethod_1885())
			{
				return false;
			}
			if (this.field_0.prop_9 == Class_508.Comment)
			{
				return true;
			}
			this.gmethod_2773();
			return true;
		}

		// Token: 0x06000F47 RID: 3911 RVA: 0x0004E7D0 File Offset: 0x0004C9D0
		private void gmethod_2773()
		{
			if (this.field_3 == null)
			{
				Class_432 class_ = new Class_432();
				this.field_3 = class_.tmethod_3502(this.field_2);
				if (!Class_486.IsStartToken(this.field_0.prop_9))
				{
					this.vmethod_2755(new Class_381.NClass_0(Class_428.None, this.prop_7));
				}
			}
			switch (this.field_0.prop_9)
			{
			case Class_508.None:
				return;
			case Class_508.StartObject:
			{
				this.xmethod_2781();
				IList<Class_431> arg_ = this.prop_7.Where(new Func<Class_431, bool>(this.lmethod_2788)).ToList<Class_431>();
				this.vmethod_2755(new Class_381.NClass_0(Class_428.Object, arg_));
				this.cmethod_2774(this.prop_6);
				return;
			}
			case Class_508.StartArray:
			{
				this.xmethod_2781();
				IList<Class_431> arg_2 = this.prop_7.Where(new Func<Class_431, bool>(this.kmethod_2787)).ToList<Class_431>();
				this.vmethod_2755(new Class_381.NClass_0(Class_428.Array, arg_2));
				this.cmethod_2774(this.prop_6);
				return;
			}
			case Class_508.StartConstructor:
				this.xmethod_2781();
				this.vmethod_2755(new Class_381.NClass_0(Class_428.Constructor, null));
				this.cmethod_2774(this.prop_6);
				return;
			case Class_508.PropertyName:
				this.cmethod_2774(this.prop_6);
				using (IEnumerator<Class_431> enumerator = this.prop_6.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						Class_431 arg_3 = enumerator.Current;
						this.vmethod_2785(arg_3);
					}
					return;
				}
				break;
			case Class_508.Comment:
				goto IL_3F9;
			case Class_508.Raw:
				break;
			case Class_508.Integer:
				this.xmethod_2781();
				this.cmethod_2774(this.prop_7);
				using (IEnumerator<Class_431> enumerator2 = this.prop_7.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						Class_431 arg_4 = enumerator2.Current;
						this.smethod_2780(arg_4);
					}
					return;
				}
				goto IL_1E8;
			case Class_508.Float:
				goto IL_1E8;
			case Class_508.String:
				goto IL_23A;
			case Class_508.Boolean:
				goto IL_28C;
			case Class_508.Null:
				goto IL_2DE;
			case Class_508.Undefined:
			case Class_508.Date:
			case Class_508.Bytes:
				this.cmethod_2774(this.prop_7);
				return;
			case Class_508.EndObject:
				goto IL_330;
			case Class_508.EndArray:
				this.cmethod_2774(this.prop_6);
				foreach (Class_431 arg_5 in this.prop_6)
				{
					this.dmethod_2776(arg_5);
				}
				this.dmethod_2756();
				return;
			case Class_508.EndConstructor:
				this.cmethod_2774(this.prop_6);
				this.dmethod_2756();
				return;
			default:
				goto IL_3F9;
			}
			this.xmethod_2781();
			return;
			IL_1E8:
			this.xmethod_2781();
			this.cmethod_2774(this.prop_7);
			using (IEnumerator<Class_431> enumerator4 = this.prop_7.GetEnumerator())
			{
				while (enumerator4.MoveNext())
				{
					Class_431 arg_6 = enumerator4.Current;
					this.tmethod_2782(arg_6);
				}
				return;
			}
			IL_23A:
			this.xmethod_2781();
			this.cmethod_2774(this.prop_7);
			using (IEnumerator<Class_431> enumerator5 = this.prop_7.GetEnumerator())
			{
				while (enumerator5.MoveNext())
				{
					Class_431 arg_7 = enumerator5.Current;
					this.pmethod_2779(arg_7);
				}
				return;
			}
			IL_28C:
			this.xmethod_2781();
			this.cmethod_2774(this.prop_7);
			using (IEnumerator<Class_431> enumerator6 = this.prop_7.GetEnumerator())
			{
				while (enumerator6.MoveNext())
				{
					Class_431 arg_8 = enumerator6.Current;
					this.lmethod_2778(arg_8);
				}
				return;
			}
			IL_2DE:
			this.xmethod_2781();
			this.cmethod_2774(this.prop_7);
			using (IEnumerator<Class_431> enumerator7 = this.prop_7.GetEnumerator())
			{
				while (enumerator7.MoveNext())
				{
					Class_431 arg_9 = enumerator7.Current;
					this.kmethod_2777(arg_9);
				}
				return;
			}
			IL_330:
			this.cmethod_2774(this.prop_6);
			foreach (Class_431 arg_10 in this.prop_6)
			{
				this.vmethod_2775(arg_10);
			}
			this.dmethod_2756();
			return;
			IL_3F9:
			throw new ArgumentOutOfRangeException();
		}

		// Token: 0x06000F48 RID: 3912 RVA: 0x0004EC40 File Offset: 0x0004CE40
		private void cmethod_2774(IList<Class_431> arg_0)
		{
			foreach (Class_381.NClass_0 nclass_ in this.field_1)
			{
				bool flag = nclass_.nprop_7 == Class_428.Array && nclass_.nprop_2 && nclass_.nprop_1 > 0;
				if (!flag)
				{
					if (Class_381.field_7 == null)
					{
						Class_381.field_7 = new Func<Class_431, bool>(Class_381.gmethod_2793);
					}
					if (!arg_0.Any(Class_381.field_7))
					{
						continue;
					}
				}
				if (nclass_.nprop_4 == null)
				{
					if (Class_486.IsEndToken(this.field_0.prop_9))
					{
						continue;
					}
					nclass_.nprop_4 = new Class_426();
				}
				nclass_.nprop_4.kmethod_2017(this.field_0, false);
				if (nclass_.nprop_4.prop_1 == 0 && this.field_0.prop_9 != Class_508.PropertyName)
				{
					Class_361 class_ = nclass_.nprop_4.prop_1;
					nclass_.nprop_4 = null;
					if (flag)
					{
						if (nclass_.nprop_3.Contains(class_, Class_361.prop_0))
						{
							string str_ = "Non-unique array item at index {0}.".FormatWith(CultureInfo.InvariantCulture, nclass_.nprop_1 - 1);
							IEnumerable<Class_431> source = nclass_.nprop_5;
							if (Class_381.field_8 == null)
							{
								Class_381.field_8 = new Func<Class_431, bool>(Class_381.cmethod_2794);
							}
							this.pmethod_2759(str_, source.First(Class_381.field_8));
						}
						nclass_.nprop_3.Add(class_);
					}
					else
					{
						if (Class_381.field_9 == null)
						{
							Class_381.field_9 = new Func<Class_431, bool>(Class_381.vmethod_2795);
						}
						if (arg_0.Any(Class_381.field_9))
						{
							foreach (Class_431 class_2 in arg_0)
							{
								if (class_2.prop_21 != null && !class_2.prop_21.ContainsValue(class_, Class_361.prop_0))
								{
									StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture);
									class_.cmethod_2474(new Class_412(stringWriter), new Class_299[0]);
									this.pmethod_2759("Value {0} is not defined in enum.".FormatWith(CultureInfo.InvariantCulture, stringWriter.ToString()), class_2);
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000F49 RID: 3913 RVA: 0x0004EEBC File Offset: 0x0004D0BC
		private void vmethod_2775(Class_431 arg_0)
		{
			if (arg_0 == null)
			{
				return;
			}
			Dictionary<string, bool> dictionary = this.field_4.nprop_6;
			if (dictionary != null)
			{
				IEnumerable<KeyValuePair<string, bool>> source = dictionary;
				if (Class_381.field_10 == null)
				{
					Class_381.field_10 = new Func<KeyValuePair<string, bool>, bool>(Class_381.dmethod_2796);
				}
				IEnumerable<KeyValuePair<string, bool>> source2 = source.Where(Class_381.field_10);
				if (Class_381.field_11 == null)
				{
					Class_381.field_11 = new Func<KeyValuePair<string, bool>, string>(Class_381.kmethod_2797);
				}
				List<string> list = source2.Select(Class_381.field_11).ToList<string>();
				if (list.Count > 0)
				{
					this.pmethod_2759("Required properties are missing from object: {0}.".FormatWith(CultureInfo.InvariantCulture, string.Join(", ", list.ToArray())), arg_0);
				}
			}
		}

		// Token: 0x06000F4A RID: 3914 RVA: 0x0004EF68 File Offset: 0x0004D168
		private void dmethod_2776(Class_431 arg_0)
		{
			if (arg_0 == null)
			{
				return;
			}
			int num = this.field_4.nprop_1;
			if (arg_0.prop_10 != null && num > arg_0.prop_10)
			{
				this.pmethod_2759("Array item count {0} exceeds maximum count of {1}.".FormatWith(CultureInfo.InvariantCulture, num, arg_0.prop_10), arg_0);
			}
			if (arg_0.prop_9 != null && num < arg_0.prop_9)
			{
				this.pmethod_2759("Array item count {0} is less than minimum count of {1}.".FormatWith(CultureInfo.InvariantCulture, num, arg_0.prop_9), arg_0);
			}
		}

		// Token: 0x06000F4B RID: 3915 RVA: 0x0004F050 File Offset: 0x0004D250
		private void kmethod_2777(Class_431 arg_0)
		{
			if (arg_0 == null)
			{
				return;
			}
			if (!this.pmethod_2789(arg_0, Class_463.Null))
			{
				return;
			}
			this.cmethod_2764(arg_0);
		}

		// Token: 0x06000F4C RID: 3916 RVA: 0x0004F06F File Offset: 0x0004D26F
		private void lmethod_2778(Class_431 arg_0)
		{
			if (arg_0 == null)
			{
				return;
			}
			if (!this.pmethod_2789(arg_0, Class_463.Boolean))
			{
				return;
			}
			this.cmethod_2764(arg_0);
		}

		// Token: 0x06000F4D RID: 3917 RVA: 0x0004F090 File Offset: 0x0004D290
		private void pmethod_2779(Class_431 arg_0)
		{
			if (arg_0 == null)
			{
				return;
			}
			if (!this.pmethod_2789(arg_0, Class_463.String))
			{
				return;
			}
			this.cmethod_2764(arg_0);
			string text = this.field_0.prop_10.ToString();
			if (arg_0.prop_3 != null && text.Length > arg_0.prop_3)
			{
				this.pmethod_2759("String '{0}' exceeds maximum length of {1}.".FormatWith(CultureInfo.InvariantCulture, text, arg_0.prop_3), arg_0);
			}
			if (arg_0.prop_2 != null && text.Length < arg_0.prop_2)
			{
				this.pmethod_2759("String '{0}' is less than minimum length of {1}.".FormatWith(CultureInfo.InvariantCulture, text, arg_0.prop_2), arg_0);
			}
			if (arg_0.prop_11 != null)
			{
				foreach (string text2 in arg_0.prop_11)
				{
					if (!Regex.IsMatch(text, text2))
					{
						this.pmethod_2759("String '{0}' does not match regex pattern '{1}'.".FormatWith(CultureInfo.InvariantCulture, text, text2), arg_0);
					}
				}
			}
		}

		// Token: 0x06000F4E RID: 3918 RVA: 0x0004F20C File Offset: 0x0004D40C
		private void smethod_2780(Class_431 arg_0)
		{
			if (arg_0 == null)
			{
				return;
			}
			if (!this.pmethod_2789(arg_0, Class_463.Integer))
			{
				return;
			}
			this.cmethod_2764(arg_0);
			object obj = this.field_0.prop_10;
			if (arg_0.prop_6 != null)
			{
				if (Class_362.xmethod_2591(Class_428.Integer, obj, arg_0.prop_6) > 0)
				{
					this.pmethod_2759("Integer {0} exceeds maximum value of {1}.".FormatWith(CultureInfo.InvariantCulture, obj, arg_0.prop_6), arg_0);
				}
				if (arg_0.prop_8 && Class_362.xmethod_2591(Class_428.Integer, obj, arg_0.prop_6) == 0)
				{
					this.pmethod_2759("Integer {0} equals maximum value of {1} and exclusive maximum is true.".FormatWith(CultureInfo.InvariantCulture, obj, arg_0.prop_6), arg_0);
				}
			}
			if (arg_0.prop_5 != null)
			{
				if (Class_362.xmethod_2591(Class_428.Integer, obj, arg_0.prop_5) < 0)
				{
					this.pmethod_2759("Integer {0} is less than minimum value of {1}.".FormatWith(CultureInfo.InvariantCulture, obj, arg_0.prop_5), arg_0);
				}
				if (arg_0.prop_7 && Class_362.xmethod_2591(Class_428.Integer, obj, arg_0.prop_5) == 0)
				{
					this.pmethod_2759("Integer {0} equals minimum value of {1} and exclusive minimum is true.".FormatWith(CultureInfo.InvariantCulture, obj, arg_0.prop_5), arg_0);
				}
			}
			if (arg_0.prop_4 != null)
			{
				bool flag2;
				if (obj is BigInteger)
				{
					BigInteger bigInteger = (BigInteger)obj;
					bool flag = !Math.Abs(arg_0.prop_4.Value - Math.Truncate(arg_0.prop_4.Value)).Equals(0.0);
					if (flag)
					{
						flag2 = (bigInteger != 0L);
					}
					else
					{
						flag2 = (bigInteger % new BigInteger(arg_0.prop_4.Value) != 0L);
					}
				}
				else
				{
					flag2 = !Class_381.cmethod_2784((double)Convert.ToInt64(obj, CultureInfo.InvariantCulture) % arg_0.prop_4.Value);
				}
				if (flag2)
				{
					this.pmethod_2759("Integer {0} is not evenly divisible by {1}.".FormatWith(CultureInfo.InvariantCulture, Class_416.ToString(obj), arg_0.prop_4), arg_0);
				}
			}
		}

		// Token: 0x06000F4F RID: 3919 RVA: 0x0004F460 File Offset: 0x0004D660
		private void xmethod_2781()
		{
			if (this.field_4 != null && this.field_4.nprop_7 == Class_428.Array)
			{
				this.field_4.nprop_1++;
				foreach (Class_431 class_ in this.prop_6)
				{
					if (class_ != null && class_.prop_17 && !class_.prop_19 && (class_.prop_12 == null || this.field_4.nprop_1 - 1 >= class_.prop_12.Count))
					{
						this.pmethod_2759("Index {0} has not been defined and the schema does not allow additional items.".FormatWith(CultureInfo.InvariantCulture, this.field_4.nprop_1), class_);
					}
				}
			}
		}

		// Token: 0x06000F50 RID: 3920 RVA: 0x0004F548 File Offset: 0x0004D748
		private void tmethod_2782(Class_431 arg_0)
		{
			if (arg_0 == null)
			{
				return;
			}
			if (!this.pmethod_2789(arg_0, Class_463.Float))
			{
				return;
			}
			this.cmethod_2764(arg_0);
			double num = Convert.ToDouble(this.field_0.prop_10, CultureInfo.InvariantCulture);
			if (arg_0.prop_6 != null)
			{
				double num2 = num;
				double? num3 = arg_0.prop_6;
				if (num2 > num3.GetValueOrDefault() && num3 != null)
				{
					this.pmethod_2759("Float {0} exceeds maximum value of {1}.".FormatWith(CultureInfo.InvariantCulture, Class_416.ToString(num), arg_0.prop_6), arg_0);
				}
				if (arg_0.prop_8)
				{
					double num4 = num;
					double? num5 = arg_0.prop_6;
					if (num4 == num5.GetValueOrDefault() && num5 != null)
					{
						this.pmethod_2759("Float {0} equals maximum value of {1} and exclusive maximum is true.".FormatWith(CultureInfo.InvariantCulture, Class_416.ToString(num), arg_0.prop_6), arg_0);
					}
				}
			}
			if (arg_0.prop_5 != null)
			{
				double num6 = num;
				double? num7 = arg_0.prop_5;
				if (num6 < num7.GetValueOrDefault() && num7 != null)
				{
					this.pmethod_2759("Float {0} is less than minimum value of {1}.".FormatWith(CultureInfo.InvariantCulture, Class_416.ToString(num), arg_0.prop_5), arg_0);
				}
				if (arg_0.prop_7)
				{
					double num8 = num;
					double? num9 = arg_0.prop_5;
					if (num8 == num9.GetValueOrDefault() && num9 != null)
					{
						this.pmethod_2759("Float {0} equals minimum value of {1} and exclusive minimum is true.".FormatWith(CultureInfo.InvariantCulture, Class_416.ToString(num), arg_0.prop_5), arg_0);
					}
				}
			}
			if (arg_0.prop_4 != null)
			{
				double double_ = Class_381.gmethod_2783(num, arg_0.prop_4.Value);
				if (!Class_381.cmethod_2784(double_))
				{
					this.pmethod_2759("Float {0} is not evenly divisible by {1}.".FormatWith(CultureInfo.InvariantCulture, Class_416.ToString(num), arg_0.prop_4), arg_0);
				}
			}
		}

		// Token: 0x06000F51 RID: 3921 RVA: 0x0004F76B File Offset: 0x0004D96B
		private static double gmethod_2783(double double_0, double double_1)
		{
			return double_0 - Math.Floor(double_0 / double_1) * double_1;
		}

		// Token: 0x06000F52 RID: 3922 RVA: 0x0004F779 File Offset: 0x0004D979
		private static bool cmethod_2784(double double_0)
		{
			return Math.Abs(double_0) < 4.4408920985006262E-15;
		}

		// Token: 0x06000F53 RID: 3923 RVA: 0x0004F78C File Offset: 0x0004D98C
		private void vmethod_2785(Class_431 arg_0)
		{
			if (arg_0 == null)
			{
				return;
			}
			string text = Convert.ToString(this.field_0.prop_10, CultureInfo.InvariantCulture);
			if (this.field_4.nprop_6.ContainsKey(text))
			{
				this.field_4.nprop_6[text] = true;
			}
			if (!arg_0.prop_18 && !this.dmethod_2786(arg_0, text))
			{
				this.pmethod_2759("Property '{0}' has not been defined and the schema does not allow additional properties.".FormatWith(CultureInfo.InvariantCulture, text), arg_0);
			}
			this.field_4.nprop_0 = text;
		}

		// Token: 0x06000F54 RID: 3924 RVA: 0x0004F81C File Offset: 0x0004DA1C
		private bool dmethod_2786(Class_431 arg_0, string str_0)
		{
			if (arg_0.prop_13 != null && arg_0.prop_13.ContainsKey(str_0))
			{
				return true;
			}
			if (arg_0.prop_14 != null)
			{
				foreach (string pattern in arg_0.prop_14.Keys)
				{
					if (Regex.IsMatch(str_0, pattern))
					{
						return true;
					}
				}
				return false;
			}
			return false;
		}

		// Token: 0x06000F55 RID: 3925 RVA: 0x0004F8B0 File Offset: 0x0004DAB0
		private bool kmethod_2787(Class_431 arg_0)
		{
			return arg_0 == null || this.pmethod_2789(arg_0, Class_463.Array);
		}

		// Token: 0x06000F56 RID: 3926 RVA: 0x0004F8C3 File Offset: 0x0004DAC3
		private bool lmethod_2788(Class_431 arg_0)
		{
			return arg_0 == null || this.pmethod_2789(arg_0, Class_463.Object);
		}

		// Token: 0x06000F57 RID: 3927 RVA: 0x0004F8D8 File Offset: 0x0004DAD8
		private bool pmethod_2789(Class_431 arg_0, Class_463 arg_1)
		{
			if (!Class_462.gmethod_3823(new Class_463?(arg_0.prop_1), arg_1))
			{
				this.pmethod_2759("Invalid type. Expected {0} but got {1}.".FormatWith(CultureInfo.InvariantCulture, arg_0.prop_1, arg_1), arg_0);
				return false;
			}
			return true;
		}

		// Token: 0x06000F58 RID: 3928 RVA: 0x0004F928 File Offset: 0x0004DB28
		bool Class_353.smethod_2790()
		{
			Class_353 class_ = this.field_0 as Class_353;
			return class_ != null && class_.lmethod_2368();
		}

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x06000F59 RID: 3929 RVA: 0x0004F950 File Offset: 0x0004DB50
		int Class_353.prop_10
		{
			get
			{
				Class_353 class_ = this.field_0 as Class_353;
				if (class_ == null)
				{
					return 0;
				}
				return class_.prop_0;
			}
		}

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x06000F5A RID: 3930 RVA: 0x0004F978 File Offset: 0x0004DB78
		int Class_353.prop_11
		{
			get
			{
				Class_353 class_ = this.field_0 as Class_353;
				if (class_ == null)
				{
					return 0;
				}
				return class_.prop_1;
			}
		}

		// Token: 0x06000F5B RID: 3931 RVA: 0x0004F99F File Offset: 0x0004DB9F
		[CompilerGenerated]
		private static bool gmethod_2793(Class_431 arg_0)
		{
			return arg_0.prop_21 != null;
		}

		// Token: 0x06000F5C RID: 3932 RVA: 0x0004F9AD File Offset: 0x0004DBAD
		[CompilerGenerated]
		private static bool cmethod_2794(Class_431 arg_0)
		{
			return arg_0.prop_20;
		}

		// Token: 0x06000F5D RID: 3933 RVA: 0x0004F99F File Offset: 0x0004DB9F
		[CompilerGenerated]
		private static bool vmethod_2795(Class_431 arg_0)
		{
			return arg_0.prop_21 != null;
		}

		// Token: 0x06000F5E RID: 3934 RVA: 0x0004F9B5 File Offset: 0x0004DBB5
		[CompilerGenerated]
		private static bool dmethod_2796(KeyValuePair<string, bool> arg_0)
		{
			return !arg_0.Value;
		}

		// Token: 0x06000F5F RID: 3935 RVA: 0x0004F9C1 File Offset: 0x0004DBC1
		[CompilerGenerated]
		private static string kmethod_2797(KeyValuePair<string, bool> arg_0)
		{
			return arg_0.Key;
		}

		// Token: 0x0400093B RID: 2363
		private readonly Class_285 field_0;

		// Token: 0x0400093C RID: 2364
		private readonly Stack<Class_381.NClass_0> field_1;

		// Token: 0x0400093D RID: 2365
		private new Class_459 field_2;

		// Token: 0x0400093E RID: 2366
		private new Class_431 field_3;

		// Token: 0x0400093F RID: 2367
		private new Class_381.NClass_0 field_4;

		// Token: 0x04000940 RID: 2368
		private Class_439 field_5;

		// Token: 0x04000941 RID: 2369
		private static readonly IList<Class_431> field_6 = new List<Class_431>();

		// Token: 0x04000942 RID: 2370
		[CompilerGenerated]
		private static Func<Class_431, bool> field_7;

		// Token: 0x04000943 RID: 2371
		[CompilerGenerated]
		private static Func<Class_431, bool> field_8;

		// Token: 0x04000944 RID: 2372
		[CompilerGenerated]
		private static Func<Class_431, bool> field_9;

		// Token: 0x04000945 RID: 2373
		[CompilerGenerated]
		private new static Func<KeyValuePair<string, bool>, bool> field_10;

		// Token: 0x04000946 RID: 2374
		[CompilerGenerated]
		private new static Func<KeyValuePair<string, bool>, string> field_11;

		// Token: 0x020001FD RID: 509
		private new class NClass_0
		{
			// Token: 0x1700032E RID: 814
			// (get) Token: 0x06000F61 RID: 3937 RVA: 0x0004F9D6 File Offset: 0x0004DBD6
			// (set) Token: 0x06000F62 RID: 3938 RVA: 0x0004F9DE File Offset: 0x0004DBDE
			public string nprop_0 { get; set; }

			// Token: 0x1700032F RID: 815
			// (get) Token: 0x06000F63 RID: 3939 RVA: 0x0004F9E7 File Offset: 0x0004DBE7
			// (set) Token: 0x06000F64 RID: 3940 RVA: 0x0004F9EF File Offset: 0x0004DBEF
			public int nprop_1 { get; set; }

			// Token: 0x17000330 RID: 816
			// (get) Token: 0x06000F65 RID: 3941 RVA: 0x0004F9F8 File Offset: 0x0004DBF8
			// (set) Token: 0x06000F66 RID: 3942 RVA: 0x0004FA00 File Offset: 0x0004DC00
			public bool nprop_2 { get; set; }

			// Token: 0x17000331 RID: 817
			// (get) Token: 0x06000F67 RID: 3943 RVA: 0x0004FA09 File Offset: 0x0004DC09
			// (set) Token: 0x06000F68 RID: 3944 RVA: 0x0004FA11 File Offset: 0x0004DC11
			public IList<Class_361> nprop_3 { get; set; }

			// Token: 0x17000332 RID: 818
			// (get) Token: 0x06000F69 RID: 3945 RVA: 0x0004FA1A File Offset: 0x0004DC1A
			// (set) Token: 0x06000F6A RID: 3946 RVA: 0x0004FA22 File Offset: 0x0004DC22
			public Class_426 nprop_4 { get; set; }

			// Token: 0x17000333 RID: 819
			// (get) Token: 0x06000F6B RID: 3947 RVA: 0x0004FA2B File Offset: 0x0004DC2B
			public IList<Class_431> nprop_5
			{
				get
				{
					return this.field_53;
				}
			}

			// Token: 0x17000334 RID: 820
			// (get) Token: 0x06000F6C RID: 3948 RVA: 0x0004FA33 File Offset: 0x0004DC33
			public Dictionary<string, bool> nprop_6
			{
				get
				{
					return this.field_54;
				}
			}

			// Token: 0x17000335 RID: 821
			// (get) Token: 0x06000F6D RID: 3949 RVA: 0x0004FA3B File Offset: 0x0004DC3B
			public Class_428 nprop_7
			{
				get
				{
					return this.field_52;
				}
			}

			// Token: 0x06000F6E RID: 3950 RVA: 0x0004FA44 File Offset: 0x0004DC44
			public void nmethod_13(Class_428 arg_0, IList<Class_431> arg_1)
			{
				base..ctor();
				this.field_52 = arg_0;
				this.field_53 = arg_1;
				IEnumerable<string> source = arg_1.SelectMany(new Func<Class_431, IEnumerable<string>>(this.nmethod_14)).Distinct<string>();
				if (Class_381.NClass_0.field_60 == null)
				{
					Class_381.NClass_0.field_60 = new Func<string, string>(Class_381.NClass_0.nmethod_15);
				}
				Func<string, string> keySelector = Class_381.NClass_0.field_60;
				if (Class_381.NClass_0.field_61 == null)
				{
					Class_381.NClass_0.field_61 = new Func<string, bool>(Class_381.NClass_0.nmethod_16);
				}
				this.field_54 = source.ToDictionary(keySelector, Class_381.NClass_0.field_61);
				if (arg_0 == Class_428.Array)
				{
					if (Class_381.NClass_0.field_62 == null)
					{
						Class_381.NClass_0.field_62 = new Func<Class_431, bool>(Class_381.NClass_0.nmethod_17);
					}
					if (arg_1.Any(Class_381.NClass_0.field_62))
					{
						this.nprop_2 = true;
						this.nprop_3 = new List<Class_361>();
					}
				}
			}

			// Token: 0x06000F6F RID: 3951 RVA: 0x0004FB0C File Offset: 0x0004DD0C
			private IEnumerable<string> nmethod_14(Class_431 arg_0)
			{
				if (arg_0 == null || arg_0.prop_13 == null)
				{
					return Enumerable.Empty<string>();
				}
				IEnumerable<KeyValuePair<string, Class_431>> source = arg_0.prop_13;
				if (Class_381.NClass_0.field_63 == null)
				{
					Class_381.NClass_0.field_63 = new Func<KeyValuePair<string, Class_431>, bool>(Class_381.NClass_0.nmethod_18);
				}
				IEnumerable<KeyValuePair<string, Class_431>> source2 = source.Where(Class_381.NClass_0.field_63);
				if (Class_381.NClass_0.field_64 == null)
				{
					Class_381.NClass_0.field_64 = new Func<KeyValuePair<string, Class_431>, string>(Class_381.NClass_0.nmethod_19);
				}
				return source2.Select(Class_381.NClass_0.field_64);
			}

			// Token: 0x06000F70 RID: 3952 RVA: 0x0004FB80 File Offset: 0x0004DD80
			[CompilerGenerated]
			private static string nmethod_15(string str_0)
			{
				return str_0;
			}

			// Token: 0x06000F71 RID: 3953 RVA: 0x00018464 File Offset: 0x00016664
			[CompilerGenerated]
			private static bool nmethod_16(string str_0)
			{
				return false;
			}

			// Token: 0x06000F72 RID: 3954 RVA: 0x0004F9AD File Offset: 0x0004DBAD
			[CompilerGenerated]
			private static bool nmethod_17(Class_431 arg_0)
			{
				return arg_0.prop_20;
			}

			// Token: 0x06000F73 RID: 3955 RVA: 0x0004FB83 File Offset: 0x0004DD83
			[CompilerGenerated]
			private static bool nmethod_18(KeyValuePair<string, Class_431> arg_0)
			{
				return arg_0.Value.prop_0;
			}

			// Token: 0x06000F74 RID: 3956 RVA: 0x0004FB91 File Offset: 0x0004DD91
			[CompilerGenerated]
			private static string nmethod_19(KeyValuePair<string, Class_431> arg_0)
			{
				return arg_0.Key;
			}

			// Token: 0x04000947 RID: 2375
			private readonly Class_428 field_52;

			// Token: 0x04000948 RID: 2376
			private readonly IList<Class_431> field_53;

			// Token: 0x04000949 RID: 2377
			private readonly Dictionary<string, bool> field_54;

			// Token: 0x0400094A RID: 2378
			[CompilerGenerated]
			private string field_55;

			// Token: 0x0400094B RID: 2379
			[CompilerGenerated]
			private int field_56;

			// Token: 0x0400094C RID: 2380
			[CompilerGenerated]
			private bool field_57;

			// Token: 0x0400094D RID: 2381
			[CompilerGenerated]
			private IList<Class_361> field_58;

			// Token: 0x0400094E RID: 2382
			[CompilerGenerated]
			private Class_426 field_59;

			// Token: 0x0400094F RID: 2383
			[CompilerGenerated]
			private static Func<string, string> field_60;

			// Token: 0x04000950 RID: 2384
			[CompilerGenerated]
			private static Func<string, bool> field_61;

			// Token: 0x04000951 RID: 2385
			[CompilerGenerated]
			private static Func<Class_431, bool> field_62;

			// Token: 0x04000952 RID: 2386
			[CompilerGenerated]
			private static Func<KeyValuePair<string, Class_431>, bool> field_63;

			// Token: 0x04000953 RID: 2387
			[CompilerGenerated]
			private static Func<KeyValuePair<string, Class_431>, string> field_64;
		}
	}
}
