using System;
using System.Collections.Generic;
using System.Linq;
using Forms.Driving.Data;

namespace Forms.Driving.Domain.Entities
{
    public class Order
    {
        private readonly OrderData data;

        private Order(OrderData data)
        {
            this.data = data;

            Passenger = Passenger.Map.From(data.Passenger);

            State = (OrderState)data.State.Id;
            StateName = data.State?.Name;

            CompletionReason = (OrderCompletionReason?)data.CompletionReason?.Id;
            CompletionReasonName = data.CompletionReason?.Name;

            Comments = data.Comments.Select(Comment.Map.From).OrderByDescending(x => x.CreatedAt).ToList();                        
        }

        public long Id => data.Id;
        
        public long TariffPlanId => data.TariffPlanId;
        
        public Place Start => data.Start;

        public Place End => data?.End;

        public decimal? EstimatedPrice => data.EstimatedPrice;

        public decimal? WaitingPrice => data.WaitingPrice;

        public decimal? ExtraPrice => data.ExtraPrice;

        public decimal? ActualPrice => data.ActualPrice;        

        public TimeSpan? FreeWaitingTime => data.FreeWaitingTime;        

        public TimeSpan ArrivalTime => data.ArrivalTime;

        public DateTimeOffset CreatedAt => data.CreatedAt;

        public DateTimeOffset? DepartedAt => data.DepartedAt;

        public DateTimeOffset? ExpectedDepartedAt => DepartedAt ?? CreatedAt + ArrivalTime;

        public DateTimeOffset? ArrivedAt => data.ArrivalAt;

        public DateTimeOffset? WaitedAt => data.WaitingAt;

        public TimeSpan? WaitingTime => data.WaitingTime;

        public DateTimeOffset? ExecutedAt => data.ExecutingAt;

        public DateTimeOffset? FinishedAt => data.FinishedAt;

        public DateTimeOffset? ClosedAt => data.ClosedAt;
        
        public OrderCompletionReason? CompletionReason { get; }

        public string CompletionReasonName { get; }

        public OrderState State { get; }

        public string StateName { get; }

        public IReadOnlyCollection<Comment> Comments { get; }

        public Passenger Passenger { get; }

        public decimal? AggregatorCommission => data.AggregatorCommission;

        public decimal? AggregatorFee => data.AggregatorFee;

        public decimal? Commission => data.Commission;

        public decimal? Fee => data.Fee;

        public int? Rating => data.Rating;

        public static class Map
        {
            public static Order From(OrderData data) => data == null ? null : new Order(data);
        }
    }
}