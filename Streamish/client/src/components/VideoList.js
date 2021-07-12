import React, { useEffect, useState } from "react";
import Video from './Video';
import { getAllVideosWithComments, videoSearch } from "../modules/VideoManager";

const VideoList = () => {
  const [videos, setVideos] = useState([]);

  const getVideos = () => {
    getAllVideosWithComments().then(videos => setVideos(videos));
  };

  const [search, setSearch] = useState({});

  const searchForVideos = (event) => {
    event.preventDefault();
    videoSearch(search.search)
        .then(res => setVideos(res));
};

const handleInputChange = (event) => {
    let newSearch = { ...search }
    let input = event.target.value;
    console.log(event)
    newSearch[event.target.id] = input;
    setSearch(newSearch);
};

  useEffect(() => {
    getVideos();
  }, []);

  return (
    <div className="container">
      <div className="row justify-content-center">
          <form>
              <input type="text" id="search" className="videoSearch" autoComplete="off" placeHolderText="search for a video" onChange={handleInputChange}/>
              <button type="submit" onClick={searchForVideos}>Search</button>
          </form>
        {videos.map((video) => (
          <Video video={video} key={video.id} />
        ))}
      </div>
    </div>
  );
};

export default VideoList;
