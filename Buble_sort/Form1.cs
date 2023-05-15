using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.SymbolStore;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buble_sort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int m;
        char s;

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (txtArray.Text == "")
            { MessageBox.Show("Кількість елементів не введено!", "Помилка"); }
            else
            {
                m = Int32.Parse(txtArray.Text);
                dgvMass.ColumnCount = m;
                for (int j = 0; j < m; j++)
                {
                    dgvMass.Columns[j].Width = 110;

                    dgvMass.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    dgvMass.Columns[j].HeaderText = "Символ №" + (j + 1).ToString();
                }
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            txtBubbleSort.Text = "";
            char[] symbs = new char[m];

            for (int j = 0; j < symbs.Length; j++)
            { symbs[j] = Convert.ToChar(dgvMass.Rows[0].Cells[j].Value); }
            
            for (int i = 1; i <= symbs.Length - 1; i++)
            {
                for (int j = 0; j < symbs.Length - i; j++)
                {
                    if (symbs[j] > symbs[j+1])
                    {
                        s = symbs[j+1];
                        symbs[j + 1] = symbs[j];
                        symbs[j] = s;
                    }
                }
            }

            for (int j = 0; j < symbs.Length; j++)
            { txtBubbleSort.Text += Convert.ToString(symbs[j]) + " "; }
        }
    }
}
