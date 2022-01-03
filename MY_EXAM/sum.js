// Sum all numbers from array
'use strict'
function sumNumbers (array) {
  let result = 0
  for (let value of array) {
  let type = typeof value;
  if (type === 'number'){
    result  += value 
  }
  };
  return result
}
const result = sumNumbers([5, true, 'string', 7, 'hello']);
console.log(result);
