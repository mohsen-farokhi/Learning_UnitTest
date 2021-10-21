using Suzianna.Core.Screenplay.Actors;
using Suzianna.Rest.Screenplay.Interactions;
using Suzianna.Rest.Screenplay.Questions;
using UOM.Specs.Shared.Models;
using UOM.Specs.Shared.Questions;

namespace UOM.Technical.Rest.Questions
{
    public class LastCreatedDimensionApi : LastCreatedDimension
    {
        protected override MeasurementDimension Execute(long id, Actor actor)
        {
            actor.AttemptsTo(Get.ResourceAt($"Dimensions/{id}"));

            return actor.AsksFor(LastResponse.Content<MeasurementDimension>());
        }
    }
}
