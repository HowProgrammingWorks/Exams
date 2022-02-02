'use strict';

const test = require('../test.js');

const cases = [
  [[0, 10], (x) => x >= 0 && x <= 10],
  [[-10, 10], (x) => x >= -10 && x <= 10],
  [[1, 1], (x) => x === 1],
];

module.exports = test(cases);
