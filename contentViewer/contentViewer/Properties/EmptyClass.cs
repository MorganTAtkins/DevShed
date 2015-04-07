using System;
using System.IO;
using System.Text.RegularExpressions;
namespace contentViewer
{
	public class sourceDir		
	{
		
		public sourceDir ()
		{
			
		}
		public String[] getFile(String sDir)
		{
			
			Console.WriteLine("debug marker");
			Console.WriteLine(sDir);
			// Put all file names in the directory into array.
			string[] filesIn = Directory.GetFiles (sDir);

			foreach (String name in filesIn) 
			{
				Console.WriteLine (name);
			}
				
			return filesIn;
		}

	}
}

