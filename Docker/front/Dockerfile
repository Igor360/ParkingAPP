# build environment
FROM node:12.2.0-alpine as build

COPY ./Front/app /app
WORKDIR /app

ENV PATH /app/node_modules/.bin:$PATH
RUN npm install --silent
RUN npm run build

# production environment
FROM nginx:1.16.0-alpine
COPY --from=build /app/dist /usr/share/nginx/html
RUN rm /etc/nginx/conf.d/default.conf
COPY  ./Docker/nginx/nginx.conf /etc/nginx/conf.d
EXPOSE 8080
CMD ["nginx", "-g", "daemon off;"]
