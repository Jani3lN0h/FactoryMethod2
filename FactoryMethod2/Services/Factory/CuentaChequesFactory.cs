using FactoryMethod2.Services.Factory.Interfaces;
using FactoryMethod2.Services.Interfaces;
using System;

namespace FactoryMethod2.Services.Factory
{
    public class CuentaChequesFactory : ICuentaFactory
    {
        public ICuenta CrearInstancia()
        {
            Console.WriteLine("Ingresa el número de cuenta:");
            int iCuenta = Convert.ToInt32(Console.ReadLine());
            return new CuentaCheques(iCuenta);
        }
    }
}