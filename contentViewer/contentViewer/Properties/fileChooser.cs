using System;
using System.Windows;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace contentViewer
{
	public class fileChooser
	{
		public fileChooser ()
		{
		}

		public String sourceDir()
		{
			Regex reg = new Regex(@"^(?:[a-zA-Z]\:|\\\\[\w\.]+\\[\w.$]+)\\(?:[\w]+\\)*\w([\w.])+$");

			Console.WriteLine ("Enter the directory you wish to view");
			String sDir = Console.ReadLine();
		
			if (!reg.IsMatch (sDir)) 
			{
				Console.WriteLine ("You have entered an incorrect Directory");
				sourceDir ();
			}
		
			return sDir;
		}

	}
}


