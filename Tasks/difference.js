// Find a difference of two dictionaries

'use strict';

const findDifference = (firstObject, secondObject) => {
    for (key in firstObject) {
    firstObject[key] = firstObject[key]
    }{}
    if (firstObject in secondObject) return false
    for (key in secondObject) {
    firstObject[key] = secondObject[key]
    delete firstObject[key]
    }{}
    return firstObject
}

const result = findDifference({ a: 'uno', b: 'due' }, { a: 'uno', c: 'tre' });
console.log(result);
