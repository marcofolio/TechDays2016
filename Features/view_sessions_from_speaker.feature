Feature: View sessions from speaker

Scenario Outline: View sessions from speaker
	Given I am on the Speakers page
	When I view the sessions from "<name>"
	Then I should see these "<sessions>"

	Examples:
        |  name          |  sessions                                |
        | Marco Kuiper   | Turn specs into high quality apps        |
        | Wilfred Wattel | Turn specs into high quality apps        |