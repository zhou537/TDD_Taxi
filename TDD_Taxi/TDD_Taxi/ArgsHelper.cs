using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TDD_Taxi
{
    public class ArgsHelper
    {
        public int[] GetArgs(string content)
        {
            int[] arg = new int[] { -1, -1 };
            if (!string.IsNullOrEmpty(content))
            {
                arg[0] = FindDistance(content);
                arg[1] = FindWaitingTime(content);
            }
            return arg;
        }

        private int FindDistance(string content)
        {
            var splitRes = content.Split(new string[] { "公里" }, StringSplitOptions.RemoveEmptyEntries);
            if (splitRes != null && splitRes.Length > 0)
            {
                bool distanceRes = int.TryParse(splitRes[0], out int distance);
                if (distanceRes)
                    return distance;
            }
            return -1;
        }

        private int FindWaitingTime(string content)
        {
            var firstSplit = content.Split(new string[] { "等待" }, StringSplitOptions.RemoveEmptyEntries);
            if (firstSplit == null || firstSplit.Length <= 1)
                return -1;
            var secondSplit = firstSplit[1].Split(new string[] { "分钟" }, StringSplitOptions.RemoveEmptyEntries);
            if (secondSplit == null || secondSplit.Length <= 0)
                return -1;
            bool timeRes = int.TryParse(secondSplit[0], out int waitingTime);
            return timeRes ? waitingTime : -1;
        }
    }
}
