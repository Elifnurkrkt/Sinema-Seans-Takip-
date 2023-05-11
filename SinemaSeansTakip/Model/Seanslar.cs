using FluentNHibernate.Mapping;
using System.ComponentModel.DataAnnotations.Schema;

namespace SinemaSeansTakip.Model
{
    public class Seanslar
    {
        public virtual long Id { get; set; }
        public virtual long FilmId { get; set; }
        public virtual long SalonId { get; set; }
        public virtual long FilmSaatiId { get; set; }
        public virtual string MusteriAd { get; set; }
        public virtual string MusteriSoyad { get; set; }
        public virtual long MusteriKoltukNo { get; set; }
    }

    public sealed class SeansMap : ClassMap<Seanslar>
    {
        public SeansMap()
        {
            Id(x => x.Id).GeneratedBy.Identity();
            Map(x => x.FilmId);
            Map(x => x.SalonId);
            Map(x => x.FilmSaatiId);
            Map(x => x.MusteriAd);
            Map(x => x.MusteriSoyad);
            Map(x => x.MusteriKoltukNo);
            Table("Seanslar");
        }
    }
}
