using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Friendly.Utilities
{
    class DelegateBroadcastClient
    {
        private String clientName;
        private void onMsgArrived(String msg)
        {
            Console.WriteLine("Msg arrived (Client {0}): {1}", clientName, msg);
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
