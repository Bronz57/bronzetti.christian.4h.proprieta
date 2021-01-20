using System;

namespace bronzetti.christian._4H.proprieta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programma \"Proprietà\" scritto da Christian Bronzetti");
            
            Quadrato q = new Quadrato(-10);

            Console.WriteLine(q);
           
           q.Lato = 20;
            Console.WriteLine(q);

           q.Area = 144;
           Console.WriteLine(q);

            for(int val =2; val <10; val++)
            {
                q.Lato++;
                 Console.WriteLine(q);
            }

           q.Lato= -35;
           Console.WriteLine(q);
        }
    }

    class Quadrato
    {
        //field lato
        private double _lato;

        //field area, è ridontante e viene da una progettazione errata della classe
        //è sufficinte infatti Lato per esprimere lo stato di un quadrato
        private double _area;

        public double Lato //property lato
        {
            //se nella property c'è solo il get, sto facendo una property read only
            get
            {
                return _lato;
            }

            //con set la property diventa RW
            set
            {
                 if(value >=0 )
                {
                _lato = value;
                _area = Math.Pow(_lato,2);
                }
                else
                {
                    _lato = -value;
                    _area = Math.Pow(_lato,2);
                }   
            }
        }

        public double Area //property lato
        {
            get
            {
                return Math.Pow(_lato,2);
            }

            set
            {
                _lato = Math.Sqrt(value);
            }
        }
        public Quadrato() //costruttore default
        {

        }

        //costruttore che parte dal lato...
        public Quadrato(double lato)
        {
           Lato = lato;           
        }

        public override string ToString()
        {
            return $"Lato: {Lato}, Area: {Area}";
        }
    }
}
