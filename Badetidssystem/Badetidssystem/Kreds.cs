using System;
namespace Badetidssystem
{
    public class Kreds
    {
        public string _id;
        public string _navn;
        public string _adresse;
        public int _antaldeltagere;
        public string _malder;
        public Kreds(string Id, string Navn, string Adresse, int AntalDeltagere, string Malder)
        {
            _id = Id;
            _navn = Navn;
            _adresse = Adresse;
            _antaldeltagere = AntalDeltagere;
            _malder = Malder;

            if (_antaldeltagere <= 0)
            {
                throw new ArgumentException("Antal deltagere er mindre eller ligemed 0");

            }
            
        }
        public string ID { get { return _id; } set { _id = value; } }
        public string NAVN { get { return _navn; } set { _navn = value; } }
        public string ADRESSE { get { return _adresse; } set { _adresse = value; } }
        public int ANTALD { get { return _antaldeltagere; } set { _antaldeltagere = value; } }
        public string MALDER { get { return _malder; } set { _malder = value; } }

        public override string ToString()
        {
            return $"Id: {_id} Navn: {_navn} Adresse: {_adresse} Mindste alder: {_malder} Antal deltagere: {_antaldeltagere}";
        }

    }
}
