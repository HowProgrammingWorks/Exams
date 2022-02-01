'use strict';

const test = require('../test.js');

const cases = [
  [[{ a: 'uno', b: 'due', c: 'tre' }], { uno: 'a', due: 'b', tre: 'c' }],
];

module.exports = test(cases);
