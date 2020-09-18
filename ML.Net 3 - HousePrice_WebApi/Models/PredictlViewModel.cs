using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.ML.Data;

namespace HousePrice_WebApi.Models
{
    public class PredictlViewModel
    {
        [LoadColumn(0)]
        public float Longitude { get; set; }
        [LoadColumn(1)]
        public float Latitude { get; set; }
        [LoadColumn(2)]
        public float Housing_median_age { get; set; }
        [LoadColumn(3)]
        public float Total_rooms { get; set; }
        [LoadColumn(4)]
        public float Total_bedrooms { get; set; }
        [LoadColumn(5)]
        public float Population { get; set; }
        [LoadColumn(6)]
        public float Households { get; set; }
        [LoadColumn(7)]
        public float Median_income { get; set; }
        [ColumnName("Label"), LoadColumn(8)]
        public float Median_house_value { get; set; }
        [LoadColumn(9)]
        public string Ocean_proximity { get; set; }
    }
}
