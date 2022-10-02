import React, { useEffect, useState } from "react";
import SignalrDatabaseHelper from "../helpers/SignalrDatabaseHelper";
import Form from "./Form";

const ListenToDatabse = () => {
  const [connection, setConnection] = useState(SignalrDatabaseHelper());

  useEffect(() => {
    if (connection) {
      connection.start().then(() => {
        console.log("Contected to Hub");

        connection.on("TableChanged", (tableName) => {
          alert(`The table with name: ${tableName} was changed`);
        });
      }).catch(e => console.log('Connect Error', e));
    }
  }, [connection]);

  return (
    <>
      <Form connection={connection} />
    </>
  );
};

export default ListenToDatabse;
