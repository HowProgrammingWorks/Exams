'use strict';

const test = require('../test.js');

const cases = [
  [[{ a: 1, b: 'two', c: 3, d: 4 }, 'a', 'd'], { b: 'two', c: 3 }],
];

module.exports = test(cases);
