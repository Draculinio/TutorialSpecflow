Feature: googleTranslate
	As a user I want to translate phrases from different languages

@This is for US 666
Scenario: Translate something
	Given I enter to google translator site
	And I enter 'Hola Mundo' in the translator textbox
	When I press the translate button
	Then the answer should be 'Hello World'

Scenario: Translate changing language
	Given I enter to google translator site
	And I change language to 'spanish'
	And I enter 'Auto' in the translator textbox
	When I press the translate button
	Then the answer should be 'Car'

Scenario Outline: Translate with some data
	Given I enter to google translator site
	And I enter <text to translate> in the translator textbox
	When I press the translate button
	Then the answer should be <text translated>

	Examples: 
	| text to translate | text translated |
	| Automovil         | Car             |
	| Silla             | Chair           |