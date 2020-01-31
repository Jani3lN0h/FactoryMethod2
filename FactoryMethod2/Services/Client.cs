using FactoryMethod2.Services.Factory.Interfaces;
using FactoryMethod2.Services.Interfaces;

namespace FactoryMethod2.Services
{
    public class Client : ICuentaFactory
    {
        private readonly int _tipoCuenta;
        private readonly int _cuentaRetiro;
        public Client(int iTipoCuenta, int iCuentaRetiro)
        {
            _tipoCuenta = iTipoCuenta;
            _cuentaRetiro = iCuentaRetiro;
        }

        public ICuenta CrearInstancia()
        {
            ICuenta cuenta = new CuentaCheques(_cuentaRetiro);
            switch (_tipoCuenta)
            {
                case 1:
                    cuenta = new CuentaCheques(_cuentaRetiro);
                    break;
                case 2:
                    cuenta = new CuentaAhorro(_cuentaRetiro);
                    break;
                case 3:
                    cuenta = new CuentaNomina(_cuentaRetiro);
                    break;
            }
            return cuenta;
        }

        public string RetirarFondos(ICuenta iCuentaRetiro)
        {
            string msg = "";
            return msg;
        }
    }
}
