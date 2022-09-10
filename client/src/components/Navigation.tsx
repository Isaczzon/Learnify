import React from 'react';
import * as FaIcons from "react-icons/fa";
import Logo from "../Assets/logo.png";

const Navigation = () => {
    return (
        <div className="nav-container">
            <div className="nav">
                <div className="nav__left">
                    <img className="nav__left__logo" src={Logo} alt="Logo" />
                    <ul className="nav__left__list">
                        <div className="nav__left__list__item">Categories</div>
                        <div className="nav__left__list__item">Courses</div>
                    </ul>
                </div>
                <div className="nav__right">
                    <form className="nav__right__search">
                        <input 
                        type="text" 
                        className="nav__right__search__input"
                        placeholder="Search Courses..."
                        />
                        <button title="button" type="button" className="nav__right__search__button">
                            <FaIcons.FaSearch />
                        </button>
                    </form>
                </div>
            </div>
        </div>
    );
};

export default Navigation;