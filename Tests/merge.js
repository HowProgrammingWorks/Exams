'use strict';

const test = require('../test.js');

const cases = [
  [[{ a: 'uno', b: 'due' }, { c: 'tre' }], { a: 'uno', b: 'due', c: 'tre' }],
];

module.exports = test(cases);
