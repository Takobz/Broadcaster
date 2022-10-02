import { HubConnectionBuilder, LogLevel } from "@microsoft/signalr";

const SignalrDatabaseHelper = () => {
  const portnumber = process.env.REACT_APP_SERVER_PORT;
  const connection = new HubConnectionBuilder()
    .withUrl(`https://localhost:${portnumber}/hubs/realtime-database`)
    .configureLogging(LogLevel.Information)
    .build();

  return connection
};

export default SignalrDatabaseHelper;
