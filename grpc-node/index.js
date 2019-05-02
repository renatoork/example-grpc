var grpc = require('grpc');
var protoDescriptor = grpc.load('../proto/bim.proto');
const bim = protoDescriptor.Mega.Bim;
var request = require('request')

var admin = require("firebase-admin");
var serviceAccount = require("./adm.json");

admin.initializeApp({
    credential: admin.credential.cert(serviceAccount),
    databaseURL: "",
    storageBucket: ""
});

var bucket = admin.storage().bucket();

function createServer() {
    const server = new grpc.Server()
    server.addService(protoDescriptor.Mega.Bim.Items.service, { sendItems })
    server.bind('0.0.0.0:50051', grpc.ServerCredentials.createInsecure());
    server.start()
    console.log("Server runnin on port 50051")

    function sendItems(call, callback) {
        call.on('data', (item) => console.log(item))
        call.on('end', () => callback(null, "Ok"))
    }
}

async function createClient() {
    var client = new protoDescriptor.Mega.Bim.Items('localhost:50051', grpc.credentials.createInsecure());

    callSendItems()

    function callSendItems() {
        let call = client.sendItems((error, result) => console.log(error, result))

        call.write({ id: "1", family: "wall", category: "brick wall" })
        call.write({ id: "2", family: "wall", category: "dry wall" })
        call.end()
    }
}

async function downloadFile() {
    try {
        var config = {
            action: 'read',
            expires: '03-17-2025'
        };
        let file = await bucket.file("download.png")
        //console.log(file)
        await file.getSignedUrl(config, (err, url) => {
            console.log(url)
            // request(url, function(err, resp) {
            //     console.log(err, resp)
            //   });
        });
    } catch (error) {
        console.log(error)
    }
}

downloadFile()

/*createServer()
createClient()*/