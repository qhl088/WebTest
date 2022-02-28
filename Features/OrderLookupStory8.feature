Feature: OrderLookupStory8
	Course order lookup
	Class order lookup

@mytag
Scenario: Course order lookup
	Given I can open homepage
	And I can login admin account
	| name | password     |
	| admin    | 5EstafeyEtre |
	When I select course order and serach
	Then the result should pass

Scenario: Class order lookup
	Given I can open homepage
	And I can login admin account
	| name | password     |
	| admin    | 5EstafeyEtre |
	When I select class order and serach
	Then the result should pass

Scenario Outline: Course order lookup by test case
	Given I can open homepage
	And I can login admin account
	| name | password     |
	| admin    | 5EstafeyEtre |
	When I select course order and input <number> and <info>
	Then the result shoud pass
	Examples: 
	| number | info             |
	| 1      | 2017-12-14 22:51 |
	| 2      | 已付款              |
	| 3      | 支付宝              |
	| 4      | 课程名称             |

Scenario Outline: Class order lookup by test case
	Given I can open homepage
	And I can login admin account
	| name | password     |
	| admin    | 5EstafeyEtre |
	When I select class order and input <number> and <info>
	Then the result shoud pass
	Examples: 
	| number | info             |
	| 1      | 2017-12-14 22:51 |
	| 2      | 已付款              |
	| 3      | 支付宝              |
	| 4      | 班级编号             |