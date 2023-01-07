// Get one random element from an array
'use strict';

const randomElement = (arr) => {
  arr = arr[Math.floor(Math.random() * arr.length)];
  return arr;
};

require('../Tests/sample.js')(randomElement);
