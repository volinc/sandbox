namespace SqlitePclLock
{
    public class OrderDbContext : BaseDbContext
    {
        public const string FileName =
#if DEBUG
            "debug_order.realm";
#else
            "order.realm";
#endif

        public OrderDbContext() : base(FileName) { }        
    }
}
