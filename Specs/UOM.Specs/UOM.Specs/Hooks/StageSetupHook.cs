using BoDi;
using Suzianna.Core.Screenplay;
using Suzianna.Rest.Screenplay.Abilities;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using UOM.Specs.Constants;

namespace UOM.Specs.Hooks
{
    [Binding]
    public class StageSetupHook
    {
        private readonly IObjectContainer _container;

        public StageSetupHook(IObjectContainer container)
        {
            _container = container;
        }

        [BeforeScenario]
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
