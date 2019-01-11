*# Project Notes

  

  

## Description
Ce Project a comme objectif, de démontrer mes capacités a développer,documenter et déployer une application web.
![Functionement global du site](https://drive.google.com/file/d/12ZU5vHpYEcoRUhP-DBm8E8JeNFDsvSPm/view?usp=sharing)

  

# Prerequisites
- Notions de systèmes déploies en micro-services.
- Notions du fonctionnement de serveurs web. 
- Notions serveur des bases de donnes.
- Configuration des serveur proxy.

  
### Environements
 - Linux ( Docker, Docker-compose)
 - Windows (Visual Studio)
### Languages de Programation  
 - Javacsript
 - C#
 - Uml
 - SQL
 - Yaml
 - json
### Technologies
	- .Netcore
	- NodeJs
	- Docker && Docker-compose
	- Traefik
	- Swagger
#  Conception
 - Les web-service sont developes en C#,
  - L'application web est developpée en javascript avec le framework angular JS, cette application est déployée sur un serveur nodejs.
   - La base de donne est deploye sur mysql 5.7. aucun schema de base de donnes est déclare ,car les microservices sont responsables de leur prope configuration dans la base de donnes.

  

# Deployement  

## Images Docker 
  

 1. Demarrer une console bash; 
 2. Se placer au niveau du répertoire ./Application. Lancer la commande : 

  

    
   

`     ./build.sh`
       

ceci aura pour effet la génération des images docker nécessaires au fonctionnement de l'application. la documentation concernant la generation des images docker est [ici](/Documentation/Docker-Images.md) :

  
  

- Meats

- Recipes

- GlobalDatabase

  

Une fois la generation des images ternimé.

avec la commande

  

`./run.sh`

vous pouvez demarrer l'application en local.

  

L'url d'acces sera [http://localhost/](http://localhost/)

cette adresse est celle correspondant a l'interface graphique.

  

L'address [http://localhost//meats](http://localhost//meats) donne acces a l'api Meats

L'address [http://localhost//recipes](http://localhost//meats) donne acces a l'api Recipes*
