﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalSoftwareSystem20231753
{
    internal interface IRentalManager
    {
        bool AddVehicle(Vehicle v);

        bool DeleteVehicle(string number);

        void ListVehicles();

        void ListOrderedVehicles();

        void GenerateReport(string fileName);
    }
}
