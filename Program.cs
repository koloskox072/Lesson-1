namespace ConsoleApp2
{
    class ulamek
    {
        private int licznik = 0;
        private int mianownik = 0;

        public ulamek(int licznik=0, int mianownik = 1)
        {
            this.licznik = licznik;
            if (mianownik != 0) this.mianownik=mianownik;
        }
        public void wypiszUlamek()
        {
            Console.WriteLine($"{licznik}/{mianownik}");
        }
        public override string ToString()
        {
            return $"{licznik}/{mianownik}";
        }
        public static ulamek operator -(ulamek u)
        {
            return new ulamek(-u.licznik, u.mianownik);
        }
        public static ulamek operator +(ulamek u1, ulamek u2)
        {
            if (u1.mianownik != u2.mianownik)
            {
                int x = u1.mianownik * u2.mianownik;
                int l = u1.licznik * u2.mianownik;
                int m = u2.licznik * u1.mianownik;
                return new ulamek(l + m, x);
            }
            return new ulamek(u1.licznik + u2.licznik, u1.mianownik);
        }
        public static ulamek operator *(ulamek u1, ulamek u2)
        {
            int l = u1.licznik*u2.licznik;
            int m = u1.mianownik*u2.mianownik;
            return new ulamek(l, m);
        }
        public static ulamek operator !(ulamek u)
        {
            int l = u.licznik;
            int m = u.mianownik;
            return new ulamek(m , l);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ulamek u1 = new ulamek(5 , 4);
            ulamek u2 = new ulamek(5 , 2);
            u1.wypiszUlamek();

            int x = 10;
            string xx = x.ToString();
            Console.WriteLine(xx);
            Console.WriteLine(u1);
            Console.WriteLine(-u2);
            Console.WriteLine(u1+u2);
            Console.WriteLine(u1*u2);
            Console.WriteLine(u1);
            Console.WriteLine(!u1);


            
        }
    }
}