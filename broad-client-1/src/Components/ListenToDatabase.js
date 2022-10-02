import React, { useEffect, useState } from 'react'
import SignalrDatabaseHelper from '../helpers/SignalrDatabaseHelper'

const ListenToDatabse = () => {
    const [connection, setConnection] = useState(null);

    useEffect(() =>{
        SignalrDatabaseHelper();
    });
}

export default ListenToDatabse;