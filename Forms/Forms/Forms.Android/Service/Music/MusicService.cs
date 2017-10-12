using System;
using Android.App;
using Android.Media;
using Forms.Services;

namespace Forms.Droid.Service.Music
{
    internal class MusicService : IMusicService
    {
        public event EventHandler Started;

        public event EventHandler Stoped;

        private readonly MediaPlayer _player;

        public bool IsStarted { get; private set; }

        public MusicService()
        {
            _player = MediaPlayer.Create(Application.Context, Resource.Raw.test);
            _player.Looping = true;
        }

        public void Start()
        {
            if (IsStarted) return;

            _player.Start();

            IsStarted = true;
            Started?.Invoke(this, EventArgs.Empty);
        }

        public void Stop()
        {
            if (!IsStarted) return;

            _player.Stop();

            IsStarted = false;
            Stoped?.Invoke(this, EventArgs.Empty);
        }
    }
}