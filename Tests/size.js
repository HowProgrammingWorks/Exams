'use strict';

const test = require('../test.js');

const cases = [
  [[0], '0 byte'],
  [[1], '1 byte'],
  [[12], '12 byte'],
  [[123], '123 byte'],
  [[1234], '1 kb'],
  [[12345], '12 kb'],
  [[123456], '123 kb'],
  [[1234567], '1 mb'],
  [[12345678], '12 mb'],
  [[123456789], '123 mb'],
  [[1234567890], '1 gb'],
];

module.exports = test(cases);
