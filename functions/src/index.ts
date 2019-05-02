import * as functions from 'firebase-functions';
var grpc = require('grpc');
var protoDescriptor = grpc.load('./bim.proto');
 // Start writing Firebase Functions
 // https://firebase.google.com/docs/functions/typescript

export const helloWorld = functions.https.onRequest((request, response) => {
    var client = new protoDescriptor.Mega.Bim.Items('45.63.6.225:50051', grpc.credentials.createInsecure());
    let call = client.sendItems((error, result) => console.log(error, result))
    call.write({ id: "1", family: "wall", category: "brick wall" })
    call.write({ id: "2", family: "wall", category: "dry wall" })
    call.end()
    response.send("sent")
});
