﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern_04_Vehiculos
{
    public interface IVehiculoFactory
    {
        IGamaAlta GetGamaAlta();
        IGamaMedia GetGamaMedia();
        IGamaBaja GetGamaBaja();
    }
}
