using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Dialect;
using NHibernate.Driver;
using NHibernate.Tool.hbm2ddl;
using SinemaSeansTakip.Model;
using System.IO;

namespace SinemaSeansTakip
{
    public static class CustomSessionFactory
    {
        public static ISessionFactory OpenSession()
        {          
            ISessionFactory sessionFactory = Fluently.Configure()
                .Database(SQLiteConfiguration.Standard
                 .ConnectionString(Baglanti.ConnectionString).ShowSql
                )
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Seanslar>())
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Saatler>())
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Salonlar>())
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Filmler>())
                .ExposeConfiguration(cfg => new SchemaExport(cfg)
                .Create(false, false))
                .BuildSessionFactory();
            return sessionFactory;

        }


    }
}
