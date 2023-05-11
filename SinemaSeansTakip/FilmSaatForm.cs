using NHibernate;
using SinemaSeansTakip.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SinemaSeansTakip
{
    public partial class FilmSaatForm : Form
    {
        public FilmSaatForm()
        {
            InitializeComponent();
        }

        private void FilmSaatForm_Load(object sender, System.EventArgs e)
        {
           
                IList list = new List<Filmler>();
                try
                {
                    var sessionFactory = CustomSessionFactory.OpenSession();

                    using (var session = sessionFactory.OpenSession())
                    {
                        IQuery q = session.CreateQuery("FROM Filmler");
                        list = q.List();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                cmbFilm.DisplayMember = "Ad";
                cmbFilm.ValueMember = "Id";
                cmbFilm.DataSource = list;
            
        }

        private void FilmSaatForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            SeansForm form = new SeansForm();
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
                    Saatler data = new Saatler
                    {
                        FilmId = Convert.ToInt32(cmbFilm.SelectedValue),
                        SaatDegeri = txtSaat.Text
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
