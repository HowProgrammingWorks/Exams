'use strict';

const test = require('../test.js');

const cases = [
  [[{ a: 'uno', b: 'due' }, { a: 'uno', c: 'tre' }], { a: 'uno' }],
  [[{ a: 'uno', b: 'due' }, { a: 1, c: 2 }], {}],
  [[{ a: 1, b: 2 }, { a: 'uno', c: 'tre' }], {}],
  [[{ a: 1, b: 2 }, { a: 1, c: 2 }], { a: 1 }],
  [[{ a: 2, b: 1 }, { a: 2, c: 1 }], { a: 2 }],
];

module.exports = test(cases);
