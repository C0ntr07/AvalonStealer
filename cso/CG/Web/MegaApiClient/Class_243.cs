using System;
using System.Collections.Generic;
using System.Linq;

namespace CG.Web.MegaApiClient
{
	// Token: 0x02000149 RID: 329
	public static class Class_243
	{
		// Token: 0x06000965 RID: 2405 RVA: 0x0003BD78 File Offset: 0x00039F78
		public static long GetFolderSize(this Class_232 node, Class_231 client)
		{
			IEnumerable<Class_233> allNodes = client.cmethod_1504();
			return node.GetFolderSize(allNodes);
		}

		// Token: 0x06000966 RID: 2406 RVA: 0x0003BD94 File Offset: 0x00039F94
		public static long GetFolderSize(this Class_232 node, IEnumerable<Class_233> allNodes)
		{
			if (node.prop_1 == Class_235.File)
			{
				throw new InvalidOperationException("node is not a Directory");
			}
			long num = 0L;
			foreach (Class_233 class_ in from x in allNodes
			where x.prop_0 == node.prop_0
			select x)
			{
				if (class_.prop_1 == Class_235.File)
				{
					num += class_.prop_3;
				}
				else if (class_.prop_1 == Class_235.Directory)
				{
					long folderSize = class_.GetFolderSize(allNodes);
					num += folderSize;
				}
			}
			return num;
		}
	}
}
