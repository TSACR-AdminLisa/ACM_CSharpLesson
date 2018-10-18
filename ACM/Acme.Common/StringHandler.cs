using System;

namespace Acme.Common
{
    public static class StringHandler
    {

        #region "Variables"
        #endregion

        #region "Constructors:
        #endregion

        #region "Properties"
        #endregion

        #region "Functionality"
        /// <summary>
        /// funcion con extension de su funcionalidad
        /// </summary>
        /// <param name="source">parametro extension de la funcion</param>
        /// <returns></returns>
        public static string InsertSpaces(this string source)
        {
            string result = string.Empty;

            if (!String.IsNullOrWhiteSpace(source))
            {
                foreach (char letter in source)
                {
                    if (char.IsUpper(letter))
                    {
                        result = result.Trim();
                        result += " ";
                    }
                    result += letter;
                }
                result = result.Trim();
            }

            return result;
        }


        #endregion

    }
}
