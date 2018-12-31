# Project Notes

  

## Description

  

Ce project a comm eobjecticf, de mettre en practique le deployement d'un application web , utilisant les technologie, docker, kubernates.
Les webservice sont developes en C#, le front-end sera develope en javascript avec angular JS.
La base de donne se mysql 5.7.

  

# Deployement

## Images Docker

  

Demarrer une console bash;
Se placer au niveau du repertoire Application.
Lancer la commande :

    ./build.sh 
   ceci aura pour effet la génération des images docker nécessaires au fonctionnement de l'application :
	

 - Meats 	
 - Recipes 	
 - GlobalDatabase

Une  fois la generation des images ternimé. 
avec la commande 

    `./run.sh`
 vous pouvez demarrer l'application en local
 L'url d'acces sera [http://localhost:8180](http://locahost:8180) ; cetee adresse est celle correspondant a l'interface d'infrastructure généré par Traefik.
 ensuite [http://localhost:81/meats](http://localhost:81/meats) donne acces a l'api pour Meats
  ensuite [http://localhost:81/recipes](http://localhost:81/meats) donne acces a l'api pour Recipes
	   

