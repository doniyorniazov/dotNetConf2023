# CI/CD Demo: Deploying Containerized .NET App to Azure App Service

This repository demonstrates the implementation of Continuous Integration (CI) and Continuous Deployment (CD) using GitHub Actions. The workflow is designed to build and deploy a containerized .NET application to Azure App Service.

## Table of Contents

- [Prerequisites](#prerequisites)
- [Getting Started](#getting-started)
  - [GitHub Actions Workflow](#github-actions-workflow)
  - [Azure Configuration](#azure-configuration)
- [Workflow Overview](#workflow-overview)
- [Folder Structure](#folder-structure)
- [Configuration Files](#configuration-files)
- [Customizing the Workflow](#customizing-the-workflow)
- [Troubleshooting](#troubleshooting)
- [Contributing](#contributing)
- [License](#license)

## Prerequisites

Before you begin, ensure you have the following prerequisites:

- GitHub account
- Azure subscription
- Docker installed on your local machine

## Getting Started

### GitHub Actions Workflow

The CI/CD workflow is defined in the [.github/workflows/main.yml](.github/workflows/main.yml) file. It consists of the following stages:

1. **Build**: Builds the .NET application and creates a Docker image.
2. **Test**: Runs any specified tests on the application.
3. **Deploy to Azure**: Deploys the Docker image to Azure App Service.

### Azure Configuration

For the deployment to Azure App Service, you need to set up the following secrets in your GitHub repository:

- `AZURE_WEBAPP_NAME`: Name of your Azure App Service.
- `AZURE_WEBAPP_CONTAINER_NAME`: Name of the container in Azure Container Registry.
- `AZURE_WEBAPP_PUBLISH_PROFILE`: Publish profile XML for your Azure App Service.

## Workflow Overview

The workflow is triggered on every push to the `main` branch. It can be customized to trigger on other events as needed. Once triggered, it performs the build and deployment steps, ensuring a seamless CI/CD pipeline.

## Folder Structure

- `src/`: Contains the source code of the .NET application.
- `docker/`: Includes Dockerfile for building the Docker image.
- `.github/workflows/`: Holds the GitHub Actions workflow definition.

## Configuration Files

- `.github/workflows/main.yml`: Defines the CI/CD workflow using GitHub Actions.
- `docker/Dockerfile`: Specifies the Docker image configuration.

## Customizing the Workflow

Feel free to customize the workflow to fit your specific requirements. You can modify the workflow file to include additional steps, adjust triggers, or integrate with other tools/services.

## Troubleshooting

If you encounter any issues during the CI/CD process, refer to the [Troubleshooting](docs/troubleshooting.md) guide for common problems and solutions.

## Contributing

Contributions are welcome! Please follow the [Contribution Guidelines](CONTRIBUTING.md) when submitting pull requests.

## License

This project is licensed under the [MIT License](LICENSE).
