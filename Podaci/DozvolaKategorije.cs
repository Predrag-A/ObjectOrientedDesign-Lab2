using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podaci
{
    public enum Kategorija
    {
        AM, A1, A2, A, B1, B, BE, C1, C1E, C, CE, D1, D1E, D, DE, F, M
    }

    public class DozvolaKategorije
    {

        #region Attributes

        Kategorija _kategorije;
        DateTime _datumOd;
        DateTime _datumDo;

        #endregion

        #region Properties
        
        public Kategorija Kategorije { get => _kategorije; set => _kategorije = value; }
        [DisplayName("Kategorija")]
        public string ZaPrikaz { get => _kategorije.ToString(); }
        [DisplayName("Datum izdavanja")]
        public DateTime DatumOd { get => _datumOd; set => _datumOd = value; }
        [DisplayName("Datum isteka")]
        public DateTime DatumDo { get => _datumDo; set => _datumDo = value; }

        #endregion

        #region Constructors

        public DozvolaKategorije()
        {

        }

        public DozvolaKategorije(Kategorija kategorije, DateTime datumOd, DateTime datumDo)
        {
            _kategorije = kategorije;
            _datumOd = datumOd;
            _datumDo = datumDo;
        }

        #endregion

        #region Methods

        public bool Postoji()
        {
            foreach (Kategorija i in Enum.GetValues(typeof(Kategorija)))
                if (_kategorije == i)
                    return true;
            return false;
        }

        public static int ParseIndex(string k)
        {
            switch (k)
            {
                case "AM":
                    return 0;
                case "A1":
                    return 1;
                case "A2":
                    return 2;
                case "A":
                    return 3;
                case "B1":
                    return 4;
                case "B":
                    return 5;
                case "BE":
                    return 6;
                case "C1":
                    return 7;
                case "C1E":
                    return 8;
                case "C":
                    return 9;
                case "CE":
                    return 10;
                case "D1":
                    return 11;
                case "D1E":
                    return 12;
                case "D":
                    return 13;
                case "DE":
                    return 14;
                case "F":
                    return 15;            
            }
            return 16;
        }

        #endregion

    }
}
