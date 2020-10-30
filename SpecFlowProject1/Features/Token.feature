Feature: Token
	In order to verify if Token service works properly
	As a QA Engineer
	I want to get the expected response

@dev @stage @api @regression
Scenario Outline: Get status successful code
	Given I have the access token URL '<URL>'
	And the grant type '<GrantType>'
	And the scope '<Scope>'
	And the client id '<ClientID>'
	And the client secret '<ClientSecret>'
	When I make a POST request
	Then the result statsu code should be <StatusCode>
	Examples: 
	| URL                                       | GrantType          | ClientID                         | ClientSecret                                         | StatusCode | Scope |
	| https://auth.stg-gbmapi.com/connect/token | client_credentials | r38QvL6VRe6cLhBC2Peb9edkaC9gUHZi | 2UvUvEhDYU9eLLGSiNhiRivCKdL7kZfw2z6qMj5k8ywu6Sfvvqnt | 200        |       |

	@api @other 
	Scenario Outline: Get status successful code with req specification file
	Given I have the token request specification '<RequestSpecificationFile>'
	When I make a the request
	Then the result statsu code should be <StatusCode>
	Examples: 
	| RequestSpecificationFile                             | StatusCode |
	| Resources/RequestSpecifications/valid-token-req.json | 200        |
