* {
    padding: 0;
    margin: 0;
    box-sizing: border-box;
  }
  body {
    height: 100vh;
    background: linear-gradient(
        135deg,
        #ff8e44,
        #f91362,
        #35126a
    );
  }
  .container {
    width: 90%;
    max-width: 34em;
    position: absolute;
    transform: translate(-50%, -50%);
    top: 50%;
    left: 50%;
  }
  #new-task {
    position: relative;
    background-color: #ffffff;
    padding: 1.8em 1.25em;
    border-radius: 0.3em;
    box-shadow: 0 1.25em 1.8em rgba(1, 24, 48, 0.15);
    display: grid;
    grid-template-columns: 9fr 3fr;
    gap: 1em;
  }
  #new-task input {
    font-family: "Poppins", sans-serif;
    font-size: 1em;
    border: none;
    border-bottom: 2px solid #d1d3d4;
    padding: 0.8em 0.5em;
    color: #111111;
    font-weight: 500;
  }
  #new-task input:focus {
    outline: none;
    border-color: #ff8e44;
  }
  #new-task button {
    font-family: "Poppins", sans-serif;
    font-weight: 500;
    font-size: 1em;
    background-color: #ff8e44;
    color: #ffffff;
    outline: none;
    border: none;
    border-radius: 0.3em;
    cursor: pointer;
  }
  #tasks {
    background-color: #ffffff;
    position: relative;
    padding: 1.8em 1.25em;
    margin-top: 3.8em;
    width: 100%;
    box-shadow: 0 1.25em 1.8em rgba(1, 24, 48, 0.15);
    border-radius: 0.6em;
  }
  .task {
    background-color: #ffffff;
    padding: 0.3em 0.6em;
    margin-top: 0.6em;
    display: flex;
    align-items: center;
    border-bottom: 2px solid #d1d3d4;
    cursor: pointer;
  }
  .task span {
    font-family: "Poppins", sans-serif;
    font-size: 0.9em;
    font-weight: 400;
  }
  .task button {
    color: #ffffff;
    padding: 0.8em 0;
    width: 2.8em;
    border-radius: 0.3em;
    border: none;
    outline: none;
    cursor: pointer;
  }
  .delete {
    background-color: #f91362;
  }
  .edit {
    background-color: #35126a;
    margin-left: auto;
    margin-right: 3em;
  }
  .completed {
    text-decoration: line-through;
  }

  .social-icons {
    display: flex;
    gap: 10px; /* Adjust the gap between social icons */
    position: absolute;
    bottom: 20px; /* Adjust the distance from the bottom */
    z-index: 4;
    left: 46.5%;
  }
  
  .social-icons img {
    width: 40px; /* Adjust the size of the icons */
    height: 40px;
    transition: transform 0.2s ease; /* Add a smooth transition on hover */
  }
  
  .social-icons img:hover {
    transform: translateY(-5px); /* Move the icons up slightly on hover */
  }