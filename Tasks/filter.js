// Filter array by type name

'use strict';

const Filter = (typesForFilter, typeName) => {
  for (let counter of typesForFilter) {
    let index = typesForFilter.indexOf(counter);
    if (typeof typesForFilter[index] !== typeName) { typesForFilter.splice(index, 1); }
  }
  return typesForFilter;
};
  
const result = Filter([1, 2, 'three', 4, 5, 'six'], 'number');
console.log(result);
