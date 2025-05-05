using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using DesertTrain.Classes;

namespace DesertTrain
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        private Train _train;
        private Bg1 _bg1;
        private Zombie _zombie;
        public ShopButton _shop;
        public CoinsIcon1 _coins1;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            _bg1 = new Bg1();
            _train = new Train();
            _zombie = new Zombie();
            _shop = new ShopButton();
            _coins1 = new CoinsIcon1();


            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            _bg1.LoadContent(Content);
            _train.LoadContent(Content);
            _zombie.LoadContent(Content);
            _shop.LoadContent(Content);
            _coins1.LoadContent(Content);
            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            _spriteBatch.Begin();
            {
                _train.Update();
                _bg1.Update(Content);
                if (_bg1.Night == true)
                {
                    _zombie.Update();
                }
                _shop.Update();
                _coins1.Update();

            }
            _spriteBatch.End();
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);
            _spriteBatch.Begin();
            {
                // TODO: Add your drawing code here

                _bg1.Draw(_spriteBatch);
                _train.Draw(_spriteBatch);
                if (_bg1.night == true)
                {
                    _zombie.Draw(_spriteBatch);
                }
                _shop.Draw(_spriteBatch);
                _coins1.Draw(_spriteBatch);

            }
            _spriteBatch.End();
            base.Draw(gameTime);

        }
    }
}
