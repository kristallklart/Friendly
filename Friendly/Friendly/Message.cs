using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Friendly
{
    class Message
    {
        private string mId;
        private string mDate;
        private string mTime;
        private string content;

        public string MID
        {
            get
            {
                return mId;
            }

            set
            {
                mId = value;
            }
        }

        public string MDate
        {
            get
            {
                return mDate;
            }

            set
            {
                mDate = value;
            }
        }

        public string MTime
        {
            get
            {
                return mTime;
            }

            set
            {
                mTime = value;
            }
        }

        public string Content
        {
            get
            {
                return content;
            }

            set
            {
                content = value;
            }
        }
    }
}
