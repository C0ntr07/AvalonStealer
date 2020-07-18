using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x020001E0 RID: 480
	[DefaultMember("Item")]
	public interface Class_360<out T> : IEnumerable, IEnumerable<T> where T : Class_361
	{
		// Token: 0x170002DB RID: 731
		// (get) Token: 0x06000D9F RID: 3487
		Class_360<Class_361> prop_0 { get; }
	}
}
