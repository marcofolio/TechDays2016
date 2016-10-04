Feature: Favoriting a session
	
Scenario: Favorite a session
	Given I am on a Session Details page
	When I press Favorite
	Then The session will be marked as Favorite
	And I should see "Remove from Favorites"