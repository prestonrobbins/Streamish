import React from "react";
import Video from "./video"

const SearchCard = ({ videoResult }) => {
    return (
        <div>
            <Video video={videoResult} /> 
        </div>
    );
};
export default SearchCard;