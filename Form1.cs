using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Converter
{
    public partial class Form1 : Form
    {
        public int syst1, syst2, number, number2;
        public Form1()
        {
            InitializeComponent();
        }
		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			
		}

		private void combo_SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}

		private void label3_Click(object sender, EventArgs e)
		{
			
		}

		private void label2_Click(object sender, EventArgs e)
		{
			
		}

		private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}

		private void label4_Click(object sender, EventArgs e)
		{
			
		}
		public int any_to_ten(int number, int syst)
        {
			char newnum;
			int z = 0;
			int num2 = 0;
			int rrr;
			string numS = Convert.ToString(number);
			int j = numS.Length;
			for (int i = j - 1; i >= 0; i--)
			{
				newnum = numS[z];
				rrr = newnum - '0';
				z++;
				num2 = num2 + (rrr * Convert.ToInt32(Math.Pow(syst, Convert.ToDouble(i))));
			}
			return num2;
		}
		//
		//
		//
		//
		//
        public string ten_to_sixteen(int number)
		{
			string str = "";
			int x = 0;
			string[] cnum = new string[x];
			for (int i = 0; number != 0; i++)
			{
				Array.Resize(ref cnum, cnum.Length + 1);
				x++;
				if(number%16 < 10)
				{
					cnum[i] = (number % 16).ToString();
				}
				else if(number%16 >= 10)
				{
					switch(number%16)
					{
						case 10:
							cnum[i] = "A";
							break;
						case 11:
							cnum[i] = "B";
							break;
						case 12:
							cnum[i] = "C";
							break;
						case 13:
							cnum[i] = "D";
							break;
						case 14:
							cnum[i] = "E";
							break;
						case 15:
							cnum[i] = "F";
							break;
					}
				}
				number = number / 16;
			}
			for (int i = cnum.Length - 1; i >= 0; i--)
			{
				str = str + cnum[i];
			}
			return str;
		}
		//
		//
		//
		//
		public int sixteen_to_ten(string str)
		{
			int[] mas = new int[str.Length];
			for(int i = 0; i<str.Length; i++)
			{
				if (str[i].ToString() == "A" || str[i].ToString() == "B" || str[i].ToString() == "C" || str[i].ToString() == "D" || str[i].ToString() == "E" || str[i].ToString() == "F")
				{
					switch (str[i].ToString())
					{
						case "A":
							mas[i] = 10;
							break;
						case "B":
							mas[i] = 11;
							break;
						case "C":
							mas[i] = 12;
							break;
						case "D":
							mas[i] = 13;
							break;
						case "E":
							mas[i] = 14;
							break;
						case "F":
							mas[i] = 15;
							break;
					}
				}
				else
				{
					mas[i] = str[i] - '0';
				}
			}
			int z = mas.Length - 1, num2 = 0;
			for (int i = 0; i < mas.Length; i++)
			{
				num2 = num2 + (mas[i] * Convert.ToInt32(Math.Pow(16, Convert.ToDouble(z))));
				z--;
			}
			return num2;
		}
		//
		//
		//
		//
        public string ten_to_any(int number, int syst)
        {
			int x = 0;
			string str = "";
			int[] cnum = new int[x];
			for(int i = 0; number!=0; i++)
			{
				Array.Resize(ref cnum, cnum.Length+1);
				x++;
				cnum[i] = Convert.ToChar(number % syst);
				number = number / syst;
			}
			for(int i = cnum.Length - 1; i>=0; i--)
			{
				str = str + cnum[i];
			}
			return str; 
        }
        private void button1_Click(object sender, EventArgs e)
        {

			if (syst1 == syst2)
			{
				label3.Text = textBox1.Text;
			}
			syst1 = Convert.ToInt32(comboin.SelectedItem);
            syst2 = Convert.ToInt32(comboout.SelectedItem);
			if (syst1 != syst2 && syst1!=16)
            {
				int number = Convert.ToInt32(textBox1.Text);
				int l = any_to_ten(number, syst1);
				if(syst2 == 16)
				{			
					string r = ten_to_sixteen(l);
					label3.Text = r;
				}
				else if(syst2!=16)
				{
					label3.Text = ten_to_any(l, syst2);
				}
		    }
            if(syst1 == 16 && syst1!=syst2)
			{
				string number_string = textBox1.Text;
				int l = sixteen_to_ten(number_string);
				label3.Text = ten_to_any(l, syst2);
			}
		}
	}
}
