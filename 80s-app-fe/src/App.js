import './css/App.css';
import React, { useEffect, useState } from 'react';
import {
	BrowserRouter as Router,
	Switch,
	Route,
	Link
} from "react-router-dom";

import Home from "./Components/Home";
import MusicListing from "./Components/MusicListing";
import NavBar from "./Components/Navbar";
import SongDetails from './Components/SongDetails';

const BaseApiUrl = "https://localhost:44306/api/"

function App() {
	const [error, setError] = useState(null);
	const [isLoaded, setIsLoaded] = useState(false);
	const [songs, setSongs] = useState([]);
	var requestUrl = BaseApiUrl + 'Song';

	useEffect(() => {
		fetch(requestUrl, {
			mode: "cors",
			method: 'GET',
			headers: {
				"Accept": "application/json"
			}
		})
			.then(res => res.json())
			.then((result) => {
				console.log(result);
				setSongs(result);
				setIsLoaded(true);
			},
				(error) => {
					setIsLoaded(true);
					setError(error);
				})
	}, [])


	return RenderPage(songs);
}

function RenderPage(songs){
	return (
		<main>
			<NavBar />
			<Switch>
				<Route exact path="/" component={Home} />
				<Route exact path="/MusicListing" component={() => <MusicListing songs={songs} />} />
				<Route name="songDetails" path="/SongDetails" component={SongDetails} />
			</Switch>
		</main>
	);
}


export default App;
