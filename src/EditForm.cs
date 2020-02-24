using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoCa_Editor
{
	public partial class EditForm : Form
	{
		bool editmode;
		public string editname;

		public EditForm(bool isedit, string name = "")
		{
			editmode = isedit;
			editname = name;
			InitializeComponent();
		}

		private void EditForm_Load(object sender, EventArgs e)
		{

			tb_name.Text = editname;
		}

		private void bt_save_Click(object sender, EventArgs e)
		{
			editname = tb_name.Text;
			this.Close();
		}
	}
}
