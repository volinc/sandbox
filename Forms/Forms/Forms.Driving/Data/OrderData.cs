using System;
using System.Collections.Generic;

namespace Forms.Driving.Data
{
    public class OrderData
    {
        public long Id { get; set; }

        public long TariffPlanId { get; set; }

        public Place Start { get; set; }
        
        public Place End { get; set; }
        
        public decimal? EstimatedPrice { get; set; }

        public decimal? WaitingPrice { get; set; }

        public decimal? ExtraPrice { get; set; }

        public decimal? ActualPrice { get; set; }

        public TimeSpan? FreeWaitingTime { get; set; }

        public TimeSpan ArrivalTime { get; set; }

        public DateTimeOffset CreatedAt { get; set; }

        public DateTimeOffset? DepartedAt { get; set; }

        public DateTimeOffset? ArrivalAt { get; set; }

        public DateTimeOffset? WaitingAt { get; set; }

        public TimeSpan? WaitingTime { get; set; }

        public DateTimeOffset? ExecutingAt { get; set; }

        public DateTimeOffset? FinishedAt { get; set; }

        public DateTimeOffset? ClosedAt { get; set; }

        public DirectoryItem CompletionReason { get; set; }

        public DirectoryItem State { get; set; }

        public decimal? AggregatorCommission { get; set; }

        public decimal? AggregatorFee { get; set; }

        public decimal? Commission { get; set; }

        public decimal? Fee { get; set; }

        public int? Rating { get; set; }

        public bool IsPassengerNotified { get; set; }

        public PassengerData Passenger { get; set; }

        public IReadOnlyCollection<CommentData> Comments { get; set; }                
    }
}
