﻿using Friendly.View;
using System;

namespace Friendly.Utilities
{
    class DelegateBroadcastServer
    {
        public delegate void MsgArrivedDelegate(String message, MainForm form);
        private static MsgArrivedDelegate madObj;

        public static void ClientConnect(MsgArrivedDelegate mad)
        {
            madObj = (MsgArrivedDelegate)Delegate.Combine(madObj, mad);
        }

        public static void ClientDisconnect(MsgArrivedDelegate mad)
        {
            madObj = (MsgArrivedDelegate)Delegate.Remove(madObj, mad);
        }
        public static void sendMsgToAll(String msg, MainForm form)
        {
            madObj(msg,form);
        }
        public static void sendMsgToSome(String msg,Object outside,MainForm form)
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
