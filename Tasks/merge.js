// Merge two dictionaries

'use strict';

const mergeTwoObjects = (firstObject, secondObject) => ({
    ...firstObject,
    ...secondObject,
});

const result = mergeTwoObjects({ a: 'uno', b: 'due' }, { c: 'tre' });
console.log(result);
