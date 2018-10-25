using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Common
{
    public class OperationResult
    {

        #region "Properties"
        public bool Success { get; set; }
        public List<string> MessageList { get; private set; }
        #endregion

        #region "Constructor"
        public OperationResult()
        {
            MessageList = new List<string>();
            Success = true;
        }
        #endregion

        #region "Functionality"
        public void AddMessage(string message)
        {
            MessageList.Add(message);
        }
        #endregion

    }
}
