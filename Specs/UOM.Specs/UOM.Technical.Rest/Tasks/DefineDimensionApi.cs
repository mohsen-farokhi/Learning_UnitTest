using Suzianna.Core.Screenplay;
using Suzianna.Core.Screenplay.Actors;
using Suzianna.Rest.Screenplay.Interactions;
using Suzianna.Rest.Screenplay.Questions;
using UOM.Specs.Shared.Constants;
using UOM.Specs.Shared.Models;
using UOM.Specs.Shared.Tasks;

namespace UOM.Specs.Screenplay.Tasks
{
    public class DefineDimensionApi : DefineDimension
    {
        public DefineDimensionApi
            (MeasurementDimension dimension) : base(dimension)
        {
        }

        protected override long Excute<T>(T actor)
        {
            actor.AttemptsTo(Post.DataAsJson(Dimension).To("Dimensions"));
            var createdId = actor.AsksFor(LastResponse.Content<long>());

            return createdId;
        }
    }
}
