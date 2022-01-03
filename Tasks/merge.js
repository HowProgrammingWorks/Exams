'use strict'
// Merge two dictionaries

const merge = (objOne, objTwo) => Object.assign({}, objOne, objTwo);

console.log(merge({ a: 'uno', b: 'due' }, { c: 'tre' }));
