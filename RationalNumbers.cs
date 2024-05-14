
namespace OOP_laba1_RationalNumbers
{
    public sealed class RationalNumbers
    {
        public int Numerator { get; private set; }
        public int Denominator { get; private set; }

       private void Reduction()
       {
            for (int i = 2; i <= Math.Min(Math.Abs(Denominator), Math.Abs(Numerator)); i++)
            {
                if (Denominator % i == 0 && Numerator % i == 0)
                {
                    Numerator /= i;
                    Denominator /= i;
                    i--;
                }
            }
       }

        public override string ToString()
        {
            if (Numerator % Denominator == 0)
                return $"{Numerator}";

            else
               return $"{Numerator}/{Denominator}";
        }



        public static RationalNumbers operator +(RationalNumbers obj1, RationalNumbers obj2)
        {
               return new RationalNumbers(obj1.Numerator * obj2.Denominator + obj2.Numerator * obj1.Denominator, obj1.Denominator * obj2.Denominator);
        }

        public static RationalNumbers operator -(RationalNumbers obj1, RationalNumbers obj2)
        {
            return new RationalNumbers(obj1.Numerator * obj2.Denominator - obj2.Numerator * obj1.Denominator, obj1.Denominator * obj2.Denominator);
        }

        public static RationalNumbers operator *(RationalNumbers obj1, RationalNumbers obj2)
        {
                return new RationalNumbers(obj1.Numerator * obj2.Numerator, obj1.Denominator * obj2.Denominator);
        }

        public static RationalNumbers operator /(RationalNumbers obj1, RationalNumbers obj2)
        {
            return new RationalNumbers(obj1.Numerator * obj2.Denominator, obj1.Denominator * obj2.Numerator);
        }

        public static RationalNumbers operator -(RationalNumbers obj1)
        {
            return new RationalNumbers(obj1.Numerator * -1, obj1.Denominator);
        }

        public static bool operator >(RationalNumbers obj1, RationalNumbers obj2)
        {
            if (obj1.Numerator / obj1.Denominator > obj2.Numerator / obj2.Denominator)
                return true;
            else
                return false;
        }

        public static bool operator <(RationalNumbers obj1, RationalNumbers obj2)
        {
            if (obj1.Numerator / obj1.Denominator < obj2.Numerator / obj2.Denominator)
                return true;
            else
                return false;
        }

        public static bool operator ==(RationalNumbers obj1, RationalNumbers obj2)
        {
            if (obj1.Numerator == obj2.Numerator && obj1.Denominator == obj2.Denominator)
                return true;
            else
                return false;
        }

        public static bool operator !=(RationalNumbers obj1, RationalNumbers obj2)
        {
            if (obj1.Numerator == obj2.Numerator && obj1.Denominator == obj2.Denominator)
                return false;
            else
                return true;
        }

        public static bool operator >=(RationalNumbers obj1, RationalNumbers obj2)
        {
            if (obj1.Numerator / obj1.Denominator >= obj2.Numerator / obj2.Denominator)
                return true;
            else
                return false;
        }

        public static bool operator <=(RationalNumbers obj1, RationalNumbers obj2)
        {
            if (obj1.Numerator / obj1.Denominator <= obj2.Numerator / obj2.Denominator)
                return true;
            else
                return false;
        }



        public RationalNumbers(int numerator, int denominator)
        {
            if (denominator == 0)
                throw new Exception("Знаменатель не может быть равен нулю :(");

            if (denominator < 0)
            {
                denominator *= -1;
                Numerator *= -1;
            }

            Numerator = numerator; 
            Denominator = denominator;

            Reduction();
        }
    }
}
