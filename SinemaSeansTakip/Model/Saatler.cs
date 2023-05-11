using FluentNHibernate.Mapping;
using System.ComponentModel.DataAnnotations.Schema;

namespace SinemaSeansTakip.Model
{
    
    public class Saatler
    {
        public virtual int Id { get; set; }
        public virtual int FilmId { get; set; }
        public virtual string SaatDegeri { get; set; }
    }

    public class SaatlerMap : ClassMap<Saatler>
    {
        public SaatlerMap()
        {
            Id(x => x.Id).GeneratedBy.Identity();
            Map(x => x.FilmId);
            Map(x => x.SaatDegeri);
            Table("Saatler");
        }
    }
}
