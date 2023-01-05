'use strict';

const test = require('../test.js');

const cases = [
  [[['Roma', 'Kiev', 'Beijing', 'Barcelona', 'Omsk']], 'Barcelona'],
  [[['Barcelona', 'Roma', 'Kiev', 'Beijing', 'Omsk']], 'Barcelona'],
  [[['Roma', 'Kiev', 'Beijing', 'Omsk', 'Barcelona']], 'Barcelona'],
  [[['Roma', 'Kiev', 'Omsk']], 'Roma'],
  [[['Roma']], 'Roma'],
  [[['']], 'Not found'],
];

module.exports = test(cases);
