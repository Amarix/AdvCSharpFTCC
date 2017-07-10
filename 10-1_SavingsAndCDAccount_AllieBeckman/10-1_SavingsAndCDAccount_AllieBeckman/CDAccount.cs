using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_1_SavingsAndCDAccount_AllieBeckman
{
    class CDAccount : SavingsAccount
    {
        // Field 
        private string _maturityDate;

        // Constructor 
        public CDAccount()
        {
            _maturityDate = "";
        }

        // MaturityDate property 
        public string MaturityDate
        {
            get { return _maturityDate; }
            set { _maturityDate = value; }
        }
    }
}
