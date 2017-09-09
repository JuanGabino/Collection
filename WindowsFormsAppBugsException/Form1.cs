using System;
using System.Windows.Forms;

namespace WindowsFormsAppBugsException
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			int ope1 = int.Parse(textBox1.Text);
			int ope2 = int.Parse(textBox2.Text);


			try
			{
				double calc = ope1 / ope2;
				labelResult.Text = " Resultado " + calc;
			}
			catch (Exception)
			{
				errorProvider1.SetError(textBox2, "por favor no ingrese 0");

			}





		}
	}
}
