import React, { Component } from 'react';
import { NavMenu } from './NavMenu';
import Body from './Body'

export class Layout extends Component {
  static displayName = Layout.name;

  render () {
    return (
      <div>
        <NavMenu />
        <Body/>
      </div>
    );
  }
}
