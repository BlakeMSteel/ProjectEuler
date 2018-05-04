using System;
namespace NumberLetterCounts
{
    public class BaseUI32Number
    {
        private UInt64[] baseUI32Number = new UInt64[8];
        public BaseUI32Number(UInt64[] preFormattedNumber)
        {
            baseUI32Number = preFormattedNumber;
        }
        public BaseUI32Number(string notFormattedNumber) {
            //TODO: process
        }
    }
}
