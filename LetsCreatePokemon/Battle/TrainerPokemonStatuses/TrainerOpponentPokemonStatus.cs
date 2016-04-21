﻿using System.Collections.Generic;
using LetsCreatePokemon.Common;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace LetsCreatePokemon.Battle.TrainerPokemonStatuses
{
    class TrainerOpponentPokemonStatus : TrainerPokemonStatus
    {
        public TrainerOpponentPokemonStatus(IList<PokemonStates> states) : base(states)
        {
            Position = new Vector2(-104, 30);
            Speed = 5.0f; 
        }

        protected override void AnimationDone()
        {
            if (Speed < 0.1f)
            {
                IsDone = true; 
            }
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(BarTexture, Position, new Rectangle(0, 0, 104, 13), Color.White, 0f, Vector2.Zero, Vector2.One, SpriteEffects.FlipHorizontally, 0);
            for (int n = 0; n < PokemonBallTextures.Count; n++)
            {
                spriteBatch.Draw(PokemonBallTextures[n], Position + new Vector2(77 - 10 * n, 1));
            }
        }
    }
}
