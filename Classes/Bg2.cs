using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace DesertTrain.Classes
{
    public class Bg2
    {
        private Texture2D _texture;
        private Vector2 _position1;
        private Vector2 _position2;
        private float _speed;
        Random rand = new Random();

        public float Speed
        {
            set => _speed = value;
        }

        public Bg2()
        {
            _texture = null;
            _speed = 2;
        }

        public void LoadContent(ContentManager content)
        {
            _texture = content.Load<Texture2D>("Bg2");

            _position1 = new Vector2(800, 0);
        }

        public void Update()
        {
            int n = rand.Next(1, 100);
            if (n == 67)
            {
                _position1.X -= _speed;
            }
            
        }

        public void Draw(SpriteBatch spriteBatch)
        {

            spriteBatch.Draw(_texture, _position1, Color.White);
            spriteBatch.Draw(_texture, _position2, Color.White);

        }
    }
}
