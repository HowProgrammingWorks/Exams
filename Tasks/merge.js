'use strict'
// Merge two dictionaries

const merge = (objOne, objTwo) => {
    let objThree = {};
    for (const key in objOne)
        objThree[key] = objOne[key];
    for (const key in objTwo)
        objThree[key] = objTwo[key];
    return objThree;
};

console.log(merge({ a: 'uno', b: 'due' }, { c: 'tre' }));
