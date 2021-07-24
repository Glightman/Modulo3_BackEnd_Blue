using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_aula4
{
    public class Play
    {
        public void Start()
        {
            Decor();
            Console.WriteLine("SEJA BEM VINDO AO RPG DA BLUE:");
            Console.WriteLine("..... Escolha um nome para o seu jogador: ....");
            Console.ReadLine();
            Decor();
        }

        public void Decor()
        {
            string str = string.Concat(Enumerable.Repeat("-=-", 15));
            Console.WriteLine(str);
        }
    }
}
