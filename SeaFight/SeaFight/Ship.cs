using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaFight
{
    abstract class Ship
    {
        protected bool isReady;
        protected int length;
        protected string location;
        public bool IsReady { get => isReady; set => isReady = value; }
        public int Length { get => length; set => length = value; }
        public string Location { get => location; set => location = value; }
        public abstract void Dead();
        public abstract void Damage();

    }

    class SingleShip :Ship
    {
        private const int L = 1;
        public SingleShip(string Loc)
        {
            IsReady = true;
            Length = L;
            Location = Loc;


        }

        public override void Damage()
        {
            Dead();
        }

        public override void Dead()
        {
                IsReady = false;
        }
        public override string ToString()
        {
            return $"Ready: {IsReady}, Length: {Length}";
        }
    }
    class TwiceShip : Ship
    {
        private const int L = 2;
        public TwiceShip(string Loc)
        {
            IsReady = true;
            Length = L;
            Location = Loc;
        }
        public override void Dead()
        {
            IsReady = false;
        }
        public override void Damage()
        {
            if(Length>0)
            {
                Length--;
            }
            else
            {
                Dead();
            }
        }
        public override string ToString()
        {
            return $"Ready: {IsReady}, Length: {Length}";
        }
    }
    class TripleShip:Ship
    {
        private const int L = 3;
        public TripleShip(string Loc)
        {
            IsReady = true;
            Length = L;
            Location = Loc;
        }
        public override void Damage()
        {
            if (Length > 0)
            {
                Length--;
            }
            else
            {
                Dead();
            }
        }
        public override void Dead()
        {
            IsReady = false;
        }
        public override string ToString()
        {
            return $"Ready: {IsReady}, Length: {Length}";
        }
    }
    class QuadShip: Ship
    {
        private const int L = 4;
        public QuadShip(string Loc)
        {
            IsReady = true;
            Length = L;
            Location = Loc;
        }
        public override void Dead()
        {
            IsReady = false;
        }
        public override void Damage()
        {
            if (Length > 0)
            {
                Length--;
            }
            else
            {
                Dead();
            }
        }
        public override string ToString()
        {
            return $"Ready: {IsReady}, Length: {Length}";
        }
    }
}