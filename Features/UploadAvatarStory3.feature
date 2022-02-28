Feature: UploadNewAvatarStory3
	I can change user avatar

@mytag
Scenario: Change New User Avatar
	Given I can open homepage
	And I can select login
	When I input valid username and password
	|name|password|
	|test001|Test1234|
	And I select login button
	And I move to personal list
	And I select persaonl option
	And I select avatar setting 
	And I upload Specified image
	Then the avatar upload should be successful