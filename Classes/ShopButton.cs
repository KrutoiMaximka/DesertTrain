using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using System.Threading;


namespace DesertTrain.Classes
{
    public class ShopButton
    {
        private Vector2 _position = new Vector2(10, 10);
        private Texture2D _texture = null;
        public void LoadContent(ContentManager content)
        {
            _texture = content.Load<Texture2D>("shop button");
        }
        public void Update()
        {

        }
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(_texture, _position, Color.White);
        }
    }
}
