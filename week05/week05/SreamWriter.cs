using System.IO;

namespace week05
{
	internal class SreamWriter : StreamWriter
	{
		public SreamWriter(string path) : base(path)
		{
		}
	}
}