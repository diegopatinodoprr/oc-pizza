 #!/bin/bash
echo stop all containers 
docker stop $(docker ps -a -q) 
echo build images
docker-compose -f docker-compose-services.yml -f DockerCompose/docker-compose-build.yml build