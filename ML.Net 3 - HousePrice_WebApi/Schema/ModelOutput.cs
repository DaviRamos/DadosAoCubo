using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.ML.Data;

namespace ML.NET.Web.Embedded.Schema
{
    public class ModelOutput
    {
        [ColumnName("Score")]
        public float Score { get; set; }
    }
}

