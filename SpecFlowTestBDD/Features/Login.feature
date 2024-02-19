Feature: Login

Background: 
      Given  I am on the SauceDemo website homepage
	  

@login2
 Scenario: Verify user is able to login succesfully 
    When  I enter the username "standard_user"
	And   I enter the password "secret_sauce"
	And   I click on "Login" button
    Then  I should see the product page

 @login1
 Scenario: Verify the logout_out_user getting error while login

	When  I enter the username "locked_out_user"
	And   I enter the password "secret_sauce"
	And   I click on "Login" button
    Then  I should see an error message