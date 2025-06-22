using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rock_paper_scissors
{
    public partial class frmStartScreen : Form
    {
        public frmStartScreen()
        {
            InitializeComponent();
        }
       public static byte roundsNumber;

        private void btnEnterGame_Click(object sender, EventArgs e)
        {
            if (cbRoundList.SelectedItem != null)
            {
                roundsNumber = Convert.ToByte(cbRoundList.SelectedItem);
                Form frm = new frmMainScreen(roundsNumber, 0);
                frm.ShowDialog();
                this.Close();
            }

            else
                MessageBox.Show("Please choose round before start game", "You must choose round", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmStartScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
