Feature: Test cases for DS_Query_AI_USs

  Scenario: Verify AI query response
    Given the AI is running
    When I send a query labeled DS_Query_AI_USs
    Then I should receive a valid response

  Scenario: Validate AI query handling
    Given the AI is active
    When I input a query with label DS_Query_AI_USs
    Then the AI should process the query correctly