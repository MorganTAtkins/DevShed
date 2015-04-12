using System;

namespace HashGrinder
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("DEV SHED");
			fileChooser fileChooser = new fileChooser ();
			String sDir = fileChooser.sourceDir ();

			sourceDir sourceDir = new sourceDir ();
			String[] files = sourceDir.getFile (sDir);

			CsvOptions Csvoptions = new CsvOptions (files);
			Hash hash = new Hash ();
			hash.GetHash (sDir);
		}
	}
}
