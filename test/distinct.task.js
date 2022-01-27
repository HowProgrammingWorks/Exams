'use strict';

const assert = require('node:assert/strict');
const distinct = require('../Tasks/distinct');

const ERR_FUNCTION_NOT_IMPORTED = 'The function is expected';

const testCases = [
  { input: [[1, 2, 1, 3, 1, 4]], expected: [1, 2, 3, 4] },
  { input: [[4, 6, 2, 6, 2]], expected: [4, 6, 2] },
];

assert.equal(typeof distinct, 'function', ERR_FUNCTION_NOT_IMPORTED);

for (const testCase of testCases) {
  assert.deepStrictEqual(distinct(...testCase.input), testCase.expected);
}

console.log('[Distinct] Tests passed successfully');
