'use strict'
// Finde a difference of two dictionaries

const diff = (object1,object2) => {
    if (object1 in object2) return false
    for (const name in object2) {
    object_1[name] = object2[name]
    delete object1[name]
    }
    return object1
}

const result = diff({ a: 'uno', b: 'due' }, { a: 'uno', c: 'tre' });
console.log(result);
