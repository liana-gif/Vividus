Description: Simple story to sugn up a new user;

Scenario: Open application under test
Given I am on the main application page

Scenario: Verify page title
Then the page title is equal to 'Reddit: Dive into anything'

Scenario: SignUp
When I click on element located `By.xpath(//a[@class="Z_HUY3BUsGOBOtdmH94ZS _3Wg53T10KuuPmyWOMWsY2F _2iuoyPiKHN3kfOoeIQalDT _10BQ7pjWbeYP63SAPNS8Ts HNozj_dKjQZ59ZsfEegz8 _2nelDm85zKKmuD94NequP0"])`
When I switch to frame located `By.xpath(//iframe[@class="_25r3t_lrPF3M6zD2YkWvZU"])`
When I enter `#{generate(Internet.emailAddress)}` in field located `By.xpath(//input[@id="regEmail"])`
When I click on element located `By.xpath(//button[text() ="Continue"])`

When I enter `${username}` in field located `By.xpath(//input[@id="regUsername"])`
When I enter `${password}` in field located `By.xpath(//*[@id="regPassword"])`


When I click on element located `By.xpath(//div[@class="recaptcha-checkbox-borderAnimation"])`

When I switch to frame located `By.xpath(//iframe[starts-with(@name, 'a-') and starts-with(@src, 'https://www.google.com/recaptcha')])`
When I click on element located `By.xpath(//div[@class="recaptcha-checkbox-border"])`


 


