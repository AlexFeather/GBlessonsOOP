namespace OopLesson
{
    public class Fraction
    {
        public int Num
        {
            get { return Num; }
            private set { Num = value; }
        }
        public int Denum
        {
            get { return Denum; }
            private set
            {
                if (value > 0)
                { Denum = value; }
            }
        }

        public Fraction(int num, int denum)
        {
            Num = num;
            Denum = denum;
        }

        public override string ToString()
        {
            return $"{Num}/{Denum}";
        }

        public static Fraction operator %(Fraction a, Fraction b)
        {
            (a, b) = BringToCommonDenum(a, b);
            return new Fraction(a.Num % b.Num, a.Denum);
        }

        public bool TryReduceOnce()
        {
            for (int i = 9; i > 0; i--)
            {
                if (Num % i == 0 & Denum % i == 0)
                {
                    Num = Num / i;
                    Denum = Denum / i;
                    return true;
                }
            }
            return false;
        }

        public void CompleteReduce()
        {
            bool isReducable = true;
            while (isReducable == true)
            {
                isReducable = TryReduceOnce();
            }
        }

        static bool IsDenumCommon(Fraction a, Fraction b)
        {
            if (a.Denum == b.Denum)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static (Fraction newA, Fraction newB) BringToCommonDenum(Fraction a, Fraction b)
        {
            if (IsDenumCommon(a, b))
            {
                return (a, b);
            }
            else
            {
                a.CompleteReduce();
                b.CompleteReduce();
                if (IsDenumCommon(a, b))
                {
                    return (a, b);
                }
                else
                {
                    Fraction newA = new Fraction(a.Num * b.Denum, a.Denum * b.Denum);
                    Fraction newB = new Fraction(b.Num * a.Denum, b.Denum * a.Denum);
                    return (newA, newB);
                }
            }
        }

        public static implicit operator Fraction(int a)
        {
            return new Fraction(a, 1);
        }

        public static explicit operator Fraction(float a)
        {
            string str = a.ToString();
            str = str.Split('.')[1];
            Fraction result = new Fraction((int)(a * (10 ^ str.Length)), 10 * str.Length);
            result.CompleteReduce();
            return result;
        }

        public static explicit operator int(Fraction a)
        {
            var result = a.Num / a.Denum;
            if(a.Num < a.Denum/2)
            {
                return result;
            }
            else
            {
                return ++result;
            }
        }

        public static implicit operator float(Fraction a)
        {
            return a.Num / a.Denum;
        }

        public static Fraction operator +(Fraction a, Fraction b)
        {
            (a, b) = BringToCommonDenum(a, b);
            var result = new Fraction(a.Num + b.Num, a.Denum);
            return result;
        }

        public static Fraction operator -(Fraction a, Fraction b)
        {
            (a, b) = BringToCommonDenum(a, b);
            var result = new Fraction(a.Num - b.Num, a.Denum);
            return result;
        }

        public static Fraction operator *(Fraction a, Fraction b)
        {
            var result = new Fraction(a.Num * b.Num, a.Denum * b.Denum);
            return result;
        }

        public static Fraction operator *(Fraction a, int b)
        {
            var result = new Fraction(a.Num * b, a.Denum);
            return result;
        }

        public static Fraction operator /(Fraction a, Fraction b)
        {
            var result = new Fraction(a.Num * b.Denum, a.Denum * b.Num);
            return result;
        }
        public static Fraction operator /(Fraction a, int b)
        {
            var result = new Fraction(a.Num, a.Denum * b);
            return result;
        }

        public static Fraction operator ++(Fraction a)
        {
            a.Num++;
            return a;
        }

        public static Fraction operator --(Fraction a)
        {
            a.Num--;
            return a;
        }

        public static Fraction operator -(Fraction a)
        {
            return new Fraction(-a.Num, a.Denum);
        }

        public static bool operator ==(Fraction a, Fraction b)
        {
            a.CompleteReduce();
            b.CompleteReduce();
            return a.Num == b.Num && a.Denum == b.Denum;
        }

        public static bool operator !=(Fraction a, Fraction b)
        {
            a.CompleteReduce();
            b.CompleteReduce();
            return a.Num != b.Num || a.Denum != b.Denum;
        }

        public static bool operator >(Fraction a, Fraction b)
        {
            BringToCommonDenum(a, b);
            return a.Num > b.Num;
        }

        public static bool operator <(Fraction a, Fraction b)
        {
            BringToCommonDenum(a, b);
            return a.Num < b.Num;
        }

        public static bool operator >=(Fraction a, Fraction b)
        {
            BringToCommonDenum(a, b);
            return a.Num >= b.Num;
        }

        public static bool operator <=(Fraction a, Fraction b)
        {
            BringToCommonDenum(a, b);
            return a.Num <= b.Num;
        }
    }
}
