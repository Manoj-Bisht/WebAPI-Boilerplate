WebAPI-Boilerplate
==================

WebAPIBoilerplate is implemented to provide a kick start WebAPI project providing layer architecture along with integration of other required frameworks like Logging, IoC, Validation, Error Handling and so on.
It will benefit developers who are initiating a large scale API based middleware project
## Components

### API

- WebAPI.Boilerplate.Api -Main WebAPI (RESTful) interface providing web interface to client applications

### Service
- WebAPI.Boilerplate.BusinessService.Interface -Abstraction on business services (also known as Business Access Layer)
- WebAPI.Boilerplate.BusinessService.Service -Implementation of the business services 

### Repository
- WebAPI.Boilerplate.DataService.Interface -Abstraction on repository services (also known as Data Access Layer)
- WebAPI.Boilerplate.DataService -Implementation of repository services (also known as Data Access Layer)

### Domain
- WebAPI.Boilerplate.Model -Data model (POCO) providing data transfer objects across layers

### IoC
- WebAPI.Boilerplate.DependencyResolver -Each layer calls is loosely coupled with constructor dependencies between the layers. WebAPI.Boilerplate.DependencyResolver is built to resolve application dependencies

### Logging
- WebAPI.Boilerplate.Logger -It is wrapper around the log4net framework to providing logging feature across different layers

### Utility
- WebAPI.Boilerplate.Utility.Common -Common utility methods

## DEPENDECIES
### Tools and Frameworks
- Log4net
- SimpleInjector
- Visual Studio 2013
- NuGet Package Manager

## ROAD MAP
I will continue adding more tools and framework aiming completion of the startup project. You can contribute by developing/reviewing the project.
- Exception Handling
- Validation
- Unit Testing with mocking frameworks
- Security
- Versioning
- Etc.

## REVISION HISTORY
### V1.0
- N-layer project structure 
- Integration to logging
- Integration to IoC container
