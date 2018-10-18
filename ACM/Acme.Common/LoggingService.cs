using Acme.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Acme.Common
{
    public class LoggingService
    {
        #region "Variables"
        #endregion

        #region "Constructors:
        #endregion

        #region "Properties"
        #endregion

        #region "Functionality"

        public static void WriteToFile(List<ILoggable> changedItems)
        {
            foreach (var item in changedItems)
            {
                Console.WriteLine(item.Log());
            }
        }

        #endregion
    }
}
