'use strict';

const test = require('../test.js');

const cases = [
  [[{ a: 'uno', b: 'due', c: 'tre' }, 'b', 'f'], { a: 'uno', c: 'tre' }],
  [[{ a: 'uno', b: 'due', c: 'tre' }], { a: 'uno', b: 'due', c: 'tre' }],
  [[{ a: 'uno', b: 'due' }, 'x', 'y'], { a: 'uno', b: 'due' }],
  [[{ a: 'uno', b: 'due' }, 'b', 'a'], {}],
];

module.exports = test(cases);
