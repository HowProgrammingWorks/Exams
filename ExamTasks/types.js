'use strict'

const countTypes = (arr)=> {
 const resultObj = {
  "number": 0,
  "string": 0,
  "boolean": 0,
  }
  
  for (const key of arr) {
  const types = typeof key
  resultObj[types]++
  };
  
  return resultObj
}

const result = countTypes([5, true, 'string', 7, 'hello']);
console.log(result);
