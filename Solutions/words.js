'use strict'

const Words = (s) => {
  let wordCounter = 0;
  if(s !== '') wordCounter++;
  for (const c of s) {
    if (c === ' ') wordCounter++;
  }
  return wordCounter;
};

require('../Tests/words.js')(Words);
