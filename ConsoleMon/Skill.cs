using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMon
{
    internal class Skill
    {
        internal int damage;
        internal int energyCost;
        internal string name;

        internal ElementTypes element;

        internal Skill()
        {

        }

        internal Skill(Skill copyFrom)
        {
            this.name = copyFrom.name;
            this.energyCost = copyFrom.energyCost;
            this.damage = copyFrom.damage;
        }
            

        internal void UseOn(ConsoleMon target, ConsoleMon caster)
        {
            caster.DepleteEnergy(energyCost);
            target.TakeDamge(damage);
        }
    }
}
