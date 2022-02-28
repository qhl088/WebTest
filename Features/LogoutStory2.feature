Feature: LogoutStory2
	User can logout 

@mytag
Scenario: User Can Log out
	Given I can open homepage
	And I can select login
	When I input valid username and password
	|name|password|
	|test001|Test1234|
	And I select login button
	And I move to personal list
	And I select logout option
	Then the logout should be successful