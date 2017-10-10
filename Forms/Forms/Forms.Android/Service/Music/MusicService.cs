using System;
using Android.App;
using Android.Content;
using Android.Media;
using Forms.Services;

namespace Forms.Droid.Service.Music
{
    public class MusicService : IMusicService
    {
        public event EventHandler Started;
        public event EventHandler Stoped;

        private readonly MediaPlayer player;

        public MusicService()
        {
            player = MediaPlayer.Create(Application.Context, Resource.Raw.test);
            player.Looping = true;
        }        

        public void Start()
        {
            player.Start();
            Started?.Invoke(this, EventArgs.Empty);
        }

        public void Stop()
        {
            player.Stop();
            Stoped?.Invoke(this, EventArgs.Empty);
        }
    }
}