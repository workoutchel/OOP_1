using OOP_laba1_RationalNumbers;


namespace Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1, 1, 2, 5, "7/5")]
        [InlineData(1, 2, 9, 5, "23/10")]
        [InlineData(8, 4, 7, 19, "45/19")]
        [InlineData(-28, 5, 87, 2, "379/10")]
        public void SummationTest(int n1, int n2, int n3, int n4, string test)
        {
            var Num1 = new RationalNumbers(n1, n2);
            var Num2 = new RationalNumbers(n3, n4);

            Num2 += Num1;

            Assert.Equivalent(Num2.ToString(), test);
        }


        [Theory]
        [InlineData(1, 1, 2, 5, "-3/5")]
        [InlineData(1, 2, 9, 5, "13/10")]
        [InlineData(8, 4, 7, 19, "-31/19")]
        [InlineData(-28, 5, 87, 2, "491/10")]
        public void SubtractionTest(int n1, int n2, int n3, int n4, string test)
        {
            var Num1 = new RationalNumbers(n1, n2);
            var Num2 = new RationalNumbers(n3, n4);

            Num2 -= Num1;

            Assert.Equivalent(Num2.ToString(), test);
        }


        [Theory]
        [InlineData(1, 1, 2, 5, "2/5")]
        [InlineData(1, 2, 9, 5, "9/10")]
        [InlineData(8, 4, 7, 19, "14/19")]
        [InlineData(-28, 5, 87, 2, "-1218/5")]
        public void MultiplicationTest(int n1, int n2, int n3, int n4, string test)
        {
            var Num1 = new RationalNumbers(n1, n2);
            var Num2 = new RationalNumbers(n3, n4);

            Num2 *= Num1;

            Assert.Equivalent(Num2.ToString(), test);
        }


        [Theory]
        [InlineData(1, 1, 2, 5, "2/5")]
        [InlineData(1, 2, 9, 5, "18/5")]
        [InlineData(8, 4, 7, 19, "7/38")]
        [InlineData(-28, 5, 87, 2, "-435/56")]
        public void DivisionTest(int n1, int n2, int n3, int n4, string test)
        {
            var Num1 = new RationalNumbers(n1, n2);
            var Num2 = new RationalNumbers(n3, n4);

            Num2 /= Num1;

            Assert.Equivalent(Num2.ToString(), test);
        }


        [Theory]
        [InlineData(1, 1, 2, 5, false)]
        [InlineData(1, 2, 9, 5, false)]
        [InlineData(8, 4, 7, 19, false)]
        [InlineData(-28, 5, 87, 2, false)]
        [InlineData(-78, 4, 78, -4, true)]
        [InlineData(7, 1, 14, 2, true)]
        [InlineData(1, 18, 1, 18, true)]
        [InlineData(-7, 49, 1, -7, true)]
        public void EqualityTest(int n1, int n2, int n3, int n4, bool test)
        {
            var Num1 = new RationalNumbers(n1, n2);
            var Num2 = new RationalNumbers(n3, n4);

            Assert.Equivalent(Num1 == Num2, test);
        }


        [Theory]
        [InlineData(1, 1, 2, 5, true)]
        [InlineData(1, 2, 9, 5, true)]
        [InlineData(8, 4, 7, 19, true)]
        [InlineData(-28, 5, 87, 2, true)]
        [InlineData(-78, 4, 78, -4, false)]
        [InlineData(7, 1, 14, 2, false)]
        [InlineData(1, 18, 1, 18, false)]
        [InlineData(-7, 49, 1, -7, false)]
        public void NotEqualityTest(int n1, int n2, int n3, int n4, bool test)
        {
            var Num1 = new RationalNumbers(n1, n2);
            var Num2 = new RationalNumbers(n3, n4);

            Assert.Equivalent(Num1 != Num2, test);
        }


        [Theory]
        [InlineData(1, 1, 2, 5, true)]
        [InlineData(1, 2, 9, 5, false)]
        [InlineData(8, 4, 7, 19, true)]
        [InlineData(-28, 5, 87, 2, false)]
        [InlineData(-78, 4, 78, -4, false)]
        [InlineData(7, 1, 14, 2, false)]
        [InlineData(1, 18, 1, 18, false)]
        [InlineData(-7, 49, 1, -7, false)]
        public void BiggerTest(int n1, int n2, int n3, int n4, bool test)
        {
            var Num1 = new RationalNumbers(n1, n2);
            var Num2 = new RationalNumbers(n3, n4);

            Assert.Equivalent(Num1 > Num2, test);
        }


        [Theory]
        [InlineData(1, 1, 2, 5, false)]
        [InlineData(1, 2, 9, 5, true)]
        [InlineData(8, 4, 7, 19, false)]
        [InlineData(-28, 5, 87, 2, true)]
        [InlineData(-78, 4, 78, -4, false)]
        [InlineData(7, 1, 14, 2, false)]
        [InlineData(1, 18, 1, 18, false)]
        [InlineData(-7, 49, 1, -7, false)]
        public void SmallerTest(int n1, int n2, int n3, int n4, bool test)
        {
            var Num1 = new RationalNumbers(n1, n2);
            var Num2 = new RationalNumbers(n3, n4);

            Assert.Equivalent(Num1 < Num2, test);
        }


        [Theory]
        [InlineData(1, 1, 2, 5, false)]
        [InlineData(1, 2, 9, 5, true)]
        [InlineData(8, 4, 7, 19, false)]
        [InlineData(-28, 5, 87, 2, true)]
        [InlineData(-78, 4, 78, -4, true)]
        [InlineData(7, 1, 14, 2, true)]
        [InlineData(1, 18, 1, 18, true)]
        [InlineData(-7, 49, 1, -7, true)]
        public void SmallerOrEqualityTest(int n1, int n2, int n3, int n4, bool test)
        {
            var Num1 = new RationalNumbers(n1, n2);
            var Num2 = new RationalNumbers(n3, n4);

            Assert.Equivalent(Num1 <= Num2, test);
        }


        [Theory]
        [InlineData(1, 1, 2, 5, true)]
        [InlineData(1, 2, 9, 5, false)]
        [InlineData(8, 4, 7, 19, true)]
        [InlineData(-28, 5, 87, 2, false)]
        [InlineData(-78, 4, 78, -4, true)]
        [InlineData(7, 1, 14, 2, true)]
        [InlineData(1, 18, 1, 18, true)]
        [InlineData(-7, 49, 1, -7, true)]
        public void BiggerOrEqualityTest(int n1, int n2, int n3, int n4, bool test)
        {
            var Num1 = new RationalNumbers(n1, n2);
            var Num2 = new RationalNumbers(n3, n4);

            Assert.Equivalent(Num1 >= Num2, test);
        }


    }
}
