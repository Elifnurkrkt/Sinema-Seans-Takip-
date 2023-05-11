using FluentNHibernate.Mapping;
using System.ComponentModel.DataAnnotations.Schema;

namespace SinemaSeansTakip.Model
{
    public class Filmler
    {
        public virtual int Id { get; set; }
        public virtual string Ad { get; set; }
        public virtual string YonetmenAdi { get; set; }
    }

    public sealed class FilmMap : ClassMap<Filmler>
    {
        public FilmMap()
        {
            Id(x => x.Id).GeneratedBy.Identity();
            Map(x => x.Ad);
            Map(x => x.YonetmenAdi);
            Table("Filmler");
        }
    }
}
