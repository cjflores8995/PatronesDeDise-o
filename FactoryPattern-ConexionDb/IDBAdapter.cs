﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern_ConexionDb
{
    public interface IDBAdapter
    {
        void GetConnection();
    }
}
