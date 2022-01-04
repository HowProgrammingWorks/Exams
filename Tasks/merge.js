'use strict';
// Merge two dictionaries

const mergeTwoObjects = (object1, object2) => ({ ...object1, ...object2 });

const result = mergeTwoObjects({ a: 'uno', b: 'due' }, { c: 'tre' });
console.log(result);
