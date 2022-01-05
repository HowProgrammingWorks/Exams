// Filter array by type name

'use strict';

const Filter = (typesForFilter, typeName) => {
  for (const counter of typesForFilter) {
    const index = typesForFilter.indexOf(counter);
    if (typeof typesForFilter[index] !== typeName) { typesForFilter.splice(index, 1); }
  }
  return typesForFilter;
};

console.log(Filter([1, 2, 'three', 4, 5, 'six'], 'number'));
