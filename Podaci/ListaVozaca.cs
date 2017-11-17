using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podaci
{
    public class ListaVozaca
    {
        public delegate bool SortDelegate(Vozac v1, Vozac v2);
        public SortDelegate SortListDelegate { get; set; }

        List<Vozac> _listaVozaca;

        public List<Vozac> ListaVozacaValues { get { return _listaVozaca; } }

        private ListaVozaca()
        {
            _listaVozaca = new List<Vozac>();
        }

        public Vozac getVozac(string brDozvole)
        {
            foreach (var v in _listaVozaca)
                if (v.BrojDozvole == brDozvole)
                    return v;
            return null;
        }

        public bool dodajVozaca(Vozac v)
        {
            var tmp = getVozac(v.BrojDozvole);
            if (tmp != null)
                return false;
            _listaVozaca.Add(v);
            return true;
        }

        public bool izmeniVozaca(Vozac v)
        {
            var tmp = getVozac(v.BrojDozvole);
            if (tmp == null)
                return false;
            tmp.Ime = v.Ime;
            tmp.Prezime = v.Prezime;
            tmp.ListaKategorija = v.ListaKategorija;
            tmp.ListaZabrana = v.ListaZabrana;
            tmp.DatumRodjenja = v.DatumRodjenja;
            tmp.DozvolaDo = v.DozvolaDo;
            tmp.DozvolaOd = v.DozvolaOd;
            tmp.MestoIzdavanja = v.MestoIzdavanja;
            tmp.Pol = v.Pol;
            return true;
        }

        static ListaVozaca _instance = null;
        public static ListaVozaca Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ListaVozaca();
                return _instance;
            }
        }
        
    }
}
