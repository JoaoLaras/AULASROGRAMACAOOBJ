﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Entities
{
    internal class SavingsAccountPlus : SavingsAccount  //*ERROR* CLASSE SELADA;

    {   //operacao selada nao e possivel sobrescrever *ERROR***
        public override void Withdraw(double amount)
        {

        }

    }
}
