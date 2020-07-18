using System;
using System.IO;
using System.Linq;

namespace CG.Web.MegaApiClient
{
	// Token: 0x02000151 RID: 337
	internal class Class_248 : Class_249
	{
		// Token: 0x06000999 RID: 2457 RVA: 0x0003C2D4 File Offset: 0x0003A4D4
		public Class_248(Stream stream_, long sayıUınt_0, byte[] byteDizi_0, byte[] byteDizi_1, byte[] byteDizi_2) : base(stream_, sayıUınt_0, Class_249.NClass_0.field_3, byteDizi_0, byteDizi_1)
		{
			if (byteDizi_2 == null || byteDizi_2.Length != 8)
			{
				throw new ArgumentException("Invalid expectedMetaMac");
			}
			this.field_0 = byteDizi_2;
		}

		// Token: 0x0600099A RID: 2458 RVA: 0x0003C306 File Offset: 0x0003A506
		protected virtual void kmethod_1687()
		{
			if (!this.field_0.SequenceEqual(this.field_4))
			{
				throw new Class_225();
			}
		}

		// Token: 0x0400068A RID: 1674
		private new readonly byte[] field_0;
	}
}
