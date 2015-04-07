using System;
using System.IO;
using System.Text;

namespace contentViewer
{
	public class FilesInfo2CSV
	{
		public FilesInfo2CSV ()
		{
		}
		public void info2CSV (String[] files)
		{
			if (files == null)
				throw new ArgumentNullException ("files is null");
			
			Console.WriteLine ("debug marker csv loop");
			//before your loop
			var csv = new StringBuilder();
			const String csvPath = @"C:/Users/morgan/Documents/debug/csvOutput/output.csv";
			if (File.Exists (csvPath))
			{
				Console.WriteLine ("File "+ csvPath +" exists");
			}
			else
			{
				Console.WriteLine ("File "+ csvPath + " does not exists");
			}


			foreach (string value in files) 
			{
				
				Console.WriteLine (value);

				csv.AppendLine(value);    

			}
			File.WriteAllText(csvPath, csv.ToString());
	    }
	}
}

