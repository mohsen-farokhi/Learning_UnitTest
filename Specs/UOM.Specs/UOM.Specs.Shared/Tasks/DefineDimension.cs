using Suzianna.Core.Screenplay;
using Suzianna.Core.Screenplay.Actors;
using UOM.Specs.Shared.Constants;
using UOM.Specs.Shared.Models;

namespace UOM.Specs.Shared.Tasks
{
    public abstract class DefineDimension : ITask
    {
        public DefineDimension(MeasurementDimension dimension)
        {
            Dimension = dimension;
        }

        protected MeasurementDimension Dimension { get; }

        public void PerformAs<T>(T actor) where T : Actor
        {
            var createdId = Excute(actor);
            actor.Remember(Keys.Dimension.DimensionId, createdId);
        }

        protected abstract long Excute<T>(T actor) where T : Actor;
    }
}
