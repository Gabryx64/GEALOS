using GEALOS.Graphics;
using GEALOS.Maths;
using SDL2;
using System;

namespace GEALOS.Graphics
{
    class Font
    {
        private IntPtr font;

        public Font(string file, uint ptsize)
        {
            this.font = SDL_ttf.TTF_OpenFont(file, (int)ptsize);
        }

        public void destroy()
        {
            SDL_ttf.TTF_CloseFont(font);
        }

        public Sprite toSprite(string text, Color color, Renderer renderer, Vector2f pos)
        {
            SDL.SDL_Color col = new SDL.SDL_Color()
            {
                r = color.R,
                g = color.G,
                b = color.B,
                a = color.A
            };

            IntPtr surface = SDL_ttf.TTF_RenderText_Blended(font, text, col);
            IntPtr texture = SDL.SDL_CreateTextureFromSurface(renderer.renderer, surface);

            SDL.SDL_FreeSurface(surface);
            return new Sprite(texture, pos);
        }
    }
}
