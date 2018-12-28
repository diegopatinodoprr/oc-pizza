 #!/bin/bash
 docker-compose -f docker-compose-services.yml -f DockerCompose/docker-compose-build.yml -f DockerCompose/docker-compose.serverbase.yml -f DockerCompose/env/docker-compose.dev.yml up 