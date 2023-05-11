using SinemaSeansTakip.Model;
using System;
using System.Windows.Forms;

namespace SinemaSeansTakip
{
    public partial class SalonForm : Form
    {
        public SalonForm()
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
                    Salonlar data = new Salonlar
                    {
                        Kapasite = Convert.ToInt32(txtKapasite.Text),
                        SalonKodu = txtSalonKodu.Text
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

        private void SalonForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            SeansForm form = new SeansForm();
            this.Hide();
            form.Show();
        }
    }
}
