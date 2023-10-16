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
    public partial class frmEvent : Form
    {
        int sonuc = 0;
        public frmEvent()
        {
            InitializeComponent();
        }

        private void frmEvent_MouseMove(object sender, MouseEventArgs e)
        {
            lblText.Text = "Gazi";
            lblKoordinat.Text = e.Location.ToString();
        }

        private void frmEvent_MouseLeave(object sender, EventArgs e)
        {
            lblText.Text = String.Empty;
        }

        private void Topla(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            sonuc += int.Parse(btn.Text);
           
        }


        private void btnSonuc_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"İşlemin sonucu:{sonuc}");
        }
    }
}
