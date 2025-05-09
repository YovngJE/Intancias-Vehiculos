using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_P_Clase_II_10_Instacias
{
    public class Vehiculo
    {
       public string matricula { get; set; }
        public string modelo { get; set; }
        public int cv { get; set; }

        public Vehiculo() { }

    }

    public class Taxi : Vehiculo
    {
        public int numLicen { get; set; }

        public Taxi() { }
    }

    public class Autobus : Vehiculo
    {
        public int numeroPlazos { get; set; }

        public Autobus() { }
    }
}
