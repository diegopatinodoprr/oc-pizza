 #!/bin/bash
echo stop all containers 
docker stop $(docker ps -a -q) 
echo build images
