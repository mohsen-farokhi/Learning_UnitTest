using BoDi;
using Suzianna.Core.Screenplay;
using Suzianna.Rest.Screenplay.Abilities;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using UOM.Technical.Rest.Constants;
using UOM.Technical.WebUI.Framework;

namespace UOM.Specs.Hooks
{
    [Binding]
    public class StageApiSetupHook
    {
        private readonly IObjectContainer _container;

        public StageApiSetupHook(IObjectContainer container)
        {
            _container = container;
        }

        [BeforeScenario(tags: "API-Level")]
        public void SetupStage()
        {
            var cast = Cast.WhereEveryoneCan(new List<IAbility>()
            {
                CallAnApi.At(ApiConstants.BaseUrl)
            });

            var stage = new Stage(cast);
            _container.RegisterInstanceAs(stage);
        }

        
    }
}
