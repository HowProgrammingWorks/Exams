'use strict';
// Count words in a string

const numOfWords = (str) => {
  const isNotBlank = (char) => char !== '';

  return str
    .split(' ')
    .filter(isNotBlank)
    .length;
};

require('../Tests/words.js')(numOfWords);
