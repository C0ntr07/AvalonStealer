using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x020001D7 RID: 471
	public class Class_351 : Class_344
	{
		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x06000D40 RID: 3392 RVA: 0x00048175 File Offset: 0x00046375
		// (set) Token: 0x06000D41 RID: 3393 RVA: 0x0004817D File Offset: 0x0004637D
		public TraceLevel prop_0 { get; set; }

		// Token: 0x06000D42 RID: 3394 RVA: 0x00048186 File Offset: 0x00046386
		public Class_351()
		{
			this.prop_0 = TraceLevel.Verbose;
			this.field_0 = new Queue<string>();
		}

		// Token: 0x06000D43 RID: 3395 RVA: 0x000481A0 File Offset: 0x000463A0
		public void gmethod_2363(TraceLevel arg_0, string str_0, Exception arg_1)
		{
			string item = string.Concat(new string[]
			{
				DateTime.Now.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fff", CultureInfo.InvariantCulture),
				" ",
				arg_0.ToString("g"),
				" ",
				str_0
			});
			if (this.field_0.Count >= 1000)
			{
				this.field_0.Dequeue();
			}
			this.field_0.Enqueue(item);
		}

		// Token: 0x06000D44 RID: 3396 RVA: 0x00048239 File Offset: 0x00046439
		public IEnumerable<string> cmethod_2364()
		{
			return this.field_0;
		}

		// Token: 0x06000D45 RID: 3397 RVA: 0x00048244 File Offset: 0x00046444
		public virtual string vmethod_2365()
		{
			StringBuilder stringBuilder = new StringBuilder();
			foreach (string value in this.field_0)
			{
				if (stringBuilder.Length > 0)
				{
					stringBuilder.AppendLine();
				}
				stringBuilder.Append(value);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x04000882 RID: 2178
		private readonly Queue<string> field_0;

		// Token: 0x04000883 RID: 2179
		[CompilerGenerated]
		private TraceLevel field_1;
	}
}
