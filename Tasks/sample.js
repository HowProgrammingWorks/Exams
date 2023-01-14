// Get one random element from an array
'use strict';

const randomElement = (arr) => {
  const index = Math.floor(Math.random() * arr.length);
  return arr[index];
};

require('../Tests/sample.js')(randomElement);
