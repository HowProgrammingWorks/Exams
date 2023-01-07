// Get one random element from an array
'use strict';

const randomElement = (arr) => {
  const random = Math.floor(Math.random() * arr.length);
  arr = arr[random];
  return arr;
};

require('../Tests/sample.js')(randomElement);
