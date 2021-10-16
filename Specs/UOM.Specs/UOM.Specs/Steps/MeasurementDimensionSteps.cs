using FluentAssertions;
using RestSharp;
using Suzianna.Core.Screenplay.Actors;
using Suzianna.Rest.Screenplay.Abilities;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using UOM.Specs.Models;

namespace UOM.Specs.Steps
{
    [Binding]
    public class MeasurementDimensionSteps
    {


        private Actor _actor;

        [Given(@"i have entered as procurement manager account")]
        public void GivenIHaveEnteredAsProcurementManagerAccount()
        {
            _actor = Actor.Named("ProcurementManager").WhoCan(CallAnApi.At("http://localhost:5000"));


        }

        [When(@"i define the following dimension")]
        public void WhenIDefineTheFollowingDimension(Table table)
        {
            var dimension = table.CreateInstance<MeasurementDimension>();


        }

        //private long _createdId;

        //private readonly RestClient _client =
        //    new RestClient("http://localhost:5000/");

        //private MeasurementDimension _expectedDimension;

        //[Given(@"i have entered as procurement manager account")]
        //public void GivenIHaveEnteredAsProcurementManagerAccount()
        //{
        //}

        //[When(@"i define the following dimension")]
        //public void WhenIDefineTheFollowingDimension(Table table)
        //{
        //    _expectedDimension = table.CreateInstance<MeasurementDimension>();

        //    var request =
        //        new RestRequest("dimensions", DataFormat.Json);

        //    request.AddJsonBody(_expectedDimension);

        //    var response = _client.Post<long>(request);

        //    _createdId = response.Data;
        //}

        //[Then(@"i should be able to see dimension in the list of dimension")]
        //public void ThenIShouldBeAbleToSeeDimensionInTheListOfDimension()
        //{
        //    var request =
        //        new RestRequest($"dimensions/{_createdId}", DataFormat.Json);

        //    var response = _client.Get<MeasurementDimension>(request);

        //    var actualDimension = response.Data;

        //    actualDimension.Should().BeEquivalentTo(_expectedDimension);
        //}
    }
}
