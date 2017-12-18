using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace 测试web
{
    public class MyNameTransfom : ICSharpCode.SharpZipLib.Core.INameTransform
    {

        #region INameTransform 成员

        public string TransformDirectory(string name)
        {
            return null;
        }

        public string TransformFile(string name)
        {
            return Path.GetFileName(name);
        }

        #endregion
    }
}
