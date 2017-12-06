Feature: APITests
	In order to search 
	As a API Consumer
	I want the API to send me proper failure response codes
	so that I can handle them and show appropriate error pages to user

@search
Scenario: Search API called with missing parameter
	Given I call Search API without parameter	
	When I get the response back from API
	Then API returns <404>