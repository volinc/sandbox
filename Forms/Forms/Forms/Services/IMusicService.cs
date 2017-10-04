using System;

namespace Forms.Services
{
    public interface IMusicService
    {
        event EventHandler Started;

        event EventHandler Stoped;

        void Start();

        void Stop();
    }
}
