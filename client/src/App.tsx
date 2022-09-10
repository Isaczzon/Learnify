import React from 'react';
import {Route, Switch} from 'react-router-dom';
import './App.css';
import DetailPage from './pages/DetailPage';
import Homepage from './pages/Homepage';
import Login from './pages/Login';

function App() {
  return <>
    <Switch>
      <Route exact path="/" component={Homepage} />
      <Route exact path="/login" component={Login} />
      <Route exact path="/detail" component={DetailPage} />
    </Switch>
  </>;
}

export default App;
