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
        private int _maxTime = 300;
        private ContentManager content;
        public bool night = false;

        public float Speed
        {
            set => _speed = value;
        }
        public bool Night
        {
            get; set;
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



            _position1 = new Vector2(_texture.Width, 0);
        }

        public void Update(ContentManager content)
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

            }
            if (_timer >= _maxTime && _timer <= 30000)
            {
                _texture = content.Load<Texture2D>("Bg1(night)");
                night = true;
            }

            if (_timer == 30000)
            {
                _texture = content.Load<Texture2D>("Bg1");
                night = false;
                _timer = 0;

            }
            _timer++;

        }

        public void Draw(SpriteBatch spriteBatch)
        {

            spriteBatch.Draw(_texture, _position1, Color.White);
            spriteBatch.Draw(_texture, _position2, Color.White);

        }
    }
}
