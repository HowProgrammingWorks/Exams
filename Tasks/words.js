'use strict';

// Count words in a string

let words = str => {
    let amountOfWords = 0;
    let flag = false;
    for (char of str) {
        if (!flag && char !== ' ') {
            flag = true;
            amountOfWords++;
        } else if (char === ' ') {
            flag = false;
        };
    };
    return amountOfWords;
};
  
require('../Tests/words.js')(words);
  
