using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.ML.Data;


namespace HousePrice_WebApi.Models
{
    public class ModelOutput
    {
        [ColumnName("Score")]
        public float Score { get; set; }
    }
}
