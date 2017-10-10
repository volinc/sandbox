using System;
using Forms.Services;

namespace Forms.Droid.Service.Timing
{
    public class TimingService : ITimingService
    {
        public int Value { get; }

        public event EventHandler<int> ValueChanged;

        public event EventHandler Started;

        public event EventHandler Stoped;

        public void Start()
        {
            
        }

        public void Stop()
        {
            
        }
    }
}