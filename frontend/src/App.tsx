import React from 'react';
import './App.css';
import MovieList from './movie/movieList';
import HomePage from './homepage';
import { BrowserRouter, Routes, Route } from 'react-router-dom';
import Layout from './layout';
import MyPodcasts from './myPodcasts';

function App() {
  return (
    <BrowserRouter>
      <Routes>
        <Route path="/" element={<Layout />}>
          <Route index element={<HomePage />} />
          <Route path="movie" element={<MovieList />} />
          <Route path="myPodcasts" element={<MyPodcasts />} />
        </Route>
      </Routes>
    </BrowserRouter>
  );
}

export default App;
