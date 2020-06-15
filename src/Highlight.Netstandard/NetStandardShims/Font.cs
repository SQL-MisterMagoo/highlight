using System;
using System.Collections.Generic;
using System.Text;

namespace Highlight.Netstandard.NetStandardShims
{
	public class Font
	{
		private string fontFamily;
		private float emSize;

		public Font(string fontFamily, float emSize, FontStyle style)
		{
			this.fontFamily = fontFamily;
			this.emSize = emSize;
			Style = style;
		}

		public string Name { get; internal set; }
		public float Size { get; internal set; }
		public FontStyle Style { get; internal set; }
	}
}
