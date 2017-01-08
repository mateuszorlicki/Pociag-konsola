﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainConsola
{
    class Lokomotywa
    {
        private string model;
        private int masa;

        public Lokomotywa(string model, int masa)
        {
            this.model = model;
            this.masa = masa;
        }

        public int ReturnMasa()
        {
            return this.masa;
        }

        public string Informacje()
        {
            return "Lokomotywa: model: " + model + ", masa: " + masa;
        }
    }
}
