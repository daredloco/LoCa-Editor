namespace LoCa_Editor
{
	partial class MainForm
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.ms_main = new System.Windows.Forms.ToolStripMenuItem();
			this.ts_folder = new System.Windows.Forms.ToolStripMenuItem();
			this.ts_settings = new System.Windows.Forms.ToolStripMenuItem();
			this.ts_exit = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fbd = new System.Windows.Forms.FolderBrowserDialog();
			this.lb_localizations = new System.Windows.Forms.ListBox();
			this.dgv_trans = new System.Windows.Forms.DataGridView();
			this.col_key = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.col_localization = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.l_localizations = new System.Windows.Forms.Label();
			this.tb_version = new System.Windows.Forms.TextBox();
			this.tb_author = new System.Windows.Forms.TextBox();
			this.tb_local = new System.Windows.Forms.TextBox();
			this.tb_english = new System.Windows.Forms.TextBox();
			this.tb_key = new System.Windows.Forms.TextBox();
			this.l_english = new System.Windows.Forms.Label();
			this.l_key = new System.Windows.Forms.Label();
			this.l_local = new System.Windows.Forms.Label();
			this.l_author = new System.Windows.Forms.Label();
			this.l_version = new System.Windows.Forms.Label();
			this.bt_save = new System.Windows.Forms.Button();
			this.cms_loc = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.cms_create = new System.Windows.Forms.ToolStripMenuItem();
			this.cms_rename = new System.Windows.Forms.ToolStripMenuItem();
			this.cms_delete = new System.Windows.Forms.ToolStripMenuItem();
			this.cms_copy = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_trans)).BeginInit();
			this.cms_loc.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ms_main,
            this.aboutToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 28);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "ms_main";
			// 
			// ms_main
			// 
			this.ms_main.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_folder,
            this.ts_settings,
            this.ts_exit});
			this.ms_main.Name = "ms_main";
			this.ms_main.Size = new System.Drawing.Size(46, 24);
			this.ms_main.Text = "File";
			// 
			// ts_folder
			// 
			this.ts_folder.Name = "ts_folder";
			this.ts_folder.Size = new System.Drawing.Size(174, 26);
			this.ts_folder.Text = "Open Folder";
			this.ts_folder.Click += new System.EventHandler(this.OpenFolderToolStripMenuItem_Click);
			// 
			// ts_settings
			// 
			this.ts_settings.Enabled = false;
			this.ts_settings.Name = "ts_settings";
			this.ts_settings.Size = new System.Drawing.Size(224, 26);
			this.ts_settings.Text = "Settings";
			// 
			// ts_exit
			// 
			this.ts_exit.Name = "ts_exit";
			this.ts_exit.Size = new System.Drawing.Size(224, 26);
			this.ts_exit.Text = "Exit";
			this.ts_exit.Click += new System.EventHandler(this.ts_exit_Click);
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
			this.aboutToolStripMenuItem.Text = "About";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
			// 
			// lb_localizations
			// 
			this.lb_localizations.ContextMenuStrip = this.cms_loc;
			this.lb_localizations.FormattingEnabled = true;
			this.lb_localizations.ItemHeight = 16;
			this.lb_localizations.Location = new System.Drawing.Point(12, 69);
			this.lb_localizations.Name = "lb_localizations";
			this.lb_localizations.Size = new System.Drawing.Size(284, 372);
			this.lb_localizations.TabIndex = 1;
			this.lb_localizations.SelectedIndexChanged += new System.EventHandler(this.lb_localizations_SelectedIndexChanged);
			// 
			// dgv_trans
			// 
			this.dgv_trans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_trans.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_key,
            this.col_localization});
			this.dgv_trans.Location = new System.Drawing.Point(302, 224);
			this.dgv_trans.MultiSelect = false;
			this.dgv_trans.Name = "dgv_trans";
			this.dgv_trans.RowHeadersWidth = 51;
			this.dgv_trans.RowTemplate.Height = 24;
			this.dgv_trans.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.dgv_trans.Size = new System.Drawing.Size(486, 217);
			this.dgv_trans.TabIndex = 2;
			// 
			// col_key
			// 
			this.col_key.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.col_key.FillWeight = 50F;
			this.col_key.HeaderText = "Key";
			this.col_key.MinimumWidth = 6;
			this.col_key.Name = "col_key";
			// 
			// col_localization
			// 
			this.col_localization.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.col_localization.FillWeight = 50F;
			this.col_localization.HeaderText = "Localization";
			this.col_localization.MinimumWidth = 6;
			this.col_localization.Name = "col_localization";
			// 
			// l_localizations
			// 
			this.l_localizations.AutoSize = true;
			this.l_localizations.Location = new System.Drawing.Point(12, 46);
			this.l_localizations.Name = "l_localizations";
			this.l_localizations.Size = new System.Drawing.Size(94, 17);
			this.l_localizations.TabIndex = 3;
			this.l_localizations.Text = "Localizations:";
			// 
			// tb_version
			// 
			this.tb_version.Location = new System.Drawing.Point(416, 181);
			this.tb_version.Name = "tb_version";
			this.tb_version.Size = new System.Drawing.Size(100, 22);
			this.tb_version.TabIndex = 4;
			// 
			// tb_author
			// 
			this.tb_author.Location = new System.Drawing.Point(416, 153);
			this.tb_author.Name = "tb_author";
			this.tb_author.Size = new System.Drawing.Size(100, 22);
			this.tb_author.TabIndex = 5;
			// 
			// tb_local
			// 
			this.tb_local.Location = new System.Drawing.Point(415, 125);
			this.tb_local.Name = "tb_local";
			this.tb_local.Size = new System.Drawing.Size(100, 22);
			this.tb_local.TabIndex = 6;
			// 
			// tb_english
			// 
			this.tb_english.Location = new System.Drawing.Point(416, 97);
			this.tb_english.Name = "tb_english";
			this.tb_english.Size = new System.Drawing.Size(100, 22);
			this.tb_english.TabIndex = 7;
			// 
			// tb_key
			// 
			this.tb_key.Location = new System.Drawing.Point(415, 69);
			this.tb_key.Name = "tb_key";
			this.tb_key.Size = new System.Drawing.Size(100, 22);
			this.tb_key.TabIndex = 8;
			// 
			// l_english
			// 
			this.l_english.AutoSize = true;
			this.l_english.Location = new System.Drawing.Point(302, 100);
			this.l_english.Name = "l_english";
			this.l_english.Size = new System.Drawing.Size(58, 17);
			this.l_english.TabIndex = 9;
			this.l_english.Text = "English:";
			// 
			// l_key
			// 
			this.l_key.AutoSize = true;
			this.l_key.Location = new System.Drawing.Point(302, 72);
			this.l_key.Name = "l_key";
			this.l_key.Size = new System.Drawing.Size(36, 17);
			this.l_key.TabIndex = 10;
			this.l_key.Text = "Key:";
			// 
			// l_local
			// 
			this.l_local.AutoSize = true;
			this.l_local.Location = new System.Drawing.Point(302, 128);
			this.l_local.Name = "l_local";
			this.l_local.Size = new System.Drawing.Size(46, 17);
			this.l_local.TabIndex = 11;
			this.l_local.Text = "Local:";
			// 
			// l_author
			// 
			this.l_author.AutoSize = true;
			this.l_author.Location = new System.Drawing.Point(302, 156);
			this.l_author.Name = "l_author";
			this.l_author.Size = new System.Drawing.Size(54, 17);
			this.l_author.TabIndex = 12;
			this.l_author.Text = "Author:";
			// 
			// l_version
			// 
			this.l_version.AutoSize = true;
			this.l_version.Location = new System.Drawing.Point(302, 184);
			this.l_version.Name = "l_version";
			this.l_version.Size = new System.Drawing.Size(60, 17);
			this.l_version.TabIndex = 13;
			this.l_version.Text = "Version:";
			// 
			// bt_save
			// 
			this.bt_save.Location = new System.Drawing.Point(522, 153);
			this.bt_save.Name = "bt_save";
			this.bt_save.Size = new System.Drawing.Size(266, 48);
			this.bt_save.TabIndex = 14;
			this.bt_save.Text = "Save Localization";
			this.bt_save.UseVisualStyleBackColor = true;
			this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
			// 
			// cms_loc
			// 
			this.cms_loc.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.cms_loc.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cms_create,
            this.cms_rename,
            this.cms_copy,
            this.cms_delete});
			this.cms_loc.Name = "cms_loc";
			this.cms_loc.Size = new System.Drawing.Size(133, 100);
			// 
			// cms_create
			// 
			this.cms_create.Name = "cms_create";
			this.cms_create.Size = new System.Drawing.Size(210, 24);
			this.cms_create.Text = "Create";
			this.cms_create.Click += new System.EventHandler(this.cms_create_Click);
			// 
			// cms_rename
			// 
			this.cms_rename.Name = "cms_rename";
			this.cms_rename.Size = new System.Drawing.Size(210, 24);
			this.cms_rename.Text = "Rename";
			this.cms_rename.Click += new System.EventHandler(this.cms_rename_Click);
			// 
			// cms_delete
			// 
			this.cms_delete.Name = "cms_delete";
			this.cms_delete.Size = new System.Drawing.Size(210, 24);
			this.cms_delete.Text = "Delete";
			// 
			// cms_copy
			// 
			this.cms_copy.Name = "cms_copy";
			this.cms_copy.Size = new System.Drawing.Size(210, 24);
			this.cms_copy.Text = "Copy";
			this.cms_copy.Click += new System.EventHandler(this.cms_copy_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.bt_save);
			this.Controls.Add(this.l_version);
			this.Controls.Add(this.l_author);
			this.Controls.Add(this.l_local);
			this.Controls.Add(this.l_key);
			this.Controls.Add(this.l_english);
			this.Controls.Add(this.tb_key);
			this.Controls.Add(this.tb_english);
			this.Controls.Add(this.tb_local);
			this.Controls.Add(this.tb_author);
			this.Controls.Add(this.tb_version);
			this.Controls.Add(this.l_localizations);
			this.Controls.Add(this.dgv_trans);
			this.Controls.Add(this.lb_localizations);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "LoCa Editor";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_trans)).EndInit();
			this.cms_loc.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem ms_main;
		private System.Windows.Forms.ToolStripMenuItem ts_folder;
		private System.Windows.Forms.ToolStripMenuItem ts_settings;
		private System.Windows.Forms.ToolStripMenuItem ts_exit;
		private System.Windows.Forms.FolderBrowserDialog fbd;
		private System.Windows.Forms.ListBox lb_localizations;
		private System.Windows.Forms.DataGridView dgv_trans;
		private System.Windows.Forms.Label l_localizations;
		private System.Windows.Forms.TextBox tb_version;
		private System.Windows.Forms.TextBox tb_author;
		private System.Windows.Forms.TextBox tb_local;
		private System.Windows.Forms.TextBox tb_english;
		private System.Windows.Forms.TextBox tb_key;
		private System.Windows.Forms.Label l_english;
		private System.Windows.Forms.Label l_key;
		private System.Windows.Forms.Label l_local;
		private System.Windows.Forms.Label l_author;
		private System.Windows.Forms.Label l_version;
		private System.Windows.Forms.DataGridViewTextBoxColumn col_key;
		private System.Windows.Forms.DataGridViewTextBoxColumn col_localization;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.Button bt_save;
		private System.Windows.Forms.ContextMenuStrip cms_loc;
		private System.Windows.Forms.ToolStripMenuItem cms_create;
		private System.Windows.Forms.ToolStripMenuItem cms_rename;
		private System.Windows.Forms.ToolStripMenuItem cms_delete;
		private System.Windows.Forms.ToolStripMenuItem cms_copy;
	}
}

