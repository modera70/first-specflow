Feature: Token
	In order to verify if Token service works properly
	As a QA Engineer
	I want to get the response expected

@mytag
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
