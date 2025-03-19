using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseINC
{
    static class ClutterVars
    {
        public static string[] _DATATYPES = { "INT", "SMALLINT", "DEC", "NUMERIC", "FLOAT", "DOUBLE", "CHAR", "VARCHAR", "BINARY", "VARBINARY", "BLOB", "TEXT", "ENUM", "SET",
                                              "DATE", "TIME", "DATETIME", "TIMESTAMP", "YEAR" };

        public static void ArraySort()
        {
            Array.Sort(_DATATYPES);
        }
    }
}
