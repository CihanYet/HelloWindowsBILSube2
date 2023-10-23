using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWindowsBILSube2
{
    public partial class frmOyun : Form
    {
        int skor = 0;
        int sure = 3;
        public frmOyun()
        {
            InitializeComponent();
        }

        private void btnYakala_MouseMove(object sender, MouseEventArgs e)
        {
            var rnd = new Random();
            btnYakala.Location = new Point(rnd.Next(this.ClientSize.Width - btnYakala.Width - pnlBilgi.Width), rnd.Next(this.ClientSize.Height - btnYakala.Height));
            skor++;
            lblSkor.Text = skor.ToString();
            tmrSure.Start();
        }

        private void frmOyun_SizeChanged(object sender, EventArgs e)
        {
            //pnlBilgi.Location = new Point(this.ClientSize.Width - pnlBilgi.Width, 0);
            //pnlBilgi.Height = this.ClientSize.Height;
        }

        private void tmrSure_Tick(object sender, EventArgs e)
        {
            lblSure.Text = sure.ToString();
            
            if (sure == 0)
            {
                tmrSure.Stop();
                MessageBox.Show("Süreniz doldu!");
                btnYakala.Enabled= false;   
            }
            sure--;
        }
    }
}
