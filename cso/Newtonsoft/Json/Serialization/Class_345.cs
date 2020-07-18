using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x020001CF RID: 463
	public class Class_345 : Class_344
	{
		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x06000CFF RID: 3327 RVA: 0x0004777A File Offset: 0x0004597A
		// (set) Token: 0x06000D00 RID: 3328 RVA: 0x00047782 File Offset: 0x00045982
		public TraceLevel prop_0 { get; set; }

		// Token: 0x06000D01 RID: 3329 RVA: 0x0004778C File Offset: 0x0004598C
		private TraceEventType dmethod_2306(TraceLevel arg_0)
		{
			switch (arg_0)
			{
			case TraceLevel.Error:
				return TraceEventType.Error;
			case TraceLevel.Warning:
				return TraceEventType.Warning;
			case TraceLevel.Info:
				return TraceEventType.Information;
			case TraceLevel.Verbose:
				return TraceEventType.Verbose;
			default:
				throw new ArgumentOutOfRangeException("level");
			}
		}

		// Token: 0x06000D02 RID: 3330 RVA: 0x000477CC File Offset: 0x000459CC
		public void kmethod_2307(TraceLevel arg_0, string str_0, Exception arg_1)
		{
			if (arg_0 == TraceLevel.Off)
			{
				return;
			}
			TraceEventCache eventCache = new TraceEventCache();
			TraceEventType eventType = this.dmethod_2306(arg_0);
			foreach (object obj in Trace.Listeners)
			{
				TraceListener traceListener = (TraceListener)obj;
				if (!traceListener.IsThreadSafe)
				{
					lock (traceListener)
					{
						traceListener.TraceEvent(eventCache, "Newtonsoft.Json", eventType, 0, str_0);
						goto IL_7C;
					}
					goto IL_6D;
				}
				goto IL_6D;
				IL_7C:
				if (Trace.AutoFlush)
				{
					traceListener.Flush();
					continue;
				}
				continue;
				IL_6D:
				traceListener.TraceEvent(eventCache, "Newtonsoft.Json", eventType, 0, str_0);
				goto IL_7C;
			}
		}

		// Token: 0x04000861 RID: 2145
		[CompilerGenerated]
		private TraceLevel field_0;
	}
}
