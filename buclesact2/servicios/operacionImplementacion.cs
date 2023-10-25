namespace buclesact2.servicios
{
    internal class operacionImplementacion : operacionInterfaz
    {
        public void operacion(int numInt, double numDouble)
        {
            ///<sumary>
            ///Metodo que se encargara del calculo
            ///<author>251023 - awb</author>
            ///</sumary>
            double multiplicacion = numDouble;
            int i;
            for (i = 0; i <= numInt; i++)
            {
                multiplicacion = multiplicacion * numDouble;
                Console.WriteLine(multiplicacion);
            }
            //double operacion = Math.Pow(numDouble, numInt);
            //Console.WriteLine("La operacion da como resultado: " + operacion);
        }
    }
}
