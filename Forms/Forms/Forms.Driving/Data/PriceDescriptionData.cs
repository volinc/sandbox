using System;

namespace Forms.Driving.Data
{
    public class PriceDescriptionData
    {    
        public decimal? EstimatedPrice { get; set; }
        
        public long TariffPlanId { get; set; }
        
        public decimal PricePerMinuteWaiting { get; set; }
        
        public TimeSpan FreeWaitingTime { get; set; }
        
        public decimal ArrivalPrice { get; set; }
        
        public TimeSpan IncludedTime { get; set; }
    }
}
