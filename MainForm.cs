
namespace VoxSharp
{
	using System;
	using System.Collections.Generic;
	using System.Diagnostics;
	using System.IO;
	using System.Drawing;
	using System.Windows.Forms;

	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
	    private static string app_path = AppDomain.CurrentDomain.BaseDirectory, settings_path = app_path + "settings.xml";
	    private static bool abort_conversion;
	    private static string[] valid_exts = {".AIFF", ".AIF", ".APE", ".FLAC", ".M4A", ".MP3", ".MP4", ".OGG", ".WAV", ".WMA"};
	    	
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();			
			setup();
		}		
		
		void Btn_selectClick(object sender, EventArgs e)
		{
			openFileDialog1.ShowDialog();
		}
		
		void OpenFileDialog1FileOk(object sender, System.ComponentModel.CancelEventArgs e)
		{
			checkedListBox1.DataSource = openFileDialog1.FileNames;
			for(int i=0;i<checkedListBox1.Items.Count;i++)
			{
				checkedListBox1.SetItemChecked(i,true);
			}
		}
		
		void Btn_convertClick(object sender, EventArgs e)
		{
	    	txt_result.Visible = false;
	    	ll_log.Visible = false;
	    	
		    if (checkedListBox1.CheckedItems.Count != 0)
		    {
		        string files_converted;
    		    abort_conversion = false;
    		    btn_abort.Select();
    		    
    			int file_count=checkedListBox1.Items.Count, converted = 0;
    			progressBar1.Maximum=checkedListBox1.CheckedItems.Count;
    			progressBar1.Value=0;
    			progressBar1.Step=1;
    			for(int i=0;i<file_count;i++)
    			{
    				// do file conversion
    				Application.DoEvents();
    				if(abort_conversion)
    				{
    				    files_converted = (converted == 1) ? " file converted" : " files converted";
    			        txt_result.Text = "conversion was interrupted - " + converted + files_converted;
				    	txt_result.Visible = true;
				    	ll_log.Visible = true;
    				    return;
    				}
    				checkedListBox1.SelectedIndex=i;    				
    				if(checkedListBox1.GetItemChecked(i))
    				{
        				FileInfo convert_file = new FileInfo(checkedListBox1.Items[i].ToString());
        				if(tools.convertToVox(convert_file, txt_savepath.Text, chk_normalise.Checked))
        				{
        					converted++;
        				}
        				progressBar1.PerformStep();
    				}
    			}
    			files_converted = (converted == 1) ? " file converted" : " files converted";

		    	txt_result.Text = "conversion has completed - " + converted + files_converted;
		    	txt_result.Visible = true;
		    	ll_log.Visible = true;
		    	
    			progressBar1.Value=0;
    			progressBar1.Step=0;
    		    checkedListBox1.SelectedIndex=0;
		    }
		    else
		    {
		    	txt_result.Text = "no files have been selected for conversion.";
		    	txt_result.Visible = true;
		    	ll_log.Visible = true;
		    }
		}
		
		void Btn_savetoClick(object sender, EventArgs e)
		{
			folderBrowserDialog1.ShowDialog();
			txt_savepath.Text = folderBrowserDialog1.SelectedPath;
			this.Refresh();
		}	
		
		void FromDirectoryToolStripMenuItemClick(object sender, EventArgs e)
		{
		    folderBrowserDialog1.ShowDialog();
		    string path = folderBrowserDialog1.SelectedPath;
		    txt_currdir.Text = path;
			this.Refresh();
		    openFileDialog1.InitialDirectory = path;
		    tools.updateSetting("defaultdirfrom",path,true);
		    
		    setup();
		}
		
		void ToDirectoryToolStripMenuItemClick(object sender, EventArgs e)
		{			
		    folderBrowserDialog1.ShowDialog();
		    string path = folderBrowserDialog1.SelectedPath;
		    txt_savepath.Text = path;
			this.Refresh();
		    tools.updateSetting("defaultdirto",folderBrowserDialog1.SelectedPath,true);
		    
		    setup();
		}
		
		void OpenSettingsToolStripMenuItemClick(object sender, EventArgs e)
		{
		    Process p = new Process();
		    p.StartInfo.UseShellExecute = true;
		    p.StartInfo.FileName = "\"" + settings_path + "\"";
		    p.Start();
		    p.WaitForExit();
		    
		    setup();
		}
		
		void setup()
		{
			string dir_from = tools.getSetting("defaultdirfrom", true), dir_to = tools.getSetting("defaultdirto", true);
			openFileDialog1.InitialDirectory = (Directory.Exists(dir_from)) ? dir_from : @"C:\";
			loadCheckList();
			txt_currdir.Text = openFileDialog1.InitialDirectory;
			txt_savepath.Text = (Directory.Exists(dir_to)) ? dir_to : @"C:\";
			this.Refresh();
		}
		
		void loadCheckList()
		{
			if(!string.IsNullOrEmpty(openFileDialog1.InitialDirectory))
			{
				checkedListBox1.Items.Clear();
				DirectoryInfo dir_from = new DirectoryInfo(openFileDialog1.InitialDirectory);
				if(dir_from.Exists)
				{				
					FileInfo[] fi = dir_from.GetFiles("*.*");                   
					for(int i=0;i<fi.Length;i++)
					{	
						if(Array.IndexOf(valid_exts, fi[i].Extension.ToUpperInvariant()) != -1)
						{
							checkedListBox1.Items.Add(fi[i].FullName, chk_selectall.Checked);							
						}
					}
				}
			}
		}
		void Btn_abortClick(object sender, EventArgs e)
		{
			abort_conversion = true;
		}
		
		void Ll_reloadLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			loadCheckList();			
		}
		
		void Chk_selectallCheckedChanged(object sender, EventArgs e)
		{
			for (int c = 0; c< checkedListBox1.Items.Count; c++)
			{
				checkedListBox1.SetItemChecked(c,chk_selectall.Checked);
			}
		}		
		
		void Ll_logLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{			
			tools.ShowLog();
		}
	}
}
