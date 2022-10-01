using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsztalyDia
{
    public abstract class Szemely
    {

        public string _Keresztnev;
        public string _Vezetknev;
        public int _eletkor;
        public long _telefonszam;
        public string _utca;
        public string _varos;
        public string _megye;
        public int _iranyitoszam;
        public string _orszag;

        public string Teljesnev
        {

            get
            {

                return string.Format("{0} {1}", this._Vezetknev, this._Keresztnev);

            }

        }

        public string Lakcim
        {

            get
            {

                return string.Format("\n\t{0}\n\t{1}\n\t{2}\n\t{3}\n\t{4}", this._orszag, this._megye, this._varos, this._utca, this._iranyitoszam);

            }

        }

        public Szemely(string keresztnev, string vezetknev, int eletkor, long telefonszam, string utca, string varos, string megye, int iranyitoszam, string orszag)
        {
            _Keresztnev = keresztnev;
            _Vezetknev = vezetknev;
            _eletkor = eletkor;
            _telefonszam = telefonszam;
            _utca = utca;
            _varos = varos;
            _megye = megye;
            _iranyitoszam = iranyitoszam;
            _orszag = orszag;
        }

        public virtual void Nev()
        {

            Console.WriteLine(string.Format("Neve: {0}", this.Teljesnev));
            Console.WriteLine(string.Format("Életkora: {0}", this._eletkor));
            Console.WriteLine(string.Format("Telefonszáma: {0:+#### ### ####}", this._telefonszam));
            Console.WriteLine(string.Format("Lakhelye: {0}", this.Lakcim));

        }


    }
}
