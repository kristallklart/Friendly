using Friendly.Model;
using Friendly.View;
using System;

namespace Friendly.Utilities
{
    public class DelegateBroadcastClient
    {
        private String clientName;
        

        public void onMsgArrived(string msg, MainForm form)
        {
            
            form.WriteMessages();
    }
        public Message SendMsg (Message msg)
        {
            return msg;
        }

        public DelegateBroadcastClient(string clientName)
        {
            this.clientName = clientName;
            DelegateBroadcastServer.ClientConnect(new DelegateBroadcastServer.MsgArrivedDelegate(onMsgArrived));
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
