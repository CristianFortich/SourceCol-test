using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SourceCol
{
    public class Car
    {
        public string brand { get; set; }
        public int model { get; set; }
        public string color { get; set; }

        public Car(string brand, int model, string color){
            this.brand = brand;
            this.model = model;
            this.color = color;
        }
    }
}