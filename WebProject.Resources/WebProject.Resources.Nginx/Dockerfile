#Dockerfile
FROM nginx:latest

COPY config/default.conf /etc/nginx/conf.d/
RUN apt-get update -y
RUN apt-get install -y net-tools
RUN apt install iputils-ping -y
RUN apt install curl -y 

CMD ["nginx", "-g", "daemon off;"]

EXPOSE 80