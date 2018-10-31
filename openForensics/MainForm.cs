using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace openForensics
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			BackColor = Color.FromArgb(45, 45, 45);
			ForeColor = Color.FromArgb(241, 241, 241);
			label1.ForeColor = ForeColor;
			label1.FlatStyle = FlatStyle.Flat;
			textBox1.BackColor = Color.FromArgb(30, 30, 30);
			textBox1.ForeColor = ForeColor;
			textBox1.BorderStyle = BorderStyle.FixedSingle;
			button1.ForeColor = ForeColor;
			button1.FlatStyle = FlatStyle.Flat;
			button1.FlatAppearance.BorderColor = Color.FromArgb(67, 67, 67);
			button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(27, 27, 27);
			button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 62, 62);
			button1.FlatAppearance.CheckedBackColor = Color.FromArgb(30, 30, 30);
			checkBox1.ForeColor = ForeColor;
			checkBox1.BackColor = BackColor;
			checkBox1.FlatStyle = FlatStyle.Flat;
			checkBox1.FlatAppearance.BorderColor= Color.FromArgb(67, 67, 67);
			checkBox1.FlatAppearance.MouseDownBackColor = Color.FromArgb(27, 27, 27);
			checkBox1.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 62, 62);
			checkBox1.FlatAppearance.CheckedBackColor = Color.FromArgb(30, 30, 30);
			radioButton1.ForeColor = ForeColor;
			radioButton1.BackColor = BackColor;
			radioButton1.FlatStyle = FlatStyle.Flat;
			radioButton1.FlatAppearance.BorderColor = Color.FromArgb(67, 67, 67);
			radioButton1.FlatAppearance.MouseDownBackColor = Color.FromArgb(27, 27, 27);
			radioButton1.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 62, 62);
			radioButton1.FlatAppearance.CheckedBackColor = Color.FromArgb(30, 30, 30);
			comboBox1.ForeColor = ForeColor;
			comboBox1.BackColor = Color.FromArgb(51, 51, 51);
			comboBox1.FlatStyle = FlatStyle.Flat;
			numericUpDown1.ForeColor = ForeColor;
			numericUpDown1.BackColor = Color.FromArgb(51, 51, 51);
			numericUpDown1.BorderStyle = BorderStyle.FixedSingle;
		}
	}
}
