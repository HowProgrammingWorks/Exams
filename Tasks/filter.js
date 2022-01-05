// Filter array by type name

'use strict';

const filter = (typesForFilter, typeName) => {
  for (const arrayElement of typesForFilter) {
    if (typeof typesForFilter[arrayElement] !== typeName) { typesForFilter.splice(arrayElement, 1); }
  }
  return typesForFilter;
};

console.log(filter([1, 2, 'three', 4, 5, 'six'], 'number'));
