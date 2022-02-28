Feature: UnpdatePorfileStory6
	user update valid info, no error is displayed
	user update invalid info, errors are displayed

@mytag
Scenario: User can update the basic info
	Given I can open homepage
	And I can select login
	When I input valid username and password
	|name|password|
	|test001|Test1234|
	And I select login button
	And I move to personal list
	And I select persaonl option
	And I select basic infor
	When I enter valid name 
	| name    |
	| test002 |
	Then the result is error not display

Scenario Outline: User can not update the basci infor with invalid text
	Given I can open homepage
	And I can select login
	When I input valid username and password
	|name|password|
	|test001|Test1234|
	And I select login button
	And I move to personal list
	And I select persaonl option
	And I select basic infor
	When I enter invalid infor <number> and <info>
	Then the result <error> is dispalyed

	Examples: 
	| number | info                              | error                       |
	| 1      | test000001aaaaaaaaa               | 最多输入18个字符                   |
	| 2      | abdcef                            | 请正确输入您的身份证号                 |
	| 3      | 123                               | 请输入正确的手机号                   |
	| 4      | If you were a teardrop;In my eye, | 最多只能输入24个字符                 |
	| 5      | httpss://www.baidu.com            | 地址不正确，须以http://或者https://开头 |
	| 6      | htt://www.baidu.com               | 地址不正确，须以http://或者https://开头 |
	| 7      | abbbbb                            | 请输入正确的qq号                   |
