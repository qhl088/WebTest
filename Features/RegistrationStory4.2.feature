Feature: RegistrationStory4.2
	Simple calculator for adding two numbers

@mytag
Scenario Outline: Registration - with invalid register details
	Given I can open homepage
	And I can select register page
	When I register with <email> and <name> and <password>
	Then the result error <error> is displayed
	Examples: 
	| email           | name               | password | error        |
	| wdfer@gmail.com | test10test10test10 | Test2345 | 字符长度必须小于等于18 |
	| wdfer@@         | test1              | Test2345 | 请输入有效的电子邮件地址 |
	| wdfer@@         | test1              | @@       | 最少需要输入5个字符   |
	|                 |                    |          | 请输入邮箱        |