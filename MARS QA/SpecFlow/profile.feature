Feature: profile

As a turnup portal admin Seller would like to Add seller Profile details successfully

@Login
Scenario: Test_1. Seller logged into Mars portal successfully
	Given Login with valid email-id and password 
    Then  The customer name should appear in the Profile page

@Login1
Scenario:Test_2.Validating login functionality
Given Logging in with invalid credentials
And The customer can see "Please enter valid email"
Then Error message should be displayed

@AddLanguage
Scenario Outline: Test_3.Seller is able to add language to profile page
Given I successfully logged into website
When I navigate to language tab in the profile
And I create language details with '<language>'
Then the new record for language should be created with '<language>' successfully
Examples: 
            |Language|   level     |
	        |English |   Basic     |
		    |French  |Intermediate |
@EditLanguage
Scenario Outline: Test_4.Seller is able to edit language in profile page
Given I successfully logged into website
When I navigate to language tab in the profile
And I edit '<language>' details
Then The existing record for '<language>' should be updated successfully
	
Examples: 
		    |Language  	|level |
	        |Hindi	    |fluent|
	        |Japanese   |Basic |

@DeleteLanguage
Scenario:Test_5.Seller is able to delete language in profile page
Given I successfully logged into website
When I navigate to language tab in the profile
And I delete language datails
Then The record of language should be deleted successfully


@AddSkills
Scenario Outline:Test_7.Seller is able to add skills to Profile page
Given I successfully logged into website
When I navigate to Skills tab in the profile
And I add skill details with '<Skill>'
Then the new record for skill should be created with '<Skill>' successfully
Examples: 
           	|Skill   	    |level   |
			|Reading books	|Beginner|
			|Book keeping   |Advanced|

@EditSkills
Scenario Outline: Test_8.Seller is able to edit skills in profile page
Given  I successfully logged  into website
When I navigate to Skills tab in the profile
And I edit '<Skill>' details
Then The existing record for '<Skill>' should be updated successfully

Examples: 
	        |Skill	   |level       |
	        |Cycling   |intermediate|
			|gymnastics|Advanced    |

@DeleteSkills
Scenario: Test_9.Seller is able to delete in profile page
Given : I successfully logged into website
When : I navigate to skills tab in the profile
And :I delete Skill details
Then :The record of Skills should be deleted successfully

@AddEducation
Scenario Outline:Test_10. Seller is able to Add education in profile page
Given : I successfully  logged  into website
When :  I navigate to Education tab in the profile
And : I add Education details with '<College>','<Degree>','<country of college>','<Title>','<year of Graduation>'
Then :The new record for Education is created with '<College>','<Degree>','<country of college>','<Title>','<year of Graduation>' successfully
Examples: 
            |College	     |Degree	     |Country of college|Title   | year of Graduation |
			|Bond University |Bachelors      | Australia        |Btech   |      2012          |
			| Ramo           |Masters        |Newzealand        |MS      |      2016          |

@EditEducation
Scenario Outline:Test_11.Seller is able to Edit education in profile page
Given :  I successfully  logged  into website
When : I navigate to Education tab in the profile
And : I edit Education details with '<College>','<Degree>'
Then : The existing record for Education is updated with '<College>','<Degree>' successfully

Examples: 
            |College	    |Degree  	|Country of college|Title|year of graduation|
			|GU University	|Masters	|Newzealand        |Phd  |      2015        |
			|TU University  |Masters    |Singapore         |MS   |      2013        |

@DeleteEducation
Scenario:Test_12.Seller is able to Delete Education in profile page
Given : I successfully  logged  into website
When : I navigate to Education tab in the profile
And : I delete Education details 
Then : The record of Education should be deleted successfully



