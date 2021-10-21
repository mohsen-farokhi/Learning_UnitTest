using Suzianna.Core.Screenplay.Actors;
using UOM.Specs.Shared.Models;
using UOM.Specs.Shared.Questions;

namespace UOM.Technical.Rest.Questions
{
    public class LastCreatedDimensionWeb : LastCreatedDimension
    {
        protected override MeasurementDimension Execute(long id, Actor actor)
        {
            throw new System.NotImplementedException();
        }
    }
}
