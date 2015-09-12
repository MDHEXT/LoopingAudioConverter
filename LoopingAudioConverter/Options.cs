﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoopingAudioConverter {
	public enum ExporterType {
		BRSTM,
		WAV,
		FLAC,
		MP3,
		OggVorbis
	}

	public class Options {
		public IEnumerable<string> InputFiles { get; set; }
		public ExporterType ExporterType { get; set; }
		public bool ExportWholeSong { get; set; }
		public string WholeSongSuffix { get; set; }
		public int NumberOfLoops { get; set; }
		public decimal FadeOutSec { get; set; }
		public bool ExportPreLoop { get; set; }
		public string PreLoopSuffix { get; set; }
		public bool ExportLoop { get; set; }
		public string LoopSuffix { get; set; }
	}
}