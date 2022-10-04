using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileTaggingService
{    public class FileTagGetter : IFileTagGetter
    {
        public string GetFileTag(string fileName)
        {
            char[] retVal = fileName.ToCharArray();
            int idx = 0;
            for (int i = fileName.Length - 1; i >= 0; i--)
            {
                retVal[idx++] = fileName[i];
            }

            return new string(retVal);
        }
    }
}
