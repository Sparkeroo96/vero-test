import React from 'react';
import SongComponent from './SubComponents/SongComponent';

function MusicListing(props) {

    console.log("songs ")
    console.log(props.songs);

    let songComponents = props.songs.map( song =>
        <SongComponent key={song.id} song={song}/>
    )
    return (
        <div>
            {songComponents}
        </div>
        )
}


export default MusicListing;