'use strict';

const test = require('../test.js');

const cases = [
  [[{ a: 'uno', b: 'due' }, { a: 'uno', c: 'tre' }], { b: 'due' }],
];

module.exports = test(cases);
