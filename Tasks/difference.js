// Finde a difference of two dictionaries
'use strict';

const diff = (objectFirst, objectSecond) => {
  for (const attributeName in objectSecond) {
    const valueObjFirst = objectFirst[attributeName];
    const valueObjSecond = objectSecond[attributeName];
    if (typeof(valueObjSecond) !== 'undefined') {
      if (valueObjFirst === valueObjSecond)
        delete objectFirst[attributeName];
    }
  }
  return objectFirst;
};

const result = diff({ a: 'uno', b: 'due' }, { a: 'uno', c: 'tre' });
console.log(result);
