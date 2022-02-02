'use strict';

const test = require('../test.js');

const cases = [
  [[{ a: 'uno', b: 'due', c: 'tre' }], { uno: 'a', due: 'b', tre: 'c' }],
  [[{ a: 1, b: 2, c: 3 }], { '1': 'a', '2': 'b', '3': 'c' }],
  [[{ a: true, b: false }], { 'true': 'a', 'false': 'b' }],
  [[{ a: 'uno', b: 2, c: false }], { uno: 'a', '2': 'b', 'false': 'c' }],
];

module.exports = test(cases);
