using SFML.Graphics;
using SFML.System;
using SFML.Window;
using System;
using System.Collections.Generic;
using System.Text;

namespace SFMLCoreApp
{
    public abstract class GameLoop
    {
        public const int TARGET_FPS = 60;
        public const float TIME_UNTIL_UPDATE = 1f / TARGET_FPS;

        public RenderWindow Window { get; private set; }

        public GameTime GameTime { get; set; }

        public Color WindowClearColor { get; set; }


        protected GameLoop(uint windowWidth, uint windowHeight, string windowTitle, Color windowColor)
        {
            WindowClearColor = windowColor;
            Window = new RenderWindow(new VideoMode(windowWidth, windowHeight), windowTitle);
            GameTime = new GameTime();
        }


        public void Run()
        {
            LoadContent();
            Initialize();

            var totalTimeBeforeUpdate = 0.0f;
            var prevTimeElapsed = 0f;
            var deltaTime = 0f;
            var totalTimeElapsed = 0f;

            var clock = new Clock();

            while(Window.IsOpen)
            {
                Window.DispatchEvents();

                totalTimeElapsed = clock.ElapsedTime.AsSeconds();
                deltaTime = totalTimeElapsed - prevTimeElapsed;
                prevTimeElapsed = totalTimeElapsed;

                totalTimeBeforeUpdate += deltaTime;

                if (totalTimeBeforeUpdate >= TIME_UNTIL_UPDATE)
                {
                    GameTime.Update(totalTimeBeforeUpdate, clock.ElapsedTime.AsSeconds());
                    totalTimeBeforeUpdate = 0f;

                    Update(GameTime);

                    Window.Clear(WindowClearColor);
                    Draw(GameTime);
                    Window.Display();
                }
            }
        }


        public abstract void LoadContent();

        public abstract void Initialize();

        public abstract void Update(GameTime gameTime);

        public abstract void Draw(GameTime gameTime);
    }
}
