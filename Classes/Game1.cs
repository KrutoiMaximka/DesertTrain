using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace DesertTrain.Classes
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        private Train _train;
        private Bg1 _bg1;
        private Bg2 _bg2;

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
            _bg2 = new Bg2();

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            _bg1.LoadContent(Content);
            _train.LoadContent(Content);
            _bg2.LoadContent(Content);
            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            _train.Update();
            _bg1.Update();
            _bg2.Update();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Red);
            _spriteBatch.Begin();
            {
                // TODO: Add your drawing code here

                _bg1.Draw(_spriteBatch);
                _train.Draw(_spriteBatch);
                _bg2.Draw(_spriteBatch);
            }
            _spriteBatch.End();
            base.Draw(gameTime);

        }
    }
}
