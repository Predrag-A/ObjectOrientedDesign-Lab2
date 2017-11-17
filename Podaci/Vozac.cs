using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Podaci
{
    public class Vozac
    {

        #region Attributes

        string _ime;
        string _prezime;
        DateTime _datumRodjenja;
        DateTime _dozvolaOd;
        DateTime _dozvolaDo;
        string _brojDozvole;
        string _mestoIzdavanja;
        bool _pol;
        List<DozvolaKategorije> _listaKategorija;
        List<DozvolaKategorije> _listaZabrana;
        string _imgPath;

        #endregion

        #region Properties

        public string Ime { get => _ime; set => _ime = value; }
        public string Prezime { get => _prezime; set => _prezime = value; }
        [DisplayName("Datum rodjenja")]
        public DateTime DatumRodjenja { get => _datumRodjenja; set => _datumRodjenja = value; }
        [DisplayName("Pocetak vazenja dozvole")]
        public DateTime DozvolaOd { get => _dozvolaOd; set => _dozvolaOd = value; }
        [DisplayName("Kraj vazenja dozvole")]
        public DateTime DozvolaDo { get => _dozvolaDo; set => _dozvolaDo = value; }
        [DisplayName("Broj vozacke dozvole")]
        public string BrojDozvole { get => _brojDozvole; set => _brojDozvole = value; }
        [DisplayName("Mesto izdavanja dozvole")]
        public string MestoIzdavanja { get => _mestoIzdavanja; set => _mestoIzdavanja = value; }
        public bool Pol { get => _pol; set => _pol = value; }
        public List<DozvolaKategorije> ListaKategorija { get { return _listaKategorija; } set { _listaKategorija = value; } }
        public List<DozvolaKategorije> ListaZabrana { get { return _listaZabrana; } set { _listaZabrana = value; } }
        public string ImgPath { get => _imgPath; set => _imgPath = value; }


        #endregion

        #region Constructors

        public Vozac()
        {
            _listaKategorija = new List<DozvolaKategorije>();
            _listaZabrana = new List<DozvolaKategorije>();
        }

        public Vozac(string ime, string prezime, DateTime datumRodjenja, DateTime dozvolaOd,
            DateTime dozvolaDo, string brojDozvole, string mestoIzdavanja, bool pol, string imgPath)
        {
            _ime = ime;
            _prezime = prezime;
            _datumRodjenja = datumRodjenja;
            _dozvolaOd = dozvolaOd;
            _dozvolaDo = dozvolaDo;
            _brojDozvole = brojDozvole;
            _mestoIzdavanja = mestoIzdavanja;
            _pol = pol;
            _listaKategorija = new List<DozvolaKategorije>();
            _listaZabrana = new List<DozvolaKategorije>();
            ImgPath = imgPath;
        }

        public Vozac(string ime, string prezime, DateTime datumRodjenja, DateTime dozvolaOd,
            DateTime dozvolaDo, string brojDozvole, string mestoIzdavanja, bool pol,
            List<DozvolaKategorije> listaKategorija, List<DozvolaKategorije> listaZabrana, string imgPath)
        {
            _ime = ime;
            _prezime = prezime;
            _datumRodjenja = datumRodjenja;
            _dozvolaOd = dozvolaOd;
            _dozvolaDo = dozvolaDo;
            _brojDozvole = brojDozvole;
            _mestoIzdavanja = mestoIzdavanja;
            _pol = pol;
            _listaKategorija = listaKategorija;
            _listaZabrana = listaZabrana;
            ImgPath = imgPath;
        }
        #endregion

        #region Methods

        public static bool CompareIme(Vozac v1, Vozac v2)
        {
            if (v1.Ime.CompareTo(v2.Ime) > 0)
                return true;
            return false;
        }

        public static bool ComparePrezime(Vozac v1, Vozac v2)
        {
            if (v1.Prezime.CompareTo(v2.Prezime) > 0)
                return true;
            return false;
        }

        public static bool CompareBroj(Vozac v1, Vozac v2)
        {
            if (v1.BrojDozvole.CompareTo(v2.BrojDozvole) > 0)
                return true;
            return false;
        }

        #endregion
    }
}
