using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using System.Threading;

namespace DesertTrain.Classes
{
    public class Zombie
    {
        private Vector2 _position = new Vector2(700,300);
        private Texture2D _texture = null;
        private Bg1 bg = new Bg1();

        public void LoadContent(ContentManager content)
        {
            _texture = content.Load<Texture2D>("Zombie");
        }
        public void Update()
        {
            //if (bg.night == true)
            //{
            //    while (_position.Y != 300)
            //    {
            //        _position.Y += 100;
            //    }
            //}
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            if (bg.night = true)
            {
                spriteBatch.Draw(_texture, _position, Color.White);
            }
        }
    }
}
