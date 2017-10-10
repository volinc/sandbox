using System;
using Forms.Services;

namespace Forms.Infrastructure
{
    public interface IRegistry
    {
        bool IsConnected { get; }

        event EventHandler Connected;

        event EventHandler Disconnected;

        IMusicService MusicService { get; }

        ITimingService TimingService { get; }

        ITrackingService TrackingService { get; }
    }
}
