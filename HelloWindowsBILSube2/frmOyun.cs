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
        int sure = 10;
        Random rnd = new Random();
        public frmOyun(string ad,string soyad)
        {
            InitializeComponent();
            lblKullanici.Text = $"{ad} {soyad}";
        }

        private void btnYakala_MouseMove(object sender, MouseEventArgs e)
        {
            Button b = (Button)sender;

            b.Location = new Point(rnd.Next(this.ClientSize.Width - b.Width - pnlBilgi.Width), rnd.Next(this.ClientSize.Height - b.Height));

            if (b.Name == "btnYakala")
            {
                skor++;
            }
            else
            {
                skor -= 5;
            }

            lblSkor.Text = skor.ToString();
            if (!tmrSure.Enabled)
            {
                tmrSure.Start();
            }
            if (skor % 10 == 0)
            {
                var btn = new Button();
                btn.Size = new Size(50, 50);
                btn.BackColor = Color.Red;
                btn.Location = new Point(rnd.Next(this.ClientSize.Width - btn.Width - pnlBilgi.Width), rnd.Next(this.ClientSize.Height - btn.Height));
                btn.MouseMove += btnYakala_MouseMove;
                this.Controls.Add(btn);
            }
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
                foreach (Control item in this.Controls)
                {
                    if (item is Button)
                    {
                        item.Enabled = false;
                    }
                }
            }
            sure--;
        }
    }
}
