using System;
using System.Collections.Generic;
using System.Text;
using SFML.Graphics;
using SFML.Window;
using SFML.System;

namespace SFMLCoreApp
{
    public class MyGame : GameLoop
    {
        public const uint DEFAULT_WINDOW_WIDTH = 640;
        public const uint DEFAULT_WINDOW_HEIGHT = 480;
        public const string WINDOW_TITLE = "My Game";


        public MyGame() : base(DEFAULT_WINDOW_WIDTH, DEFAULT_WINDOW_HEIGHT, WINDOW_TITLE, Color.Blue)
        {

        }


        public override void Draw(GameTime gameTime)
        {
        }


        public override void Initialize()
        {
        }


        public override void LoadContent()
        {
        }


        public override void Update(GameTime gameTime)
        {
        }
    }
}
