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
    }
}
