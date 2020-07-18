using System;
using System.Runtime.InteropServices;

namespace Ionic.Zip
{
	// Token: 0x020000A7 RID: 167
	[ComVisible(true)]
	public enum Class_128
	{
		// Token: 0x040001F7 RID: 503
		Adding_Started,
		// Token: 0x040001F8 RID: 504
		Adding_AfterAddEntry,
		// Token: 0x040001F9 RID: 505
		Adding_Completed,
		// Token: 0x040001FA RID: 506
		Reading_Started,
		// Token: 0x040001FB RID: 507
		Reading_BeforeReadEntry,
		// Token: 0x040001FC RID: 508
		Reading_AfterReadEntry,
		// Token: 0x040001FD RID: 509
		Reading_Completed,
		// Token: 0x040001FE RID: 510
		Reading_ArchiveBytesRead,
		// Token: 0x040001FF RID: 511
		Saving_Started,
		// Token: 0x04000200 RID: 512
		Saving_BeforeWriteEntry,
		// Token: 0x04000201 RID: 513
		Saving_AfterWriteEntry,
		// Token: 0x04000202 RID: 514
		Saving_Completed,
		// Token: 0x04000203 RID: 515
		Saving_AfterSaveTempArchive,
		// Token: 0x04000204 RID: 516
		Saving_BeforeRenameTempArchive,
		// Token: 0x04000205 RID: 517
		Saving_AfterRenameTempArchive,
		// Token: 0x04000206 RID: 518
		Saving_AfterCompileSelfExtractor,
		// Token: 0x04000207 RID: 519
		Saving_EntryBytesRead,
		// Token: 0x04000208 RID: 520
		Extracting_BeforeExtractEntry,
		// Token: 0x04000209 RID: 521
		Extracting_AfterExtractEntry,
		// Token: 0x0400020A RID: 522
		Extracting_ExtractEntryWouldOverwrite,
		// Token: 0x0400020B RID: 523
		Extracting_EntryBytesWritten,
		// Token: 0x0400020C RID: 524
		Extracting_BeforeExtractAll,
		// Token: 0x0400020D RID: 525
		Extracting_AfterExtractAll,
		// Token: 0x0400020E RID: 526
		Error_Saving
	}
}
