# SQLViewer
## Context
Project of the subject of Accessing Data From Program Code of the Software Engineering degree at Algebra University College (Zagreb). The project consist in a  replica of the SSMS (SQL Server Management Studio).
The project is completely done in C# with the Form Window framework. Part of the code is done with the help of the Professor Daniel Bele.
## Functionality
### Login
The application has a SQL Server Authentication in order to use it. So it handle non registered users and so on.
<img width="256" alt="image" src="https://github.com/MrCharlesSG/SQLViewer/assets/94635721/dd291694-98ad-4d95-a978-fd6baebfefa9">
### Main Window
Once the user has been aunthenticated so username and passwords are correct, then main screen will show:
  - On the top three buttons:
      - The first one is to see the content of the selected table or view.
      - The second one is to save the selected table in an XML file.
      - The third and last is to run a new query.
  - On the left side there is a tree view of the tables, views and procedures in the Data Base.
  - On the right side there is a text box where the procedures's code will be shown.
<img width="693" alt="image" src="https://github.com/MrCharlesSG/SQLViewer/assets/94635721/ce88cfc8-da58-40c8-a97e-7c1a1d9ade23">
### Run Table
When the run button is clicked, automaticaly, the content of the selected table or view will be shown.
<img width="694" alt="image" src="https://github.com/MrCharlesSG/SQLViewer/assets/94635721/42fb348c-b3f4-4c2b-a76e-96aafe4c9453">
### Save
When the save button is clicked, the user will have the option to choose where to save the table or view in a XML format.
<img width="611" alt="image" src="https://github.com/MrCharlesSG/SQLViewer/assets/94635721/f5c4ff61-98c1-47ae-8c58-0ffa23003967">
This is how the XML file will look like:
<img width="801" alt="image" src="https://github.com/MrCharlesSG/SQLViewer/assets/94635721/25445ac3-9409-4239-8c55-1c74cf6087d6">


## Patterns
The patterns used in this project are:
### Lazy
In orther
