FROM mcr.microsoft.com/dotnet/core/sdk:latest
MAINTAINER michael.dez@gmail.com

WORKDIR /ITSY
# install entity framework cli tools and add bin location to path
RUN dotnet tool install --global dotnet-ef --version 3.0.0 
RUN export PATH="$PATH:/root/.dotnet/tools" 


EXPOSE 5000-5001
ENTRYPOINT ["dotnet","watch","-p","./ITSY","run","--urls","http://0.0.0.0:5000"]
