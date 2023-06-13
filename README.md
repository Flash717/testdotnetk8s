# Test dotnet core GRPC and WebAPI

Purpose of this repo is to test out the following:

- [x] Dotnet core GRPC
- [x] Dotnet core WebAPI
- [x] Docker
- [ ] Kubernetes

The projects in this repo have been built with dotnet framework v8-preview.

## TestApi project

Created with 
```
dotnet new -webApi -n TestApi`
```

Build container
```
docker build -t testapi .
```

Run container locally
```
docker run -d -p 5000:8080 testapi
```

## TestGrpc project

Created with
```
dotnet new grpc -n TestGrpc
```

Build container
```
docker build -t testgrpc .
```

Run container locally
```
docker run -d -p 5001:8080 testgrpc
```