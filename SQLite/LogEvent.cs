using System;

namespace SQLite
{
    public class LogEvent
    {
        [PrimaryKey, AutoIncrement]
        public int OrderNo { get; set; }

        public DateTimeOffset CreatedAt { get; set; }

        public LogLevel Level { get; set; }

        public string Text { get; set; }
    }
}
