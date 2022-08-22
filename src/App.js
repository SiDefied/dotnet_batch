import logo from './icons8-github.svg';
import './App.css';
import Car from './Car';

function App() {
  return (
    <div className="App">
      <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />
        <p>
          Welcome to "myreactapp" this is edited text.
        </p>
        <a
          className="App-link"
          href="https://github.com/SiDefied"
          target="_blank"
          rel="noopener noreferrer"
        >
          Open Github
        </a>
      </header>

      <AppChild name="Shivtej"/>
    </div>
  );
}
function AppChild(props)
{
  return(
    <span>My name is {props.name} and my car is {Car.props}</span>
  );
}

export default App;
