using System;
using SDL2;

namespace GEALOS.Graphics
{
    class Window
    {
        public IntPtr window;
        private int WIDTH, HEIGHT;

        public Window(string title, int w, int h, SDL.SDL_WindowFlags flags)
        {
            window = SDL.SDL_CreateWindow(title, SDL.SDL_WINDOWPOS_UNDEFINED, SDL.SDL_WINDOWPOS_UNDEFINED, w, h, flags);
            if (window == IntPtr.Zero)
            {
                Console.WriteLine($"There was an issue creating the window. {SDL.SDL_GetError()}");
                Environment.Exit(-1);
            }

            WIDTH = w; HEIGHT = h;
        }

        ~Window()
        {
            SDL.SDL_DestroyWindow(window);
        }

        public int getWidth()
        {
            return WIDTH;
        }

        public int getHeight()
        {
            return HEIGHT;
        }
    }
}
