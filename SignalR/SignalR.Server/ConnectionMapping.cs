using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace SignalR.Server
{
    public class ConnectionMapping<T>
    {
        private readonly Dictionary<T, HashSet<string>> _connections = new Dictionary<T, HashSet<string>>();

        public int Count => _connections.Count;

        public void Add(T key, string connectionId)
        {
            Trace(new Dictionary<string, object>
            {
                { nameof(key), key },
                { nameof(connectionId), connectionId }
            });

            lock (_connections)
            {
                if (!_connections.TryGetValue(key, out HashSet<string> connections))
                {
                    connections = new HashSet<string>();
                    _connections.Add(key, connections);
                }

                lock (connections)
                {
                    connections.Add(connectionId);
                }
            }
        }

        public IEnumerable<string> GetConnections(T key)
        {
            Trace(new Dictionary<string, object>
            {
                { nameof(key), key },                
            });

            if (_connections.TryGetValue(key, out HashSet<string> connections))
            {
                return connections;
            }

            return Enumerable.Empty<string>();
        }

        public void Remove(T key, string connectionId)
        {
            Trace(new Dictionary<string, object>
            {
                { nameof(key), key },
                { nameof(connectionId), connectionId }
            });

            lock (_connections)
            {
                if (!_connections.TryGetValue(key, out HashSet<string> connections))
                {
                    return;
                }

                lock (connections)
                {
                    connections.Remove(connectionId);

                    if (connections.Count == 0)
                    {
                        _connections.Remove(key);
                    }
                }
            }
        }

        private static void Trace(Exception exception, [CallerMemberName] string caller = null)
        {
            Trace(nameof(exception), exception, caller);
        }

        private static void Trace(string key, object value, [CallerMemberName] string caller = null)
        {
            Trace(new Dictionary<string, object>
            {
                {key, value}

            }, caller);
        }

        private static void Trace(IDictionary<string, object> infos = null, [CallerMemberName] string caller = null)
        {
            infos = infos ?? new Dictionary<string, object>();

            var strings = new List<string>(infos.Select(info => $"{info.Key} = {info.Value}"));

            var log = string.Join(";", strings);

            Console.WriteLine($"{caller} {log};");
        }
    }
}
