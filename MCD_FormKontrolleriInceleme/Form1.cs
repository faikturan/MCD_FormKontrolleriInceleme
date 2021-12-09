using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCD_FormKontrolleriInceleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            DialogResult resultEnum = MessageBox.Show("Form içerisinde bulunan değerleri silmek istediğinizden emin misiniz?", "Form temizleme işlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultEnum == DialogResult.Yes)
            {
                //formTemizle();
                formElemanIndexTemizle();
            }
            else
            {
                //  işlem iptal edildi....
            }
        }

        private void formTemizle()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox) //item control == TexBox
                {
                    TextBox T = (TextBox)item;
                    T.Text = string.Empty;
                }
            }
        }

        private void formElemanIndexTemizle()
        {
            ((TextBox)this.Controls["txtIsim"]).Text = string.Empty;
            ((TextBox)this.Controls["txtSoyisim"]).Text = string.Empty;
            ((TextBox)this.Controls["txtEmailAdres"]).Text = string.Empty;
            ((TextBox)this.Controls["txtTelefonNumara"]).Text = string.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOnizleme_Click(object sender, EventArgs e)
        {
            frmOnizlemeKayit onizlemeKayit = new frmOnizlemeKayit();
            ((TextBox)onizlemeKayit.Controls["txtIsim"]).Text = txtIsim.Text;
            ((TextBox)onizlemeKayit.Controls["txtSoyisim"]).Text = txtSoyisim.Text;
            ((TextBox)onizlemeKayit.Controls["txtEmailAdres"]).Text = txtEmailAdres.Text;
            ((TextBox)onizlemeKayit.Controls["txtTelefonNumara"]).Text = txtTelefonNumara.Text;
            onizlemeKayit.ShowDialog();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //sanal database içerisine kayıt işlemi olacak...(ödev)
            //formTemizle();
        }
    }
}
