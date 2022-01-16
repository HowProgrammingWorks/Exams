'use strict';

const assert = require('node:assert/strict');
const distinct = require('../Tasks/distinct');

const RANDOM_TESTS_SIZE = 30;

const getSolution = array => [...new Set(array)];

const generateRandomArray = () => {
  const array = [];
  const randomLength = Math.floor(Math.random() * 20);
  for (let i = 0; i < randomLength; i++) {
    array.push(Math.floor(Math.random() * 10));
  }
  return array;
};

assert.equal(typeof distinct, 'function');
assert.deepStrictEqual(distinct([1, 2, 1, 3, 1, 4]), [1, 2, 3, 4]);
assert.deepStrictEqual(distinct([4, 6, 2, 6, 2]), [4, 6, 2]);

for (let i = 0; i < RANDOM_TESTS_SIZE; i++) {
  const randomArray = generateRandomArray();
  const expectedAnswer = getSolution(randomArray);
  assert.deepStrictEqual(distinct(randomArray), expectedAnswer);
}

console.log(`[Distinct] Successfully passed ${RANDOM_TESTS_SIZE} random tests`);
