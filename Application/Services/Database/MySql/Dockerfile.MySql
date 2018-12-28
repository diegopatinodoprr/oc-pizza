FROM mysql:5.7
ENV MYSQL_ROOT_PASSWORD=ElTiempCambia

WORKDIR /src
COPY Services/Database/MySql/0-init-users.sql /docker-entrypoint-initdb.d
COPY Services/Meats/MeatsDbSetup.sql /docker-entrypoint-initdb.d
COPY Services/Recipes/RecipesDbSetup.sql /docker-entrypoint-initdb.d
