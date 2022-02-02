'use strict';

const test = require('../test.js');

const cases = [
  [[{ a: 'uno', b: 'due', c: 'tre' }, 'b', 'c'], { b: 'due', c: 'tre' }],
  [[{ a: 1, b: 2, c: 3 }, 'b', 'c'], { b: 2, c: 3 }],
  [[{ a: 'uno', b: 'due', c: 'tre' }, 'x'], {}],
  [[{ a: 'uno', b: 'due', c: 'tre' }], {}],
];

module.exports = test(cases);
