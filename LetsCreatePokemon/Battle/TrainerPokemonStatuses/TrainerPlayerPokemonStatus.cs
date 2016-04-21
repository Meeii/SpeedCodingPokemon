﻿using System;
using System.Collections.Generic;
using LetsCreatePokemon.Common;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace LetsCreatePokemon.Battle.TrainerPokemonStatuses
{
    internal class TrainerPlayerPokemonStatus : TrainerPokemonStatus
    {
        public TrainerPlayerPokemonStatus(IList<PokemonStates> states) : base(states)
        {
            Position = new Vector2(240, 90);
            Speed = -5.0f;
        }

        protected override void AnimationDone()
        {
            if (Speed > -0.1f)
            {
                IsDone = true; 
            }
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(BarTexture, Position, Color.White);
            for (int n = 0; n < PokemonBallTextures.Count; n++)
            {
                spriteBatch.Draw(PokemonBallTextures[n], Position + new Vector2(20 + 10*n,1));
            }
        }
    }
}
