// Sum all numbers from array
'use strict'
const sumNumbers = (array) => {
  let calcResult = 0
  for ( const value of array) {
  const type = typeof value;
  if (type === 'number'){
    calcResult += value
    }
  }
  return calcResult
  };

const result = sumNumbers([5, true, 'string', 7, 'hello']);
console.log(result);
