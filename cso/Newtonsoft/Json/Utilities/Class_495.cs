using System;
using System.Collections.Generic;
using System.Globalization;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x020002AB RID: 683
	internal class Class_495<TFirst, TSecond>
	{
		// Token: 0x060016A2 RID: 5794 RVA: 0x0006AABC File Offset: 0x00068CBC
		public Class_495() : this(EqualityComparer<TFirst>.Default, EqualityComparer<TSecond>.Default)
		{
		}

		// Token: 0x060016A3 RID: 5795 RVA: 0x0006AACE File Offset: 0x00068CCE
		public Class_495(IEqualityComparer<TFirst> arg_0, IEqualityComparer<TSecond> arg_1) : this(arg_0, arg_1, "Duplicate item already exists for '{0}'.", "Duplicate item already exists for '{0}'.")
		{
		}

		// Token: 0x060016A4 RID: 5796 RVA: 0x0006AAE2 File Offset: 0x00068CE2
		public Class_495(IEqualityComparer<TFirst> arg_0, IEqualityComparer<TSecond> arg_1, string str_0, string str_1)
		{
			this._firstToSecond = new Dictionary<TFirst, TSecond>(arg_0);
			this._secondToFirst = new Dictionary<TSecond, TFirst>(arg_1);
			this._duplicateFirstErrorMessage = str_0;
			this._duplicateSecondErrorMessage = str_1;
		}

		// Token: 0x060016A5 RID: 5797 RVA: 0x0006AB14 File Offset: 0x00068D14
		public void pmethod_4069(TFirst arg_0, TSecond arg_1)
		{
			TSecond tsecond;
			if (this._firstToSecond.TryGetValue(arg_0, out tsecond) && !tsecond.Equals(arg_1))
			{
				throw new ArgumentException(this._duplicateFirstErrorMessage.FormatWith(CultureInfo.InvariantCulture, arg_0));
			}
			TFirst tfirst;
			if (this._secondToFirst.TryGetValue(arg_1, out tfirst) && !tfirst.Equals(arg_0))
			{
				throw new ArgumentException(this._duplicateSecondErrorMessage.FormatWith(CultureInfo.InvariantCulture, arg_1));
			}
			this._firstToSecond.Add(arg_0, arg_1);
			this._secondToFirst.Add(arg_1, arg_0);
		}

		// Token: 0x060016A6 RID: 5798 RVA: 0x0006ABC9 File Offset: 0x00068DC9
		public bool smethod_4070(TFirst arg_0, out TSecond arg_1)
		{
			return this._firstToSecond.TryGetValue(arg_0, out arg_1);
		}

		// Token: 0x060016A7 RID: 5799 RVA: 0x0006ABD8 File Offset: 0x00068DD8
		public bool xmethod_4071(TSecond arg_0, out TFirst arg_1)
		{
			return this._secondToFirst.TryGetValue(arg_0, out arg_1);
		}

		// Token: 0x04000BDB RID: 3035
		private readonly IDictionary<TFirst, TSecond> field_0;

		// Token: 0x04000BDC RID: 3036
		private readonly IDictionary<TSecond, TFirst> field_1;

		// Token: 0x04000BDD RID: 3037
		private readonly string field_2;

		// Token: 0x04000BDE RID: 3038
		private readonly string field_3;
	}
}
