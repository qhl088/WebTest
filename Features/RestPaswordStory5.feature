Feature: RestPaswordStory5
	rest password by unrigister email
	rest password by invalid email

@mytag
Scenario: Forgot your password wint unregister email
	Given I can open homepage
	And I can open login page
	And I select reset password 
	When I input valid email
	| email           |
	| wdfer@gmail.com |
	And I select reset button
	Then the email error is displayed

Scenario: Forgot your password witn invalid email
	Given I can open homepage
	And I can open login page
	And I select reset password 
	When I input valid email
	| email   |
	| wdfer@@ |
	And I select reset button
	Then the invalid email error is displayed