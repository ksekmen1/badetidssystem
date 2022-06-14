using System;
using System.Collections.Generic;
using System.Linq;
namespace Badetidssystem
{
    public class BadeTidsPeriode
    {
        public string _type;
        public DayOfWeek _ugedag;
        public DateTime _starttidspunkt;
        public DateTime _sluttidspunkt;
        public string _Leder;
        public string _aalder;
        private Dictionary<string, Kreds> _kreds;
        public BadeTidsPeriode(string Type, DayOfWeek Ugedag, DateTime Starttidspunkt, DateTime Sluttidspunkt, string Leder, string AAlder)
        {
            _type = Type;
            _ugedag = Ugedag;
            _starttidspunkt = Starttidspunkt;
            _sluttidspunkt = Sluttidspunkt;
            _Leder = Leder;
            _aalder = AAlder;
            _kreds = new Dictionary<string, Kreds>();


            if (_starttidspunkt > _sluttidspunkt)
            {
                throw new ArgumentException($"Starttidspunktet er senere end sluttidspunktet");
            }

            if(_type.Length <= 3)
            {
                throw new ArgumentException("Typen skal mindst indholde 4 tegn!");
            }

            




        }

        

        public string TYPE { get { return _type; } set { _type = value; } }
        public DayOfWeek UGEDAG { get { return _ugedag; } set { _ugedag = value; } }
        public DateTime STARTT { get { return _starttidspunkt; } set { _starttidspunkt = value; } }
        public DateTime SLUTT { get { return _sluttidspunkt; } set { _sluttidspunkt = value; } }
        public string LEDER { get { return _Leder; } set { _Leder = value; } }
        public  string AALDER { get { return _aalder; } set { _aalder = value; } }
        public Dictionary<string, Kreds> Kredse { get { return _kreds; } set { _kreds = value; } }

        

        public void DKreds(string id)
        {
            _kreds.Remove(id);
        }

        public void AddKreds(Kreds k)
        {
            _kreds.Add(k.ID, k);
        }

        public override string ToString()
        {
            foreach (var k in _kreds)
            {
                
                Console.WriteLine("------------------------------------");
                Console.WriteLine($"Navn: {k.Value._navn}");
                Console.WriteLine("------------------------------------");
                
            }
            return $"Aktivitet: Type: {_type} Ugedag: {_ugedag} Start: {_starttidspunkt} Slut: {_sluttidspunkt} Leder: {_Leder}  ANBEFALDET ALDER: {_aalder}";
            
        }



        


    }
}
