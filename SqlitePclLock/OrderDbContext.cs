namespace SqlitePclLock
{
    using SQLite;

    public class OrderDbContext : BaseDbContext
    {
        public const string FileName =
#if DEBUG
            "debug_order.db";
#else
            "order.db";
#endif

        public OrderDbContext() : base(FileName) { }

        protected override void CreateSchema(SQLiteConnection connection)
        {
            connection.CreateTable<OrderLocationSqLite>();
        }
    }
}
