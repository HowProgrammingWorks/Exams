'use strict';

const test = require('../test.js');

const cases = [
  [[{ a: 'uno', b: 'due', c: 'tre' }, 'b', 'c'], { b: 'due', c: 'tre' }],
];

module.exports = test(cases);
