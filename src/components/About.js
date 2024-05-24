
import Navigation from './Navigation';
import './About.css'; // Import the custom CSS file
import React, { useState } from 'react';

function About() {
  const [showContactDetails, setShowContactDetails] = useState(false);

  const toggleContactDetails = () => {
    setShowContactDetails(!showContactDetails);
  };
  return (
    <div className="about-container">
      <Navigation />
      <div className="about-background-image"></div>
      <div className="about-content">
        
        <div className="about-box">
          <h1 className="about-title">About Our Home Harbor</h1>
          <div className="about-text">
            <p>
              We are a dedicated team of professionals offering top-notch home
              services. Our services range from cleaning, plumbing, electrical
              work, to gardening and more. We are committed to providing
              high-quality services to ensure customer satisfaction.
            </p>
            <p>
              With years of experience in the industry, we understand the needs of
              our customers and strive to provide personalized services to suit
              each client's unique requirements. Our team is highly trained and
              equipped with the latest tools to deliver efficient and reliable
              home services.
            </p>
            <p>
              Contact us today to learn more about our services and how we can make
              your life easier!
            </p>
          </div>
          <button className="contact-btn" onClick={toggleContactDetails}>
            {showContactDetails ? 'Hide Contact' : 'Contact Us'}
          </button>
          {showContactDetails && (
            <div className="contact-details">
              <h2>Contact Us</h2>
              <p>Phone: 123-456-7890</p>
              <p>Email: info@homeservices.com</p>
              <p>Address: 123 Main Street, Chennai</p>
            </div>
          )}
        </div>
      </div>
    </div>
  );
}

export default About;