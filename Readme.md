# .NET Web API Backend Code Challenge

The objective of this challenge is to evaluate general knowledge in back-end development and API Design.

## Pre-requisites:
- Visual Studio 2019.
- SQL Server Management Studio or Azure Data Studio.
- A Local instance of SQL Server or an Azure SQL resource in the candidate's Azure Subscription.

## Areas of interest:
- Application and Solution Organization.
- API Design.
- REST Principles.
- Relational Database Design.
- Querying.
- Testability.

## Requirements:
Fork this repo, complete the exercise and answer the questions on the Readme file. Give yourself about an hour to complete and see how far did you get. Make at least one commit per each of the following requirements.

- Create an endpoint to return the collection of all available locations. Would your solution work if the number locations was very large? Think of all the Cities in the US, for example.
- Make the necessary database and data access layer modifications to allow different items to be sold in specific locations.
- Create an endpoint to return the collection of all items available in a specific location. Would your solution work for large number of items.
- Create an item to return a list of locations and the number of items available in each.
- Create a test to verify that asking for the items in a non-existing location returns an HTTP status code 404.
- Add an endpoint to create a new item.
- Create a test to verify that the Create New Item endpoint actually persists a new item.
- Make the necessary database and data access layer modifications to add a new Supplier column to the Item table.

## Questions:
- How would you modify the API to support server-side pagination?
- How would you modify the API to use different DB connections in Test and Production?
- How would you modify the API to validate the input in the Create Item endpoint?
- How would you modify the API to prevent the user for adding the same Item twice.
- How would you modify the API, the tests and the configuration to allow the tests to run in isolation?
- How would you modify the responses of the API to make them self-descriptive and allow the developer to discovery of the capabilities?
- How would you modify the API to prevent the LocationsController.GetLocationById method from locking the currently executing thread?
- How would you modify the API to prevent the leakage of newly added fields to the Items collection.
- How would you determine the performance of the endpoints is adequate?
- How would you deploy this application?
- How would you provision the resources necessary to test and run the API?
- How would you secure this API?
- How would you secure the application to prevent Users related to one Location from accessing the list of Items of another Location?
- How would you add developer documentation to the API?
- How would you design the API to allow modifications to existing Items, when multiple clients may request changes at the same time?
- How would you design the API to add more fields to the Items collection without breaking existing clients?
- What steps would you take to make sure the API is scalable in peak days, like Black Friday, Halloween, Mother's Day or other consumerist holidays?
- Would there be any advantage in using a NoSQL database? Why? Wich?
