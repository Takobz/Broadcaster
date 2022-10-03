import React, { useState, useRef } from "react";
import BroadNetService from "../Services/BroadNetService"

const Form = (props) => {
  const userInputRef = useRef();

  const handleSubmit = (event) => {
    event.preventDefault();
    const userInput = userInputRef.current.value;
    BroadNetService(userInput).then(result => {
        console.log(result);
    }).catch(e => console.error(e))
    userInputRef.current.value = '';
  };
  
  return (
    <form onSubmit={handleSubmit}>
      <label style={{margin: '10px'}} htmlFor="dataInput">Insert Here:</label>
      <br />
      <input
        type="text"
        name="dataInput"
        style={{margin: '10px'}}
        ref={userInputRef}
      />
      <br />
      <button style={{margin: '10px'}} type="submit">Send</button>
    </form>
  );
};

export default Form;
