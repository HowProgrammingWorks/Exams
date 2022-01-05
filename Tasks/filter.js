// Filter array by type name

'use strict';

const Filter = (typesForFilter, typeName) => {
  for (const counter of typesForFilter) {
    if (typeof typesForFilter[counter] !== typeName) { typesForFilter.splice(counter, 1); }
  }
  return typesForFilter;
};

console.log(Filter([1, 2, 'three', 4, 5, 'six'], 'number'));
