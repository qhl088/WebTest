Feature: NewsManagementStory9
	News management searching by multiple filter
	Changing the status of an article
	Adding a category on News Management Page
	Adding a new Category and Edit the category, change the Category name.

@mytag
Scenario Outline: News management searching by multiple filter
	Given I can open homepage
	And I can login admin account
	| name | password     |
	| admin    | 5EstafeyEtre |
	When I select News Management go to news mangement page
	And searching by multiple filter <category> and <case>
	Then the result is displayed

	Examples: 
	| category | keyword | property | published | unpublished |
	| Edusoho  |         |          |           |             |
	| Edusoho  | 世界      |          |           |             |
	| Edusoho  |         | 头条       |           |             |
	| Edusoho  |         |          | 已发布       |             |
	| Edusoho  |         |          |           | 未发布         |

Scenario: Changing the status of an article
	Given I can open homepage
	And I can login admin account
	| name | password     |
	| admin    | 5EstafeyEtre |
	When I select News Management go to news mangement page
	And switch an article status 
	| category | published | unpublished |
	| Edusoho  | 发布        | 取消发布        |
	Then  the result is displayed

Scenario: Adding a category on News Management Page
	Given I can open homepage
	And I can login admin account
	| name | password     |
	| admin    | 5EstafeyEtre |
	When I select News Management go to category mangement page
	And open new category and title is <title> and code <code>
	| title | code   |
	| 自动化    | 314bbc |
	Then  the result title is displayed

Scenario: Adding a new Category and Edit the category, change the Category name.
	Given I can open homepage
	And I can login admin account
	| name | password     |
	| admin    | 5EstafeyEtre |
	When I select News Management go to category mangement page
	And switch <code> to <newtitle> status
	| title | code   | newtitle |
	| 自动化   | 314bbc | 自动化测试    |
	Then  the result title status is displayed