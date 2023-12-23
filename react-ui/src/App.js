
import { BrowserRouter, Route, Routes } from '../../../../../node_modules/react-router-dom/index';
import './App.css';

function App() {
    return (
        <BrowserRouter>
            <Routes>
                <Route path="/login" element={<div>Login</div> }/>
                <Route path="/login" element={<div>Login</div>} />
            
                <Route path="/" element={<div>Home</div>}></Route>
            </Routes>
        </BrowserRouter>
      
  );
}

export default App;
