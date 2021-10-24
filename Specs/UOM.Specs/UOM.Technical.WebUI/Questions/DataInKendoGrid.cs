using Suzianna.Core.Screenplay.Actors;
using Suzianna.Core.Screenplay.Questions;
using System.Collections.Generic;

namespace UOM.Technical.WebUI.Questions
{
    public class DataInKendoGrid<T> : IQuestion<List<T>>
    {
        public List<T> AnsweredBy(Actor actor)
        {
            return new List<T>();
        }
    }
}
