using System;
using System.Security.Cryptography;
using System.Text;
using System.IO;


namespace contentViewer
{
	public class Hash
	{
		public Hash ()
		{
		}


		public void GetHash(String sDir)
		{
			// Create a DirectoryInfo object representing the specified directory.
			DirectoryInfo dir = new DirectoryInfo (sDir);
			// Get the FileInfo objects for every file in the directory.
			FileInfo[] files = dir.GetFiles ();

			Console.WriteLine ("check for a null array");

				//Console.WriteLine (files.ToString);
				try {
					// Create a DirectoryInfo object representing the specified directory.
					//DirectoryInfo dir = new DirectoryInfo (sDir);
					// Get the FileInfo objects for every file in the directory.
					//FileInfo[] files = dir.GetFiles ();

					// Initialize a RIPE160 hash object.
					RIPEMD160 myRIPEMD160 = RIPEMD160Managed.Create ();
					byte[] hashValue;
					// Compute and print the hash values for each file in directory. 
						foreach (FileInfo fInfo in files) 
							{
							// get the file attributes for file or directory

							FileAttributes attr = File.GetAttributes(sDir);

							//detect whether its a directory or file
							if((attr & FileAttributes.Directory) != FileAttributes.Directory)
							{
							Console.WriteLine("Its a directory");
							}
							else{

							Console.WriteLine("Its a file");
							// Create a fileStream for the file.
							FileStream fileStream = fInfo.Open (FileMode.Open);
							// Be sure it's positioned to the beginning of the stream.
							fileStream.Position = 0;
							// Compute the hash of the fileStream.
							hashValue = myRIPEMD160.ComputeHash (fileStream);
							// Write the name of the file to the Console.
							Console.Write (fInfo.Name + ": ");

							
							StringBuilder sBuilder = new StringBuilder ();
							// Loop through each hash value bytes formatting each one as a hexadecimal string. 
							for (int i = 0; i < hashValue.Length; i++) 
							{
							sBuilder.Append (hashValue [i].ToString ("x2"));
							//String hashValueString = Convert.ToString (sBuilder);
							// Write the hash value to the Console.
							}
						    String hashValueString = Convert.ToString (sBuilder);
							// Write the hash value to the Console.
							Console.WriteLine ("MD5 hash: " + hashValueString);
							//Close the file.
							fileStream.Close ();
							
					
				}
				}
							return;
				
			}
			catch(IOException)
			{
				Console.WriteLine ("Something dun fucked");
			}

		
		}

	}
}

