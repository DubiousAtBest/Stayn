using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StackExchange.Redis;

namespace Stayn.Lib.Managers
{
    public class RedisManager
    {

        #region Static Properties
        private static ConnectionMultiplexer _connection = ConnectionMultiplexer.Connect("localhost");
        private static object _asyncState = new object();
        private static IDatabase _db = _connection.GetDatabase(-1, _asyncState);
        private static ISubscriber _sub = _connection.GetSubscriber(_asyncState);
        #endregion

        public RedisManager()
        {
            _sub.Subscribe("messages", OnMessage);
        }


        #region Events
        public Action<RedisChannel, RedisValue> OnMessage;
        #endregion

        #region Redis Methods

        public void PublishToChannel(string channel = "messages", string content = "")
        {
            
        }

        #endregion
    }
}
