import React, { useState } from "react";
import BroadNetService from "../Services/BroadNetService"

const Form = (props) => {
  const [value, setValue] = useState("");

  const handleSubmit = (event) => {
    event.preventDefault();
    BroadNetService().then(result => {
        console.log(result);
    }).catch(e => console.error(e))
  };

  const handleChange = (event) => {
    if (event) {
      setValue(event.target.value);
    }
  };
  
  return (
    <form onSubmit={handleSubmit}>
      <label style={{margin: '10px'}} htmlFor="dataInput">Insert Here:</label>
      <br />
      <input
        type="text"
        value={value}
        onChange={handleChange}
        name="dataInput"
        style={{margin: '10px'}}
      />
      <br />
      <button style={{margin: '10px'}} type="submit">Send</button>
    </form>
  );
};

export default Form;
