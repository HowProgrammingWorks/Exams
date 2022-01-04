// Finde a difference of two dictionaries
'use strict';

const diff = (objectFirst, objectSecond) => {
  const objectDiff = { ...objectFirst };
  const arrayOfKeys = Object.keys(objectSecond);
  for (const attributeName of arrayOfKeys) {
    const valueObjFirst = objectFirst[attributeName];
    const valueObjSecond = objectSecond[attributeName];
    if (valueObjFirst) {
      if (valueObjFirst === valueObjSecond) {
        delete objectDiff[attributeName];
      }
    }
  }
  return objectDiff;
};

const result = diff({ a: 'uno', b: 'due' }, { a: 'uno', c: 'tre' });
console.log(result);
