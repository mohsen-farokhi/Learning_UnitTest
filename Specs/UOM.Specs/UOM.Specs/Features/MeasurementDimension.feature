Feature: Managing Measurement Dimension
	In order to categorize unit of measure and convert them to each other only in their dimension
	As a procurement manager
	I want to be able to define measurement dimension

@mytag
Scenario: Defining dimension
	Given i have entered as procurement manager account
	When i define the following dimension
	| Name | Symbol |
	| Mass | m      |
	Then i should be able to see dimension in the list of dimension