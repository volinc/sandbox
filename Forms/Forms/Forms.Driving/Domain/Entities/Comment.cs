using System;
using Forms.Driving.Data;

namespace Forms.Driving.Domain.Entities
{
    public class Comment
    {
        private readonly CommentData data;

        private Comment(CommentData data)
        {
            this.data = data;
        }

        public string Content => data.Content;

        public DateTimeOffset CreatedAt => data.CreatedAt.ToLocalTime();

        public static class Map
        {
            public static Comment From(CommentData data) => data == null ? null : new Comment(data);
        }
    }
}