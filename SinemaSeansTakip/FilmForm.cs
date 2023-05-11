using SinemaSeansTakip.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaSeansTakip
{
    public partial class FilmForm : Form
    {
        public FilmForm()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                var sessionFactory = CustomSessionFactory.OpenSession();

                using (var session = sessionFactory.OpenSession())
                {
                    Filmler data = new Filmler
                    {
                       Ad = txtFilmAd.Text,
                       YonetmenAdi = txtYonetmen.Text
                    };

                    session.Save(data);
                    session.Flush();
                    MessageBox.Show("Kayıt başarılı");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FilmForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            SeansForm form = new SeansForm();
            this.Hide();
            form.Show();
        }
    }
}
