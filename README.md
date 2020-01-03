# C#-SOAP (Calculator WSDL)

## Biography  
**Authors:**
Jordi Jaspers [[Github](https://github.com/Jordi-Jaspers "Github Page"), [Linkedin](https://www.linkedin.com/in/jordi-jaspers/ "Linkedin Page")] 
  
**Date of initial commit:** 
14/11/2019  

**Description:**
This is a 3-part project consisting of a REST & SOAP service made from different coding languages. This excercise is trying to give us knowledge about different methods of building a cloud-service. Part 3 is about requesting WSDL-services for information via C# and implemting it on a website. The main objective is to host every created service on a Docker-container.. In this part of the project got in touch with HTML, CSS and C#.  

**Docker(windows)**
run the 2 services in windows via the next commands

```
cd <Location dockerfile service>
docker build -t wcf-iis-service .
docker run -d -p 83:83 --name wcf wcf-iis-service

cd <Location dockerfile calculator>
docker build -t wcf-iis-calculator .
docker run -d -p 89:89 --name wcf_calc wcf-iis-calculator
```

**Deployed via AWS-toolkit in visual Studio**
Right click solution explorer and publish to AWS. After publishing you'll get a link to connect to you environment.

<http://calculatorservice-dev.eu-west-2.elasticbeanstalk.com/>

## What We Learned
 * Command-line programming
 *  XAMPP DataBases
 * Virtual Enironments in python
 * Python REST API with FLASK
 * Use of RapidAPI 
 * HTML, CSS and PHP development
 * Laravel Web development with Blade
 * Docker to host the webapplication
 * Javascript Basics
 * Authentications and roles
 * Mysql database connecting and hosting
 * Different new python methods and imports
 * Troubleshoot with docker containers and SQLAlchemy
 * Basic C# for SOAP service
 * XML to describe the WSDL files
 * Deploying in Windows VS studio
 * ...
  
## TODO-List:  
#### Part 1:  Laravel (BasicWebsite)
-   Build a basic central webapp in Laravel -> done
-   Use Authentication -> done
-   Use all the right redirects -> done!
-   Make a database consisting of users and messages -> done!
-   Make the website Dynamic for all users -> done!
-   Connect Laravel to Docker with all the right containers needed -> done!
-   Use a good Mark-up CSS Text-code -> done!
-   Create a redirect for the ADMIN_ONLY to see the messages. -> done!
-   ...

#### Part 2:  Python-REST (Currencyexchanger)
-   Build a REST-Service with PYTHON -> done!
-   Create own Mysql Database with all the currencies and countries -> done!
-   Create a different selection form connected to this database! -> done!
-   Use an conversion API from RapidAPI's -> done!
-   Use a good Mark-up CSS Text-code -> done!
-   Connect Python service to Laravel -> done!
-   Connect Databases via Docker -> done!
- ...

#### Part 3:  C#-SOAP (Calculator WSDL)
-   Used service as Insperation: <http://www.dneonline.com/calculator.asmx?wsdl>
-   Created own C# calculator services -> done!
-   Consumed in C3 webservice as test -> done!
-   Consuming the service in a Java project (Bonuspoints: Use Other service) -> not yet!
-   Dockerize the part 3 (Bonuspoint: everything Consistent in Docker) -> Done!
-   Deploy everything in AWS Services -> done!

## Troubleshooting:   
-   Can't connect different databases through docker for other services like python-RESTFULL... --> change host from "127.0.0.1" to match the container name of the database

**To Connect to the Localhost on the windows machine:**
```
Ipconfig

Ethernet adapter Ethernet:

    Connection-specific DNS Suffix  . : localdomain
    IPv6 Address. . . . . . . . . . . : 
    Temporary IPv6 Address. . . . . . : 
    Link-local IPv6 Address . . . . . : 
    IPv4 Address. . . . . . . . . . . : USE THIS IP-ADRESS
    Subnet Mask . . . . . . . . . . . : 
    Default Gateway . . . . . . . . . : 
```
Then your URL will be <http://YOUR_GATEWAY_IP:PORT/APPLICATION>

## Project Information (Dutch):  
1. Service Oriented Applicatie bouwen
    - Services bouwen
        * REST    
            Laravel
            Python – Flask RESTful
        * SOAP
            C#

2. Services kunnen gebruiken
    - intern: van elke categorie een: van jezelf of een teamgenoot.
    - extern: te vinden op o.a. programmableweb.com of https://rapidapi.com/collection/social-media-apis

3. Integratie
    - Laravel
    - Gelaagd en/of gecombineerd
    - Verhoogde interactie met Javascript

3. Authenticatie

4. Cloud-gebaseerde hosting
    - Docker (op Marcel)
    - Commerciële provider: Azure, AWS, Google, …

## Grading of  the project (Dutch) :  
The grading system will be writen in dutch, because it is a copy-paste of the given file for this course.

| Project CLOUD Computing (33,33%)                                                            |     /20     | 
| ------------------------------------------------------------------------------|:----------:|
|centrale webapp in Laravel                                                             |         2       |
|Integratie van Javascript in centrale webapp                                   |           2     |
|eigen REST-service maken in Laravel & documenteren                                   |       2         |
|eigen REST-service maken in Python & documenteren                                   |        3        |
|eigen SOAP-service maken in C#                                   |         3       |
|                                                                                            |                |
|eigen services oproepen                                                                    |          2      |
|externe service (bv. programmable web of rapid api) oproepen       |           2     |
|                                   |                |
|authenticatie/authorisatie                                   |          2      |
|                                   |                |
|Minstens 1 service ‘conceptueel’ via docker                                   |           2     |
|                                   |                |
|**Bonuspunten**                                   |                |
|extra service in andere programmeertaal (Node.JS, Java, ...)                       |        2        |
|consistent alles in docker                                   |        2        |
|                                   |                |
|**Strafpunten**                               |                |
|geen database in service van Python én C#                                   |       3.5         |
|niet deployen op Azure/Amazon                                   |       5         |
|geen SOAP-service oproepen                                   |          2      |

## References:  
 * POSTGREPL: <https://www.codementor.io/engineerapart/getting-started-with-postgresql-on-mac-osx-are8jcopb>
 * Python REST: <https://www.codementor.io/dongido/how-to-build-restful-apis-with-python-and-flask-fh5x7zjrx>
 * Python REST: <https://www.youtube.com/channel/UCK8YsKv4-N6ItZfzEyKlI6A>
 * microservices: <https://www.youtube.com/watch?v=PY9xSykods4>
 * SOA vs microservices: <https://www.youtube.com/watch?v=EpyPFnjue38>
 * REST vs SOAP: <https://www.youtube.com/watch?v=bPNfu0IZhoE>
 * REST API Examples: <https://www.youtube.com/watch?v=7YcW25PHnAA>
 * Docker vs Laravel: <https://laradock.io/documentation/>
 * Everything about Laravel: <https://laravel.com/docs/5.7/verification>
 * Deploying WCF: <https://www.chriswirz.com/software/wcf-docker-service>
 * Laradock on AWS: <https://github.com/laradock/laradock/issues/244>
 * Create SOAP Services: <https://www.youtube.com/watch?v=uBwHedD5xx0&t=437s>
 * NETCore & mac: <https://www.codeproject.com/Articles/1223518/ASP-NET-Core-2-0-and-Docker-on-MacOS>
 * Windows Server on AWS: <https://www.youtube.com/watch?v=5FepK5pV39c>
 * Accessing localhost on VM: <https://medium.com/@urubuz/accessing-localhost-in-mac-from-windows-vm-in-virtualbox-312a3de6fedb>
 * Troubleshooting: <https://stackoverflow.com/>
 * Create AWS instance: <https://www.clickittech.com/aws/create-amazon-ec2-instance/>
 * Connect SSH instance: <https://eu-west-2.console.aws.amazon.com/ec2/v2/home?region=eu-west-2#Instances:sort=instanceId>
 * Deploy via EC2: <https://dzone.com/articles/how-to-deploy-laravel-application-on-aws-ec2-the-r>
 * EBS tutorial: <https://medium.com/faun/deploy-a-docker-ized-laravel-application-to-aws-ecs-with-codebuild-4b0e388f4f53>
 * Multicontainer docker on AWS: <https://docs.aws.amazon.com/elasticbeanstalk/latest/dg/php-laravel-tutorial.html>