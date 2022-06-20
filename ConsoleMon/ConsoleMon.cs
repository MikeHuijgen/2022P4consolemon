using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMon
{
    internal class ConsoleMon
    {
        internal int health;
        internal int energy;
        internal string name;
        internal string monsterType;

        internal ElementTypes weakness;

        internal List<Skill> skills = new List<Skill>();

        internal ConsoleMon()
        {
            
        }

        internal ConsoleMon(ConsoleMon copyFrom)
        {
            this.health = copyFrom.health;
            this.energy = copyFrom.energy;
            this.name = copyFrom.name;
            this.skills = copyFrom.skills;

            for (int i = 0; 1 < copyFrom.skills.Count; i++)
            {
                Skill copyFromThisSkill = copyFrom.skills[i];
                Skill clone = new Skill(copyFromThisSkill);
                this.skills.Add(clone);
            }
        }

        internal void TakeDamge(int damage)
        {
            health -= damage;
        }

        internal void DepleteEnergy(int energyValue)
        {
            energy -= energyValue;
        }
    }
}
