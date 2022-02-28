Feature: LoginStory1
	login winh valid username and password, not click remember me
	login winh valid username and password, click remember me
	login with invalid username and password

@mytag
Scenario: Login With Valid
	Given I can open homepage
	And I can select login
	When I input valid username and password
	| name    | password |
	| test001 | Test1234 |
	And I select login button
	Then the result should be successful

	Scenario: Login With Valid and Remebselect
	Given I can open homepage
	And I can select login
	When I input valid username and password
	| name    | password |
	| test001 | Test1234 |
	And I can select remember me
	Then the result should be successful

	Scenario: Login With Invalid
	Given I can open homepage
	And I can select login
	When I input invalid username and password
	| name | password |
	| test | Test     |
	Then the login should not be successful
