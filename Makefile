restart:
	docker-compose -f ./Docker/docker-compose.yml down
	docker-compose -f ./Docker/docker-compose.yml up -d --build
	
down:
	docker-compose -f ./Docker/docker-compose.yml down -v

stop:
	docker-compose -f ./Docker/docker-compose.yml down

run:
	docker-compose -f ./Docker/docker-compose.yml up -d --build
	
goToDB:
	docker-compose -f ./Docker/docker-compose.yml exec database bash

goToApp:
	docker-compose -f ./Docker/docker-compose.yml exec app bash
	
startApp: 
	docker-compose -f ./Docker/docker-compose.yml up -d --build application
	
startDB:
	docker-compose -f ./Docker/docker-compose.yml up -d --build database
	
db_logs:
	docker logs $(docker ps -qa --filter name=parking_now_db)

app_logs:
	docker logs $(docker ps -qa --filter name=parking_now_app)

