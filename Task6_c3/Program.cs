namespace Task6_c3
{
    #region first
    struct time
    {
        public int Second { set; get; }
        public int Minute { set; get; }
        public int Hour { set; get; }
        public static time operator +(time a, time b)
        {
            time t = new time();
            t.Second = a.Second + b.Second;
            t.Minute = a.Minute + b.Minute;
            t.Second = a.Hour + b.Hour;
            return t;
        }
        public static time operator -(time a, time b)
        {
            time t = new time();
            t.Second = a.Second - b.Second;
            t.Minute = a.Minute - b.Minute;
            t.Second = a.Hour - b.Hour;
            return t;
        }
        public static bool operator <(time a, time b)
        {
            if (a.Hour < b.Hour)
                return true;
            else
                return false;
        }
        public static bool operator >(time a, time b)
        {
            if (a.Minute < b.Minute)
                return true;
            else
                return false;
        }
        public static bool operator >=(time a, time b)
        {
            if (a.Hour <= b.Minute)
                return true;
            else
                return false;
        }
        public static bool operator <=(time a, time b)
        {
            if (a.Second >= b.Second)
                return true;
            else
                return false;
        }
        public static time operator ++(time t)
        {
            time t2=new time();
            t2.Hour = t.Hour++;
            return t2;
        }
        public static implicit operator int(time t)
        {
            int x;
            x=t.Hour;
            return x;
        }
        public static implicit operator float(time t)
        {
            int x;
            x=t.Hour;
            return x;
        }
        public static explicit operator string(time t)
        {
            
            return $"{t.Hour} , {t.Minute}, {t.Second}";
        }
       
    }
    #endregion

    #region second
    class test <t>
    {
        t x;
        t y;
        public void seeterX( t x)
        {
            this.x= x;
        }
        public void seeterY( t y)
        {
            this.y= y;
        }
        public t getterX()
        {
            return x;
        }
        public t getterY()
        {
            return y;
        }
    }

    #endregion

    #region third
    abstract class vehicle
    {
        int model;
        public vehicle(int model)
        {
            this.model = model;
        }

    }
    interface Imove
    {
        public void move()
        {
            Console.WriteLine("I can move");
        }
        public void unmove()
        {
            Console.WriteLine("I can move");
        }
    }
    interface Itest
    {
        public void move()
        {
            Console.WriteLine("I can move");
        }
        public void unmove()
        {
            Console.WriteLine("I can move");
        }
    }
    class honda : vehicle,Imove,Itest
    {
        public honda(int model) : base(model)
        {
        }

         void Imove.move()
        {
            Console.WriteLine("I can move");
        }
        void Imove.unmove()
        {
            Console.WriteLine("I can move");
        }
        void Itest.move()
        {
            Console.WriteLine("I can move");
        }
        void Itest.unmove()
        {
            Console.WriteLine("I can move");
        }
    }
    class cart : vehicle
    {
        public cart(int model) : base(model)
        {
        }
    }
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            time time = new time();
            time.Hour = 20;
        }
    }
}
