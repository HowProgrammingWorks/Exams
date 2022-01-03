// Merge two dictionaries
'use strict';
const merge =(object1, object2) => {
    const result = {}; 
    const key1 = Object.keys(object1);
    const key2 = Object.keys(object2);
    for (const key  of key1) {
        result[key] = object1[key]; 
    }
    for (const key of key2) {
        result[key] = object2[key]; 
    }
    return result; 
}

const result = merge({ a: 'uno', b: 'due' }, { c: 'tre' });
console.log(result);
