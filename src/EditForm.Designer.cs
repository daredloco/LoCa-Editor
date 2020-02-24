namespace LoCa_Editor
{
	partial class EditForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.bt_save = new System.Windows.Forms.Button();
			this.tb_name = new System.Windows.Forms.TextBox();
			this.l_name = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// bt_save
			// 
			this.bt_save.Location = new System.Drawing.Point(15, 69);
			this.bt_save.Name = "bt_save";
			this.bt_save.Size = new System.Drawing.Size(270, 29);
			this.bt_save.TabIndex = 0;
			this.bt_save.Text = "Add";
			this.bt_save.UseVisualStyleBackColor = true;
			this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
			// 
			// tb_name
			// 
			this.tb_name.Location = new System.Drawing.Point(15, 29);
			this.tb_name.Name = "tb_name";
			this.tb_name.Size = new System.Drawing.Size(270, 22);
			this.tb_name.TabIndex = 1;
			// 
			// l_name
			// 
			this.l_name.AutoSize = true;
			this.l_name.Location = new System.Drawing.Point(12, 9);
			this.l_name.Name = "l_name";
			this.l_name.Size = new System.Drawing.Size(49, 17);
			this.l_name.TabIndex = 2;
			this.l_name.Text = "Name:";
			// 
			// EditForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(297, 110);
			this.Controls.Add(this.l_name);
			this.Controls.Add(this.tb_name);
			this.Controls.Add(this.bt_save);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "EditForm";
			this.Text = "EditForm";
			this.Load += new System.EventHandler(this.EditForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button bt_save;
		private System.Windows.Forms.TextBox tb_name;
		private System.Windows.Forms.Label l_name;
	}
}