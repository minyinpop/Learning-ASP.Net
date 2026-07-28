import * as signalR from "@microsoft/signalr";

const connection =
    new signalR.HubConnectionBuilder()
        .withUrl("/chat")
        .build();

async function connect()
{
    try
    {
        await connection.start();

        console.log("Connected!");

        await connection.invoke(
            "Echo",
            "Hello ASP.Net Core"
        );
    }
    catch (error)
    {
        console.error(error);
    }
}


connect();