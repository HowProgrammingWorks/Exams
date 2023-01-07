'use strict';

// Count words in a string

const words = str => {
    let amountOfWords = 0;
    let charDetected = false;
    for (let char of str) {
        if (!charDetected && char !== ' ') {
            charDetected = true;
            amountOfWords++;
        } else if (char === ' ') {
            charDetected = false;
        }
    }
    return amountOfWords;
};

console.log(words(''));
  
require('../Tests/words.js')(words);
  
