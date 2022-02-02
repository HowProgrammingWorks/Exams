'use strict';

const test = require('../test.js');

const cases = [
  [[{ a: 1, c: 'hello' }, { a: 1, c: 'hello' }], true],
  [[{ a: 1, c: 'hello' }, { a: 2, c: 'hello' }], false],
  [[{ a: 2, c: 'hello' }, { a: 1, c: 'hello' }], false],
  [[{ a: 1, c: 'helo' }, { a: 1, c: 'hello' }], false],
  [[{ a: 1, c: 'hello' }, { a: 1, c: 'helo' }], false],
  [[{ c: 'hello', a: 1 }, { a: 1, c: 'hello' }], false],
  [[{ a: 1, c: 'hello' }, { c: 'hello', a: 1 }], false],
];

module.exports = test(cases);
