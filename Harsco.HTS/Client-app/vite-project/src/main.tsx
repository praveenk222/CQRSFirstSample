import React from 'react'
import ReactDom from 'react-dom/client'
import './app/layout/style.css'
import App from './app/layout/App'
import { BrowserRouter } from 'react-router-dom';

import 'semantic-ui-css/semantic.min.css'
ReactDom.createRoot(document.getElementById('root')!).render(
  <React.StrictMode>
    <BrowserRouter>
    <App />
    </BrowserRouter>
  </React.StrictMode>,
)
