using System;
using GEALOS.Maths;
using SDL2;

namespace GEALOS.Graphics
{
    class Sprite
    {
        public IntPtr texture;
        public Vector2f pos;
        public int w, h;
        public double angle = 0;
        public SDL.SDL_Point center;
        public SDL.SDL_RendererFlip flip = SDL.SDL_RendererFlip.SDL_FLIP_NONE;

        public Sprite(string imgPath, Renderer renderer, Vector2f pos)
        {
            IntPtr loadedSurface = SDL_image.IMG_Load(imgPath);
            if (loadedSurface == IntPtr.Zero)
            {
                Console.WriteLine($"There was an issue loading the image. {SDL.SDL_GetError()}");
                Environment.Exit(-1);
            }

            texture = SDL.SDL_CreateTextureFromSurface(renderer.renderer, loadedSurface);
            SDL.SDL_QueryTexture(texture, out uint NULL1, out int NULL2, out w, out h);
            this.pos = pos;
            resetCenter();

            SDL.SDL_FreeSurface(loadedSurface);
        }

        public Sprite(IntPtr texture, Vector2f pos)
        {
            this.texture = texture;
            SDL.SDL_QueryTexture(texture, out uint NULL1, out int NULL2, out w, out h);
            this.pos = pos;
            resetCenter();
        }

        ~Sprite()
        {
            SDL.SDL_DestroyTexture(texture);
        }

        public void setPos(Vector2f pos)
        {
            this.pos = pos;
        }

        public void setAngle(double angle)
        {
            this.angle = angle;
        }

        public void setCenter(Vector2i center)
        {
            this.center.x = center.x;
            this.center.y = center.y;
        }

        public void resetCenter()
        {
            center.x = w / 2;
            center.y = h / 2;
        }

        public void setFlip(SDL.SDL_RendererFlip flip)
        {
            this.flip = flip;
        }

        public void move(Vector2f movement)
        {
            pos += movement;
        }
    }
}
