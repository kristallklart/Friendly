using Friendly.Model;
using Friendly.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Friendly.Utilities
{
    public class DelegateBroadcastClient
    {
        private String clientName;
      

        public void onMsgArrived(string msg)
        {
            
            string message = (clientName + ": "+msg);
            

    }
        public Message SendMsg (Message msg)
        {

            return msg;
        }
        public DelegateBroadcastClient(String clientName)
        {
            this.clientName = clientName;
            DelegateBroadcastServer.clientConnect(
                new DelegateBroadcastServer.MsgArrivedDelegate(onMsgArrived));
        }
        public void Dispose()
        {
            DelegateBroadcastServer.clientDisconnect
                (new  DelegateBroadcastServer.MsgArrivedDelegate(onMsgArrived));
            GC.SuppressFinalize(this);
        }
        ~DelegateBroadcastClient()
        {
            Dispose();
        }
    }
}
