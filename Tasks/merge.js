'use strict';
// Merge two dictionaries

const merge = (obj1, obj2) => ({ ...obj1, ...obj2 });

const result = merge({ a: 'uno', b: 'due' }, { c: 'tre' });
console.log(result);
