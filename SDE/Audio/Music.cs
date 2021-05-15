using System;
using SDL2;

namespace SDE.Audio
{
    class Music : Audio
    {
        IntPtr music;

        public Music(String path)
        {
            load(path);
        }

        ~Music()
        {
            SDL_mixer.Mix_FreeMusic(music);
        }

        public override void load(string path)
        {
            music = SDL_mixer.Mix_LoadMUS(path);

            if (music == IntPtr.Zero)
            {
                Console.WriteLine($"There was an issue loading the music. {SDL.SDL_GetError()}");
                Environment.Exit(-1);
            }
        }

        public override void play()
        {
            if (SDL_mixer.Mix_PlayingMusic() == 0)
            {
                if (SDL_mixer.Mix_PlayMusic(music, 0) == -1)
                {
                    Console.WriteLine($"There was an issue playing the music. {SDL.SDL_GetError()}");
                    Environment.Exit(-1);
                }
            }
        }

        public void pause()
        {
            if (SDL_mixer.Mix_PausedMusic() != 1)
            {
                SDL_mixer.Mix_PauseMusic();
            }
        }

        public void resume()
        {
            if (SDL_mixer.Mix_PausedMusic() == 1)
            {
                SDL_mixer.Mix_ResumeMusic();
            }
        }
    }
}
