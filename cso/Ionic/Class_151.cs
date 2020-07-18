using System;
using System.Text;
using Ionic.Zip;

namespace Ionic
{
	// Token: 0x020000BE RID: 190
	internal class Class_151 : Class_145
	{
		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000379 RID: 889 RVA: 0x000171C3 File Offset: 0x000153C3
		// (set) Token: 0x0600037A RID: 890 RVA: 0x000171CB File Offset: 0x000153CB
		internal new Class_145 prop_0
		{
			get
			{
				return this.field_2;
			}
			set
			{
				this.field_2 = value;
				if (value == null)
				{
					this.field_0 = Class_142.NONE;
					return;
				}
				if (this.field_0 == Class_142.NONE)
				{
					this.field_0 = Class_142.AND;
				}
			}
		}

		// Token: 0x0600037B RID: 891 RVA: 0x000171F4 File Offset: 0x000153F4
		internal virtual bool xmethod_491(string str_0)
		{
			bool flag = this.field_1.xmethod_461(str_0);
			switch (this.field_0)
			{
			case Class_142.AND:
				if (flag)
				{
					flag = this.prop_0.xmethod_461(str_0);
				}
				break;
			case Class_142.OR:
				if (!flag)
				{
					flag = this.prop_0.xmethod_461(str_0);
				}
				break;
			case Class_142.XOR:
				flag ^= this.prop_0.xmethod_461(str_0);
				break;
			default:
				throw new ArgumentException("Conjunction");
			}
			return flag;
		}

		// Token: 0x0600037C RID: 892 RVA: 0x00017280 File Offset: 0x00015480
		public virtual string tmethod_492()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("(").Append((this.field_1 != null) ? this.field_1.ToString() : "null").Append(" ").Append(this.field_0.ToString()).Append(" ").Append((this.prop_0 != null) ? this.prop_0.ToString() : "null").Append(")");
			return stringBuilder.ToString();
		}

		// Token: 0x0600037D RID: 893 RVA: 0x00017324 File Offset: 0x00015524
		internal virtual bool gmethod_493(Class_163 arg_0)
		{
			bool flag = this.field_1.gmethod_463(arg_0);
			switch (this.field_0)
			{
			case Class_142.AND:
				if (flag)
				{
					flag = this.prop_0.gmethod_463(arg_0);
				}
				break;
			case Class_142.OR:
				if (!flag)
				{
					flag = this.prop_0.gmethod_463(arg_0);
				}
				break;
			case Class_142.XOR:
				flag ^= this.prop_0.gmethod_463(arg_0);
				break;
			}
			return flag;
		}

		// Token: 0x0400023D RID: 573
		internal Class_142 field_0;

		// Token: 0x0400023E RID: 574
		internal Class_145 field_1;

		// Token: 0x0400023F RID: 575
		private Class_145 field_2;
	}
}
