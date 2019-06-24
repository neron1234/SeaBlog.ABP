docker build:
```
    docker build -t sea/seablog:v2.0 .
```

docker run
```
    docker run --name seablog.api --link=prostgres_dev:localhost -p 21021:80 -d sea/seablog:v2.0
```