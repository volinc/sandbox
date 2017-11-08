using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Configuration;

namespace SignalR.Server.SignalR
{
    public class ConnectionRepository
    {
        private readonly CloudTable table;

        public ConnectionRepository()
        {
            table = GetConnectionTable();
            table.CreateIfNotExists();
        }

        public void CreateOrUpdate(string userName, string connectionId)
        {
            var entity = new ConnectionEntity(userName, connectionId);
            var insertOperation = TableOperation.InsertOrReplace(entity);

            table.Execute(insertOperation);
        }

        public void Delete(string userName, string connectionId)
        {
            var deleteOperation = TableOperation.Delete(
                new ConnectionEntity(userName, connectionId) { ETag = "*" });

            table.Execute(deleteOperation);            
        }

        private CloudTable GetConnectionTable()
        {
            var connectionString = ConfigurationManager.AppSettings["StorageConnectionString"];                        
            if (CloudStorageAccount.TryParse(connectionString, out var storageAccount))
            {
                var tableClient = storageAccount.CreateCloudTableClient();
                return tableClient.GetTableReference("connection");
            }

            throw new InvalidOperationException();
        }
    }
}
