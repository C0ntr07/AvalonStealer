using System;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000275 RID: 629
	internal static class Class_471<T> where T : Attribute
	{
		// Token: 0x060015B9 RID: 5561 RVA: 0x00067784 File Offset: 0x00065984
		public static T GetAttribute(object type)
		{
			return Class_471<T>.TypeAttributeCache.Get(type);
		}

		// Token: 0x04000B63 RID: 2915
		private static readonly Class_493<object, T> TypeAttributeCache = new Class_493<object, T>(new Func<object, T>(Class_470.GetAttribute<T>));
	}
}
