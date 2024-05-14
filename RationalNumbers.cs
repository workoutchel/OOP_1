
namespace OOP_laba1_RationalNumbers
{
    public sealed class RationalNumbers
    {
        public int numerator { get; private set; }
        public int denominator { get; private set; }

        private void Reduction()
        {
            if (numerator % denominator == 0)
            {
                numerator /= denominator;
                denominator = 1;
            }

            else
            {
                for (int i = 2; i <= Math.Min(Math.Abs(denominator), Math.Abs(numerator)); i++)
                {
                    if (denominator % i == 0 && numerator % i == 0)
                    {
                        numerator /= i;
                        denominator /= i;
                        i--;
                    }
                }
            }
        }

        public override string ToString()
        {
            if (numerator % denominator == 0)
                return $"{numerator}";

            else
               return $"{numerator}/{denominator}";
        }


        public static RationalNumbers operator +(RationalNumbers obj1, RationalNumbers obj2)
        {
               return new RationalNumbers(obj1.numerator * obj2.denominator + obj2.numerator * obj1.denominator, obj1.denominator * obj2.denominator);
        }

        public static RationalNumbers operator -(RationalNumbers obj1, RationalNumbers obj2)
        {
            return new RationalNumbers(obj1.numerator * obj2.denominator - obj2.numerator * obj1.denominator, obj1.denominator * obj2.denominator);
        }

        public static RationalNumbers operator *(RationalNumbers obj1, RationalNumbers obj2)
        {
                return new RationalNumbers(obj1.numerator * obj2.numerator, obj1.denominator * obj2.denominator);
        }

        public static RationalNumbers operator /(RationalNumbers obj1, RationalNumbers obj2)
        {
            return new RationalNumbers(obj1.numerator * obj2.denominator, obj1.denominator * obj2.numerator);
        }

        public static RationalNumbers operator -(RationalNumbers obj1)
        {
            return new RationalNumbers(obj1.numerator * -1, obj1.denominator);
        }

        public static bool operator >(RationalNumbers obj1, RationalNumbers obj2)
        {
            if (obj1.numerator / obj1.denominator > obj2.numerator / obj2.denominator)
                return true;
            else
                return false;
        }

        public static bool operator <(RationalNumbers obj1, RationalNumbers obj2)
        {
            if (obj1.numerator / obj1.denominator < obj2.numerator / obj2.denominator)
                return true;
            else
                return false;
        }

        public static bool operator ==(RationalNumbers obj1, RationalNumbers obj2)
        {
            if (obj1.numerator == obj2.numerator && obj1.denominator == obj2.denominator)
                return true;
            else
                return false;
        }

        public static bool operator !=(RationalNumbers obj1, RationalNumbers obj2)
        {
            if (obj1.numerator == obj2.numerator && obj1.denominator == obj2.denominator)
                return false;
            else
                return true;
        }

        public static bool operator >=(RationalNumbers obj1, RationalNumbers obj2)
        {
            if (obj1.numerator / obj1.denominator >= obj2.numerator / obj2.denominator)
                return true;
            else
                return false;
        }

        public static bool operator <=(RationalNumbers obj1, RationalNumbers obj2)
        {
            if (obj1.numerator / obj1.denominator <= obj2.numerator / obj2.denominator)
                return true;
            else
                return false;
        }



        public RationalNumbers(int Num, int Denom)
        {
            if (Denom == 0)
                throw new Exception("Знаменатель не может быть равен нулю :(");

            if (Denom < 0)
            {
                Denom *= -1;
                Num *= -1;
            }

            numerator = Num; 
            denominator = Denom;

            Reduction();
        }
    }
}
