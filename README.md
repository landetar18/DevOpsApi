# DevOpsApi
Evaluación técnica NTTData
# Introduction 
DevOps_ServiceApi is a .NET demo application that shows the process of a devops implementation.

# Getting Started
The application is installed in an Azure App Service Web.
1. Clone the DevOps_ServiceApi repository.
2. Compile the .NET solution.

# Build and Test
1. The continues integration to run unit tests and code coverage for quality (FILE: DevOps_ServiceApi-CI.yml).
2. You can test the API's with the following addresses through postman.
https://devopsapifrld.azurewebsites.net/api/customers/message

JSON Test
{
    "message" : "This is a test",
    "to": "You name and last name",
    "from": "Rita Asturia",
    "timeToLifeSec" : 45
}

Return a message with your name and last name.

http://devopsapifrld.azurewebsites.net/api/login/authenticate

JSON Test
{
    "Username":"user",    
    "Password":"123456"
}

Return a token.
