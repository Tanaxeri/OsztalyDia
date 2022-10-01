using System;


namespace OsztalyDia
{
    public class Tanulo : Szemely
    {
        public double _atlagosjegy;
        public bool _felveheto;
        public Tanulo(string keresztnev, string vezetknev, int eletkor, long telefonszam, string utca, string varos, string megye, int iranyitoszam, string orszag, double atlagosjegy, bool felveheto) : base(keresztnev, vezetknev, eletkor, telefonszam, utca, varos, megye, iranyitoszam, orszag)
        {

            this._atlagosjegy = atlagosjegy;
            this._felveheto = felveheto;
        }

        

        public override void Nev()
        {

            Console.WriteLine(string.Format("Neve: {0}", this.Teljesnev));
            Console.WriteLine(string.Format("Életkora: {0}", this._eletkor));
            Console.WriteLine(string.Format("Telefonszáma: {0:+#### ### ####}", this._telefonszam));
            Console.WriteLine(string.Format("Lakhelye: {0}", this.Lakcim));
            Console.WriteLine(string.Format("Átlagos jegye: {0}",this._atlagosjegy));
            if (this._felveheto == true)
            {

                Console.WriteLine(string.Format("Felvehető a diák"));

            }
            else
            {

                Console.WriteLine(string.Format("Nem felvehető a diák"));

            }
            

        }

    }
}
