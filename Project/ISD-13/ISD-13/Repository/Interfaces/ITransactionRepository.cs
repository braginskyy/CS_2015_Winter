﻿using ISD_13.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_13.Repository.Interfaces
{
    interface ITransactionRepository : IRepository<Transaction>
    {
        IEnumerable<Transaction> TopTenBySum();
    }
}
