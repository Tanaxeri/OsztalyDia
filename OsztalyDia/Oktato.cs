using System;


namespace OsztalyDia
{
    public class Oktato : Szemely
    {
        private int _dolgozottev;
        protected int _dolgozokszama;
        private int _kereslet;
        public int _osztalyokszama;
        public Oktato(string keresztnev, string vezetknev, int eletkor, long telefonszam, string utca, string varos, string megye, int iranyitoszam, string orszag, int dolgozottev, int dolgozokszama, int kereslet, int osztalyokszama) : base(keresztnev, vezetknev, eletkor, telefonszam, utca, varos, megye, iranyitoszam, orszag)
        {

            this._dolgozottev = dolgozottev;
            this._dolgozokszama = dolgozokszama;
            this._kereslet = kereslet;
            this._osztalyokszama = osztalyokszama;
        }

        public override void Nev()
        {

            Console.WriteLine(string.Format("Neve: {0}", this.Teljesnev));
            Console.WriteLine(string.Format("Életkora: {0}", this._eletkor));
            Console.WriteLine(string.Format("Telefonszáma: {0:+#### ### ####}", this._telefonszam));
            Console.WriteLine(string.Format("Lakhelye: {0}", this.Lakcim));
            Console.WriteLine(string.Format("Osztályok száma: {0}", this._osztalyokszama));

        }

    }
}
