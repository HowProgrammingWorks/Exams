// Count types in array
'use strict';

const typeCounter = (array) => {
  let typesList = {};
  for (let elem of array) {
    const currentType = typeof elem;
      if (typesList[currentType] === undefined) {
        typesList[currentType] = 1
      } 
      else typesList[currentType]++;
  }
  return typesList;
}

const result = typeCounter([5, true, 'string', 7, 'hello']);
console.log(result);
