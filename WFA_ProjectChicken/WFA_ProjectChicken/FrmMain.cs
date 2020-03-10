using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_ProjectChicken
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();


        }



        private void cbChicken_CheckedChanged(object sender, EventArgs e)
        {
            pbChicken.Visible = true;
            if (!cbChicken.Checked) pbChicken.Visible = false;
            AllChecked();
        }

        private void cbCock_CheckedChanged(object sender, EventArgs e)
        {
            pbCock.Visible = true;
            if (!cbCock.Checked) pbCock.Visible = false;
            AllChecked();
        }

        private void cbFood_CheckedChanged(object sender, EventArgs e)
        {
            pbFood.Visible = true;
            if (!cbFood.Checked) pbFood.Visible = false;
            AllChecked();
        }

        private void cbScafander_CheckedChanged(object sender, EventArgs e)
        {
            pbScafander.Visible = true;
            if (!cbScafander.Checked) pbScafander.Visible = false;
            AllChecked();
        }


        private void cbSpaceship_CheckedChanged(object sender, EventArgs e)
        {
            pbSpaceship.Visible = true;
            if (!cbSpaceship.Checked) pbSpaceship.Visible = false;
            AllChecked();
        }


        private  void AllChecked()
        {
            btnTakeOff.Enabled = false;
            if (cbChicken.Checked && cbCock.Checked
              && cbFood.Checked && cbScafander.Checked &&
              cbSpaceship.Checked)
            {
                btnTakeOff.Enabled = true;
            }
        }

        private void btnTakeOff_Click(object sender, EventArgs e)
        {
            var frm = new FrmSuccess();
            frm.ShowDialog();
        }

        private void cbMusk_CheckedChanged(object sender, EventArgs e)
        {
            var frm = new FrmTesla();
            frm.ShowDialog();
        }
    }
}
