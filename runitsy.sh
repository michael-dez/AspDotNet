#!/bin/bash
# run .netcore container in interactive mode with app folder mounted to project folder 
docker run -it  \
 -v $PWD/ITSY/:/ITSY \
 -p 5000:5000 \
 --entrypoint "/bin/bash" \
itsy:latest \



