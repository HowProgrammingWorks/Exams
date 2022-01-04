// Finde a difference of two dictionaries
'use strict';

const diff = (objectFirst, objectSecond) => {
  if (objectFirst in objectSecond) return false;
  for (const attributeName in objectSecond) {
    objectFirst[attributeName] = objectSecond[attributeName];
    delete objectFirst[attributeName];
  }
  return objectFirst;
};

const result = diff({ a: 'uno', b: 'due' }, { a: 'uno', c: 'tre' });
console.log(result);
