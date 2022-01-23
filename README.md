# ITSY
ITSY is an **I**ssue **T**racking **Sy**stem made by myself and [keajoj](https://github.com/keajoj) in 2020 for us to learn C#/ASP.NET. I also took the opportunity to learn more about containers and Docker. Functionality includes:

* issue severity
* issue description
* unique identifier provided after issue creation

Originally the project was hosted on an EC2 instance with docker-compose launching containers for:
* Kestrel: Application Server
* NGINX: Reverse Proxy
* Certbot: SSL Certificate Renewal
* PostGres: Database

I'm planning on moving some personal projects over to Kubernetes and am hoping this can bring some life back to the project.
