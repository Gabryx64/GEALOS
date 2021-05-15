using System;

namespace SDE.Audio
{
    abstract class Audio
    {
        public abstract void load(string path);
        public abstract void play();
    }
}
