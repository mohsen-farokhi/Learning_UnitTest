using OpenQA.Selenium;
using UOM.Specs.Shared.Models;
using UOM.Specs.Shared.Tasks;
using UOM.Technical.WebUI.Framework.Interaction;
using UOM.Technical.WebUI.Kendo;
using UOM.Technical.WebUI.Questions;

namespace UOM.Specs.Screenplay.Tasks
{
    public class DefineDimensionWeb : DefineDimension
    {
        public DefineDimensionWeb(MeasurementDimension dimension) : base(dimension)
        {
        }

        protected override long Excute<T>(T actor)
        {
            actor.AttemptsTo
                (new OpenThePage("http://localhost:4200/dimension-list"),
                new Click(By.Id("addDimensionBtn")),
                new FillInput(By.Id("name"), Dimension.Name),
                new FillInput(By.Id("symbol"), Dimension.Symbol),
                new Click(By.Id("saveButton")),
                new WaiatForKendoGrid());

            var dataInGrid = actor.AsksFor(new DataInKendoGrid<MeasurementDimension>());
            // find created id from grid data
            return 0;
        }
    }
}
