using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace repules.Models
{
    public class pilotak
    {
        public int Id { get; set; }
        [Display(Name = "Név")]
        public string Nev { get; set; }
        [Display(Name = "Dátum")]
        public int SzulDatum { get; set; }
        [Display(Name = "Nemzetiség")]
        public string Nemzet { get; set; }
        [Display(Name = "Rajtszám")]
        public string Rajtszam { get; set; }
        public pilotak()
        { }

        public pilotak(string sor)
        {
            string[] adat = sor.Split(";");
            Nev = adat[0];
            SzulDatum = Convert.ToInt32(adat[1]);
            Nemzet = adat[2];
            Rajtszam = adat[3];
        }
    }
}