using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace Mono_1945.Screens
{
    public abstract class GameScreen : DrawableGameComponent
    {
        List<GameComponent> gameComponents;
        public List<GameComponent> GameComponents
        {
            get { return gameComponents; }
            set { gameComponents = value; }
        }

        public GameScreen(Game game) : base(game)
        {
            gameComponents = new List<GameComponent>();

        }

        public override void Update(GameTime gameTime)
        {

            base.Update(gameTime);

            foreach (GameComponent gameComponent in gameComponents)
            {
                gameComponent.Update(gameTime);
            }
        }

        public override void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);
            foreach (DrawableGameComponent gameComponent in gameComponents)
            {
                //if (gameComponent is DrawableGameComponent)
                //{
                //    ((DrawableGameComponent)gameComponent).Draw(gameTime);
                //}

                gameComponent.Draw(gameTime);
            }
        }


    }
}
