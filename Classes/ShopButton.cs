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
        private readonly Rectangle _rect = new Rectangle();
        MouseState prevms = new MouseState();
        public bool isShop = false;
        public int shopCoolDown = 75;
        public int maxShopCD = 100;

        public ShopButton(Texture2D t, Vector2 p)
        {
            _texture = t;
            _position = p;
            _rect = new((int)p.X, (int)p.Y, t.Width, t.Height);
        }
        public ShopButton()
        {

        }
        public void LoadContent(ContentManager content)
        {
            _texture = content.Load<Texture2D>("shop button");
        }

        public void Update(ContentManager content)
        {
            MouseState mouse = Mouse.GetState();
            Rectangle cursor = new(mouse.Position.X, mouse.Position.Y, 1, 1);

            if (cursor.Intersects(_rect))
            {
                _texture = content.Load<Texture2D>("shopbutton_selected");
            }
            else
            {
                _texture = content.Load<Texture2D>("shop button");
            }
            if (cursor.Intersects(_rect) && isShop == false && shopCoolDown >= maxShopCD)
            {
                isShop = true;
                shopCoolDown = 50;
            }
            if (cursor.Intersects(_rect) && shopCoolDown >= maxShopCD && isShop == true)
            {
                isShop = false;
                shopCoolDown = 35;
            }
            shopCoolDown++;

        }
        public void Draw(SpriteBatch spriteBatch, Rectangle cursor)
        {
            spriteBatch.Draw(_texture, _position, Color.White);
        }
    }
}
