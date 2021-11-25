using static OopLesson.Program;

namespace OopLesson
{
    public class Account
    {
        private static int idCounter = 0;

        public int Total { get; private set; }
        public AccountType Type { get; private set; }

        public int Id { get; private set; }


        public Account(AccountType type)
        {
            GenerateId();
            Type = type;
            Total = 0;
        }

        public Account(int initialSum)
        {
            GenerateId();
            Total = initialSum;
        }

        public Account(AccountType type, int initialSum)
        {
            GenerateId();
            Type = type;
            Total = initialSum;
        }


        public int GenerateId()
        {
            idCounter++;
            return idCounter;
        }

        public void DepositIntoAccount(int sum)
        {
            Total += sum;
        }

        public bool WithdrawFromAccount(int sum)
        {
            if (sum <= Total)
            {
                Total -= sum;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool TransferFrom(int sum, Account donator)
        {
            if (donator.WithdrawFromAccount(sum))
            {
                DepositIntoAccount(sum);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Equals(Account obj)
        {
            if (Type == obj.Type && Total == obj.Total && Id == obj.Id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator ==(Account acc1, Account acc2)
        {
            if (acc1.Type == acc2.Type && acc1.Total == acc2.Total && acc1.Id == acc2.Id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Account acc1, Account acc2)
        {
            if (acc1.Type != acc2.Type || acc1.Total != acc2.Total || acc1.Id != acc2.Id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Так как Id у нас уникальны, я решал, что они отлично подойдут для хэш-кода
        public override int GetHashCode()
        {
            return Id;
        }

        public override string ToString()
        {
            return $"Id #{Id}: {Type} type account, {Total} total.";
        }
    }
}
