using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fight_Against_Evil
{
    public class Creature
    {
        private int defence = 1;

        protected Creature(int defence)
        {
            this.defence = defence;
        }
    }

    public class Hero : Creature
    {
        private int hp = 1;

        protected Hero(int defence, int hp) : base(defence)
        {
            this.hp = hp;
        }
    }

    public class Enemy : Creature
    {
        private int hp = 2;

        protected Enemy(int defence, int hp) : base(defence)
        {
            this.hp = hp;
        }
    }

    public class Ghost : Enemy
    {
        private bool flying = true;

        protected Ghost(int defence, int hp, bool flying) : base(defence, hp)
        {
            this.flying = flying;
        }
    }

    public class Skeleton : Enemy
    {
        protected Skeleton(int defence, int hp) : base(defence, hp)
        {

        }
    }

    public class Banshee : Ghost
    {
        protected Banshee(int defence, int hp, bool flying) : base(defence, hp, flying)
        {

        }
    }

    public class Wrath : Ghost
    {
        protected Wrath(int defence, int hp, bool flying) : base(defence, hp, flying)
        {

        }
    }

    public class Slime : Enemy
    {
        protected Slime(int defence, int hp) : base(defence, hp)
        {

        }
    }

    public class Ork : Enemy
    {
        protected Ork(int defence, int hp) : base(defence, hp)
        {

        }
    }

    public class Troll : Ork
    {
        protected Troll(int defence, int hp) : base(defence, hp)
        {

        }
    }

    public class RedTroll : Troll
    {
        protected RedTroll(int defence, int hp) : base(defence, hp)
        {

        }
    }

    public class GreenTroll : Troll
    {
        protected GreenTroll(int defence, int hp) : base(defence, hp)
        {

        }
    }

    public class WhiteTroll : GreenTroll
    {
        protected WhiteTroll(int defence, int hp) : base(defence, hp)
        {

        }
    }
}
