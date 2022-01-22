// Return an array without duplica
'use strict';

const distinct = (data) => {
  const setOfUniqueElements = new Set(); 
  for (let el of data) {
    if (!setOfUniqueElements.has(el)) {
      setOfUniqueElements.add(el);
    }
  };
  return [...setOfUniqueElements];
};

const result = distinct([1, 2, 1, 3, 1, 4]);
console.log(result);
