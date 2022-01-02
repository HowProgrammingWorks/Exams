// Merge two dictionaries
'use strict';
const mergeTwoObj = (obj1, obj2) => ({...obj1, ...obj2});

const result = mergeTwoObj({ a: 'uno', b: 'due' }, { c: 'tre' });
console.log(result);
