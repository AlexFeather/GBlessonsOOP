using System;
using System.Collections.Generic;
using System.Text;

namespace OopLesson
{
    class AccountsBase
    {
        List<Account> AccountsList = new List<Account>();

        public bool CheckId(Account subject)
        {
            if (AccountsList.Find(x => x.Id.Equals(subject.Id)) != null)
                return false;
            else return true;

        }
    }
}
