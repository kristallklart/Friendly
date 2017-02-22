﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Friendly.Utilities
{
    class DelegateBroadcastServer
    {
        public delegate void MsgArrivedDelegate(String message);
        private static MsgArrivedDelegate madObj;
        public static void clientConnect(MsgArrivedDelegate mad)
        {
            madObj = (MsgArrivedDelegate)Delegate.Combine(madObj, mad);
        }
        public static void clientDisconnect(MsgArrivedDelegate mad)
        {
            madObj = (MsgArrivedDelegate)Delegate.Remove(madObj, mad);
        }
        public static void sendMsgToAll(String msg)
        {
            madObj(msg);
        }
        public static void sendMsgToSome(String msg,Object outside)
        {
            Delegate[] delegateList = madObj.GetInvocationList();
            for (int i = 0; i < delegateList.Length; i++)
                if (delegateList[i].Target != outside)
                    ((MsgArrivedDelegate)delegateList[i])(msg);
        }
    }
}
