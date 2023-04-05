import React from 'react';
import { Link } from 'react-router-dom';

function MyPodcasts() {
  // Use the Link component to redirect to an external website
  return (
    <>
      <h4>These are my super awesome podcasts</h4>
      <Link
        to="https://baconsale.com/"
        target="_blank"
        rel="noopener noreferrer"
      >
        Visit the Site Here
      </Link>
    </>
  );
}

export default MyPodcasts;
