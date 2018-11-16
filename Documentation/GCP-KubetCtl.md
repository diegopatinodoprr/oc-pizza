## genrerer les images Docker
    cd docker-traefik-ocelot
    docker-compose -f docker-compose-services.yml -f DockerCompose/docker-compose-build.yml  build
## pusher les images 
d'abord le tager avec 
```sh
docker tag recipes eu.gcr.io/notes-10000/recipes:latest
``` 
ensuite les pusher :
```sh
docker push eu.gcr.io/notes-10000/recipes:latest
```
## Liens

- Tutoriaux pour démarrer avec kubernetes
  - https://kubernetes.io/docs/tutorials/stateless-application/hello-minikube/
  - https://docs.microsoft.com/fr-fr/azure/aks/tutorial-kubernetes-prepare-app (tutorial azure)
- La doc avancée de Kubernetes : https://kubernetes.io/docs/concepts/
- Guide d'installation de google cloud sdk : https://cloud.google.com/sdk/downloads?hl=fr
- Blue / Green deployment : https://www.ianlewis.org/en/bluegreen-deployments-kubernetes
- Continuous deployment (exemple de google) : https://github.com/GoogleCloudPlatform/continuous-deployment-on-kubernetes.git

## Configuration de gcloud pour le poste local

Le plus simple est d'installer la ligne de commande gcloud sur le poste :

- Installer le client gcloud en suivant la procédure https://cloud.google.com/sdk/install
- Lors de l'installation, utiliser le compte **********@gmail.com ou votre compte gmail
- Une fois l'installation terminée, installer kubectl (il sera configuré sur notre cluster par défaut) : 
```sh
gcloud components install kubectl
```
## Configuration de gcloud pour l'outillage

Le compte utilisé pour manipuler le cluster kubernetes est le compte `9405950534-compute@developer.gserviceaccount.com` (c'est un service account, vous ne pouvez pas vous connecter à la console google avec)

1. Copier la clé du compte devops (fichier .secret  sur un répertoire local
1. Jouer les commandes suivantes :

```sh
gcloud auth activate-service-account 9405950534-compute@developer.gserviceaccount.com --key-file "chemin/vers/secret"
gcloud config set account 9405950534-compute@developer.gserviceaccount.com
gcloud config set project notes-10000
gcloud config set compute/zone europe-west1-b
```

## Se connceter à un container depuis la console kubernetes

Par exemple démarrer un bash en mode intéractif :

```sh
gcloud container clusters get-credentials notes --zone europe-west1-b --project notes (pour récupérer les credentials)
kubectl exec -it mysql-deployment-6fbdb8899f-44rld --namespace dev -- bash
```
Configurer kubectl pour pointer sur le cluster du backend de l'app :

`gcloud container clusters get-credentials notes`

# définir le context pour pointer notre cluster
```sh
gcloud container clusters get-credentials notes
```
# afficher les informations du cluster actif
```sh
kubectl cluster-info
```
# définir un namespace par défaut (évite les --namespace)
```sh
kubectl config set-context $(kubectl config current-context) --namespace=dev
```
# appliquer un fichier
```sh
kubectl apply -f cloud/unfichier.yaml
```
# watcher une ressource
```sh
kubectl get pods --watchdocker ps
kubectl get deployments --watch
kubectl get services --watch
```
# décrire une ressource
```sh
kubectl describe pods/podabcd
```
# supprimer une resource
```sh
kubectl delete pods/podabcd
```
# ouvrir un bash sur un pod distant
```sh
kubectl exec -it mysql-deployment-*********** bash
```