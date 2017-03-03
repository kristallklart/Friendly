using Friendly.Model;
using System;

namespace Friendly.Utilities
{
    public class DelegateBroadcastClient
    {
        private string clientName;
      
        public void OnMsgArrived(string msg)
        {           
            string message = (clientName + ": " + msg);       
        }

        public Message SendMsg (Message msg)
        {
            return msg;
        }

        public DelegateBroadcastClient(string clientName)
        {
            this.clientName = clientName;
            DelegateBroadcastServer.ClientConnect(new DelegateBroadcastServer.MsgArrivedDelegate(OnMsgArrived));
        }

        public void Dispose()
        {
            DelegateBroadcastServer.ClientDisconnect(new DelegateBroadcastServer.MsgArrivedDelegate(OnMsgArrived));
            GC.SuppressFinalize(this);
        }

        ~DelegateBroadcastClient()
        {
            Dispose();
        }
    }
}
