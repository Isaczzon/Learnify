import React, {useState, useEffect} from 'react';
import axios from 'axios';
import logo from './logo.svg';
import './App.css';

function App() {
  const [courses, setCourses] = useState([]);

  useEffect(() => {
    axios.get("http://localhost:5000/api/courses").then((response) => { 
      console.log(response)
      setCourses(response.data)
    })
  }, [])

  return (
    <div className="App">
      <ul>
        {courses.map((course: any, index) => {
          return (
            <li key={index}>
              {course.id}
              {course.title}
            </li>
          )
        })}
      </ul>
      {/* <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />
        <p>
          Edit <code>src/App.tsx</code> and save to reload.
        </p>
        <a
          className="App-link"
          href="https://reactjs.org"
          target="_blank"
          rel="noopener noreferrer"
        >
          Learn React
        </a>
      </header> */}
    </div>
  );
}

export default App;
