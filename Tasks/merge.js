// Merge two dictionaries

'use strict';

const mergeTwoObjects = (firstObject, secondObject) => {
    const mergedObject = {};
   for (const key in firstObject) {
        mergedObject[key] = firstObject[key]
  }
   for (const key in secondObject) {
     mergedObject[key] = secondObject[key]
    }
return mergedObject;
}

const result = mergeTwoObjects({ a: 'uno', b: 'due' }, { c: 'tre' });
console.log(result);
