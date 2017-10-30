Feature: MVCFeatureNext
	In order to create and view Active/Completed/All tasks in the ToDoMvc AngularJSpage
	As a user
	I want to ensure the ToDOMVc page elements and task lists are displayed correctly


Scenario Outline:Verify New Task
Given I am on the ToDoMvc AngularJS Page
When I Enter a New <Task>
And I press Enter
Then the new <Task> is populated on the List
	
Examples:
| Task              |
| 30 days Challenge |


Scenario Outline: Verify Complete Task
Given I am on the ToDoMvc AngularJS Page
When I Enter a New <Task>
And I press Enter
And I click on Checkbox of Acive <Task>
And I Click on the Complete 
Then the <Task> is displayed on the Completed List

Examples:
| Task       |
| Unit Tests |

#@Clear_Completed_Task
#Scenario Outline:Verify Clear Complete Task
#Given I am on the ToDoMvc AngularJS Page
#When I Enter a New <Task1>
#And I press Enter
#And I Enter a New <Task2>
#And I press Enter
#And I click on Checkbox of Acive <Task1>
#And I Click on the Complete 
#And click on Completed <Task1>
#Then only <Task2> is Displayed
#And <Task1> is not Displayed
#
#Examples:
#| Task1   | Task2     |
#| Meetups | Challenge |

