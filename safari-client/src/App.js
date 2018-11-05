import React, { Component } from "react";
import logo from "./logo.svg";
import "./App.css";

class App extends Component {
  state = {
    SafariVacation: []
  };
  componentDidMount() {
    fetch("http://localhost:5001/api/SafariVacation")
      .then(resp => resp.json()) //not sure this is linking to my safari database
      .then(json => {
        this.setState({ SafariVacation: json });
      });
  }
  handleSearchTermUpdate = e => {
    //not sure the button works either
    this.setState({
      term: e.target.value
    });
  };

  search = e => {
    e.preventDefault();
    fetch(`http://localhost:5000/api/search?name=${this.state.term}`)
      .then(resp => resp.json())
      .then(json => {
        this.setState({
          courses: json
        });
      });
  };

  render() {
    return (
      <div className="App">
        <header>My safari looked like:</header>
        <section>
          <form onSubmit={this.search}>
            <input type="search" placeholder="search for an animal..." />
            <button> Search</button>
          </form>
        </section>

        <ul>
          {this.state.SafariVacation.map(SafariVacation => {
            return (
              <li key={SafariVacation.Id}>
                {SafariVacation.Species}, {SafariVacation.CountOfTimesSeen},{" "}
                {SafariVacation.LocationOfLastSeen}
              </li>
            );
          })}
        </ul>
      </div>
    );
  }
}

export default App;
