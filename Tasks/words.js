// Count words in a string

'use strict';

const words = (string) => {
  const clearString = string.trim();
  if (clearString === '') {
    return 0;
  }
  const array = clearString.split(' ');
  return array.length;
};

require('../Tests/words.js')(words);
