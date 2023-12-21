# H3PD_SW_Test

Repository with a small code sample used in the course Software Test on H3PD (TECHCOLLEGE Aalborg)



# Purpose

To show a practical usage of Unit Testing and Continuous Integration using Gitlab


The source code contains three projects:

## math

A class lib containing the namespace **techmath** with a number of "simple" math related classes

* Fraction
* Shape
	* Rectangle
	* Circle
* QuadraticFormula

## tests

A XUnit test based project for unit testing of the **techmath** classes

## console_app

A sample console based application demonstrating the simple usages of the **techmath** classes

# Continuous Integration

The continuous integration process is defined in **.gitlab-ci.yml**

It contains two stages:

* build
* test





![Pipelines](pipelines.png "Gitlab Pipelines in this project").
![Code Coverage](coverage.png "Code coverage of the unit tests").


# Feedback

Any Feedback is very welcome: pmad@techcollege.dk

