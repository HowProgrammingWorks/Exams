// Count words in a string

//Step 4
//Remove recurring ternary operator and useless brackets
//Add arrow function
//Change identifiers case
//Remove `!`, turn all `true` into `false` and vice versa

'use strict';

const Words = (s) => {
  let numberOfWordsInS = 0;
  let flag = true;
  for (const c of s) {
    if (flag) 
      numberOfWordsInS++;
      c === ' ' ? flag = true : flag = false; 
  }
  return numberOfWordsInS;
};

require('../Tests/words.js')(Words);
