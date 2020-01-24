﻿using ExerciseAnswers.DataEntities;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace ExerciseAnswers.StepDefinitions
{
    [Binding]
    public class SpecFlowAssistSteps
    {
        private Album myAlbum;

        [Given(@"the following album exists")]
        public void GivenTheFollowingAlbumExists(Table table)
        {
            myAlbum = table.CreateInstance<Album>();
        }

        [When(@"the album is rereleased")]
        public void WhenTheAlbumIsRereleased()
        {
            myAlbum.ReleaseYear = DateTime.Now.Year;
        }

        [Then(@"the new album details should be")]
        public void ThenTheNewAlbumDetailsShouldBe(Table table)
        {
            table.CompareToInstance(myAlbum);
        }
    }
}
