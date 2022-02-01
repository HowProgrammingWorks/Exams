'use strict';

const test = require('../test.js');

const cases = [
  [[3, ['a', 'b', 'c', 'd', 'e']], [['a', 'b', 'c'], ['d', 'e']]],
];

module.exports = test(cases);
