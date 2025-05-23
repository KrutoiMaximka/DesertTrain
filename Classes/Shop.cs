﻿using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using System.Threading;


namespace DesertTrain.Classes
{
    public class Shop
    {
        private Vector2 _position = new Vector2(100,0);
        private Texture2D _texture = null;
        private readonly Rectangle _rect = new Rectangle();
        MouseState prevms;
        ShopButton _shopB = new ShopButton();

        public void LoadContent(ContentManager content)
        {
            _texture = content.Load<Texture2D>("shopMenuBg");
        }
        public void Update()
        {

        }
        public void Draw(SpriteBatch _spriteBatch)
        {
            _spriteBatch.Draw(_texture, _position, Color.White);
        }
    }
}
