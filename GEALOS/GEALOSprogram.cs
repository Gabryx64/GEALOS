using System;
using SDL2;
using GEALOS.Utils;

namespace GEALOS
{
    class GEALOSprogram
    {
        public Input input = new Input();

        public bool running;

        public virtual void init() {}

        public virtual void update() {}

        public void GEALOSinit()
        {
            if (SDL.SDL_Init(SDL.SDL_INIT_VIDEO) < 0)
            {
                Console.WriteLine($"There was an issue initilizing SDL. {SDL.SDL_GetError()}");
                Environment.Exit(-1);
            }

            if (SDL_image.IMG_Init(SDL_image.IMG_InitFlags.IMG_INIT_PNG | SDL_image.IMG_InitFlags.IMG_INIT_PNG |
                                   SDL_image.IMG_InitFlags.IMG_INIT_TIF | SDL_image.IMG_InitFlags.IMG_INIT_WEBP) < 0)
            {
                Console.WriteLine($"There was an issue initilizing SDL_image. {SDL.SDL_GetError()}");
                Environment.Exit(-1);
            }

            if (SDL_ttf.TTF_Init() < 0)
            {
                Console.WriteLine($"There was an issue initilizing SDL_ttf. {SDL.SDL_GetError()}");
                Environment.Exit(-1);
            }

            if (SDL_mixer.Mix_OpenAudio(22050, SDL_mixer.MIX_DEFAULT_FORMAT, 2, 4096) < 0 ||
                SDL_mixer.Mix_Init(SDL_mixer.MIX_InitFlags.MIX_INIT_FLAC | SDL_mixer.MIX_InitFlags.MIX_INIT_MID |
                                   SDL_mixer.MIX_InitFlags.MIX_INIT_MOD | SDL_mixer.MIX_InitFlags.MIX_INIT_MP3 |
                                   SDL_mixer.MIX_InitFlags.MIX_INIT_OGG | SDL_mixer.MIX_InitFlags.MIX_INIT_OPUS) < 0)
            {
                Console.WriteLine($"There was an issue initilizing SDL_mixer. {SDL.SDL_GetError()}");
                Environment.Exit(-1);
            }

            running = true;

            GEALOSprog();
        }

        void GEALOSprog()
        {
            init();

            while (running)
            {
                while (SDL.SDL_PollEvent(out SDL.SDL_Event e) == 1)
                {
                    switch (e.type)
                    {
                        case SDL.SDL_EventType.SDL_QUIT:
                            running = false;
                            break;

                        case SDL.SDL_EventType.SDL_KEYDOWN:
                            input.setPress(e.key.keysym.sym, true);
                            break;

                        case SDL.SDL_EventType.SDL_KEYUP:
                            if (e.key.repeat == 0)
                                input.setPress(e.key.keysym.sym, false);
                            break;
                    }
                }

                update();
            }

            SDL_mixer.Mix_Quit();
            SDL_ttf.TTF_Quit();
            SDL_image.IMG_Quit();
            SDL.SDL_Quit();
        }
    }
}
