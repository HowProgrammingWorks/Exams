'use strict';

const test = require('../test.js');

const data = ['a', 'b', 'c', 'd', 'e'];

const cases = [
  [[data], (arr) => Array.isArray(arr)],
  [[data], (arr) => arr.every((x) => data.includes(x))],
];

module.exports = test(cases);
