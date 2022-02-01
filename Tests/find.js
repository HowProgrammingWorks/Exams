'use strict';

const test = require('../test.js');

const cases = [
  [[{ a: 1, b: 2, c: 'hello', d: false }, 'hello'], 'c'],
];

module.exports = test(cases);
