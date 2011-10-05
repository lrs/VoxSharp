namespace VoxSharp
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.txt_savepath = new System.Windows.Forms.TextBox();
			this.lbl_dirto = new System.Windows.Forms.Label();
			this.btn_convert = new System.Windows.Forms.Button();
			this.btn_select = new System.Windows.Forms.Button();
			this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.btn_saveto = new System.Windows.Forms.Button();
			this.chk_normalise = new System.Windows.Forms.CheckBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.setDefaultFromDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fromDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lbl_currdir = new System.Windows.Forms.Label();
			this.txt_currdir = new System.Windows.Forms.TextBox();
			this.btn_abort = new System.Windows.Forms.Button();
			this.ll_reload = new System.Windows.Forms.LinkLabel();
			this.chk_selectall = new System.Windows.Forms.CheckBox();
			this.txt_result = new System.Windows.Forms.TextBox();
			this.ll_log = new System.Windows.Forms.LinkLabel();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// txt_savepath
			// 
			this.txt_savepath.BackColor = System.Drawing.Color.White;
			this.txt_savepath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_savepath.Location = new System.Drawing.Point(33, 286);
			this.txt_savepath.Name = "txt_savepath";
			this.txt_savepath.Size = new System.Drawing.Size(374, 20);
			this.txt_savepath.TabIndex = 2;
			this.txt_savepath.Text = "C:\\TEMP";
			// 
			// lbl_dirto
			// 
			this.lbl_dirto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.lbl_dirto.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lbl_dirto.Location = new System.Drawing.Point(12, 286);
			this.lbl_dirto.Name = "lbl_dirto";
			this.lbl_dirto.Size = new System.Drawing.Size(30, 20);
			this.lbl_dirto.TabIndex = 3;
			this.lbl_dirto.Text = "to:";
			// 
			// btn_convert
			// 
			this.btn_convert.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.btn_convert.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.btn_convert.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btn_convert.Location = new System.Drawing.Point(12, 312);
			this.btn_convert.Name = "btn_convert";
			this.btn_convert.Size = new System.Drawing.Size(222, 32);
			this.btn_convert.TabIndex = 4;
			this.btn_convert.Text = "convert";
			this.btn_convert.UseVisualStyleBackColor = false;
			this.btn_convert.Click += new System.EventHandler(this.Btn_convertClick);
			// 
			// btn_select
			// 
			this.btn_select.BackColor = System.Drawing.SystemColors.ControlDark;
			this.btn_select.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_select.ForeColor = System.Drawing.Color.White;
			this.btn_select.Location = new System.Drawing.Point(407, 31);
			this.btn_select.Name = "btn_select";
			this.btn_select.Size = new System.Drawing.Size(55, 22);
			this.btn_select.TabIndex = 6;
			this.btn_select.Text = "change";
			this.btn_select.UseVisualStyleBackColor = false;
			this.btn_select.Click += new System.EventHandler(this.Btn_selectClick);
			// 
			// checkedListBox1
			// 
			this.checkedListBox1.BackColor = System.Drawing.Color.White;
			this.checkedListBox1.CheckOnClick = true;
			this.checkedListBox1.FormattingEnabled = true;
			this.checkedListBox1.HorizontalScrollbar = true;
			this.checkedListBox1.Location = new System.Drawing.Point(12, 81);
			this.checkedListBox1.Name = "checkedListBox1";
			this.checkedListBox1.Size = new System.Drawing.Size(450, 199);
			this.checkedListBox1.TabIndex = 7;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.Filter = "WAV files (*.wav)|*.wav|All files (*.*)|*.*";
			this.openFileDialog1.InitialDirectory = "desktop";
			this.openFileDialog1.Multiselect = true;
			this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialog1FileOk);
			// 
			// progressBar1
			// 
			this.progressBar1.BackColor = System.Drawing.Color.White;
			this.progressBar1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.progressBar1.Location = new System.Drawing.Point(12, 350);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(450, 23);
			this.progressBar1.TabIndex = 8;
			// 
			// btn_saveto
			// 
			this.btn_saveto.BackColor = System.Drawing.SystemColors.ControlDark;
			this.btn_saveto.Location = new System.Drawing.Point(407, 285);
			this.btn_saveto.Name = "btn_saveto";
			this.btn_saveto.Size = new System.Drawing.Size(55, 21);
			this.btn_saveto.TabIndex = 10;
			this.btn_saveto.Text = "change";
			this.btn_saveto.UseVisualStyleBackColor = false;
			this.btn_saveto.Click += new System.EventHandler(this.Btn_savetoClick);
			// 
			// chk_normalise
			// 
			this.chk_normalise.Checked = true;
			this.chk_normalise.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chk_normalise.ForeColor = System.Drawing.SystemColors.ControlText;
			this.chk_normalise.Location = new System.Drawing.Point(188, 63);
			this.chk_normalise.Name = "chk_normalise";
			this.chk_normalise.Size = new System.Drawing.Size(97, 21);
			this.chk_normalise.TabIndex = 11;
			this.chk_normalise.Text = "Normalise Files";
			this.chk_normalise.UseVisualStyleBackColor = true;
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolsToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(474, 24);
			this.menuStrip1.TabIndex = 12;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// toolsToolStripMenuItem
			// 
			this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.setDefaultFromDirectoryToolStripMenuItem,
									this.openSettingsToolStripMenuItem});
			this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
			this.toolsToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.toolsToolStripMenuItem.Text = "Tools";
			// 
			// setDefaultFromDirectoryToolStripMenuItem
			// 
			this.setDefaultFromDirectoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.fromDirectoryToolStripMenuItem,
									this.toDirectoryToolStripMenuItem});
			this.setDefaultFromDirectoryToolStripMenuItem.Name = "setDefaultFromDirectoryToolStripMenuItem";
			this.setDefaultFromDirectoryToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
			this.setDefaultFromDirectoryToolStripMenuItem.Text = "Set Default Directories";
			// 
			// fromDirectoryToolStripMenuItem
			// 
			this.fromDirectoryToolStripMenuItem.Name = "fromDirectoryToolStripMenuItem";
			this.fromDirectoryToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
			this.fromDirectoryToolStripMenuItem.Text = "From Directory";
			this.fromDirectoryToolStripMenuItem.Click += new System.EventHandler(this.FromDirectoryToolStripMenuItemClick);
			// 
			// toDirectoryToolStripMenuItem
			// 
			this.toDirectoryToolStripMenuItem.Name = "toDirectoryToolStripMenuItem";
			this.toDirectoryToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
			this.toDirectoryToolStripMenuItem.Text = "To Directory";
			this.toDirectoryToolStripMenuItem.Click += new System.EventHandler(this.ToDirectoryToolStripMenuItemClick);
			// 
			// openSettingsToolStripMenuItem
			// 
			this.openSettingsToolStripMenuItem.Name = "openSettingsToolStripMenuItem";
			this.openSettingsToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
			this.openSettingsToolStripMenuItem.Text = "Open Settings File";
			this.openSettingsToolStripMenuItem.Click += new System.EventHandler(this.OpenSettingsToolStripMenuItemClick);
			// 
			// lbl_currdir
			// 
			this.lbl_currdir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_currdir.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lbl_currdir.Location = new System.Drawing.Point(12, 32);
			this.lbl_currdir.Name = "lbl_currdir";
			this.lbl_currdir.Size = new System.Drawing.Size(37, 23);
			this.lbl_currdir.TabIndex = 13;
			this.lbl_currdir.Text = "from: ";
			// 
			// txt_currdir
			// 
			this.txt_currdir.BackColor = System.Drawing.Color.White;
			this.txt_currdir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_currdir.Location = new System.Drawing.Point(45, 32);
			this.txt_currdir.Name = "txt_currdir";
			this.txt_currdir.ReadOnly = true;
			this.txt_currdir.Size = new System.Drawing.Size(362, 20);
			this.txt_currdir.TabIndex = 14;
			// 
			// btn_abort
			// 
			this.btn_abort.BackColor = System.Drawing.Color.IndianRed;
			this.btn_abort.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.btn_abort.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btn_abort.Location = new System.Drawing.Point(243, 312);
			this.btn_abort.Name = "btn_abort";
			this.btn_abort.Size = new System.Drawing.Size(219, 32);
			this.btn_abort.TabIndex = 15;
			this.btn_abort.Text = "stop!";
			this.btn_abort.UseVisualStyleBackColor = false;
			this.btn_abort.Click += new System.EventHandler(this.Btn_abortClick);
			// 
			// ll_reload
			// 
			this.ll_reload.ActiveLinkColor = System.Drawing.SystemColors.ControlText;
			this.ll_reload.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ll_reload.ForeColor = System.Drawing.SystemColors.ControlText;
			this.ll_reload.LinkColor = System.Drawing.SystemColors.ControlText;
			this.ll_reload.Location = new System.Drawing.Point(380, 62);
			this.ll_reload.Name = "ll_reload";
			this.ll_reload.Size = new System.Drawing.Size(82, 20);
			this.ll_reload.TabIndex = 17;
			this.ll_reload.TabStop = true;
			this.ll_reload.Text = "Reload File List";
			this.ll_reload.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.ll_reload.VisitedLinkColor = System.Drawing.Color.CornflowerBlue;
			this.ll_reload.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Ll_reloadLinkClicked);
			// 
			// chk_selectall
			// 
			this.chk_selectall.Checked = true;
			this.chk_selectall.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chk_selectall.ForeColor = System.Drawing.SystemColors.ControlText;
			this.chk_selectall.Location = new System.Drawing.Point(12, 63);
			this.chk_selectall.Name = "chk_selectall";
			this.chk_selectall.Size = new System.Drawing.Size(70, 20);
			this.chk_selectall.TabIndex = 18;
			this.chk_selectall.Text = "Select All";
			this.chk_selectall.UseVisualStyleBackColor = true;
			this.chk_selectall.CheckedChanged += new System.EventHandler(this.Chk_selectallCheckedChanged);
			// 
			// txt_result
			// 
			this.txt_result.BackColor = System.Drawing.SystemColors.Control;
			this.txt_result.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txt_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.txt_result.ForeColor = System.Drawing.SystemColors.Highlight;
			this.txt_result.Location = new System.Drawing.Point(12, 379);
			this.txt_result.Name = "txt_result";
			this.txt_result.Size = new System.Drawing.Size(450, 14);
			this.txt_result.TabIndex = 19;
			this.txt_result.Visible = false;
			// 
			// ll_log
			// 
			this.ll_log.ActiveLinkColor = System.Drawing.SystemColors.ControlText;
			this.ll_log.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ll_log.ForeColor = System.Drawing.SystemColors.ControlText;
			this.ll_log.LinkColor = System.Drawing.SystemColors.ControlText;
			this.ll_log.Location = new System.Drawing.Point(407, 396);
			this.ll_log.Name = "ll_log";
			this.ll_log.Size = new System.Drawing.Size(58, 20);
			this.ll_log.TabIndex = 21;
			this.ll_log.TabStop = true;
			this.ll_log.Text = "View Log";
			this.ll_log.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.ll_log.VisitedLinkColor = System.Drawing.Color.CornflowerBlue;
			this.ll_log.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Ll_logLinkClicked);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(474, 425);
			this.Controls.Add(this.ll_log);
			this.Controls.Add(this.checkedListBox1);
			this.Controls.Add(this.txt_savepath);
			this.Controls.Add(this.txt_result);
			this.Controls.Add(this.chk_selectall);
			this.Controls.Add(this.ll_reload);
			this.Controls.Add(this.btn_abort);
			this.Controls.Add(this.txt_currdir);
			this.Controls.Add(this.lbl_currdir);
			this.Controls.Add(this.chk_normalise);
			this.Controls.Add(this.btn_saveto);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.btn_select);
			this.Controls.Add(this.btn_convert);
			this.Controls.Add(this.lbl_dirto);
			this.Controls.Add(this.menuStrip1);
			this.ForeColor = System.Drawing.Color.White;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "VoxSharp - Audio to VOX converter";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.LinkLabel ll_log;
		private System.Windows.Forms.Label lbl_dirto;
		private System.Windows.Forms.TextBox txt_result;
		private System.Windows.Forms.CheckBox chk_selectall;
		private System.Windows.Forms.ToolStripMenuItem openSettingsToolStripMenuItem;
		private System.Windows.Forms.LinkLabel ll_reload;
		private System.Windows.Forms.Button btn_abort;
		private System.Windows.Forms.TextBox txt_currdir;
		private System.Windows.Forms.Label lbl_currdir;
		private System.Windows.Forms.ToolStripMenuItem toDirectoryToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fromDirectoryToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem setDefaultFromDirectoryToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.CheckBox chk_normalise;
		private System.Windows.Forms.TextBox txt_savepath;
		private System.Windows.Forms.Button btn_saveto;
		private System.Windows.Forms.Button btn_convert;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.CheckedListBox checkedListBox1;
		private System.Windows.Forms.Button btn_select;
	}
}
