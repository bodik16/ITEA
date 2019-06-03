using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaFight
{
    enum typeOfShip
    {
        Single, 
        Twice,
        Triple,
        Quad
    }
    abstract class Ship
    { 
        public typeOfShip type;
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
        public const typeOfShip ship = typeOfShip.Single;
        private const int L = 1;
        public int GetLength { get => L; }
        public SingleShip()
        {
            IsReady = true;
            Length = L;
        }
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
        public const typeOfShip ship = typeOfShip.Twice;

        private const int L = 2;
        public int GetLength { get => L; }

        public string[] Loca = new string[L];

        public TwiceShip()
        {
            IsReady = true;
            Length = L;
        }
        public TwiceShip(string Loc1, string Loc2)
        {
            IsReady = true;
            Length = L;
            Loca[0] = Loc1;
            Loca[1] = Loc2;
            //Location = Loc1;
            //Location = Loc2;
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
        public const typeOfShip ship = typeOfShip.Triple;

        private const int L = 3;
        public int GetLength { get => L; }

        public string[] Loca = new string[L];

        public TripleShip()
        {
            IsReady = true;
            Length = L;
        }
        public TripleShip(string Loc, string Loc1, string Loc2)
        {
            IsReady = true;
            Length = L;
            Loca[0] = Loc;
            Loca[1] = Loc1;
            Loca[2] = Loc2;

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
        public const typeOfShip ship = typeOfShip.Quad;

        private const int L = 4;
        public int GetLength { get => L; }

        public string[] Loca = new string[L];
        public QuadShip()
        {
            IsReady = true;
            Length = L;
        }
        public QuadShip(string Loc, string Loc1, string Loc2, string Loc3)
        {
            IsReady = true;
            Length = L;
            Loca[0] = Loc;
            Loca[1] = Loc1;
            Loca[2] = Loc2;
            Loca[3] = Loc3;
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