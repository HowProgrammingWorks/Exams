'use strict';

const test = require('../test.js');

const cases = [
  [[{ a: 'uno', b: 'due' }, { a: 'uno', c: 'tre' }], { b: 'due' }],
  [[{ a: 'uno', b: 'due' }, { a: 'uno', b: 'due' }], {}],
  [[{ a: 'uno', b: 'due' }, { a: 'uno', b: 'due', c: 'tre' }], {}],
  [[{ a: 'uno', b: 'due' }, { a: 'uno1', b: 'due' }], {}],
  [[{ a: 'uno1', b: 'due' }, { a: 'uno', b: 'due' }], {}],
];

module.exports = test(cases);
