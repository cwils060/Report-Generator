# Project Outline
For this assignment, you will submit a high-level outline of your project. This can, and likely will, change over time. In particular, your mentor will provide direction and feedback to help sharpen your ideas. So don't worry if you feel unsure about some aspects of the outline or if you have to change some things later.

## Assignment Description
[Project Outline Assignment](https://education.launchcode.org/liftoff/modules/assignments/project-outline)

## Submission Instructions

### Overview
Before I came to Philadelphia, I used to do third-party compliance audits of legal cannabis facilities in Las Vegas.
Each time I walked through a client's facility, I would have to spend a few hours afterwards writing up a report
with the appropriate citations, potential fines, and recommendations for resolution. When I got the home inspection
on my last house done, I noticed the inspector was using a program that allowed him to pull up building codes using
a common search term, generate the template for his usual recommendation for issues surrounding that item and cost estimates, add
the pictures he was taking with his mobile device, and create the entire report on the fly. I want to create the same
thing for cannabis auditors, and I want to create it with a focus on scalability and intuitive user experience.

### Features

- User login: Users will be able to create accounts and log in to the application. Each user will have a profile
page. Future goal: Companies can white-label their "portal", and all employees of that company will see the same
branding when they log in
- Base template: Users can create a custom base template by inputting information that will auto-populate in the introductory and
closing paragraphs like inspection date, facility type, client name, etc.
- Search: Users will be able to search for state or local regulations containing the given text. Future goal: app
supports regulatory searches for multiple states
- Relational database: Within state code, there are levels of civil penalties for infractions that involve both regulatory
penalties (license suspensions, etc) and fines. When users select the a regulation a client is in violation of, the associated penalties
will automatically be tracked and totalled in the closing paragraphs.
- Create Report: Users will be able to generate a Word document that contains the created report - this will allow for easy
minor edits to be make to the template when needed and allow for export of the final version to PDF.
- Future goal - Add images: Users will be able to insert images into their reports

### Technologies

- C#
- JavaScript
- .NET MVC
- MySQL

### What I'll Have to Learn
- Formatting the input so that the search function and relational database works as intended
- Taking the template and exporting to a formatted Word document

### Project Tracker
https://trello.com/b/pjucOadS/liftoff-project

