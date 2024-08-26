# Game-Programming-Class-Materials

This is the repository of all Unity code and scene examples used in the SER 494/594 Game Programming and Design class.

## This project has been updated for Unity version 2022.3.43f1

Unity is explicitly NOT backwards compatable so these examples will not be expected to work in previous versions of Unity. While it should work in the above version without any issue, you should be able to update it to any later version with only minor deprecation warnings. This project will be updated to the latest version every time this course is run. 

## Project Structure

The intention is for you to download the entire Unity porject as one whole set of examples. At the top level of the project is a set of folders, one for each module in the course. All of these folders are treated as their own self contained projects. So, each has all the related scripts in it and an example scene that has those scripts and such being used.

There are some Modules with no scripts or example scenes. Currently, such modules do not have scripts associated with them. Those modules have all of their content on the class slides. These modules are left here though just in case examples for these are created later.

The bonus modules folder contains extra modules created by the Teaching Assistants. Each time this course runs the TA will create their own module that will be fit somewhere within the regular modules. These will cover some topic not covered by the regular modules and are kept for future reference.

## The Dummy Method

Many scripts contain a method with the signature `public void dummy()` that just prints member variables to the log. This is just added because many examples contain member variables that are not used but exist only to demonstrate something. The dummy method is put into these scripts to ensure the project builds with no warnings for unused variables.