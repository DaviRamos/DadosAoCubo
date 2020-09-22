using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.ML;
using ML.NET.Web.Embedded.Schema;

namespace ML.NET.Web.Embedded.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PredictionController : ControllerBase
    {
        private readonly PredictionEnginePool<ModelInput, ModelOutput> predictionEnginePool;

        public PredictionController(PredictionEnginePool<ModelInput, ModelOutput> predictionEnginePool)
        {
            this.predictionEnginePool = predictionEnginePool;
        }

        [HttpGet]
        public string Get()
        {
            return "WebAPI de Predição";
        }

        [HttpPost]
        [Route("predict")]
        public ModelOutput Predict(ModelInput modelInput)
        {
            return this.predictionEnginePool.Predict(modelInput);
        }
    }
}
