using System;
using Android.Content;
using Android.OS;
using Forms.Droid.Service;
using Forms.Services;

namespace Forms.Droid
{
    internal class Registry : UndeadServiceConnection, Infrastructure.IRegistry
    {
        public bool IsConnected => IsBound;

        public event EventHandler Connected;

        public event EventHandler Disconnected;

        public Registry()
        {            
            Open();
        }

        public IMusicService MusicService => Binder?.MusicService;

        public ITimingService TimingService => Binder?.TimingService;

        public ITrackingService TrackingService => Binder?.TrackingService;

        public override void OnServiceConnected(ComponentName name, IBinder service)
        {
            base.OnServiceConnected(name, service);

            Connected?.Invoke(this, EventArgs.Empty);
        }

        public override void OnServiceDisconnected(ComponentName name)
        {
            base.OnServiceDisconnected(name);

            Disconnected?.Invoke(this, EventArgs.Empty);
        }        
    }
}