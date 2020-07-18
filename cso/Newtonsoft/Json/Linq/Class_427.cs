using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x02000238 RID: 568
	public class Class_427 : Class_420
	{
		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x060012EC RID: 4844 RVA: 0x0005A820 File Offset: 0x00058A20
		protected virtual IList<Class_361> prop_0
		{
			get
			{
				return this.field_0;
			}
		}

		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x060012ED RID: 4845 RVA: 0x0005A828 File Offset: 0x00058A28
		public new string prop_1
		{
			[DebuggerStepThrough]
			get
			{
				return this.field_1;
			}
		}

		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x060012EE RID: 4846 RVA: 0x0005A830 File Offset: 0x00058A30
		// (set) Token: 0x060012EF RID: 4847 RVA: 0x0005A840 File Offset: 0x00058A40
		public new Class_361 prop_2
		{
			[DebuggerStepThrough]
			get
			{
				return this.field_0.field_4;
			}
			set
			{
				base.smethod_3190();
				Class_361 arg_ = value ?? Class_362.kmethod_2597();
				if (this.field_0.field_4 == null)
				{
					this.kmethod_3207(0, arg_, false);
					return;
				}
				this.xmethod_3211(0, arg_);
			}
		}

		// Token: 0x060012F0 RID: 4848 RVA: 0x0005A883 File Offset: 0x00058A83
		public Class_427(Class_427 arg_0) : base(arg_0)
		{
			this.field_1 = arg_0.prop_1;
		}

		// Token: 0x060012F1 RID: 4849 RVA: 0x0005A8A3 File Offset: 0x00058AA3
		internal virtual Class_361 cmethod_3434(int sayıInt_0)
		{
			if (sayıInt_0 != 0)
			{
				throw new ArgumentOutOfRangeException();
			}
			return this.prop_2;
		}

		// Token: 0x060012F2 RID: 4850 RVA: 0x0005A8B8 File Offset: 0x00058AB8
		internal virtual void vmethod_3435(int sayıInt_0, Class_361 arg_0)
		{
			if (sayıInt_0 != 0)
			{
				throw new ArgumentOutOfRangeException();
			}
			if (Class_420.dmethod_3216(this.prop_2, arg_0))
			{
				return;
			}
			if (base.prop_1 != null)
			{
				((Class_423)base.prop_1).pmethod_3299(this);
			}
			base.xmethod_3211(0, arg_0);
			if (base.prop_1 != null)
			{
				((Class_423)base.prop_1).lmethod_3298(this);
			}
		}

		// Token: 0x060012F3 RID: 4851 RVA: 0x0005A923 File Offset: 0x00058B23
		internal virtual bool dmethod_3436(Class_361 arg_0)
		{
			throw new Class_318("Cannot add or remove items from {0}.".FormatWith(CultureInfo.InvariantCulture, typeof(Class_427)));
		}

		// Token: 0x060012F4 RID: 4852 RVA: 0x0005A923 File Offset: 0x00058B23
		internal virtual void kmethod_3437(int sayıInt_0)
		{
			throw new Class_318("Cannot add or remove items from {0}.".FormatWith(CultureInfo.InvariantCulture, typeof(Class_427)));
		}

		// Token: 0x060012F5 RID: 4853 RVA: 0x0005A944 File Offset: 0x00058B44
		internal virtual void lmethod_3438(int sayıInt_0, Class_361 arg_0, bool bool_0)
		{
			if (arg_0 != null && arg_0.prop_3 == Class_428.Comment)
			{
				return;
			}
			if (this.prop_2 != null)
			{
				throw new Class_318("{0} cannot have multiple values.".FormatWith(CultureInfo.InvariantCulture, typeof(Class_427)));
			}
			base.kmethod_3207(0, arg_0, false);
		}

		// Token: 0x060012F6 RID: 4854 RVA: 0x0005A997 File Offset: 0x00058B97
		internal virtual bool pmethod_3439(Class_361 arg_0)
		{
			return this.prop_2 == arg_0;
		}

		// Token: 0x060012F7 RID: 4855 RVA: 0x0005A9A4 File Offset: 0x00058BA4
		internal virtual void smethod_3440(object obje_0, Class_328 arg_0)
		{
			Class_427 class_ = obje_0 as Class_427;
			if (class_ == null)
			{
				return;
			}
			if (class_.prop_2 != null && class_.prop_2.prop_3 != Class_428.Null)
			{
				this.prop_2 = class_.prop_2;
			}
		}

		// Token: 0x060012F8 RID: 4856 RVA: 0x0005A923 File Offset: 0x00058B23
		internal virtual void xmethod_3441()
		{
			throw new Class_318("Cannot add or remove items from {0}.".FormatWith(CultureInfo.InvariantCulture, typeof(Class_427)));
		}

		// Token: 0x060012F9 RID: 4857 RVA: 0x0005A9E8 File Offset: 0x00058BE8
		internal virtual bool tmethod_3442(Class_361 arg_0)
		{
			Class_427 class_ = arg_0 as Class_427;
			return class_ != null && this.field_1 == class_.prop_1 && base.dmethod_3196(class_);
		}

		// Token: 0x060012FA RID: 4858 RVA: 0x0005AA21 File Offset: 0x00058C21
		internal virtual Class_361 gmethod_3443()
		{
			return new Class_427(this);
		}

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x060012FB RID: 4859 RVA: 0x00040723 File Offset: 0x0003E923
		public virtual Class_428 prop_3
		{
			[DebuggerStepThrough]
			get
			{
				return Class_428.Property;
			}
		}

		// Token: 0x060012FC RID: 4860 RVA: 0x0005AA29 File Offset: 0x00058C29
		internal Class_427(string str_0)
		{
			Class_517.ArgumentNotNull(str_0, "name");
			this.field_1 = str_0;
		}

		// Token: 0x060012FD RID: 4861 RVA: 0x0005AA4E File Offset: 0x00058C4E
		public Class_427(string str_0, params object[] arg_0) : this(str_0, arg_0)
		{
		}

		// Token: 0x060012FE RID: 4862 RVA: 0x0005AA58 File Offset: 0x00058C58
		public Class_427(string str_0, object obje_0)
		{
			Class_517.ArgumentNotNull(str_0, "name");
			this.field_1 = str_0;
			this.prop_2 = (base.cmethod_3204(obje_0) ? new Class_424(obje_0) : Class_420.tmethod_3222(obje_0));
		}

		// Token: 0x060012FF RID: 4863 RVA: 0x0005AAAC File Offset: 0x00058CAC
		public virtual void vmethod_3445(Class_296 arg_0, params Class_299[] arg_1)
		{
			arg_0.gmethod_2013(this.field_1);
			Class_361 class_ = this.prop_2;
			if (class_ != null)
			{
				class_.cmethod_2474(arg_0, arg_1);
				return;
			}
			arg_0.gmethod_2033();
		}

		// Token: 0x06001300 RID: 4864 RVA: 0x0005AAE1 File Offset: 0x00058CE1
		internal virtual int dmethod_3446()
		{
			return this.field_1.GetHashCode() ^ ((this.prop_2 != null) ? this.prop_2.dmethod_2556() : 0);
		}

		// Token: 0x06001301 RID: 4865 RVA: 0x0005AB0C File Offset: 0x00058D0C
		public static Class_427 kmethod_3447(Class_285 arg_0)
		{
			if (arg_0.prop_9 == Class_508.None && !arg_0.vmethod_1885())
			{
				throw Class_414.lmethod_3098(arg_0, "Error reading JProperty from JsonReader.");
			}
			while (arg_0.prop_9 == Class_508.Comment)
			{
				arg_0.vmethod_1885();
			}
			if (arg_0.prop_9 != Class_508.PropertyName)
			{
				throw Class_414.lmethod_3098(arg_0, "Error reading JProperty from JsonReader. Current JsonReader item is not a property: {0}".FormatWith(CultureInfo.InvariantCulture, arg_0.prop_9));
			}
			Class_427 class_ = new Class_427((string)arg_0.prop_10);
			class_.lmethod_2568(arg_0 as Class_353);
			class_.pmethod_3229(arg_0);
			return class_;
		}

		// Token: 0x04000A16 RID: 2582
		private new readonly Class_427.NClass_0 field_0 = new Class_427.NClass_0();

		// Token: 0x04000A17 RID: 2583
		private new readonly string field_1;

		// Token: 0x02000239 RID: 569
		[DefaultMember("Item")]
		private class NClass_0 : IEnumerable, IEnumerable<Class_361>, IList<Class_361>, ICollection<Class_361>
		{
			// Token: 0x06001302 RID: 4866 RVA: 0x0005ABA0 File Offset: 0x00058DA0
			public IEnumerator<Class_361> nmethod_0()
			{
				if (this.field_4 != null)
				{
					yield return this.field_4;
				}
				yield break;
			}

			// Token: 0x06001303 RID: 4867 RVA: 0x0005ABBC File Offset: 0x00058DBC
			IEnumerator IEnumerable.nmethod_1()
			{
				return this.nmethod_0();
			}

			// Token: 0x06001304 RID: 4868 RVA: 0x0005ABC4 File Offset: 0x00058DC4
			public void nmethod_2(Class_361 arg_0)
			{
				this.field_4 = arg_0;
			}

			// Token: 0x06001305 RID: 4869 RVA: 0x0005ABCD File Offset: 0x00058DCD
			public void nmethod_3()
			{
				this.field_4 = null;
			}

			// Token: 0x06001306 RID: 4870 RVA: 0x0005ABD6 File Offset: 0x00058DD6
			public bool nmethod_4(Class_361 arg_0)
			{
				return this.field_4 == arg_0;
			}

			// Token: 0x06001307 RID: 4871 RVA: 0x0005ABE1 File Offset: 0x00058DE1
			public void nmethod_5(Class_361[] arg_0, int sayıInt_0)
			{
				if (this.field_4 != null)
				{
					arg_0[sayıInt_0] = this.field_4;
				}
			}

			// Token: 0x06001308 RID: 4872 RVA: 0x0005ABFB File Offset: 0x00058DFB
			public bool nmethod_6(Class_361 arg_0)
			{
				if (this.field_4 == arg_0)
				{
					this.field_4 = null;
					return true;
				}
				return false;
			}

			// Token: 0x170003F8 RID: 1016
			// (get) Token: 0x06001309 RID: 4873 RVA: 0x0005AC13 File Offset: 0x00058E13
			public int nprop_0
			{
				get
				{
					if (this.field_4 == null)
					{
						return 0;
					}
					return 1;
				}
			}

			// Token: 0x170003F9 RID: 1017
			// (get) Token: 0x0600130A RID: 4874 RVA: 0x00018464 File Offset: 0x00016664
			public bool nprop_1
			{
				get
				{
					return false;
				}
			}

			// Token: 0x0600130B RID: 4875 RVA: 0x0005AC23 File Offset: 0x00058E23
			public int nmethod_9(Class_361 arg_0)
			{
				if (this.field_4 != arg_0)
				{
					return -1;
				}
				return 0;
			}

			// Token: 0x0600130C RID: 4876 RVA: 0x0005AC34 File Offset: 0x00058E34
			public void nmethod_10(int sayıInt_0, Class_361 arg_0)
			{
				if (sayıInt_0 == 0)
				{
					this.field_4 = arg_0;
				}
			}

			// Token: 0x0600130D RID: 4877 RVA: 0x0005AC43 File Offset: 0x00058E43
			public void nmethod_11(int sayıInt_0)
			{
				if (sayıInt_0 == 0)
				{
					this.field_4 = null;
				}
			}

			// Token: 0x170003FA RID: 1018
			// (get) Token: 0x0600130E RID: 4878 RVA: 0x0005AC52 File Offset: 0x00058E52
			// (set) Token: 0x0600130F RID: 4879 RVA: 0x0005AC34 File Offset: 0x00058E34
			public Class_361 nprop_2
			{
				get
				{
					if (sayıInt_0 != 0)
					{
						return null;
					}
					return this.field_4;
				}
				set
				{
					if (sayıInt_0 == 0)
					{
						this.field_4 = value;
					}
				}
			}

			// Token: 0x06001310 RID: 4880 RVA: 0x0000237C File Offset: 0x0000057C
			public void nmethod_14()
			{
				base..ctor();
			}

			// Token: 0x04000A18 RID: 2584
			internal Class_361 field_4;
		}
	}
}
