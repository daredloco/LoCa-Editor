using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RoWa;

namespace LoCa_Editor
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			LoCa.Init(System.IO.Path.Combine(Application.StartupPath, "Localization"));
			TranslateForm();
		}

		private void TranslateForm()
		{
			l_localizations.Text = LoCa.Trans("main_localizations") + ":";

			l_key.Text = LoCa.Trans("main_key") + ":";
			l_english.Text = LoCa.Trans("main_english") + ":";
			l_local.Text = LoCa.Trans("main_local") + ":";
			l_author.Text = LoCa.Trans("main_author") + ":";
			l_version.Text = LoCa.Trans("main_version") + ":";

			dgv_trans.Columns[0].HeaderText = LoCa.Trans("main_key");
			dgv_trans.Columns[1].HeaderText = LoCa.Trans("main_localization");

			ms_main.Text = LoCa.Trans("menu_main");
			ts_folder.Text = LoCa.Trans("menu_open");
			ts_settings.Text = LoCa.Trans("menu_settings");
			ts_exit.Text = LoCa.Trans("menu_exit");
		}

		private void OpenFolderToolStripMenuItem_Click(object sender, EventArgs e)
		{
			fbd.ShowDialog();
			if(fbd.SelectedPath != "")
			{
				EditorBackend.LoadLanguages(fbd.SelectedPath);
				lb_localizations.Items.Clear();
				foreach(KeyValuePair<string,LoCa.Language> lang in EditorBackend.Languages)
				{
					lb_localizations.Items.Add(lang.Key);
				}
			}
		}

		private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string about = "LoCa Editor" + Environment.NewLine +
				"Version: " + Application.ProductVersion + Environment.NewLine +
				"Author: Roman Wanner" + Environment.NewLine +
				"License: MIT" + Environment.NewLine +
				"Copyright: Roman Wanner 2020";
			MessageBox.Show(about, "Application Informations", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void lb_localizations_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (lb_localizations.SelectedItem == null)
				return;

			LoCa.Language lang = EditorBackend.Languages[(string)lb_localizations.SelectedItem];
			tb_key.Text = lang.Key;
			tb_english.Text = lang.English;
			tb_local.Text = lang.Local;
			tb_author.Text = lang.Author;
			tb_version.Text = lang.Version;

			dgv_trans.Rows.Clear();
			foreach(KeyValuePair<string,string> kvp in lang.Dict)
			{
				string[] vals = {kvp.Key, kvp.Value };
				dgv_trans.Rows.Add(vals);
			}
		}

		private void bt_save_Click(object sender, EventArgs e)
		{
			using(System.IO.StreamWriter sw = new System.IO.StreamWriter(System.IO.Path.Combine(EditorBackend.Directory,(string)lb_localizations.SelectedItem)))
			{
				sw.WriteLine("language_key=" + tb_key.Text);
				sw.WriteLine("language_english=" + tb_english.Text);
				sw.WriteLine("language_local=" + tb_local.Text);
				sw.WriteLine("language_author=" + tb_author.Text);
				sw.WriteLine("language_version=" + tb_version.Text);
				sw.WriteLine("");
				foreach(DataGridViewRow row in dgv_trans.Rows)
				{
					if(row.Cells[0].Value != null && row.Cells[1].Value != null)
					sw.WriteLine(row.Cells[0].Value + "=" + row.Cells[1].Value);
				}
			}
			MessageBox.Show("Saved...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
			EditorBackend.LoadLanguages(EditorBackend.Directory);
		}

		private void cms_create_Click(object sender, EventArgs e)
		{
			EditForm ef = new EditForm(false);
			ef.ShowDialog();
			string ename = ef.editname;
			lb_localizations.Items.Add(ename);
			using (System.IO.StreamWriter sw = new System.IO.StreamWriter(System.IO.Path.Combine(EditorBackend.Directory, ename)))
			{
				sw.WriteLine("language_key=change me");
				sw.WriteLine("language_english=change me");
				sw.WriteLine("language_local=change me");
				sw.WriteLine("language_author=change me");
				sw.WriteLine("language_version=change me");
			}
			EditorBackend.LoadLanguages(EditorBackend.Directory);
		}

		private void cms_rename_Click(object sender, EventArgs e)
		{
			if (lb_localizations.SelectedItem == null)
				return;
			string old = (string)lb_localizations.SelectedItem;
			EditForm ef = new EditForm(true, (string)lb_localizations.SelectedItem);
			ef.ShowDialog();
			string ename = ef.editname;
			System.IO.File.Move(System.IO.Path.Combine(EditorBackend.Directory, old), System.IO.Path.Combine(EditorBackend.Directory, ename));
			lb_localizations.Items.Add(ename);
			EditorBackend.LoadLanguages(EditorBackend.Directory);
		}

		private void cms_copy_Click(object sender, EventArgs e)
		{
			if (lb_localizations.SelectedItem == null)
				return;
			string old = (string)lb_localizations.SelectedItem;
			EditForm ef = new EditForm(false);
			ef.ShowDialog();
			string ename = ef.editname;
			System.IO.File.Copy(System.IO.Path.Combine(EditorBackend.Directory,old), System.IO.Path.Combine(EditorBackend.Directory,ename));
			lb_localizations.Items.Add(ename);
			EditorBackend.LoadLanguages(EditorBackend.Directory);
		}

		private void ts_exit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
