using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using System.Threading;

namespace DesertTrain.Classes
{
    public class Bg1
    {
        private Texture2D _texture;
        private Vector2 _position1;
        private Vector2 _position2;
        private float _speed;
        private int _timer = 0;
        private int _maxTime = 5;
        private ContentManager content;

        public float Speed
        {
            set => _speed = value;
        }

        public Bg1()
        {
            _texture = null;
            _position1 = Vector2.Zero;
            _position2 = Vector2.Zero;
            _speed = 2;
        }

        public void LoadContent(ContentManager content)
        {
            _texture = content.Load<Texture2D>("Bg1");

            if (_timer >= _maxTime)
                _texture = content.Load<Texture2D>("Bg1(night)");

            _position1 = new Vector2(_texture.Width, 0);
        }

        public void Update()
        {
            if (_timer <= _maxTime)
            {
                _position1.X -= _speed;
                _position2.X -= _speed;
                if (_position1.X <= 0)
                {
                    _position1.X = _texture.Width;
                    _position2.X = 0;
                }
                _timer++;
            }

            if (_timer >= _maxTime)
            {

            }

        }

        public void Draw(SpriteBatch spriteBatch)
        {

            spriteBatch.Draw(_texture, _position1, Color.White);
            spriteBatch.Draw(_texture, _position2, Color.White);

        }
    }
}
