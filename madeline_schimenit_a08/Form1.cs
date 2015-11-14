using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace madeline_schimenit_a08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void playersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.playersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.baseballDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'baseballDataSet.Players' table. You can move, or remove it, as needed.
            this.playersTableAdapter.Fill(this.baseballDataSet.Players);

        }

        private void buttonSearchLastName_Click(object sender, EventArgs e)
        {
            this.playersTableAdapter.FillByLastName(baseballDataSet.Players, textBoxSearchLastName.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonSearchBattAvg_Click(object sender, EventArgs e)
        {
           // decimal minimum = Convert.ToDecimal( textBoxMin.Text );
           // decimal maximum = Convert.ToDecimal(textBoxMax.Text);
            try
            {
                playersTableAdapter.FillByAvg(baseballDataSet.Players, Convert.ToDecimal(textBoxMin.Text), Convert.ToDecimal(textBoxMax.Text));
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("No values, please try again.", ex.Message);
            }
        }

        private void textBoxMax_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
