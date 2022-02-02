// Get one random element from an array

const SAMPLE = (arr) => {
  arr = arr[Math.floor(Math.random() * arr.length)];
  return arr;
};

require('../Tests/sample.js')(SAMPLE);
