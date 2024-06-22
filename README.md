# isaac-castorena-repo
Repository with the stories solution

RUN THE APLICATION
To run the application you need to access the repository: https://github.com/BitCoconot/isaac-castorena-repo.git

Clone the repository using Visual Studio, or Git commands
Using Visual Studio:
Navigate to Git Changes tab in the Solution Explorer section
 - Click, clone Repository
 - Type the repository name: https://github.com/BitCoconot/isaac-castorena-repo.git
 - Click Clone
 - After cloning the solution will open
 - Then Click on Run button, the preference to Run is https.
	NOTE: if ISS is selected make sure the certificate is installed, the certificated should be installed, normally VS ask to enable the use of the certificate 

Using Git Bash
- Open Git Bash console
- Locate the folder in which the repository will be located.
- type git clone https://github.com/BitCoconot/isaac-castorena-repo.git
- open Visual Studio.
- Open the solution: Stories.sln
- Then Click on Run button, the preference to Run is https.
	NOTE: if ISS is selected make sure the certificate is installed, the certificated should be installed, normally VS ask to enable the use of the certificate

Using Swagger
- After to the solution start, the Swagger page should be displayed.
- You can test the application just clicking the GET method 
- click try it out
- add the n parameter in the parameter section
- Click execute
- This should return the n best stories.

Using Postman,
- Run the Application using Visual Studio
- Open postman
- Select GET Method
- Type in the URL section : https://localhost:7110/api/stories/detail?n=2
	NOTE: The local host port number should be replace with the actual port show after to run the solution
- The n parameter should be updated according which number of stories you want to retrieve from the API.
- Then Click Send
	  -NOTE: if ISS is selected make sure the certificate is installed, the certificated should be installed, enable the use of the certificate in postman

Using Browser:
-Run the Application using Visual Studio
-type in the URL section : https://localhost:7110/api/stories/detail?n=2
- NOTE: The local host port number should be replace with the actual port show after to run the solution
-  The result will be displayed as a json object in the browser.

ASSUMPTIONS

The commentCount is not a field that is being returned by the API call, the example of the details of the API is the next: 

{
    "by": "ismaildonmez",
    "descendants": 588,
    "id": 21233041,
    "kids": [
        21233229,
        ...
    ],
    "score": 1757,
    "time": 1570887781,
    "title": "A uBlock Origin update was rejected from the Chrome Web Store",
    "type": "story",
    "url": "https://github.com/uBlockOrigin/uBlock-issues/issues/745"
}

In which there is not "commnetCount" Field.So that now the Comment count is just showing a null value.


The API should return an array of the best n stories as returned by the Hacker News API in descending order of score, in the form:
[
{
"title": "A uBlock Origin update was rejected from the Chrome Web Store",
"uri": "https://github.com/uBlockOrigin/uBlock-issues/issues/745",
"postedBy": "ismaildonmez",
"time": "2019-10-12T13:43:01+00:00",
"score": 1716,
"commentCount": 572
},
{ ... },
{ ... },
{ ... },
...
]
