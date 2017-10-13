using Forms.Driving.Data;

namespace Forms.Driving.Domain.Entities
{
    public class Finance
    {
        private readonly FinanceData data;

        private Finance(FinanceData data)
        {
            this.data = data;
        }

        public decimal Balance => data.Balance;

        public static class Map
        {
            public static Finance From(FinanceData data) => data == null ? null : new Finance(data);
        }
    }
}