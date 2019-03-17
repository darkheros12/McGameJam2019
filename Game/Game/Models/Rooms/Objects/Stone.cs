﻿using System;
using Game.Graphics;
using Game.Graphics.Contexts;
using Game.Models.Rooms.Objects;
using Game.UserInterface;

namespace Game.Models.Rooms.Objects
{
    [Serializable]
    public class Stone : CollisionObject
    {
        public override bool Probe(float x, float y)
        {
            if (base.Probe(x, y))
            {
                Console.WriteLine("Stone has been collided");
            }
            return true;
        }
    }
}
