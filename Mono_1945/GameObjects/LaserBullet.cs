namespace Mono_1945.GameObjects
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Microsoft.Xna.Framework.Graphics;
    using MonoGame.Extended.Sprites;
    
    public class LaserBullet
    {
        Sprite bullet;

        public LaserBullet(Texture2D texture)
        {
            bullet = new Sprite(texture);
        }

        public void Update()
        {
            
        }
    }
}
