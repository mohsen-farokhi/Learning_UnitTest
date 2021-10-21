﻿using Suzianna.Core.Screenplay.Actors;
using Suzianna.Core.Screenplay.Questions;
using UOM.Specs.Shared.Constants;
using UOM.Specs.Shared.Models;

namespace UOM.Specs.Shared.Questions
{
    public abstract class LastCreatedDimension : IQuestion<MeasurementDimension>
    {
        public MeasurementDimension AnsweredBy(Actor actor)
        {
            var id = actor.Recall<long>(Keys.Dimension.DimensionId);
            return Execute(id, actor);
        }

        protected abstract MeasurementDimension Execute(long id, Actor actor);

    }
}
