using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Transform;
using SinemaSeansTakip.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SinemaSeansTakip
{
    public partial class SeansForm : Form
    {
        public SeansForm()
        {
            InitializeComponent();
        }

        public int koltukSiraBaslangic = 1;
        private List<Button> buttonList = new List<Button>();
        public int filmId = 0;
        public int salonId = 0;
        public int saatId = 0;

        public string filmAdi = string.Empty;
        public string saati = string.Empty;
        public string salonAdi = string.Empty;
        public int secilenKoltukNo = 0;

        private void SeansForm_Load(object sender, EventArgs e)
        {
            SaatleriGetir();
            FilmleriGetir();
            SalonlariGetir();


            //TODO: oluşturma işlemi kapasiteye göre getirilecek
            ButonlarıOlustur(4);

            if (filmId > 0 && salonId > 0 && saatId > 0)
            {
                Ara();
            }
        }

        private void ButonlarıOlustur(int sayi)
        {
            if (sayi > 0)
            {
                for (int i = 0; i < sayi; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        Button button = new Button();
                        button.Size = new Size(65, 65);
                        button.Location = new Point(j * 65, i * 65);
                        button.Text = $"Koltuk {koltukSiraBaslangic}";
                        button.Click += new EventHandler(Button_Click);
                        panel1.Controls.Add(button);

                        buttonList.Add(button);

                        koltukSiraBaslangic++;
                    }
                }
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            secilenKoltukNo = Convert.ToInt32(button.Text.Replace("Koltuk ", ""));

            if (button.BackColor == Color.Red)
            {
                List<Seanslar> list = new List<Seanslar>();

                var sessionFactory = CustomSessionFactory.OpenSession();

                using (var session = sessionFactory.OpenSession())
                {
                    var q = session.CreateSQLQuery($"SELECT * FROM Seanslar WHERE MusteriKoltukNo = :param AND FilmId = :param2");
                    q.SetParameter("param", secilenKoltukNo);
                    q.SetParameter("param2", filmId);

                    IList<Seanslar> results = q.SetResultTransformer(Transformers.AliasToBean(typeof(Seanslar)))
                                  .List<Seanslar>();

                    list = (List<Seanslar>)results;
                }



                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = list.Select(c=> new { c.Id, c.MusteriAd, c.MusteriSoyad, c.MusteriKoltukNo });

                dataGridView1.DataSource = bindingSource;
            }
            else
            {

                if (secilenKoltukNo > 0)
                {
                    BiletSatisForm form = new BiletSatisForm();
                    form.filmAdi = filmAdi;
                    form.salonAdi = salonAdi;
                    form.saati = saati;
                    form.secilenKoltukNo = secilenKoltukNo;

                    form.filmId = filmId;
                    form.saatId = saatId;
                    form.salonId = salonId;

                    Hide();
                    form.Show();
                }
            }
        }

        private void SaatleriGetir()
        {
            List<Saatler> list = new List<Saatler>();
            try
            {
                var sessionFactory = CustomSessionFactory.OpenSession();

                using (var session = sessionFactory.OpenSession())
                {
                    IList<Saatler> q = session.CreateQuery("FROM Saatler").List<Saatler>();
                    list = (List<Saatler>)q;
                }
            }
            catch (Exception ex)    
            {
                MessageBox.Show(ex.Message);
            }

            cmbTarih.DisplayMember = "SaatDegeri";
            cmbTarih.ValueMember = "Id";

            cmbTarih.DataSource = list;
        }

        private void FilmleriGetir()
        {
            List<Filmler> list = new List<Filmler>();
            try
            {
                var sessionFactory = CustomSessionFactory.OpenSession();

                using (var session = sessionFactory.OpenSession())
                {
                    IList<Filmler> myClasses = session.QueryOver<Filmler>().List();

                    IList<Filmler> q = session.CreateQuery("FROM Filmler").List<Filmler>();
                    list = (List<Filmler>)q;
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


        private void SalonlariGetir()
        {
            List<Salonlar> list = new List<Salonlar>();
            try
            {
                var sessionFactory = CustomSessionFactory.OpenSession();

                using (var session = sessionFactory.OpenSession())
                {
                    IList<Salonlar> q = session.CreateQuery("FROM Salonlar").List<Salonlar>();
                    list = (List<Salonlar>)q;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            cmbSalon.DisplayMember = "SalonKodu";
            cmbSalon.ValueMember = "Id";
            cmbSalon.DataSource = list;
        }

        private void btnFilmEkle_Click(object sender, EventArgs e)
        {
            FilmForm form = new FilmForm();
            this.Hide();
            form.Show();
        }



        private void btnSalonEkle_Click(object sender, EventArgs e)
        {
            SalonForm form = new SalonForm();
            this.Hide();
            form.Show();
        }

        private void btnSaatEkle_Click(object sender, EventArgs e)
        {
            FilmSaatForm form = new FilmSaatForm();
            this.Hide();
            form.Show();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            Ara();
        }

        private void Ara()
        {
            filmId = Convert.ToInt32(cmbFilm.SelectedValue);
            salonId = Convert.ToInt32(cmbSalon.SelectedValue);
            saatId = Convert.ToInt32(cmbTarih.SelectedValue);

            filmAdi = cmbFilm.Text;
            salonAdi = cmbSalon.Text;
            saati = cmbTarih.Text;

            IList list = new List<Seanslar>();
            List<Seanslar> liste = new List<Seanslar>();

            string sartlar = string.Empty;

            if (filmId > 0 || salonId > 0 || saatId > 0)
            {
                sartlar += "WHERE 1=1 ";


                if (filmId > 0)
                    sartlar += $" AND FilmId = {filmId}";

                if (salonId > 0)
                    sartlar += $" AND SalonId = {salonId}";

                if (saatId > 0)
                    sartlar += $" AND FilmSaatiId = {saatId}";
            }

            try
            {
                var sessionFactory = CustomSessionFactory.OpenSession();

                using (var session = sessionFactory.OpenSession())
                {
                    IList<Seanslar> q = session.CreateQuery($"FROM Seanslar {sartlar}").List<Seanslar>();

                    liste = (List<Seanslar>)q;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            List<int> doluKoltuklar = liste.Select(c => Convert.ToInt32(c.MusteriKoltukNo)).ToList();

            foreach (var item in buttonList)
            {
                int no = Convert.ToInt32(item.Text.Replace("Koltuk ", ""));
                if (doluKoltuklar.Contains(no))
                    item.BackColor = Color.Red;

                else
                    item.BackColor = Color.YellowGreen;
            }
        }
    }

}
