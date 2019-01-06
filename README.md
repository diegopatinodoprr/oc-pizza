# Project Notes

  

## Description

  

Ce project a comme objecticf, de mettre en practique le deployement d'un application web , utilisant les technologie, docker,nodejs, kubernetes.
Les webservice sont developes en C#, 

Le front-end sera develope en javascript avec angular JS.

La base de donne sera mysql 5.7.

# Deployement

## Images Docker


Demarrer une console bash;
Se placer au niveau du repertoire Application.
Lancer la commande :

    ./build.sh 
   ceci aura pour effet la génération des images docker nécessaires au fonctionnement de l'application. la documentation concernant la generation des images docker est [ici](/Documentation/Docker-Images.md) :


 - Meats
 - Recipes
 - GlobalDatabase

Une  fois la generation des images ternimé. 
avec la commande 

    `./run.sh`
 vous pouvez demarrer l'application en local.

 L'url d'acces sera [http://demo.localhost.tv/](http://demo.localhost.tv/)
 
 cette adresse est celle correspondant a l'interface graphique.

 L'address [http://demo.localhost.tv//meats](http://demo.localhost.tv//meats) donne acces a l'api Meats
  
L'address [http://demo.localhost.tv//recipes](http://demo.localhost.tv//meats) donne acces a l'api  Recipes
	   

