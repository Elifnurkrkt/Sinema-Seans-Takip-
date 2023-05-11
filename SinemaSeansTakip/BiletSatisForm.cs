using SinemaSeansTakip.Model;
using System;
using System.Windows.Forms;

namespace SinemaSeansTakip
{
    public partial class BiletSatisForm : Form
    {
        public BiletSatisForm()
        {
            InitializeComponent();
        }

        public int filmId = 0;
        public int salonId = 0;
        public int saatId = 0;

        public string filmAdi = string.Empty;
        public string saati = string.Empty;
        public string salonAdi = string.Empty;
        public int secilenKoltukNo = 0;

        private void BiletSatisForm_Load(object sender, EventArgs e)
        {
            SeansForm seansForm = new SeansForm();
            lblFilmAd.Text = filmAdi;
            lblKoltuk.Text = secilenKoltukNo.ToString();
            lblSalon.Text = salonAdi;
            lblSeans.Text = saati;
        }

        private void BiletSatisForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            SeansForm form = new SeansForm();

            form.salonId = salonId;
            form.saatId = saatId;
            form.filmId = filmId;

            this.Hide();
            form.Show();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                var sessionFactory = CustomSessionFactory.OpenSession();

                using (var session = sessionFactory.OpenSession())
                {
                    Seanslar data = new Seanslar
                    {
                        FilmId = filmId,
                        FilmSaatiId = saatId,
                        MusteriAd = txtAd.Text,
                        MusteriSoyad = txtSoyad.Text,
                        SalonId = salonId,
                        MusteriKoltukNo = secilenKoltukNo
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
    }
}
