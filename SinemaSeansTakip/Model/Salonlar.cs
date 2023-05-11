using FluentNHibernate.Mapping;
using System.ComponentModel.DataAnnotations.Schema;

namespace SinemaSeansTakip.Model
{
    [Table("Salonlar")]
    public class Salonlar
    {
        public virtual int Id { get; set; }
        public virtual string SalonKodu { get; set; }
        public virtual int Kapasite { get; set; }
    }

    public sealed class SalonMap : ClassMap<Salonlar>
    {
        public SalonMap()
        {
            Id(x => x.Id).GeneratedBy.Identity();
            Map(x => x.Kapasite);
            Map(x => x.SalonKodu);
            Table("Salonlar");
        }
    }
}
