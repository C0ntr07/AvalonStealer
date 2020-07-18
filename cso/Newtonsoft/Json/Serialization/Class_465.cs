using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200026B RID: 619
	internal abstract class Class_465
	{
		// Token: 0x06001503 RID: 5379 RVA: 0x00061434 File Offset: 0x0005F634
		protected Class_465(Class_418 arg_0)
		{
			Class_517.ArgumentNotNull(arg_0, "serializer");
			this.field_3 = arg_0;
			this.field_4 = arg_0.prop_2;
			this.field_2 = (base.GetType() == typeof(Class_467));
		}

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x06001504 RID: 5380 RVA: 0x00061480 File Offset: 0x0005F680
		internal Class_495<string, object> prop_0
		{
			get
			{
				if (this.field_1 == null)
				{
					this.field_1 = new Class_495<string, object>(EqualityComparer<string>.Default, new Class_465.NClass_0(), "A different value already has the Id '{0}'.", "A different Id has already been assigned for value '{0}'.");
				}
				return this.field_1;
			}
		}

		// Token: 0x06001505 RID: 5381 RVA: 0x000614B2 File Offset: 0x0005F6B2
		private Class_446 lmethod_3848(object obje_0, object obje_1, string str_0, Exception arg_0)
		{
			if (this.field_0 == null)
			{
				this.field_0 = new Class_446(obje_0, obje_1, str_0, arg_0);
			}
			if (this.field_0.prop_1 != arg_0)
			{
				throw new InvalidOperationException("Current error context error is different to requested error.");
			}
			return this.field_0;
		}

		// Token: 0x06001506 RID: 5382 RVA: 0x000614F2 File Offset: 0x0005F6F2
		protected void pmethod_3849()
		{
			if (this.field_0 == null)
			{
				throw new InvalidOperationException("Could not clear error context. Error context is already null.");
			}
			this.field_0 = null;
		}

		// Token: 0x06001507 RID: 5383 RVA: 0x00061514 File Offset: 0x0005F714
		protected bool smethod_3850(object obje_0, Class_349 arg_0, object obje_1, Class_353 arg_1, string str_0, Exception arg_2)
		{
			Class_446 class_ = this.lmethod_3848(obje_0, obje_1, str_0, arg_2);
			if (this.field_4 != null && this.field_4.prop_0 >= TraceLevel.Error && !class_.prop_0)
			{
				class_.prop_0 = true;
				string text = this.field_2 ? "Error serializing" : "Error deserializing";
				if (arg_0 != null)
				{
					text = text + " " + arg_0.prop_0;
				}
				text = text + ". " + arg_2.Message;
				if (!(arg_2 is Class_318))
				{
					text = Class_326.FormatMessage(arg_1, str_0, text);
				}
				this.field_4.gmethod_2303(TraceLevel.Error, text, arg_2);
			}
			if (arg_0 != null && obje_0 != null)
			{
				arg_0.kmethod_2347(obje_0, this.field_3.prop_15, class_);
			}
			if (!class_.prop_5)
			{
				this.field_3.tmethod_3182(new Class_371(obje_0, class_));
			}
			return class_.prop_5;
		}

		// Token: 0x04000B3C RID: 2876
		private Class_446 field_0;

		// Token: 0x04000B3D RID: 2877
		private Class_495<string, object> field_1;

		// Token: 0x04000B3E RID: 2878
		private bool field_2;

		// Token: 0x04000B3F RID: 2879
		internal readonly Class_418 field_3;

		// Token: 0x04000B40 RID: 2880
		internal readonly Class_344 field_4;

		// Token: 0x0200026C RID: 620
		private class NClass_0 : IEqualityComparer<object>
		{
			// Token: 0x06001508 RID: 5384 RVA: 0x000589B0 File Offset: 0x00056BB0
			bool IEqualityComparer<object>.nmethod_0(object obje_0, object obje_1)
			{
				return object.ReferenceEquals(obje_0, obje_1);
			}

			// Token: 0x06001509 RID: 5385 RVA: 0x0006160A File Offset: 0x0005F80A
			int IEqualityComparer<object>.nmethod_1(object obje_0)
			{
				return RuntimeHelpers.GetHashCode(obje_0);
			}

			// Token: 0x0600150A RID: 5386 RVA: 0x0000237C File Offset: 0x0000057C
			public void nmethod_2()
			{
				base..ctor();
			}
		}
	}
}
