using Microsoft.WindowsAzure.Storage.Table;

namespace SignalR.Server
{
    public class ConnectionEntity : TableEntity
    {
        public ConnectionEntity() { }

        public ConnectionEntity(string userName, string connectionId)
        {
            PartitionKey = userName;
            RowKey = connectionId;
        }
    }
}
