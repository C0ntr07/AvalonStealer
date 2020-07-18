using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Token: 0x02000124 RID: 292
[CompilerGenerated]
internal sealed class Class_218<<r>j__TPar, <u>j__TPar>
{
	// Token: 0x1700018C RID: 396
	// (get) Token: 0x06000801 RID: 2049 RVA: 0x00035716 File Offset: 0x00033916
	public <r>j__TPar r
	{
		get
		{
			return this.<r>i__Field;
		}
	}

	// Token: 0x1700018D RID: 397
	// (get) Token: 0x06000802 RID: 2050 RVA: 0x0003571E File Offset: 0x0003391E
	public <u>j__TPar u
	{
		get
		{
			return this.<u>i__Field;
		}
	}

	// Token: 0x06000803 RID: 2051 RVA: 0x00035726 File Offset: 0x00033926
	[DebuggerHidden]
	public Class_218(<r>j__TPar r, <u>j__TPar u)
	{
		this.<r>i__Field = r;
		this.<u>i__Field = u;
	}

	// Token: 0x06000804 RID: 2052 RVA: 0x0003573C File Offset: 0x0003393C
	[DebuggerHidden]
	public override bool Equals(object value)
	{
		Class_218<<r>j__TPar, <u>j__TPar> class_ = value as Class_218<<r>j__TPar, <u>j__TPar>;
		return class_ != null && EqualityComparer<<r>j__TPar>.Default.Equals(this.<r>i__Field, class_.<r>i__Field) && EqualityComparer<<u>j__TPar>.Default.Equals(this.<u>i__Field, class_.<u>i__Field);
	}

	// Token: 0x06000805 RID: 2053 RVA: 0x00035789 File Offset: 0x00033989
	[DebuggerHidden]
	public override int GetHashCode()
	{
		return (145950875 + EqualityComparer<<r>j__TPar>.Default.GetHashCode(this.<r>i__Field)) * -1521134295 + EqualityComparer<<u>j__TPar>.Default.GetHashCode(this.<u>i__Field);
	}

	// Token: 0x06000806 RID: 2054 RVA: 0x000357BC File Offset: 0x000339BC
	[DebuggerHidden]
	public override string ToString()
	{
		IFormatProvider provider = null;
		string format = "{{ r = {0}, u = {1} }}";
		object[] array = new object[2];
		int num = 0;
		<r>j__TPar <r>j__TPar = this.<r>i__Field;
		ref <r>j__TPar ptr = ref <r>j__TPar;
		<r>j__TPar <r>j__TPar2 = default(<r>j__TPar);
		object obj;
		if (<r>j__TPar2 == null)
		{
			<r>j__TPar2 = <r>j__TPar;
			ptr = ref <r>j__TPar2;
			if (<r>j__TPar2 == null)
			{
				obj = null;
				goto IL_4F;
			}
		}
		obj = ptr.ToString();
		IL_4F:
		array[num] = obj;
		int num2 = 1;
		<u>j__TPar <u>j__TPar = this.<u>i__Field;
		ref <u>j__TPar ptr2 = ref <u>j__TPar;
		<u>j__TPar <u>j__TPar2 = default(<u>j__TPar);
		object obj2;
		if (<u>j__TPar2 == null)
		{
			<u>j__TPar2 = <u>j__TPar;
			ptr2 = ref <u>j__TPar2;
			if (<u>j__TPar2 == null)
			{
				obj2 = null;
				goto IL_93;
			}
		}
		obj2 = ptr2.ToString();
		IL_93:
		array[num2] = obj2;
		return string.Format(provider, format, array);
	}

	// Token: 0x040005F3 RID: 1523
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly <r>j__TPar <r>i__Field;

	// Token: 0x040005F4 RID: 1524
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly <u>j__TPar <u>i__Field;
}
