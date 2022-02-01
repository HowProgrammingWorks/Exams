'use strict';

const test = require('../test.js');

const cases = [
  [[{ a: 1, c: 'hello' }, { a: 1, c: 'hello' }], true],
];

module.exports = test(cases);
