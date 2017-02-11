﻿#region copyright
// Copyright Information
// ==============================
// PatternsExamples - Hero.cs
// All samples copyright Philip Japikse 
// http://www.skimedic.com 2016/11/08
// See License.txt for more information
// ==============================
#endregion

namespace PatternsExamples.C_Behavioral.Strategy
{
    public class Hero : IHero
    {
        private ISuperPower _power;
        public Hero() : this(new RegularJoe())
        {
        }

        public Hero(ISuperPower power)
        {
            _power = power;
        }

        public string DoHeroStuff() => _power.ExercisePower();

	    public void ChangeSuperPower(ISuperPower power)
        {
            _power = power;
        }
    }

    public class SpiderMan : Hero
    {
        public SpiderMan() : base(new WeaveWeb())
        {
        }
    }

    public class SuperMan : Hero
    {
        public SuperMan() : base(new Fly())
        {
        }
    }

    public class BatMan : Hero
    {
        public BatMan() : base(new Fight())
        {
        }
    }
}