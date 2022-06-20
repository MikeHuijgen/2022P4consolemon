using System;

namespace ConsoleMon
{
    class ConsoleMonArena
    {
        public void DoBattle(ConsoleMon a, ConsoleMon b)
        {
            Random random = new Random();
            Skill skilla = a.skills[random.Next(2)];
            Skill skillb = b.skills[random.Next(2)];
            while (a.health > 0 || b.health > 0)
            {
                skilla.UseOn(b, a);
                skillb.UseOn(a, b);
                Console.WriteLine(a.health);
                Console.WriteLine(b.health);
            }
        }
    }
}
