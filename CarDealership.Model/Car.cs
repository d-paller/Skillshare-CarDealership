using CarDealership.Model.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarDealership.Model
{
    public class Car : Vehicle
    {
        public int MPG { get; set; }

        public CarTypes Type { get; set; }
    }
}
