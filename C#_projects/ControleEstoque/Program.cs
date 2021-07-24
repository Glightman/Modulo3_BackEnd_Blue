using System;

namespace ControleEstoque //ESCOPO DO CÓDIGO: EU POSSO USAR COISAS DE OUTROS ARQUIVO COM ESSE MESMO namespace.
{
    class Program
    {
        static void Main(string[] args)
        {
            BlueShop blueshop = new BlueShop();
            blueshop.Iniciar();
        }
    }
}
