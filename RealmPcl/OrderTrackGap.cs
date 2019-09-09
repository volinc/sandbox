namespace SqlitePclLock
{
    using Newtonsoft.Json;

    public class OrderTrackGap
    {
        public int BeginIndex { get; }

        public int EndIndex { get; }

        [JsonConstructor]
        public OrderTrackGap(int beginIndex, int endIndex)
        {
            BeginIndex = beginIndex;
            EndIndex = endIndex;
        }
    }
}
