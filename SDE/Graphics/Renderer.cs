using System;
using SDL2;

namespace SDE.Graphics
{
    class Renderer
    {
        public IntPtr renderer;

        public Renderer(Window window)
        {
            renderer = SDL.SDL_CreateRenderer(window.window, -1, SDL.SDL_RendererFlags.SDL_RENDERER_ACCELERATED);
            if (renderer == IntPtr.Zero)
            {
                Console.WriteLine($"There was an issue creating the renderer. {SDL.SDL_GetError()}");
                Environment.Exit(-1);
            }
        }

        ~Renderer()
        {
            SDL.SDL_DestroyRenderer(renderer);
        }

        public void setColor(Color col)
        {
            SDL.SDL_SetRenderDrawColor(renderer, col.R, col.G, col.B, col.A);
        }

        public void clear()
        {
            SDL.SDL_RenderClear(renderer);
        }

        public void submit(Sprite sprite)
        {
            SDL.SDL_Rect srcrect, destrect;

            srcrect.x = 0;
            srcrect.y = 0;
            srcrect.w = sprite.w;
            srcrect.h = sprite.h;

            destrect.x = (int)sprite.pos.x;
            destrect.y = (int)sprite.pos.y;
            destrect.w = sprite.w;
            destrect.h = sprite.h;

            SDL.SDL_RenderCopyEx(renderer, sprite.texture, ref srcrect, ref destrect,
                                 sprite.angle, ref sprite.center, sprite.flip);
        }

        public void flush()
        {
            SDL.SDL_RenderPresent(renderer);
        }
    }
}
