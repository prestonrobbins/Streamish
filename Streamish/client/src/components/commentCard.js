import React from "react";
import { Card, CardBody } from "reactstrap";

const Comment = ({ comment }) => {
  return (
    <Card >
      <p className="text-left px-2">Posted by: {video.userProfile.name}</p>
      <CardBody>
        <iframe className="comment"
          src={video.comment.message}
          title="YouTube video player"
          frameBorder="0"
          allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture"
          allowFullScreen />

        <p>
          <strong>hello</strong>
        </p>
        <p>{video.description}</p>
      </CardBody>
    </Card>
  );
};

export default Video;
