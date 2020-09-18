using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HousePrice_WebApi.Models;
using Microsoft.ML;
using Microsoft.ML.Data;

namespace HousePrice_WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HousePricePredictionController : Controller
    {
        string modelPath = @"./HouseModelv2.zip";

        [HttpGet]
        public string Get()
        {
            return "WebAPI de Predição";
        }

        [Route("predict")]
        [HttpPost]
        public float Predict(PredictlViewModel viewModel)
        {
            MLContext mlContext = new MLContext();

            var model = mlContext.Model.Load(modelPath, out var modelInputSchema);
            // Criar um mecanismo de predição relacionado ao modelo treinado carregado
            var predEngine = mlContext.Model.CreatePredictionEngine<PredictlViewModel, ModelOutput>(model);

            //Score
            var resultprediction = predEngine.Predict(viewModel);

            return resultprediction.Score;
        }

    }
}
