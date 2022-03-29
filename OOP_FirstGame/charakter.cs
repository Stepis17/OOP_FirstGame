using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_FirstGame
{
    class charakter
    {
        private int shield;
        private int damage;
        private int health;

        public string Name { get; }
        public int Health { get => Health; }
        public int Shield { get => shield; }
        public int Damage { get => damage; }

        public charakter(string name)
        {
            Name = name;
            health = 100;
            shield = 50;
            damage = 20;
        }
        public void GetHit(int damage)
        {
            if (Shield > 0)
            {
                shield -= damage;
                if (shield < 0)
                {
                    health += shield;
                    shield = 0;
                }
          
            }
        }
        public void Heal()
        {
            health += 15;
        }

        public override ToString()
        {
            string text = "Name "
        }
    }