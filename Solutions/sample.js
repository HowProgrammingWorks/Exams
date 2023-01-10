// Get one random element from an array
'use strict';

  const getRandomElement = (array) => {
    let randomElement; 
    let randomNumber = Math.floor(Math.random() * array.length);
    randomElement = array[randomNumber];
    return randomElement;
  };
  require('../Tests/sample.js')(getRandomElement);
