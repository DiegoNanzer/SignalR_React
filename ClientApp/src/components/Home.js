import React, { Component } from 'react'
import StartProcess from './StartProcess'
import Status from './Status'

export class Home extends Component {
  static displayName = Home.name;

  render() {
    return (
      <div>
        <h1>Lets Call remote Process and send info to all clients </h1>
        <StartProcess></StartProcess>
        <Status></Status>
      </div>
    );
  }
}
