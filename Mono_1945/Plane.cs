using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGame.Extended.InputListeners;
using MonoGame.Extended.Sprites;

namespace Mono_1945
{

    
    public class Plane
    {
        

        Sprite sprite;
        KeyboardState state;
        Vector2 Direction;
        public  Vector2 Position { get { return sprite.Position; } }
        Viewport viewport;
        float speed = 400;
        public Plane(Texture2D texture, GraphicsDeviceManager graphics)
        {
            sprite = new Sprite(texture);
           
            viewport = new Viewport(graphics.GraphicsDevice.Viewport.Bounds);
            sprite.Position = new Vector2(viewport.Width / 2 ,viewport.Height - sprite.GetBoundingRectangle().Height / 2);
            


        }

        public void Update(GameTime dt)
        {
            state = Keyboard.GetState();
            Move(dt);
            
        }
        public void Draw(SpriteBatch batch)
        {
           sprite.Draw(batch);
        }

        Vector2 InputHandler()
        {
            
            Vector2 tmpDirection = Vector2.Zero;

            Dictionary<Keys, Vector2> KeyMap = new Dictionary<Keys, Vector2>();
            KeyMap.Add(Keys.Left, new Vector2(-1, 0));
            KeyMap.Add(Keys.Right, new Vector2(1, 0));

            foreach (var key in KeyMap)
            {
                
                if (state.IsKeyDown(key.Key))
                {
                    Console.WriteLine("hahaha");

                    tmpDirection = key.Value;
                }
            }
            return tmpDirection;
        }
        void Move(GameTime dt)
        {
            Direction = InputHandler();
            Vector2 newPosition = Position + ((Direction * (float)dt.ElapsedGameTime.TotalSeconds) * speed);

            sprite.Position = newPosition;
        }

    }
}
