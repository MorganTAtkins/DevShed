using System;
using System.Text.RegularExpressions;

namespace HashGrinder
{
	public class CsvOptions
	{
		public CsvOptions (String[] files)
		{

			//do you want to save the file to a csv file 
			Console.WriteLine("Save file to a CSV file? Y/N");
			String userInput = Console.ReadLine();
			// reg = new Regex("^y");
			//Match match = Regex.Match (userInput, "^y", RegexOptions.IgnoreCase);
			if(userInput=="y"||userInput=="Y"||userInput=="yes"||userInput=="Yes") 
			{
				Console.WriteLine (userInput," matched");
				FilesInfo2CSV f2CSV = new FilesInfo2CSV ();
				f2CSV.info2CSV (files);
			}
		}
	}
}

