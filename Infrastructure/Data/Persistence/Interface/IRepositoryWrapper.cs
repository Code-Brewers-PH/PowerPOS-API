﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Persistence.Interface
{
    public interface IRepositoryWrapper
    {
        IProductRepository Product { get; }
        void Save();
    }
}
