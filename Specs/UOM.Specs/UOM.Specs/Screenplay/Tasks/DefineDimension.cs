using Suzianna.Core.Screenplay;
using Suzianna.Core.Screenplay.Actors;
using Suzianna.Rest.Screenplay.Interactions;
using Suzianna.Rest.Screenplay.Questions;
using UOM.Specs.Constants;
using UOM.Specs.Models;

namespace UOM.Specs.Screenplay.Tasks
{
    public class DefineDimension : ITask
    {
        private readonly MeasurementDimension _dimension;

        public DefineDimension(MeasurementDimension dimension)
        {
            _dimension = dimension;
        }

        public void PerformAs<T>(T actor) where T : Actor
        {
            actor.AttemptsTo(Post.DataAsJson(_dimension).To("Dimensions"));
            var createdId = actor.AsksFor(LastResponse.Content<long>());

            actor.Remember(Keys.Dimension.DimensionId, createdId);
        }
    }
}
