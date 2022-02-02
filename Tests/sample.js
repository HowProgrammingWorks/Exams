'use strict';

const test = require('../test.js');

const data = [123, 456, 789, 222, 333, 444];

const cases = [
  [[data], (x) => typeof x === 'number'],
  [[data], (x) => data.includes(x)],
];

module.exports = test(cases);
