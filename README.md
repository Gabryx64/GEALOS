# GEALOS - Game Engine Abstraction Layer Over SDL

## An SDL2# based game engine

### Usage

```csharp
class Program
{
    static void Main()
    {
        new Game().GEALOSinit();
    }
}

class Game : GEALOSprogram
{
    // code
}
```

### Dependencies

* [SDL2-CS source files](https://github.com/flibitijibibo/SDL2-CS)
* [SDL2 DLLs for Visual C++](https://www.libsdl.org/download-2.0.php)
* [SDL_image DLLs for Visual C++](https://www.libsdl.org/projects/SDL_image/)
* [SDL_ttf DLLs for Visual C++](https://www.libsdl.org/projects/SDL_ttf/)
* [SDL_mixer DLLs for Visual C++](https://www.libsdl.org/projects/SDL_mixer/)
