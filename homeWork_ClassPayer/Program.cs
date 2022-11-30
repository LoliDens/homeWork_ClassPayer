using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork_ClassPayer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string playerName = "Воитель";
            int playerHealth = 100;
            int playerDamage = 10;

            Player player = new Player(playerName, playerHealth, playerDamage);

            player.ShowInfo();

            Console.ReadKey();
        }
    }

    class Player 
    {
        private string _name;
        private int _health;
        private int _damage;

        public Player(string name, int health, int damage)
        {
            _name = name;
            _health = health;
            _damage = damage;
        }

        public void ShowInfo() 
        {
            Console.WriteLine($"Имя игрока - {_name}");
            Console.WriteLine($"Здоровье игрока - {_health}");
            Console.WriteLine($"Урон игрока - {_damage}");
        }
    }
}
