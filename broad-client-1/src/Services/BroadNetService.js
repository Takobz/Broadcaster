const sendTableNotification = async (tableName) => {
  try {
    await fetch(
      `https://localhost:${process.env.REACT_APP_SERVER_PORT}/api/notify-all?${tableName}`,
      {
        method: "POST",
      }
    );
  } catch (err) {
    console.error(err);
  }
};

export default sendTableNotification;
