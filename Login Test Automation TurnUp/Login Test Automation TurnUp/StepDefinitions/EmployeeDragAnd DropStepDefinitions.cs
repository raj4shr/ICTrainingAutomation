﻿using Login_Test_Automation_TurnUp.EmployeeFolder;
using TechTalk.SpecFlow;
using WebDriver = Login_Test_Automation_TurnUp.SetupCommonClassFolder.WebDriver;

namespace Login_Test_Automation_TurnUp.StepDefinitions
{
    [Binding]
    public class EmployeeDragAnd_DropStepDefinitions : WebDriver
    {
        EmployeeDragAndDropPage? employeeDAD;
        [When(@"I have dragged and dropped a column tab")]
        public void WhenIHaveDraggedAndDroppedAColumnTab()
        {
            employeeDAD = new();
            employeeDAD.dragAnddropEmployee(chromeDriver);
        }

        [Then(@"the employee page should be sorted successfully")]
        public void ThenTheEmployeePageShouldBeSortedSuccessfully()
        {
            Thread.Sleep(3000);
            employeeDAD.dragAnddropCloseBDD(chromeDriver);
            chromeDriver.Quit();
        }

    }
}
