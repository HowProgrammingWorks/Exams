// Count types in array
'use strict'

const typeCounter = array => {
  let typesList = {};
  for (let elem of array) {
    const currentType = typeof elem;
    typesList[currentType]++;
  }
  return typesList;
}

const result = typeCounter([5, true, 'string', 7, 'hello']);
console.log(result);
