Feature: PO_Inspections
	
@mytag
Scenario: Check if user is able to add new inspection request
Given User have logged into the application
When User have sent a new inspection request
Then The browser will be closed
