using System;

namespace Friendly.Utilities
{
    class DelegateBroadcastServer
    {
        public delegate void MsgArrivedDelegate(string message);
        private static MsgArrivedDelegate madObj;

        public static void ClientConnect(MsgArrivedDelegate mad)
        {
            madObj = (MsgArrivedDelegate)Delegate.Combine(madObj, mad);
        }

        public static void ClientDisconnect(MsgArrivedDelegate mad)
        {
            madObj = (MsgArrivedDelegate)Delegate.Remove(madObj, mad);
        }

        public static void SendMsgToAll(string msg)
        {
            madObj(msg);
        }

        public static void SendMsgToSome(string msg, object outside)
        {
            Delegate[] delegateList = madObj.GetInvocationList();

            for (int i = 0; i < delegateList.Length; i++)
            {
                if (delegateList[i].Target != outside)
                {
                    ((MsgArrivedDelegate)delegateList[i])(msg);                   
                }              
            }
        }
    }
}
