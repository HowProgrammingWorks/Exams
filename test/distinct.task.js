'use strict';

const assert = require('node:assert/strict');
const distinct = require('../Tasks/distinct');

assert.equal(typeof distinct, 'function');
assert.deepStrictEqual(distinct([1, 2, 1, 3, 1, 4]), [1, 2, 3, 4]);
assert.deepStrictEqual(distinct([4, 6, 2, 6, 2]), [4, 6, 2]);

console.log('[Distinct] Tests passed successfully');
