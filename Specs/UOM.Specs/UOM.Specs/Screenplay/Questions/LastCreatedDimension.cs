using Suzianna.Core.Screenplay.Actors;
using Suzianna.Core.Screenplay.Questions;
using Suzianna.Rest.Screenplay.Interactions;
using Suzianna.Rest.Screenplay.Questions;
using UOM.Specs.Constants;
using UOM.Specs.Models;

namespace UOM.Specs.Screenplay.Questions
{
    public class LastCreatedDimension : IQuestion<MeasurementDimension>
    {
        public MeasurementDimension AnsweredBy(Actor actor)
        {
            var id = actor.Recall<long>(Keys.Dimension.DimensionId);

            actor.AttemptsTo(Get.ResourceAt($"Dimensions/{id}"));

            return actor.AsksFor(LastResponse.Content<MeasurementDimension>());
        }
    }
}
