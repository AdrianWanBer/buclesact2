namespace buclesact2.servicios
{
    internal class peticionDeNumerosImplementacion : peticionDeNumerosInterfaz
    {        
        ///<sumary>
        ///Metodo que se encargara de la peticion de variables y las enviara a program.cs
        ///<author>251023 - awb</author>
        ///</sumary>
        public int peticionInt()
        {
            ///<sumary>
            ///Peticion del Int
            ///<author>251023 - awb</author>
            ///</sumary>
            Console.WriteLine("Escriba un numero Int: ");
            int numeroInt = Convert.ToInt32(Console.ReadLine());
            return numeroInt;
        }
        public double peticionDouble()
        {
            ///<sumary>
            ///Peticion del Double
            ///<author>251023 - awb</author>
            ///</sumary>
            Console.WriteLine("Escriba un numero Double: ");
            double numeroDouble = Convert.ToDouble(Console.ReadLine());
            return numeroDouble;
        }
    }
}
