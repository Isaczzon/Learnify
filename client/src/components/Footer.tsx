import { Row } from "antd";
import React from "react";
import { Link } from "react-router-dom";
import Subscription from "./Subscription";



const Footer = () => {
  
  return (
    <div className="footer-container">
      <div className="footer">
        <div className="footer__left">
          <Row>
            <div className="footer__left__information">
              <div className="footer__left__information__header">
                About us:
                <div className="footer__left__information__specific">
                  Fifth Avenue, New York
                </div>
                <div className="footer__left__information__specific">
                  +123 12 12 33 33
                </div>
                <div className="footer__left__information__specific">
                  info@learnify.com
                </div>
                <div className="footer__left__information__specific">
                  <Link to="/contact">Visit us</Link>
                </div>
                <div className="footer__left__information__specific">
                  <Link to="/contact">Contact us</Link>
                </div>
              </div>
            </div>
          </Row>
        </div>
        <div className="footer__right">
          <Row>
            <div className="footer__right__information">
              <div className="footer__right__information__header">
                Want to know when more of our courses is available?
              </div>
              <div className="footer__right__information__header">
                Subscribe to our newsletter!
              </div>
              <div className="footer__right__information__specific">
                Register here:
              </div>
              <div className="footer__right__information__specific">
                <Subscription>Subscribe</Subscription>
              </div>
            </div>
          </Row>
        </div>
      </div>
    </div>
  );
};

export default Footer;
