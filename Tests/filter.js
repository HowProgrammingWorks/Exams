'use strict';

const test = require('../test.js');

const cases = [
  [[[1, 2, 'three', 4, 5, 'six'], 'number'], [1, 2, 4, 5]],
];

module.exports = test(cases);
