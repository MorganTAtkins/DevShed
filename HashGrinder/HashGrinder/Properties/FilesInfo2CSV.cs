using System;
using System.IO;
using System.Text;

namespace HashGrinder
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
				

				Console.WriteLine ("Value = "+value);
				Hash hash = new Hash();
				String hashes = hash.GetHash (value);
				Console.WriteLine("hash = "+hashes );
				//String valuehash = hash.GetHashString ();


				csv.AppendLine(value);    
				Console.WriteLine (value);

			}
			File.WriteAllText(csvPath,csv.ToString());
	    }
	}
}

