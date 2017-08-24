using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileShowroom
{
    public enum Category
    {
        TwoWheeler,
        ThreeWheeler,
        FourWheeler
    }
    public enum Color
    {
        Red,
        Yellow,
        Violet,
        Green,
        Orange,
        Purple,
        Indigo,
        Black,
        Silver,
        Magenta,
        Gold
    }
    public class Vehicle
    {
        public string Name { get; private set; }
        public DateTime Mfgdate { get; private set; }     //Manufacturing Date for Vehicle
        public Color Color { get; private set; }
        public string Model { get; private set; }
        public decimal Cost { get; private set; }

        public Vehicle(string name, DateTime mfgdate, Color colorname, string model, decimal cost)
        {
            Name = name;
            Mfgdate = mfgdate;
            Color = colorname;
            Model = model;
            Cost = cost;
        }
    }
}
