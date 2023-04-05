import React from 'react';
import { Outlet } from 'react-router-dom';
import MyNavbar from './navbar';

const Layout = () => {
  return (
    <>
      <MyNavbar />
      <Outlet />
    </>
  );
};

export default Layout;
