using System;
using System.Collections.Generic;
using System.Text;

namespace SFMLCoreApp
{
    public class GameTime
    {
        private float _deltaTime = 0f;
        private float _timeScale = 1f;


        public float TimeScale
        {
            get => _timeScale;
            set { _timeScale = value; }
        }


        public float DelataTime
        {
            get => _deltaTime * _timeScale;
            set => _deltaTime = value;
        }

        public float DeltaTimeUnscaled => _deltaTime;

        public float TotalTimeElapsed { get; private set; }


        public GameTime()
        {
        }

        public void Update(float deltaTime, float totalTimeElapsed)
        {
            _deltaTime = deltaTime;
            TotalTimeElapsed = totalTimeElapsed;
        }
    }
}
