const connection = new signalR.HubConnectionBuilder()
.withUrl("/chat")
.build();

async function connect()
{
    await connection.start();
    console.log("Connected!");
    
    await connection.invoke("Echo", "Hello SignalR!");
}

connect();