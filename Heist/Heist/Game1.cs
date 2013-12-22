using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace Heist
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    class Game1 : Microsoft.Xna.Framework.Game
    {
  
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        
        //Placeholder objects
        Level testLevel = new Level(new Vector2(3000, 3000));
        
        
       
        

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            graphics.PreferredBackBufferHeight = 800;
            graphics.PreferredBackBufferWidth = 1500;
            Content.RootDirectory = "Content";
           
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
                      

            // TODO: use this.Content to load your game content here

            //Here I load the textures and asign them            
            testLevel.testTexture = Content.Load<Texture2D>("wall1");
            testLevel.testPlayer.dot = Content.Load<Texture2D>("testcollidable");
            

        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();
           
            //Update the currentLevel, it then iterates through all of the objects within it and updates them among other things
            testLevel.UpdateLevel();
            //CO testLevel.testPlayer.Update();
          
            

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            spriteBatch.Begin();

            //testLevel.testPlayer.Draw(spriteBatch, testTexture);

            //Here we draw the current level. The level iterates through every object and draws it, taking the camera into account
            testLevel.DrawLevel(spriteBatch);
            
            
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}