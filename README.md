# _Animal Shelter API_

#### By _**Kayla Weaver**_

## Description

An API project that allows users to Create, Read, Update, and Delete animals and lists the available animals at the shelter.

## Specifications user stories

1. A user is able to GET (read) a list of animals.
2. A user is able to GET a specific animal information based on AnimalId.
3. A user is able to GET animals by species, age or name.
4. A user is able to POST (create) a new animal in the database.
5. A user is able to PUT (update) an existing animal information in the database.
6. A user is able to DELETE an existing animal information in the database.

## API Endpoints

#### Request
`GET api/animalshelter/`

EXAMPLE URL: http://localhost:5000/api/animalshelter/

#### Response
    [  
      {
        AnimalId = 1,
        Name = "Abby",
        Age = 7,
        Species = "Dog",
        About = "Insane in the membrane and loves long walks off shor docks"
      },
      new Animal
      {
        AnimalId = 2,
        Name = "Bella",
        Age = 11,
        Species = "Dog",
        About = "Sweet girl can never play enough fetch"
      },
      new Animal
      {
        AnimalId = 3,
        Name = "Lemon",
        Age = 5,
        Species = "Kitty",
        About = "Will keep your home safe from rats and birds"
      }
    ]

### 2. Get a specific Animal
#### Request
`GET api/animalshelter/{id}`

EXAMPLE URL: http://localhost:5000/api/animalshelter/1

   #### Response 
    {
      AnimalId = 1,
      Name = "Abby",
      Age = 7,
      Species = "Dog",
      About = "Insane in the membrane and loves long walks off shordocks"
    }


### 3. GET animals by species, name or age 
#### Request
`GET /api/animalshelter/?[PARAMETER_NAME]=[PARAMETER_VALUE]&[PARAMETER_NAME]=[PARAMETER_VALUE]`

EXAMPLE_URL: http://localhost:5000/api/animals?species=kitty&age=5&name=lemon

#### Response
    {
      AnimalId = 3,
      Name = "Lemon",
      Age = 5,
      Species = "Kitty",
      About = "Will keep your home safe from rats and birds"
    }

### 4. Create a new Animal

#### Request

`POST /api/animalshelter/`

EXAMPLE URL: http://localhost:5000/api/animalshelter

#### Example Request body
    {  
      Name = "Sid", //optional
      Species = "Sloth", //optional
      Age = 2, //optional
      About = " just a silly goose trying to survive the end of the world as we know it " //optional
    }


### 5. Edit an Animal's information

#### Request

`PUT /api/animalshelter/{id}`

EXAMPLE URL: http://localhost:5000/api/animalshelter/4

#### Example Request Body
    { 
      AnimalId = 4, // value must match id value provided in URL
      Name = "Sid", //optional
      Species = "Sloth", //optional
      Age = 2, //optional
      About = " looking for my friends have you seen them " //optional
    }

### 6. Delete an Animal

#### Request

`DELETE /api/animalshelter/{id}`

EXAMPLE URL: http://localhost:5000/api/animalshelter/3

#### Response

    Status: 200 OK
    
### 7. Get a non-existent Animal

#### Request

`GET /animals/id`

   http://localhost:5000/api/animalshelter/

#### Response

    Status: 204 No Content


## Setup/Installation Requirements

### Install .NET Core

* Download the .NET Core SDK [Software Development Kit](https://dotnet.microsoft.com/download)
* Open the .Net Core SDK file and install
* To confirm installation was successful, run the ```$ dotnet --version``` command in your terminal

### Install MySQL Community Server and MySQL Workbench

#### on macOS:
_Download the MySQL Community Server DMG File [MySQL Community Server page](https://dev.mysql.com/downloads/file/?id=484914). 
* Follow along with the installer until you reach the configuration page. Once you've reached Configuration, set the following options (or user default if not specified):_
      * use legacy password encryption
      * set password 
      * click finish
* Verify MySQL installation by opening Terminal and entering the command ``mysql -uroot -p{your password here}``.  
  You can exit the mysql program by entering exit.

_Download MySQL Workbench DMG file [ MySQL Workbench page](https://dev.mysql.com/downloads/file/?id=484391). 
* Install MySQL Workbench to Applications folder. 
* Open MySQL Workbench and select Local instance 3306 server, then enter the password you set. If it connects, you're good to go._

#### on Windows:
_Download the MySQL Web Installer [MySQL Web Installer ](https://dev.mysql.com/downloads/file/?id=484919) 
* Choose Custom setup type
* When prompted to Select Products and Features, choose the following: 
    * MySQL Server (Will be under MySQL Servers) 
    * MySQL Workbench (Will be under Applications)
* Select Next, then Execute. Wait for download and installation 
* Advance through Configuration as follows:
  - High Availability set to Standalone.
  - Defaults are OK under Type and Networking.
  - Authentication Method set to Use Legacy Authentication Method.
  - Set password to epicodus. You can use your own if you want but epicodus will be assumed in the lessons.
  - Unselect Configure MySQL Server as a Windows Service.
* Complete installation process

_Add the MySQL environment variable to the System PATH. Instructions for Windows 10:_
* Open the Control Panel and visit _System > Advanced System Settings > Environment Variables..._
* Select _PATH..._, click _Edit..._, then _Add_.
* Add the exact location of your MySQL installation and click _OK_. (This location is likely C:\Program Files\MySQL\MySQL Server 8.0\bin, but may differ depending on your specific installation.)
* Verify installation by opening Windows PowerShell and entering the command ``mysql -uroot -p{your password here}``. It's working correctly if you gain access to the MySQL command line. 
  You can exit the mysql program by entering `exit`

### Download this repository

_Download Manually:_

* Navigate to https://github.com/kayla-weaver/AnimalShelterApi
* Click the green "Clone or Download" button.
* Click "Download ZIP".
* Click downloaded file to unzip.
* Open folder (AnimalShelterAPI.solution).

_In Terminal:_

* Navigate to where you want this application to be saved, i.e.:
  ```
  cd desktop
  ```
* Clone the file from GitHub with HTTPS
  ```
  git clone https://github.com/kayla-weaver/AnimalShelterApi
  ```
* Open file in your preferred text editor
  ```
  cd AnimalShelterApi.Solution
    ```
* Change directories into the project directory
  ``` 
  cd AnimalShelter.Solution/AnimalShelterApi
   ```

* Restore all dependencies
  ```
   dotnet restore
   ```
* Build the project and dependencies
   ```
   dotnet build

## Create the Database

* Build the database
  ```
  dotnet ef database update
  ```

_To run this application:_


* Run the program
  ``` 
  dotnet run
  ```
   Note: To exit, simply press ```Ctrl + C```

* Visit [swagger documentation:](https://localhost:5001/swagger/index.html) to see API running or visit `http://localhost:5000/api/animalshelter/` in Postman.
   ## Known Bugs

_No known bugs._


## Technologies Used

* C#
* .Net Core 2.2
* ASP.NET Core MVC
* MySQL, MySQL Workbench
* Entity Framework Core 2.2
* Newtonsoft.Json 


### License

[MIT](https://choosealicense.com/licenses/mit/)

Copyright (c) 2023 **_Kayla Weaver_**