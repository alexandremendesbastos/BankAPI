using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAPI.Domain.Models.Account
{
    public class AccountCards
    {
        public AccountCards(Card card, int cvv, Agency agency, DateTime expirationDate)
        {
            Card = card;
            CVV = cvv;
            Agency = agency;
            ExpirationDate = expirationDate;
        }

        public Card Card { get; private set; }
        public string CardNumber { get; private set; }
        public int CVV { get; private set; }
        public Agency Agency { get; private set; }
        public DateTime ExpirationDate { get; private set; }

    }
}
