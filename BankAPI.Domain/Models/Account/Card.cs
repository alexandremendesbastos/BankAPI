using BankAPI.Domain.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAPI.Domain.Models.Account
{
    public  class Card
    {
        private Card() { }

        public Card (string name, Flag flag)
        {
            Name = name;
            Flag = flag;
        }

        public string Name { get; private set; }
        public Flag Flag { get; private set; }
    }
    public enum Flag
    {
        MasterCard = 0,
        Hipercard = 1,
        Discover = 2,
        AmericanExpress = 3,
        DinersClub = 4,
        Alelo = 5,
        Elo = 6,
        JCB = 7,
        Visa = 8,
    }
}
