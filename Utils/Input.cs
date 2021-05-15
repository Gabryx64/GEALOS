using SDL2;

namespace SDE.Utils
{
    class Input
    {
        bool[] kbPressList;

        public Input()
        {
            kbPressList = new bool[322];

            for(int i = 0; i< 322; i++)
            {
                kbPressList[i] = false;
            }
        }
        
        public void setPress(SDL.SDL_Keycode key, bool press)
        {
            SDL.SDL_Scancode scan = SDL.SDL_GetScancodeFromKey(key);
            kbPressList[(int)scan] = press;
        }
        
        public bool isPressed(SDL.SDL_Keycode key)
        {
            SDL.SDL_Scancode scan = SDL.SDL_GetScancodeFromKey(key);
            return kbPressList[(int)scan];
        }
    }
}
