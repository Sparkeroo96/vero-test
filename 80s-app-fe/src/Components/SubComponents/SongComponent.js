import React from 'react';
import {
    BrowserRouter as Router,
    Link
} from "react-router-dom";

function SongComponent(props) {

    console.log("Song Id: " + props.song.id)
    return (
        <div className="SongComponet">
            <Link to={{
                pathname: '/SongDetails',
                props: {
                    song: props.song
                }
            }}>
                <h2 className="SongTitle">{props.song.name}</h2>
            </Link>

        </div>
    )
}

export default SongComponent;