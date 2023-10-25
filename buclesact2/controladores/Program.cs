using buclesact2.servicios;

namespace buclesact2.controladores
{
    class program
    {
        public static void Main(string[] args)
        {
            ///<sumary>
            ///Creacion de objetos y y variables
            ///<author>251023 - awb</author>
            ///</sumary>
            peticionDeNumerosInterfaz pdn = new peticionDeNumerosImplementacion();
            double numeroDouble = pdn.peticionDouble();
            int numeroInt = pdn.peticionInt();
            operacionInterfaz oi = new operacionImplementacion();
            oi.operacion(numeroInt, numeroDouble);
        }
    }
}