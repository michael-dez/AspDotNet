#! /bin/bash
# create dotnet docker build image
docker build -t itsy:latest \
--file /home/$USER/asp/dockerfile .
