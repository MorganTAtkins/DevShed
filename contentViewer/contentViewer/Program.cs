using System;
using System.Text.RegularExpressions;
//diplays the content of a file directory 
namespace contentViewer
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("THE DEV SHED");
		
			fileChooser fileChooser = new fileChooser ();
			String sDir = fileChooser.sourceDir ();

			sourceDir sourceDir = new sourceDir ();
			String[] files = sourceDir.getFile (sDir);
		
			CsvOptions CsvOptions = new CsvOptions (files);

			Hash hash = new Hash ();
			hash.GetHash (sDir);

		}

	}
}
