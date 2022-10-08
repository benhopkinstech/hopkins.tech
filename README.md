# hopkins.tech

This is my over engineered personal website

## Getting Started

- Ensure Docker Desktop is installed and running
- Clone the repository and open the project in Visual Studio
- Right-click `docker-compose` and set as startup project
- Simply click start!

## Running with Kubernetes

- Ensure Kubernetes is installed and running through Docker Desktop
- Open a command line and cd into the Server folder
- Enter the command `kubectl apply -f deployment.yml`
- This will create the deployment and service, run `kubectl get all` to check it is running
- Go to `http://localhost` and you will see a local copy of the latest version

## Deploying with Kubernetes

- Ensure Kubernetes is installed and running through Docker Desktop
- Ensure any previous containers related to hopkinstech have been deleted
- Open a command line and cd into the root folder
- Enter the command `docker-compose up`
- Go to `https://localhost:3000` to check the site is running
- Press Ctrl+C to shut down and enter the command `docker-compose down`
- Ensure you are logged in to Docker Hub
- Enter the command `docker tag hopkinstech:latest {dockerhubuser}/hopkinstech:latest`
- Enter the command `docker push {dockerhubuser}/hopkinstech:latest`
- Edit the `deployment.yml` image section to `{dockerhubuser}/hopkinstech:latest`
- On the command line cd into the Server folder and type `kubectl apply -f deployment.yml`
- This will create the deployment and service, run `kubectl get all` to check it is running
- Go to `http://localhost` and you will see a local copy of the image you just pushed
