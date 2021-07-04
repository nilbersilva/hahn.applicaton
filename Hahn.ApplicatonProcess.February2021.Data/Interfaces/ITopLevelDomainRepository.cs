﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hahn.ApplicatonProcess.February2021.Data.Interfaces
{
    public interface ITopLevelDomainRepository
    {
        Task<IList<string>> GetTopLevelDomainsAsync(Uri uri);
    }
}
