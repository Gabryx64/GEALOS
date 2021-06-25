using System;
using SDL2;

namespace GEALOS.Utils
{
    class Time
    {
        public double deltaTime = 0;
        UInt64 last = 0;
        UInt64 now = 0;

        public void update()
        {
            last = now;
            now = SDL.SDL_GetPerformanceCounter();

            if(last != 0 && now != 0)
                deltaTime = (double)((now - last) * 1000 / (double)SDL.SDL_GetPerformanceFrequency());
        }
    }
}
