Feature:UITest

Scenario: 01_Validate access the site
	Given I go to "http://demo.cs-cart.com/"
	Then the site will be displayed

Scenario: 02_Validate the filling of informations
	Given I search for a product
	Then the search page will be displayed

Scenario: 03_Validate the access in the product
	Given I click on the product
	Then the product page will be displayed
	
Scenario: 04_Validate Add to Cart
	Given I click on Add To Cart button
	And I click on Cart icon
	When I click on View Cart button
	Then the cart page will be displayed

Scenario: 05_Validate checkout page

	Given I click on Proceed to Checkout button
	Then the checkout page will be displayed

Scenario: 06_Validate Order
	Given I click on Sign In button
	And I click on Sign In button in the login box
	And I click on Phone Option
	And I click on the terms box
	When I click on Checkout confirm option
	Then the order will be confirmed
		