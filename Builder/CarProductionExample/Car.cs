using System.Collections.Generic;

namespace CarProductionExample
{
    abstract class Car
    {
        protected List<string> CompulsoryParts;
        public List<string> OptionallyParts { get; set; }
        protected string model;

        public Car()
        {
            CompulsoryParts = new List<string>() {
                "Rotil", "Salıncak", "Egzantirik Mili", "Krank Mili",
                "Yağ Pompası", "Radyatör","Buji","Tekerlek","Egzost"
            };
            OptionallyParts = new List<string>();
        }

    }
}
