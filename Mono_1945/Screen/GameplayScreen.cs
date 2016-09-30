using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Mono_1945.GameObjects;

namespace Mono_1945.Screen
{
    public class GameplayScreen : GameScreen
    {
        SpriteBatch spriteBatch;
        ContentManager Content;
        GraphicsDeviceManager graphics;

        AirPlane plane;
        public GameplayScreen(Game game) : base(game)
        {
            graphics = ((Game1)game).GraphicsDeviceManager;
            Content = game.Content;
            Content.RootDirectory = "Content";

        }

        public override void Initialize()
        {
         
            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            plane = new AirPlane(Content.Load<Texture2D>("player"), graphics);
            base.LoadContent();
           
        }

        public override void Update(GameTime gameTime)
        {
            plane.Update(gameTime);
            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            spriteBatch.Begin();
            plane.Draw(spriteBatch);
            spriteBatch.End();
           
        }
    }
}
