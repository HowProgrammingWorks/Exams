'use strict';

const test = require('../test.js');

const cases = [
  [[10, 15], [10, 11, 12, 13, 14, 15]],
  [[-2, 2], [-2, -1, 0, 1, 2]],
  [[2, -2], []],
  [[2, 2], [2]],
  [[0, 0], [0]],
];

module.exports = test(cases);
