using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Schema
{
	// Token: 0x02000244 RID: 580
	public class Class_435
	{
		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x0600137A RID: 4986 RVA: 0x0005B9C0 File Offset: 0x00059BC0
		// (set) Token: 0x0600137B RID: 4987 RVA: 0x0005B9C8 File Offset: 0x00059BC8
		public IList<Class_459> prop_0 { get; protected set; }

		// Token: 0x0600137C RID: 4988 RVA: 0x0005B9D1 File Offset: 0x00059BD1
		public Class_435()
		{
			this.prop_0 = new List<Class_459>();
		}

		// Token: 0x0600137D RID: 4989 RVA: 0x0005B9E4 File Offset: 0x00059BE4
		public virtual Class_459 xmethod_3531(string str_0)
		{
			Class_435.NClass_0 nclass_ = new Class_435.NClass_0();
			nclass_.field_9 = str_0;
			Class_459 class_ = this.prop_0.SingleOrDefault(new Func<Class_459, bool>(nclass_.nmethod_1));
			if (class_ == null)
			{
				class_ = this.prop_0.SingleOrDefault(new Func<Class_459, bool>(nclass_.nmethod_2));
			}
			return class_;
		}

		// Token: 0x04000A57 RID: 2647
		[CompilerGenerated]
		private IList<Class_459> field_0;

		// Token: 0x02000245 RID: 581
		[CompilerGenerated]
		private sealed class NClass_0
		{
			// Token: 0x0600137E RID: 4990 RVA: 0x0000237C File Offset: 0x0000057C
			public void nmethod_0()
			{
				base..ctor();
			}

			// Token: 0x0600137F RID: 4991 RVA: 0x0005BA35 File Offset: 0x00059C35
			public bool nmethod_1(Class_459 arg_0)
			{
				return string.Equals(arg_0.prop_0, this.field_9, StringComparison.Ordinal);
			}

			// Token: 0x06001380 RID: 4992 RVA: 0x0005BA49 File Offset: 0x00059C49
			public bool nmethod_2(Class_459 arg_0)
			{
				return string.Equals(arg_0.prop_33, this.field_9, StringComparison.Ordinal);
			}

			// Token: 0x04000A58 RID: 2648
			public string field_9;
		}
	}
}
