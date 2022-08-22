import logo from './table.png';
import './App.css';

function App() {
  return (
    <div className="App">
      <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />
        <p>
          The best tables are available here!!
        </p>
        <a
          className="App-link"
          href="https://www.ikea.com/in/en/p/sandsberg-table-black-s09420394/?utm_source=google&utm_medium=surfaces&utm_campaign=shopping_feed&utm_content=free_google_shopping_clicks%20_Dining&region_id=598598&gclid=EAIaIQobChMIzcG5nona-QIV0a2WCh3nyQ8gEAQYAiABEgK5n_D_BwE"
          target="_blank"
          rel="noopener noreferrer"
        >
          Buy a table
        </a>
      </header>
    </div>
  );
}

export default App;
