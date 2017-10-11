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

        public MusicService()
        {
            _player = MediaPlayer.Create(Application.Context, Resource.Raw.test);
            _player.Looping = true;
        }        

        public void Start()
        {
            _player.Start();
            Started?.Invoke(this, EventArgs.Empty);
        }

        public void Stop()
        {
            _player.Stop();
            Stoped?.Invoke(this, EventArgs.Empty);
        }
    }
}