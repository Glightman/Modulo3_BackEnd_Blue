using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_aula4
{
    public class Play
    {
        Hero hero;
        public void Start()
        {
            Console.WriteLine("INFORME O SEU NOME: ");
            hero = new Hero(Console.ReadLine());
            Options();
        }
        void Options()
        {
            Console.Clear();
            Show();
            Console.WriteLine("DESEJA LUTAR CONTRA QUAL INIMIGO?: ");
            Console.WriteLine("1 - ORC");
            Console.WriteLine("2 - TROLL");
            Console.WriteLine("3 - GOBLIN");
            Console.WriteLine("");
            Console.WriteLine("0 - PARA SAIR DO JOGO");
            switch (Console.ReadLine().ToUpper())
            {
                case "1":
                case "ORC":
                    Figth(new Enemy("ORC", hero.level * 2, hero.level));
                    break;
                case "2":
                case "TROLL":
                    Figth(new Enemy("TROLL", hero.level * 5, hero.level * 2));
                    break;
                case "3":
                case "GOBLIN":
                    Figth(new Enemy("GOBLIN", hero.level * 10, hero.level * 4));
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("OPÇÃO INVÁLIDA!!!");
                    break;
            }

            Console.WriteLine("PRESSIONE QUALQUER TECLA PARA CONTINUAR...");
            Console.ReadKey();
            if (hero.life <= 0)
            {
                Console.WriteLine("E MORREU.... x(");
                return;
            }
            else
            {
                Options();
            }
                

        }
        void Figth(Enemy enemy)
        {
            Console.Clear();
            Show();
            Console.WriteLine($"MONSTRO ENCONTRADO: {enemy.name} - ATAQUE: {enemy.attack} - VIDA: {enemy.life} - XP: {enemy.XP}");
            Console.WriteLine("DESEJA (1)ATACAR OU (2)FUGIR?");
            switch (Console.ReadLine().ToUpper())
            {
                case "1":
                case "ATACAR":
                    enemy.life -= hero.attack;
                    Console.WriteLine($"\n\nVOCÊ CAUSOU {hero.attack} DE DANO NO {enemy.name}!");
                    hero.life -= enemy.attack;
                    Console.WriteLine($"\n\nVOCÊ RECEBEU {enemy.attack} DE DANO DO ATAQUE DO {enemy.name}!");
                    if (hero.life <= 0)
                    {
                        Console.WriteLine("E MORREU.... x(");
                        return;
                    }
                    if (enemy.life <= 0)
                    {
                        Console.WriteLine($"VOCÊ DERROTOU O {enemy.name}, E GANHOU {enemy.XP} DE XP.");
                        hero.GetXP(enemy.XP);
                        return;
                    }
                    break;
                case "2":
                case "FUGIR":
                    Console.WriteLine("VOCÊ FUGIU DA BATALHA!");
                    return;
            }
            Console.WriteLine("\n\nPRESSIONE QUALQUER TECLA PARA CONTINUAR...");
            Console.ReadKey();
            Figth(enemy);
        }
        void Show()
        {
            Console.WriteLine($"-=-=-=-=-=-=-=-=-=-");
            Console.WriteLine($"Olá {hero.name}");
            Console.WriteLine($"Seu nível é {hero.level}");
            Console.WriteLine($"Seu XP é {hero.XP}");
            Console.WriteLine($"Seu ataque é {hero.attack}");
            Console.WriteLine($"Sua vida é {hero.life}");
            Console.WriteLine($"-=-=-=-=-=-=-=-=-=-");
        }
    }

}
