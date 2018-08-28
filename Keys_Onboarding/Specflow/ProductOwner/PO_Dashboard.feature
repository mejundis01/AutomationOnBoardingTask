Feature: PO_Dashboard
	

@mytag
Scenario: Check if user is able to add new property
	Given User have logged into the application
	When  User have added a new property
	Then  The browser will be closed

Scenario: Check if user is able to add a tenant
	Given User have logged into the application
	When  User have listed a new tenant
	Then The browser will be closed

Scenario: Check if user is able to list as rental
	Given User have logged into the application
	When  User have listed a new rental property
	Then The browser will be closed

Scenario: Check if user is able to send a request
	Given User have logged into the application
	When  User have sent a new request
	Then The browser will be closed


	