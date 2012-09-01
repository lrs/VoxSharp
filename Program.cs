
using System;
using System.Windows.Forms;
using System.IO;

namespace VoxSharp
{
	internal sealed class Program
	{
		[STAThread]
		private static void Main(string[] args)
		{
			if (args.Length == 0)
			{
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);
				Application.Run(new MainForm());
			}
			else
			{
				String path_from = String.Empty, path_to = String.Empty;
				DirectoryInfo dir_to;
				FileInfo file_from;
				
				bool normalise = true;
				
				tools.LogText("command line> VoxSharp running from command line");
				
				path_from = args[0];				
				path_to = args[1];
				
				tools.LogText("command line> converting from: " + path_from + ", to: " + path_to);
				
				try
				{					
					file_from = new FileInfo(path_from);
				}
				catch (IOException ex)
				{
					tools.LogText("command line> get file from exception occured: " + ex.ToString());
					return;
				}
					
				if (!file_from.Exists)
				{
					tools.LogText("command line> the from path does not exist: " + path_from);
					return;					
				}
								
				try
				{					
					dir_to = new DirectoryInfo(path_to);
				}
				catch (IOException ex)
				{
					tools.LogText("command line> get directory to exception occured: " + ex.ToString());
					return;
				}
				
								
				if (!dir_to.Exists)
				{
					tools.LogText("command line> the to path does not exist: " + path_to);
					return;										
				}
				
				tools.LogText("From Path: " + args[0]);
				tools.LogText("To Path: " + args[1]);
				if (args.Length > 2)
				{
					normalise = (args[2] == "1") ? true : false;
					tools.LogText("Normalise: " + normalise.ToString());
				}
				
				tools.convertToVox(file_from, path_to, normalise);
				return;					
			}
		}
		
	}
}
