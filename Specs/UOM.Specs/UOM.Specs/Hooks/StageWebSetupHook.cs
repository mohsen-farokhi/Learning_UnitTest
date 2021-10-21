using BoDi;
using Suzianna.Core.Screenplay;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using UOM.Technical.WebUI.Framework;

namespace UOM.Specs.Hooks
{
    [Binding]
    public class StageWebSetupHook
    {
        private readonly IObjectContainer _container;
        private BrowseTheWeb _browseTheWeb;

        public StageWebSetupHook(IObjectContainer container)
        {
            _container = container;
        }

        [BeforeScenario(tags: "UI-Level")]
        public void SetupStage()
        {
            _browseTheWeb = new BrowseTheWeb();
            var cast = Cast.WhereEveryoneCan(new List<IAbility>()
            {
                new BrowseTheWeb()
            });

            var stage = new Stage(cast);
            _container.RegisterInstanceAs(stage);
        }

        [AfterScenario(tags: "UI-Level")]
        public void DisposeAbility()
        {
            _browseTheWeb.Dispose();
        }
    }
}
