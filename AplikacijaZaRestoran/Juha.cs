using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikacijaZaRestoran
{
    public partial class Juha : Form
    {
        public Juha()
        {
            InitializeComponent();
        }

        private Pocetna myForm;

        public Juha(Pocetna form1)
        {
            InitializeComponent();
            myForm = form1;
        }


        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void pilecaJuha_Click(object sender, EventArgs e)
        {
            // Get the DataGridView object from the first form.
            DataGridView dgv = myForm.Narudzba;

            // Create a new row.
            DataGridViewRow row = new DataGridViewRow();

            // Add data to the row.
            DataGridViewCell cell1 = new DataGridViewTextBoxCell();
            cell1.Value = "Pileća juha";
            row.Cells.Add(cell1);

            DataGridViewCell cell2 = new DataGridViewTextBoxCell();
            cell2.Value = "1";
            row.Cells.Add(cell2);

            DataGridViewCell cell3 = new DataGridViewTextBoxCell();
            cell2.Value = "";
            row.Cells.Add(cell3);

            // Add the new row to the DataGridView.
            dgv.Rows.Add(row);
        }
    }
}
