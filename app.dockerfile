FROM microsoft/dotnet:2.2-sdk
COPY . /app
WORKDIR /app

RUN apt-get update && apt-get install -y mysql-client

RUN ["dotnet", "restore"]
RUN ["dotnet", "build"]
EXPOSE 80/tcp
RUN chmod +x ./entrypoint.sh 
CMD /bin/bash ./entrypoint.sh database:3306