import React from 'react';
import { Redirect } from 'react-router';
import {
	BrowserRouter as Router,
	Switch,
	Route,
	Link
} from "react-router-dom";

function SongDetails(props) {

    var songDetails = props.location.props.song
    return (
        <div> Soong Details
            <h2 className="SongTitle">{songDetails.name}</h2>
            <h3>Lyrics:</h3>
            <p className="Lyrics">{songDetails.lyrics}</p>

            <form onSubmit={PurchaseSong} action="/">
                <input type="text" id="emailInput" />
                <input type="hidden" name="price" value={songDetails.price} />
                <input type="hidden" name="songId" value={songDetails.id} />
                <input type="submit" value="Submit"/>
            </form>

        </div>
    )
}

function PurchaseSong() {
    var emailInput = document.querySelector("#emailInput")
    console.log(emailInput);
    //You would submit to an API/payment provider to complete purchase here
    //You would move to a confirmation page
}

export default SongDetails;