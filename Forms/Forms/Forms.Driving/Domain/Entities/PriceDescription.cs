using System;
using Forms.Driving.Data;

namespace Forms.Driving.Domain.Entities
{
    public class PriceDescription
    {
        private readonly PriceDescriptionData data;

        private PriceDescription(PriceDescriptionData data)
        {
            this.data = data;
        }

        public decimal? EstimatedPrice => data.EstimatedPrice;

        public long TariffPlanId => data.TariffPlanId;

        public decimal PricePerMinuteWaiting => data.PricePerMinuteWaiting;

        public TimeSpan FreeWaitingTime => data.FreeWaitingTime;

        public decimal ArrivalPrice => data.ArrivalPrice;

        public TimeSpan IncludedTime => data.IncludedTime;

        public static class Map
        {
            public static PriceDescription From(PriceDescriptionData data) =>
                data == null ? null : new PriceDescription(data);
        }        
    }
}
