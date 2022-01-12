// Get one random element from array

'use strict';

const SAMPLE = arr => arr[Math.floor(Math.random() * arr.length)];
const result = SAMPLE([123, 456, 789, 222, 333, 444]);
console.log(result);
  