const sendTableNotification = async (tableName) => {
  console.log(JSON.stringify({ tableName: tableName }))
  try {
    await fetch(
      `https://localhost:${process.env.REACT_APP_SERVER_PORT}/api/notify-all`,
      {
        method: "POST",
        headers: {
          'Content-Type': 'application/json'
        },
        body: JSON.stringify({ TableName: tableName })
      }
    );
  } catch (err) {
    console.error(err);
  }
};

export default sendTableNotification;
