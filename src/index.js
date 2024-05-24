import React from 'react';
import ReactDOM from 'react-dom/client';
import './index.css';
import App from './App';
import reportWebVitals from './reportWebVitals';

const root = ReactDOM.createRoot(document.getElementById('root'));   
//It creates a root for your application on the DOM node passed into it (document.getElementById('root') in this case).


//This is where your React application starts rendering.
// It takes a React element and renders it into the root DOM node
root.render(
  <React.StrictMode> 
    <App />
  </React.StrictMode>
);
 //  checks for potential problems in the application during the development build



// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();
