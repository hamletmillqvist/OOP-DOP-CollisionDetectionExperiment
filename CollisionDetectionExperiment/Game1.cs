using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace CollisionDetectionExperiment
{
    internal class Game1 : Game
    {
        private readonly GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;
        private Texture2D texture;

        /// <summary>
        /// Only change settings in here.
        /// </summary>
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public Game1() : base()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            this.graphics = new GraphicsDeviceManager(this);
            this.Content.RootDirectory = "Content";
            this.IsFixedTimeStep = true;
            this.IsMouseVisible = true;
        }

        /// <summary>
        /// Called on first initialization of the game object. Setup of settings and objects should be done here.
        /// OBS! GraphicsDevice and game-specific members are not initialized until this method completes.
        /// </summary>
        protected override void Initialize()
        {
            this.Window.Title = "Collision Detection Experiment";
            spriteBatch = new SpriteBatch(GraphicsDevice);
            base.Initialize();
        }

        /// <summary>
        /// Called once after initialization. Loading of files, textures and sounds should be done here.
        /// </summary>
        protected override void LoadContent()
        {
            texture = Content.Load<Texture2D>("Pixel");
            base.LoadContent();
        }

        /// <summary>
        /// Called before the application exits. Releasing reasorces should be done here.
        /// </summary>
        protected override void UnloadContent()
        {
            base.UnloadContent();
        }

        /// <summary>
        /// Called every frame (fixed, if VSYNC is enabled). Keep graphics-calls out of this method!
        /// </summary>
        /// <param name="gameTime">GameTime object containing information regarding elapsed time.</param>
        protected override void Update(GameTime gameTime)
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Escape)) {
                this.Exit();
            }
            base.Update(gameTime);
        }

        /// <summary>
        /// Called every frame after <see cref="Update(GameTime)"/> has finished. All calls to the graphics device should be isolated inside this method.
        /// </summary>
        /// <param name="gameTime"></param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            this.spriteBatch.Begin();

            this.spriteBatch.Draw(texture, new Vector2(50, 50), null, Color.White, 0, Vector2.Zero, 20, SpriteEffects.None, 0);

            this.spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
