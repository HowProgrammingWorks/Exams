// Filter array by type name

'use strict';

const Filter = (typesForFilter, typeName) => {
  for (const arrayElement of typesForFilter) {
    if (typeof typesForFilter[arrayElement] !== typeName) { typesForFilter.splice(arrayElement, 1); }
  }
  return typesForFilter;
};

console.log(Filter([1, 2, 'three', 4, 5, 'six'], 'number'));
