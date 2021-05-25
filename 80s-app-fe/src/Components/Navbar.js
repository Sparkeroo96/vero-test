import React from 'react';
import {
    BrowserRouter as Router,
    Link
  } from "react-router-dom";
import '../css/NavBar.css'

class NavBar extends React.Component {

    render() {
        return (
            <div className="Navbar">
                <Link to="/">Home</Link> 
                <Link to="/MusicListing">Song Listings</Link>
            </div>
        );
    }
}

export default NavBar;