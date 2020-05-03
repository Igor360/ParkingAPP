#!/bin/bash

host="$1"

#until mysql -h "$host" -u "root"  -p${MYSQL_ROOT_PASSWORD} -c '\q'; do
#  >&2 echo "Mysql is unavailable - sleeping"
#  sleep 1
#done

mysql -h "$host" -u root -p${MYSQL_ROOT_PASSWORD} -D ${MYSQL_DATABASE} -e 'CREATE TABLE `__EFMigrationsHistory` ( `MigrationId` nvarchar(150) NOT NULL, `ProductVersion` nvarchar(32) NOT NULL, PRIMARY KEY (`MigrationId`) );';

set -e
run_cmd="dotnet run --server.urls http://*:80"

until dotnet ef database update; do
>&2 echo "SQL Server is starting up"
sleep 1
done

>&2 echo "SQL Server is up - executing command"
exec $run_cmd