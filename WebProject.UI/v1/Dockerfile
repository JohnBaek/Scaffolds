FROM node:lts-alpine as build-stage
WORKDIR /app
ADD . .
RUN yarn install
RUN yarn run build

# production stage
FROM node:lts-alpine as production-stage
COPY --from=build-stage /app/dist /app/dist
WORKDIR /app
RUN npm install -g serve
EXPOSE 4000
CMD ["serve", "-s", "dist" ,"-l" , "4000"]