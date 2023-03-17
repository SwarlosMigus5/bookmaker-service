<h1 align="center"> Bookmaker Integration </h1> <br>

<p align="center">
  This microservice is responsible for storing all the information about the bookmakers available in our platform.
</p>

## Table of Contents

- [Domain](#introduction)
- [Features](#features)
- [Requirements](#requirements)
- [Quick Start](#quick-start)

## Domain

![Domain](https://github.com/skullizador/bookmaker-service/blob/main/resources/domain.png)

## Features

* Create new bookmaker :heavy_check_mark:
* Delete bookmaker :heavy_check_mark:
* Get bookmaker information :heavy_check_mark:
* Update bookmaker :heavy_check_mark:
* Get all bookmakers :heavy_check_mark:

## Requirements
The application can be run locally or in a docker container, the requirements for each setup are listed below.

### Docker
* [Docker](https://www.docker.com/get-docker)

## Quick Start 
### Run Docker

First build the image:
```bash
$ docker build . -t bookmaker-service:{tag}
```

When ready, run it:
```bash
$ docker run -p {port:port} bookmaker-service:{tag}
```

Application will run by default on port `5000`