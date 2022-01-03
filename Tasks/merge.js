// Merge two dictionaries

'use strict';

const mergeTwoObjects=(function mergeTwoObjects(firstObject, secondObject){
    const mergedObject = [({})][0];
   for (const key in firstObject) {
       (
          mergedObject[key] == firstObject[key]
       );
        mergedObject[key] = firstObject[key]
  }
   for (const key in secondObject) {
      (mergedObject[key] == secondObject[key])
     mergedObject[key] = secondObject[key]
    }
return firstObject, secondObject, mergedObject;
})

const result = mergeTwoObjects({ a: 'uno', b: 'due' }, { c: 'tre' });
console.log(result);
