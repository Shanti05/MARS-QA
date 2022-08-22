Feature: profile

As a turnup portal admin Seller would like to Add seller Profile details successfully

Background: 
Given I logged into Mars portal successfully
When I navigate to Profile Page


Scenario Outline: T01 Seller is able to add language to Languages
Given I Add language details '<Language>','<Level>'
Then the new record for language should be created with '<Language>','<Level>' successfully
Examples: 
|  Language  |    Level      |
|   English  |    Basic      |
|   French   |    Fluent     |

Scenario Outline: T02 Seller is able to edit language to Languages
Given I successfully able  to loggin into website
When I edit language '<Language>','<Level>' details
Then The existing record for '<Language>','<Level>' should be updated successfully
	
Examples: 
|  Language  |     Level        |
|  Hindi	 |   Conversational |


Scenario: T03 Seller is able to delete language in Languages
Given I successfully logged into the website
When I click on delete language 
Then The record of language should be deleted successfully

Scenario: T04 Verify validation error for languages
Given I left language field as blank
Then An Error message should be displayed


Scenario Outline: T05 Seller is able to add skills to Skills Page
Given I add skill details with '<Skill>','<Level>' details
Then the new record for skill should be created with '<Skill>','<Level>' successfully
Examples: 
|   Skill   	|  Level         |
|   Dance	    |  Beginner      |
|  Swimming     |  Intermediate  |

Scenario Outline: T06 Seller is able to edit skills in Skills Page
Given I edit '<Skill>','<Level>' details
Then existing record for '<Skill>','<Level>' should be updated successfully
Examples: 
|   Skill	   |   Level         |
|  Gymnastics  |  Beginner       |


Scenario: T07 Seller is able to delete in Skills Page
Given I click on delete Skills 
Then The record of Skills should be deleted successfully

Scenario: T04 Verify validation error for Skills
Given I left Skills details as blank
Then An Error message is thrown




Scenario Outline: T08 Seller is able to Add education in Education
Given I add Education details with '<Country of college>','<College>','<Title>','<Degree>','<Year>'
Then  The new record for Education is created with '<Country of college>','<College>','<Title>','<Degree>','<Year>' successfully
Examples: 
 |      College    | Country of college |       Title      |    Degree          |      Year         |
 | Bond University |    Algeria         |      M.Tech      |   Bachelors        |      2012         |
 |     Ram         |    Australia       |       M.A        |     Masters        |      2016         |

Scenario Outline: T09 Seller is able to Edit education in Education
Given I edit Education details with '<Country of college>','<College>','<Title>','<Degree>','<Year>'
Then The existing record for Education is updated with '<Country of college>','<College>','<Title>','<Degree>','<Year>' successfully
Examples: 
|     College    |  Country of college  |      Title  | Degree  |      Year          |
|  GU University |       Brazil         |      B.Sc   | PHD     |      2015          |
			

Scenario: T10 Seller is able to Delete Education in Education
Given I delete Education details 
Then The record of Education should be deleted successfully

