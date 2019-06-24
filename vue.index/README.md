docker build:
```
    docker build -t sea/seablog.vue:v1.0 .
```

docker run
```
    docker run --name seablog.vue -p 1337:80 -d sea/seablog.vue:v1.0
```