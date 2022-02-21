import React, { Component } from 'react';
import { NavMenu } from './NavMenu';
import { Container } from 'reactstrap';
import CategoryMenu from "./CategoryMenu";

export class Layout extends Component {
  static displayName = Layout.name;

  render() {
    console.log('props')
    console.log(this.props.children)
    return (
      <div>
        <NavMenu />
        <div className='container justify-content-center d-flex h-100'>
          <div className="row align-self-center w-100 h-100 border">
            <div className="col-2">
              <CategoryMenu />
            </div>
            <div className="col-8">
              <Container>
                {this.props.children}
              </Container>
            </div>

          </div>
        </div>
      </div>
    );
  }
}
 // Imported