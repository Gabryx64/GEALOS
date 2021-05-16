using System;
using SDL2;

namespace GEALOS.Audio
{
    class Sound : Audio
    {
        IntPtr sound;

        public Sound(String path)
        {
            load(path);
        }

        public override void load(string path)
        {
            sound = SDL_mixer.Mix_LoadWAV(path);

            if (sound == IntPtr.Zero)
            {
                Console.WriteLine($"There was an issue loading the sound. {SDL.SDL_GetError()}");
                Environment.Exit(-1);
            }
        }

        public override void play()
        {
            if (SDL_mixer.Mix_PlayChannel(-1, sound, 0) == -1)
            {
                Console.WriteLine($"There was an issue playing the sound. {SDL.SDL_GetError()}");
                Environment.Exit(-1);
            }
        }
    }
}
