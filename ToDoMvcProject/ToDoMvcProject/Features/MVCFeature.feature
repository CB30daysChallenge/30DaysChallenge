Feature: ToDoMvcFeature
	In order to create and view Active/Completed/All tasks in the ToDoMvc AngularJSpage
	As a user
	I want to ensure the ToDOMVc page elements and task lists are displayed correctly

@Browser_Chrome
@Browser_Firefox
Scenario:Verify Completed Lists
Given I am on the ToDoMvc AngularJS Page
When I Enter New tasks
| Tasks      |
| US Racing  |
| Specflow   | 
And I click on the checkbox of one of the tasks
And I Click on the Complete 
Then all entered tasks are displayed

Scenario:Verify Active Lists
Given I am on the ToDoMvc AngularJS Page
When I Enter New tasks
| Tasks              |
| 30 days Challenge  |
| Unit Tests         | 
And I Click on the Active 
Then all entered tasks are displayed

Scenario:Verify New Tasks
Given I am on the ToDoMvc AngularJS Page
When I Enter New tasks
| Tasks             |
| SIS Greyhounds    |
| SIS Throughbreds  | 
Then all entered tasks are displayed

Scenario:Verify All Lists
Given I am on the ToDoMvc AngularJS Page
When I Enter New tasks
| Tasks      |
| Automation |
| Atlas      |
And I click on the checkbox of one of the tasks
And I Click on the All 
Then all entered tasks are displayed

