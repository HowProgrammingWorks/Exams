// Count types in array
'use strict'

const typeCounter = array => {
  let typesList = {
    "number": 0,
    "string": 0,
    "boolean": 0,
  }
  for (i of array) {
    const t = typeof i
    typesList[t]++
  }
  return typesList
}

const result = typeCounter([5, true, 'string', 7, 'hello']);
console.log(result);
