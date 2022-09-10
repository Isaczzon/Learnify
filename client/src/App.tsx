import React from 'react';
import {Route, Switch} from 'react-router-dom';
import './App.css';
import DetailPage from './sass/pages/DetailPage';
import Homepage from './sass/pages/Homepage';
import Login from './sass/pages/Login';

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
