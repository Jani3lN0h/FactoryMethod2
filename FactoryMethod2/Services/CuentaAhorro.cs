using FactoryMethod2.Services.Interfaces;

namespace FactoryMethod2.Services
{
    public class CuentaAhorro : ICuenta
    {
        private readonly int numCuenta;
        public CuentaAhorro(int iNumeroCuenta)
        {
            numCuenta = iNumeroCuenta;
        }

        public string RetirarFondos(float dCantidadRetirar)
        {
            return string.Format("El cliente hizo un retiro de {0} de la cuenta {1} de AHORRO", dCantidadRetirar, numCuenta);
        }
    }
}