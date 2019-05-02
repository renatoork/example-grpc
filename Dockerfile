FROM node

ADD ./grpc-node/index.js /app/grpc-node/index.js
ADD ./grpc-node/package.json /app/grpc-node/package.json
ADD ./grpc-node/package-lock.json /app/grpc-node/package-lock.json
ADD ./proto /app/proto
WORKDIR /app/grpc-node
RUN npm install
EXPOSE 50051
CMD [ "node", "index.js" ]